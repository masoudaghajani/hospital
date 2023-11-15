using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using System.Web;
namespace hospital
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        second se = new second();
        private void button1_Click_1(object sender, EventArgs e)
        {

            ReportDocument rptDoc = new ReportDocument();

            rptDoc.Load(System.IO.Path.Combine(Environment.CurrentDirectory, "Reports/ReportBimar.rpt"));
          string str=business.PrintQuery.StrPrintQuery;
            rptDoc.SetDataSource(se.Select("select * from bimar"));
            crystalReportViewer1.ReportSource = rptDoc;

        }

        private void Print_Load(object sender, EventArgs e)
        {
            
        }
    }
}
