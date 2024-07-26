namespace POS_System
{
    partial class FrmReportView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button BtnViewProductList;
        private System.Windows.Forms.Button BtnProfitOrLossReport;
        private System.Windows.Forms.Button BtnViewPurchaseReport;
        private System.Windows.Forms.Button BtnViewSalesReport;
        private System.Windows.Forms.Button BtnViewStockBalance;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.BtnViewProductList = new System.Windows.Forms.Button();
            this.BtnProfitOrLossReport = new System.Windows.Forms.Button();
            this.BtnViewPurchaseReport = new System.Windows.Forms.Button();
            this.BtnViewSalesReport = new System.Windows.Forms.Button();
            this.BtnViewStockBalance = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnViewProductList
            // 
            this.BtnViewProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnViewProductList.ForeColor = System.Drawing.Color.White;
            this.BtnViewProductList.Image = global::POS_System.Properties.Resources.Product;
            this.BtnViewProductList.Location = new System.Drawing.Point(62, 91);
            this.BtnViewProductList.Name = "BtnViewProductList";
            this.BtnViewProductList.Size = new System.Drawing.Size(250, 50);
            this.BtnViewProductList.TabIndex = 0;
            this.BtnViewProductList.Text = "View Product List";
            this.BtnViewProductList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnViewProductList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnViewProductList.UseVisualStyleBackColor = false;
            this.BtnViewProductList.Click += new System.EventHandler(this.BtnViewProductList_Click);
            // 
            // BtnProfitOrLossReport
            // 
            this.BtnProfitOrLossReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnProfitOrLossReport.ForeColor = System.Drawing.Color.White;
            this.BtnProfitOrLossReport.Image = global::POS_System.Properties.Resources.Reports;
            this.BtnProfitOrLossReport.Location = new System.Drawing.Point(214, 260);
            this.BtnProfitOrLossReport.Name = "BtnProfitOrLossReport";
            this.BtnProfitOrLossReport.Size = new System.Drawing.Size(457, 41);
            this.BtnProfitOrLossReport.TabIndex = 1;
            this.BtnProfitOrLossReport.Text = "View Profit Or LossReport Report";
            this.BtnProfitOrLossReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProfitOrLossReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProfitOrLossReport.UseVisualStyleBackColor = false;
            this.BtnProfitOrLossReport.Click += new System.EventHandler(this.BtnProfitOrLossReport_Click);
            // 
            // BtnViewPurchaseReport
            // 
            this.BtnViewPurchaseReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnViewPurchaseReport.ForeColor = System.Drawing.Color.White;
            this.BtnViewPurchaseReport.Image = global::POS_System.Properties.Resources.Purchase;
            this.BtnViewPurchaseReport.Location = new System.Drawing.Point(318, 170);
            this.BtnViewPurchaseReport.Name = "BtnViewPurchaseReport";
            this.BtnViewPurchaseReport.Size = new System.Drawing.Size(250, 50);
            this.BtnViewPurchaseReport.TabIndex = 2;
            this.BtnViewPurchaseReport.Text = "View Purchase Report";
            this.BtnViewPurchaseReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnViewPurchaseReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnViewPurchaseReport.UseVisualStyleBackColor = false;
            this.BtnViewPurchaseReport.Click += new System.EventHandler(this.BtnViewPurchaseReport_Click);
            // 
            // BtnViewSalesReport
            // 
            this.BtnViewSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnViewSalesReport.ForeColor = System.Drawing.Color.White;
            this.BtnViewSalesReport.Image = global::POS_System.Properties.Resources.Sales;
            this.BtnViewSalesReport.Location = new System.Drawing.Point(62, 170);
            this.BtnViewSalesReport.Name = "BtnViewSalesReport";
            this.BtnViewSalesReport.Size = new System.Drawing.Size(250, 50);
            this.BtnViewSalesReport.TabIndex = 3;
            this.BtnViewSalesReport.Text = "View Sales Report";
            this.BtnViewSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnViewSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnViewSalesReport.UseVisualStyleBackColor = false;
            this.BtnViewSalesReport.Click += new System.EventHandler(this.BtnViewSalesReport_Click);
            // 
            // BtnViewStockBalance
            // 
            this.BtnViewStockBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.BtnViewStockBalance.ForeColor = System.Drawing.Color.White;
            this.BtnViewStockBalance.Image = global::POS_System.Properties.Resources.Stock_16;
            this.BtnViewStockBalance.Location = new System.Drawing.Point(577, 170);
            this.BtnViewStockBalance.Name = "BtnViewStockBalance";
            this.BtnViewStockBalance.Size = new System.Drawing.Size(250, 50);
            this.BtnViewStockBalance.TabIndex = 4;
            this.BtnViewStockBalance.Text = "View Stock Balance";
            this.BtnViewStockBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnViewStockBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnViewStockBalance.UseVisualStyleBackColor = false;
            this.BtnViewStockBalance.Click += new System.EventHandler(this.BtnViewStockBalance_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::POS_System.Properties.Resources.supplier;
            this.button1.Location = new System.Drawing.Point(318, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Supplier List";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnViewSupplierList_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(61)))), ((int)(((byte)(204)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::POS_System.Properties.Resources.Customers1;
            this.button2.Location = new System.Drawing.Point(577, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "View Customer List";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnViewCustomerList_Click);
            // 
            // FrmReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnViewProductList);
            this.Controls.Add(this.BtnProfitOrLossReport);
            this.Controls.Add(this.BtnViewPurchaseReport);
            this.Controls.Add(this.BtnViewSalesReport);
            this.Controls.Add(this.BtnViewStockBalance);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report View";
            this.Load += new System.EventHandler(this.FrmReportView_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
