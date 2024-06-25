namespace POS_System
{
    partial class FrmMain
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.BtnMax = new System.Windows.Forms.ToolStripButton();
            this.Minimize = new System.Windows.Forms.ToolStripButton();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.BtnSales = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnPurchase = new System.Windows.Forms.Button();
            this.BtnProduct = new System.Windows.Forms.Button();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.BtnSupplier = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Close,
            this.BtnMax,
            this.Minimize});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(900, 29);
            this.toolStrip.TabIndex = 16;
            this.toolStrip.Text = "toolStrip1";
            // 
            // Close
            // 
            this.Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Close.Image = global::POS_System.Properties.Resources.close_64;
            this.Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(34, 24);
            this.Close.Text = "Close";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMax.Image = global::POS_System.Properties.Resources.maximize_64;
            this.BtnMax.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(34, 24);
            this.BtnMax.Text = "Maximize";
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // Minimize
            // 
            this.Minimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Minimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Minimize.Image = global::POS_System.Properties.Resources.minimize_64;
            this.Minimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(34, 24);
            this.Minimize.Text = "Minimize";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // CenterPanel
            // 
            this.CenterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterPanel.Location = new System.Drawing.Point(254, 31);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(2);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(646, 558);
            this.CenterPanel.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.BtnSupplier);
            this.panel2.Controls.Add(this.BtnUsers);
            this.panel2.Controls.Add(this.BtnSales);
            this.panel2.Controls.Add(this.BtnCustomers);
            this.panel2.Controls.Add(this.BtnPurchase);
            this.panel2.Controls.Add(this.BtnProduct);
            this.panel2.Controls.Add(this.BtnCategory);
            this.panel2.Controls.Add(this.BtnHome);
            this.panel2.Controls.Add(this.LblUser);
            this.panel2.Controls.Add(this.PictureBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 571);
            this.panel2.TabIndex = 27;
            // 
            // BtnUsers
            // 
            this.BtnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnUsers.FlatAppearance.BorderSize = 0;
            this.BtnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnUsers.ForeColor = System.Drawing.Color.White;
            this.BtnUsers.Image = global::POS_System.Properties.Resources.Categary1;
            this.BtnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsers.Location = new System.Drawing.Point(50, 520);
            this.BtnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(150, 40);
            this.BtnUsers.TabIndex = 2;
            this.BtnUsers.Text = "   Users";
            this.BtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsers.UseVisualStyleBackColor = false;
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnSales
            // 
            this.BtnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSales.FlatAppearance.BorderSize = 0;
            this.BtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSales.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnSales.ForeColor = System.Drawing.Color.White;
            this.BtnSales.Image = global::POS_System.Properties.Resources.Sales;
            this.BtnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSales.Location = new System.Drawing.Point(50, 470);
            this.BtnSales.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSales.Name = "BtnSales";
            this.BtnSales.Size = new System.Drawing.Size(150, 40);
            this.BtnSales.TabIndex = 2;
            this.BtnSales.Text = "   Sales";
            this.BtnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSales.UseVisualStyleBackColor = false;
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCustomers.FlatAppearance.BorderSize = 0;
            this.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnCustomers.ForeColor = System.Drawing.Color.White;
            this.BtnCustomers.Image = global::POS_System.Properties.Resources.Customers;
            this.BtnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomers.Location = new System.Drawing.Point(50, 426);
            this.BtnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(181, 40);
            this.BtnCustomers.TabIndex = 2;
            this.BtnCustomers.Text = "   Customers";
            this.BtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCustomers.UseVisualStyleBackColor = false;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnPurchase
            // 
            this.BtnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPurchase.FlatAppearance.BorderSize = 0;
            this.BtnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPurchase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnPurchase.ForeColor = System.Drawing.Color.White;
            this.BtnPurchase.Image = global::POS_System.Properties.Resources.Purchase;
            this.BtnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPurchase.Location = new System.Drawing.Point(50, 382);
            this.BtnPurchase.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPurchase.Name = "BtnPurchase";
            this.BtnPurchase.Size = new System.Drawing.Size(150, 40);
            this.BtnPurchase.TabIndex = 2;
            this.BtnPurchase.Text = "   Purchase";
            this.BtnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPurchase.UseVisualStyleBackColor = false;
            // 
            // BtnProduct
            // 
            this.BtnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnProduct.FlatAppearance.BorderSize = 0;
            this.BtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnProduct.ForeColor = System.Drawing.Color.White;
            this.BtnProduct.Image = global::POS_System.Properties.Resources.Product;
            this.BtnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProduct.Location = new System.Drawing.Point(50, 288);
            this.BtnProduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Size = new System.Drawing.Size(150, 40);
            this.BtnProduct.TabIndex = 2;
            this.BtnProduct.Text = "   Product";
            this.BtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProduct.UseVisualStyleBackColor = false;
            // 
            // BtnCategory
            // 
            this.BtnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCategory.FlatAppearance.BorderSize = 0;
            this.BtnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnCategory.ForeColor = System.Drawing.Color.White;
            this.BtnCategory.Image = global::POS_System.Properties.Resources.Categary;
            this.BtnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategory.Location = new System.Drawing.Point(50, 244);
            this.BtnCategory.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Size = new System.Drawing.Size(198, 40);
            this.BtnCategory.TabIndex = 2;
            this.BtnCategory.Text = "   Category";
            this.BtnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCategory.UseVisualStyleBackColor = false;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Image = global::POS_System.Properties.Resources.home;
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(50, 200);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(2);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(150, 40);
            this.BtnHome.TabIndex = 2;
            this.BtnHome.Text = "   Home";
            this.BtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHome.UseVisualStyleBackColor = false;
            // 
            // LblUser
            // 
            this.LblUser.BackColor = System.Drawing.Color.Transparent;
            this.LblUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(2, 125);
            this.LblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(246, 32);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "Username";
            this.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::POS_System.Properties.Resources.icons8_person_48;
            this.PictureBox.Location = new System.Drawing.Point(78, 25);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(95, 95);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // BtnSupplier
            // 
            this.BtnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSupplier.FlatAppearance.BorderSize = 0;
            this.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnSupplier.ForeColor = System.Drawing.Color.White;
            this.BtnSupplier.Image = global::POS_System.Properties.Resources.Product;
            this.BtnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupplier.Location = new System.Drawing.Point(50, 332);
            this.BtnSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSupplier.Name = "BtnSupplier";
            this.BtnSupplier.Size = new System.Drawing.Size(150, 40);
            this.BtnSupplier.TabIndex = 3;
            this.BtnSupplier.Text = "   Supplier";
            this.BtnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSupplier.UseVisualStyleBackColor = false;
            this.BtnSupplier.Click += new System.EventHandler(this.BtnSupplier_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.ToolStripButton BtnMax;
        private System.Windows.Forms.ToolStripButton Minimize;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnUsers;
        private System.Windows.Forms.Button BtnSales;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnPurchase;
        private System.Windows.Forms.Button BtnProduct;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button BtnSupplier;
    }
}