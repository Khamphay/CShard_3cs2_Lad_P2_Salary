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
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }

        SqlConnection conn = MyConnect.Connected();
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds = new DataSet();
        string posi_id = "";
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

        private void LoaPosition()
        {
            try
            {
                cmd = new SqlCommand("Select Po_Name_Eng From tbPosition",conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows && dr["Po_Name_Eng"].ToString()!="")
                {
                    while (dr.Read())
                    {
                        cmbPosition.Items.Add(dr["Po_Name_Eng"].ToString());
                        auto.Add(dr["Po_Name_Eng"].ToString());
                    }
                    cmbPosition.AutoCompleteCustomSource = auto;
                    cmbPosition.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cmbPosition.AutoCompleteSource = AutoCompleteSource.CustomSource;
                }
            }catch (Exception ex)
            {

            }finally
            {
                dr.Close();
            }
        }
        private void Save()
        {
            try
            {
                cmd = new SqlCommand("Insert Into Create_Account Values(@id, @name, @Posi, @user, @pass)", conn);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("name", txtName.Text);
                cmd.Parameters.AddWithValue("Posi", posi_id);
                cmd.Parameters.AddWithValue("user", txtUser.Text);
                cmd.Parameters.AddWithValue("pass", txtNewpass.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Create Completed !!!", "Create New User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearText()
        {
            txtID.Clear();
            txtName.Clear();
            txtNewpass.Clear();
            txtRepass.Clear();
            posi_id = "";
            txtUser.Clear();
        }

        private void brexit_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            DialogResult dir = MessageBox.Show("Are you sure?", "Exit programe", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dir == DialogResult.Yes)
            {
                this.Hide();
                login.Show();
            }
            else
            {
                
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            KeyBord.getKeyBord();
            LoaPosition();
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select Po_ID From tbPosition Where Po_Name_Eng=N'" + cmbPosition.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows && dr["Po_ID"].ToString() != "")
                {
                    dr.Read();
                    posi_id=dr["Po_ID"].ToString();
                }
            }
            catch (Exception ex)
            {

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
    }
}
