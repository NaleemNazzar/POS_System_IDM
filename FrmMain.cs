using POS_System.View;
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
        static FrmMain _obj;
        public static FrmMain Instance
        {
            get { if (_obj == null) { _obj = new FrmMain(); } return _obj; }
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
            LblUser.Text = MainClass.USER;
            PictureBox.Image = MainClass.IMG;
        }

        public void AddControls(Form F)
        {
            this.CenterPanel.Controls.Clear();
            F.Dock = DockStyle.Fill;
            F.TopLevel = false;
            CenterPanel.Controls.Add(F);
            F.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                CenterForm();
            }
        }

        private void CenterForm()
        {
            // Manually center the form on the screen
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            AddControls(new FrmUserView());
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCategoryView());
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            AddControls(new FrmSupplierView());
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            AddControls(new FrmCustomerView());
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new FrmProductView());
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            AddControls(new FrmPurchaseView());
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            AddControls(new FrmSaleView());
        }
    }
}
