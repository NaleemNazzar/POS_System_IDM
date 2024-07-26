using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            //DataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            DataGridView1.CellClick += DataGridView1_CellClick;
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

            if (cusID > 0)
            {
                CbCustomer.SelectedValue = cusID;
                LoadForEdit();
                GrandTotal();
            }

            LoadProductsFromDatabase();
        }

        public void AddItems(string id, string name, string price, Image pimage, string cost, string barcode)
        {
            var w = new UcProuct()
            {
                PName = name,
                Price = price,
                PImage = pimage,
                PCost = cost,
                id = Convert.ToInt32(id),
                Barcode = barcode
            };

            flowLayoutPanel1.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (UcProuct)ss;

                // Display the barcode in the TxtBarcode TextBox
                TxtBarcode.Text = wdg.Barcode;

                foreach (DataGridViewRow item in DataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["Dgvproid"].Value) == wdg.id)
                    {
                        item.Cells["DgvQty"].Value = int.Parse(item.Cells["DgvQty"].Value.ToString()) + 1;
                        item.Cells["DgvAmount"].Value = int.Parse(item.Cells["DgvQty"].Value.ToString()) *
                            int.Parse(item.Cells["DgvPrice"].Value.ToString());
                        GrandTotal();
                        return;
                    }
                }

                //if not find the product in DataGridView
                DataGridView1.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, wdg.Price, wdg.Price, wdg.PCost });
                GrandTotal();
            };

        }

        private void GrandTotal()
        {
            double tot = 0;
            LblTotal.Text = "";
            foreach (DataGridViewRow item in DataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["DgvAmount"].Value.ToString());
            }

            LblTotal.Text = tot.ToString("N2");
        }

        private void LoadProductsFromDatabase()
        {
            string qry = "Select * From Product";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Byte[] imageArray = (byte[])row["PImage"];
                    byte[] imageByteArray = imageArray;

                    AddItems(row["proID"].ToString(), row["pName"].ToString(), row["pPrice"].ToString(),
                        Image.FromStream(new MemoryStream(imageArray)), row["pCost"].ToString(), row["pBarcode"].ToString());
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            TxtDate.Value = DateTime.Now;

            // Ensure the ComboBox has items before setting the SelectedIndex
            if (CbCustomer.Items.Count > 0)
            {
                CbCustomer.SelectedIndex = -1;
            }

            LblTotal.Text = "0.00";

            // Clear search text
            TxtSearch.Text = "";

            // Clear barcode text
            TxtBarcode.Text = "";
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var pro = (UcProuct)item;
                pro.Visible = pro.PName.ToLower().Contains(TxtSearch.Text.Trim().ToLower());
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
                    DataRow row = dt.Rows[0];
                    foreach (DataGridViewRow item in DataGridView1.Rows)
                    {
                        if (Convert.ToInt32(item.Cells["Dgvproid"].Value) == int.Parse(row["proID"].ToString()))
                        {
                            item.Cells["DgvQty"].Value = int.Parse(item.Cells["DgvQty"].Value.ToString()) + 1;
                            item.Cells["DgvAmount"].Value = int.Parse(item.Cells["DgvQty"].Value.ToString()) *
                                int.Parse(item.Cells["DgvPrice"].Value.ToString()) + 1;
                            GrandTotal();
                            TxtBarcode.Text = "";
                            return;
                        }
                    }

                    DataGridView1.Rows.Add(new object[] { 0, row["proID"].ToString(),
                            row["pName"].ToString(), 1, row["pPrice"].ToString(),
                            row["proID"].ToString(), row["pCost"].ToString() });
                    TxtBarcode.Text = "";

                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Initialize the error message variable
            string errorMessage = "";

            // Check if customer is selected
            if (CbCustomer.SelectedIndex == -1)
            {
                errorMessage += "Please select a customer.\n";
            }

            // Check if DataGridView has rows
            if (DataGridView1.Rows.Count == 0)
            {
                errorMessage += "Please add at least one product.\n";
            }

            // If there are any errors, display the error message and return
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Continue with saving process if validation passed
            string qry1 = ""; //for main table
            string qry2 = ""; //for details table
            int record = 0;

            if (id == 0) //insert
            {
                qry1 = @"INSERT INTO tblMain VALUES(@date,@type,@supID);
                    SELECT SCOPE_IDENTITY()";
            }
            else
            {
                qry1 = @"UPDATE tblMain SET mdate = @date, mType= @type, mSupCusID =@supID
                    WHERE MainID = @id";
            }

            SqlCommand cmd1 = new SqlCommand(qry1, MainClass.con);
            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Parameters.AddWithValue("@date", Convert.ToDateTime(TxtDate.Value).Date);
            cmd1.Parameters.AddWithValue("@type", "SAL");
            cmd1.Parameters.AddWithValue("@supID", Convert.ToInt32(CbCustomer.SelectedValue));
            if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }

            if (id == 0)
            {
                id = Convert.ToInt32(cmd1.ExecuteScalar());
            }
            else
            {
                cmd1.ExecuteNonQuery();
            }

            //insert details table
            foreach (DataGridViewRow row in DataGridView1.Rows)
            {
                int did = Convert.ToInt32(row.Cells["Dgvid"].Value);

                if (did == 0) // insert
                {
                    qry2 = @"INSERT INTO tblDetails VALUES(@mID,@proID,@qty,@price,@amount,@cost)";
                }
                else
                {
                    qry2 = @"UPDATE tblDetails SET dMainID = @mID, productID = @proID,
                    qty = @qty, price = @price, amount = @amount, cost = @cost
                    WHERE detailID = @id";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@id", did);
                cmd2.Parameters.AddWithValue("@mID", id);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["DgvProID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["DgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToInt32(row.Cells["DgvCost"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToInt32(row.Cells["DgvAmount"].Value));
                cmd2.Parameters.AddWithValue("@cost", Convert.ToInt32(row.Cells["DgvCost"].Value));
                record += cmd2.ExecuteNonQuery();
            }

            if (record > 0)
            {
                MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                id = 0;
                cusID = 0;
                TxtDate.Value = DateTime.Now;
                CbCustomer.SelectedIndex = 0;
                CbCustomer.SelectedIndex = -1;
                DataGridView1.Rows.Clear();
                LblTotal.Text = "0.00";
            }
        }

        private void LoadForEdit()
        {
            string qry = "SELECT * FROM tblDetails inner join product on proID = productID WHERE dMainID = " + id + "";
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
                pid = row["proID"].ToString();
                qty = row["qty"].ToString();
                cost = row["price"].ToString();
                amt = row["amount"].ToString();
                cost = row["cost"].ToString();

                //0 for Serial an id
                DataGridView1.Rows.Add(did, pid, pname, qty, cost, amt, cost);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Delete
            if (DataGridView1.CurrentCell != null && DataGridView1.CurrentCell.OwningColumn.Name == "DgvDel")
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int rowindex = DataGridView1.CurrentCell.RowIndex;

                    // Remove the row from the DataGridView
                    DataGridView1.Rows.RemoveAt(rowindex);

                    if (DataGridView1.CurrentRow != null && DataGridView1.CurrentRow.Cells["Dgvid"].Value != null)
                    {
                        int id = Convert.ToInt32(DataGridView1.CurrentRow.Cells["Dgvid"].Value);
                        string qry = "DELETE FROM tblMain WHERE MainID = " + id + "";
                        string qry2 = "DELETE FROM tblDetails WHERE dMainID = " + id + "";
                        Hashtable ht = new Hashtable();
                        MainClass.SQL(qry, ht);

                        if (MainClass.SQL(qry2, ht) > 0)
                        {
                            // MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    // Update the grand total after deleting the row
                    GrandTotal();
                }
            }
        }


    }
}
