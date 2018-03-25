namespace SportsFacility4A
{
    partial class mb_timeslotform
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
            this.updatebk_cancelbtn = new System.Windows.Forms.Button();
            this.updatebk_okbtn = new System.Windows.Forms.Button();
            this.mb_availabilitygridview = new System.Windows.Forms.DataGridView();
            this.oldbookinglb = new System.Windows.Forms.Label();
            this.oldhourtb = new System.Windows.Forms.TextBox();
            this.newhourtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Categorycb = new System.Windows.Forms.ComboBox();
            this.oldvenuetb = new System.Windows.Forms.TextBox();
            this.oldcategorytb = new System.Windows.Forms.TextBox();
            this.newcategorytb = new System.Windows.Forms.TextBox();
            this.newvenuetb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mb_availabilitygridview)).BeginInit();
            this.SuspendLayout();
            // 
            // updatebk_cancelbtn
            // 
            this.updatebk_cancelbtn.Location = new System.Drawing.Point(741, 313);
            this.updatebk_cancelbtn.Name = "updatebk_cancelbtn";
            this.updatebk_cancelbtn.Size = new System.Drawing.Size(146, 54);
            this.updatebk_cancelbtn.TabIndex = 6;
            this.updatebk_cancelbtn.Text = "Cancel";
            this.updatebk_cancelbtn.UseVisualStyleBackColor = true;
            this.updatebk_cancelbtn.Click += new System.EventHandler(this.updatebk_cancelbtn_Click);
            // 
            // updatebk_okbtn
            // 
            this.updatebk_okbtn.Location = new System.Drawing.Point(924, 313);
            this.updatebk_okbtn.Name = "updatebk_okbtn";
            this.updatebk_okbtn.Size = new System.Drawing.Size(146, 54);
            this.updatebk_okbtn.TabIndex = 5;
            this.updatebk_okbtn.Text = "OK";
            this.updatebk_okbtn.UseVisualStyleBackColor = true;
            this.updatebk_okbtn.Click += new System.EventHandler(this.updatebk_okbtn_Click);
            // 
            // mb_availabilitygridview
            // 
            this.mb_availabilitygridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mb_availabilitygridview.Location = new System.Drawing.Point(16, 27);
            this.mb_availabilitygridview.MultiSelect = false;
            this.mb_availabilitygridview.Name = "mb_availabilitygridview";
            this.mb_availabilitygridview.ReadOnly = true;
            this.mb_availabilitygridview.RowTemplate.Height = 28;
            this.mb_availabilitygridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mb_availabilitygridview.Size = new System.Drawing.Size(655, 420);
            this.mb_availabilitygridview.TabIndex = 4;
            this.mb_availabilitygridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mb_availabilitygridview_CellClick_1);
            // 
            // oldbookinglb
            // 
            this.oldbookinglb.Location = new System.Drawing.Point(696, 58);
            this.oldbookinglb.Name = "oldbookinglb";
            this.oldbookinglb.Size = new System.Drawing.Size(144, 29);
            this.oldbookinglb.TabIndex = 7;
            this.oldbookinglb.Text = "Old Booking";
            this.oldbookinglb.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // oldhourtb
            // 
            this.oldhourtb.Location = new System.Drawing.Point(924, 122);
            this.oldhourtb.Name = "oldhourtb";
            this.oldhourtb.ReadOnly = true;
            this.oldhourtb.Size = new System.Drawing.Size(146, 26);
            this.oldhourtb.TabIndex = 8;
            this.oldhourtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newhourtb
            // 
            this.newhourtb.Location = new System.Drawing.Point(924, 236);
            this.newhourtb.Name = "newhourtb";
            this.newhourtb.ReadOnly = true;
            this.newhourtb.Size = new System.Drawing.Size(146, 26);
            this.newhourtb.TabIndex = 10;
            this.newhourtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(696, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "New Booking:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Categorycb
            // 
            this.Categorycb.FormattingEnabled = true;
            this.Categorycb.Items.AddRange(new object[] {
            "Current Booking"});
            this.Categorycb.Location = new System.Drawing.Point(694, 27);
            this.Categorycb.Name = "Categorycb";
            this.Categorycb.Size = new System.Drawing.Size(193, 28);
            this.Categorycb.TabIndex = 11;
            this.Categorycb.SelectedValueChanged += new System.EventHandler(this.Categorycb_SelectedValueChanged);
            // 
            // oldvenuetb
            // 
            this.oldvenuetb.Location = new System.Drawing.Point(694, 90);
            this.oldvenuetb.Name = "oldvenuetb";
            this.oldvenuetb.ReadOnly = true;
            this.oldvenuetb.Size = new System.Drawing.Size(376, 26);
            this.oldvenuetb.TabIndex = 12;
            this.oldvenuetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oldcategorytb
            // 
            this.oldcategorytb.Location = new System.Drawing.Point(694, 122);
            this.oldcategorytb.Name = "oldcategorytb";
            this.oldcategorytb.ReadOnly = true;
            this.oldcategorytb.Size = new System.Drawing.Size(193, 26);
            this.oldcategorytb.TabIndex = 13;
            this.oldcategorytb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newcategorytb
            // 
            this.newcategorytb.Location = new System.Drawing.Point(694, 236);
            this.newcategorytb.Name = "newcategorytb";
            this.newcategorytb.ReadOnly = true;
            this.newcategorytb.Size = new System.Drawing.Size(193, 26);
            this.newcategorytb.TabIndex = 15;
            this.newcategorytb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newvenuetb
            // 
            this.newvenuetb.Location = new System.Drawing.Point(694, 204);
            this.newvenuetb.Name = "newvenuetb";
            this.newvenuetb.ReadOnly = true;
            this.newvenuetb.Size = new System.Drawing.Size(376, 26);
            this.newvenuetb.TabIndex = 14;
            this.newvenuetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mb_timeslotform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 467);
            this.Controls.Add(this.newcategorytb);
            this.Controls.Add(this.newvenuetb);
            this.Controls.Add(this.oldcategorytb);
            this.Controls.Add(this.oldvenuetb);
            this.Controls.Add(this.Categorycb);
            this.Controls.Add(this.newhourtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldhourtb);
            this.Controls.Add(this.oldbookinglb);
            this.Controls.Add(this.updatebk_cancelbtn);
            this.Controls.Add(this.updatebk_okbtn);
            this.Controls.Add(this.mb_availabilitygridview);
            this.Name = "mb_timeslotform";
            this.Text = "Available Timeslot";
            this.Load += new System.EventHandler(this.mb_availabilityform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mb_availabilitygridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebk_cancelbtn;
        private System.Windows.Forms.Button updatebk_okbtn;
        private System.Windows.Forms.DataGridView mb_availabilitygridview;
        private System.Windows.Forms.Label oldbookinglb;
        private System.Windows.Forms.TextBox oldhourtb;
        private System.Windows.Forms.TextBox newhourtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Categorycb;
        private System.Windows.Forms.TextBox oldvenuetb;
        private System.Windows.Forms.TextBox oldcategorytb;
        private System.Windows.Forms.TextBox newcategorytb;
        private System.Windows.Forms.TextBox newvenuetb;
    }
}