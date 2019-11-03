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
    class MetricRevisor : Effects
    {
        displayDriver form;
        int iterations;
        public Image draw(Image image)
        {
            Bitmap deconv = new Bitmap(image.Width, image.Height);
            int[,] R = image.decompMatrix('R');
            int[,] G = image.decompMatrix('G');
            int[,] B = image.decompMatrix('B');
            return null;

        }

        public void formsetup()
        {
            form = new displayDriver();
            adjustparameters();
            form.Show();
        }

        public void formdispose()
        {

        }

        public void adjustparameters()
        {
            form.parameter.Text = "Iterations";
            form.trackBar.Minimum = 0;
            form.trackBar.Maximum = 200;
            form.trackBar.ValueChanged += TrackBar_ValueChanged;
            ComboBox combo = new ComboBox();
            
            
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            form.valueDisplay.Text = form.trackBar.Value.ToString();
            iterations = form.trackBar.Value;
        }
    }
}
