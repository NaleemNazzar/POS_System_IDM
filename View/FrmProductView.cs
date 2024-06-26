using POS_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.View
{
    public partial class FrmProductView : Form
    {
        private bool isCleared;

        public FrmProductView()
        {
            InitializeComponent();
        }

        private void FrmProductView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FrmProductAdd());
            LoadData(); // Refresh data after adding a new user
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(Dgvid);       // proID
            lb.Items.Add(Dgvname);     // pName
            lb.Items.Add(DgvcatID);    // pCatID
            lb.Items.Add(DgvBarcode);  // pBarcode
            lb.Items.Add(DgvCost);     // pCost
            lb.Items.Add(DgvSale);     // pPrice

            try
            {
                string qry;

                if (TxtSearch.Text == "      Search Here")
                {
                    qry = "SELECT proID, pName, pCatID, pBarcode, pCost, pPrice catName FROM Product INNER JOIN Category ON catID = pCatID";
                }
                else
                {
                    qry = @"SELECT proID, pName, pCatID, pBarcode, pCost, pPrice 
                    FROM Product INNER JOIN Category ON catID = pCatID
                    WHERE pName LIKE '%" + TxtSearch.Text + "%' ORDER BY proID DESC";
                }

                MainClass.LoadData(qry, DataGridView1, lb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is not a header cell
            if (e.RowIndex < 0) return;

            // Update
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvEdit")
            {
                FrmProductAdd frm = new FrmProductAdd();
                frm.id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                frm.catID = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["DgvcatID"].Value);
                frm.TxtName.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["Dgvname"].Value);
                frm.TxtBarcode.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvBarcode"].Value);
                frm.TxtCost.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvCost"].Value);
                frm.TxtPrice.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvSale"].Value);

                MainClass.BlurBackground(frm);
                LoadData();
            }

            // Delete
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvDel")
            {
                int id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string qry = "DELETE FROM Product WHERE proID = @id";
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", id);
                    if (MainClass.SQL(qry, ht) > 0)
                    {
                        MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!isCleared)
            {
                TxtSearch.Clear();
                PictureBox1.Hide(); // Assuming PictureBox1 is a search icon or something similar
                isCleared = true;
            }
            LoadData();
        }
    }

}
