﻿
namespace final_project
{
    partial class UserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.MaximizeBox = true;
            this.ControlBox = true;
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCHangePassword = new System.Windows.Forms.Button();
            this.buttonChangeUserName = new System.Windows.Forms.Button();
            this.textBoxCoins = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "פרטי משתמש";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "שם משתמש";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Location = new System.Drawing.Point(12, 193);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(205, 30);
            this.textBoxUserName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "תעודת זהות";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Location = new System.Drawing.Point(12, 363);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(206, 30);
            this.textBoxID.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "סיסמה";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Location = new System.Drawing.Point(12, 277);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(206, 30);
            this.textBoxPassword.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.buttonCHangePassword);
            this.panel1.Controls.Add(this.buttonChangeUserName);
            this.panel1.Controls.Add(this.textBoxCoins);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxGender);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(784, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(374, 699);
            this.panel1.TabIndex = 0;
            // 
            // buttonCHangePassword
            // 
            this.buttonCHangePassword.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonCHangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCHangePassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCHangePassword.Location = new System.Drawing.Point(12, 313);
            this.buttonCHangePassword.Name = "buttonCHangePassword";
            this.buttonCHangePassword.Size = new System.Drawing.Size(206, 23);
            this.buttonCHangePassword.TabIndex = 18;
            this.buttonCHangePassword.Text = "שינוי סיסמא";
            this.buttonCHangePassword.UseVisualStyleBackColor = false;
            this.buttonCHangePassword.Click += new System.EventHandler(this.buttonCHangePassword_Click_1);
            // 
            // buttonChangeUserName
            // 
            this.buttonChangeUserName.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonChangeUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonChangeUserName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeUserName.Location = new System.Drawing.Point(12, 229);
            this.buttonChangeUserName.Name = "buttonChangeUserName";
            this.buttonChangeUserName.Size = new System.Drawing.Size(206, 23);
            this.buttonChangeUserName.TabIndex = 17;
            this.buttonChangeUserName.Text = "שינוי שם משתמש";
            this.buttonChangeUserName.UseVisualStyleBackColor = false;
            this.buttonChangeUserName.Click += new System.EventHandler(this.buttonChangeUserName_Click);
            // 
            // textBoxCoins
            // 
            this.textBoxCoins.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxCoins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCoins.Location = new System.Drawing.Point(125, 516);
            this.textBoxCoins.Multiline = true;
            this.textBoxCoins.Name = "textBoxCoins";
            this.textBoxCoins.Size = new System.Drawing.Size(57, 30);
            this.textBoxCoins.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(209, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "מספר מטבעות";
            // 
            // textBoxGender
            // 
            this.textBoxGender.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGender.Location = new System.Drawing.Point(12, 464);
            this.textBoxGender.Multiline = true;
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(205, 30);
            this.textBoxGender.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "מין";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.Cornsilk;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Location = new System.Drawing.Point(12, 412);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(205, 30);
            this.textBoxEmail.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "E-MAIL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(211, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(702, 78);
            this.label8.TabIndex = 17;
            this.label8.Text = ":מוצרים אחרונים שנקנו בחנות";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 699);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInterface";
            this.Text = "פרטי משתמש";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCoins;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCHangePassword;
        private System.Windows.Forms.Button buttonChangeUserName;
        private System.Windows.Forms.Label label8;
    }
}
