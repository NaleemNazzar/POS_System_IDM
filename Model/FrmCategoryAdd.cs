using System;
using System.Collections;
using System.Text;
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
            // Perform validation
            string validationMessage = ValidateInputs();
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string qry = "";
            Hashtable ht = new Hashtable();
            ht.Add("@name", TxtName.Text);

            try
            {
                if (id == 0) // Insert
                {
                    qry = @"INSERT INTO Category (catName) VALUES (@name);";
                }
                else // Update
                {
                    qry = @"UPDATE Category SET catName = @name WHERE catID = @id;";
                    ht.Add("@id", id);
                }

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

        private string ValidateInputs()
        {
            StringBuilder validationErrors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                validationErrors.AppendLine("Category name is required.");
            }

            // Add more validation checks as needed

            return validationErrors.ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
