using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Model
{
    public partial class FrmPurchaseAdd : Form
    {
        public FrmPurchaseAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int supID = 0;
       

        private void CbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbProduct.SelectedIndex !=-1)
            {
                TxtQty.Text = "";
                GetDetails();
            }
        }
        private void GetDetails()
        {
            string qry = "SELECT * FROM Product WHERE proID = " + Convert.ToInt32(CbProduct.SelectedValue) + "";
            SqlCommand cmd = new SqlCommand(qry,MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                TxtCost.Text = dt.Rows[0]["pCost"].ToString();
                Calculate();
            }
        }

        private void Calculate()
        {
            double qty = 0;
            double cost = 0;
            double amt = 0;

            double.TryParse(TxtQty.Text, out qty);
            double.TryParse(TxtCost.Text, out cost);

            amt = qty * cost;
            TxtAmount.Text = amt.ToString();

        }

        private void TxtQty_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPurchaseAdd_Load(object sender, EventArgs e)
        {
            string qry = "SELECT proID 'id' , pName 'name' FROM Product";
            string qry2 = "SELECT supID 'id' , supName 'name' from Supplier";

            MainClass.CBFILL(qry, CbProduct);
            MainClass.CBFILL(qry2, CbSupplier);

            if (supID > 0)
            {
                CbSupplier.SelectedValue = supID;
            }
        }

        private void TxtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string qry = "SELECT * FROM Product WHERE pBarcode LIKE '" + TxtBarcode.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    CbProduct.SelectedValue = Convert.ToInt32(dt.Rows[0]["proID"].ToString());
                    Calculate();
                    TxtBarcode.Text = "";
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string pid;
            string pname;
            string qty;
            string cost;
            string amt;

            pname = CbProduct.Text;
            pid = CbProduct.SelectedValue.ToString();
            qty = TxtQty.Text;
            cost = TxtCost.Text;
            amt = TxtAmount.Text;

            //0 for Serial an id
            DataGridView1.Rows.Add(0, 0, pid, pname, qty, cost, amt);
            CbProduct.SelectedIndex = 0;
            CbProduct.SelectedIndex = -1;
            TxtQty.Text = "";
            TxtCost.Text = "";
            TxtAmount.Text = "";

        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           

            int count = 0;

            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
    }
}
