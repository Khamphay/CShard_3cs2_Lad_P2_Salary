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
    public partial class frmStaff : Form
    {
        frmHome _home;
        public frmStaff(frmHome home)
        {
            InitializeComponent();
            _home = home;
        }
        SqlConnection conn = MyConnect.Connected();
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds = new DataSet();
        AutoCompleteStringCollection auto;
        string que_id = "", posi_id = "", dep_id = "", gender="", status="";
        string[] col = { "ລະຫັດ", "ຊື່(ພາສາລາວ)", "ນາມສະກຸນ(ພາສາລາວ)", "ຊື່(ພາສາອັງກິດ)", "ນາມສະກຸນ(ພາສາອັງກິດ)", "ເພດ", "ສະຖານະ", "ວ.ດ.ປ ເກີດ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ເບີໂທ", "Email", "Facbook", "ລະດັບການສຶກ(ພາສາອັງກິດ)", "ລະດັບການສຶກ(ພາສາລາວ)", "ຕຳແໜ່ງ(ພາສາອັງກິດ)", "ຕຳແໜ່ງ(ພາສາລາວ)", "ພະແນກ" };


        private void LoadQua()
        {
            try
            {
                cmd = new SqlCommand("Select Qua_Name_Eng, Qua_Name_Lao From tbQualification", conn);
                dr = cmd.ExecuteReader();
                //if(dr.HasRows && (dr["Qua_Name_Eng"].ToString()!="" || dr["Qua_Name_Lao"].ToString() != "")){
                while (dr.Read())
                {
                    cmbNameEngQ.Items.Add(dr["Qua_Name_Eng"].ToString());
                    cmbNameLaoQ.Items.Add(dr["Qua_Name_Lao"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Quelificaton", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        } 
        private void LoadPosition()
        {
            try
            {
                cmd = new SqlCommand("Select Po_Name_Eng, Po_Name_Lao From tbPosition", conn);
                dr = cmd.ExecuteReader();
                // if(dr.HasRows && (dr["Po_Name_Eng"].ToString()!="" || dr["Po_Name_Lao"].ToString() != "")){
                while (dr.Read())
                {
                    cmbNameEngP.Items.Add(dr["Po_Name_Eng"].ToString());
                    cmbNameLaoP.Items.Add(dr["Po_Name_Lao"].ToString());
                }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        } 
        private void LoadDep()
        {
            try
            {
                auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select Dep_Name From tbDepartment", conn);
                dr = cmd.ExecuteReader();
                // dr.Read();
                // if(dr.HasRows && dr["Dep_Name"].ToString()!=""){
                while (dr.Read())
                {
                    cmbDeparment.Items.Add(dr["Dep_Name"].ToString());
                    auto.Add(dr["Dep_Name"].ToString());
                }
                cmbDeparment.AutoCompleteCustomSource = auto;
                cmbDeparment.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbDeparment.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void ShowData()
        {
            try
            {
                da = new SqlDataAdapter("Select * From vw_Staff", conn);
                ds = new DataSet();
                da.Fill(ds, "st");
                dgvStaff.DataSource = ds.Tables["st"];
                for (int c = 0; c < col.Length; c++)
                {
                    dgvStaff.Columns[c].HeaderText = col[c];
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Save()
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbStaff Values(@id, @nameLao, @surnameLao, @nameEng, @surnameEng, @gender, @status, @brithDay, @village, @district, @province, @tel, @email, @facebook, @que, @posi, @dep)", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("nameLao", txtNameLao.Text);
                cmd.Parameters.AddWithValue("surnameLao", txtSurNameLao.Text);
                cmd.Parameters.AddWithValue("nameEng", txtNameEng.Text);
                cmd.Parameters.AddWithValue("surnameEng", txtSurNameEng.Text);
                cmd.Parameters.AddWithValue("gender", gender);
                cmd.Parameters.AddWithValue("status", status);
                cmd.Parameters.AddWithValue("brithDay", DbType.Date).Value= dpBrithDate.Value;
                cmd.Parameters.AddWithValue("village", txtVillage.Text);
                cmd.Parameters.AddWithValue("district", txtDistrict.Text);
                cmd.Parameters.AddWithValue("province", txtProvince.Text);
                cmd.Parameters.AddWithValue("tel", txtTel.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("facebook", txtFacebook.Text);
                cmd.Parameters.AddWithValue("que", que_id);
                cmd.Parameters.AddWithValue("posi", posi_id);
                cmd.Parameters.AddWithValue("dep", dep_id);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData();
                    ClearText();
                    _home.ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit()
        {
            try
            {
                cmd = new SqlCommand("Update tbStaff Set  Name_Lao=@nameLao, Surname_Lao=@surnameLao, Name_Eng=@nameEng, Surname_Eng=@surnameEng, Gender=@gender, Status=@status, Date_of_Brith=@brithDay, Village_now=@village, District_now=@district, Province_now=@province, Mobile=@tel, Email=@email, Facbook=@faecbook, Qua_ID=@que, Po_ID=@posi, Dep_ID=@dep Where St_ID=@id", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("nameLao", txtNameLao.Text);
                cmd.Parameters.AddWithValue("surnameLao", txtSurNameLao.Text);
                cmd.Parameters.AddWithValue("nameEng", txtNameEng.Text);
                cmd.Parameters.AddWithValue("surnameEng", txtSurNameEng.Text);
                cmd.Parameters.AddWithValue("gender", gender);
                cmd.Parameters.AddWithValue("status", status);
                cmd.Parameters.AddWithValue("brithDay", DbType.Date).Value = dpBrithDate.Value;
                cmd.Parameters.AddWithValue("village", txtVillage.Text);
                cmd.Parameters.AddWithValue("district", txtDistrict.Text);
                cmd.Parameters.AddWithValue("province", txtProvince.Text);
                cmd.Parameters.AddWithValue("tel", txtTel.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("faecbook", txtFacebook.Text);
                cmd.Parameters.AddWithValue("que", que_id);
                cmd.Parameters.AddWithValue("posi", posi_id);
                cmd.Parameters.AddWithValue("dep", dep_id);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData();
                    ClearText();
                    _home.ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete()
        {
            try
            {
                cmd = new SqlCommand("Delete From  tbStaff  Where St_ID=@id", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.ExecuteNonQuery();
                ShowData();
                ClearText();
                _home.ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearText()
        {
            txtID.Clear();
            txtNameEng.Clear();
            txtSurNameEng.Clear();
            txtNameLao.Clear();
            txtSurNameLao.Clear();
            gender = "";
            status = "";
            txtVillage.Clear();
            txtDistrict.Clear();
            txtProvince.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtFacebook.Clear();
            cmbNameEngQ.ResetText();
            cmbNameLaoQ.ResetText();
            cmbNameEngP.ResetText();
            cmbNameLaoP.ResetText();
            cmbDeparment.ResetText();
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            KeyBord.getKeyBord();
            ShowData();
            LoadQua();
            LoadPosition();
            LoadDep();
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMale.Checked == true)
            {
                gender = rdbMale.Text;
            }
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFemale.Checked == true)
            {
                gender = rdbFemale.Text;
            }
        }

        private void rdbSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSingle.Checked == true)
            {
                status = rdbSingle.Text;
            }
        }

        private void rdbMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMarried.Checked == true)
            {
                status = rdbMarried.Text;
            }
        }

        private void txtNameLao_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = KeyBord.lao;
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = KeyBord.eng;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Key_EnterNextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmbNameLaoQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNameLaoQ.SelectedIndex == cmbNameLaoQ.FindString("ການບໍລີຫານ"))
            {
                cmbNameEngQ.ResetText();
                cmbNameEngQ.SelectedText = "Aministative";
            }
            else if (cmbNameLaoQ.SelectedIndex == cmbNameLaoQ.FindString("ໄອທີ"))
            {
                cmbNameEngQ.ResetText();
                cmbNameEngQ.SelectedText = "IT";
            }
            else if (cmbNameLaoQ.SelectedIndex == cmbNameLaoQ.FindString("ອອແບບ"))
            {
                cmbNameEngQ.ResetText();
                cmbNameEngQ.SelectedText = "Design";
            }
            else if (cmbNameLaoQ.SelectedIndex == cmbNameLaoQ.FindString("ການເງີນ"))
            {
                cmbNameEngQ.ResetText();
                cmbNameEngQ.SelectedText = "Financial";
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

        private void btPrint_Click(object sender, EventArgs e)
        {
            frmStaffReport report = new frmStaffReport();
            report.ShowDialog();
        }

        private void dgvStaff_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameLao.Text = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSurNameLao.Text = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNameEng.Text = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSurNameEng.Text = dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString();

                gender = dgvStaff.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (gender == "Male")
                {
                    rdbMale.Checked = true;
                }
                else
                {
                    rdbMale.Checked = true;
                }
                status = dgvStaff.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (status == "Single")
                {
                    rdbSingle.Checked = true;
                }
                else
                {
                    rdbMarried.Checked = true;
                }

                dpBrithDate.Value = DateTime.Parse(dgvStaff.Rows[e.RowIndex].Cells[7].Value.ToString());
                txtVillage.Text = dgvStaff.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtDistrict.Text = dgvStaff.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtProvince.Text = dgvStaff.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtTel.Text = dgvStaff.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtEmail.Text = dgvStaff.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtFacebook.Text = dgvStaff.Rows[e.RowIndex].Cells[13].Value.ToString();
                cmbNameEngQ.Text = dgvStaff.Rows[e.RowIndex].Cells[14].Value.ToString();
                cmbNameEngP.Text = dgvStaff.Rows[e.RowIndex].Cells[16].Value.ToString();
                cmbDeparment.Text = dgvStaff.Rows[e.RowIndex].Cells[18].Value.ToString();
            }
        }

        private void cmbQualifica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNameEngQ.SelectedIndex == cmbNameEngQ.FindString("Aministative"))
            {
                cmbNameLaoQ.ResetText();
                cmbNameLaoQ.SelectedText = "ການບໍລີຫານ";
            }
            else if (cmbNameEngQ.SelectedIndex == cmbNameEngQ.FindString("IT"))
            {
                cmbNameLaoQ.ResetText();
                cmbNameLaoQ.SelectedText = "ໄອທີ";
            }
            else if (cmbNameEngQ.SelectedIndex == cmbNameEngQ.FindString("Design"))
            {
                cmbNameLaoQ.ResetText();
                cmbNameLaoQ.SelectedText = "ອອແບບ";
            }
            else if (cmbNameEngQ.SelectedIndex == cmbNameEngQ.FindString("Financial"))
            {
                cmbNameLaoQ.ResetText();
                cmbNameLaoQ.SelectedText = "ການເງີນ";
            }



            try
            {
                cmd = new SqlCommand("Select Qua_ID From tbQualification Where Qua_Name_Eng='" + cmbNameEngQ.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if(dr.HasRows && dr["Qua_ID"].ToString() != "")
                {
                    que_id = dr["Qua_ID"].ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
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
                cmd = new SqlCommand("Select Po_ID From tbPosition Where Po_Name_Eng=N'" + cmbNameEngP.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr["Po_ID"].ToString() != "")
                {
                    posi_id = dr["Po_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
        }

        private void cmbDeparment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select Dep_ID From tbDepartment Where Dep_Name=N'" + cmbDeparment.Text + "'", conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr["Dep_ID"].ToString() != "")
                {
                    dep_id = dr["Dep_ID"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
        }
    }
}
