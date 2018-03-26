using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

//By Hoon Li Wen Esther | Student ID: A0180504N
namespace SportsFacility4A
{
    public partial class Managebookings : Form
    {

        SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
        private List<BookingTransaction> confirmedbookings { get; set; }
        private List<BookingTransaction> confirmedtimeslots { get; set; }
        private string BookingID { get; set; }
        public Managebookings()
        {
            InitializeComponent();
        }

        private void Managebookings_Load(object sender, EventArgs e)
        {
            List<string> cat = ctx.Venue.Select(x => x.Category).Distinct().ToList();
            foreach(string category in cat)
            {
                FacilityCB.Items.Add(category);
            }
            toolStripStatusLabel1.Text = "...";
        }
        //Venue Combobox display all venues that have bookings
        private void FacilityCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "...";
            VenueCB.Items.Clear();
            VenueCB.Text = "";
            TimeSlotCB.Items.Clear();
            TimeSlotCB.Text = "";
            CustNameTextBox.Text = "";
            confirmedbookings = ctx.BookingTransaction.Where(x => x.BookedDate > DateTime.Today.Date && x.Status == "Confirmed" && x.Venue.Category == FacilityCB.SelectedItem.ToString()).OrderBy(x=>x.Venue.VenueName).ToList();
            List<string> venues = confirmedbookings.Select(x => x.Venue.VenueName).Distinct().ToList();
            foreach (string venue in venues)
            {
                VenueCB.Items.Add(venue);
            }

        }
        //Timeslot ComboBox display all timings that have been booked.
        //Note: Time in combobox not sorted.
        private void VenueCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TimeSlotCB.Items.Clear();
            confirmedtimeslots = confirmedbookings.Where(x=>x.Venue.VenueName.Trim()==VenueCB.SelectedItem.ToString().Trim()).ToList();
            List<string> bookedhours = confirmedtimeslots.Select(x => x.BookedHour).Distinct().ToList();
            foreach(string bookedhour in bookedhours)
            {
                TimeSlotCB.Items.Add(bookedhour);
            }

        }

        //Display customer name in custname TextBox.
        private void TimeSlotCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BookingTransaction selectedbooking = confirmedtimeslots.Where(x => x.BookedHour == TimeSlotCB.SelectedItem.ToString()).First();
            CustNameTextBox.Text = selectedbooking.Customers.CustomerName;
            BookingID = selectedbooking.BookingID.ToString();
        }
        //Click button to view and select booking from list of bookings.
        private void cidsearch_Click(object sender, EventArgs e)
        {
            BookingList bklist = new BookingList();
            bklist.DataSent += Bklist_DataSent1; ;
            bklist.ShowDialog();
        }

        private void Bklist_DataSent1(string facility, string venuename, string timeslot, string custname, string bookingid)
        {
            FacilityCB.Text = facility;
            VenueCB.Text = venuename;
            TimeSlotCB.Text = timeslot;
            CustNameTextBox.Text = custname;
            BookingID = bookingid;
        }

        private void cancelbookingbtn_Click(object sender, EventArgs e)
        {
            if (BookingID != null)
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    BookingTransaction selectedbooking = ctx.BookingTransaction.Where(x => x.BookingID.ToString().Trim() == BookingID.Trim()).First();
                    string bookedhour = selectedbooking.BookedHour;
                    selectedbooking.Status = "Cancelled";
                    if (Remarkstextbox.Text.Trim().Count() > 0)
                    {
                        selectedbooking.Remark = Remarkstextbox.Text;
                    }
                    var q3 = ctx.Availability.Where(x => x.VenueID == selectedbooking.VenueID).First();
                    switch (bookedhour)
                    {
                        case "9am":
                            q3.C9am = false;
                            break;
                        case "10am":
                            q3.C10am = false;
                            break;
                        case "11am":
                            q3.C11am = false;
                            break;
                        case "12pm":
                            q3.C12pm = false;
                            break;
                        case "1pm":
                            q3.C1pm = false;
                            break;
                        case "2pm":
                            q3.C2pm = false;
                            break;
                        case "3pm":
                            q3.C3pm = false;
                            break;
                        case "4pm":
                            q3.C4pm = false;
                            break;
                        case "5pm":
                            q3.C5pm = false;
                            break;
                    }
                    ctx.SaveChanges();
                    FacilityCB.Text = "";
                    VenueCB.Items.Clear();
                    VenueCB.Text = "";
                    TimeSlotCB.Items.Clear();
                    TimeSlotCB.Text = "";
                    CustNameTextBox.Text = "";
                    Transaction.Current.TransactionCompleted += new TransactionCompletedEventHandler(Current_TransactionCompleted); ;
                    ts.Complete();
                }
            }
        }

        private void Current_TransactionCompleted(object sender, TransactionEventArgs e)
        {
            if (e.Transaction.TransactionInformation.Status == TransactionStatus.Committed)
            {
                toolStripStatusLabel1.Text = "Update Completed...";
            }
            else if (e.Transaction.TransactionInformation.Status == TransactionStatus.Aborted)
            {
                toolStripStatusLabel1.Text = "Failed...";
            }
        }

        private void mbclosebtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }
    }
}
