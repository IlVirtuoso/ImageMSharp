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
        String[] filters = { "Greyscale", "Threshold", "BorderRecon" , "MetricRevisor"};
        public GUI()
        {
     
            InitializeComponent();
            FilterSelector.Items.AddRange(filters);
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
            dialog.Filter = "*Jpeg Image File (.jpg)|*.jpg|Raw Image File (.Raw)|*.raw| Nikon Raw File(*.Nef)|*.NEF|Canon Raw File(*.CR2)|*.CR2";
            dialog.InitialDirectory = lastdir;
            dialog.ShowDialog();
            imagepath = dialog.FileName;
            Console.WriteLine("File selected" + imagepath);
            lastdir = dialog.InitialDirectory;
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
           
                render.effectformdispose();
                FilterSelector.Text = FilterSelector.SelectedText;
                render.filter = FilterSelector.SelectedIndex;
                render.effectgenerateform();
                if (render.filter != FilterSelector.SelectedIndex)
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

        private void SalvaButton_Click(object sender, EventArgs e)
        {
            try
            {
                Image tosave = render.picture;
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Scegli dove salvare il file";
                save.InitialDirectory = lastdir;
                save.Filter = "jpeg image file (*.jpg)|*.jpg|Raw Format File(*.raw)|*.raw";
                save.AddExtension = true;
                save.ShowDialog();
                try
                {
                    tosave.Save(save.FileName);
                }
                catch(ArgumentException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            catch (NullReferenceException exc)
            {
                Console.WriteLine(exc.Message);
            }

        }

        private void ViewBox_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void ViewBox_Click_2(object sender, EventArgs e)
        {

        }
    }
}
