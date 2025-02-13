namespace POS_System
{
    partial class FrmReportViewer
    {
        private System.ComponentModel.IContainer components = null;

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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.BtnMax = new System.Windows.Forms.ToolStripButton();
            this.Minimize = new System.Windows.Forms.ToolStripButton();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.toolStrip.SuspendLayout();
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
            this.toolStrip.Size = new System.Drawing.Size(800, 29);
            this.toolStrip.TabIndex = 17;
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
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 29);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(800, 471);
            this.crystalReportViewer.TabIndex = 18;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmReportViewer_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            

        }

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.ToolStripButton BtnMax;
        private System.Windows.Forms.ToolStripButton Minimize;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}
