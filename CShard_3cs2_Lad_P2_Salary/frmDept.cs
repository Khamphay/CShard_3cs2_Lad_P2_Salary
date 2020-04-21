using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CShard_3cs2_Lad_P2_Salary
{
    public partial class frmDept : Form
    {
        public frmDept()
        {
            InitializeComponent();
        }

        SqlConnection conn = MyConnect.Connected();

        private void frmDept_Load(object sender, EventArgs e)
        {
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qualificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
