using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace ImageProcessor
{
    class ImageProcessFunctions
    {
        public ImageProcessFunctions()
        {

        }

        public Image<Bgr, Byte> GetGrayScale(Image<Bgr, Byte> sourceImage)
        {
            Image<Bgr, Byte> image = new Image<Bgr, Byte>(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    int gray = 0;
                    for (int z = 0; z < sourceImage.Data.GetLength(2); z++)
                    {
                        gray += sourceImage.Data[y, x, z];
                    }
                    gray /= 3;
                    for (int z = 0; z < sourceImage.Data.GetLength(2); z++)
                    {
                        image.Data[y, x, z] = (byte)gray;
                    }
                }
            }
            return image;
        }
    }
}
