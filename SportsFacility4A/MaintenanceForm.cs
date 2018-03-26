using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsFacility4A
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
			Status.Items.Add("Active");
			Status.Items.Add("In Active");

		}

		public  string custid
		{
			set
			{
				CIDtextbox.Text = value;
			}
		}

		public string custname
		{
			set
			{
				CustNameTextbox.Text = value;
			}
		}

		public string phonenumber
		{
			set
			{
				phonetextbox.Text = value;
			}
		}

		
		public string address
		{
			set
			{
				addresstextbox.Text = value;
			}
		}
		public string email
		{
			set
			{
				emailtextbox.Text = value;
			}
		}
		public string age
		{
			set
			{
				agetextbox.Text = value;
			}
		}
		public string status
		{
			set
			{
				Status.Text = value;
			}
		}
		public string notes
		{
			set
			{
				Notes.Text = value;
			}
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void CIDtextbox_KeyUp(object sender, KeyEventArgs e)
		{
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			if (e.KeyCode == Keys.Enter)
			{
				int i = Convert.ToInt32(CIDtextbox.Text);
				var q = from x in context.Customers where x.CustomerID==i select x;
				Customers c = q.First();
				CustNameTextbox.Text = c.CustomerName;
				phonetextbox.Text = c.PhoneNumber;
				addresstextbox.Text = c.CustomerAddress;
				emailtextbox.Text = c.Email;
				agetextbox.Text = Convert.ToString(c.Age);
				if ((bool)c.Status)//nullable boolean so explicit conversion is required
				Status.Text ="Active";
				else
			    Status.Text = "InActive";
				Notes.Text = c.Notes;


			}

		}

		private void cidsearch_Click(object sender, EventArgs e)
		{
			Customer_Search_Screen form1 = new Customer_Search_Screen();
			form1.ShowDialog();
		}

		private void Refreshbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			MaintenanceForm f1 = new MaintenanceForm();
			f1.Show();
		}

		private void createbutton_Click(object sender, EventArgs e)
		{
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			Customers c = new Customers();
			{
				var q = from x in context.Customers orderby x.CustomerID descending select x;
				Customers c1 = q.First();
				//c.CustomerID = c1.CustomerID + 1;
				c.CustomerName = CustNameTextbox.Text;
				c.PhoneNumber = phonetextbox.Text;
				c.CustomerAddress = addresstextbox.Text;
				c.Email = emailtextbox.Text;
				c.Age = Convert.ToInt32(agetextbox.Text);
				if (c.Age >= 55)
					c.MemberCategory = "A";
				else if (c.Age >= 40 && c.Age < 55)
					c.MemberCategory = "B";
				else if (c.Age >= 30 && c.Age < 40)
					c.MemberCategory = "C";
				else
					c.MemberCategory = "D";

				if (Status.Text == "Active")
					c.Status = Convert.ToBoolean(1);
				else
					c.Status = Convert.ToBoolean(0);
				c.Notes = Notes.Text;		

			}
			context.Customers.Add(c);
			context.SaveChanges();
			var q1 = from x in context.Customers where x.CustomerName == CustNameTextbox.Text select x;
			Customers c2 = q1.First();
			string id = Convert.ToString(c2.CustomerID);
			MessageBox.Show("Customer created Successfully. Id is " + id);

		}

		private void updatebutton_Click(object sender, EventArgs e)
		{
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			int s = Convert.ToInt32(CIDtextbox.Text);
			var q = from x in context.Customers where x.CustomerID == s select x;
			Customers c = q.First();
			{
				c.CustomerName = CustNameTextbox.Text;
				c.PhoneNumber = phonetextbox.Text;
				c.CustomerAddress = addresstextbox.Text;
				c.Email = emailtextbox.Text;
				c.Age = Convert.ToInt32(agetextbox.Text);
				if (c.Age >= 55)
					c.MemberCategory = "A";
				else if (c.Age >= 40 && c.Age < 55)
					c.MemberCategory = "B";
				else if (c.Age >= 30 && c.Age < 40)
					c.MemberCategory = "C";
				else
					c.MemberCategory = "D";
				if (Status.Text == "Active")
					c.Status = Convert.ToBoolean(1);
				else
					c.Status = Convert.ToBoolean(0);
				c.Notes = Notes.Text;

			}
			context.SaveChanges();
			MessageBox.Show("Update successful");
		}

		private void Bookbutton_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(CIDtextbox.Text);
			BookingForm b = new BookingForm(id);
            b.Location = this.Location;
            b.StartPosition = FormStartPosition.Manual;
            b.FormClosing += delegate { this.Show(); };
            b.Show();
            this.Hide();
		}
	}
}
