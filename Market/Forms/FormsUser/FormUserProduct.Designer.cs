namespace Market.Forms.FormsUser
{
    partial class FormUserProduct
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PriceBoxUser = new System.Windows.Forms.TextBox();
            this.DicBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.ComboBoxUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderPrice,
            this.columnHeaderDes});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1073, 1206);
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(200, 66);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "IDProduct";
            this.columnHeaderId.Width = 109;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 89;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.Width = 96;
            // 
            // columnHeaderDes
            // 
            this.columnHeaderDes.Text = "Des";
            this.columnHeaderDes.Width = 105;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IdBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PriceBoxUser);
            this.panel1.Controls.Add(this.DicBox);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonBuy);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.ComboBoxUser);
            this.panel1.Location = new System.Drawing.Point(1086, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 1206);
            this.panel1.TabIndex = 1;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(101, 247);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(285, 38);
            this.IdBox.TabIndex = 25;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(101, 324);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(285, 38);
            this.NameBox.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 32);
            this.label10.TabIndex = 31;
            this.label10.Text = "Dis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 32);
            this.label9.TabIndex = 30;
            this.label9.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 32);
            this.label8.TabIndex = 29;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 32);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID";
            // 
            // PriceBoxUser
            // 
            this.PriceBoxUser.Location = new System.Drawing.Point(101, 398);
            this.PriceBoxUser.Name = "PriceBoxUser";
            this.PriceBoxUser.Size = new System.Drawing.Size(285, 38);
            this.PriceBoxUser.TabIndex = 26;
            // 
            // DicBox
            // 
            this.DicBox.Location = new System.Drawing.Point(101, 474);
            this.DicBox.Name = "DicBox";
            this.DicBox.Size = new System.Drawing.Size(285, 38);
            this.DicBox.TabIndex = 27;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(240, 913);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(146, 42);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(12, 913);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(146, 42);
            this.buttonBuy.TabIndex = 6;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(240, 562);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(146, 42);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ComboBoxUser
            // 
            this.ComboBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxUser.ItemHeight = 30;
            this.ComboBoxUser.Location = new System.Drawing.Point(9, 114);
            this.ComboBoxUser.Name = "ComboBoxUser";
            this.ComboBoxUser.Size = new System.Drawing.Size(377, 36);
            this.ComboBoxUser.TabIndex = 0;
            this.ComboBoxUser.SelectedIndexChanged += new System.EventHandler(this.ComboBoxUser_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1494, 1225);
            this.panel2.TabIndex = 2;
            // 
            // FormUserProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2323, 1532);
            this.Controls.Add(this.panel2);
            this.Name = "FormUserProduct";
            this.Text = "FormUserProduct";
            this.Load += new System.EventHandler(this.FormUserProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.ColumnHeader columnHeaderDes;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxUser;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PriceBoxUser;
        private System.Windows.Forms.TextBox DicBox;
        private System.Windows.Forms.Panel panel2;
    }
}