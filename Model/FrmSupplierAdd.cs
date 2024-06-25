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
    public partial class FrmSupplierAdd : Form
    {
        public FrmSupplierAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

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
                    qry = @"INSERT INTO Supplier (supName, supPhone, supEmail) VALUES (@name, @phone, @Email);";
                }
                else // Update
                {
                    qry = @"UPDATE Supplier SET 
                                supName = @name,
                                supPhone = @phone,
                                supEmail = @Email
                            WHERE supID = @id;";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@name", TxtName.Text);
                ht.Add("@phone", TxtPhone.Text);
                ht.Add("@Email", TxtEmail.Text);

                if (MainClass.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    id = 0;
                    TxtName.Text = "";
                    TxtPhone.Text = "";
                    TxtEmail.Text = "";
                    TxtName.Focus();
                }
            }
        }
    }
}
