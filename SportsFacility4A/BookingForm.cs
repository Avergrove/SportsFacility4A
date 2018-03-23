﻿using System;
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
    public partial class BookingForm : Form
    {

        SportsFacilitiesEntities context;

        public BookingForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            context = new SportsFacilitiesEntities();
            var query = from x in context.Availability select x;
            var dataset = query.ToList<Availability>();

            searchDataGrid.DataSource = dataset;
        }

        private void ActivityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
