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
            bookingForm.FormClosing += delegate { this.Show(); this.Close(); };
            bookingForm.Show();
            this.Hide();
        }

        private void Main_MaintenanceButton_Click(object sender, EventArgs e)
        {
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.Location = this.Location;
            maintenanceForm.StartPosition = FormStartPosition.Manual;
            maintenanceForm.FormClosing += delegate { this.Show(); this.Close(); };
            maintenanceForm.Show();
            this.Hide();
        }

        private void Main_ReportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Location = this.Location;
            reportForm.StartPosition = FormStartPosition.Manual;
            reportForm.FormClosing += delegate { this.Show(); this.Close(); };
            reportForm.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void resetAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var AvailabilityQuery = from x in context.Availability select x;
            var availabilities = AvailabilityQuery.ToList<Availability>();

            foreach(Availability a in availabilities)
            {
                a.C9am = false;
                a.C10am = false;
                a.C11am = false;
                a.C12pm = false;
                a.C1pm = false;
                a.C2pm = false;
                a.C3pm = false;
                a.C4pm = false;
                a.C5pm = false;
            }
        }
    }
}
