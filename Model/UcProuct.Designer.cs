namespace POS_System.Model
{
    partial class UcProuct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblPName = new System.Windows.Forms.Label();
            this.TxtPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblPrice);
            this.panel1.Controls.Add(this.LblPName);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 143);
            this.panel1.TabIndex = 0;
            // 
            // LblPrice
            // 
            this.LblPrice.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(-1, 103);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(168, 35);
            this.LblPrice.TabIndex = 1;
            this.LblPrice.Text = "200";
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPName
            // 
            this.LblPName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPName.Location = new System.Drawing.Point(1, 55);
            this.LblPName.Name = "LblPName";
            this.LblPName.Size = new System.Drawing.Size(166, 48);
            this.LblPName.TabIndex = 0;
            this.LblPName.Text = "Product Name";
            this.LblPName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPic
            // 
            this.TxtPic.Image = global::POS_System.Properties.Resources.product_64;
            this.TxtPic.Location = new System.Drawing.Point(51, 15);
            this.TxtPic.Name = "TxtPic";
            this.TxtPic.Size = new System.Drawing.Size(90, 90);
            this.TxtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TxtPic.TabIndex = 0;
            this.TxtPic.TabStop = false;
            this.TxtPic.Click += new System.EventHandler(this.TxtPic_Click);
            // 
            // UcProuct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.TxtPic);
            this.Controls.Add(this.panel1);
            this.Name = "UcProuct";
            this.Size = new System.Drawing.Size(195, 199);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox TxtPic;
        private System.Windows.Forms.Label LblPName;
        private System.Windows.Forms.Label LblPrice;
    }
}
