using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using System.Drawing;
using ImageMSharp.Libs;



namespace ImageMSharp.Filters
{
    class GreyScale : Effects
    {


        public Image draw(Image image)
        {
            Color[,] img = image.toMatrix();
            Bitmap greyscaled = new Bitmap(img.GetLength(0), img.GetLength(1));
            for(int x = 0; x < img.GetLength(0); x++)
            {
                for(int y = 0; y < img.GetLength(1); y++)
                {
                    
                    int r = img[x, y].R;
                    int g = img[x, y].G;
                    int b = img[x, y].B;
                    int a = img[x, y].A;
                    int m = (r + g + b) / 3;
                    greyscaled.SetPixel(x, y, Color.FromArgb(a, m, m, m));
                }
            }
            return greyscaled;
        }
        public void formsetup()
        {

        }
        public void formdispose()
        {

        }
    }
}
