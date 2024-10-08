﻿using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Login : Form
    {
        private Database DB;

        public Login()
        {
            InitializeComponent();
            DB = new Database();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }
        private void signupButton_Click(object sender, EventArgs e)
        {
            Hide();                                     // Hide the login form
            Register registerForm = new Register();     // Create an instance of the register form
            registerForm.Show();                        // Show the register form
        }            
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            int index = DB.ValidateUser(username, password);

            if (index!=-1)
            {
                MessageBox.Show("התחברת בהצלחה","התחברות", MessageBoxButtons.OK, MessageBoxIcon.Information);
                User user = DB.getUser(username, password);
                Menu mainMenu = new Menu(user);
                mainMenu.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("שם משתמש או סיסמא שגויים. נסה שוב", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}