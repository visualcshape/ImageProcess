using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ImageProcessor
{
    public class VideoProcessorPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        static VideoProcessorPresentationModel _instance = null;
        bool _processButtonsEnabled;
        string _hintLabelText;
        ImageProcessFunctions.MaskType _checkedType;

        public VideoProcessorPresentationModel()
        {
            const string DEFAULT_HINT_MESSAGE = "載入影片後，按下任一影像處理方法鍵便會開始撥放影片。";
            _hintLabelText = DEFAULT_HINT_MESSAGE;
            _processButtonsEnabled = false;
            _checkedType = ImageProcessFunctions.MaskType.Type1;
            _instance = this;
        }

        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string HintLabelText
        {
            get
            {
                return _hintLabelText;
            }
            set
            {
                if (_hintLabelText != value)
                {
                    _hintLabelText = value;
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

        static public VideoProcessorPresentationModel Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
