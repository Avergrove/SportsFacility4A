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
    public partial class mb_timeslotform : Form
    {
        SportsFacilitiesEntities ctx = new SportsFacilitiesEntities();
        public string selectedvenuename { get; set; }
        public string oldtimeslot { get; set; }
        public string oldcategory { get; set; }
        public string BookingID { get; set; }
        string newtimeslot { get; set; }
        string newvenuename { get; set; }
        string newcategory { get; set; }
        public mb_timeslotform()
        {
            InitializeComponent();
        }

        private void updatebk_cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mb_availabilityform_Load(object sender, EventArgs e)
        {
            oldhourtb.Text = oldtimeslot;
            oldvenuetb.Text = selectedvenuename;
            oldcategorytb.Text = oldcategory;
            Categorycb.Text = "Current Booking";
            List<string> cat = ctx.Venue.Select(x => x.Category).Distinct().ToList();
            foreach (string category in cat)
            {
                Categorycb.Items.Add(category);
            }
            LoadGrid();
        }

        //Loadgrid based on Category ComboBox selection. Booked timeslots will be highlighted.
        private void LoadGrid()
        {
            if(Categorycb.Text=="Current Booking" || Categorycb.SelectedItem.ToString()=="Current Booking")
            {
                mb_availabilitygridview.DataSource = ctx.Availability.Where(x => x.Venue.VenueName == selectedvenuename).Select(x => new { x.Venue.VenueName, x.C9am, x.C10am, x.C11am, x.C12pm, x.C1pm, x.C2pm, x.C3pm, x.C4pm, x.C5pm, x.Venue.Category }).ToList();
            }
            else
            {
                mb_availabilitygridview.DataSource = ctx.Availability.Where(x => x.Venue.Category == Categorycb.Text || x.Venue.Category == Categorycb.SelectedItem.ToString()).Select(x => new { x.Venue.VenueName, x.C9am, x.C10am, x.C11am, x.C12pm, x.C1pm, x.C2pm, x.C3pm, x.C4pm, x.C5pm, x.Venue.Category }).ToList();
            }
            mb_availabilitygridview.DefaultCellStyle.SelectionForeColor = mb_availabilitygridview.DefaultCellStyle.ForeColor;
            mb_availabilitygridview.DefaultCellStyle.SelectionBackColor = mb_availabilitygridview.DefaultCellStyle.BackColor;
            for (int i = 0; i < mb_availabilitygridview.RowCount; i++)
            {
                if (mb_availabilitygridview.Rows[i].Cells[0].Value.ToString().Trim() == selectedvenuename.Trim())
                {
                    mb_availabilitygridview.Rows[i].Cells[0].Style.BackColor = System.Drawing.Color.LightBlue;
                    mb_availabilitygridview.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                    mb_availabilitygridview.Rows[i].Cells[10].Style.BackColor = System.Drawing.Color.LightBlue;
                }
            }
            for (int i = 0; i < mb_availabilitygridview.RowCount; i++)
            {
                for (int j = 1; j < mb_availabilitygridview.ColumnCount; j++)
                {
                    if (mb_availabilitygridview.Rows[i].Cells[j].Value is true)
                    {
                        mb_availabilitygridview.Rows[i].Cells[j].Style.ForeColor = mb_availabilitygridview.DefaultCellStyle.BackColor;
                        mb_availabilitygridview.Rows[i].Cells[j].Style.BackColor = mb_availabilitygridview.DefaultCellStyle.ForeColor;
                    }
                }
            }
            mb_availabilitygridview.Columns[0].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            mb_availabilitygridview.Columns[0].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            mb_availabilitygridview.Columns[10].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            mb_availabilitygridview.Columns[10].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
            mb_availabilitygridview.Columns[0].HeaderText = "Venue";
            mb_availabilitygridview.Columns[0].Width = 150;
            for (int i = 1; i < mb_availabilitygridview.ColumnCount; i++)
            {
                mb_availabilitygridview.Columns[i].Width = 70;
            }
        }
        //Retrieve new booking info
        private void RetrieveData()
        {
            newtimeslot = mb_availabilitygridview.CurrentCell.OwningColumn.HeaderText.Substring(1);
            newvenuename = mb_availabilitygridview.CurrentRow.Cells[0].Value.ToString();
            newcategory = mb_availabilitygridview.CurrentRow.Cells[10].Value.ToString();
        }
        private void ClearTextBoxes()
        {
            newhourtb.Text = "";
            newvenuetb.Text = "";
            newcategorytb.Text = "";
        }
        //Prevent occupied cells from being selected
        private void mb_availabilitygridview_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ClearTextBoxes();
            if (mb_availabilitygridview.CurrentCell.ColumnIndex == 0|| mb_availabilitygridview.CurrentCell.ColumnIndex==mb_availabilitygridview.ColumnCount-1)
            {
                mb_availabilitygridview.CurrentCell.Selected = false;
                newhourtb.Text = "";
            }
            else if (mb_availabilitygridview.CurrentCell.Value is true)
            {
                mb_availabilitygridview.CurrentCell.Selected = false;
            }else if(mb_availabilitygridview.CurrentCell.Value is false)
            {
                mb_availabilitygridview.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                mb_availabilitygridview.CurrentCell.Style.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                RetrieveData();
                newhourtb.Text = newtimeslot;
                newvenuetb.Text = newvenuename;
                newcategorytb.Text = newcategory;
            }
        }
        //update bookinginfo
        private void updatebk_okbtn_Click(object sender, EventArgs e)
        {
            if (mb_availabilitygridview.CurrentCell.Value is bool && mb_availabilitygridview.CurrentCell.OwningColumn.HeaderText.ToString().Substring(1) != oldtimeslot)
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    RetrieveData();
                    Availability updateslot = ctx.Availability.Where(x => x.Venue.VenueName == selectedvenuename).First();
                    switch (oldtimeslot)
                    {
                        case "9am":
                            updateslot.C9am = false;
                            break;
                        case "10am":
                            updateslot.C10am = false;
                            break;
                        case "11am":
                            updateslot.C11am = false;
                            break;
                        case "12pm":
                            updateslot.C12pm = false;
                            break;
                        case "1pm":
                            updateslot.C1pm = false;
                            break;
                        case "2pm":
                            updateslot.C2pm = false;
                            break;
                        case "3pm":
                            updateslot.C3pm = false;
                            break;
                        case "4pm":
                            updateslot.C4pm = false;
                            break;
                        case "5pm":
                            updateslot.C5pm = false;
                            break;
                    }
                    Availability newslot = ctx.Availability.Where(x => x.Venue.VenueName == newvenuename).First();
                    switch (newtimeslot)
                    {
                        case "9am":
                            newslot.C9am = true;
                            break;
                        case "10am":
                            newslot.C10am = true;
                            break;
                        case "11am":
                            newslot.C11am = true;
                            break;
                        case "12pm":
                            newslot.C12pm = true;
                            break;
                        case "1pm":
                            newslot.C1pm = true;
                            break;
                        case "2pm":
                            newslot.C2pm = true;
                            break;
                        case "3pm":
                            newslot.C3pm = true;
                            break;
                        case "4pm":
                            newslot.C4pm = true;
                            break;
                        case "5pm":
                            newslot.C5pm = true;
                            break;
                    }
                    BookingTransaction booking = ctx.BookingTransaction.Where(x => x.BookingID.ToString() == BookingID).First();
                    Venue v = ctx.Venue.Where(x => x.VenueName == newvenuename).First();
                    v.BookingTransaction.Add(booking);
                    booking.BookedHour = newtimeslot;
                    ctx.SaveChanges();
                    Transaction.Current.TransactionCompleted += new TransactionCompletedEventHandler(Current_TransactionCompleted);
                    ts.Complete();
                }
            }                
        }
        //If successful prompts messagebox
        private void Current_TransactionCompleted(object sender, TransactionEventArgs e)
        {
            if (e.Transaction.TransactionInformation.Status == TransactionStatus.Committed)
            {
                MessageBox.Show("Update Completed");
                Close();
            }
        }

        private void Categorycb_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            LoadGrid();
        }
        //Change displayed value for cells with bool values 
        private void mb_availabilitygridview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is bool)
            {
                bool value = (bool)e.Value;
                e.Value = (value) ? "" : "Available";
                e.FormattingApplied = true;
            }
        }
    }
}
