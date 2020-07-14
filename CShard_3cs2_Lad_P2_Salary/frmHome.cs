using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        SqlConnection con = MyConnect.Connected();
        SqlDataAdapter da;
        DataSet ds;

        string[] col = { "ລະຫັດ", "ຊື່(ພາສາລາວ)", "ນາມສະກຸນ(ພາສາລາວ)", "ຊື່(ພາສາອັງກິດ)", "ນາມສະກຸນ(ພາສາອັງກິດ)", "ເພດ", "ສະຖານະ", "ວ.ດ.ປ ເກີດ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ເບີໂທ", "Email", "Facbook", "ລະດັບການສຶກ(ພາສາອັງກິດ)", "ລະດັບການສຶກ(ພາສາລາວ)", "ຕຳແໜ່ງ(ພາສາອັງກິດ)", "ຕຳແໜ່ງ(ພາສາລາວ)", "ພະແນກ"};
        public void ShowData()
        {
            try
            {
                da = new SqlDataAdapter("Select * From vw_Staff", con);
                ds = new DataSet();
                da.Fill(ds, "st");
                dgvStaff.DataSource = ds.Tables["st"];
                for(int c=0; c < col.Length; c++)
                {
                    dgvStaff.Columns[c].HeaderText = col[c];
                }
            }
            catch (Exception)
            {

                throw;
            }
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
            frmLogin login = new frmLogin();
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
            frmStaff staff = new frmStaff(this);
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
            frmQualification adpli = new frmQualification();
            adpli.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateUser createuser = new frmCreateUser();
            createuser.Show();
        }

        private void checkInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheck_In_Out check_In_Out = new frmCheck_In_Out();
            check_In_Out.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void basicSaralyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicSalary salary = new BasicSalary();
            salary.Show();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCheck_In_Out in_Out = new frmCheck_In_Out();
            in_Out.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmStaff staff = new frmStaff(this);
            staff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCreateUser createUseruser = new frmCreateUser();
            createUseruser.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          BasicSalary salary = new BasicSalary();
            salary.Show();
        }
    }
}
