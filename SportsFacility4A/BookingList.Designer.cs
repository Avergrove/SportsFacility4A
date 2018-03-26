namespace SportsFacility4A
{
    partial class BookingList
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
            this.bkinglistGridView = new System.Windows.Forms.DataGridView();
            this.mb_okbtn = new System.Windows.Forms.Button();
            this.mb_cancelbtn = new System.Windows.Forms.Button();
            this.bookinglistselCB = new System.Windows.Forms.ComboBox();
            this.mb_updatebtn = new System.Windows.Forms.Button();
            this.Reloadbtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bkinglistGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bkinglistGridView
            // 
            this.bkinglistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bkinglistGridView.Location = new System.Drawing.Point(37, 90);
            this.bkinglistGridView.MultiSelect = false;
            this.bkinglistGridView.Name = "bkinglistGridView";
            this.bkinglistGridView.ReadOnly = true;
            this.bkinglistGridView.RowTemplate.Height = 28;
            this.bkinglistGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bkinglistGridView.Size = new System.Drawing.Size(1235, 420);
            this.bkinglistGridView.TabIndex = 0;
            this.bkinglistGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bkinglistGridView_CellClick);
            this.bkinglistGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bkinglistGridView_CellDoubleClick);
            // 
            // mb_okbtn
            // 
            this.mb_okbtn.Location = new System.Drawing.Point(791, 25);
            this.mb_okbtn.Name = "mb_okbtn";
            this.mb_okbtn.Size = new System.Drawing.Size(146, 54);
            this.mb_okbtn.TabIndex = 1;
            this.mb_okbtn.Text = "Select";
            this.mb_okbtn.UseVisualStyleBackColor = true;
            this.mb_okbtn.Click += new System.EventHandler(this.mb_okbtn_Click);
            // 
            // mb_cancelbtn
            // 
            this.mb_cancelbtn.Location = new System.Drawing.Point(1126, 25);
            this.mb_cancelbtn.Name = "mb_cancelbtn";
            this.mb_cancelbtn.Size = new System.Drawing.Size(146, 54);
            this.mb_cancelbtn.TabIndex = 3;
            this.mb_cancelbtn.Text = "Cancel";
            this.mb_cancelbtn.UseVisualStyleBackColor = true;
            this.mb_cancelbtn.Click += new System.EventHandler(this.mb_cancelbtn_Click);
            // 
            // bookinglistselCB
            // 
            this.bookinglistselCB.FormattingEnabled = true;
            this.bookinglistselCB.Items.AddRange(new object[] {
            "Confirmed",
            "Cancelled"});
            this.bookinglistselCB.Location = new System.Drawing.Point(37, 56);
            this.bookinglistselCB.Name = "bookinglistselCB";
            this.bookinglistselCB.Size = new System.Drawing.Size(257, 28);
            this.bookinglistselCB.TabIndex = 4;
            this.bookinglistselCB.SelectedValueChanged += new System.EventHandler(this.bookinglistselCB_SelectedValueChanged);
            // 
            // mb_updatebtn
            // 
            this.mb_updatebtn.Location = new System.Drawing.Point(625, 25);
            this.mb_updatebtn.Name = "mb_updatebtn";
            this.mb_updatebtn.Size = new System.Drawing.Size(146, 54);
            this.mb_updatebtn.TabIndex = 5;
            this.mb_updatebtn.Text = "Update";
            this.mb_updatebtn.UseVisualStyleBackColor = true;
            this.mb_updatebtn.Visible = false;
            this.mb_updatebtn.Click += new System.EventHandler(this.mb_updatebtn_Click);
            // 
            // Reloadbtn
            // 
            this.Reloadbtn.Location = new System.Drawing.Point(958, 25);
            this.Reloadbtn.Name = "Reloadbtn";
            this.Reloadbtn.Size = new System.Drawing.Size(146, 54);
            this.Reloadbtn.TabIndex = 6;
            this.Reloadbtn.Text = "Reload";
            this.Reloadbtn.UseVisualStyleBackColor = true;
            this.Reloadbtn.Click += new System.EventHandler(this.Reloadbtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(37, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(254, 26);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchBox_MouseClick);
            this.SearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 486);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Reloadbtn);
            this.Controls.Add(this.mb_updatebtn);
            this.Controls.Add(this.bookinglistselCB);
            this.Controls.Add(this.mb_cancelbtn);
            this.Controls.Add(this.mb_okbtn);
            this.Controls.Add(this.bkinglistGridView);
            this.Name = "BookingList";
            this.Text = "Booking List";
            this.Load += new System.EventHandler(this.BookingsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bkinglistGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bkinglistGridView;
        private System.Windows.Forms.Button mb_okbtn;
        private System.Windows.Forms.Button mb_cancelbtn;
        private System.Windows.Forms.ComboBox bookinglistselCB;
        private System.Windows.Forms.Button mb_updatebtn;
        private System.Windows.Forms.Button Reloadbtn;
        private System.Windows.Forms.TextBox SearchBox;
    }
}