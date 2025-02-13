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
using System.Xml.Linq;

namespace POS_System.Model
{
    public partial class FrmPurchaseAdd : Form
    {
        public FrmPurchaseAdd()
        {
            InitializeComponent();
        }

        public int mainID = 0;
        public int supID = 0;


        private void CbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbProduct.SelectedIndex != -1)
            {
                TxtQty.Text = "";
                GetDetails();

                // Show barcode in TxtBarcode
                string qry = "SELECT pBarcode FROM Product WHERE proID = " + Convert.ToInt32(CbProduct.SelectedValue);
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                TxtBarcode.Text = cmd.ExecuteScalar().ToString();
            }
        }

        private void GetDetails()
        {
            string qry = "SELECT * FROM Product WHERE proID = " + Convert.ToInt32(CbProduct.SelectedValue) + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
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
            CbProduct.SelectedIndexChanged -= new EventHandler(CbProduct_SelectedIndexChanged);
            //stop before product load from database
            string qry = "SELECT proID 'id' , pName 'name' FROM Product";
            string qry2 = "SELECT supID 'id' , supName 'name' from Supplier";

            MainClass.CBFILL(qry, CbProduct);
            MainClass.CBFILL(qry2, CbSupplier);

            if (supID > 0)
            {
                CbSupplier.SelectedValue = supID;
                LoadForEdit();
            }
            //reenableit
            //at load we need to stop product selection change event
            CbProduct.SelectedIndexChanged += new EventHandler(CbProduct_SelectedIndexChanged);

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
            string errorMessage = ValidateInput();

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pid = CbProduct.SelectedValue.ToString();
            string pname = CbProduct.Text;
            string qty = TxtQty.Text;
            string cost = TxtCost.Text;
            string amt = TxtAmount.Text;

            // Add to DataGridView
            DataGridView1.Rows.Add(0, 0, pid, pname, qty, cost, amt);

            // Clear fields except Supplier
            CbProduct.SelectedIndex = -1;
            TxtQty.Text = "";
            TxtCost.Text = "";
            TxtAmount.Text = "";
            TxtBarcode.Text = ""; // Clear barcode field
        }



        private string ValidateInput()
        {
            StringBuilder errors = new StringBuilder();

            if (CbSupplier.SelectedIndex == -1)
            {
                errors.AppendLine("Please select a Supplier.");
            }

            if (CbProduct.SelectedIndex == -1)
            {
                errors.AppendLine("Please select a Product.");
            }

            if (string.IsNullOrWhiteSpace(TxtQty.Text))
            {
                errors.AppendLine("Please enter a Quantity.");
            }
            else
            {
                int quantity;
                if (!int.TryParse(TxtQty.Text, out quantity) || quantity <= 0)
                {
                    errors.AppendLine("Quantity should be a valid positive number.");
                }
            }

            return errors.ToString().Trim();
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
        private string ValidateSave()
        {
            StringBuilder errors = new StringBuilder();

            // Validate Date
            if (TxtDate.Value == null)
            {
                errors.AppendLine("Please select a Date.");
            }

            // Validate Supplier
            if (CbSupplier.SelectedIndex == -1)
            {
                errors.AppendLine("Please select a Supplier.");
            }

            // Validate DataGridView has rows
            if (DataGridView1.Rows.Count == 0)
            {
                errors.AppendLine("Please add at least one item to the purchase.");
            }

            // Additional validations as needed

            return errors.ToString().Trim();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateSave();

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Continue with save logic as before
            string qry1 = ""; // Query for main table
            string qry2 = ""; // Query for details table
            int record = 0;

            // Determine if it's an insert or update
            if (mainID == 0) // Insert
            {
                qry1 = @"INSERT INTO tblMain VALUES(@date, @type, @supID);
                    SELECT SCOPE_IDENTITY()";
            }
            else // Update
            {
                qry1 = @"UPDATE tblMain SET mdate = @date, mType = @type, mSupCusID = @supID
                    WHERE MainID = @id";
            }

            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            cmd1.Parameters.AddWithValue("@id", mainID);
            cmd1.Parameters.AddWithValue("@date", Convert.ToDateTime(TxtDate.Value).Date);
            cmd1.Parameters.AddWithValue("@type", "PUR"); // Assuming "PUR" is the type for purchase
            cmd1.Parameters.AddWithValue("@supID", Convert.ToInt32(CbSupplier.SelectedValue));

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }

            if (mainID == 0) // Execute scalar for insert
            {
                mainID = Convert.ToInt32(cmd1.ExecuteScalar());
            }
            else // Execute non-query for update
            {
                cmd1.ExecuteNonQuery();
            }

            // Insert/update details table
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                int did = Convert.ToInt32(row.Cells["Dgvid"].Value);

                if (did == 0) // Insert new detail
                {
                    qry2 = @"INSERT INTO tblDetails VALUES(@mID, @proID, @qty, @price, @amount, @cost)";
                }
                else // Update existing detail
                {
                    qry2 = @"UPDATE tblDetails SET dMainID = @mID, productID = @proID,
                    qty = @qty, price = @price, amount = @amount, cost = @cost
                    WHERE detailID = @id";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@id", did);
                cmd2.Parameters.AddWithValue("@mID", mainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["DgvProID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["DgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToInt32(row.Cells["DgvCost"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToInt32(row.Cells["DgvAmount"].Value));
                cmd2.Parameters.AddWithValue("@cost", Convert.ToInt32(row.Cells["DgvCost"].Value));

                record += cmd2.ExecuteNonQuery();
            }

            // Check if records were saved successfully
            if (record > 0)
            {
                MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form fields and variables
                mainID = 0;
                supID = 0;
                TxtDate.Value = DateTime.Now;
                CbSupplier.SelectedIndex = 0;
                CbSupplier.SelectedIndex = -1;
                DataGridView1.Rows.Clear();
            }
        }

        private void LoadForEdit()
        {
            string qry = "SELECT * FROM tblDetails inner join product on proID = productID WHERE dMainID = " + mainID + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                string did;
                string pid;
                string pname;
                string qty;
                string cost;
                string amt;
                did = row["detailID"].ToString();
                pname = row["pName"].ToString();
                pid = row["productID"].ToString();
                qty = row["qty"].ToString();
                cost = row["price"].ToString();
                amt = row["amount"].ToString();

                //0 for Serial an id
                DataGridView1.Rows.Add(0, did, pid, pname, qty, cost, amt);
            }
        }
    }
}