using POS_System.Model; // Import the namespace containing your data models
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System.View
{
    public partial class FrmPurchaseView : Form
    {
        private bool isCleared = false;

        public FrmPurchaseView()
        {
            InitializeComponent();
        }

        // Load event handler for FrmPurchaseView
        private void FrmPurchaseView_Load(object sender, EventArgs e)
        {
            LoadData(); // Load initial data when the form loads
        }

        // Add button click event handler
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Open FrmPurchaseAdd form with blurred background
            MainClass.BlurBackground(new FrmPurchaseAdd());
            LoadData(); // Refresh data after adding a new purchase
        }

        // Method to load data into the DataGridView
        private void LoadData()
        {
            // Prepare a ListBox to store DataGridView column names for data binding
            ListBox lb = new ListBox();
            lb.Items.Add(Dgvid);        // Purchase ID column
            lb.Items.Add(DgvDate);      // Purchase Date column
            lb.Items.Add(DgvSupID);     // Supplier ID column
            lb.Items.Add(DgvSupplier);  // Supplier Name column
            lb.Items.Add(DgvAmount);    // Total Amount column

            try
            {
                string qry;

                // Check if the search box contains the placeholder text
                if (TxtSearch.Text == " Search Here")
                {
                    // Query to select all purchases with their total amounts grouped by supplier
                    qry = @"SELECT dMainID, mdate, m.mSupCusID, s.supName, SUM(d.amount)
                            FROM tblMain m
                            INNER JOIN tblDetails d ON d.dMainID = m.MainID
                            INNER JOIN Supplier s ON s.supID = m.mSupCusID
                            WHERE m.mType = 'PUR'
                            GROUP BY dMainID, mdate, m.mSupCusID, s.supName";
                }
                else
                {
                    // Query to search purchases by supplier name and order by ID descending
                    qry = @"SELECT dMainID, mdate, m.mSupCusID, s.supName, SUM(d.amount)
                            FROM tblMain m
                            INNER JOIN tblDetails d ON d.dMainID = m.MainID
                            INNER JOIN Supplier s ON s.supID = m.mSupCusID
                            WHERE m.mType = 'PUR' AND supName LIKE '%" + TxtSearch.Text + @"%'
                            GROUP BY dMainID, mdate, m.mSupCusID, s.supName";
                }

                // Load data into DataGridView using MainClass.LoadData method
                MainClass.LoadData(qry, DataGridView1, lb);
            }
            catch (Exception ex)
            {
                // Show an error message if there is an exception loading data
                MessageBox.Show("Error loading purchase data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Open FrmPurchaseAdd form with data pre-filled for editing
                FrmPurchaseAdd frm = new FrmPurchaseAdd();
                frm.mainID = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                frm.supID = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["DgvSupID"].Value);

                MainClass.BlurBackground(frm); // Blur background and show the form
                LoadData(); // Refresh data after updating a purchase
            }

            // Delete action
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvDel")
            {
                // Get the ID of the selected purchase
                int id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                // Show a confirmation message before deleting the purchase
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this purchase?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Query to delete the purchase and its details by ID
                    string qry = "DELETE FROM tblMain WHERE MainID = " + id + "";
                    string qry2 = "DELETE FROM tblDetails WHERE dMainID = " + id + "";

                    // Hashtable to store parameters for SQL queries (not used in DELETE operations here)
                    Hashtable ht = new Hashtable();

                    // Execute the delete queries
                    MainClass.SQL(qry, ht);
                    if (MainClass.SQL(qry2, ht) > 0)
                    {
                        MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh data after deleting a purchase
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
