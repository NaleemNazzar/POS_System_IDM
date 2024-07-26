using POS_System.Model; // Import the namespace containing your data models
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System.View
{
    public partial class FrmSaleView : Form
    {
        private bool isCleared = false;

        public FrmSaleView()
        {
            InitializeComponent();
        }

        // Load event handler for FrmSaleView
        private void FrmSaleView_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data initially when the form loads
        }

        // Add button click event handler
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Open FrmSaleAdd form with blurred background
            MainClass.BlurBackground(new FrmSaleAdd());
            LoadData(); // Refresh data after adding a new sale
        }

        // Method to load data into the DataGridView
        private void LoadData()
        {
            // Prepare a ListBox to store DataGridView column names for data binding
            ListBox lb = new ListBox();
            lb.Items.Add(Dgvid);        // Sale ID column
            lb.Items.Add(DgvDate);      // Sale Date column
            lb.Items.Add(DgvCusID);     // Customer ID column
            lb.Items.Add(DgvCustomer);  // Customer Name column
            lb.Items.Add(DgvAmount);    // Sale Amount column

            try
            {
                string qry;

                // Check if the search box contains the placeholder text
                if (TxtSearch.Text == " Search Here")
                {
                    // Query to select all sales
                    qry = "SELECT dMainID, mdate, m.mSupCusID, c.cusName, SUM(d.amount) " +
                          "FROM tblMain m " +
                          "INNER JOIN tblDetails d ON d.dMainID = m.MainID " +
                          "INNER JOIN Customer c ON c.cusID = m.mSupCusID " +
                          "WHERE m.mType = 'SAL' " +
                          "GROUP BY dMainID, mdate, m.mSupCusID, c.cusName";
                }
                else
                {
                    // Query to search sales by customer name and order by date
                    qry = @"SELECT dMainID, mdate, m.mSupCusID, c.cusName, SUM(d.amount) " +
                           "FROM tblMain m " +
                           "INNER JOIN tblDetails d ON d.dMainID = m.MainID " +
                           "INNER JOIN Customer c ON c.cusID = m.mSupCusID " +
                           "WHERE m.mType = 'SAL' AND cusName LIKE '%" + TxtSearch.Text + "%' " +
                           "GROUP BY dMainID, mdate, m.mSupCusID, c.cusName";
                }

                // Load data into DataGridView using MainClass.LoadData method
                MainClass.LoadData(qry, DataGridView1, lb);
            }
            catch (Exception ex)
            {
                // Show an error message if there is an exception loading data
                MessageBox.Show("Error loading sale data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cell click event handler for DataGridView1
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is not a header cell
            if (e.RowIndex < 0) return;

            // Update action
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvEdit")
            {
                // Open FrmSaleAdd form with data pre-filled for editing
                FrmSaleAdd frm = new FrmSaleAdd();
                frm.id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                frm.cusID = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["DgvCusID"].Value);

                MainClass.BlurBackground(frm); // Blur background and show the form
                LoadData(); // Refresh data after updating a sale
            }

            // Delete action
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvDel")
            {
                // Get the ID of the selected sale
                int id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                // Show a confirmation message before deleting the sale
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this sale?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Query to delete the sale by ID
                    string qry = "DELETE FROM tblMain WHERE MainID = " + id + "";
                    string qry2 = "DELETE FROM tblDetails WHERE dMainID = " + id + "";

                    Hashtable ht = new Hashtable();
                    // Execute the delete query and check if it was successful
                    MainClass.SQL(qry, ht);
                    if (MainClass.SQL(qry2, ht) > 0)
                    {
                        MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh data after deleting a sale
                    }
                }
            }
        }

        // Text changed event handler for TxtSearch
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // If the search text box is not cleared yet
            if (!isCleared)
            {
                TxtSearch.Clear(); // Clear the text box
                isCleared = true; // Set the isCleared flag to true
            }
            else
            {
                LoadData(); // Trigger search and load data whenever the text changes
            }
        }
    }
}
