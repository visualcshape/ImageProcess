using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ImageProcessor
{
    class ImageProcessorPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        static ImageProcessorPresentationModel _instance = null;
        bool _restoreImageButtonEnabled;
        bool _openPreviewerButtonEnabled;
        GeneralModel _generalModel;

        public ImageProcessorPresentationModel(GeneralModel generalModel)
        {
            _restoreImageButtonEnabled = false;
            _openPreviewerButtonEnabled = false;
            _generalModel = generalModel;
            _instance = this;
        }

        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public bool IsImageButtonEnabled
        {
            get
            {
                return _restoreImageButtonEnabled;
            }
            set
            {
                if (value != _restoreImageButtonEnabled)
                {
                    _restoreImageButtonEnabled = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool IsOpenPreviewerEnabled
        {
            get
            {
                return _openPreviewerButtonEnabled;
            }

            set
            {
                if (value != _openPreviewerButtonEnabled)
                {
                    _openPreviewerButtonEnabled = value;
                    NotifyPropertyChanged();
                }
            }
        }

        static public ImageProcessorPresentationModel ImageProcesseorPresentationModel
        {
            get
            {
                return _instance;
            }
        }
    }
}
