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
    public partial class FrmSaleView : Form
    {
        private bool isCleared;

        public FrmSaleView()
        {
            InitializeComponent();
        }

        private void FrmSaleView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FrmSaleAdd());
            LoadData(); // Refresh data after adding a new user
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(Dgvid);
            lb.Items.Add(DgvDate);
            lb.Items.Add(DgvCusID);
            lb.Items.Add(DgvCustomer);
            lb.Items.Add(DgvAmount);

            try
            {
                string qry;

                if (TxtSearch.Text == "      Search Here")
                {
                    qry = "Select dMainID, mdate , m.mSupCusID,c.cusName, SUM(d.amount) from tblMain m inner join tblDetails d on d.dMainID = m.MainID inner join Customer c on c.cusID = m.mSupCusID where m.mType = 'SAL' group by dMainID , mdate , m.mSupCusID,c.cusName";
                }
                else
                {
                    qry = @"Select dMainID, mdate , m.mSupCusID,c.cusName, SUM(d.amount) from tblMain m 
                            inner join tblDetails d on d.dMainID = m.MainID
                            inner join Customer c on c.cusID = m.mSupCusID
                            where m.mType = 'SAL'and cusName LIKE '%" + TxtSearch.Text + "%'" +
                            "group by dMainID , mdate , m.mSupCusID,c.cusName";
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
                FrmSaleAdd frm = new FrmSaleAdd();
                frm.id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                frm.cusID = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["DgvCusID"].Value);

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
                    string qry = "DELETE FROM tblMain WHERE MainID = " + id + "";
                    string qry2 = "DELETE FROM tblDetails WHERE dMainID = " + id + "";

                    Hashtable ht = new Hashtable();
                    //ht.Add("@id", id);
                    MainClass.SQL(qry, ht);
                    if (MainClass.SQL(qry2, ht) > 0)
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
