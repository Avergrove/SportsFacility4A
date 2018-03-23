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
    public partial class Managebookings : Form
    {

        SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
        private List<BookingTransaction> bktxn { get; set; } 
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
        }

        private void FacilityCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            VenueCB.Items.Clear();
            VenueCB.Text = "";
            TimeSlotCB.Items.Clear();
            TimeSlotCB.Text = "";
            CustNameTextBox.Text = "";
            List < string> venues = ctx.Venue.Where(x => x.Category.Trim() == FacilityCB.SelectedItem.ToString()).Select(x => x.VenueName).ToList();
            foreach(string venue in venues)
            {
                VenueCB.Items.Add(venue);
            }

        }

        private void VenueCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TimeSlotCB.Items.Clear();
            int venueid = ctx.Venue.Where(x => x.VenueName == VenueCB.SelectedItem.ToString()).Select(x => x.VenueID).First();
            bktxn = ctx.BookingTransaction.Where(x => x.BookedDate >= DateTime.Today && x.VenueID == venueid).ToList();
            foreach(BookingTransaction bookedhour in bktxn)
            {
                TimeSlotCB.Items.Add(bookedhour.BookedHour);
            }

        }


        private void TimeSlotCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string custid = bktxn.Where(x => x.BookedHour == TimeSlotCB.SelectedItem.ToString()).Select(x => x.CustomerID).First().ToString();
            CustNameTextBox.Text = ctx.Customers.Where(x => x.CustomerID.ToString().Trim() == custid.Trim()).Select(x => x.CustomerName).First().ToString();
        }

        private void cidsearch_Click(object sender, EventArgs e)
        {
            BookingList bklist = new BookingList();
            bklist.DataSent += Bklist_DataSent;
            bklist.ShowDialog();
        }

        private void Bklist_DataSent(string facility, string venuename, string timeslot, string custname)
        {
            FacilityCB.Text = facility;
            VenueCB.Text = venuename;
            TimeSlotCB.Text = timeslot;
            CustNameTextBox.Text = custname;
        }

        private void cancelbookingbtn_Click(object sender, EventArgs e)
        {
            var q1 = from x in ctx.BookingTransaction join y in ctx.Venue on x.VenueID equals y.VenueID
                    where x.BookedDate> DateTime.Today.Date
                    select new { x.BookingID, x.VenueID, y.VenueName, x.BookedHour };
            int bookingid = q1.Where(x => x.VenueName == VenueCB.Text && x.BookedHour == TimeSlotCB.Text).Select(x => x.BookingID).First();
            BookingTransaction b = ctx.BookingTransaction.Where(x => x.BookingID == bookingid).First();
            b.Status = "Cancelled";

        }
    }
}
