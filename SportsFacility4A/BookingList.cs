﻿using System;
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
            RetrieveGrid();
        }

        private void RetrieveGrid()
        {
            var q = from x in ctx.BookingTransaction
                    join y in ctx.Customers on x.CustomerID equals y.CustomerID
                    join z in ctx.Venue on x.VenueID equals z.VenueID
                    where x.BookedDate > DateTime.Today.Date
                    select new
                    { y.CustomerName, z.Category, z.VenueName, x.DateCreated, x.BookedDate, x.BookedHour, x.Status, x.BookingID, x.Remark,};
            
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
            bkinglistGridView.DefaultCellStyle.SelectionForeColor = bkinglistGridView.DefaultCellStyle.ForeColor;
            bkinglistGridView.DefaultCellStyle.SelectionBackColor = bkinglistGridView.DefaultCellStyle.BackColor;
            for(int i=1; i < bkinglistGridView.ColumnCount; i++)
            {
                bkinglistGridView.Columns[i].Width = 70;
            }
            bkinglistGridView.Columns[2].HeaderText = "Venue";
            bkinglistGridView.Columns[0].Width = 150;
            bkinglistGridView.Columns[2].Width = 150;
            bkinglistGridView.Columns[8].Width = 150;
        }



        private void mb_okbtn_Click(object sender, EventArgs e)
        {
            if (bkinglistGridView.RowCount > 0)
            {
                DataSent(facility, venuename, timeslot, custname, bookingid);
                Close();
            }
        }


        private void bookinglistselCB_SelectedValueChanged(object sender, EventArgs e)
        {
            RetrieveGrid();
        }

        private void mb_updatebtn_Click(object sender, EventArgs e)
        {
            if (bkinglistGridView.RowCount>0)
            {
                RetrieveData();
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
            if (bkinglistGridView.RowCount > 0)
            {
                facility = bkinglistGridView.CurrentRow.Cells[1].Value.ToString();
                venuename = bkinglistGridView.CurrentRow.Cells[2].Value.ToString();
                custname = bkinglistGridView.CurrentRow.Cells[0].Value.ToString();
                timeslot = bkinglistGridView.CurrentRow.Cells[5].Value.ToString();
                bookingid = bkinglistGridView.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void bkinglistGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bkinglistGridView.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            bkinglistGridView.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            RetrieveData();
        }
    }
}