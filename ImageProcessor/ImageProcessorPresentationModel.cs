using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor
{
    class ImageProcessorPresentationModel
    {
        bool _restoreImageButtonEnabled;
        string _imagePath;

        ImageProcessorPresentationModel()
        {
            _restoreImageButtonEnabled = false;
            _imagePath = "";
        }

        bool IsImageButtonEnabled
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
                }
            }
        }

        string ImagePath
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
                }
            }
        }
    }
}
