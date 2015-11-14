using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ImageProcessor
{
    public class ImageProcessorPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        static ImageProcessorPresentationModel _instance = null;
        bool _restoreImageButtonEnabled;
        bool _openPreviewerButtonEnabled;
        bool _processButtonsEnabled;
        ImageProcessFunctions.MaskType _checkedType;
        GeneralModel _generalModel;

        public ImageProcessorPresentationModel(GeneralModel generalModel)
        {
            _restoreImageButtonEnabled = false;
            _openPreviewerButtonEnabled = false;
            _processButtonsEnabled = false;
            _checkedType = ImageProcessFunctions.MaskType.Type1;
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

        public bool IsProcessedButtonsEnabled
        {
            get
            {
                return _processButtonsEnabled;
            }
            set
            {
                if (value != _processButtonsEnabled)
                {
                    _processButtonsEnabled = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ImageProcessFunctions.MaskType CheckedType
        {
            get
            {
                return _checkedType;
            }
            set
            {
                if (value != _checkedType)
                {
                    _checkedType = value;
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
