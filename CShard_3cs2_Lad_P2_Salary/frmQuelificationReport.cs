using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShard_3cs2_Lad_P2_Salary
{
    public partial class frmQuelificationReport : Form
    {
        public frmQuelificationReport()
        {
            InitializeComponent();
            //crystalReportViewer1.RefreshReport();
        }

        ReportDocument rd;
        ParameterFieldDefinition fieldDefinition;
        ParameterFieldDefinitions fieldDefinitions;
        ParameterDiscreteValue discreteValue=new ParameterDiscreteValue();
        ParameterValues parameterValues=new ParameterValues();

        private void frmQuelificationReport_Load(object sender, EventArgs e)
        {

            rd = new ReportDocument();
            rd.Load(@"D:\Cshart3cs2\CShard_3cs2_Lad_P2_Salary\CShard_3cs2_Lad_P2_Salary\crQuelifiReport.rpt");

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
            crystalReportViewer1.Refresh();
        }
    }
}
