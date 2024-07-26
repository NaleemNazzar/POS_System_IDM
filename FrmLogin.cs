using POS_System;
using POS_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class FrmLogin : Form
    {
        private bool isCleared;

        // Constructor for FrmLogin form
        public FrmLogin()
        {
            InitializeComponent(); // Initialize form components

        }

        // Event handler for the form load event
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        // Event handler for the Close button click event
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        // Event handler for the Minimize button click event
        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimize the form
        }

        // Event handler for the Login button click event
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Check if the user credentials are valid
            if (MainClass.IsValidUser(TxtUser.Text, TxtPass.Text))
            {
                this.Hide(); // Hide the current login form
                FrmMain frm = new FrmMain(); // Create a new instance of FrmMain
                frm.Show(); // Show the main form
            }
            else
            {
                // Show error message if credentials are invalid
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for the Forgot Password link click event
        private void LnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPassword frmForgotPassword = new FrmForgotPassword();
            frmForgotPassword.ShowDialog();
        }

        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShowPassword.Checked)
            {
                TxtPass.UseSystemPasswordChar = false;
            }
            else
            {
                if (TxtPass.Text != "Type Your Password")
                {
                    TxtPass.UseSystemPasswordChar = true;
                }
            }

            // Force refresh to apply the change immediately
            TxtPass.Refresh();
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {
            // if (!isCleared)
            // {
            //     TxtUser.Clear(); // Clear the text box
            //     isCleared = true; // Set the isCleared flag to true
            // }
        }

        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Type Your Username")
            {
                TxtUser.Text = "";
                TxtUser.ForeColor = Color.Black;
            }
        }

        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUser.Text))
            {
                TxtUser.Text = "Type Your Username";
                TxtUser.ForeColor = Color.Gray;
            }
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (TxtPass.Text == "Type Your Password")
            {
                TxtPass.Text = "";
                TxtPass.ForeColor = Color.Black;
                TxtPass.UseSystemPasswordChar = true;
            }
        }

        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPass.Text))
            {
                TxtPass.Text = "Type Your Password";
                TxtPass.ForeColor = Color.Gray;
                TxtPass.UseSystemPasswordChar = false;
            }
        }
    }
}