using POS_System.Model; // Import the namespace containing your data models
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
        private bool isCleared; // Flag to indicate if the search box has been cleared initially

        // Constructor for FrmProductView
        public FrmProductView()
        {
            InitializeComponent(); // Method to initialize form components
        }

        // Event handler for the Load event of FrmProductView
        private void FrmProductView_Load(object sender, EventArgs e)
        {
            LoadData(); // Load the data when the form loads
        }

        // Event handler for the Add button click event
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FrmProductAdd()); // Open the add product form with blurred background
            LoadData(); // Refresh data after adding a new product
        }

        // Method to load data into the DataGridView
        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(Dgvid);       // Add the ID column (proID) to the ListBox
            lb.Items.Add(Dgvname);     // Add the Name column (pName) to the ListBox
            lb.Items.Add(DgvcatID);    // Add the Category ID column (pCatID) to the ListBox
            lb.Items.Add(DgvCategory); // Add the Category Name column (catName) to the ListBox
            lb.Items.Add(DgvBarcode);  // Add the Barcode column (pBarcode) to the ListBox
            lb.Items.Add(DgvCost);     // Add the Cost column (pCost) to the ListBox
            lb.Items.Add(DgvSale);     // Add the Sale Price column (pPrice) to the ListBox

            try
            {
                string qry;

                // Check if the search box contains the placeholder text
                if (TxtSearch.Text == " Search Here")
                {
                    // Query to select all products with their categories
                    qry = "SELECT proID, pName, pCatID, catName, pBarcode, pCost, pPrice FROM Product INNER JOIN Category ON catID = pCatID";
                }
                else
                {
                    // Query to search products by name and order by ID
                    qry = @"SELECT proID, pName, pCatID, catName, pBarcode, pCost, pPrice 
                            FROM Product INNER JOIN Category ON catID = pCatID
                            WHERE pName LIKE '%" + TxtSearch.Text + "%' ORDER BY proID DESC";
                }

                // Load data into DataGridView1 using MainClass.LoadData method
                MainClass.LoadData(qry, DataGridView1, lb);
            }
            catch (Exception ex)
            {
                // Show an error message if there is an exception
                MessageBox.Show("Error loading product data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for cell click in DataGridView1
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is not a header cell
            if (e.RowIndex < 0) return;

            // Update
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvEdit")
            {
                FrmProductAdd frm = new FrmProductAdd();
                // Pass the product details to the add product form
                frm.id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                frm.catID = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["DgvcatID"].Value);
                frm.TxtName.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["Dgvname"].Value);
                frm.TxtBarcode.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvBarcode"].Value);
                frm.TxtCost.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvCost"].Value);
                frm.TxtPrice.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvSale"].Value);

                MainClass.BlurBackground(frm); // Open the add product form with blurred background
                LoadData(); // Refresh data after updating a product
            }

            // Delete
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvDel")
            {
                // Get the ID of the selected product
                int id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                // Show a confirmation message before deleting the product
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Query to delete the product by ID
                    string qry = "DELETE FROM Product WHERE proID = @id";
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", id);
                    // Execute the delete query and check if it was successful
                    if (MainClass.SQL(qry, ht) > 0)
                    {
                        MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh data after deleting a product
                    }
                }
            }
        }

        // Event handler for text change in TxtSearch
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
