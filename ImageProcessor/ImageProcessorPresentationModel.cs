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

        bool _restoreImageButtonEnabled;
        GeneralModel _generalModel;

        public ImageProcessorPresentationModel(GeneralModel generalModel)
        {
            _restoreImageButtonEnabled = false;
            _generalModel = generalModel;
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
    }
}
