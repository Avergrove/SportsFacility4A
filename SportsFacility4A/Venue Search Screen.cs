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
	public partial class Venue_Search_Screen : Form
	{
		public Venue_Search_Screen()
		{
			InitializeComponent();
		}

		private void Venue_Search_Screen_Load(object sender, EventArgs e)
		{
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			var q = from x in context.Venue select new { x.VenueID,x.VenueName,x.VenueAddress,x.Category};
			venuegrid.DataSource = q.ToList();
		}

		private void venuegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void venuegrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			

		}

		private void okvenuebutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form f = Application.OpenForms["Venue_Maintenance_Screen"];
			Venue_Maintenance_Screen f1 = (Venue_Maintenance_Screen)f;
			f1.Show();
		}

		private void cancelbutton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void searchvenuebutton_Click(object sender, EventArgs e)
		{
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			string s = searchvenuetextbox.Text;
			var q=from x in context.Venue where x.VenueName.Substring(0,s.Length)==s select new { x.VenueID, x.VenueName, x.VenueAddress, x.Category };
			venuegrid.DataSource = q.ToList();

		}

		private void venuegrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dg = (DataGridView)sender;
			DataGridViewRow row = dg.SelectedRows[0];
			Form f = Application.OpenForms["Venue_Maintenance_Screen"];
			Venue_Maintenance_Screen f1 = (Venue_Maintenance_Screen)f;
			f1.Venueid = row.Cells[0].Value.ToString();
			f1.Venuename = row.Cells[1].Value.ToString();
			f1.Venueaddress = row.Cells[2].Value.ToString();
			f1.Category = row.Cells[3].Value.ToString();

		}
	}
}
