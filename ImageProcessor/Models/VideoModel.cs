using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace ImageProcessor
{
    public class VideoModel
    {
        public delegate void LoadVideoEventHandler();
        public event LoadVideoEventHandler LoadVideo;

        public delegate void PlayVideoEventHandler();
        public event PlayVideoEventHandler PlayVideo;

        public delegate void PauseVideoEventHandler();
        public event PauseVideoEventHandler PauseVideo;

        public delegate void StopVideoEventHandler();
        public event StopVideoEventHandler StopVideo;

        Capture _capture;
        bool _isPaused;
        bool _isPlay;
        bool _isStopped;
        string _path;
        string _originalVideoWindowName;
        string _processedVideoWindowName;
        int _frameNumber;
        int _delay;
        IImage _currentFrame;
        IImage _processedFrame;
        ImageProcessFunctions.Methods _processMethod;
        int _intArgument1;
        int _intArgument2;
        float _floatArgument;
        ImageProcessFunctions.MaskType _maskArgument;

        public VideoModel(string originalVideoWindowName = "Original Video" , string processedVideoWindowName = "Processed Video")
        {
            _path = "";
            _originalVideoWindowName = originalVideoWindowName;
            _processedVideoWindowName = processedVideoWindowName;
            _frameNumber = 0;
            _delay = 0;
            _isPaused = false;
            _isPlay = false;
            _isStopped = true;
        }

        public void Play()
        {
            const string HINT_MESSAGE = "等待影片撥放完畢或是按下停止鍵方可選擇其他處理方法。";
            IsPaused = false;
            IsPlay = true;
            _isStopped = false;
            VideoProcessorPresentationModel.Instance.IsProcessedButtonsEnabled = false;
            VideoProcessorPresentationModel.Instance.HintLabelText = HINT_MESSAGE;
            while (!_isPaused && !_isStopped)
            {
                _currentFrame = _capture.QueryFrame();
                if (_currentFrame == null)
                {
                    Stop();
                    break;
                }
                    
                CvInvoke.Imshow(OriginalVideoWindowName, _currentFrame);
                //Process Fuction Here
                _processedFrame = this.SelectProcessMethodAndCompute();
                //
                CvInvoke.Imshow(ProcessedVideoWindowName, _processedFrame);

                CvInvoke.WaitKey(_delay);

                _frameNumber++;
            }
            
        }

        public void Stop()
        {
            const string HINT_MESSAGE = "載入影片後，按下任一影像處理方法鍵便會開始撥放影片。";
            VideoProcessorPresentationModel.Instance.HintLabelText = HINT_MESSAGE;
            _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosAviRatio, 0);
            IsPlay = false;
            IsPaused = false;
            _isStopped = true;
            _frameNumber = 0;
            CvInvoke.Imshow(OriginalVideoWindowName, _capture.QueryFrame());
            CvInvoke.Imshow(ProcessedVideoWindowName, _capture.QueryFrame());
            VideoProcessorPresentationModel.Instance.IsProcessedButtonsEnabled = true;
            StopVideo();
        }

        public void Pause()
        {
            IsPaused = true;
            IsPlay = false;
        }

        public void SetProcessMethod(ImageProcessFunctions.Methods method,int intArgument1 = 0, int intArgument2 = 0, float floatArgument = 0.0f, ImageProcessFunctions.MaskType maskType = ImageProcessFunctions.MaskType.Type1)
        {
            _processMethod = method;
            _intArgument1 = intArgument1;
            _intArgument2 = intArgument2;
            _floatArgument = floatArgument;
            _maskArgument = maskType;
        }

        private Image<Bgr, byte> SelectProcessMethodAndCompute()
        {
            Image<Bgr, Byte> result = null;
            ImageProcessFunctions functions = new ImageProcessFunctions();
            Image<Bgr,byte> sourceImage = new Image<Bgr,byte>(_currentFrame.Bitmap);

            switch (_processMethod)
            {
                case ImageProcessFunctions.Methods.Averaging:
                    result = functions.GetAveraging(sourceImage, _intArgument1, _intArgument2);
                    break;
                case ImageProcessFunctions.Methods.Canny:
                    result = functions.GetCanny(sourceImage, _intArgument1, _intArgument2);
                    break;
                case ImageProcessFunctions.Methods.GrayScale:
                    result = functions.GetGrayScale(sourceImage);
                    break;
                case ImageProcessFunctions.Methods.HighBoost:
                    result = functions.GetHighBoostFilteredImage(sourceImage, _floatArgument, _maskArgument);
                    break;
                case ImageProcessFunctions.Methods.Inverse:
                    result = functions.GetInverse(sourceImage);
                    break;
                case ImageProcessFunctions.Methods.Laplacian:
                    result = functions.GetLaplacian(sourceImage, _intArgument1);
                    break;
                case ImageProcessFunctions.Methods.Mosaic:
                    result = functions.GetMosaic(sourceImage, _intArgument1, _intArgument2);
                    break;
                case ImageProcessFunctions.Methods.Sobel:
                    result = functions.GetSobel(sourceImage, _intArgument1);
                    break;
                case ImageProcessFunctions.Methods.Thresholding:
                    result = functions.GetThresholding(sourceImage, _intArgument1);
                    break;
            }

            return result;
        }

        private void OpenVideoWindows()
        {
            CvInvoke.NamedWindow(OriginalVideoWindowName);
            CvInvoke.NamedWindow(ProcessedVideoWindowName);
        }

        private void CloseVideoWindows()
        {
            CvInvoke.DestroyAllWindows();
        }

        private void EnableButtons()
        {
            VideoProcessorPresentationModel presentationModel = VideoProcessorPresentationModel.Instance;
            presentationModel.IsProcessedButtonsEnabled = true;
        }

        private void ResetAtttributes()
        {
            _frameNumber = 0;
            _delay = 0;
        }

        public string VideoPath
        {
            get
            {
                return _path;
            }
            set
            {
                if (value != _path)
                {
                    if (_capture != null)
                    {
                        this.Stop();
                        CloseVideoWindows();
                    }
                    _path = value;
                    _capture = new Capture(_path);
                    ResetAtttributes();
                    _delay = (int)(1000 / FrameRate);
                    OpenVideoWindows();
                    EnableButtons();
                    if(LoadVideo != null)
                        LoadVideo();
                }
            }
        }

        public string OriginalVideoWindowName
        {
            get
            {
                return _originalVideoWindowName;
            }
            set
            {
                if (value != _originalVideoWindowName)
                {
                    _originalVideoWindowName = value;
                }
            }
        }

        public string ProcessedVideoWindowName
        {
            get
            {
                return _processedVideoWindowName;
            }
            set
            {
                if (value != _processedVideoWindowName)
                {
                    _processedVideoWindowName = value;
                }
            }
        }

        public double FrameRate
        {
            get
            {
                double frameRate = _capture.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps);
                return frameRate;
            }
        }

        public int Delay
        {
            get
            {
                return _delay;
            }
            set
            {
                if (value != _delay)
                {
                    _delay = value;
                }
            }
        }

        public bool IsPlay
        {
            get
            {
                return _isPlay;
            }
            set
            {
                if (value)
                {
                    _isPlay = true;
                    _isPaused = false;
                    if (PlayVideo != null)
                        PlayVideo();
                }
                else
                {
                    _isPlay = false;
                    _isPaused = true;
                }
            }
        }

        public bool IsPaused
        {
            get
            {
                return _isPaused;
            }
            set
            {
                if (value)
                {
                    _isPlay = false;
                    _isPaused = true;
                    if (PauseVideo != null)
                        PauseVideo();
                }
                else
                {
                    _isPlay = true;
                    _isPaused = false;
                }
            }
        }
    }
}
