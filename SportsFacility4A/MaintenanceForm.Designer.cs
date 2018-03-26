namespace SportsFacility4A
{
    partial class MaintenanceForm
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
			this.CustNameTextbox = new System.Windows.Forms.TextBox();
			this.CustName = new System.Windows.Forms.Label();
			this.Phone = new System.Windows.Forms.Label();
			this.Address = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CIDtextbox = new System.Windows.Forms.TextBox();
			this.phonetextbox = new System.Windows.Forms.TextBox();
			this.addresstextbox = new System.Windows.Forms.TextBox();
			this.emailtextbox = new System.Windows.Forms.TextBox();
			this.agetextbox = new System.Windows.Forms.TextBox();
			this.Age = new System.Windows.Forms.Label();
			this.cidsearch = new System.Windows.Forms.Button();
			this.updatebutton = new System.Windows.Forms.Button();
			this.createbutton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Status = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Notes = new System.Windows.Forms.TextBox();
			this.Refreshbutton = new System.Windows.Forms.Button();
			this.Bookbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CustNameTextbox
			// 
			this.CustNameTextbox.Location = new System.Drawing.Point(444, 197);
			this.CustNameTextbox.Margin = new System.Windows.Forms.Padding(2);
			this.CustNameTextbox.Name = "CustNameTextbox";
			this.CustNameTextbox.Size = new System.Drawing.Size(245, 26);
			this.CustNameTextbox.TabIndex = 0;
			// 
			// CustName
			// 
			this.CustName.AutoSize = true;
			this.CustName.Location = new System.Drawing.Point(288, 203);
			this.CustName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.CustName.Name = "CustName";
			this.CustName.Size = new System.Drawing.Size(51, 20);
			this.CustName.TabIndex = 2;
			this.CustName.Text = "Name";
			// 
			// Phone
			// 
			this.Phone.AutoSize = true;
			this.Phone.Location = new System.Drawing.Point(288, 270);
			this.Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Phone.Name = "Phone";
			this.Phone.Size = new System.Drawing.Size(55, 20);
			this.Phone.TabIndex = 3;
			this.Phone.Text = "Phone";
			// 
			// Address
			// 
			this.Address.AutoSize = true;
			this.Address.Location = new System.Drawing.Point(288, 349);
			this.Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Address.Name = "Address";
			this.Address.Size = new System.Drawing.Size(68, 20);
			this.Address.TabIndex = 5;
			this.Address.Text = "Address";
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(288, 411);
			this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(48, 20);
			this.Email.TabIndex = 7;
			this.Email.Text = "Email";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(288, 137);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "ID";
			// 
			// CIDtextbox
			// 
			this.CIDtextbox.Location = new System.Drawing.Point(444, 130);
			this.CIDtextbox.Margin = new System.Windows.Forms.Padding(2);
			this.CIDtextbox.Name = "CIDtextbox";
			this.CIDtextbox.Size = new System.Drawing.Size(245, 26);
			this.CIDtextbox.TabIndex = 10;
			this.CIDtextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CIDtextbox_KeyUp);
			// 
			// phonetextbox
			// 
			this.phonetextbox.Location = new System.Drawing.Point(444, 264);
			this.phonetextbox.Margin = new System.Windows.Forms.Padding(2);
			this.phonetextbox.Name = "phonetextbox";
			this.phonetextbox.Size = new System.Drawing.Size(245, 26);
			this.phonetextbox.TabIndex = 11;
			// 
			// addresstextbox
			// 
			this.addresstextbox.Location = new System.Drawing.Point(444, 325);
			this.addresstextbox.Margin = new System.Windows.Forms.Padding(2);
			this.addresstextbox.Multiline = true;
			this.addresstextbox.Name = "addresstextbox";
			this.addresstextbox.Size = new System.Drawing.Size(402, 53);
			this.addresstextbox.TabIndex = 12;
			// 
			// emailtextbox
			// 
			this.emailtextbox.Location = new System.Drawing.Point(444, 405);
			this.emailtextbox.Margin = new System.Windows.Forms.Padding(2);
			this.emailtextbox.Name = "emailtextbox";
			this.emailtextbox.Size = new System.Drawing.Size(245, 26);
			this.emailtextbox.TabIndex = 13;
			// 
			// agetextbox
			// 
			this.agetextbox.Location = new System.Drawing.Point(444, 478);
			this.agetextbox.Margin = new System.Windows.Forms.Padding(2);
			this.agetextbox.Name = "agetextbox";
			this.agetextbox.Size = new System.Drawing.Size(245, 26);
			this.agetextbox.TabIndex = 14;
			// 
			// Age
			// 
			this.Age.AutoSize = true;
			this.Age.Location = new System.Drawing.Point(288, 484);
			this.Age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Age.Name = "Age";
			this.Age.Size = new System.Drawing.Size(38, 20);
			this.Age.TabIndex = 15;
			this.Age.Text = "Age";
			// 
			// cidsearch
			// 
			this.cidsearch.Location = new System.Drawing.Point(724, 130);
			this.cidsearch.Margin = new System.Windows.Forms.Padding(2);
			this.cidsearch.Name = "cidsearch";
			this.cidsearch.Size = new System.Drawing.Size(55, 33);
			this.cidsearch.TabIndex = 16;
			this.cidsearch.Text = "...";
			this.cidsearch.UseVisualStyleBackColor = true;
			this.cidsearch.Click += new System.EventHandler(this.cidsearch_Click);
			// 
			// updatebutton
			// 
			this.updatebutton.Location = new System.Drawing.Point(543, 658);
			this.updatebutton.Margin = new System.Windows.Forms.Padding(2);
			this.updatebutton.Name = "updatebutton";
			this.updatebutton.Size = new System.Drawing.Size(120, 50);
			this.updatebutton.TabIndex = 17;
			this.updatebutton.Text = "Update";
			this.updatebutton.UseVisualStyleBackColor = true;
			this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
			// 
			// createbutton
			// 
			this.createbutton.Location = new System.Drawing.Point(367, 658);
			this.createbutton.Name = "createbutton";
			this.createbutton.Size = new System.Drawing.Size(118, 50);
			this.createbutton.TabIndex = 18;
			this.createbutton.Text = "Create";
			this.createbutton.UseVisualStyleBackColor = true;
			this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(272, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(534, 40);
			this.label2.TabIndex = 20;
			this.label2.Text = "Customer Maintenance screen";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(285, 545);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 20);
			this.label3.TabIndex = 21;
			this.label3.Text = "Status";
			// 
			// Status
			// 
			this.Status.FormattingEnabled = true;
			this.Status.Location = new System.Drawing.Point(444, 536);
			this.Status.Name = "Status";
			this.Status.Size = new System.Drawing.Size(121, 28);
			this.Status.TabIndex = 22;
			this.Status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(285, 601);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 20);
			this.label4.TabIndex = 23;
			this.label4.Text = "Notes";
			// 
			// Notes
			// 
			this.Notes.Location = new System.Drawing.Point(444, 583);
			this.Notes.Multiline = true;
			this.Notes.Name = "Notes";
			this.Notes.Size = new System.Drawing.Size(402, 58);
			this.Notes.TabIndex = 24;
			// 
			// Refreshbutton
			// 
			this.Refreshbutton.Location = new System.Drawing.Point(176, 658);
			this.Refreshbutton.Name = "Refreshbutton";
			this.Refreshbutton.Size = new System.Drawing.Size(94, 50);
			this.Refreshbutton.TabIndex = 25;
			this.Refreshbutton.Text = "Refresh";
			this.Refreshbutton.UseVisualStyleBackColor = true;
			this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
			// 
			// Bookbutton
			// 
			this.Bookbutton.Location = new System.Drawing.Point(715, 658);
			this.Bookbutton.Name = "Bookbutton";
			this.Bookbutton.Size = new System.Drawing.Size(104, 49);
			this.Bookbutton.TabIndex = 26;
			this.Bookbutton.Text = "Book";
			this.Bookbutton.UseVisualStyleBackColor = true;
			this.Bookbutton.Click += new System.EventHandler(this.Bookbutton_Click);
			// 
			// MaintenanceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 719);
			this.Controls.Add(this.Bookbutton);
			this.Controls.Add(this.Refreshbutton);
			this.Controls.Add(this.Notes);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Status);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.createbutton);
			this.Controls.Add(this.updatebutton);
			this.Controls.Add(this.cidsearch);
			this.Controls.Add(this.Age);
			this.Controls.Add(this.agetextbox);
			this.Controls.Add(this.emailtextbox);
			this.Controls.Add(this.addresstextbox);
			this.Controls.Add(this.phonetextbox);
			this.Controls.Add(this.CIDtextbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.Address);
			this.Controls.Add(this.Phone);
			this.Controls.Add(this.CustName);
			this.Controls.Add(this.CustNameTextbox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MaintenanceForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustNameTextbox;
        private System.Windows.Forms.Label CustName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CIDtextbox;
        private System.Windows.Forms.TextBox phonetextbox;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.TextBox emailtextbox;
        private System.Windows.Forms.TextBox agetextbox;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Button cidsearch;
        private System.Windows.Forms.Button updatebutton;
		private System.Windows.Forms.Button createbutton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox Status;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Notes;
		private System.Windows.Forms.Button Refreshbutton;
		private System.Windows.Forms.Button Bookbutton;
	}
}