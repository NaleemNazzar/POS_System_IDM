using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace POS_System.Model
{
    public partial class FrmCustomerAdd : Form
    {
        public FrmCustomerAdd()
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
            string validationMessage = ValidateInputs();
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string qry = "";
            if (id == 0) // Insert
            {
                qry = @"INSERT INTO Customer (cusName, cusPhone, cusEmail) VALUES (@name, @phone, @Email);";
            }
            else // Update
            {
                qry = @"UPDATE Customer SET 
                            cusName = @name,
                            cusPhone = @phone,
                            cusEmail = @Email
                        WHERE cusID = @id;";
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

        private string ValidateInputs()
        {
            StringBuilder validationErrors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                validationErrors.AppendLine("Customer name is required.");
            }

            // Validate Phone Number
            if (string.IsNullOrWhiteSpace(TxtPhone.Text) || !IsValidPhoneNumber(TxtPhone.Text))
            {
                validationErrors.AppendLine("Please enter a valid 10-digit phone number.");
            }

            // Validate Email Address
            if (string.IsNullOrWhiteSpace(TxtEmail.Text) || !IsValidEmail(TxtEmail.Text))
            {
                validationErrors.AppendLine("Please enter a valid email address Ex. name@mail.com.");
            }

            return validationErrors.ToString();
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Phone number must be exactly 10 digits
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
