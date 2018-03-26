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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main_BookingButton = new System.Windows.Forms.Button();
            this.Main_MaintenanceButton = new System.Windows.Forms.Button();
            this.Main_ReportButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAvailabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.venueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demographicTrendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_BookingButton
            // 
            this.Main_BookingButton.Location = new System.Drawing.Point(216, 346);
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
            this.Main_MaintenanceButton.Location = new System.Drawing.Point(320, 346);
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
            this.Main_ReportButton.Location = new System.Drawing.Point(424, 346);
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
            this.toolStripMenuItem1,
            this.reportToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            this.resetAvailabilityToolStripMenuItem,
            this.bookingToolStripMenuItem1,
            this.venueToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 19);
            this.toolStripMenuItem1.Text = "Maintenance";
            // 
            // resetAvailabilityToolStripMenuItem
            // 
            this.resetAvailabilityToolStripMenuItem.Name = "resetAvailabilityToolStripMenuItem";
            this.resetAvailabilityToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.resetAvailabilityToolStripMenuItem.Text = "Customer..";
            this.resetAvailabilityToolStripMenuItem.Click += new System.EventHandler(this.resetAvailabilityToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem1
            // 
            this.bookingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.manageToolStripMenuItem1});
            this.bookingToolStripMenuItem1.Name = "bookingToolStripMenuItem1";
            this.bookingToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.bookingToolStripMenuItem1.Text = "Booking..";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.createToolStripMenuItem1.Text = "Create";
            // 
            // manageToolStripMenuItem1
            // 
            this.manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            this.manageToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem1.Text = "Manage";
            // 
            // venueToolStripMenuItem
            // 
            this.venueToolStripMenuItem.Name = "venueToolStripMenuItem";
            this.venueToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.venueToolStripMenuItem.Text = "Venue..";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberListToolStripMenuItem,
            this.bookingAnalysisToolStripMenuItem,
            this.demographicTrendToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // memberListToolStripMenuItem
            // 
            this.memberListToolStripMenuItem.Name = "memberListToolStripMenuItem";
            this.memberListToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.memberListToolStripMenuItem.Text = "Member List";
            // 
            // bookingAnalysisToolStripMenuItem
            // 
            this.bookingAnalysisToolStripMenuItem.Name = "bookingAnalysisToolStripMenuItem";
            this.bookingAnalysisToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.bookingAnalysisToolStripMenuItem.Text = "Booking Analysis";
            // 
            // demographicTrendToolStripMenuItem
            // 
            this.demographicTrendToolStripMenuItem.Name = "demographicTrendToolStripMenuItem";
            this.demographicTrendToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.demographicTrendToolStripMenuItem.Text = "Demographic Trend";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 415);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(718, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(289, 17);
            this.toolStripStatusLabel1.Text = "Please start by selecting an option from the menu bar";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 249);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sports Facilities Booking";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Main_ReportButton);
            this.Controls.Add(this.Main_MaintenanceButton);
            this.Controls.Add(this.Main_BookingButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Sports Facility Booking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Main_BookingButton;
        private System.Windows.Forms.Button Main_MaintenanceButton;
        private System.Windows.Forms.Button Main_ReportButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetAvailabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem venueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demographicTrendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

