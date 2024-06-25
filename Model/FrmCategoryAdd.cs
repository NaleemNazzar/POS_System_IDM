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

namespace POS_System.Model
{
    public partial class FrmCategoryAdd : Form
    {
        public FrmCategoryAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
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
                    qry = @"INSERT INTO Category (catName) VALUES (@name);";
                }
                else // Update
                {
                    qry = @"UPDATE Category SET catName = @name WHERE catID = @id;";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", TxtName.Text);

                try
                {
                    if (MainClass.SQL(qry, ht) > 0)
                    {
                        MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        id = 0;
                        TxtName.Text = "";
                        TxtName.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
