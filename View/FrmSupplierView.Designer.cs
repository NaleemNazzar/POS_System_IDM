namespace POS_System.View
{
    partial class FrmSupplierView
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.DgvSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgvname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.DgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.TxtSearch);
            this.Panel1.Controls.Add(this.BtnAdd);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(800, 150);
            this.Panel1.TabIndex = 2;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtSearch.Location = new System.Drawing.Point(500, 109);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(250, 33);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.Text = " Search Here";
            this.TxtSearch.Click += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Image = global::POS_System.Properties.Resources.add;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(50, 97);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(200, 45);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add New";
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::POS_System.Properties.Resources.Search;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(495, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "    Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Image = global::POS_System.Properties.Resources.sSupplier;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Supplier List";
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
            this.Dgvname,
            this.DgvPhone,
            this.DgvEmail,
            this.DgvEdit,
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
            this.DataGridView1.Location = new System.Drawing.Point(50, 174);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.RowTemplate.Height = 28;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(700, 300);
            this.DataGridView1.TabIndex = 5;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
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
            // Dgvname
            // 
            this.Dgvname.HeaderText = "Name";
            this.Dgvname.MinimumWidth = 8;
            this.Dgvname.Name = "Dgvname";
            this.Dgvname.ReadOnly = true;
            // 
            // DgvPhone
            // 
            this.DgvPhone.HeaderText = "Phone";
            this.DgvPhone.MinimumWidth = 8;
            this.DgvPhone.Name = "DgvPhone";
            this.DgvPhone.ReadOnly = true;
            // 
            // DgvEmail
            // 
            this.DgvEmail.HeaderText = "Email";
            this.DgvEmail.MinimumWidth = 8;
            this.DgvEmail.Name = "DgvEmail";
            this.DgvEmail.ReadOnly = true;
            // 
            // DgvEdit
            // 
            this.DgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvEdit.FillWeight = 50F;
            this.DgvEdit.HeaderText = "";
            this.DgvEdit.Image = global::POS_System.Properties.Resources.add2;
            this.DgvEdit.MinimumWidth = 50;
            this.DgvEdit.Name = "DgvEdit";
            this.DgvEdit.ReadOnly = true;
            this.DgvEdit.Width = 50;
            // 
            // DgvDel
            // 
            this.DgvDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DgvDel.FillWeight = 50F;
            this.DgvDel.HeaderText = "";
            this.DgvDel.Image = global::POS_System.Properties.Resources.Delete;
            this.DgvDel.MinimumWidth = 50;
            this.DgvDel.Name = "DgvDel";
            this.DgvDel.ReadOnly = true;
            this.DgvDel.Width = 50;
            // 
            // FrmSupplierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSupplierView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSupplierView";
            this.Load += new System.EventHandler(this.FrmSupplierView_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Panel1;
        public System.Windows.Forms.TextBox TxtSearch;
        public System.Windows.Forms.Button BtnAdd;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgvname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvEmail;
        private System.Windows.Forms.DataGridViewImageColumn DgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn DgvDel;
    }
}