using POS_System.Model;
using POS_System.View; // Namespace for views
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class FrmMain : Form
    {
        // Singleton instance of FrmMain
        static FrmMain _obj;

        // Property to get the singleton instance
        public static FrmMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FrmMain();
                }
                return _obj;
            }
        }

        // Constructor for FrmMain
        public FrmMain()
        {
            InitializeComponent(); // Initialize form components
        }

        // Event handler for form load event
        private void FrmMain_Load(object sender, EventArgs e)
        {
            _obj = this; // Set the singleton instance
            LblUser.Text = MainClass.USER; // Set the label text to the current username
            PictureBox.Image = MainClass.IMG; // Set the picture box image to the user image
            BtnHome.PerformClick(); // Simulate a click on the Home button
        }

        // Method to add controls to the CenterPanel
        public void AddControls(Form F)
        {
            this.CenterPanel.Controls.Clear(); // Clear existing controls
            F.Dock = DockStyle.Fill; // Set the docking style
            F.TopLevel = false; // Set the form as non-top-level
            CenterPanel.Controls.Add(F); // Add the form to the CenterPanel
            F.Show(); // Show the form
        }

        // Event handler for close button click event
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        // Event handler for maximize button click event
        private void BtnMax_Click(object sender, EventArgs e)
        {
            // Toggle between maximized and normal window state
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                CenterForm(); // Center the form manually
            }
        }

        // Method to center the form manually
        private void CenterForm()
        {
            this.StartPosition = FormStartPosition.Manual; // Set the start position manually
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, // Center horizontally
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2); // Center vertically
        }

        // Event handler for minimize button click event
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimize the form
        }

        // Event handler for Users button click event
        private void BtnUsers_Click(object sender, EventArgs e)
        {
            AddControls(new FrmUserView()); // Add FrmUserView to the CenterPanel
        }

        // Event handler for Category button click event
        private void BtnCategory_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCategoryView()); // Add FrmCategoryView to the CenterPanel
        }

        // Event handler for Supplier button click event
        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            AddControls(new FrmSupplierView()); // Add FrmSupplierView to the CenterPanel
        }

        // Event handler for Customers button click event
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCustomerView()); // Add FrmCustomerView to the CenterPanel
        }

        // Event handler for Product button click event
        private void BtnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new FrmProductView()); // Add FrmProductView to the CenterPanel
        }

        // Event handler for Purchase button click event
        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            AddControls(new FrmPurchaseView()); // Add FrmPurchaseView to the CenterPanel
        }

        // Event handler for Sales button click event
        private void BtnSales_Click(object sender, EventArgs e)
        {
            AddControls(new FrmSaleView()); // Add FrmSaleView to the CenterPanel
        }

        // Event handler for form closing event
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show confirmation dialog when closing the form
            DialogResult dr = MessageBox.Show("Are you sure you want to Exit the Application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true; // Cancel the form closing if the user selects No
            }
        }

        // Event handler for form closed event
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Exit the application when the form is closed
        }

        // Event handler for Home button click event
        private void BtnHome_Click(object sender, EventArgs e)
        {
            AddControls(new FrmDashboard()); // Add FrmDashboard to the CenterPanel
        }

        // Event handler for Report button click event
        private void BtnReport_Click(object sender, EventArgs e)
        {
            AddControls(new FrmReportView()); // Add FrmReports to the CenterPanel
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
