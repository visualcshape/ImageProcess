using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV;

namespace ImageProcessor
{
    public class ImageModel
    {
        public delegate void LoadOriginalImageEventHandler();
        public event LoadOriginalImageEventHandler LoadOrginalImage;

        public delegate void LoadProcessedImageEventHandler();
        public event LoadProcessedImageEventHandler LoadProcessedImage;

        public enum ImageState
        {
            Original,
            Processed
        }

        string _imagePath;
        ImageState _imageState;
        Image<Bgr, Byte> _originalImage;
        Image<Bgr, Byte> _processedImage;

        public ImageModel()
        {
            _imagePath = "";
        }

        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                if (value != _imagePath)
                {
                    _imagePath = value;
                    _originalImage = new Image<Bgr, Byte>(_imagePath);
                    _processedImage = new Image<Bgr, Byte>(_imagePath);
                    FireLoadOriginalImageEvent();
                }
            }
        }

        public void ResetToOriginalImage()
        {
            FireLoadOriginalImageEvent();
        }

        private void FireLoadOriginalImageEvent()
        {
            CurrentImageState = ImageState.Original;
            _processedImage = this.OriginalImage;
            LoadOrginalImage();
        }

        private void FireLoadProcessedImageEvent()
        {
            CurrentImageState = ImageState.Processed;
            LoadProcessedImage();
        }

        public Image<Bgr, Byte> OriginalImage
        {
            get
            {
                return _originalImage;
            }
        }

        public Image<Bgr, Byte> ProcessedImage
        {
            get
            {
                return _processedImage;
            }
            set
            {
                if (value != _processedImage)
                {
                    _processedImage = value;
                    FireLoadProcessedImageEvent();
                }
            }
        }

        public ImageState CurrentImageState
        {
            get
            {
                return _imageState;
            }

            set
            {
                if (value != _imageState)
                {
                    _imageState = value;                    
                }
            }
        }
    }
}
