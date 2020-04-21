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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void brexit_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            DialogResult dir = MessageBox.Show("Are you sure?", "Exit programe", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dir == DialogResult.Yes)
            {
                this.Hide();
                login.Show();
            }
            else
            {
                
            }
        }
    }
}
