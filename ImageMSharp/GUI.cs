using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageMSharp
{
    public partial class GUI : Form
    {
        private String imagepath;
        private String lastdir;
        private Render render;
        private String filter;
    
        public GUI()
        {
            InitializeComponent();
            lastdir = "C:\\";
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void ApriButton_Click(object sender, EventArgs e)
        {
            openSelector();
        }

        private void openSelector()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Scegli un file";
            dialog.Filter = "*.jpg|*.jpg";
            dialog.InitialDirectory = lastdir;
            dialog.ShowDialog();
            imagepath = dialog.FileName;
            Console.WriteLine("File selected" + imagepath);
            Console.WriteLine("File selected" + imagepath);
            render = new Render(imagepath);
            visualize();
        }

        private void visualize()
        {
            Image vis = render.picture;
            ViewBox.Image = vis;
            ViewBox.Refresh();
        }

        private void Aggiorna_Click(object sender, EventArgs e)
        {
            render.reset();
            visualize();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            if(render == null)
            {
                throw new Exception("Please select a image before");
            }
            else
            {
                render.compute();
                visualize();
            }
        }

        private void FilterSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSelector.Text = FilterSelector.SelectedText;
            render.filter = FilterSelector.SelectedIndex;
            if(render.filter != FilterSelector.SelectedIndex)
            {
                throw new Exception("Cannot set filter");
            }
        }

        private void DigitaIlCodiceSegretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecretCode code = new SecretCode();
            code.Show();
            
        }

        private void ViewBox_Click(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
