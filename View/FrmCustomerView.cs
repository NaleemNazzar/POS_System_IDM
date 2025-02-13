using POS_System.Model; // Import the namespace containing your data models
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        // Load event handler for FrmCustomerView
        private void FrmCustomerView_Load(object sender, EventArgs e)
        {
            LoadData(); // Load initial data when the form loads
        }

        // Add button click event handler
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Open FrmCustomerAdd form with blurred background
            MainClass.BlurBackground(new FrmCustomerAdd());
            LoadData(); // Refresh data after adding a new customer
        }

        // Method to load data into the DataGridView
        private void LoadData()
        {
            // Prepare a ListBox to store DataGridView column names for data binding
            ListBox lb = new ListBox();
            lb.Items.Add(Dgvid);        // Customer ID column
            lb.Items.Add(Dgvname);      // Customer Name column
            lb.Items.Add(DgvPhone);     // Customer Phone column
            lb.Items.Add(DgvEmail);     // Customer Email column

            try
            {
                string qry;

                // Check if the search box contains the placeholder text
                if (TxtSearch.Text == " Search Here")
                {
                    // Query to select all customers
                    qry = @"SELECT * FROM Customer";
                }
                else
                {
                    // Query to search customers by name and order by ID descending
                    qry = @"SELECT * FROM Customer
                            WHERE cusName LIKE '%" + TxtSearch.Text + @"%'
                            ORDER BY cusID DESC";
                }

                // Load data into DataGridView using MainClass.LoadData method
                MainClass.LoadData(qry, DataGridView1, lb);
            }
            catch (Exception ex)
            {
                // Show an error message if there is an exception loading data
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Open FrmCustomerAdd form with data pre-filled for editing
                FrmCustomerAdd frm = new FrmCustomerAdd();
                frm.id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                frm.TxtName.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["Dgvname"].Value);
                frm.TxtPhone.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvPhone"].Value);
                frm.TxtEmail.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvEmail"].Value);

                MainClass.BlurBackground(frm); // Blur background and show the form
                LoadData(); // Refresh data after updating a customer
            }

            // Delete action
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvDel")
            {
                // Get the ID of the selected customer
                int id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                // Show a confirmation message before deleting the customer
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Query to delete the customer by ID
                    string qry = "DELETE FROM Customer WHERE cusID = @id";
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", id);
                    // Execute the delete query and check if it was successful
                    if (MainClass.SQL(qry, ht) > 0)
                    {
                        MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh data after deleting a customer
                    }
                }
            }
        }
    }
}
