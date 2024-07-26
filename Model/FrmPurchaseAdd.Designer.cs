namespace POS_System.Model
{
    partial class FrmPurchaseAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CbSupplier = new System.Windows.Forms.ComboBox();
            this.TxtBarcode = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.DateTimePicker();
            this.CbProduct = new System.Windows.Forms.ComboBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.DgvSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 100);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::POS_System.Properties.Resources.Purchase;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Purchase Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 100);
            this.panel2.TabIndex = 5;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Crimson;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(250, 28);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(150, 45);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(50, 28);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 45);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CbSupplier
            // 
            this.CbSupplier.FormattingEnabled = true;
            this.CbSupplier.Location = new System.Drawing.Point(368, 152);
            this.CbSupplier.Name = "CbSupplier";
            this.CbSupplier.Size = new System.Drawing.Size(300, 36);
            this.CbSupplier.TabIndex = 1;
            this.CbSupplier.Tag = "v";
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.BackColor = System.Drawing.Color.White;
            this.TxtBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBarcode.Location = new System.Drawing.Point(684, 155);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.Size = new System.Drawing.Size(300, 33);
            this.TxtBarcode.TabIndex = 2;
            this.TxtBarcode.Tag = "";
            // 
            // TxtDate
            // 
            this.TxtDate.Checked = false;
            this.TxtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtDate.Location = new System.Drawing.Point(52, 155);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(300, 33);
            this.TxtDate.TabIndex = 0;
            // 
            // CbProduct
            // 
            this.CbProduct.FormattingEnabled = true;
            this.CbProduct.Location = new System.Drawing.Point(58, 249);
            this.CbProduct.Name = "CbProduct";
            this.CbProduct.Size = new System.Drawing.Size(300, 36);
            this.CbProduct.TabIndex = 3;
            this.CbProduct.SelectedIndexChanged += new System.EventHandler(this.CbProduct_SelectedIndexChanged);
            // 
            // TxtQty
            // 
            this.TxtQty.BackColor = System.Drawing.Color.White;
            this.TxtQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtQty.Location = new System.Drawing.Point(368, 249);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(150, 33);
            this.TxtQty.TabIndex = 4;
            this.TxtQty.Tag = "";
            this.TxtQty.TextChanged += new System.EventHandler(this.TxtQty_TextChanged);
            // 
            // TxtCost
            // 
            this.TxtCost.BackColor = System.Drawing.Color.White;
            this.TxtCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCost.Location = new System.Drawing.Point(538, 249);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(150, 33);
            this.TxtCost.TabIndex = 5;
            this.TxtCost.Tag = "";
            // 
            // TxtAmount
            // 
            this.TxtAmount.BackColor = System.Drawing.Color.White;
            this.TxtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtAmount.Location = new System.Drawing.Point(706, 249);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(150, 33);
            this.TxtAmount.TabIndex = 6;
            this.TxtAmount.Tag = "";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(878, 215);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(106, 67);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.DgvSr,
            this.Dgvid,
            this.DgvProID,
            this.DgvProName,
            this.DgvQty,
            this.DgvCost,
            this.DgvAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.Location = new System.Drawing.Point(52, 314);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.RowTemplate.Height = 28;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(932, 259);
            this.DataGridView1.TabIndex = 38;
            this.DataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // DgvSr
            // 
            this.DgvSr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvSr.FillWeight = 70F;
            this.DgvSr.HeaderText = "Sr #";
            this.DgvSr.MinimumWidth = 70;
            this.DgvSr.Name = "DgvSr";
            this.DgvSr.ReadOnly = true;
            this.DgvSr.Width = 70;
            // 
            // Dgvid
            // 
            this.Dgvid.HeaderText = "id";
            this.Dgvid.MinimumWidth = 8;
            this.Dgvid.Name = "Dgvid";
            this.Dgvid.ReadOnly = true;
            this.Dgvid.Visible = false;
            // 
            // DgvProID
            // 
            this.DgvProID.HeaderText = "proid";
            this.DgvProID.MinimumWidth = 8;
            this.DgvProID.Name = "DgvProID";
            this.DgvProID.ReadOnly = true;
            this.DgvProID.Visible = false;
            // 
            // DgvProName
            // 
            this.DgvProName.HeaderText = "Product Name";
            this.DgvProName.MinimumWidth = 100;
            this.DgvProName.Name = "DgvProName";
            this.DgvProName.ReadOnly = true;
            // 
            // DgvQty
            // 
            this.DgvQty.HeaderText = "Quantity";
            this.DgvQty.MinimumWidth = 100;
            this.DgvQty.Name = "DgvQty";
            this.DgvQty.ReadOnly = true;
            // 
            // DgvCost
            // 
            this.DgvCost.HeaderText = "Cost";
            this.DgvCost.MinimumWidth = 100;
            this.DgvCost.Name = "DgvCost";
            this.DgvCost.ReadOnly = true;
            // 
            // DgvAmount
            // 
            this.DgvAmount.HeaderText = "Amount";
            this.DgvAmount.MinimumWidth = 100;
            this.DgvAmount.Name = "DgvAmount";
            this.DgvAmount.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::POS_System.Properties.Resources.pProduct;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(53, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = "     Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::POS_System.Properties.Resources.sSupplier;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(363, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "     Supplier";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = global::POS_System.Properties.Resources.icons8_estimate_16;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(701, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 28);
            this.label8.TabIndex = 33;
            this.label8.Text = "     Amount";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Image = global::POS_System.Properties.Resources.Cost_16;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(533, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "     Cost";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = global::POS_System.Properties.Resources.icons8_quantity_16;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(363, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "     Qty";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::POS_System.Properties.Resources.icons8_date_16;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(53, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "     Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::POS_System.Properties.Resources.Barcode_16;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(679, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "     Barcode";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPurchaseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1015, 701);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.CbProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtBarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPurchaseAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPurchaseAdd";
            this.Load += new System.EventHandler(this.FrmPurchaseAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button BtnClose;
        public System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CbSupplier;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtBarcode;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TxtDate;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbProduct;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtQty;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtCost;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvAmount;
    }
}