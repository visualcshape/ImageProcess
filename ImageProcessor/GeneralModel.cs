using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor
{
    class GeneralModel
    {
        public delegate void LoadImage();
        public event LoadImage LoadImage;

        string _imagePath;
       

        public GeneralModel()
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
                }
            }
        }

        
    }
}
