namespace SportsFacility4A
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Main_BookingButton = new System.Windows.Forms.Button();
            this.Main_MaintenanceButton = new System.Windows.Forms.Button();
            this.Main_ReportButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beta Build";
            // 
            // Main_BookingButton
            // 
            this.Main_BookingButton.Location = new System.Drawing.Point(335, 133);
            this.Main_BookingButton.Margin = new System.Windows.Forms.Padding(6);
            this.Main_BookingButton.Name = "Main_BookingButton";
            this.Main_BookingButton.Size = new System.Drawing.Size(92, 23);
            this.Main_BookingButton.TabIndex = 2;
            this.Main_BookingButton.Text = "Booking";
            this.Main_BookingButton.UseVisualStyleBackColor = true;
            this.Main_BookingButton.Click += new System.EventHandler(this.Main_BookingButton_Click);
            // 
            // Main_MaintenanceButton
            // 
            this.Main_MaintenanceButton.Location = new System.Drawing.Point(335, 213);
            this.Main_MaintenanceButton.Margin = new System.Windows.Forms.Padding(6);
            this.Main_MaintenanceButton.Name = "Main_MaintenanceButton";
            this.Main_MaintenanceButton.Size = new System.Drawing.Size(92, 23);
            this.Main_MaintenanceButton.TabIndex = 3;
            this.Main_MaintenanceButton.Text = "Maintenance";
            this.Main_MaintenanceButton.UseVisualStyleBackColor = true;
            this.Main_MaintenanceButton.Click += new System.EventHandler(this.Main_MaintenanceButton_Click);
            // 
            // Main_ReportButton
            // 
            this.Main_ReportButton.Location = new System.Drawing.Point(335, 286);
            this.Main_ReportButton.Margin = new System.Windows.Forms.Padding(6);
            this.Main_ReportButton.Name = "Main_ReportButton";
            this.Main_ReportButton.Size = new System.Drawing.Size(92, 23);
            this.Main_ReportButton.TabIndex = 4;
            this.Main_ReportButton.Text = "Report Generation";
            this.Main_ReportButton.UseVisualStyleBackColor = true;
            this.Main_ReportButton.Click += new System.EventHandler(this.Main_ReportButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(718, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAvailabilityToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 19);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // resetAvailabilityToolStripMenuItem
            // 
            this.resetAvailabilityToolStripMenuItem.Name = "resetAvailabilityToolStripMenuItem";
            this.resetAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.resetAvailabilityToolStripMenuItem.Text = "Reset Availability";
            this.resetAvailabilityToolStripMenuItem.Click += new System.EventHandler(this.resetAvailabilityToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 437);
            this.Controls.Add(this.Main_ReportButton);
            this.Controls.Add(this.Main_MaintenanceButton);
            this.Controls.Add(this.Main_BookingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Sports Facility Booking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Main_BookingButton;
        private System.Windows.Forms.Button Main_MaintenanceButton;
        private System.Windows.Forms.Button Main_ReportButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetAvailabilityToolStripMenuItem;
    }
}

