using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ImageProcessor.PresentaionModel
{
    public class VideoControlPanelFormPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        bool _stopButtonEnabled;
        bool _playButtonEnabled;
        bool _pauseButtonEnabled;
        VideoModel _videoModel;
        static VideoControlPanelFormPresentationModel _instance = null;

        public VideoControlPanelFormPresentationModel(VideoModel videoModel)
        {
            _instance = this;
            _videoModel = videoModel;
            _stopButtonEnabled = false;
            _pauseButtonEnabled = false;
            _playButtonEnabled = false;
            _videoModel.PauseVideo += this.ReactPause;
            _videoModel.PlayVideo += this.ReactPlay;
            _videoModel.StopVideo += this.ReactStop;
        }

        private void ReactPlay()
        {
            IsStopButtonEnabled = true;
            IsPauseButtonEnabled = true;
            IsPlayButtonEnabled = false;
        }

        private void ReactPause()
        {
            IsPauseButtonEnabled = false;
            IsPlayButtonEnabled = true;
            IsStopButtonEnabled = true;
        }

        private void ReactStop()
        {
            IsPlayButtonEnabled = false;
            IsPauseButtonEnabled = false;
            IsStopButtonEnabled = false;
        }

        public bool IsStopButtonEnabled
        {
            get
            {
                return _stopButtonEnabled;
            }
            set
            {
                if (value != _stopButtonEnabled)
                {
                    _stopButtonEnabled = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool IsPlayButtonEnabled
        {
            get
            {
                return _playButtonEnabled;
            }
            set
            {
                if (value != _playButtonEnabled)
                {
                    _playButtonEnabled = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool IsPauseButtonEnabled
        {
            get
            {
                return _pauseButtonEnabled;
            }
            set
            {
                if (value != _pauseButtonEnabled)
                {
                    _pauseButtonEnabled = value;
                    NotifyPropertyChanged();
                }
            }
        }

        static public VideoControlPanelFormPresentationModel Instance
        {
            get
            {
                return _instance;
            }
        }

        private void NotifyPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
