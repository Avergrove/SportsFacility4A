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
    public partial class ReportForm : Form
    {

        Sportsfacilities sf;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void DisplayResults()
        {
        
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.Dock = DockStyle.Fill;
        }

        private void memberListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf = new Sportsfacilities();
            SportsfacilitiesTableAdapters.CustomersTableAdapter ta = new SportsfacilitiesTableAdapters.CustomersTableAdapter();
            ta.Fill(sf.Customers);


            SFCustomer cr = new SFCustomer();
            cr.SetDataSource(sf);
            crystalReportViewer1.ReportSource = cr;
            DisplayResults();


        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sf = new Sportsfacilities();
            SportsfacilitiesTableAdapters.ReportbookingtxnTableAdapter ta = new SportsfacilitiesTableAdapters.ReportbookingtxnTableAdapter();
            ta.Fill(sf.Reportbookingtxn);

            sfbkreport cr = new sfbkreport();
            cr.SetDataSource(sf);
            crystalReportViewer1.ReportSource = cr;
            DisplayResults();

        }

        private void demograhpicTrendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf = new Sportsfacilities();
            SportsfacilitiesTableAdapters.TrendchartTableAdapter ta = new SportsfacilitiesTableAdapters.TrendchartTableAdapter();
            ta.Fill(sf.Trendchart);

            demographic cr = new demographic();
            cr.SetDataSource(sf);
            crystalReportViewer1.ReportSource = cr;
            DisplayResults();


        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

            this.ClientSize = new System.Drawing.Size(1000, 1000);

        }
    }
}
