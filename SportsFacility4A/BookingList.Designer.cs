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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mb_cancelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bkinglistGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bkinglistGridView
            // 
            this.bkinglistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bkinglistGridView.Location = new System.Drawing.Point(36, 23);
            this.bkinglistGridView.MultiSelect = false;
            this.bkinglistGridView.Name = "bkinglistGridView";
            this.bkinglistGridView.ReadOnly = true;
            this.bkinglistGridView.RowTemplate.Height = 28;
            this.bkinglistGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bkinglistGridView.Size = new System.Drawing.Size(655, 420);
            this.bkinglistGridView.TabIndex = 0;
            this.bkinglistGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bkinglistGridView_CellClick);
            this.bkinglistGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bkinglistGridView_CellDoubleClick);
            // 
            // mb_okbtn
            // 
            this.mb_okbtn.Location = new System.Drawing.Point(714, 47);
            this.mb_okbtn.Name = "mb_okbtn";
            this.mb_okbtn.Size = new System.Drawing.Size(146, 54);
            this.mb_okbtn.TabIndex = 1;
            this.mb_okbtn.Text = "OK";
            this.mb_okbtn.UseVisualStyleBackColor = true;
            this.mb_okbtn.Click += new System.EventHandler(this.mb_okbtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mb_cancelbtn
            // 
            this.mb_cancelbtn.Location = new System.Drawing.Point(714, 134);
            this.mb_cancelbtn.Name = "mb_cancelbtn";
            this.mb_cancelbtn.Size = new System.Drawing.Size(146, 54);
            this.mb_cancelbtn.TabIndex = 3;
            this.mb_cancelbtn.Text = "Cancel";
            this.mb_cancelbtn.UseVisualStyleBackColor = true;
            this.mb_cancelbtn.Click += new System.EventHandler(this.mb_cancelbtn_Click);
            // 
            // BookingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 486);
            this.Controls.Add(this.mb_cancelbtn);
            this.Controls.Add(this.statusStrip1);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button mb_cancelbtn;
    }
}