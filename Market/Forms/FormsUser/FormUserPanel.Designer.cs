using System.Windows.Forms;

namespace Market.Forms.FormsUser
{
    partial class FormUserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserPanel));
            this.panelFormUser = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAdminProfil = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBuyPanel = new System.Windows.Forms.Panel();
            this.ButtonHistory = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonTotal = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonProducts = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelFormUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormUser
            // 
            this.panelFormUser.BackColor = System.Drawing.Color.DarkCyan;
            this.panelFormUser.Controls.Add(this.pictureBox1);
            this.panelFormUser.Location = new System.Drawing.Point(337, 33);
            this.panelFormUser.Name = "panelFormUser";
            this.panelFormUser.Size = new System.Drawing.Size(1640, 1043);
            this.panelFormUser.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1608, 884);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAdminProfil);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelBuyPanel);
            this.panel1.Controls.Add(this.ButtonHistory);
            this.panel1.Controls.Add(this.ButtonTotal);
            this.panel1.Controls.Add(this.ButtonProducts);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelLevel);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 1046);
            this.panel1.TabIndex = 3;
            // 
            // labelAdminProfil
            // 
            this.labelAdminProfil.AutoSize = true;
            this.labelAdminProfil.Location = new System.Drawing.Point(104, 208);
            this.labelAdminProfil.Name = "labelAdminProfil";
            this.labelAdminProfil.Size = new System.Drawing.Size(92, 32);
            this.labelAdminProfil.TabIndex = 8;
            this.labelAdminProfil.Text = "label1";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DarkCyan;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(58, 468);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(181, 42);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "History";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(325, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1486, 1046);
            this.panel2.TabIndex = 2;
            // 
            // panelBuyPanel
            // 
            this.panelBuyPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelBuyPanel.Location = new System.Drawing.Point(328, 3);
            this.panelBuyPanel.Name = "panelBuyPanel";
            this.panelBuyPanel.Size = new System.Drawing.Size(1486, 1046);
            this.panelBuyPanel.TabIndex = 2;
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.BorderRadius = 8;
            this.ButtonHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonHistory.FillColor = System.Drawing.Color.DarkCyan;
            this.ButtonHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonHistory.ForeColor = System.Drawing.Color.White;
            this.ButtonHistory.Location = new System.Drawing.Point(58, 548);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.Size = new System.Drawing.Size(181, 42);
            this.ButtonHistory.TabIndex = 6;
            this.ButtonHistory.Text = "Exit";
            this.ButtonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // ButtonTotal
            // 
            this.ButtonTotal.BorderRadius = 8;
            this.ButtonTotal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonTotal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonTotal.FillColor = System.Drawing.Color.DarkCyan;
            this.ButtonTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonTotal.ForeColor = System.Drawing.Color.White;
            this.ButtonTotal.Location = new System.Drawing.Point(58, 302);
            this.ButtonTotal.Name = "ButtonTotal";
            this.ButtonTotal.Size = new System.Drawing.Size(181, 44);
            this.ButtonTotal.TabIndex = 5;
            this.ButtonTotal.Text = "Total";
            this.ButtonTotal.Click += new System.EventHandler(this.ButtonTotal_Click);
            // 
            // ButtonProducts
            // 
            this.ButtonProducts.BorderRadius = 8;
            this.ButtonProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonProducts.FillColor = System.Drawing.Color.DarkCyan;
            this.ButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonProducts.ForeColor = System.Drawing.Color.White;
            this.ButtonProducts.Location = new System.Drawing.Point(58, 390);
            this.ButtonProducts.Name = "ButtonProducts";
            this.ButtonProducts.Size = new System.Drawing.Size(181, 44);
            this.ButtonProducts.TabIndex = 4;
            this.ButtonProducts.Text = "Products";
            this.ButtonProducts.Click += new System.EventHandler(this.ButtonProducts_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(39, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "______________";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(117, 163);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(69, 32);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "user";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(87, 11);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(132, 130);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FormUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2913, 1700);
            this.Controls.Add(this.panelFormUser);
            this.Controls.Add(this.panel1);
            this.Name = "FormUserPanel";
            this.Text = "FormUserPanel";
            this.Load += new System.EventHandler(this.FormUserPanel_Load);
            this.panelFormUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBuyPanel;
        private Guna.UI2.WinForms.Guna2Button ButtonHistory;
        private Guna.UI2.WinForms.Guna2Button ButtonTotal;
        private Guna.UI2.WinForms.Guna2Button ButtonProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLevel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private PaintEventHandler panelFormUser_Paint;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label labelAdminProfil;
    }
}