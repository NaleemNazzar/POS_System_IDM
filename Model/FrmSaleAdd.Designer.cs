namespace POS_System.Model
{
    partial class FrmSaleAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CbCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvproid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbCustomer
            // 
            this.CbCustomer.FormattingEnabled = true;
            this.CbCustomer.Location = new System.Drawing.Point(227, 70);
            this.CbCustomer.Name = "CbCustomer";
            this.CbCustomer.Size = new System.Drawing.Size(250, 36);
            this.CbCustomer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Customer";
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBarcode.Location = new System.Drawing.Point(498, 73);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.Size = new System.Drawing.Size(250, 33);
            this.TxtBarcode.TabIndex = 2;
            this.TxtBarcode.Tag = "v";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Barcode";
            // 
            // TxtDate
            // 
            this.TxtDate.Checked = false;
            this.TxtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtDate.Location = new System.Drawing.Point(32, 73);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(159, 33);
            this.TxtDate.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 28);
            this.label4.TabIndex = 37;
            this.label4.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.LblTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(797, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 55);
            this.panel1.TabIndex = 6;
            // 
            // LblTotal
            // 
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.LblTotal.ForeColor = System.Drawing.Color.White;
            this.LblTotal.Location = new System.Drawing.Point(169, 7);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(158, 38);
            this.LblTotal.TabIndex = 0;
            this.LblTotal.Text = "0.00";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Grand Total";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(65)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeight = 35;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgvid,
            this.Dgvproid,
            this.DgvProduct,
            this.DgvQty,
            this.DgvPrice,
            this.DgvAmount,
            this.DgvCost,
            this.DgvDel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(797, 137);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.RowTemplate.Height = 28;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(337, 437);
            this.DataGridView1.TabIndex = 5;
            // 
            // Dgvid
            // 
            this.Dgvid.HeaderText = "id";
            this.Dgvid.MinimumWidth = 8;
            this.Dgvid.Name = "Dgvid";
            this.Dgvid.ReadOnly = true;
            this.Dgvid.Visible = false;
            // 
            // Dgvproid
            // 
            this.Dgvproid.HeaderText = "proid";
            this.Dgvproid.MinimumWidth = 8;
            this.Dgvproid.Name = "Dgvproid";
            this.Dgvproid.ReadOnly = true;
            this.Dgvproid.Visible = false;
            // 
            // DgvProduct
            // 
            this.DgvProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DgvProduct.HeaderText = "Product";
            this.DgvProduct.MinimumWidth = 100;
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.ReadOnly = true;
            // 
            // DgvQty
            // 
            this.DgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvQty.FillWeight = 50F;
            this.DgvQty.HeaderText = "Qty";
            this.DgvQty.MinimumWidth = 50;
            this.DgvQty.Name = "DgvQty";
            this.DgvQty.ReadOnly = true;
            this.DgvQty.Width = 50;
            // 
            // DgvPrice
            // 
            this.DgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvPrice.FillWeight = 70F;
            this.DgvPrice.HeaderText = "Price";
            this.DgvPrice.MinimumWidth = 70;
            this.DgvPrice.Name = "DgvPrice";
            this.DgvPrice.ReadOnly = true;
            this.DgvPrice.Width = 70;
            // 
            // DgvAmount
            // 
            this.DgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvAmount.FillWeight = 70F;
            this.DgvAmount.HeaderText = "Amount";
            this.DgvAmount.MinimumWidth = 70;
            this.DgvAmount.Name = "DgvAmount";
            this.DgvAmount.ReadOnly = true;
            this.DgvAmount.Width = 70;
            // 
            // DgvCost
            // 
            this.DgvCost.HeaderText = "Cost";
            this.DgvCost.MinimumWidth = 8;
            this.DgvCost.Name = "DgvCost";
            this.DgvCost.ReadOnly = true;
            this.DgvCost.Visible = false;
            // 
            // DgvDel
            // 
            this.DgvDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvDel.FillWeight = 30F;
            this.DgvDel.HeaderText = "";
            this.DgvDel.Image = global::POS_System.Properties.Resources.Delete;
            this.DgvDel.MinimumWidth = 30;
            this.DgvDel.Name = "DgvDel";
            this.DgvDel.ReadOnly = true;
            this.DgvDel.Width = 30;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 186);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(734, 388);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::POS_System.Properties.Resources.Search;
            this.PictureBox1.Location = new System.Drawing.Point(38, 152);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(15, 15);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 43;
            this.PictureBox1.TabStop = false;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtSearch.Location = new System.Drawing.Point(29, 144);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(250, 33);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.Text = "      Search Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "Search";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Close});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(1173, 29);
            this.toolStrip.TabIndex = 44;
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
            // FrmSaleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1173, 600);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSaleAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSaleAdd";
            this.Load += new System.EventHandler(this.FrmSaleAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbCustomer;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtBarcode;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TxtDate;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvproid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCost;
        private System.Windows.Forms.DataGridViewImageColumn DgvDel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.PictureBox PictureBox1;
        public System.Windows.Forms.TextBox TxtSearch;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton Close;
    }
}