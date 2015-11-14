using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessor
{
    class ImagePreviewerPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Image _pictureBoxImage;
        GeneralModel _generalModel;
        bool _informationLabelVisible;
        Size _formSize;
        Size DEFAULT_FORM_SIZE = new Size(960, 720);
        Size _borderSize;

        public ImagePreviewerPresentationModel(GeneralModel generalModel, Size borderSize)
        {
            _generalModel = generalModel;
            _borderSize = borderSize;
            IsInformationLabelVisible = true;
            if (_generalModel.OriginalImage != null)
                PictureBoxImage = _generalModel.OriginalImage.ToBitmap();
            else
                _pictureBoxImage = null;
            MakeFormSizeFitPicture();
            _generalModel.LoadOrginalImage += this.LoadOriginalImage;
            _generalModel.LoadProcessedImage += this.LoadProcessedImage;
        }

        private void LoadOriginalImage()
        {
            this.PictureBoxImage = _generalModel.OriginalImage.ToBitmap();
            MakeFormSizeFitPicture();
        }

        private void LoadProcessedImage()
        {
            this.PictureBoxImage = _generalModel.ProcessedImage.ToBitmap();
            MakeFormSizeFitPicture();
        }

        private void MakeFormSizeFitPicture()
        {
            if (_generalModel.OriginalImage != null)
            {
                int width = _generalModel.OriginalImage.Width;
                int height = _generalModel.OriginalImage.Height;

                this.FormSize = new Size(width, height);
            }
            else
            {
                IsInformationLabelVisible = true;
                FormSize = DEFAULT_FORM_SIZE;
            }
        }

        public Image PictureBoxImage
        {
            get
            {
                return _pictureBoxImage;
            }
            set
            {
                if (value != _pictureBoxImage)
                {
                    _pictureBoxImage = value;
                    if (_pictureBoxImage != null)
                    {
                        IsInformationLabelVisible = false;
                    }
                    NotifyPropertyChanged();
                }
            }
        }

        public bool IsInformationLabelVisible
        {
            get
            {
                return _informationLabelVisible;
            }
            set
            {
                if (value != _informationLabelVisible)
                {
                    _informationLabelVisible = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Size FormSize
        {
            get
            {
                return _formSize;
            }
            set
            {
                if (value != _formSize)
                {
                    _formSize = value;
                    _formSize = _formSize + _borderSize;
                    NotifyPropertyChanged();
                }
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
