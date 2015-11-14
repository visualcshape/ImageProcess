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
    public class GeneralModel
    {
        public delegate void LoadOriginalImageEventHandler();
        public event LoadOriginalImageEventHandler LoadOrginalImage;

        public delegate void LoadProcessedImageEventHandler();
        public event LoadProcessedImageEventHandler LoadProcessedImage;

        string _imagePath;
        Image<Bgr, Byte> _originalImage;
        Image<Bgr, Byte> _processedImage;

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
                    _originalImage = new Image<Bgr, Byte>(_imagePath);
                    LoadOrginalImage();
                }
            }
        }

        public void ResetToOriginalImage()
        {
            LoadOrginalImage();
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
                    LoadProcessedImage();
                }
            }
        }
    }
}
