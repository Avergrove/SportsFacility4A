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
            GenerateBookingForm();
        }

        private void Main_MaintenanceButton_Click(object sender, EventArgs e)
        {
            GenerateCustomerMaintenanceForm();
        }

        private void Main_ReportButton_Click(object sender, EventArgs e)
        {
            GenerateReportForm();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }


		private void resetAvailabilityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GenerateCustomerMaintenanceForm();
        }

		private void venueToolStripMenuItem_Click(object sender, EventArgs e)
		{
            GenerateVenueMaintenanceForm();
		}

		private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenerateBookingMaintenanceForm();
        }

		private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenerateBookingForm();
        }

		private void managebookingsbutton_Click(object sender, EventArgs e)
		{
            GenerateBookingMaintenanceForm();
		}

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GenerateFAQForm();
        }

        // Utility: Displays a Booking Form
        private void GenerateBookingForm()
        {
            BookingForm bookingForm = new BookingForm();
            bookingForm.Location = this.Location;
            bookingForm.StartPosition = FormStartPosition.Manual;
            bookingForm.FormClosing += delegate { this.Show(); };
            bookingForm.Show();
            this.Hide();
        }

        // Utility: Displays a Customer Maintenance Form
        private void GenerateCustomerMaintenanceForm()
        {
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.Location = this.Location;
            maintenanceForm.StartPosition = FormStartPosition.Manual;
            maintenanceForm.FormClosing += delegate { this.Show(); };
            maintenanceForm.Show();
            this.Hide();
        }

        // Utility: Displays a Venue Maintenance Form
        private void GenerateVenueMaintenanceForm()
        {
            Venue_Maintenance_Screen venueMaintenanceScreen = new Venue_Maintenance_Screen();
            venueMaintenanceScreen.Location = this.Location;
            venueMaintenanceScreen.StartPosition = FormStartPosition.Manual;
            venueMaintenanceScreen.FormClosing += delegate { this.Show(); };
            venueMaintenanceScreen.Show();
            this.Hide();
        }

        // Utility: Displays a Booking Maintenance Form
        private void GenerateBookingMaintenanceForm()
        {
            Managebookings manageBookings = new Managebookings();
            manageBookings.Location = this.Location;
            manageBookings.StartPosition = FormStartPosition.Manual;
            manageBookings.FormClosing += delegate { this.Show(); };
            manageBookings.Show();
            this.Hide();

        }


        // Utility: Displays a Report Form
        private void GenerateReportForm()
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Location = this.Location;
            reportForm.StartPosition = FormStartPosition.Manual;
            reportForm.FormClosing += delegate { this.Show(); };
            reportForm.Show();
            this.Hide();

        }


        // Utility: Displays a Help page.
        private void GenerateFAQForm()
        {
            FAQForm faqForm = new FAQForm();
            faqForm.Location = this.Location;
            faqForm.StartPosition = FormStartPosition.Manual;
            faqForm.FormClosing += delegate { this.Show(); };
            faqForm.Show();
            this.Hide();
        }


    }
}
