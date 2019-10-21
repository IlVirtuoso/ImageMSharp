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
    public partial class SecretCode : Form
    {
        public bool isit = false;
        public SecretCode()
        {
            InitializeComponent();
        }

        private void SecretCode_Load(object sender, EventArgs e)
        {

        }

        private void CodeBox_Click(object sender, EventArgs e)
        {

        }

        private void CodeConfirmation_Click(object sender, EventArgs e)
        {
            String code = CodeBox.Text;
            if (code == "24/11/1997")
            {
                isit = true;
                FabolousSecretPowers();
            }
            else
            {
                MessageBox.Show("Sorry is not for you");
            }
            Close();
        }

        private void FabolousSecretPowers()
        {

        }
    }
}
