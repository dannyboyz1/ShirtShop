﻿namespace ShirtShop
{
    partial class fmrLogIn
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
            this.lbluserName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoggIn = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnRegisterNewUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Location = new System.Drawing.Point(15, 38);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(108, 17);
            this.lbluserName.TabIndex = 0;
            this.lbluserName.Text = "Användarnamn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoggIn);
            this.groupBox1.Controls.Add(this.txtPassWord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.lbluserName);
            this.groupBox1.Location = new System.Drawing.Point(184, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 249);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logga In";
            // 
            // btnLoggIn
            // 
            this.btnLoggIn.BackColor = System.Drawing.Color.Gray;
            this.btnLoggIn.Location = new System.Drawing.Point(68, 194);
            this.btnLoggIn.Name = "btnLoggIn";
            this.btnLoggIn.Size = new System.Drawing.Size(90, 39);
            this.btnLoggIn.TabIndex = 4;
            this.btnLoggIn.Text = "Logga in";
            this.btnLoggIn.UseVisualStyleBackColor = false;
            this.btnLoggIn.Click += new System.EventHandler(this.btnLoggIn_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(21, 147);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(172, 22);
            this.txtPassWord.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lösenord:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(18, 69);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(175, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // btnRegisterNewUser
            // 
            this.btnRegisterNewUser.BackColor = System.Drawing.Color.Gray;
            this.btnRegisterNewUser.Location = new System.Drawing.Point(202, 330);
            this.btnRegisterNewUser.Name = "btnRegisterNewUser";
            this.btnRegisterNewUser.Size = new System.Drawing.Size(187, 37);
            this.btnRegisterNewUser.TabIndex = 2;
            this.btnRegisterNewUser.Text = "Registrera ny användare";
            this.btnRegisterNewUser.UseVisualStyleBackColor = false;
            this.btnRegisterNewUser.Click += new System.EventHandler(this.btnRegisterNewUser_Click);
            // 
            // fmrLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(618, 437);
            this.Controls.Add(this.btnRegisterNewUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmrLogIn";
            this.Text = "Shirt Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegisterNewUser;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLoggIn;
    }
}