using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using ImageProcessor.Imaging.Filters.EdgeDetection;
using System.Drawing;
using ImageMSharp.Libs;
using System.Windows.Forms;
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
        System.Windows.Forms.CheckBox sovrapponi;
        public Image draw(Image image)
        {
            Image original = image;
            Color[,] origin = original.toMatrix();
            GreyScale grey = new GreyScale();
            image = grey.draw(image);
            Bitmap img = new Bitmap(image.Width, image.Height);
            Color[,] matrix = image.toMatrix();
            int[,] kern = kernelselector(combo.SelectedIndex);
            bool on_mode = sovrapponi.Checked;

            for(int x = 1; x < image.Width - 1; x++)
            {
                double progress = ((double)x / (double)image.Width) * 100;
                form.progressBar.Value = (int)progress + 1;
                Console.WriteLine(progress);
                for(int y = 1; y < image.Height - 1; y++)
                {

                    int pixelvalue = 0;
                    for(int dx = -1; dx <= 1 ; dx++)
                    {
                        for(int dy = -1; dy <= 1; dy++)
                        {
                            pixelvalue = matrix[dx + x, dy + y].R * kern[dx + 1, dy + 1] + pixelvalue;
                        }
                        if (on_mode)
                        {
                            if (pixelvalue > form.trackBar.Value && pixelvalue < 255)
                            {
                                img.SetPixel(x, y, Color.FromArgb(pixelvalue, origin[x,y].G , origin[x,y].B));
                            }
                            else if (pixelvalue <= form.trackBar.Value)
                            {
                                img.SetPixel(x, y, Color.FromArgb(origin[x,y].R, origin[x,y].G, origin[x,y].B));
                            }
                            else
                            {
                                img.SetPixel(x, y, Color.FromArgb(0, 255, 0));
                            }
                        }
                        else
                        {
                            if (pixelvalue > form.trackBar.Value && pixelvalue < 255)
                            {
                                img.SetPixel(x, y, Color.FromArgb(pixelvalue, pixelvalue, pixelvalue));
                            }
                            else if (pixelvalue <= form.trackBar.Value)
                            {
                                img.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                            }
                            else
                            {
                                img.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                            }
                        }
                    }
                }
            }
            GC.Collect();
            return img;
            
        }

        public void formsetup()
        {
            form = new displayDriver();
            form.parameter.Text = "Separator";
            form.valueDisplay.Text = "0";
            form.progressBar.ForeColor = Color.Red;
            combo = combobox();
            sovrapponi = checkbox();
            form.Controls.Add(combo);
            form.Controls.Add(sovrapponi);
            form.trackBar.Minimum = 0;
            form.trackBar.Maximum = 255;
            form.trackBar.Value = 0;
            form.trackBar.ValueChanged += TrackBar_ValueChanged;
            form.Show();
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            form.valueDisplay.Text = form.trackBar.Value.ToString();
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
                        for(int k = 0; k < x; k++)
                        {
                            kernel[i, k] = -1;
                        }
                        
                    }
                    kernel[1, 1] = 8;
                    return kernel;
                    

                case (int)Kernel.LAPLACIAN_V2:
                    for(int i = 0; i < x; i++)
                    {
                        for(int k = 0; k < x; k++)
                        {
                            kernel[i, k] = 0;
                        }
                    }
                    kernel[0, 0] = -4;
                    kernel[2, 2] = 4;
                    return kernel;

                case (int) Kernel.SOBEL_HORIZONTAL:
                    kernel[0, 0] = -1;
                    kernel[0, 1] = 0;
                    kernel[0, 2] = 1;
                    kernel[1, 0] = -2;
                    kernel[1, 1] = 0;
                    kernel[1, 2] = 2;
                    kernel[2, 0] = -1;
                    kernel[2, 1] = 0;
                    kernel[2, 2] = 1;
                    return kernel;

                case (int)Kernel.SOBEL_VERTICAL:
                    kernel[0, 0] = -1;
                    kernel[0, 1] = -2;
                    kernel[0, 2] = -1;
                    kernel[1, 0] = 0;
                    kernel[1, 1] = 0;
                    kernel[1, 2] = 0;
                    kernel[2, 0] = 1;
                    kernel[2, 1] = 2;
                    kernel[2, 2] = 1;
                    return kernel;

                default:
                    return kernel;
            }

        }

        public CheckBox checkbox()
        {
            CheckBox ch = new CheckBox();
            ch.Text = "Sovrapponi";
            ch.Checked = false;
            ch.ForeColor = Color.White;
            ch.Dock = DockStyle.Right;
            ch.Show();
            return ch;
        }
    }
}
