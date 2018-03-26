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
    public partial class MainForm : Form
    {

        SportsFacilitiesEntities context = new SportsFacilitiesEntities();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_BookingButton_Click(object sender, EventArgs e)
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Location = this.Location;
            bookingForm.StartPosition = FormStartPosition.Manual;
            bookingForm.FormClosing += delegate { this.Show();};
            bookingForm.Show();
            this.Hide();
        }

        private void Main_MaintenanceButton_Click(object sender, EventArgs e)
        {
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.Location = this.Location;
            maintenanceForm.StartPosition = FormStartPosition.Manual;
            maintenanceForm.FormClosing += delegate { this.Show();};
            maintenanceForm.Show();
            this.Hide();
        }

        private void Main_ReportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Location = this.Location;
            reportForm.StartPosition = FormStartPosition.Manual;
            reportForm.FormClosing += delegate { this.Show();};
            reportForm.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void resetAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {

		}

		private void resetAvailabilityToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			MaintenanceForm c = new MaintenanceForm();
			c.Show();
		}

		private void venueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Venue_Maintenance_Screen v = new Venue_Maintenance_Screen();
			v.Show();
		}

		private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Managebookings mb = new Managebookings();
			mb.ShowDialog();
		}

		private void createToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			BookingForm b = new BookingForm();
			b.Show();
		}

		private void managebookingsbutton_Click(object sender, EventArgs e)
		{
			Managebookings mb = new Managebookings();
			mb.ShowDialog();
		}
	}
}
