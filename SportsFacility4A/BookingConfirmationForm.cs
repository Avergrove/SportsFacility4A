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
    public partial class BookingConfirmationForm : Form
    {
        public BookingConfirmationForm()
        {
            InitializeComponent();
        }

        public BookingConfirmationForm(String category, String name, String address, String timeslot, DateTime d): this()
        {
            CategoryTextBox.Text = category;
            NameTextBox.Text = name;
            AddressTextBox.Text = address;
            TimeSlotTextBox.Text = timeslot;
            DateTextBox.Text = d.ToString("dd/mm/yyyy");
        }

    }
}
