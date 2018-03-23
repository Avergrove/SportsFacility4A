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
    public delegate void DataStringHandler(string facility, string venuename, string timeslot, string custname);
    public partial class BookingList : Form
    {
        SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();

        public event DataStringHandler DataSent;
        string facility, venuename, timeslot, custname;
        public BookingList()
        {
            InitializeComponent();
        }

        private void BookingsList_Load(object sender, EventArgs e)
        {
            var q = from x in ctx.BookingTransaction
                    join y in ctx.Customers on x.CustomerID equals y.CustomerID
                    join z in ctx.Venue on x.VenueID equals z.VenueID
                    where x.BookedDate>DateTime.Today.Date
                    select new
                    { x.BookingID, z.Category,z.VenueName, y.CustomerName, x.DateCreated, x.BookedDate, x.BookedHour, x.Status, x.Remark };
            bkinglistGridView.DataSource = q.ToList();
        }

        private void mb_okbtn_Click(object sender, EventArgs e)
        {
            DataSent(facility, venuename, timeslot, custname);
            Close();
        }

        private void bkinglistGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RetrieveData();
            DataSent(facility, venuename, timeslot, custname);
            Close();
        }

        private void mb_cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void RetrieveData()
        {
            facility = bkinglistGridView.CurrentRow.Cells[1].Value.ToString();
            venuename = bkinglistGridView.CurrentRow.Cells[2].Value.ToString();
            custname = bkinglistGridView.CurrentRow.Cells[3].Value.ToString();
            timeslot = bkinglistGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void bkinglistGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RetrieveData();
        }
    }
}
