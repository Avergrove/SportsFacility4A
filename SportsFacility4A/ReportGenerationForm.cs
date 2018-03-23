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
    public partial class ReportGenerationForm : Form
    {

        Sportsfacilities sf= new Sportsfacilities();
        

        public ReportGenerationForm()
        {
            InitializeComponent();
        }

        private void ReportGenerationForm_Load(object sender, EventArgs e)
        {
            
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }


        private void Display()
        {
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.Dock = DockStyle.Fill;

        }

        private void memberListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //generate memberlist report//
            SportsfacilitiesTableAdapters.CustomersTableAdapter ta = new SportsfacilitiesTableAdapters.CustomersTableAdapter();
            ta.Fill(sf.Customers);

            SFCustomer cr = new SFCustomer() ;
            cr.SetDataSource(sf);
            crystalReportViewer1.ReportSource = cr;
            Display();
                       
        }

        private void managmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creating a new dataset created using query
            //select b.VenueID,b.BookedDate,b.BookedHour,b.CustomerID,b.Status,v.VenueName from BookingTransaction b, Venue v
            //where b.VenueID = v.VenueID
            //and b.Status in (select Status from BookingTransaction where Status = 'confirmed')//

            SportsfacilitiesTableAdapters.ReportbookingtxnTableAdapter ta = new SportsfacilitiesTableAdapters.ReportbookingtxnTableAdapter();
            ta.Fill(sf.Reportbookingtxn);
                       
            sfbkreport cr = new sfbkreport();
            cr.SetDataSource(sf);
            crystalReportViewer1.ReportSource = cr;
            Display();
            
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer2_Load_1(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trendChartToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //create a dataset using query
            //select b.CustomerID,c.MemberCategory,b.BookedDate,b.BookedHour from BookingTransaction b, Customers c
            //where b.CustomerID = c.CustomerID
            // and b.Status in (select Status from BookingTransaction where Status = 'confirmed')

            SportsfacilitiesTableAdapters.TrendchartTableAdapter ta = new SportsfacilitiesTableAdapters.TrendchartTableAdapter();
            ta.Fill(sf.Trendchart);

            trendreport cr = new trendreport();
            cr.SetDataSource(sf);
            crystalReportViewer1.ReportSource = cr;
            Display();
           
            
        }
    }
}
