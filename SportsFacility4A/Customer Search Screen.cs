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
	public partial class Customer_Search_Screen : Form
	{
		public Customer_Search_Screen()
		{
			InitializeComponent();
		}

		private void Customer_Search_Screen_Load(object sender, EventArgs e)
		{
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			var q = from x in context.Customers select new { x.CustomerID, x.CustomerName, x.PhoneNumber, x.CustomerAddress, x.Email, x.Age, x.Status};
			Custdatagrid.DataSource = q.ToList();
		}

		private void cancelbutton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Custdatagrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{



		}

		private void okbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Application.OpenForms["MaintenanceForm"].Show();

		}

		private void searchbutton_Click(object sender, EventArgs e)
		{
			string s = searchtextbox.Text;
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			var q = from x in context.Customers where x.CustomerName.Substring(0, s.Length) == s select new { x.CustomerID, x.CustomerName, x.PhoneNumber, x.CustomerAddress, x.Email, x.Age, x.Status };
			Custdatagrid.DataSource = q.ToList();
		}

		private void Custdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dg = (DataGridView)sender;
			DataGridViewRow row = dg.SelectedRows[0];
			Form f = Application.OpenForms["MaintenanceForm"];
			MaintenanceForm f1 = (MaintenanceForm)f;
			f1.custid = row.Cells[0].Value.ToString();
			f1.custname = row.Cells[1].Value.ToString();
			f1.phonenumber = row.Cells[2].Value.ToString();
			f1.address = row.Cells[3].Value.ToString();
			f1.email = row.Cells[4].Value.ToString();
			f1.age = row.Cells[5].Value.ToString();
			if ((bool)row.Cells[6].Value)
				f1.status = "Active";
			else
				f1.status = "InActive";

		}
	}
}
