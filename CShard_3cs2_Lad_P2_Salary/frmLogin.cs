using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShard_3cs2_Lad_P2_Salary
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }




        private void btcancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {

            frmHome home = new frmHome();
            this.Hide();
            home.Show();
        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void gunaCirclePictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/explore");
        }

        private void gunaCirclePictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/gmail");
        }

        private void gunaCirclePictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Khamphay/");
        }
    }
}
