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
using System.Xml.Linq;

namespace POS_System.Model
{
    public partial class FrmProductAdd : Form
    {
        public FrmProductAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int catID = 0;

        public string filePath = "";
        Byte[] imageByteArray;

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProductAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select catID 'id' , catName 'name' from Category";
            MainClass.CBFILL(qry, CbCategory);

            if (id > 0)
            {
                CbCategory.SelectedValue = catID;
                LoadImage();
            }
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
                    qry = @"INSERT INTO Product (pName, pCatID, pBarcode, pCost, pPrice, pImage) VALUES (@name, @pCatID, @barcode, @cost, @price, @image);";
                }
                else // Update
                {
                    qry = @"UPDATE Product SET 
                                pName = @name,
                                pCatID = @pCatID,
                                pBarcode = @barcode,
                                pCost = @cost,
                                pPrice = @price,
                                pImage = @image
                            WHERE proID = @id;";
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

                System.Collections.Hashtable ht = new System.Collections.Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", TxtName.Text);
                ht.Add("@pCatID", Convert.ToInt32(CbCategory.SelectedValue));
                ht.Add("@barcode", TxtBarcode.Text);
                ht.Add("@cost", TxtCost.Text);
                ht.Add("@price", TxtPrice.Text);
                ht.Add("@image", imageByteArray);

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    id = 0;
                    TxtName.Text = "";
                    CbCategory.SelectedIndex = 0;
                    CbCategory.SelectedIndex = -1;
                    TxtBarcode.Text = "";
                    TxtCost.Text = "";
                    TxtPrice.Text = "";
                    TxtPic.Image = POS_System.Properties.Resources.product_64;
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
            string qry = @"SELECT pImage FROM Product WHERE proID = " + id + "";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Byte[] imageArray = (byte[])dt.Rows[0]["pImage"];
                TxtPic.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }
    }
}