namespace SportsFacility4A
{
    partial class BookingForm
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
            this.ActivityComboBox = new System.Windows.Forms.ComboBox();
            this.AvailabilityDataGrid = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.VenueComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.BookingButton = new System.Windows.Forms.Button();
            this.VenueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C9am = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C10am = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C11am = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C12pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C1pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C5pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AvailabilityDataGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activity";
            // 
            // ActivityComboBox
            // 
            this.ActivityComboBox.FormattingEnabled = true;
            this.ActivityComboBox.Location = new System.Drawing.Point(80, 75);
            this.ActivityComboBox.Name = "ActivityComboBox";
            this.ActivityComboBox.Size = new System.Drawing.Size(153, 21);
            this.ActivityComboBox.TabIndex = 6;
            this.ActivityComboBox.DropDown += new System.EventHandler(this.ActivityComboBox_DropDown);
            this.ActivityComboBox.SelectedValueChanged += new System.EventHandler(this.ActivityBox_SelectedIndexChanged);
            // 
            // AvailabilityDataGrid
            // 
            this.AvailabilityDataGrid.AllowUserToAddRows = false;
            this.AvailabilityDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailabilityDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VenueName,
            this.C9am,
            this.C10am,
            this.C11am,
            this.C12pm,
            this.C1pm,
            this.C2pm,
            this.C3pm,
            this.C4pm,
            this.C5pm});
            this.AvailabilityDataGrid.Location = new System.Drawing.Point(80, 114);
            this.AvailabilityDataGrid.MultiSelect = false;
            this.AvailabilityDataGrid.Name = "AvailabilityDataGrid";
            this.AvailabilityDataGrid.ReadOnly = true;
            this.AvailabilityDataGrid.RowHeadersVisible = false;
            this.AvailabilityDataGrid.Size = new System.Drawing.Size(553, 239);
            this.AvailabilityDataGrid.TabIndex = 8;
            this.AvailabilityDataGrid.SelectionChanged += new System.EventHandler(this.availabilityDataGrid_SelectionChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "Status Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Venue";
            // 
            // VenueComboBox
            // 
            this.VenueComboBox.FormattingEnabled = true;
            this.VenueComboBox.Location = new System.Drawing.Point(263, 75);
            this.VenueComboBox.Name = "VenueComboBox";
            this.VenueComboBox.Size = new System.Drawing.Size(142, 21);
            this.VenueComboBox.TabIndex = 7;
            this.VenueComboBox.SelectedIndexChanged += new System.EventHandler(this.VenueComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(454, 78);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(10, 13);
            this.AddressLabel.TabIndex = 11;
            this.AddressLabel.Text = "-";
            // 
            // BookingButton
            // 
            this.BookingButton.Enabled = false;
            this.BookingButton.Location = new System.Drawing.Point(457, 369);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(95, 23);
            this.BookingButton.TabIndex = 12;
            this.BookingButton.Text = "Make a Booking";
            this.BookingButton.UseVisualStyleBackColor = true;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            // 
            // VenueName
            // 
            this.VenueName.HeaderText = "Venue Name";
            this.VenueName.Name = "VenueName";
            this.VenueName.ReadOnly = true;
            // 
            // C9am
            // 
            this.C9am.HeaderText = "9 A.M.";
            this.C9am.Name = "C9am";
            this.C9am.ReadOnly = true;
            this.C9am.Width = 50;
            // 
            // C10am
            // 
            this.C10am.HeaderText = "10 A.M.";
            this.C10am.Name = "C10am";
            this.C10am.ReadOnly = true;
            this.C10am.Width = 50;
            // 
            // C11am
            // 
            this.C11am.HeaderText = "11 A.M.";
            this.C11am.Name = "C11am";
            this.C11am.ReadOnly = true;
            this.C11am.Width = 50;
            // 
            // C12pm
            // 
            this.C12pm.HeaderText = "12 P.M.";
            this.C12pm.Name = "C12pm";
            this.C12pm.ReadOnly = true;
            this.C12pm.Width = 50;
            // 
            // C1pm
            // 
            this.C1pm.HeaderText = "1 P.M.";
            this.C1pm.Name = "C1pm";
            this.C1pm.ReadOnly = true;
            this.C1pm.Width = 50;
            // 
            // C2pm
            // 
            this.C2pm.HeaderText = "2 P.M.";
            this.C2pm.Name = "C2pm";
            this.C2pm.ReadOnly = true;
            this.C2pm.Width = 50;
            // 
            // C3pm
            // 
            this.C3pm.HeaderText = "3 P.M.";
            this.C3pm.Name = "C3pm";
            this.C3pm.ReadOnly = true;
            this.C3pm.Width = 50;
            // 
            // C4pm
            // 
            this.C4pm.HeaderText = "4 P.M.";
            this.C4pm.Name = "C4pm";
            this.C4pm.ReadOnly = true;
            this.C4pm.Width = 50;
            // 
            // C5pm
            // 
            this.C5pm.HeaderText = "5 P.M.";
            this.C5pm.Name = "C5pm";
            this.C5pm.ReadOnly = true;
            this.C5pm.Width = 50;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.BookingButton);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AvailabilityDataGrid);
            this.Controls.Add(this.VenueComboBox);
            this.Controls.Add(this.ActivityComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookingForm";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvailabilityDataGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ActivityComboBox;
        private System.Windows.Forms.DataGridView AvailabilityDataGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VenueComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn C9am;
        private System.Windows.Forms.DataGridViewTextBoxColumn C10am;
        private System.Windows.Forms.DataGridViewTextBoxColumn C11am;
        private System.Windows.Forms.DataGridViewTextBoxColumn C12pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn C5pm;
    }
}