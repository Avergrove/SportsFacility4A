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
	public partial class Venue_Maintenance_Screen : Form
	{
		public Venue_Maintenance_Screen()
		{
			InitializeComponent();
		}
		public string Venueid
		{
			set
			{
				venueidtextbox.Text = value;
			}
		}
		public string Venuename
		{
			set
			{
				venuenametextbox.Text = value;
			}
		}

		public string Venueaddress
		{
			set
			{
				venueaddresstextbox.Text = value;
			}
		}

		public string Category
		{
			set
			{
				categorytextbox.Text = value;
			}
		}


		private void Venue_Maintenance_Screen_Load(object sender, EventArgs e)
		{

		}

		private void venueidtextbox_KeyUp(object sender, KeyEventArgs e)
		{
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			if (e.KeyCode == Keys.Enter)
			{
				int id = Convert.ToInt32(venueidtextbox.Text);
				var q = from x in context.Venue where x.VenueID == id  select x;
				Venue c = q.First();
				venuenametextbox.Text = c.VenueName;
				venueidtextbox.Text = Convert.ToString(c.VenueID);
				venueaddresstextbox.Text = c.VenueAddress;
				categorytextbox.Text = c.Category;
			}


		}

		private void searchbutton_Click(object sender, EventArgs e)
		{
			Venue_Search_Screen f1 = new Venue_Search_Screen();
			f1.Show();
		}

		private void createbutton_Click(object sender, EventArgs e)
		{
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			var q = from x in context.Venue orderby x.VenueID descending select x;
			Venue v = q.First();
			Venue v1 = new Venue();
			{
				//v1.VenueID = v.VenueID + 1;
				v1.VenueName = venuenametextbox.Text;
				v1.VenueAddress = venueaddresstextbox.Text;
				v1.Category = categorytextbox.Text;
			}
			context.Venue.Add(v1);
			context.SaveChanges();
			var q1 = from x in context.Venue orderby x.VenueID descending select x;
			Venue v2 = q.First();
			int id = v2.VenueID;
			MessageBox.Show("Venue created Successfully. ID is " + id);
           }

		private void Refreshbutton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Venue_Maintenance_Screen v1 = new Venue_Maintenance_Screen();
			v1.Show();
		}

		private void updatebutton1_Click(object sender, EventArgs e)
		{
			SportsFacilitiesEntities context = new SportsFacilitiesEntities();
			int i = Convert.ToInt32(venueidtextbox.Text);
			var q = from x in context.Venue where x.VenueID == i select x;
			Venue v = q.First();
			{
				v.VenueName = venuenametextbox.Text;
				v.VenueAddress = venueaddresstextbox.Text;
				v.Category = categorytextbox.Text;
			}
			context.SaveChanges();
			MessageBox.Show("Update successful");
		}
	}
}
