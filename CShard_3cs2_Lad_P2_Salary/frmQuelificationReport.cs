﻿using System;
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
            crystalReportViewer1.RefreshReport();
        }
    }
}
