using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Model
{
    public partial class FrmSaleAdd : Form
    {
        public FrmSaleAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int cusID = 0;

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSaleAdd_Load(object sender, EventArgs e)
        {
            string qry = @"Select cusID 'id' , cusName 'name' from Customer";
            MainClass.CBFILL(qry, CbCustomer);

            if (cusID>0)
            {
                CbCustomer.SelectedValue = cusID;
            }
        }
    }
}
