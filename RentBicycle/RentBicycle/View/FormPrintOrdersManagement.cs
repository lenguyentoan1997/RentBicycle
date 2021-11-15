using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentBicycle.View
{
    public partial class FormPrintOrdersManagement : Form
    {
        public FormPrintOrdersManagement()
        {
            InitializeComponent();
        }

        private void FormPrintOrdersManagement_Load(object sender, EventArgs e)
        {
            this.crystalReportBillManagement1.SetDatabaseLogon("group1", "group1", "DESKTOP-FBQCESN", "RentBicycle");

            crystalReportViewer1.ReportSource = crystalReportBillManagement1;
        }
    }
}
