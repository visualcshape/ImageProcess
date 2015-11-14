using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Drawing;

namespace ImageProcessor
{
    public class ImageProcessFunctions
    {
        public enum MaskType
        {
            Type1,
            Type2
        }

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

        public Image<Bgr, Byte> GetThresholding(Image<Bgr, Byte> sourceImage, int threshold)
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
                    if (gray >= threshold)
                    {
                        for (int z = 0; z < sourceImage.Data.GetLength(2); z++)
                        {
                            image.Data[y, x, z] = (byte)255;
                        }
                    }
                    else
                    {
                        for (int z = 0; z < sourceImage.Data.GetLength(2); z++)
                        {
                            image.Data[y, x, z] = (byte)0;
                        }
                    }
                }
            }
            return image;
        }

        public Image<Bgr, Byte> GetInverse(Image<Bgr, Byte> sourceImage)
        {
            Image<Bgr, Byte> image = new Image<Bgr, Byte>(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    for (int z = 0; z < sourceImage.Data.GetLength(2); z++)
                    {
                        image.Data[y, x, z] = (byte)(255 - sourceImage.Data[y, x, z]);
                    }
                }
            }
            return image;
        }

        public Image<Bgr, Byte> GetMosaic(Image<Bgr, Byte> sourceImage, int matrixWidthSize, int matrixHeightSize)
        {
            Image<Bgr, Byte> image = new Image<Bgr, Byte>(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y += matrixHeightSize)
            {
                for (int x = 0; x < sourceImage.Width; x += matrixWidthSize)
                {
                    int[] value = new int[sourceImage.Data.GetLength(2)];
                    int n = 0;
                    int i;
                    int my = y - matrixHeightSize / 2;
                    my = Math.Max(my, 0);
                    int mx = x - matrixWidthSize / 2;
                    mx = Math.Max(mx, 0);
                    for (i = 0; i < matrixHeightSize && my + i < sourceImage.Height; i++)
                    {
                        int j;
                        for (j = 0; j < matrixWidthSize && mx + j < sourceImage.Width; j++)
                        {
                            for (int z = 0; z < sourceImage.Data.GetLength(2); z++)
                            {
                                value[z] += sourceImage.Data[my + i, mx + j, z];
                            }
                            n++;
                        }
                    }
                    if (n > 0)
                        for (int z = 0; z < sourceImage.Data.GetLength(2); z++)
                        {
                            value[z] /= n;
                        }
                    for (i = 0; i < matrixHeightSize && my + i < sourceImage.Height; i++)
                    {
                        int j;
                        for (j = 0; j < matrixWidthSize && mx + j < sourceImage.Width; j++)
                        {
                            for (int z = 0; z < sourceImage.Data.GetLength(2); z++)
                            {
                                image.Data[my + i, mx + j, z] = (byte)value[z];
                            }
                        }
                    }
                }
            }
            return image;
        }

        public Image<Bgr, Byte> GetAveraging(Image<Bgr, Byte> sourceImage, int matrixWidthSize, int matrixHeightSize)
        {
            Image<Bgr, Byte> image = new Image<Bgr, Byte>(sourceImage.Width, sourceImage.Height);
            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    int n = 0;
                    int[] value = new int[3];
                    int my = y - matrixHeightSize / 2;
                    my = Math.Max(my, 0);
                    int mx = x - matrixWidthSize / 2;
                    mx = Math.Max(mx, 0);
                    for (int i = 0; i < matrixHeightSize && my + i < sourceImage.Height; i++)
                    {
                        for (int j = 0; j < matrixWidthSize && mx + j < sourceImage.Width; j++)
                        {
                            for (int z = 0; z < sourceImage.Data.GetLength(2); z++)
                            {
                                value[z] += sourceImage.Data[my + i, mx + j, z];
                            }
                            n++;
                        }
                    }
                    n = Math.Max(n, 1);
                    for (int z = 0; z < sourceImage.Data.GetLength(2); z++)
                    {
                        image.Data[y, x, z] = (byte)(value[z] / n);
                    }
                }
            }
            return image;
        }

        public Image<Bgr, byte> GetHighBoostFilteredImage(Image<Bgr, byte> sourceImage, float allFactor, MaskType type)
        {
            Image<Bgr, byte> returnImage = new Image<Bgr, byte>(sourceImage.Width, sourceImage.Height);
            float[,] firstTypeMatrix = new float[3, 3]
            {
                {0, -1, 0},
                { -1, allFactor + 4, -1},
                { 0, -1, 0} 
            };
            float[,] secondTypeMatrix = new float[3, 3]
            {
                {-1, -1, -1},
                { -1, allFactor + 8, -1},
                {-1, -1, -1}
            };

            ConvolutionKernelF matrix = null;
            switch (type)
            {
                case MaskType.Type1:
                    matrix = new ConvolutionKernelF(firstTypeMatrix);
                    break;
                case MaskType.Type2:
                    matrix = new ConvolutionKernelF(secondTypeMatrix);
                    break;
            }

            CvInvoke.Filter2D(sourceImage, returnImage, matrix, new Point(0, 0));

            return returnImage;
        }

        public Image<Bgr, byte> GetSobel(Image<Bgr,byte> sourceImage, int threshold)
        {
            Image<Bgr, byte> result = new Image<Bgr, byte>(sourceImage.Width,sourceImage.Height);

            Image<Gray, byte> graySourceImage = sourceImage.Convert<Gray, byte>();
            Image<Gray, float> sobelX = graySourceImage.Sobel(1, 0, 3);
            Image<Gray, float> sobelY = graySourceImage.Sobel(0, 1, 3);
            sobelX = sobelX.AbsDiff(new Gray(0));
            sobelY = sobelY.AbsDiff(new Gray(0));

            Image<Gray, float> sobel = sobelX + sobelY;
            double[] mins, maxs;
            Point[] minLocation, maxLocation;

            sobel.MinMax(out mins, out maxs, out minLocation, out maxLocation);

            Image<Gray, byte> sobelImage = sobel.ConvertScale<byte>(255 / maxs[0], 0);
            sobelImage._ThresholdBinary(new Gray(threshold), new Gray(255));
            result = sobelImage.Convert<Bgr, byte>();
            return result;
        }

        public Image<Bgr, byte> GetLaplacian(Image<Bgr, byte> sourceImage, int aperture)
        {
            Image<Gray, byte> graySourceImage = sourceImage.Convert<Gray, byte>();

            Image<Gray, float> floatGrayResult = graySourceImage.Laplace(aperture);

            Image<Bgr,byte> result = floatGrayResult.Convert<Bgr, byte>();

            return result;
        }

        public Image<Bgr, byte> GetCanny(Image<Bgr, byte> sourceImage, int thresh, int threshLinking)
        {
            Image<Gray, byte> graySourceImage = sourceImage.Convert<Gray, byte>();
            Image<Gray, byte> cannyImage = graySourceImage.Canny((double)thresh, (double)threshLinking);
            cannyImage._ThresholdBinary(new Gray(125), new Gray(255));
            
            return cannyImage.Convert<Bgr,byte>();
        }
    }
}
