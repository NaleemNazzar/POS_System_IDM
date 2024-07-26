using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace POS_System
{
    class MainClass
    {
        // Connection string for the database
        public static readonly string con_string = "Data Source=DESKTOP-F0KSCG6\\SQLEXPRESS;Initial Catalog=POS;User ID=Naleem;Password=12345;";
        public static SqlConnection con = new SqlConnection(con_string);

        // Method to check user validation
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false; // Variable to store if the user is valid or not
            string qry = "SELECT * FROM users WHERE uUsername = @user AND upass = @pass"; // Parameterized query to prevent SQL injection

            // Using statement ensures the SqlCommand is disposed of correctly
            using (SqlCommand cmd = new SqlCommand(qry, con))
            {
                cmd.Parameters.AddWithValue("@user", user); // Adding username parameter to the query
                cmd.Parameters.AddWithValue("@pass", pass); // Adding password parameter to the query

                DataTable dt = new DataTable(); // DataTable to hold query results
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // Using statement ensures the SqlDataAdapter is disposed of correctly
                {
                    da.Fill(dt); // Fill the DataTable with query results
                }

                // Check if any rows are returned, indicating a valid user
                if (dt.Rows.Count > 0)
                {
                    isValid = true;
                    USER = dt.Rows[0]["uName"].ToString(); // Set the username

                    byte[] imageArray = (byte[])dt.Rows[0]["uImage"]; // Retrieve the user image as a byte array
                    IMG = Image.FromStream(new MemoryStream(imageArray)); // Convert byte array to Image
                }
            }

            return isValid; // Return whether the user is valid or not
        }

        // Method to check if user exists
        private bool CheckUserExists(string username)
        {
            bool userExists = false;

            using (SqlConnection connection = new SqlConnection(MainClass.con_string))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE uUsername = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                        userExists = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return userExists;
        }


        // Method to reset user password
        public static bool ResetPassword(string username, string newPassword)
        {
            bool resetSuccess = false;

            // Example implementation: Update password in the database
            using (SqlConnection connection = new SqlConnection(con_string))
            {
                string query = "UPDATE Users SET uPass = @NewPassword WHERE uUsername = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        resetSuccess = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return resetSuccess;
        }

        // Method for executing SQL queries with parameters
        public static DataTable GetDataTable(string qry, Hashtable ht)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con)) // Using statement ensures the SqlCommand is disposed of correctly
                {
                    cmd.CommandType = CommandType.Text; // Setting the command type to Text

                    // Add parameters to the command
                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value); // Adding parameters from Hashtable to the command
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // Using statement ensures the SqlDataAdapter is disposed of correctly
                    {
                        da.Fill(dt); // Fill the DataTable with data from SqlDataAdapter
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); // Show exception message if an error occurs
            }

            return dt; // Return the filled DataTable
        }

        // Method for enabling/disabling double buffering for smoother UI updates
        public static void StopBuffering(Panel ctr, bool doubleBuffer)
        {
            try
            {
                // Use reflection to set the DoubleBuffered property of the control
                typeof(Control).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, ctr, new object[] { doubleBuffer });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); // Show exception message if an error occurs
            }
        }

        // Property for username
        private static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; } // Private setter to prevent external modification
        }

        // Property for user image
        private static Image img;
        public static Image IMG
        {
            get { return img; }
            private set { img = value; } // Private setter to prevent external modification
        }

        // Method for executing SQL queries with parameters and returning number of rows affected
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0; // Variable to store the result of the query execution

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con)) // Using statement ensures the SqlCommand is disposed of correctly
                {
                    cmd.CommandType = CommandType.Text; // Setting the command type to Text

                    // Add parameters to the command
                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value); // Adding parameters from Hashtable to the command
                    }

                    if (con.State == ConnectionState.Closed) { con.Open(); } // Open the connection if it is closed
                    res = cmd.ExecuteNonQuery(); // Execute the command
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); // Show exception message if an error occurs
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); } // Close the connection if it is open
            }

            return res; // Return the result of the query execution
        }

        // Method for loading data from database into DataGridView
        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(Gv_CellFormatting); // Add the event handler for cell formatting

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.CommandType = CommandType.Text; // Setting the command type to Text
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // Using statement ensures the SqlDataAdapter is disposed of correctly
                    {
                        DataTable dt = new DataTable(); // DataTable to hold query results
                        da.Fill(dt); // Fill the DataTable with query results

                        // Check if there is a mismatch between ListBox items and query result columns
                        if (dt.Columns.Count < lb.Items.Count)
                        {
                            MessageBox.Show("Mismatch between ListBox items and query result columns. Ensure ListBox contains only relevant columns.");
                            return;
                        }

                        // Set DataPropertyName for each DataGridView column from ListBox items
                        for (int i = 0; i < lb.Items.Count; i++)
                        {
                            string colName = ((DataGridViewColumn)lb.Items[i]).Name;
                            if (i < dt.Columns.Count)
                            {
                                gv.Columns[colName].DataPropertyName = dt.Columns[i].ColumnName;
                            }
                        }
                        gv.DataSource = dt; // Set the DataGridView's data source
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); // Show exception message if an error occurs
                if (con.State == ConnectionState.Open) { con.Close(); } // Close the connection if it is open
            }
        }

        // Event handler for cell formatting in DataGridView
        private static void Gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;
            int count = 0; // Counter for row numbers
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count; // Set the value of the first cell in each row to the row number
            }
        }

        // Method for blurring the background and displaying a model form
        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model) // Using statement ensures the Form is disposed of correctly
            {
                // Set properties for the background form
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = FrmMain.Instance.Size;
                Background.Location = FrmMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();

                // Set the Model form's owner to the background form
                Model.Owner = Background;
                Model.ShowDialog(Background); // Show the Model form as a dialog with the background form
                Background.Dispose(); // Dispose of the background form
            }
        }

        // Method for filling ComboBox with data from database
        public static void CBFILL(string qry, ComboBox cb)
        {
            using (SqlCommand cmd = new SqlCommand(qry, con)) // Using statement ensures the SqlCommand is disposed of correctly
            {
                cmd.CommandType = CommandType.Text; // Setting the command type to Text
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // Using statement ensures the SqlDataAdapter is disposed of correctly
                {
                    DataTable dt = new DataTable(); // DataTable to hold query results
                    da.Fill(dt); // Fill the DataTable with query results

                    cb.DisplayMember = "name"; // Display member in ComboBox
                    cb.ValueMember = "id"; // Value member in ComboBox
                    cb.DataSource = dt; // Set the ComboBox's data source
                    cb.SelectedIndex = -1; // Set default selection
                }
            }
        }

        // Method for validating controls in a form
        public static bool Validation(Form F)
        {
            bool isValid = false; // Variable to store if the form is valid or not
            int count = 0; // Counter for invalid controls

            foreach (Control c in F.Controls)
            {
                // Using tag for the control to check if we want to validate it or not
                if (!string.IsNullOrEmpty(Convert.ToString(c.Tag)))
                {
                    // For TextBox control
                    if (c is TextBox)
                    {
                        TextBox t = (TextBox)c;
                        if (string.IsNullOrWhiteSpace(t.Text))
                        {
                            t.BackColor = Color.Red; // Set background color to red if empty
                            t.ForeColor = Color.Red; // Set foreground color to red if empty
                            count++; // Increment counter for invalid controls
                        }
                        else
                        {
                            t.BackColor = Color.FromArgb(213, 218, 223); // Reset background color
                            t.ForeColor = Color.Black; // Reset foreground color
                        }
                    }
                    // For ComboBox control
                    else if (c is ComboBox)
                    {
                        ComboBox t = (ComboBox)c;
                        if (string.IsNullOrWhiteSpace(t.Text))
                        {
                            t.BackColor = Color.Red; // Set background color to red if empty
                            t.ForeColor = Color.Red; // Set foreground color to red if empty
                            count++; // Increment counter for invalid controls
                        }
                        else
                        {
                            t.BackColor = Color.FromArgb(213, 218, 223); // Reset background color
                            t.ForeColor = Color.Black; // Reset foreground color
                        }
                    }
                }
            }

            // Set isValid based on count of invalid controls
            isValid = count == 0;

            return isValid; // Return whether the form is valid or not
        }

        // Placeholder method for loading data into DataGridView with Hashtable parameters
        internal static void LoadData(string qry, DataGridView dataGridView1, Hashtable ht)
        {
            throw new NotImplementedException();
        }
    }
}
