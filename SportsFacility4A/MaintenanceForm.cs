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
        }

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void CIDtextbox_KeyDown(object sender, KeyEventArgs e)
		{
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			
			if (e.KeyCode == Keys.Enter)
			{
				int i = Int32.Parse(CIDtextbox.Text);
				var q = from x in context.Customers where x.CustomerID == i select x;
				Customers c = q.First();
				CustName.Text = c.CustomerName;
				Phone.Text = c.PhoneNumber;
				Address.Text = c.CustomerAddress;
				Email.Text = c.Email;
				Age.Text = Convert.ToString(c.Age);
				Status.Text = Convert.ToBoolean(c.Status) ? "Active" : "InActive";
				Notes.Text = c.Notes;
			}

		}

		private void CIDtextbox_TextChanged(object sender, EventArgs e)
		{

		}
	}

}
