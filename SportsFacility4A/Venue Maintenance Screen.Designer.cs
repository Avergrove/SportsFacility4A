namespace SportsFacility4A
{
	partial class Venue_Maintenance_Screen
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
			this.venuelabel = new System.Windows.Forms.Label();
			this.venueidlabel = new System.Windows.Forms.Label();
			this.venuenamelabel = new System.Windows.Forms.Label();
			this.Venueaddresslabel = new System.Windows.Forms.Label();
			this.venuecategorylabel = new System.Windows.Forms.Label();
			this.venueidtextbox = new System.Windows.Forms.TextBox();
			this.venuenametextbox = new System.Windows.Forms.TextBox();
			this.venueaddresstextbox = new System.Windows.Forms.TextBox();
			this.categorytextbox = new System.Windows.Forms.TextBox();
			this.updatebutton1 = new System.Windows.Forms.Button();
			this.createbutton = new System.Windows.Forms.Button();
			this.searchbutton = new System.Windows.Forms.Button();
			this.Refreshbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// venuelabel
			// 
			this.venuelabel.AutoSize = true;
			this.venuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.venuelabel.Location = new System.Drawing.Point(255, 64);
			this.venuelabel.Name = "venuelabel";
			this.venuelabel.Size = new System.Drawing.Size(433, 37);
			this.venuelabel.TabIndex = 0;
			this.venuelabel.Text = "Venue Maintenance Screen";
			// 
			// venueidlabel
			// 
			this.venueidlabel.AutoSize = true;
			this.venueidlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.venueidlabel.Location = new System.Drawing.Point(299, 160);
			this.venueidlabel.Name = "venueidlabel";
			this.venueidlabel.Size = new System.Drawing.Size(94, 25);
			this.venueidlabel.TabIndex = 1;
			this.venueidlabel.Text = "Venue ID";
			// 
			// venuenamelabel
			// 
			this.venuenamelabel.AutoSize = true;
			this.venuenamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.venuenamelabel.Location = new System.Drawing.Point(287, 240);
			this.venuenamelabel.Name = "venuenamelabel";
			this.venuenamelabel.Size = new System.Drawing.Size(127, 25);
			this.venuenamelabel.TabIndex = 2;
			this.venuenamelabel.Text = "Venue Name";
			// 
			// Venueaddresslabel
			// 
			this.Venueaddresslabel.AutoSize = true;
			this.Venueaddresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Venueaddresslabel.Location = new System.Drawing.Point(267, 327);
			this.Venueaddresslabel.Name = "Venueaddresslabel";
			this.Venueaddresslabel.Size = new System.Drawing.Size(148, 25);
			this.Venueaddresslabel.TabIndex = 3;
			this.Venueaddresslabel.Text = "Venue Address";
			// 
			// venuecategorylabel
			// 
			this.venuecategorylabel.AutoSize = true;
			this.venuecategorylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.venuecategorylabel.Location = new System.Drawing.Point(301, 432);
			this.venuecategorylabel.Name = "venuecategorylabel";
			this.venuecategorylabel.Size = new System.Drawing.Size(92, 25);
			this.venuecategorylabel.TabIndex = 4;
			this.venuecategorylabel.Text = "Category";
			// 
			// venueidtextbox
			// 
			this.venueidtextbox.Location = new System.Drawing.Point(454, 159);
			this.venueidtextbox.Name = "venueidtextbox";
			this.venueidtextbox.Size = new System.Drawing.Size(100, 26);
			this.venueidtextbox.TabIndex = 5;
			this.venueidtextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.venueidtextbox_KeyUp);
			// 
			// venuenametextbox
			// 
			this.venuenametextbox.Location = new System.Drawing.Point(454, 223);
			this.venuenametextbox.Multiline = true;
			this.venuenametextbox.Name = "venuenametextbox";
			this.venuenametextbox.Size = new System.Drawing.Size(309, 56);
			this.venuenametextbox.TabIndex = 6;
			// 
			// venueaddresstextbox
			// 
			this.venueaddresstextbox.Location = new System.Drawing.Point(454, 316);
			this.venueaddresstextbox.Multiline = true;
			this.venueaddresstextbox.Name = "venueaddresstextbox";
			this.venueaddresstextbox.Size = new System.Drawing.Size(309, 60);
			this.venueaddresstextbox.TabIndex = 7;
			// 
			// categorytextbox
			// 
			this.categorytextbox.Location = new System.Drawing.Point(454, 417);
			this.categorytextbox.Multiline = true;
			this.categorytextbox.Name = "categorytextbox";
			this.categorytextbox.Size = new System.Drawing.Size(221, 50);
			this.categorytextbox.TabIndex = 8;
			// 
			// updatebutton1
			// 
			this.updatebutton1.Location = new System.Drawing.Point(617, 542);
			this.updatebutton1.Name = "updatebutton1";
			this.updatebutton1.Size = new System.Drawing.Size(163, 59);
			this.updatebutton1.TabIndex = 9;
			this.updatebutton1.Text = "Update";
			this.updatebutton1.UseVisualStyleBackColor = true;
			this.updatebutton1.Click += new System.EventHandler(this.updatebutton1_Click);
			// 
			// createbutton
			// 
			this.createbutton.Location = new System.Drawing.Point(390, 542);
			this.createbutton.Name = "createbutton";
			this.createbutton.Size = new System.Drawing.Size(143, 59);
			this.createbutton.TabIndex = 10;
			this.createbutton.Text = "Create";
			this.createbutton.UseVisualStyleBackColor = true;
			this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
			// 
			// searchbutton
			// 
			this.searchbutton.Location = new System.Drawing.Point(582, 160);
			this.searchbutton.Name = "searchbutton";
			this.searchbutton.Size = new System.Drawing.Size(51, 24);
			this.searchbutton.TabIndex = 11;
			this.searchbutton.Text = "...";
			this.searchbutton.UseVisualStyleBackColor = true;
			this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
			// 
			// Refreshbutton
			// 
			this.Refreshbutton.Location = new System.Drawing.Point(172, 542);
			this.Refreshbutton.Name = "Refreshbutton";
			this.Refreshbutton.Size = new System.Drawing.Size(122, 59);
			this.Refreshbutton.TabIndex = 12;
			this.Refreshbutton.Text = "Refresh";
			this.Refreshbutton.UseVisualStyleBackColor = true;
			this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
			// 
			// Venue_Maintenance_Screen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 665);
			this.Controls.Add(this.Refreshbutton);
			this.Controls.Add(this.searchbutton);
			this.Controls.Add(this.createbutton);
			this.Controls.Add(this.updatebutton1);
			this.Controls.Add(this.categorytextbox);
			this.Controls.Add(this.venueaddresstextbox);
			this.Controls.Add(this.venuenametextbox);
			this.Controls.Add(this.venueidtextbox);
			this.Controls.Add(this.venuecategorylabel);
			this.Controls.Add(this.Venueaddresslabel);
			this.Controls.Add(this.venuenamelabel);
			this.Controls.Add(this.venueidlabel);
			this.Controls.Add(this.venuelabel);
			this.Name = "Venue_Maintenance_Screen";
			this.Text = "Venue_Maintenance_Screen";
			this.Load += new System.EventHandler(this.Venue_Maintenance_Screen_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label venuelabel;
		private System.Windows.Forms.Label venueidlabel;
		private System.Windows.Forms.Label venuenamelabel;
		private System.Windows.Forms.Label Venueaddresslabel;
		private System.Windows.Forms.Label venuecategorylabel;
		private System.Windows.Forms.TextBox venueidtextbox;
		private System.Windows.Forms.TextBox venuenametextbox;
		private System.Windows.Forms.TextBox venueaddresstextbox;
		private System.Windows.Forms.TextBox categorytextbox;
		private System.Windows.Forms.Button updatebutton1;
		private System.Windows.Forms.Button createbutton;
		private System.Windows.Forms.Button searchbutton;
		private System.Windows.Forms.Button Refreshbutton;
	}
}