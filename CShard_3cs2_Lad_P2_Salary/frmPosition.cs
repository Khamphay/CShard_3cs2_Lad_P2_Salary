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
    public partial class frmPosition : Form
    {
        public frmPosition()
        {
            InitializeComponent();
        }

        SqlConnection conn = MyConnect.Connected();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        string[] colname = { "ລະຫັດ", "ຕຳແໜ່ງ(ພາສາອັງກິດ)", "ຕຳແໜ່ງ(ພາສາລາວ)" };

        private void Show_Data()
        {
            try
            {
                ds.Clear();
                da = new SqlDataAdapter("Select * From tbPosition", conn);
                da.Fill(ds, "Pos");
                dgvPosition.DataSource = ds.Tables["Pos"];
                dgvPosition.Refresh();
                
                for (int i = 0; i < colname.Length; i++)
                {
                    dgvPosition.Columns[i].HeaderText = colname[i];
                    if (i != 0) { 
                        dgvPosition.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void Save()
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbPosition Values(@id, @nameEng, @nameLao)", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("nameEng", cmbNameEngP.Text);
                cmd.Parameters.AddWithValue("nameLao", cmbNameLaoP.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                    ClearText();
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
                cmd = new SqlCommand("Update  tbPosition Set Po_Name_Eng=@nameEng, Po_Name_Lao=@nameLao Where Po_ID=@id", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("nameEng", cmbNameEngP.Text);
                cmd.Parameters.AddWithValue("nameLao", cmbNameLaoP.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete()
        {
            try
            {
                cmd = new SqlCommand("Delete From  tbPosition  Where Po_ID=@id", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.ExecuteNonQuery();
                Show_Data();
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearText()
        {
            txtID.Clear();
            cmbNameLaoP.ResetText();
            cmbNameEngP.ResetText();
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            KeyBord.getKeyBord();
            Show_Data();
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

        private void txtID_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = KeyBord.eng;
        }

        private void txtNameLao_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = KeyBord.lao;
        }

        private void dgvPosition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvPosition.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbNameEngP.Text = dgvPosition.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbNameLaoP.Text = dgvPosition.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            }else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ພະແນກບໍລິຫານ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Aministive";
            }else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ຜູ້ບໍລິຫານ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Manager";
            }else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ຫົວໜ້າພະແນກ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Head of Department";
            }else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ຮອງພະແນກ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Deputy of Department";
            }else if (cmbNameLaoP.SelectedIndex == cmbNameLaoP.FindString("ພະນັກງານ"))
            {
                cmbNameEngP.ResetText();
                cmbNameEngP.SelectedText = "Employee";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
            }else if (cmbNameEngP.SelectedIndex == cmbNameEngP.FindString("Manager"))
            {
                cmbNameLaoP.ResetText();
                cmbNameLaoP.SelectedText = "ຫົວໜັາພະແນກ";
            }else if (cmbNameEngP.SelectedIndex == cmbNameEngP.FindString("Head of Department"))
            {
                cmbNameLaoP.ResetText();
                cmbNameLaoP.SelectedText = "ຫົວໜ້າພະແນກ";
            }else if (cmbNameEngP.SelectedIndex == cmbNameEngP.FindString("Deputy of Department"))
            {
                cmbNameLaoP.ResetText();
                cmbNameLaoP.SelectedText = "ຮອງພະແນກ";
            }else if (cmbNameEngP.SelectedIndex == cmbNameEngP.FindString("Employee"))
            {
                cmbNameLaoP.ResetText();
                cmbNameLaoP.SelectedText = "ພະນັກງານ";
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            frmPositionReport report = new frmPositionReport();
            report.ShowDialog();
        }
    }
}
