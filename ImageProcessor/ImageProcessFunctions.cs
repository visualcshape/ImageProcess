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

        public Image<Bgr, byte> GetHighBoostFilteredImage(Image<Bgr, byte> sourceImage, int allFactor)
        {
            Image<Bgr, byte> returnImage = new Image<Bgr, byte>(sourceImage.Width, sourceImage.Height);
            int[] firstMatrix = { 0, -1, 0, -1, allFactor + 4, -1, 0, -1, 0 };
            int[] secondMatrix = { -1, -1, -1, -1, allFactor + 8, -1, -1, -1, -1 };

            return returnImage;
        }
    }
}
