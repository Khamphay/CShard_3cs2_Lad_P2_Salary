using Message;
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
        frmLogin login;

        string[] col = { "ລະຫັດ", "ຊື່(ພາສາລາວ)", "ນາມສະກຸນ(ພາສາລາວ)", "ຊື່(ພາສາອັງກິດ)", "ນາມສະກຸນ(ພາສາອັງກິດ)", "ເພດ", "ສະຖານະ", "ວ.ດ.ປ ເກີດ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ເບີໂທ", "Email", "Facbook", "ລະດັບການສຶກ(ພາສາອັງກິດ)", "ລະດັບການສຶກ(ພາສາລາວ)", "ຕຳແໜ່ງ(ພາສາອັງກິດ)", "ຕຳແໜ່ງ(ພາສາລາວ)", "ພະແນກ (ພາສາລາວ)", "ພະແນກ (ພາສາອັງກີດ)" };
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
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShearchData(string data)
        {
            try
            {
                da = new SqlDataAdapter("Select * From vw_Staff Where Name_Lao Like N'"+data+"%' Or Surname_Lao like N'%"+data+"%' Or Name_Eng like N'%"+data+"%' Or Surname_Eng like N'%"+data+"%' ", con);
                ds = new DataSet();
                da.Fill(ds, "st");
                dgvStaff.DataSource = ds.Tables["st"];
                for (int c = 0; c < col.Length; c++)
                {
                    dgvStaff.Columns[c].HeaderText = col[c];
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            DialogResult dir = MyMessageBox.ShowMssg("ທ່ານຕ້ອງການປີດໂປຣແກຣມບໍ່?", "ປີດໂປຣແກຣມ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dir == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dir = MyMessageBox.ShowMssg("ທ່ານຕ້ອງການອອກຈາກລະບົບບໍ່?", "ອອກຈາກລະບົບ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dir == DialogResult.Yes)
            {
                if (login!=null)
                {
                    login.Close();
                }
                login = new frmLogin();
                this.Hide();
                login.Show();
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
            lbUserName.Text = MyModel.staff[0];
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") {
                ShearchData(textBox1.Text);
            }
            else
            {
                ShowData();
            }
        }

        private void aboautToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMessageBox.ShowMssg("ຊື່ໂປຣເຈັກ: Salary, ສອນໂດຍ: ອາຈານ ຈັນທະສິດ ພຸດທີຫົງ, ຂຽນໂດຍ: ທ້າວ ຄຳໄຟ ເສຍລີມົວ, ຫ້ອງ 3cs2", "ກ່ຽວກັບ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }
    }
}
