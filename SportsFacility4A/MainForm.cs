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
            ReportGenerationForm reportGenerationForm = new ReportGenerationForm();
            reportGenerationForm.Location = this.Location;
            reportGenerationForm.StartPosition = FormStartPosition.Manual;
            reportGenerationForm.FormClosing += delegate { this.Show(); this.Close(); };
            reportGenerationForm.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }
    }
}
