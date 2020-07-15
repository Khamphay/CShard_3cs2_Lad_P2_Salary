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
    public partial class frmCheck_In_Out : Form
    {
        public frmCheck_In_Out()
        {
            InitializeComponent();
            //lbDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            timer1.Start();
        }


        SqlConnection con = MyConnect.Connected();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        DataTable table;
        AutoCompleteStringCollection auto;
        int id;

        string[] col = { "ລຳດັບ","ລະຫັດ ພ/ງ" ,"ຊື່(ພາສາລາວ)", "ນາມສະກຸນ(ພາສາລາວ)", "ຊື່(ພາສາອັງກິດ)", "ນາມສະກຸນ(ພາສາອັງກິດ)", "ເວລາເຂົ້າ", "ເວລາອອກ"};
        private void ShowData()
        {
            try
            {
                da = new SqlDataAdapter("Select * From vw_Check_In_Out", con);
                ds = new DataSet();
                da.Fill(ds, "inout");
                dgvCheckInOut.DataSource = ds.Tables["inout"];
                for(int i = 0; i < col.Length; i++)
                {
                    dgvCheckInOut.Columns[i].HeaderText = col[i];
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Check_IN()
        {
            try
            {
                if (txtID.Text != "" && txtName.Text != "" && txtSureName.Text != "" && txtTel.Text != "" && txtemail.Text != "") 
                {
                    da = new SqlDataAdapter("Select chk_ID From tbCheck_In_Out Where Staff='" + txtID.Text + "' And (check_in Is not null And check_out Is null)", con);
                    table = new DataTable();
                    da.Fill(table);
                    if (table.Rows.Count < 1)
                    {

                        da = new SqlDataAdapter("Select Max(chk_ID) maxid From tbCheck_In_Out", con);
                        table = new DataTable();
                        da.Fill(table);
                        if (table.Rows.Count > 0 && table.Rows[0][0].ToString() != "")
                        {
                            id = int.Parse(table.Rows[0][0].ToString()) + 1;
                        }
                        else
                        {
                            id = 1;
                        }

                        cmd = new SqlCommand("Insert Into tbCheck_In_Out (chk_ID, Staff, check_in) Values(@id, @staff, @timeIn)", con);
                        cmd.Parameters.AddWithValue("id", DbType.Int32).Value = id;
                        cmd.Parameters.AddWithValue("staff", txtID.Text);
                        cmd.Parameters.AddWithValue("timeIn", DbType.DateTime).Value = DateTime.Now;
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            ShowData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You had check-in!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void Check_Out()
        {
            try
            {
                da = new SqlDataAdapter("Select chk_ID From tbCheck_In_Out Where Staff='"+txtID.Text+ "' And check_out Is Null", con);
                table = new DataTable();
                da.Fill(table);
                if (table.Rows.Count > 0)
                {
                    id = int.Parse(table.Rows[0]["chk_ID"].ToString());
                }

                cmd = new SqlCommand("Update tbCheck_In_Out Set check_out=@timeOut Where chk_ID=@id", con);
                cmd.Parameters.AddWithValue("id", DbType.Int32).Value = id;
                cmd.Parameters.AddWithValue("timeOut", DbType.DateTime).Value = DateTime.Now;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    ShowData();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ShowMemberID()
        {
            try
            {
                auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select St_ID From tbStaff", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auto.Add(dr["St_ID"].ToString());
                }
                txtID.AutoCompleteCustomSource = auto;
                txtID.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dr.Close();
            }
        }

        private void frmCheck_In_Out_Load(object sender, EventArgs e)
        {
            ShowData();
            ShowMemberID();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
           //timer1.Interval = 100;
        }

        private void frmCheck_In_Out_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            frmCheckInOutReport report = new frmCheckInOutReport();
            report.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_IN();
        }

        private void btnewuser_Click(object sender, EventArgs e)
        {
            Check_Out();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("Select Name_Lao, Surname_Lao, mobile, email From tbStaff Where St_ID='" + txtID.Text + "'", con);
                table = new DataTable();
                da.Fill(table);
                if (table.Rows.Count > 0)
                {
                    txtName.Text = table.Rows[0][0].ToString();
                    txtSureName.Text = table.Rows[0][1].ToString();
                    txtTel.Text = table.Rows[0][2].ToString();
                    txtemail.Text = table.Rows[0][3].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtSureName.Clear();
                    txtTel.Clear();
                    txtemail.Clear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DisbleKey(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
