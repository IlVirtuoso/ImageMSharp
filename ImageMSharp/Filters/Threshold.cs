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

        displayDriver form;
        public Image draw(Image image)
        {
            int threshold = form.trackBar.Value;
            Bitmap newimage = new Bitmap(image.Width, image.Height);
            Color[,] matrix = image.toMatrix();
            for(int x = 0; x < image.Width; x++)
            {
                double progress = ((double)x / (double)image.Width) * 100;
                form.progressBar.Value =(int) progress + 1;
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
            form = new displayDriver();
            form.trackBar.Minimum = 0;
            form.trackBar.Maximum = 255;
            form.parameter.Text = "Threshold";
            form.trackBar.Value = 0;
            form.trackBar.ValueChanged += changevalue;
            form.valueDisplay.Text = form.trackBar.Value.ToString();
            form.Show();
        }

       

        public void formdispose()
        {
            form.Dispose();
        }

        public void changevalue(object sender, EventArgs e)
        {
            form.valueDisplay.Text = form.trackBar.Value.ToString();
        }


    }
}
