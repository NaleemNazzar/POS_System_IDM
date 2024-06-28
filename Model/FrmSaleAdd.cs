using System;
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

            LoadProductsFromDatabase();

        }

        public void AddItems(string id, string name, string price, Image pimage, string cost)
        {
            var w = new UcProuct()
            {
                PName = name,
                Price = price,
                PImage = pimage,
                PCost = cost,
                id = Convert.ToInt32(id)
            };

            flowLayoutPanel1.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (UcProuct)ss;
                foreach (DataGridViewRow item in DataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["Dgvproid"].Value) == wdg.id)
                    {
                        item.Cells["DgvQty"].Value = int.Parse(item.Cells["DgvQty"].Value.ToString()) +1;
                        item.Cells["DgvAmount"].Value = int.Parse(item.Cells["DgvQty"].Value.ToString()) *
                            int.Parse(item.Cells["DgvPrice"].Value.ToString()) + 1;
                        GrandTotal();
                        return;
                    }
                }

                //if not find the prouct in gv

                DataGridView1.Rows.Add(new object[] {0, wdg.id, wdg.PName,1,wdg.Price,wdg.Price,wdg.PCost});
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

            if(dt.Rows.Count >0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Byte[] imageArray = (byte[])row["PImage"];
                    byte[] imageByteArray = imageArray;

                    AddItems(row["proID"].ToString(), row["pName"].ToString(), row["pPrice"].ToString(),
                        Image.FromStream(new MemoryStream(imageArray)), row["pCost"].ToString());
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
            TxtDate.Value = DateTime.Now;
            CbCustomer.SelectedIndex = 0;
            CbCustomer.SelectedIndex = -1;
            LblTotal.Text = "0.00";
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
    }
}
