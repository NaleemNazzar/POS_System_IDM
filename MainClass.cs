using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Collections;

namespace POS_System
{
    class MainClass
    {
        // Connection string for the database
        public static readonly string con_string = "Data Source=DESKTOP-F0KSCG6\\SQLEXPRESS; Initial Catalog=POS;Integrated Security=True;";
        public static SqlConnection con = new SqlConnection(con_string);

        // Method to check user validation
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;
            string qry = "Select * From users where uUsername = @user and upass = @pass"; // Parameterized query to prevent SQL injection

            // Using statement ensures the SqlCommand is disposed of correctly
            using (SqlCommand cmd = new SqlCommand(qry, con))
            {
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // Using statement ensures the SqlDataAdapter is disposed of correctly
                {
                    da.Fill(dt); // Fill the DataTable with query results
                }

                // Check if any rows are returned, indicating a valid user
                if (dt.Rows.Count > 0)
                {
                    isValid = true;
                    USER = dt.Rows[0]["uName"].ToString(); // Set the username

                    Byte[] imageArray = (byte[])dt.Rows[0]["uImage"]; // Retrieve the user image as a byte array
                    IMG = Image.FromStream(new MemoryStream(imageArray)); // Convert byte array to Image
                }
            }

            return isValid;
        }

        // Method for enabling/disabling double buffering
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
                MessageBox.Show(ex.ToString());
            }
        }

        // Property for username
        private static string user;
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        // Property for user image
        private static Image img;
        public static Image IMG
        {
            get { return img; }
            private set { img = value; }
        }

        // Method for CRUD operation
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con)) // Using statement ensures the SqlCommand is disposed of correctly
                {
                    cmd.CommandType = CommandType.Text;

                    // Add parameters to the command
                    foreach (DictionaryEntry item in ht)
                    {
                        cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    }

                    if (con.State == ConnectionState.Closed) { con.Open(); }
                    res = cmd.ExecuteNonQuery(); // Execute the command
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open) { con.Close(); }
            }

            return res;
        }

        // Method for loading data from database

        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(Gv_CellFormatting); // Add the event handler for cell formatting

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Columns.Count < lb.Items.Count)
                        {
                            MessageBox.Show("Mismatch between ListBox items and query result columns. Ensure ListBox contains only relevant columns.");
                            return;
                        }

                        for (int i = 0; i < lb.Items.Count; i++)
                        {
                            string colName = ((DataGridViewColumn)lb.Items[i]).Name;
                            if (i < dt.Columns.Count)
                            {
                                gv.Columns[colName].DataPropertyName = dt.Columns[i].ColumnName;
                            }
                        }
                        gv.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
        }

        // Event handler for cell formatting
        private static void Gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;
            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        // Method for blurring the background
        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model) // Using statement ensures the Form is disposed of correctly
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = FrmMain.Instance.Size;
                Background.Location = FrmMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        // Method for filling ComboBox
        public static void CBFILL(string qry, ComboBox cb)
        {
            using (SqlCommand cmd = new SqlCommand(qry, con)) // Using statement ensures the SqlCommand is disposed of correctly
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd)) // Using statement ensures the SqlDataAdapter is disposed of correctly
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt); // Fill the DataTable with query results

                    cb.DisplayMember = "name"; // Display member in ComboBox
                    cb.ValueMember = "id"; // Value member in ComboBox
                    cb.DataSource = dt; // Set the ComboBox's data source
                    cb.SelectedIndex = -1; // Set default selection
                }
            }
        }

        // Method for validation
        public static bool Validation(Form F)
        {
            bool isValid = false;
            int count = 0;

            foreach (Control c in F.Controls)
            {
                //using tag for the control to check if we want to validate it or not
                if (Convert.ToString(c.Tag) != "" && Convert.ToString(c.Tag) != null)
                {
                    //for text box
                    if (c is TextBox)
                    {
                        TextBox t = (TextBox)c;
                        if (t.Text.Trim() == "")
                        {
                            t.BackColor = Color.Red;
                            t.ForeColor = Color.Red;
                            count++;
                        }
                        else
                        {
                            t.BackColor = Color.FromArgb(213, 218, 223);
                            t.ForeColor = Color.Black;
                        }
                    }
                    //for Combo box
                    if (c is ComboBox)
                    {
                        ComboBox t = (ComboBox)c;
                        if (t.Text.Trim() == "")
                        {
                            t.BackColor = Color.Red;
                            t.ForeColor = Color.Red;
                            count++;
                        }
                        else
                        {
                            t.BackColor = Color.FromArgb(213, 218, 223);
                            t.ForeColor = Color.Black;
                        }
                    }
                }

                if (count == 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }

            return isValid;
        }


        internal static void LoadData(string qry, DataGridView dataGridView1, Hashtable ht)
        {
            throw new NotImplementedException();
        }

        internal static DataTable GetDataTable(string qry, Hashtable ht)
        {
            throw new NotImplementedException();
        }
    }
}