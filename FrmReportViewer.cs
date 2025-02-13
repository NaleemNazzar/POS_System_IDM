using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Windows.Forms;

namespace POS_System
{
    public partial class FrmReportViewer : Form
    {
        private string _reportPath;

        public FrmReportViewer(string reportPath)
        {
            InitializeComponent();
            _reportPath = reportPath;
        }

        private void FrmReportViewer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadReport();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void LoadReport()
        {
            try
            {
                Console.WriteLine($"Loading report from path: {_reportPath}");
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(_reportPath);
                crystalReportViewer.ReportSource = reportDocument;
                Console.WriteLine("Report loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}");
            }
        }

        public void SetDatabaseLogon(string userID, string password, string serverName, string databaseName)
        {
            try
            {
                Console.WriteLine("Setting database logon credentials.");
                ReportDocument reportDocument = (ReportDocument)crystalReportViewer.ReportSource;

                TableLogOnInfo logOnInfo = new TableLogOnInfo();
                ConnectionInfo connectionInfo = new ConnectionInfo
                {
                    ServerName = serverName,
                    DatabaseName = databaseName,
                    UserID = userID,
                    Password = password
                };

                foreach (Table table in reportDocument.Database.Tables)
                {
                    logOnInfo = table.LogOnInfo;
                    logOnInfo.ConnectionInfo = connectionInfo;
                    table.ApplyLogOnInfo(logOnInfo);
                    Console.WriteLine($"Applied logon info to table: {table.Name}");
                }

                foreach (ReportDocument subreport in reportDocument.Subreports)
                {
                    foreach (Table table in subreport.Database.Tables)
                    {
                        logOnInfo = table.LogOnInfo;
                        logOnInfo.ConnectionInfo = connectionInfo;
                        table.ApplyLogOnInfo(logOnInfo);
                        Console.WriteLine($"Applied logon info to subreport table: {table.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting database logon: {ex.Message}");
            }
        }
    }
}
