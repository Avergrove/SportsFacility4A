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
            this.Main_CustomerButton = new System.Windows.Forms.Button();
            this.Main_ReportButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_ViewBookingBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(988, 645);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beta Build";
            // 
            // Main_BookingButton
            // 
            this.Main_BookingButton.Location = new System.Drawing.Point(502, 205);
            this.Main_BookingButton.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Main_BookingButton.Name = "Main_BookingButton";
            this.Main_BookingButton.Size = new System.Drawing.Size(138, 35);
            this.Main_BookingButton.TabIndex = 2;
            this.Main_BookingButton.Text = "Booking";
            this.Main_BookingButton.UseVisualStyleBackColor = true;
            this.Main_BookingButton.Click += new System.EventHandler(this.Main_BookingButton_Click);
            // 
            // Main_CustomerButton
            // 
            this.Main_CustomerButton.Location = new System.Drawing.Point(502, 361);
            this.Main_CustomerButton.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Main_CustomerButton.Name = "Main_CustomerButton";
            this.Main_CustomerButton.Size = new System.Drawing.Size(138, 35);
            this.Main_CustomerButton.TabIndex = 3;
            this.Main_CustomerButton.Text = "Customer";
            this.Main_CustomerButton.UseVisualStyleBackColor = true;
            this.Main_CustomerButton.Click += new System.EventHandler(this.Main_MaintenanceButton_Click);
            // 
            // Main_ReportButton
            // 
            this.Main_ReportButton.Location = new System.Drawing.Point(502, 440);
            this.Main_ReportButton.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Main_ReportButton.Name = "Main_ReportButton";
            this.Main_ReportButton.Size = new System.Drawing.Size(138, 35);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(18, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1077, 41);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAvailabilityToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 29);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // resetAvailabilityToolStripMenuItem
            // 
            this.resetAvailabilityToolStripMenuItem.Name = "resetAvailabilityToolStripMenuItem";
            this.resetAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.resetAvailabilityToolStripMenuItem.Text = "Reset Availability";
            this.resetAvailabilityToolStripMenuItem.Click += new System.EventHandler(this.resetAvailabilityToolStripMenuItem_Click);
            // 
            // Main_ViewBookingBtn
            // 
            this.Main_ViewBookingBtn.Location = new System.Drawing.Point(502, 282);
            this.Main_ViewBookingBtn.Margin = new System.Windows.Forms.Padding(9);
            this.Main_ViewBookingBtn.Name = "Main_ViewBookingBtn";
            this.Main_ViewBookingBtn.Size = new System.Drawing.Size(138, 35);
            this.Main_ViewBookingBtn.TabIndex = 6;
            this.Main_ViewBookingBtn.Text = "View Bookings";
            this.Main_ViewBookingBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 672);
            this.Controls.Add(this.Main_ViewBookingBtn);
            this.Controls.Add(this.Main_ReportButton);
            this.Controls.Add(this.Main_CustomerButton);
            this.Controls.Add(this.Main_BookingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
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
        private System.Windows.Forms.Button Main_CustomerButton;
        private System.Windows.Forms.Button Main_ReportButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetAvailabilityToolStripMenuItem;
        private System.Windows.Forms.Button Main_ViewBookingBtn;
    }
}

