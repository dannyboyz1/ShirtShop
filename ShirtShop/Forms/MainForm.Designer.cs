﻿namespace ShirtShop
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbMan = new System.Windows.Forms.ComboBox();
            this.llblLogIn = new System.Windows.Forms.LinkLabel();
            this.llblRegisterNewUser = new System.Windows.Forms.LinkLabel();
            this.llblShoppingCart = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbLady = new System.Windows.Forms.ComboBox();
            this.cmbKid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(779, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sök";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(814, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(394, 115);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 276);
            this.listBox1.TabIndex = 6;
            // 
            // cmbMan
            // 
            this.cmbMan.FormattingEnabled = true;
            this.cmbMan.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.cmbMan.Location = new System.Drawing.Point(11, 42);
            this.cmbMan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMan.Name = "cmbMan";
            this.cmbMan.Size = new System.Drawing.Size(110, 24);
            this.cmbMan.TabIndex = 7;
            this.cmbMan.SelectedIndexChanged += new System.EventHandler(this.cmbMan_SelectedIndexChanged);
            // 
            // llblLogIn
            // 
            this.llblLogIn.AutoSize = true;
            this.llblLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llblLogIn.LinkColor = System.Drawing.Color.Black;
            this.llblLogIn.Location = new System.Drawing.Point(753, 22);
            this.llblLogIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblLogIn.Name = "llblLogIn";
            this.llblLogIn.Size = new System.Drawing.Size(63, 17);
            this.llblLogIn.TabIndex = 9;
            this.llblLogIn.TabStop = true;
            this.llblLogIn.Text = "Logga in";
            this.llblLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLogIn_LinkClicked);
            // 
            // llblRegisterNewUser
            // 
            this.llblRegisterNewUser.AutoSize = true;
            this.llblRegisterNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llblRegisterNewUser.LinkColor = System.Drawing.Color.Black;
            this.llblRegisterNewUser.Location = new System.Drawing.Point(834, 22);
            this.llblRegisterNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblRegisterNewUser.Name = "llblRegisterNewUser";
            this.llblRegisterNewUser.Size = new System.Drawing.Size(74, 17);
            this.llblRegisterNewUser.TabIndex = 10;
            this.llblRegisterNewUser.TabStop = true;
            this.llblRegisterNewUser.Text = "Registrera";
            this.llblRegisterNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegisterNewUser_LinkClicked);
            // 
            // llblShoppingCart
            // 
            this.llblShoppingCart.AutoSize = true;
            this.llblShoppingCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llblShoppingCart.LinkColor = System.Drawing.Color.Black;
            this.llblShoppingCart.Location = new System.Drawing.Point(930, 22);
            this.llblShoppingCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblShoppingCart.Name = "llblShoppingCart";
            this.llblShoppingCart.Size = new System.Drawing.Size(66, 17);
            this.llblShoppingCart.TabIndex = 11;
            this.llblShoppingCart.TabStop = true;
            this.llblShoppingCart.Text = "Varukorg";
            this.llblShoppingCart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShoppingCart_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(968, 115);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 17);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hitta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmbLady
            // 
            this.cmbLady.FormattingEnabled = true;
            this.cmbLady.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.cmbLady.Location = new System.Drawing.Point(139, 42);
            this.cmbLady.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLady.Name = "cmbLady";
            this.cmbLady.Size = new System.Drawing.Size(110, 24);
            this.cmbLady.TabIndex = 15;
            // 
            // cmbKid
            // 
            this.cmbKid.FormattingEnabled = true;
            this.cmbKid.Items.AddRange(new object[] {
            "Hattar",
            "T-shirts",
            "Skor"});
            this.cmbKid.Location = new System.Drawing.Point(264, 42);
            this.cmbKid.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKid.Name = "cmbKid";
            this.cmbKid.Size = new System.Drawing.Size(110, 24);
            this.cmbKid.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Herr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(261, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Barn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(136, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dam";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1073, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKid);
            this.Controls.Add(this.cmbLady);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.llblShoppingCart);
            this.Controls.Add(this.llblRegisterNewUser);
            this.Controls.Add(this.llblLogIn);
            this.Controls.Add(this.cmbMan);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "ShirtShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbMan;
        private System.Windows.Forms.LinkLabel llblLogIn;
        private System.Windows.Forms.LinkLabel llblRegisterNewUser;
        private System.Windows.Forms.LinkLabel llblShoppingCart;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbLady;
        private System.Windows.Forms.ComboBox cmbKid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

