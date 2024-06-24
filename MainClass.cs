using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Reflection;
using System.IO;

namespace POS_System
{
    class MainClass
    {
        public static readonly string con_string = "Data Source=DESKTOP-F0KSCG6\\SQLEXPRESS; Initial Catalog=POS;Integrated Security=True;";
        public static SqlConnection con = new SqlConnection(con_string);

        // Method to check user validation
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;
            string qry = @"Select * From users where uUsername = '" + user + "' and upass ='" + pass + "' ";

            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                USER = dt.Rows[0]["uName"].ToString();

                Byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                IMG = Image.FromStream(new MemoryStream(imageArray));
            }
            return isValid;
        }

        // Method for enabling/disabling double buffering
        public static void StopBuffering(Panel ctr, bool doubleBuffer)
        {
            try
            {
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
        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }

        // Property for user image
        public static Image img;

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
                SqlCommand cmd = new SqlCommand(qry, con)
                {
                    CommandType = CommandType.Text
                };

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }

        // Method for loading data from database
        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(Gv_CellFormatting);
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con)
                {
                    CommandType = CommandType.Text
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private static void Gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Implement cell formatting logic if needed
        }

        // Method for blurring the background
        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
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
            SqlCommand cmd = new SqlCommand(qry, con)
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }

        // Method for validation
        public static bool Validation(Form F)
        {
            bool isValid = false;
            int count = 0;

            foreach (Control c in F.Controls)
            {
                if (Convert.ToString(c.Tag) != "" && Convert.ToString(c.Tag) != null)
                {
                    if (c is TextBox)
                    {
                        TextBox t = (TextBox)c;
                        if (t.Text.Trim() == "")
                        {
                            t.BackColor = Color.Red; // Use BackColor to indicate invalid input
                            count++;
                        }
                        else
                        {
                            t.BackColor = SystemColors.Window; // Reset to default color if valid
                        }
                    }
                }
                if (count > 0)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }

            // Set isValid to true if no invalid controls were found
            if (count == 0)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
