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
    public partial class frmDept : Form
    {
        public frmDept()
        {
            InitializeComponent();
        }

        SqlConnection conn = MyConnect.Connected();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        string[] colname = { "ລະຫັດ", "ພະແນກ (ພາສາລາວ)", "ພະແນກ (ພາສາອັງກີດ)" };
        private void Show_Data()
        {
            try
            {
                ds.Clear();
                da = new SqlDataAdapter("Select * From tbDepartment", conn);
                da.Fill(ds, "Dep");
                dgvDepartment.DataSource = ds.Tables["Dep"];
                dgvDepartment.Refresh();
                dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for(int i = 0; i < colname.Length; i++)
                {
                    dgvDepartment.Columns[i].HeaderText = colname[i];
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Save()
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbDepartment Values(@id, @nameL, @nameE)", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("nameL", cmbName_Lao.Text);
                cmd.Parameters.AddWithValue("nameE", cmbName_Eng.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                    ClearText();
                }
            }catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດບັນທືກຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit()
        {
            try
            {
                cmd = new SqlCommand("Update  tbDepartment Set Dep_Name_Lao=@namel, Dep_Name_Eng=@nameE  Where Dep_ID=@id", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("nameL", cmbName_Lao.Text);
                cmd.Parameters.AddWithValue("nameE", cmbName_Eng.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດແກ້ໄຂຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete()
        {
            try
            {
                cmd = new SqlCommand("Delete From  tbDepartment  Where Dep_ID=@id", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.ExecuteNonQuery();
                Show_Data();
                ClearText();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດລົບຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearText()
        {
            txtID.Clear();
            cmbName_Eng.ResetText();
            cmbName_Lao.ResetText();
        }

        private void frmDept_Load(object sender, EventArgs e)
        {
            KeyBord.getKeyBord();
            Show_Data();
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = KeyBord.eng;
        }

        private void dgvDepartment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text= dgvDepartment.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbName_Lao.Text= dgvDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbName_Eng.Text= dgvDepartment.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
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
            DialogResult result = MyMessageBox.ShowMssg("ຕ້ອງການລົບຂໍ້ມູນ ຫຼື ບໍ່?", "ລົບຂໍ້ມູນ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Delete();
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            frmDepartReport report = new frmDepartReport();
            report.ShowDialog();
        }

        private void cmbName_Eng_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbName_Eng.SelectedIndex == cmbName_Eng.FindString("Administrator"))
            {
                cmbName_Lao.ResetText();
                cmbName_Lao.SelectedText = "ພະແນກບໍລິຫານ";
            }
            else if (cmbName_Eng.SelectedIndex == cmbName_Eng.FindString("Finalcial"))
            {
                cmbName_Lao.ResetText();
                cmbName_Lao.SelectedText = "ພະແນກການເງີນ";
            }
            else if (cmbName_Eng.SelectedIndex == cmbName_Eng.FindString("IT"))
            {
                cmbName_Lao.ResetText();
                cmbName_Lao.SelectedText = "ພະແນກ ໄອທີ";
            }
            else if (cmbName_Eng.SelectedIndex == cmbName_Eng.FindString("Design"))
            {
                cmbName_Lao.ResetText();
                cmbName_Lao.SelectedText = "ພະແນກອອກແບບ";
            }
        }

        private void cmbName_Lao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbName_Lao.SelectedIndex == cmbName_Lao.FindString("ພະແນກບໍລິຫານ"))
            {
                cmbName_Eng.ResetText();
                cmbName_Eng.SelectedText = "Administrator";
            }
            else if (cmbName_Lao.SelectedIndex == cmbName_Lao.FindString("ພະແນກການເງີນ"))
            {
                cmbName_Eng.ResetText();
                cmbName_Eng.SelectedText = "Finalcial";
            }
            else if (cmbName_Lao.SelectedIndex == cmbName_Lao.FindString("ພະແນກ ໄອທີ"))
            {
                cmbName_Eng.ResetText();
                cmbName_Eng.SelectedText = "IT";
            }
            else if (cmbName_Lao.SelectedIndex == cmbName_Lao.FindString("ພະແນກອອກແບບ"))
            {
                cmbName_Eng.ResetText();
                cmbName_Eng.SelectedText = "Design";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    ds.Clear();
                    da = new SqlDataAdapter("Select * From tbDepartment Where Dep_ID=N'"+txtSearch.Text+"' Or Dep_Name_Lao=N'"+ txtSearch.Text + "' Or Dep_Name_Eng=N'"+ txtSearch.Text + "'", conn);
                    da.Fill(ds, "Dep");
                    dgvDepartment.DataSource = ds.Tables["Dep"];
                    dgvDepartment.Refresh();
                    dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    for (int i = 0; i < colname.Length; i++)
                    {
                        dgvDepartment.Columns[i].HeaderText = colname[i];
                    }
                }
                else
                {
                    Show_Data();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດສະແດງຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
