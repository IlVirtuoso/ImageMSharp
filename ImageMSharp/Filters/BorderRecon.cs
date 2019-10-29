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
        String[] kernels = { "Laplacian v1", "Laplacian v2", "Sobel Horizontal", "Sobel vertical" };
        enum Kernel
        {
            LAPLACIAN_V1,
            LAPLACIAN_V2,
            SOBEL_HORIZONTAL,
            SOBEL_VERTICAL
        };

        Kernel kernel;
        System.Windows.Forms.ComboBox combo;
        public Image draw(Image image)
        {
            GreyScale grey = new GreyScale();
            image = grey.draw(image);
            Bitmap img = new Bitmap(image.Width, image.Height);
            Color[,] matrix = image.toMatrix();
            int[,] kern = kernelselector(combo.SelectedIndex);

            for(int x = 1; x < image.Width - 1; x++)
            {
                double progress = ((double)x / (double)image.Width) * 100;
                form.progressBar.Value = (int)progress + 1;
                Console.WriteLine(progress);
                for(int y = 1; y < image.Height - 1; y++)
                {

                    int pixelvalue = 0;
                    for(int Dx = -1; Dx <= 1; Dx++)
                    {
                        for(int Dy = -1; Dy <=1; Dy++)
                        {
                            pixelvalue = kern[Dx, Dy] * matrix[Dx + x, Dy + y].R + pixelvalue;
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
            form.progressBar.ForeColor = Color.Red;
            combo = combobox();
            form.Controls.Add(combo);
            form.Show();
        }

        public void formdispose()
        {
            form.Dispose();
        }

        public System.Windows.Forms.ComboBox combobox()
        {
            System.Windows.Forms.ComboBox matrixbox = new System.Windows.Forms.ComboBox();
            matrixbox.Dock = System.Windows.Forms.DockStyle.Right;
            matrixbox.Items.AddRange(kernels);
            return matrixbox;
            
        }

        public int[,] kernelselector(int value)
        {
            int[,] kernel = new int[3,3];
            int x = 3;
            switch (value)
            {
                case (int)Kernel.LAPLACIAN_V1:
                    for(int i = 0; i < x; i++)
                    {
                        for(int k = 0; k < x, k++)
                        {
                            kernel[i, k] = -1;
                        }
                        kernel[1, 1] = 8;
                    }
                    break;

            }
            return kernel;
        }
    }
}
