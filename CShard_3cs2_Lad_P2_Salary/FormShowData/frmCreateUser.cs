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
        int maxid = 0;

        private void MaxID()
        {
            try
            {
                cmd = new SqlCommand("Select Max(Cre_ID) as mid From tbCreate_Account", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    maxid = int.Parse(dr["mid"].ToString())+1;
                    txtID.Text = maxid.ToString();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຄ່າໃຫຍ່ສຸດໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }

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
            //try
            //{
            //    da = new SqlDataAdapter("Select Po_Name_Eng, Po_Name_Lao From tbPosition", con);
            //    table = new DataTable();
            //    da.Fill(table);
            //    if (table.Rows.Count>0)
            //    {
            //        for (int i=0;i<table.Rows.Count;i++)
            //        {
            //            cmbNameEngP.Items.Add(table.Rows[i][0].ToString());
            //            cmbNameLaoP.Items.Add(table.Rows[i][1].ToString());
            //        }
            //    }
            //}catch (Exception ex)
            //{
            //    MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void Save()
        {
            if(txtUser.Text!="" && txtRepass.Text!="" && txtName.Text != "")
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
                        MaxID();
                    }
                }
                catch (Exception ex)
                {
                    MyMessageBox.ShowMssg("ບໍ່ສາມາດບັນທືກຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MyMessageBox.ShowMssg("ປ້ອນຂໍ້ມູນໃຫ້ຄົບຕາມທີ່ກຳນົດ ແລ້ວລອງໃໝ່ອີກຄັ້ງ","ປ້ອນຂໍ້ມູນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtPo_Eng.Clear();
            txtPo_Lao.Clear();
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
            //LoaPosition();
            MaxID();
            LoadStaffID();
            LoadStaffName();
        }

        private void btnewuser_Click(object sender, EventArgs e)
        {
            if (txtRepass.Text == txtNewpass.Text)
            {
                Save();
            }
            else
            {
                MyMessageBox.ShowMssg("ລະຫັດບໍ່ຄືກັນ ກະລຸນາປ້ອນໃຫມ່", "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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


        private void txtstaff_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("Select * From tbCreate_Account Where staff=N'" + txtstaff_id.Text + "'", con);
                DataTable t = new DataTable();
                da.Fill(t);
                if (t.Rows.Count<=0)
                {
                    table = new DataTable();
                    da = new SqlDataAdapter("Select tbStaff.Name_Lao, tbPosition.Po_Name_Eng, tbPosition.Po_Name_Lao From tbStaff Inner Join tbPosition ON tbStaff.Po_ID=tbPosition.Po_ID Where tbStaff.St_ID=N'" + txtstaff_id.Text + "'", con);
                    da.Fill(table);

                    if (table.Rows.Count > 0 && table.Rows[0][0].ToString() != "")
                    {
                        if (txtName.Text == "")
                        {
                            txtName.Text = table.Rows[0][0].ToString();
                        }

                        txtPo_Eng.Text = table.Rows[0][1].ToString();
                        txtPo_Lao.Text = table.Rows[0][2].ToString();
                    }
                }
                else
                {
                    txtstaff_id.Clear();
                    MyMessageBox.ShowMssg("ມີບັນຊີນີ້ຢຸ່ໃນລະບົບແລ້ວ", "ຄຳເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (txtstaff_id.Text == "")
                {
                    table = new DataTable();
                    da = new SqlDataAdapter("Select St_ID From tbStaff Where Name_Lao=N'" + txtName.Text + "' OR Name_Eng=N'" + txtName.Text + "'", con);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        txtstaff_id.Text = table.Rows[0]["St_ID"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRepass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPo_Eng_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select Po_ID From tbPosition Where Po_Name_Eng=N'" + txtPo_Eng.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr["Po_ID"].ToString() != "")
                {
                    posi_id = dr["Po_ID"].ToString();
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

        private void txtPo_Lao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
