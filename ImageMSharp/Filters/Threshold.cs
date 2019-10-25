using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using ImageProcessor.Imaging.Filters.Binarization;
using System.Drawing;

namespace ImageMSharp.Filters
{
    class Threshold : Effects
    {
        public ImageFactory draw(ImageFactory image)
        {
            float threshold = 50 / 100;
            Bitmap destination = (Bitmap)image.Image;
            for (int x = 0; x < destination.Width; x++)
            {
                for (int y = 0; y < destination.Height; y++)
                {
                    
                    if(destination.GetPixel(x,y) <= threshold)
                    {
                        Console.WriteLine("Color: " + destination.GetPixel(x, y).ToArgb());
                        destination.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        destination.SetPixel(x, y, Color.White);
                    }
                }
            }
            ImageFactory newimage = new ImageFactory();
            newimage.Load(destination);
            return newimage;
        }
    }
}
