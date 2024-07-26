using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_System
{
    public partial class FrmReportView : Form
    {
        private readonly string _connectionString;
        private readonly string _username = "Naleem";
        private readonly string _password = "12345";
        private readonly string _server = "DESKTOP-F0KSCG6\\SQLEXPRESS";

        public FrmReportView()
        {
            InitializeComponent();
            _connectionString = $"Server={_server};Database=POS;User Id={_username};Password={_password};";
        }

        private async void BtnViewProductList_Click(object sender, EventArgs e)
        {
            await ShowReportIfAuthenticated("RptProductList.rpt");
        }

        private async void BtnViewSupplierList_Click(object sender, EventArgs e)
        {
            await ShowReportIfAuthenticated("RptSupplierList.rpt");
        }

        private async void BtnViewCustomerList_Click(object sender, EventArgs e)
        {
            await ShowReportIfAuthenticated("RptCustomersList.rpt");
        }

        private async void BtnProfitOrLossReport_Click(object sender, EventArgs e)
        {
            await ShowReportIfAuthenticated("RptProfitOrLossReport.rpt");
        }

        private async void BtnViewPurchaseReport_Click(object sender, EventArgs e)
        {
            await ShowReportIfAuthenticated("RptPurchaseReport.rpt");
        }

        private async void BtnViewSalesReport_Click(object sender, EventArgs e)
        {
            await ShowReportIfAuthenticated("RptSalesReport.rpt");
        }

        private async void BtnViewStockBalance_Click(object sender, EventArgs e)
        {
            await ShowReportIfAuthenticated("RptStockBalance.rpt");
        }

        private async Task ShowReportIfAuthenticated(string reportFileName)
        {
            if (await ValidateDatabaseCredentialsAsync())
            {
                await ShowReportWithLoader(reportFileName);
            }
            else
            {
                MessageBox.Show("Unable to connect to the database. Please check your connection settings.");
            }
        }

        private async Task<bool> ValidateDatabaseCredentialsAsync()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    Console.WriteLine("Database connection successful.");
                    return true;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }

        private async Task ShowReportWithLoader(string reportFileName)
        {
            using (FrmReportLoader loader = new FrmReportLoader())
            {
                loader.SetReportName(reportFileName);
                loader.Show();

                for (int i = 0; i <= 100; i += 10)
                {
                    loader.UpdateProgress(i);
                    await Task.Delay(50); // Simulate loading
                }

                loader.Close();
            }
            ShowReport(reportFileName);
        }

        private void ShowReport(string reportFileName)
        {
            try
            {
                string reportPath = $@"C:\Users\nalee\Downloads\C# Project\POS_System\Reports\{reportFileName}";

                using (FrmReportViewer reportViewer = new FrmReportViewer(reportPath))
                {
                    reportViewer.LoadReport();
                    reportViewer.SetDatabaseLogon(_username, _password, _server, "POS");
                    reportViewer.RefreshReport(); // Ensure the report is refreshed
                    reportViewer.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying report: {ex.Message}");
            }
        }


        private void FrmReportView_Load(object sender, EventArgs e)
        {
            // Additional initialization if needed
        }
    }
}
