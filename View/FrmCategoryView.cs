using POS_System.Model; // Namespace for models
using System;
using System.Collections; // Namespace for Hashtable
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Namespace for Windows Forms components

namespace POS_System.View
{
    public partial class FrmCategoryView : Form
    {
        // Field to track if the search text box is cleared
        private bool isCleared;

        // Constructor for FrmCategoryView form
        public FrmCategoryView()
        {
            InitializeComponent(); // Method to initialize form components
        }

        // Event handler for the TextChanged event of TxtSearch
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!isCleared) // If the search text box is not cleared yet
            {
                TxtSearch.Clear(); // Clear the text box
                isCleared = true; // Set the isCleared flag to true
            }
            else
            {
                LoadData(); // Trigger search and load data whenever the text changes
            }
        }

        // Event handler for the Load event of FrmCategoryView
        private void FrmCategoryView_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data when the form loads
        }

        // Event handler for the Add button click event
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Show the category add form with blurred background
            MainClass.BlurBackground(new FrmCategoryAdd());
            LoadData(); // Refresh data after adding a new category
        }

        // Method to load data into the DataGridView
        private void LoadData()
        {
            // Create a ListBox to hold DataGridView columns
            ListBox lb = new ListBox();
            lb.Items.Add(Dgvid); // Add the ID column
            lb.Items.Add(Dgvname); // Add the name column

            try
            {
                string qry; // Query string

                // Check if the search text box contains the default search text
                if (TxtSearch.Text == " Search Here")
                {
                    qry = @"SELECT * FROM Category"; // Query to select all categories
                }
                else
                {
                    // Query to search categories by name and order by ID in descending order
                    qry = @"SELECT * FROM Category
                               WHERE catName LIKE '%" + TxtSearch.Text + "%' ORDER BY catID DESC";
                }

                // Load data into DataGridView using the query
                MainClass.LoadData(qry, DataGridView1, lb);
            }
            catch (Exception ex)
            {
                // Show error message if data loading fails
                MessageBox.Show("Error loading category data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for cell click event of DataGridView
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is not a header cell
            if (e.RowIndex < 0) return;

            // Update category
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvEdit")
            {
                // Create a new instance of the category add form
                FrmCategoryAdd frm = new FrmCategoryAdd();
                // Set the ID and name fields of the form
                frm.id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                frm.TxtName.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["Dgvname"].Value);

                // Show the category add form with blurred background
                MainClass.BlurBackground(frm);
                LoadData(); // Refresh data after updating the category
            }

            // Delete category
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvDel")
            {
                int id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value); // Get the category ID
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes) // If the user confirms deletion
                {
                    // Query to delete the category by ID
                    string qry = "DELETE FROM Category WHERE catID = @id";
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", id); // Add the ID parameter
                    if (MainClass.SQL(qry, ht) > 0) // Execute the query
                    {
                        MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh data after deleting the category
                    }
                }
            }
        }
    }
}
