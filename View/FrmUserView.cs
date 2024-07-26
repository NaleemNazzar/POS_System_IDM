using POS_System.Model; // Import the namespace containing your data models
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS_System.View
{
    public partial class FrmUserView : Form
    {
        private bool isCleared = false;

        public FrmUserView()
        {
            InitializeComponent();
        }

        // Load event handler for FrmUserView
        private void FrmUserView_Load(object sender, EventArgs e)
        {
            LoadData(); // Load user data initially when the form loads
        }

        // Add button click event handler
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Open FrmUserAdd form with blurred background
            MainClass.BlurBackground(new FrmUserAdd());
            LoadData(); // Refresh data after adding a new user
        }

        // Method to load data into the DataGridView
        private void LoadData()
        {
            // Prepare a ListBox to store DataGridView column names for data binding
            ListBox lb = new ListBox();
            lb.Items.Add(Dgvid);        // User ID column
            lb.Items.Add(Dgvname);      // User Name column
            lb.Items.Add(DgvuserName);  // Username column
            lb.Items.Add(Dgvpass);      // Password column
            lb.Items.Add(Dgvphone);     // Phone column

            try
            {
                string qry;

                // Check if the search box contains the placeholder text
                if (TxtSearch.Text == " Search Here")
                {
                    // Query to select all users
                    qry = "SELECT userID, uName, uUsername, uPass, uPhone FROM users";
                }
                else
                {
                    // Query to search users by name and order by ID descending
                    qry = @"SELECT userID, uName, uUsername, uPass, uPhone 
                            FROM users 
                            WHERE uName LIKE '%" + TxtSearch.Text + "%' ORDER BY userID DESC";
                }

                // Load data into DataGridView using MainClass.LoadData method
                MainClass.LoadData(qry, DataGridView1, lb);
            }
            catch (Exception ex)
            {
                // Show an error message if there is an exception loading data
                MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Open FrmUserAdd form with data pre-filled for editing
                FrmUserAdd frm = new FrmUserAdd();
                frm.id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                frm.TxtName.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["Dgvname"].Value);
                frm.TxtUser.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["DgvuserName"].Value);
                frm.TxtPass.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["Dgvpass"].Value);
                frm.TxtPhone.Text = Convert.ToString(DataGridView1.Rows[e.RowIndex].Cells["Dgvphone"].Value);

                MainClass.BlurBackground(frm); // Blur background and show the form
                LoadData(); // Refresh data after updating a user
            }

            // Delete action
            if (DataGridView1.Columns[e.ColumnIndex].Name == "DgvDel")
            {
                // Get the ID of the selected user
                int id = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["Dgvid"].Value);
                // Show a confirmation message before deleting the user
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // Query to delete the user by ID
                    string qry = "DELETE FROM users WHERE userID = @id";
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", id);
                    if (MainClass.SQL(qry, ht) > 0)
                    {
                        MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh data after deleting a user
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
