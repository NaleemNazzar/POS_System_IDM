using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace POS_System
{
    public partial class FrmReportViewer : Form
    {
        private ReportDocument _reportDocument;

        public FrmReportViewer(string reportPath)
        {
            InitializeComponent();
            _reportDocument = new ReportDocument();
            _reportDocument.Load(reportPath);
        }

        public void LoadReport()
        {
            crystalReportViewer.ReportSource = _reportDocument;
        }

        public void SetDatabaseLogon(string username, string password, string server, string database)
        {
            _reportDocument.SetDatabaseLogon(username, password, server, database);
        }

        public void RefreshReport()
        {
            _reportDocument.Refresh();
            crystalReportViewer.ReportSource = _reportDocument;
        }

        private void FrmReportViewer_Load(object sender, EventArgs e)
        {
            // Maximize the form when loaded
            this.WindowState = FormWindowState.Maximized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
