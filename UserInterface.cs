﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace final_project
{
    public partial class UserInterface : Form
    {
        private User user;
        private Panel items_panel;
        private const int ItemWidth = 120;
        private const int ItemHeight = 160;
        private Dictionary<string, (string, int)> items ;

        private Database database;

        public UserInterface(Database db, User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;
            database = db;
            this.user = user;
            loadItems();
            AddItemToUI(this.items);
            UpdateForm();
            items_panel = new Panel();                 
        }
        private void loadItems()
        {
            var storeDB = new Database(@"../storeitems.xlsx");
            items = storeDB.GetItemsByUserId(user);
        }
        private void UpdateForm()
        {
            var db = new Database();
            user = db.getUser(user.ID);
            textBoxUserName.Text = user.Username;
            textBoxPassword.Text = user.Password;
            textBoxID.Text = user.ID;
            textBoxEmail.Text = user.Email;
            textBoxGender.Text = user.Gender;
            textBoxCoins.Text = database.GetBalance(int.Parse(user.ID)).ToString();
        }
        private void buttonChangeUserName_Click(object sender, EventArgs e)
        {
            ChangeUserName changeUserForm = new ChangeUserName(user);
            changeUserForm.Show();
            changeUserForm.FormClosed += (s, args) =>
            {
                // This code runs when the form is closed
                UpdateForm();
            };
        }
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword(database, user);
            changePasswordForm.Show();
            changePasswordForm.FormClosed += (s, args) =>
            {
                // This code runs when the form is closed
                UpdateForm();
            };
        }
        private void AddItemToUI(Dictionary<string, (string, int)> items)
        {
            // Clear existing controls
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in items)
            {
                var panel = new Panel
                {
                    Width = ItemWidth + 20,
                    Height = ItemHeight + 100,
                    Margin = new Padding(5)
                };
                string fullImagePath = Path.Combine(Application.StartupPath, item.Value.Item1);

                var pictureBox = new PictureBox
                {
                    ImageLocation = fullImagePath,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = ItemWidth ,
                    Height = ItemHeight, // Adjust height to leave space for the text
                    Top = 10,
                    Left = 10
                };

                var nameLabel = new Label
                {
                    Text = item.Key + $"\nכמות: {item.Value.Item2}",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = ItemWidth ,
                    Height = 100,
                    Top = pictureBox.Bottom + 5,
                    Left = 10,
                    Font = new Font("Gill Sans MT", 11, FontStyle.Regular)
                };

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(nameLabel);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }
    }
}
