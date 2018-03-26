using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//By Hoon Li Wen Esther | Student ID: A0180504N
namespace SportsFacility4A
{
    public delegate void DataStringHandler(string facility, string venuename, string timeslot, string custname, string bookingid);
    public partial class BookingList : Form
    {
        SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();

        public event DataStringHandler DataSent;
        string facility, venuename, timeslot, custname, bookingid;
        public BookingList()
        {
            InitializeComponent();
        }

        private void BookingsList_Load(object sender, EventArgs e)
        {
            bookinglistselCB.Text = "Confirmed";
            SearchBox.Text = "[Enter Customer Name...]";
            RetrieveGrid();
        }
        //Retrieve grid based on selection in combobox
        private void RetrieveGrid()
        {
            var q = from x in ctx.BookingTransaction
                    where x.BookedDate > DateTime.Today.Date
                    select new
                    { x.Customers.CustomerName, x.Venue.Category, x.Venue.VenueName, x.DateCreated, x.BookedDate, x.BookedHour, x.Status, x.BookingID, x.Remark,};
            
            if (bookinglistselCB.Text == "Confirmed" || bookinglistselCB.SelectedItem.ToString() == "Confirmed")
            {
                bkinglistGridView.DataSource = q.Where(x => x.Status == "Confirmed").ToList();
                mb_updatebtn.Visible = true;
                mb_okbtn.Visible = true;
            }
            else if (bookinglistselCB.Text == "Cancelled" || bookinglistselCB.SelectedItem.ToString() == "Cancelled")
            {
                bkinglistGridView.DataSource = q.Where(x => x.Status == "Cancelled").ToList();
                mb_updatebtn.Visible = false;
                mb_okbtn.Visible = false;
            }
            bkinglistGridView.ClearSelection();

            //change header names and fix width
            for (int i=1; i < bkinglistGridView.ColumnCount; i++)
            {
                bkinglistGridView.Columns[i].Width = 70;
            }
            bkinglistGridView.Columns[0].HeaderText = "Customer Name";
            bkinglistGridView.Columns[2].HeaderText = "Venue";
            bkinglistGridView.Columns[0].Width = 150;
            bkinglistGridView.Columns[2].Width = 150;
            bkinglistGridView.Columns[8].Width = 150;
        }


        //retrieve booking info when select button is clicked
        private void mb_okbtn_Click(object sender, EventArgs e)
        {
            if (bkinglistGridView.SelectedRows.Count > 0)
            {
                DataSent(facility, venuename, timeslot, custname, bookingid);
                Close();
            }
        }


        private void bookinglistselCB_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchBox.Text = "[Enter Customer Name...]";
            RetrieveGrid();
        }

        private void mb_updatebtn_Click(object sender, EventArgs e)
        {
            if (bkinglistGridView.SelectedRows.Count > 0)
            {
                //RetrieveData();
                mb_timeslotform availability = new mb_timeslotform();
                availability.selectedvenuename = venuename;
                availability.oldtimeslot = timeslot;
                availability.oldcategory = facility;
                availability.BookingID = bookingid;
                availability.ShowDialog();
            }
        }

        private void Reloadbtn_Click(object sender, EventArgs e)
        {
            RetrieveGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(bookinglistselCB.Text.ToLower().Trim()=="cancelled"|| bookinglistselCB.Text.ToLower().Trim() == "confirmed")
            {
                var q = from x in ctx.BookingTransaction
                        where x.BookedDate > DateTime.Today.Date && (x.Status == bookinglistselCB.SelectedItem.ToString() || x.Status == bookinglistselCB.Text.Trim())
                        select new
                        { x.Customers.CustomerName, x.Venue.Category, x.Venue.VenueName, x.DateCreated, x.BookedDate, x.BookedHour, x.Status, x.BookingID, x.Remark, };

                bkinglistGridView.DataSource = q.Where(x => x.CustomerName.Contains(SearchBox.Text)).ToList();
            }
        }

        private void SearchBox_MouseClick(object sender, MouseEventArgs e)
        {
            SearchBox.Clear();
        }

        private void bkinglistGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bkinglistGridView.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            bkinglistGridView.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            RetrieveData();
            DataSent(facility, venuename, timeslot, custname,bookingid);
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
                custname = bkinglistGridView.CurrentRow.Cells[0].Value.ToString();
                timeslot = bkinglistGridView.CurrentRow.Cells[5].Value.ToString();
                bookingid = bkinglistGridView.CurrentRow.Cells[7].Value.ToString();
        }

        private void bkinglistGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RetrieveData();
        }
    }
}
