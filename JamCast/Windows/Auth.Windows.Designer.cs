﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Client
{
    partial class AuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this._login = new System.Windows.Forms.Button();
            this._titleLabel = new System.Windows.Forms.Label();
            this._descriptionLabel = new System.Windows.Forms.Label();
            this._emailAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._password = new System.Windows.Forms.TextBox();
            this._error = new System.Windows.Forms.Label();
            this._imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _login
            // 
            this._login.Enabled = false;
            this._login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._login.Location = new System.Drawing.Point(164, 420);
            this._login.Name = "_login";
            this._login.Size = new System.Drawing.Size(138, 51);
            this._login.TabIndex = 2;
            this._login.Text = "Login";
            this._login.UseVisualStyleBackColor = true;
            this._login.Click += new System.EventHandler(this._login_Click);
            // 
            // _titleLabel
            // 
            this._titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleLabel.Location = new System.Drawing.Point(12, 187);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(435, 80);
            this._titleLabel.TabIndex = 3;
            this._titleLabel.Text = "Welcome to the Melbourne Global Game Jam 2016!";
            this._titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _descriptionLabel
            // 
            this._descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._descriptionLabel.Location = new System.Drawing.Point(44, 267);
            this._descriptionLabel.Name = "_descriptionLabel";
            this._descriptionLabel.Size = new System.Drawing.Size(368, 35);
            this._descriptionLabel.TabIndex = 4;
            this._descriptionLabel.Text = "Sign in with the email address and password you used to buy your ticket on https:" +
    "//melbggj16.info/";
            this._descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _emailAddress
            // 
            this._emailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._emailAddress.Location = new System.Drawing.Point(164, 340);
            this._emailAddress.Name = "_emailAddress";
            this._emailAddress.Size = new System.Drawing.Size(248, 26);
            this._emailAddress.TabIndex = 7;
            this._emailAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this._emailAddress_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _password
            // 
            this._password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._password.Location = new System.Drawing.Point(164, 372);
            this._password.Name = "_password";
            this._password.PasswordChar = '*';
            this._password.Size = new System.Drawing.Size(248, 26);
            this._password.TabIndex = 9;
            this._password.KeyUp += new System.Windows.Forms.KeyEventHandler(this._password_KeyUp);
            // 
            // _error
            // 
            this._error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._error.ForeColor = System.Drawing.Color.Red;
            this._error.Location = new System.Drawing.Point(44, 302);
            this._error.Name = "_error";
            this._error.Size = new System.Drawing.Size(368, 35);
            this._error.TabIndex = 11;
            this._error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _imageBox
            // 
            this._imageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this._imageBox.Location = new System.Drawing.Point(0, 0);
            this._imageBox.Name = "_imageBox";
            this._imageBox.Size = new System.Drawing.Size(459, 171);
            this._imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imageBox.TabIndex = 12;
            this._imageBox.TabStop = false;
            // 
            // AuthForm
            // 
            this.AcceptButton = this._login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 489);
            this.ControlBox = false;
            this.Controls.Add(this._imageBox);
            this.Controls.Add(this._error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._emailAddress);
            this.Controls.Add(this._descriptionLabel);
            this.Controls.Add(this._titleLabel);
            this.Controls.Add(this._login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Melbourne Global Game Jam 2016";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion
        private Button _login;
        private Label _titleLabel;
        private Label _descriptionLabel;
        private TextBox _emailAddress;
        private Label label3;
        private Label label4;
        private TextBox _password;
        private Label _error;
        private PictureBox _imageBox;
    }
}