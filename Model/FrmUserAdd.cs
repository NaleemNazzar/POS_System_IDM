using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Model
{
    public partial class FrmUserAdd : Form
    {
        public FrmUserAdd()
        {
            InitializeComponent();

        }

        public int id = 0;
        public string filePath = "";
        Byte[] imageByteArray;

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Before saving, we need validation
            if (MainClass.Validation(this) == false)
            {
                MessageBox.Show("Please remove errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string qry = "";
                if (id == 0) // Insert
                {
                    qry = @"INSERT INTO users (uName, uUsername, uPass, uPhone, uImage) VALUES (@name, @username, @pass, @phone, @image);";
                }
                else // Update
                {
                    qry = @"UPDATE users SET 
                                uName = @name,
                                uUsername = @username,
                                uPass = @pass,
                                uPhone = @phone,
                                uImage = @image
                            WHERE userID = @id;";
                }

                // Ensure the filePath is valid before attempting to load the image
                if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                {
                    MessageBox.Show("Please select a valid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert image to byte array
                Image tmp = new Bitmap(filePath);
                MemoryStream ms = new MemoryStream();
                tmp.Save(ms, ImageFormat.Png);
                imageByteArray = ms.ToArray();

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", TxtName.Text);
                ht.Add("@username", TxtUser.Text);
                ht.Add("@pass", TxtPass.Text);
                ht.Add("@phone", TxtPhone.Text); // Assuming you need phone number here
                ht.Add("@image", imageByteArray);

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    id = 0;
                    TxtName.Text = "";
                    TxtUser.Text = "";
                    TxtPass.Text = "";
                    TxtPhone.Text = "";
                    TxtPic.Image = POS_System.Properties.Resources.icons8_person_48;
                    TxtName.Focus();
                }
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (.jpg, .png)|*.png;*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                TxtPic.Image = new Bitmap(filePath);
            }
        }
        private void LoadImage()
        {
            string qry = @"SELECT uImage FROM users WHERE userID = " + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Byte[] imageArray = (byte[])dt.Rows[0]["uImage"];
                TxtPic.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }

        private void FrmUserAdd_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                LoadImage();
            }
        }
    }
}
