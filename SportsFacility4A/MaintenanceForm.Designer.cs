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
            this.savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustNameTextbox
            // 
            this.CustNameTextbox.Location = new System.Drawing.Point(197, 87);
            this.CustNameTextbox.Name = "CustNameTextbox";
            this.CustNameTextbox.Size = new System.Drawing.Size(278, 31);
            this.CustNameTextbox.TabIndex = 0;
            // 
            // CustName
            // 
            this.CustName.AutoSize = true;
            this.CustName.Location = new System.Drawing.Point(69, 87);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(68, 25);
            this.CustName.TabIndex = 2;
            this.CustName.Text = "Name";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(69, 161);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(74, 25);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "Phone";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(69, 253);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(91, 25);
            this.Address.TabIndex = 5;
            this.Address.Text = "Address";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(69, 355);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(65, 25);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // CIDtextbox
            // 
            this.CIDtextbox.Location = new System.Drawing.Point(197, 22);
            this.CIDtextbox.Name = "CIDtextbox";
            this.CIDtextbox.Size = new System.Drawing.Size(278, 31);
            this.CIDtextbox.TabIndex = 10;
            // 
            // phonetextbox
            // 
            this.phonetextbox.Location = new System.Drawing.Point(197, 155);
            this.phonetextbox.Name = "phonetextbox";
            this.phonetextbox.Size = new System.Drawing.Size(278, 31);
            this.phonetextbox.TabIndex = 11;
            // 
            // addresstextbox
            // 
            this.addresstextbox.Location = new System.Drawing.Point(197, 253);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(278, 31);
            this.addresstextbox.TabIndex = 12;
            // 
            // emailtextbox
            // 
            this.emailtextbox.Location = new System.Drawing.Point(197, 349);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(278, 31);
            this.emailtextbox.TabIndex = 13;
            // 
            // agetextbox
            // 
            this.agetextbox.Location = new System.Drawing.Point(197, 452);
            this.agetextbox.Name = "agetextbox";
            this.agetextbox.Size = new System.Drawing.Size(278, 31);
            this.agetextbox.TabIndex = 14;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(69, 452);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(50, 25);
            this.Age.TabIndex = 15;
            this.Age.Text = "Age";
            // 
            // cidsearch
            // 
            this.cidsearch.Location = new System.Drawing.Point(530, 22);
            this.cidsearch.Name = "cidsearch";
            this.cidsearch.Size = new System.Drawing.Size(73, 41);
            this.cidsearch.TabIndex = 16;
            this.cidsearch.Text = "...";
            this.cidsearch.UseVisualStyleBackColor = true;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(330, 556);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(145, 51);
            this.savebutton.TabIndex = 17;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 639);
            this.Controls.Add(this.savebutton);
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
        private System.Windows.Forms.Button savebutton;
    }
}