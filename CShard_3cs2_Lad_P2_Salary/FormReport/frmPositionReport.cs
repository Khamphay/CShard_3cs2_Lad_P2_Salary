﻿using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmPositionReport : Form
    {
        public frmPositionReport()
        {
            InitializeComponent();
            // crystalReportViewer1.RefreshReport();
        }

        ReportDocument rd;
        ParameterFieldDefinition fieldDefinition;
        ParameterFieldDefinitions fieldDefinitions;
        ParameterDiscreteValue discreteValue=new ParameterDiscreteValue();
        ParameterValues parameterValues=new ParameterValues();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void frmPositionReport_Load(object sender, EventArgs e)
        {
            //ReportDocument rd;
            //ParameterFieldDefinition fieldDefinition;
            //ParameterFieldDefinitions fieldDefinitions;
            //ParameterDiscreteValue discreteValue;
            //ParameterValues parameterValues;

            rd = new ReportDocument();
            rd.Load(@"D:\Cshart3cs2\CShard_3cs2_Lad_P2_Salary\CShard_3cs2_Lad_P2_Salary\Report\crPositionReport.rpt");

            //St_ID
            discreteValue.Value = MyModel.staff[5];
            fieldDefinitions = rd.DataDefinition.ParameterFields;
            fieldDefinition = fieldDefinitions["st_id"];
            parameterValues = fieldDefinition.CurrentValues;
            parameterValues.Clear();
            parameterValues.Add(discreteValue);
            fieldDefinition.ApplyCurrentValues(parameterValues);

            // st_name
            discreteValue.Value = MyModel.staff[0];
            fieldDefinitions = rd.DataDefinition.ParameterFields;
            fieldDefinition = fieldDefinitions["st_name"];
            parameterValues = fieldDefinition.CurrentValues;
            parameterValues.Clear();
            parameterValues.Add(discreteValue);
            fieldDefinition.ApplyCurrentValues(parameterValues);

            // st_name
            discreteValue.Value = MyModel.staff[4];
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
