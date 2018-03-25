namespace SportsFacility4A
{
    partial class Managebookings
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
            this.cidsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FacilityCB = new System.Windows.Forms.ComboBox();
            this.VenueCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeSlotCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelbookingbtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Remarkstextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mbclosebtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cidsearch
            // 
            this.cidsearch.Location = new System.Drawing.Point(581, 83);
            this.cidsearch.Margin = new System.Windows.Forms.Padding(2);
            this.cidsearch.Name = "cidsearch";
            this.cidsearch.Size = new System.Drawing.Size(55, 33);
            this.cidsearch.TabIndex = 19;
            this.cidsearch.Text = "...";
            this.cidsearch.UseVisualStyleBackColor = true;
            this.cidsearch.Click += new System.EventHandler(this.cidsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Facility";
            // 
            // FacilityCB
            // 
            this.FacilityCB.FormattingEnabled = true;
            this.FacilityCB.Location = new System.Drawing.Point(266, 85);
            this.FacilityCB.Name = "FacilityCB";
            this.FacilityCB.Size = new System.Drawing.Size(291, 28);
            this.FacilityCB.TabIndex = 20;
            this.FacilityCB.SelectionChangeCommitted += new System.EventHandler(this.FacilityCB_SelectionChangeCommitted);
            // 
            // VenueCB
            // 
            this.VenueCB.FormattingEnabled = true;
            this.VenueCB.Location = new System.Drawing.Point(266, 150);
            this.VenueCB.Name = "VenueCB";
            this.VenueCB.Size = new System.Drawing.Size(291, 28);
            this.VenueCB.TabIndex = 22;
            this.VenueCB.SelectionChangeCommitted += new System.EventHandler(this.VenueCB_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Venue";
            // 
            // TimeSlotCB
            // 
            this.TimeSlotCB.FormattingEnabled = true;
            this.TimeSlotCB.Location = new System.Drawing.Point(266, 209);
            this.TimeSlotCB.Name = "TimeSlotCB";
            this.TimeSlotCB.Size = new System.Drawing.Size(291, 28);
            this.TimeSlotCB.TabIndex = 24;
            this.TimeSlotCB.SelectionChangeCommitted += new System.EventHandler(this.TimeSlotCB_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Time Slot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Customer Name";
            // 
            // CustNameTextBox
            // 
            this.CustNameTextBox.Location = new System.Drawing.Point(266, 270);
            this.CustNameTextBox.Name = "CustNameTextBox";
            this.CustNameTextBox.ReadOnly = true;
            this.CustNameTextBox.Size = new System.Drawing.Size(291, 26);
            this.CustNameTextBox.TabIndex = 26;
            // 
            // cancelbookingbtn
            // 
            this.cancelbookingbtn.Location = new System.Drawing.Point(249, 420);
            this.cancelbookingbtn.Name = "cancelbookingbtn";
            this.cancelbookingbtn.Size = new System.Drawing.Size(148, 43);
            this.cancelbookingbtn.TabIndex = 27;
            this.cancelbookingbtn.Text = "Cancel Booking";
            this.cancelbookingbtn.UseVisualStyleBackColor = true;
            this.cancelbookingbtn.Click += new System.EventHandler(this.cancelbookingbtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(869, 30);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(24, 25);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // Remarkstextbox
            // 
            this.Remarkstextbox.Location = new System.Drawing.Point(266, 327);
            this.Remarkstextbox.Multiline = true;
            this.Remarkstextbox.Name = "Remarkstextbox";
            this.Remarkstextbox.Size = new System.Drawing.Size(291, 71);
            this.Remarkstextbox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Remarks";
            // 
            // mbclosebtn
            // 
            this.mbclosebtn.Location = new System.Drawing.Point(465, 420);
            this.mbclosebtn.Name = "mbclosebtn";
            this.mbclosebtn.Size = new System.Drawing.Size(112, 43);
            this.mbclosebtn.TabIndex = 31;
            this.mbclosebtn.Text = "Close";
            this.mbclosebtn.UseVisualStyleBackColor = true;
            this.mbclosebtn.Click += new System.EventHandler(this.mbclosebtn_Click);
            // 
            // Managebookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 496);
            this.Controls.Add(this.mbclosebtn);
            this.Controls.Add(this.Remarkstextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cancelbookingbtn);
            this.Controls.Add(this.CustNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeSlotCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VenueCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FacilityCB);
            this.Controls.Add(this.cidsearch);
            this.Controls.Add(this.label1);
            this.Name = "Managebookings";
            this.Text = "Manage Bookings";
            this.Load += new System.EventHandler(this.Managebookings_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cidsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FacilityCB;
        private System.Windows.Forms.ComboBox VenueCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TimeSlotCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustNameTextBox;
        private System.Windows.Forms.Button cancelbookingbtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox Remarkstextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button mbclosebtn;
    }
}