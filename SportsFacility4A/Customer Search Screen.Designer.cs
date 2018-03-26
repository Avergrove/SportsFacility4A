namespace SportsFacility4A
{
	partial class Customer_Search_Screen
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
			this.Custdatagrid = new System.Windows.Forms.DataGridView();
			this.searchtextbox = new System.Windows.Forms.TextBox();
			this.searchbutton = new System.Windows.Forms.Button();
			this.okbutton = new System.Windows.Forms.Button();
			this.cancelbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Custdatagrid)).BeginInit();
			this.SuspendLayout();
			// 
			// Custdatagrid
			// 
			this.Custdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Custdatagrid.Location = new System.Drawing.Point(71, 132);
			this.Custdatagrid.Name = "Custdatagrid";
			this.Custdatagrid.RowTemplate.Height = 28;
			this.Custdatagrid.Size = new System.Drawing.Size(767, 406);
			this.Custdatagrid.TabIndex = 0;
			// 
			// searchtextbox
			// 
			this.searchtextbox.Location = new System.Drawing.Point(284, 37);
			this.searchtextbox.Multiline = true;
			this.searchtextbox.Name = "searchtextbox";
			this.searchtextbox.Size = new System.Drawing.Size(198, 58);
			this.searchtextbox.TabIndex = 1;
			// 
			// searchbutton
			// 
			this.searchbutton.Location = new System.Drawing.Point(528, 37);
			this.searchbutton.Name = "searchbutton";
			this.searchbutton.Size = new System.Drawing.Size(105, 52);
			this.searchbutton.TabIndex = 2;
			this.searchbutton.Text = "Search";
			this.searchbutton.UseVisualStyleBackColor = true;
			// 
			// okbutton
			// 
			this.okbutton.Location = new System.Drawing.Point(268, 570);
			this.okbutton.Name = "okbutton";
			this.okbutton.Size = new System.Drawing.Size(133, 39);
			this.okbutton.TabIndex = 3;
			this.okbutton.Text = "Ok";
			this.okbutton.UseVisualStyleBackColor = true;
			// 
			// cancelbutton
			// 
			this.cancelbutton.Location = new System.Drawing.Point(528, 566);
			this.cancelbutton.Name = "cancelbutton";
			this.cancelbutton.Size = new System.Drawing.Size(139, 47);
			this.cancelbutton.TabIndex = 4;
			this.cancelbutton.Text = "Cancel";
			this.cancelbutton.UseVisualStyleBackColor = true;
			// 
			// Customer_Search_Screen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(909, 631);
			this.Controls.Add(this.cancelbutton);
			this.Controls.Add(this.okbutton);
			this.Controls.Add(this.searchbutton);
			this.Controls.Add(this.searchtextbox);
			this.Controls.Add(this.Custdatagrid);
			this.Name = "Customer_Search_Screen";
			this.Text = "Customer_Search_Screen";
			((System.ComponentModel.ISupportInitialize)(this.Custdatagrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView Custdatagrid;
		private System.Windows.Forms.TextBox searchtextbox;
		private System.Windows.Forms.Button searchbutton;
		private System.Windows.Forms.Button okbutton;
		private System.Windows.Forms.Button cancelbutton;
	}
}