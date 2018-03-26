namespace SportsFacility4A
{
	partial class Venue_Search_Screen
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
			this.venuegrid = new System.Windows.Forms.DataGridView();
			this.okvenuebutton = new System.Windows.Forms.Button();
			this.cancelbutton = new System.Windows.Forms.Button();
			this.searchvenuebutton = new System.Windows.Forms.Button();
			this.searchvenuetextbox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.venuegrid)).BeginInit();
			this.SuspendLayout();
			// 
			// venuegrid
			// 
			this.venuegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.venuegrid.Location = new System.Drawing.Point(98, 115);
			this.venuegrid.Name = "venuegrid";
			this.venuegrid.RowTemplate.Height = 28;
			this.venuegrid.Size = new System.Drawing.Size(775, 406);
			this.venuegrid.TabIndex = 0;
			// 
			// okvenuebutton
			// 
			this.okvenuebutton.Location = new System.Drawing.Point(172, 576);
			this.okvenuebutton.Name = "okvenuebutton";
			this.okvenuebutton.Size = new System.Drawing.Size(142, 52);
			this.okvenuebutton.TabIndex = 1;
			this.okvenuebutton.Text = "Ok";
			this.okvenuebutton.UseVisualStyleBackColor = true;
			// 
			// cancelbutton
			// 
			this.cancelbutton.Location = new System.Drawing.Point(558, 574);
			this.cancelbutton.Name = "cancelbutton";
			this.cancelbutton.Size = new System.Drawing.Size(156, 62);
			this.cancelbutton.TabIndex = 2;
			this.cancelbutton.Text = "Cancel";
			this.cancelbutton.UseVisualStyleBackColor = true;
			// 
			// searchvenuebutton
			// 
			this.searchvenuebutton.Location = new System.Drawing.Point(530, 38);
			this.searchvenuebutton.Name = "searchvenuebutton";
			this.searchvenuebutton.Size = new System.Drawing.Size(154, 40);
			this.searchvenuebutton.TabIndex = 3;
			this.searchvenuebutton.Text = "Search";
			this.searchvenuebutton.UseVisualStyleBackColor = true;
			// 
			// searchvenuetextbox
			// 
			this.searchvenuetextbox.Location = new System.Drawing.Point(254, 34);
			this.searchvenuetextbox.Multiline = true;
			this.searchvenuetextbox.Name = "searchvenuetextbox";
			this.searchvenuetextbox.Size = new System.Drawing.Size(220, 43);
			this.searchvenuetextbox.TabIndex = 4;
			// 
			// Venue_Search_Screen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(911, 673);
			this.Controls.Add(this.searchvenuetextbox);
			this.Controls.Add(this.searchvenuebutton);
			this.Controls.Add(this.cancelbutton);
			this.Controls.Add(this.okvenuebutton);
			this.Controls.Add(this.venuegrid);
			this.Name = "Venue_Search_Screen";
			this.Text = "Venue_Search_Screen";
			((System.ComponentModel.ISupportInitialize)(this.venuegrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView venuegrid;
		private System.Windows.Forms.Button okvenuebutton;
		private System.Windows.Forms.Button cancelbutton;
		private System.Windows.Forms.Button searchvenuebutton;
		private System.Windows.Forms.TextBox searchvenuetextbox;
	}
}