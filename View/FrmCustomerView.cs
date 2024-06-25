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
    public partial class FrmCustomerView : Form
    {
        private bool isCleared = false;
        public FrmCustomerView()
        {
            InitializeComponent();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!isCleared)
            {
                TxtSearch.Clear();
                PictureBox1.Hide(); // Assuming PictureBox1 is a search icon or something similar
                isCleared = true;
            }
        }

        private void FrmCustomerView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FrmCustomerAdd());
            LoadData(); // Refresh data after adding a new customer
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(Dgvid);
            lb.Items.Add(Dgvname);
            lb.Items.Add(DgvPhone);
            lb.Items.Add(DgvEmail);

            try
            {
                string qry;

                if (TxtSearch.Text == "      Search Here")
                {
                    qry = @"SELECT * FROM Customer";
                }
                else
                {
                    qry = @"SELECT * FROM Customer
                            WHERE cusName LIKE '%" + TxtSearch.Text + "%' ORDER BY cusID DESC";
                }

                MainClass.LoadData(qry, DataGridView1, lb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is not a header cell
            if (e.RowIndex < 0) return;

            // Update
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvEdit")
            {
                FrmCustomerAdd frm = new FrmCustomerAdd();
                frm.id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                frm.TxtName.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["Dgvname"].Value);
                frm.TxtPhone.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvPhone"].Value);
                frm.TxtEmail.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvEmail"].Value);

                MainClass.BlurBackground(frm);
                LoadData();
            }

            // Delete
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvDel")
            {
                int id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string qry = "DELETE FROM Customer WHERE cusID = @id";
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
    }
}
