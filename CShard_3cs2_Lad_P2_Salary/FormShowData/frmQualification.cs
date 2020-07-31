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
    public partial class frmQualification : Form
    {
        public frmQualification()
        {
            InitializeComponent();
        }
        SqlConnection conn = MyConnect.Connected();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        string[] colname = { "ລະຫັດ", "ລະດັບການສຶກສາ(ພາສາອັງກິດ)", "ລະດັບການສຶກສາ(ພາສາລາວ)" };

        private void Show_Data()
        {
            try
            {
                ds.Clear();
                da = new SqlDataAdapter("Select * From tbQualification", conn);
                da.Fill(ds, "Qua");
                dgvQualification.DataSource = ds.Tables["Qua"];
                dgvQualification.Refresh();

                for (int i = 0; i < colname.Length; i++)
                {
                    dgvQualification.Columns[i].HeaderText = colname[i];
                    if (i != 0)
                    {
                        dgvQualification.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
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
                cmd = new SqlCommand("Insert Into tbQualification Values(@id, @nameEng, @nameLao)", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("nameEng", cmbNameEngQ.Text);
                cmd.Parameters.AddWithValue("nameLao", cmbNameLaoQ.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMssg("ບໍ່ສາມາດບັນທືກຂໍ້ມູນໄດ້ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "ເກີດບັນຫາ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit()
        {
            try
            {
                cmd = new SqlCommand("Update  tbQualification Set Qua_Name_Eng=@nameEng, Qua_Name_Lao=@nameLao Where Qua_ID=@id", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("nameEng", cmbNameEngQ.Text);
                cmd.Parameters.AddWithValue("nameLao", cmbNameLaoQ.Text);
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
                cmd = new SqlCommand("Delete From  tbQualification  Where Qua_ID=@id", conn);
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
            cmbNameLaoQ.ResetText();
            cmbNameEngQ.ResetText();
        }

        private void frmQualification_Load(object sender, EventArgs e)
        {
            KeyBord.getKeyBord();
            Show_Data();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = KeyBord.eng;
        }

        private void txtNameLao_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = KeyBord.lao;
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvQualification_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvQualification.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbNameEngQ.Text = dgvQualification.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbNameLaoQ.Text = dgvQualification.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void cmbNameEng_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNameEngQ.SelectedIndex == cmbNameEngQ.FindString("Aministative"))
            {
                cmbNameLaoQ.ResetText();
                cmbNameLaoQ.SelectedText = "ການບໍລີຫານ";
            }
            else if(cmbNameEngQ.SelectedIndex==cmbNameEngQ.FindString("IT"))
            {
                cmbNameLaoQ.ResetText();
                cmbNameLaoQ.SelectedText = "ໄອທີ";
            }else if (cmbNameEngQ.SelectedIndex == cmbNameEngQ.FindString("Design"))
            {
                cmbNameLaoQ.ResetText();
                cmbNameLaoQ.SelectedText = "ອອແບບ";
            }else if (cmbNameEngQ.SelectedIndex == cmbNameEngQ.FindString("Financial"))
            {
                cmbNameLaoQ.ResetText();
                cmbNameLaoQ.SelectedText = "ການເງີນ";
            }
        }
       
        private void cmbNameLao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNameLaoQ.SelectedIndex == cmbNameLaoQ.FindString("ການບໍລີຫານ"))
            {
                cmbNameEngQ.ResetText();
                cmbNameEngQ.SelectedText = "Aministative";
            } else if (cmbNameLaoQ.SelectedIndex == cmbNameLaoQ.FindString("ໄອທີ"))
            {
                cmbNameEngQ.ResetText();
                cmbNameEngQ.SelectedText = "IT";
            } else if (cmbNameLaoQ.SelectedIndex == cmbNameLaoQ.FindString("ອອແບບ"))
            {
                cmbNameEngQ.ResetText();
                cmbNameEngQ.SelectedText = "Design";
            } else if (cmbNameLaoQ.SelectedIndex == cmbNameLaoQ.FindString("ການເງີນ"))
            {
                cmbNameEngQ.ResetText();
                cmbNameEngQ.SelectedText = "Financial";
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            frmQuelificationReport report = new frmQuelificationReport();
            report.ShowDialog();
        }
    }
}
