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
            this.BtnViewProductList.Location = new System.Drawing.Point(12, 53);
            this.BtnViewProductList.Name = "BtnViewProductList";
            this.BtnViewProductList.Size = new System.Drawing.Size(250, 41);
            this.BtnViewProductList.TabIndex = 0;
            this.BtnViewProductList.Text = "View Product List";
            this.BtnViewProductList.UseVisualStyleBackColor = true;
            this.BtnViewProductList.Click += new System.EventHandler(this.BtnViewProductList_Click);
            // 
            // BtnProfitOrLossReport
            // 
            this.BtnProfitOrLossReport.Location = new System.Drawing.Point(166, 329);
            this.BtnProfitOrLossReport.Name = "BtnProfitOrLossReport";
            this.BtnProfitOrLossReport.Size = new System.Drawing.Size(457, 41);
            this.BtnProfitOrLossReport.TabIndex = 1;
            this.BtnProfitOrLossReport.Text = "View Profit Or LossReport Report";
            this.BtnProfitOrLossReport.UseVisualStyleBackColor = true;
            this.BtnProfitOrLossReport.Click += new System.EventHandler(this.BtnProfitOrLossReport_Click);
            // 
            // BtnViewPurchaseReport
            // 
            this.BtnViewPurchaseReport.Location = new System.Drawing.Point(579, 148);
            this.BtnViewPurchaseReport.Name = "BtnViewPurchaseReport";
            this.BtnViewPurchaseReport.Size = new System.Drawing.Size(150, 41);
            this.BtnViewPurchaseReport.TabIndex = 2;
            this.BtnViewPurchaseReport.Text = "View Purchase Report";
            this.BtnViewPurchaseReport.UseVisualStyleBackColor = true;
            this.BtnViewPurchaseReport.Click += new System.EventHandler(this.BtnViewPurchaseReport_Click);
            // 
            // BtnViewSalesReport
            // 
            this.BtnViewSalesReport.Location = new System.Drawing.Point(27, 145);
            this.BtnViewSalesReport.Name = "BtnViewSalesReport";
            this.BtnViewSalesReport.Size = new System.Drawing.Size(150, 44);
            this.BtnViewSalesReport.TabIndex = 3;
            this.BtnViewSalesReport.Text = "View Sales Report";
            this.BtnViewSalesReport.UseVisualStyleBackColor = true;
            this.BtnViewSalesReport.Click += new System.EventHandler(this.BtnViewSalesReport_Click);
            // 
            // BtnViewStockBalance
            // 
            this.BtnViewStockBalance.Location = new System.Drawing.Point(263, 148);
            this.BtnViewStockBalance.Name = "BtnViewStockBalance";
            this.BtnViewStockBalance.Size = new System.Drawing.Size(222, 41);
            this.BtnViewStockBalance.TabIndex = 4;
            this.BtnViewStockBalance.Text = "View Stock Balance";
            this.BtnViewStockBalance.UseVisualStyleBackColor = true;
            this.BtnViewStockBalance.Click += new System.EventHandler(this.BtnViewStockBalance_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Supplier List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnViewSupplierList_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "View Customer List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnViewCustomerList_Click);
            // 
            // FrmReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(778, 394);
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
