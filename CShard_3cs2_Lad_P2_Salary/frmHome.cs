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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            DialogResult dir = MessageBox.Show("Are you sure to exit programe?", "Exit programe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dir == DialogResult.Yes)
            {
                Application.ExitThread();
            }




            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            DialogResult dir = MessageBox.Show("Are you sure to log-out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dir == DialogResult.Yes)
            {
                this.Hide();
                login.Show();
            }
            else
            {

            }
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff();
            staff.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDept detpart = new frmDept();
            detpart.Show();
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPosition position = new frmPosition();
            position.Show();
        }

        private void qualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAualiaction adpli = new frmAualiaction();
            adpli.Show();
        }
    }
}
