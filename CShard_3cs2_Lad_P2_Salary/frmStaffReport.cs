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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CShard_3cs2_Lad_P2_Salary
{
    public partial class frmStaffReport : Form
    {
        string stid;
        public frmStaffReport(string id)
        {
            InitializeComponent();
            // crystalReportViewer1.RefreshReport();
                stid = id;
        }

        SqlConnection con = MyConnect.Connected();
        SqlCommand cmd;
        dsReport ds;
        SqlDataAdapter da;
        ReportDocument rd;


        ParameterFieldDefinition fieldDefinition;
        ParameterFieldDefinitions fieldDefinitions;
        ParameterDiscreteValue discreteValue =new ParameterDiscreteValue();
        ParameterValues parameterValues=new ParameterValues();


        private void frmStaffReport_Load(object sender, EventArgs e)
        {
            if (stid != "")
            {
                MessageBox.Show(stid);
                cmd = new SqlCommand("Select * From vw_Staff Where St_ID='"+stid+"'", con);
                da = new SqlDataAdapter(cmd);
                ds = new dsReport();
                da.Fill(ds, "Staff");
                rd = new ReportDocument();
                rd.Load(@"D:\Cshart3cs2\CShard_3cs2_Lad_P2_Salary\CShard_3cs2_Lad_P2_Salary\crReportStaff_One.rpt");
                rd.SetDataSource(ds);



                //St_ID
                discreteValue.Value = "";
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["st_id"];
                parameterValues = fieldDefinition.CurrentValues;
                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues); 
                
               // st_name
                discreteValue.Value = "";
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["st_name"];
                parameterValues = fieldDefinition.CurrentValues;
                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

               // tel
                discreteValue.Value = "";
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["tel"];
                parameterValues = fieldDefinition.CurrentValues;
                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);





                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.Refresh();

            }
            else
            {
                rd = new ReportDocument();
                rd.Load(@"D:\Cshart3cs2\CShard_3cs2_Lad_P2_Salary\CShard_3cs2_Lad_P2_Salary\crStaffReport.rpt");

                //St_ID
                discreteValue.Value = "";
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["st_id"];
                parameterValues = fieldDefinition.CurrentValues;
                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                // st_name
                discreteValue.Value = "";
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["st_name"];
                parameterValues = fieldDefinition.CurrentValues;
                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                // st_name
                discreteValue.Value = "";
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["tel"];
                parameterValues = fieldDefinition.CurrentValues;
                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                crystalReportViewer1.ReportSource = rd;
            }
        }
    }
}
