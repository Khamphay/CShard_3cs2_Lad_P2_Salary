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
        int id;

        string[] col = { "ລຳດັບ", "ຊື່(ພາສາລາວ)", "ນາມສະກຸນ(ພາສາລາວ)", "ຊື່(ພາສາອັງກິດ)", "ນາມສະກຸນ(ພາສາອັງກິດ)", "ເວລາເຂົ້າ", "ເວລາອອກ"};
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
                da = new SqlDataAdapter("Select Max(chk_ID) maxid From tbCheck_In_Out", con);
                table = new DataTable();
                da.Fill(table);
                if (table.Rows.Count > 0)
                {
                    id = int.Parse(table.Rows[0]["maxid"].ToString());
                }
                else
                {
                    id = 1;
                }

                cmd = new SqlCommand("Insert Into tbCheck_In_Out (ch_k_ID, Staff, check_in) Values(@id, @staff, @timeIn)", con);
                cmd.Parameters.AddWithValue("id", DbType.Int32).Value= id;
                cmd.Parameters.AddWithValue("staff", txtID.Text);
                cmd.Parameters.AddWithValue("timeIn", DbType.DateTime).Value= DateTime.Now;
                cmd.Parameters.AddWithValue("timeOut", DbType.DateTime).Value= DateTime.Now;
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
        private void Check_Out()
        {
            try
            {
                da = new SqlDataAdapter("Select chk_ID From tbCheck_In_Out Where Staff='"+txtID.Text+"'", con);
                table = new DataTable();
                da.Fill(table);
                if (table.Rows.Count > 0)
                {
                    id = int.Parse(table.Rows[0]["chk_ID"].ToString());
                }

                cmd = new SqlCommand("Update tbCheck_In_Out Set @timeOut Where ch_k_ID=@id", con);
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
        private void frmCheck_In_Out_Load(object sender, EventArgs e)
        {
            ShowData();
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
    }
}
