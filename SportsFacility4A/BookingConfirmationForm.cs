using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Code Written by Chua Khiong Yang
// Windows Form Script for the confirmation form
namespace SportsFacility4A
{
    public partial class BookingConfirmationForm : Form
    {

        SportsFacilitiesEntities context;

        int customerId;
        int venueID;
        String timeslot;
        DateTime bookedDate;
        String remark;
    

        // Default constructor for Booking Confirmation form
        public BookingConfirmationForm()
        {

            InitializeComponent();
        }
        
        // True constructor for Booking Confirmation Form
        public BookingConfirmationForm(int venueId, int customerId, String timeslot, DateTime d, String remark) : this()
        {
            this.venueID = venueId;
            this.customerId = customerId;
            this.timeslot = timeslot;
            this.bookedDate = d;
            this.remark = remark;

            ReloadForm();
            
        }


        // Utility: Reloads the form with relevant data
        private void ReloadForm()
        {
            context = new SportsFacilitiesEntities();

            // Show Booking Information
            var venueQuery = from x in context.Venue where x.VenueID == venueID select x;
            Venue v = venueQuery.First();
            
            if (v != null)
            {
                CategoryLabel.Text = v.Category;
                NameLabel.Text = v.VenueName;
                AddressLabel.Text = v.VenueAddress;
                TimeSlotLabel.Text = this.timeslot;
                DateLabel.Text = this.bookedDate.ToString("dd/MM/yyyy");
                RemarkLabel.Text = remark;
            }

            // Show Customer information
            Console.WriteLine(customerId);
            var customerQuery = from x in context.Customers where x.CustomerID == customerId select x;
            Customers c = customerQuery.First();

            if (c != null)
            {
                CustomerIdLabel.Text = c.CustomerID.ToString();
                CustomerNameLabel.Text = c.CustomerName;
                CustomerPhoneNumberLabel.Text = c.PhoneNumber;
                CustomerAddressLabel.Text = c.CustomerAddress;
                CustomerEmailLabel.Text = c.Email;
                CustomerAgeLabel.Text = c.Age.ToString();
                CustomerNotesLabel.Text = c.Notes;
                CustomerMemberCategoryLabel.Text = c.MemberCategory;
            }
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            BookingCompleteDialog bookingCompleteDialog = new BookingCompleteDialog();
            bookingCompleteDialog.Location = this.Location;
            bookingCompleteDialog.FormClosing += delegate {
                ConfirmButton.Enabled = false;
                this.toolStripStatusLabel.Text = "Booking has been completed!";
                ConfirmationLabel.Visible = true;
            };

            try
            {

                // Build a new Booking transaction object to insert into
                BookingTransaction newBookingTransaction = new BookingTransaction()
                {
                    CustomerID = this.customerId,
                    VenueID = this.venueID,
                    DateCreated = DateTime.Now,
                    BookedDate = bookedDate,
                    BookedHour = timeslot,
                    Status = "Confirmed",
                    Remark = remark
                    
                };
                context.BookingTransaction.Add(newBookingTransaction);
                context.SaveChanges();

                context = new SportsFacilitiesEntities();

                // Update the availability table to show that the timeslot is occupied
                var query = from x in context.Availability where venueID == x.VenueID select x;
                Availability availability = query.First();

                switch (timeslot)
                {
                    case "9am":
                        availability.C9am = true;
                        break;

                    case "10am":
                        availability.C10am = true;
                        break;

                    case "11am":
                        availability.C11am = true;
                        break;

                    case "12pm":
                        availability.C12pm = true;
                        break;

                    case "1pm":
                        availability.C1pm = true;
                        break;

                    case "2pm":
                        availability.C2pm = true;
                        break;

                    case "3pm":
                        availability.C3pm = true;
                        break;

                    case "4pm":
                        availability.C4pm = true;
                        break;

                    case "5pm":
                        availability.C5pm = true;
                        break;
                }
            }

            catch(Exception ex)
            {
                toolStripStatusLabel.Text = ex.ToString();
                Console.WriteLine("\n\n" + ex.ToString());
            }

            context.SaveChanges();
            bookingCompleteDialog.ShowDialog();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        // Utility: Gets the column index of a timeslot, and return it's index on the column
        private int GetAvailabilityColumnIndex(String s)
        {
            switch (s)
            {
                case "9am":
                    return 1;

                case "10am":
                    return 2;

                case "11am":
                    return 3;

                case "12pm":
                    return 4;

                case "1pm":
                    return 5;

                case "2pm":
                    return 6;

                case "3pm":
                    return 7;

                case "4pm":
                    return 8;

                case "5pm":
                    return 9;

                default:
                    return -1;

            }
        }


    }
}
