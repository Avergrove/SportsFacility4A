namespace SportsFacility4A
{
    partial class ReportGenerationForm
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
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managmentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trendChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberListToolStripMenuItem,
            this.managmentReportToolStripMenuItem,
            this.trendChartToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // memberListToolStripMenuItem
            // 
            this.memberListToolStripMenuItem.Name = "memberListToolStripMenuItem";
            this.memberListToolStripMenuItem.Size = new System.Drawing.Size(334, 38);
            this.memberListToolStripMenuItem.Text = "Member List";
            this.memberListToolStripMenuItem.Click += new System.EventHandler(this.memberListToolStripMenuItem_Click);
            // 
            // managmentReportToolStripMenuItem
            // 
            this.managmentReportToolStripMenuItem.Name = "managmentReportToolStripMenuItem";
            this.managmentReportToolStripMenuItem.Size = new System.Drawing.Size(334, 38);
            this.managmentReportToolStripMenuItem.Text = "Management Report";
            this.managmentReportToolStripMenuItem.Click += new System.EventHandler(this.managmentReportToolStripMenuItem_Click);
            // 
            // trendChartToolStripMenuItem
            // 
            this.trendChartToolStripMenuItem.Name = "trendChartToolStripMenuItem";
            this.trendChartToolStripMenuItem.Size = new System.Drawing.Size(334, 38);
            this.trendChartToolStripMenuItem.Text = "Trend Chart";
            this.trendChartToolStripMenuItem.Click += new System.EventHandler(this.trendChartToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2084, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.AutoSize = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayBackgroundEdge = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(1, 43);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1190, 583);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Visible = false;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ReportGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2084, 1059);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ReportGenerationForm";
            this.Text = "Report Generation";
            this.Load += new System.EventHandler(this.ReportGenerationForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managmentReportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
       // private SfBookingTxn SfBookingTxn1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trendChartToolStripMenuItem;
        // private SfBooktxn SfBooktxn1;
    }
}