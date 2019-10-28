using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using ImageProcessor.Imaging.Filters.EdgeDetection;
using System.Drawing;
using ImageMSharp.Libs;
namespace ImageMSharp.Filters
{
    class BorderRecon:Effects
    {
        displayDriver form;
        public Image draw(Image image)
        {
            int progress = 0;
            GreyScale grey = new GreyScale();
            image = grey.draw(image);
            Bitmap img = new Bitmap(image.Width, image.Height);
            Color[,] matrix = image.toMatrix();

            for(int x = 1; x < image.Width - 1; x++)
            {
                for(int y = 1; y < image.Height - 1; y++)
                {
                    if(image.Width%x == 0)
                    {
                        form.progressBar.PerformStep();
                    }
                    int pixelvalue = 0;
                    for(int Dx = -1; Dx <= 1; Dx++)
                    {
                        for(int Dy = -1; Dy <=1; Dy++)
                        {
                            if(Dx == 0 && Dy == 0)
                            {
                                pixelvalue = (8 * matrix[x, y].R) + pixelvalue;
                            }
                            else
                            {
                                pixelvalue = pixelvalue + (matrix[x + Dx, y + Dy].R * -1);
                            }
                        }
                        if(pixelvalue > 0 && pixelvalue < 255)
                        {
                            img.SetPixel(x, y, Color.FromArgb(pixelvalue, pixelvalue, pixelvalue));
                        }
                        else if(pixelvalue <= 0)
                        {
                            img.SetPixel(x, y,Color.FromArgb(0,0,0));
                        }
                        else
                        {
                            img.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                    }
                }
            }
            return img;
            
        }

        public void formsetup()
        {
            form = new displayDriver();
            form.parameter.Text = "Separator";
            form.valueDisplay.Text = "0";
            form.Show();
        }

        public void formdispose()
        {
            form.Dispose();
        }
    }
}
