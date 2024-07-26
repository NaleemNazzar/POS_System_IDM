using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace POS_System
{
    public partial class FrmForgotPassword : Form
    {
        private string connectionString = "Data Source=DESKTOP-F0KSCG6\\SQLEXPRESS;Initial Catalog=POS;User ID=Naleem;Password=12345;";
        private SqlConnection connection;

        public FrmForgotPassword()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);

            // Add the Load event handler
            this.Load += new EventHandler(FrmForgotPassword_Load);
        }

        private void FrmForgotPassword_Load(object sender, EventArgs e)
        {
            // Center the message label initially
            CenterLblMessage();

        }


        private void CenterLblMessage()
        {
            LblMessage.Left = (this.ClientSize.Width - LblMessage.Width) / 2;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text.Trim();
            string phone = TxtPhone.Text.Trim();

            // Validate inputs
            if (!ValidateInputs(username, phone))
                return;

            if (CheckUserExists(username, phone))
            {
                // User exists, proceed with showing new password input and resizing form
                TxtNewPassword.Visible = true; // Show the new password textbox
                BtnResetPassword.Visible = true; // Show the reset password button
                label3.Visible = true; // Show label for "New password"
                LblMessage.Text = "User validated. Enter new password."; // Update message label
                CenterLblMessage(); // Center the message label again

                // Calculate the position for new controls
                int additionalHeight = 120;
                int newControlTop = LblMessage.Bottom + 10;

                // Resize the form to accommodate new password input fields
                this.Height += additionalHeight; // Adjust the height as needed to fit new fields
                TxtNewPassword.Top = newControlTop; // Position the new password textbox
                label3.Top = TxtNewPassword.Top - label3.Height + 20; // Position the label just above the textbox
                BtnResetPassword.Top = TxtNewPassword.Bottom + 10; // Position the reset password button just below the textbox
            }
            else
            {
                // User not found
                MessageBox.Show("User with provided username and phone not found.", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs(string username, string phone)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone number cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]{3,50}$"))
            {
                MessageBox.Show("Username must be between 3 and 50 alphanumeric characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool CheckUserExists(string username, string phone)
        {
            bool userExists = false;

            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE uUsername = @Username AND uPhone = @Phone", connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Phone", phone);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                        userExists = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            return userExists;
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            string newPassword = TxtNewPassword.Text.Trim();

            // Validate new password
            if (!ValidateNewPassword(newPassword))
                return;

            if (UpdatePassword(newPassword))
            {
                MessageBox.Show("Password updated successfully.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after successful password reset
            }
            else
            {
                MessageBox.Show("Failed to update password. Please try again later.", "Password Reset Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateNewPassword(string newPassword)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrEmpty(newPassword))
            {
                errorMessage.AppendLine("Please enter a new password.");
            }
            else
            {
                if (newPassword.Length < 8)
                {
                    errorMessage.AppendLine("Password must be at least 8 characters long.");
                }

                if (!Regex.IsMatch(newPassword, @"[A-Z]"))
                {
                    errorMessage.AppendLine("Password must contain at least one uppercase letter.");
                }

                if (!Regex.IsMatch(newPassword, @"[a-z]"))
                {
                    errorMessage.AppendLine("Password must contain at least one lowercase letter.");
                }

                if (!Regex.IsMatch(newPassword, @"[0-9]"))
                {
                    errorMessage.AppendLine("Password must contain at least one digit.");
                }

                if (!Regex.IsMatch(newPassword, @"[\W_]"))
                {
                    errorMessage.AppendLine("Password must contain at least one special character.");
                }
            }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage.ToString(), "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private bool UpdatePassword(string newPassword)
        {
            bool success = false;
            string username = TxtUsername.Text.Trim();
            string phone = TxtPhone.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET uPass = @NewPassword WHERE uUsername = @Username AND uPhone = @Phone";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Phone", phone);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating password: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return success;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        


        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtNewPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
