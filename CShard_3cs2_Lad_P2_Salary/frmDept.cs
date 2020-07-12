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
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        string[] colname = { "ລະຫັດ", "ພະແນກ" };
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

            }
        }
        private void Save()
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbDepartment Values(@id, @name)", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("name", txtName.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                    ClearText();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit()
        {
            try
            {
                cmd = new SqlCommand("Update  tbDepartment Set Dep_Name=@name Where Dep_ID=@id", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("name", txtName.Text);
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
                cmd = new SqlCommand("Delete From  tbDepartment  Where Dep_ID=@id", conn);
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
                txtName.Text= dgvDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
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
            Delete();
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
    }
}
