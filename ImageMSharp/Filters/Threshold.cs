using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMSharp.Filters;
using ImageMSharp.Libs;
using System.Drawing;
using MetroFramework;

namespace ImageMSharp.Filters
{
    class Threshold : Effects
    {
        public Image draw(Image image)
        {
            int threshold = 127;
            Bitmap newimage = new Bitmap(image.Width, image.Height);
            Color[,] matrix = image.toMatrix();
            for(int x = 0; x < image.Width; x++)
            {
                for(int y = 0; y < image.Height; y++)
                {
                    int r = matrix[x, y].R;
                    int g = matrix[x, y].G;
                    int b = matrix[x, y].B;
                    int m = (r + g + b) / 3;
                    if(m <= threshold)
                    {
                        newimage.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        newimage.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            }
 
            return newimage;
        }
        public void formsetup()
        {

        }

        public void formdispose()
        {

        }
    }
}
