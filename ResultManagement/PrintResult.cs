using ResultManagement.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResultManagement.Reports;
using CrystalDecisions.Shared;
using ResultManagement.DataSets;
using CrystalDecisions.CrystalReports.Engine;

namespace ResultManagement
{
    public partial class PrintResult : Form
    {
        ResultProvider rstHelper = new ResultProvider();
        CommonUtility utils = new CommonUtility();
        public int ResultId;
        public PrintResult(int ResultId)
        {

            InitializeComponent();
            this.ResultId = ResultId;
          
        }

        private void PrintResult_Load(object sender, EventArgs e)
        {
            ResultRPT report = new ResultRPT();
            report.SetDataSource(rstHelper.GetResultsByStudent(ResultId));
           
            crystalReportViewer1.ReportSource = report;

            crystalReportViewer1.Refresh();
        }
       
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
