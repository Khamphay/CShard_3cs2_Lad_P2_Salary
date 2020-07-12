﻿using System;
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
    public partial class BasicSalary : Form
    {
        public BasicSalary()
        {
            InitializeComponent();
        }

        SqlConnection con = MyConnect.Connected();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        private void ShowData()
        {
            try
            {
                da = new SqlDataAdapter("Select * from tbBasic_Salary",con);
                ds = new DataSet();
                da.Fill(ds, "sa");
                dgvSalary.DataSource = ds.Tables["sa"];
                dgvSalary.Columns[0].HeaderText = "ລະຫັດ";
                dgvSalary.Columns[1].HeaderText = "ຈຳນວນ";
                dgvSalary.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
                if(txtID.Text!="" && txtAmouat.Text != "")
                {
                    cmd = new SqlCommand("Insert into tbBasic_Salary Values(@id, @amuat)", con);
                    cmd.Parameters.AddWithValue("id", txtID.Text);
                    cmd.Parameters.AddWithValue("amuat", txtAmouat.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        ShowData();
                        txtID.Clear();
                        txtAmouat.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        } 
        private void Edit()
        {
            try
            {
                if(txtID.Text!="" && txtAmouat.Text != "")
                {
                    cmd = new SqlCommand("Update tbBasic_Salary Set Amount=@amuat Where Cas_ID=@id", con);
                    cmd.Parameters.AddWithValue("id", txtID.Text);
                    cmd.Parameters.AddWithValue("amuat", txtAmouat.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        ShowData();
                        txtID.Clear();
                        txtAmouat.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Delete()
        {
            try
            {
                if (txtID.Text != "")
                {
                    cmd = new SqlCommand("Delete From tbBasic_Salary  Where Cas_ID=@id", con);
                    cmd.Parameters.AddWithValue("id", txtID.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        ShowData();
                        txtID.Clear();
                        txtAmouat.Clear();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BasicSalary_Load(object sender, EventArgs e)
        {
            ShowData();
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

        private void txtAmouat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSalary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvSalary.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAmouat.Text = dgvSalary.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            frmBasiSalary report = new frmBasiSalary();
            report.ShowDialog();
        }
    }
}
