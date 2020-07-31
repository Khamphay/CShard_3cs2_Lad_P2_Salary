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
using Message;

namespace CShard_3cs2_Lad_P2_Salary
{
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }

        SqlConnection con = MyConnect.Connected();
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds = new DataSet();
        DataTable table;
        string posi_id = "";
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

        private void LoadStaffID()
        {
            try
            {
                auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select St_ID From tbStaff",con);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    auto.Add(dr["St_ID"].ToString());
                }
                txtstaff_id.AutoCompleteCustomSource = auto;
                txtstaff_id.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtstaff_id.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }

        private void LoadStaffName()
        {
            try
            {
                auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select  Name_Lao, Name_Eng From tbStaff",con);
                dr = cmd.ExecuteReader();
               while(dr.Read())
                {
                    auto.Add(dr["Name_Lao"].ToString());
                    auto.Add(dr["Name_Eng"].ToString());
                }
                txtName.AutoCompleteCustomSource = auto;
                txtName.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtName.AutoCompleteSource = AutoCompleteSource.CustomSource; 
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }

        private void LoaPosition()
        {
            try
            {
                da = new SqlDataAdapter("Select Po_Name_Eng, Po_Name_Lao From tbPosition", con);
                table = new DataTable();
                da.Fill(table);
                if (table.Rows.Count>0)
                {
                    for (int i=0;i<table.Rows.Count;i++)
                    {
                        cmbNameEngP.Items.Add(table.Rows[i][0].ToString());
                        cmbNameLaoP.Items.Add(table.Rows[i][1].ToString());
                    }
                }
            }catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Save()
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbCreate_Account Values(@id, @stid, @Posi, @user, @pass)", con);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("stid", txtstaff_id.Text);
                cmd.Parameters.AddWithValue("Posi", posi_id);
                cmd.Parameters.AddWithValue("user", txtUser.Text);
                cmd.Parameters.AddWithValue("pass", txtNewpass.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MyMessageBox.ShowMssg("ບັນທືກຂໍ້ມູນສຳເລັດແລ້ວ", "ບັນທືກ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດບັນທືກຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearText()
        {
            txtID.Clear();
            txtstaff_id.Clear();
            txtNewpass.Clear();
            txtRepass.Clear();
            posi_id = "";
            txtUser.Clear();
            cmbNameEngP.ResetText();
            cmbNameLaoP.ResetText();
        }

        private void brexit_Click(object sender, EventArgs e)
        {
            //frmLogin login = new frmLogin();
            //DialogResult dir = MessageBox.Show("Are you sure?", "Exit programe", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            //if (dir == DialogResult.Yes)
            //{
            this.Close();
            //}
            //else
            //{
                
            //}
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            KeyBord.getKeyBord();
            LoaPosition();
            LoadStaffID();
            LoadStaffName();
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNameEngP.SelectedIndex == cmbNameEngP.FindString("Administrator"))
            {
                cmbNameLaoP.ResetText();
                cmbNameLaoP.SelectedText = "ປະທານ";
            }
            else if (cmbNameEngP.SelectedIndex == cmbNameEngP.FindString("Vice Administrator"))
            {
                cmbNameLaoP.ResetText();
                cmbNameLaoP.SelectedText = "ຜູ້ບໍລິຫານ";
            }
            else if (cmbNameEngP.SelectedIndex == cmbNameEngP.FindString("Manager"))
            {
                cmbNameLaoP.ResetText();
                cmbNameLaoP.SelectedText = "ຫົວໜັາພະແນກ";
            }
            else if (cmbNameEngP.SelectedIndex == cmbNameEngP.FindString("Head of Department"))
            {
                cmbNameLaoP.ResetText();
                cmbNameLaoP.SelectedText = "ຫົວໜ້າພະແນກ";
            }
            else if (cmbNameEngP.SelectedIndex == cmbNameEngP.FindString("Deputy of Department"))
            {
                cmbNameLaoP.ResetText();
                cmbNameLaoP.SelectedText = "ຮອງພະແນກ";
            }
            else if (cmbNameEngP.SelectedIndex == cmbNameEngP.FindString("Employee"))
            {
                cmbNameLaoP.ResetText();
                cmbNameLaoP.SelectedText = "ພະນັກງານ";
            }


            try
            {
                cmd = new SqlCommand("Select Po_ID From tbPosition Where Po_Name_Eng=N'" + cmbNameEngP.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr["Po_ID"].ToString() != "")
                {
                    posi_id=dr["Po_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }

        private void btnewuser_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = KeyBord.eng;
        }

        private void Key_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmbNameLaoP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ປະທານ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Administrator";
            }
            else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ຮອງປະທານ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Vice Administrator";
            }
            else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ພະແນກບໍລິຫານ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Aministive";
            }
            else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ຜູ້ບໍລິຫານ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Manager";
            }
            else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ຫົວໜ້າພະແນກ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Head of Department";
            }
            else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ຮອງພະແນກ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Deputy of Department";
            }
            else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ພະນັກງານ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Employee";
            }
        }

        private void txtstaff_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                table = new DataTable();
                da = new SqlDataAdapter("Select Name_Lao From tbStaff Where St_ID=N'" + txtstaff_id.Text + "'", con);
                da.Fill(table);
                if (table.Rows.Count > 0)
                {
                  txtName.Text= table.Rows[0]["Name_Lao"].ToString();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                table = new DataTable();
                da = new SqlDataAdapter("Select St_ID From tbStaff Where Name_Lao=N'" + txtName.Text + "' OR Name_Eng=N'" + txtName.Text + "'", con);
                da.Fill(table);
                if (table.Rows.Count>0)
                {
                    txtstaff_id.Text = table.Rows[0]["St_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
