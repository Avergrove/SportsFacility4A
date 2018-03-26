using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Written by Chua Khiong Yang
// Code written for the main form, of the booking form, where you select venue and time slot

namespace SportsFacility4A
{
    public partial class BookingForm : Form
    {

        SportsFacilitiesEntities context;
        int customerId;


        const string BOOKING_OCCUPIED = "Occupied";
        const string BOOKING_FREE = "Available";
        

        /// <summary>
        /// Default constructor for booking form, used for testing purposes.
        /// </summary>
        public BookingForm()
        {
            this.customerId = new Random().Next(1, 50); // TODO: Get true customer information
            Console.WriteLine("Init Customer id: " + customerId);
            InitializeComponent();
        }

        public BookingForm(int customerId) : this()
        {
            this.customerId = customerId;
            CustomerIdLabel.Text = this.customerId.ToString();
            
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            context = new SportsFacilitiesEntities();
        }

        // Populates Activity combo box from database data, with sports categories.
        private void ActivityComboBox_DropDown(object sender, EventArgs e)
        {

           
            var query = from x in context.Venue select x;
            var dataset = query.ToList<Venue>();

            foreach (Venue v in dataset)
            {
                if (!ActivityComboBox.Items.Contains(v.Category))
                {
                    ActivityComboBox.Items.Add(v.Category);
                }
            }


        }

        // Populates Venue Combo Box with the name of the venue, on selection of a category.
        private void ActivityBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            String selectedActivity = ActivityComboBox.SelectedItem.ToString();

            var query = from x in context.Venue where x.Category == selectedActivity select x;
            var dataset = query.ToList<Venue>();

            VenueComboBox.Items.Clear();
            VenueComboBox.SelectedIndex = -1;
            foreach (Venue v in dataset)
            {

                if (!VenueComboBox.Items.Contains(v.VenueName))
                {
                    VenueComboBox.Items.Add(v.VenueName);
                }
                
            }

            StatusLabel.Text = "Please select a venue for your reservation.";
        }


        // Shows address of the venue, and populate the Datagrid with relevant time slots.
        private void VenueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            RefreshAvailabilityDataGrid();

            StatusLabel.Text = "Next, select a free timeslot from the list.";
        }

        // UTILITY: Refreshes the Avaialability datagrid.
        private void RefreshAvailabilityDataGrid()
        {
            // selectionbackcolor, back color
            context = new SportsFacilitiesEntities();

            if (VenueComboBox.SelectedIndex != -1)
            {
                var AddressQuery = from x in context.Venue where x.VenueName == VenueComboBox.SelectedItem.ToString() select x;
                AddressLabel.Text = AddressQuery.First<Venue>().VenueAddress;


                var AvailabilityQuery = from x in context.Availability
                                        join y in context.Venue
                                        on x.VenueID equals y.VenueID
                                        where y.VenueName == VenueComboBox.SelectedItem.ToString()
                                        select new
                                        {
                                            availabilities = x,
                                            venues = y
                                        };

                // Repopulate the table.
                AvailabilityDataGrid.Rows.Clear();

                var firstQ = AvailabilityQuery.First();
                AvailabilityDataGrid.Rows.Clear();
                foreach (var v in AvailabilityQuery)
                {
                    AvailabilityDataGrid.Rows.Add(v.venues.VenueName, this.AvailabilityBoolToString(v.availabilities.C9am), this.AvailabilityBoolToString(v.availabilities.C10am), this.AvailabilityBoolToString(v.availabilities.C11am), this.AvailabilityBoolToString(v.availabilities.C12pm), this.AvailabilityBoolToString(v.availabilities.C1pm), this.AvailabilityBoolToString(v.availabilities.C2pm), this.AvailabilityBoolToString(v.availabilities.C3pm), this.AvailabilityBoolToString(v.availabilities.C4pm), this.AvailabilityBoolToString(v.availabilities.C5pm));
                    foreach(DataGridViewRow r in AvailabilityDataGrid.Rows)
                    {
                        foreach(DataGridViewCell c in r.Cells)
                        {
                            if(c.Value.Equals(BOOKING_OCCUPIED))
                            {
                                c.Style = new DataGridViewCellStyle();
                                c.Style.SelectionBackColor = Color.Black;
                                c.Style.BackColor = Color.Black;
                            }
                        }
                    }
                }
            }
        }

        private void BookingButton_Click(object sender, EventArgs e)
        {
            var selection = AvailabilityDataGrid.SelectedCells;

            // Get information for selected venue
            var query = from x in context.Availability
                                    join y in context.Venue
                                    on x.VenueID equals y.VenueID
                                    where y.VenueName == VenueComboBox.SelectedItem.ToString()
                                    select new
                                    {
                                        availabilities = x,
                                        venues = y
                                    };

            var v = query.First();

            DateTime bookedTime = DateTime.Now;
            bookedTime = bookedTime.AddDays(1);


            // BookingConfirmationForm bookingConfirmationForm = new BookingConfirmationForm(v.venues.Category, v.venues.VenueName, v.venues.VenueAddress, GetTimeSlot(), DateTime.Now);
            BookingConfirmationForm bookingConfirmationForm = new BookingConfirmationForm(v.venues.VenueID, Int32.Parse(CustomerIdLabel.Text), GetTimeSlot(), bookedTime, RemarkTextBox.Text);
            bookingConfirmationForm.Location = this.Location;
            bookingConfirmationForm.StartPosition = FormStartPosition.Manual;
            bookingConfirmationForm.FormClosing += delegate { this.Show(); this.RefreshAvailabilityDataGrid();};
            bookingConfirmationForm.Show();
            this.Hide();



        }

        private void availabilityDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            var selection = AvailabilityDataGrid.CurrentCell;

            bool parseResult;

            try
            {
                Int32.Parse(CustomerIdLabel.Text);
                parseResult = true;
            }
            catch(Exception ex)
            {
                parseResult = false;
            }



            if (selection.ColumnIndex > 0 && !selection.Value.Equals(BOOKING_OCCUPIED) && parseResult)
            {
                BookingButton.Enabled = true;
                StatusLabel.Text = "Finally, Add a remark, or click \"Make a booking\"";
            }

            else
            {
                BookingButton.Enabled = false;
            }
        }



        // Utility: Converts bools into strings.
        private String AvailabilityBoolToString(bool? state)
        {
            if (state == false)
            {
                return BOOKING_FREE;
            }

            else
            {
                return BOOKING_OCCUPIED;
            }
        }

        // Utility: Converts strings into bools
        private Boolean AvailabilityStringToBool(String state)
        {
            if (state == BOOKING_OCCUPIED)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Utility: Gets the selected timeslot
        private String GetTimeSlot()
        {
            int column = AvailabilityDataGrid.CurrentCell.ColumnIndex;

            switch (column)
            {
                case 1:
                    return "9am";

                case 2:
                    return "10am";

                case 3:
                    return "11am";

                case 4:
                    return "12pm";

                case 5:
                    return "1pm";

                case 6:
                    return "2pm";

                case 7:
                    return "3pm";

                case 8:
                    return "4pm";

                case 9:
                    return "5pm";

                default:
                    break;
            }

            return "ERROR";

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AvailabilityQuery = from x in context.Availability select x;
            var availabilities = AvailabilityQuery.ToList<Availability>();

            foreach (Availability a in availabilities)
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

            context.SaveChanges();
            RefreshAvailabilityDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
