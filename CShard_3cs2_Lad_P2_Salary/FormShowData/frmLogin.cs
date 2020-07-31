using Message;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        SqlConnection con = MyConnect.Connected();
        SqlDataAdapter da;
        DataTable table;
        frmHome home;

        private void Login(string username, string password)
        {
            try
            {
                if (username != "" && password!="")
                {
                    table = new DataTable();
                    da = new SqlDataAdapter("Select Name_Lao, Surname_Lao, Surname_Lao, Position, Username, Password, mobile, St_ID From tbCreate_Account INNER JOIN tbStaff ON tbCreate_Account.Staff=tbStaff.St_ID Where Username='" + username + "' AND Password='" + password + "'", con);
                    da.Fill(table);
                    if (table.Rows.Count>0)
                    {
                        MyModel.staff[0] = table.Rows[0]["Name_Lao"].ToString() + " " + table.Rows[0]["Surname_Lao"].ToString();
                        MyModel.staff[1] = table.Rows[0]["Position"].ToString();
                        MyModel.staff[2] = table.Rows[0]["Username"].ToString();
                        MyModel.staff[3] = table.Rows[0]["Password"].ToString();
                        MyModel.staff[4] = table.Rows[0]["mobile"].ToString();
                        MyModel.staff[5] = table.Rows[0]["St_ID"].ToString();

                        if (MyModel.staff[2] == username)
                        {
                            if (MyModel.staff[3] == password)
                            {
                                if (home != null)
                                {
                                    home.Close();
                                }
                                home = new frmHome();
                                this.Hide();
                                home.Show();
                            }
                            else
                            {
                                MyMessageBox.ShowMssg("ລະຫັດບໍ່ຖຶກ!", "ບໍ່ສາມາດເຂົ້າລະບົບ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MyMessageBox.ShowMssg("ຊື່ຜູ້ໃຊ້ບໍ່ຖຶກ!", "ບໍ່ສາມາດເຂົ້າລະບົບ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MyMessageBox.ShowMssg("ບໍ່ມີບັນຊີຜູ້ໃຊ້ນີ້ຢູ່ໃນລະບົບ!", "ບໍ່ສາມາດເຂົ້າລະບົບ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MyMessageBox.ShowMssg("ກະລຸນາປ້ອນຊື່ຜູ້ໃຊ້ ແລະ ລະຫັດຜ່ານ ແລ້ວລອງໃຫມ່ອີກຄັ້ງ", "ປ້ອນຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດເຂົ້າລະບົບໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກິດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {
            Login(txtuser.Text, txtpass.Text);
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
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void gunaCirclePictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Khamphay/");
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();
            }            
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login(txtuser.Text, txtpass.Text);
            }
        }
    }
}
