using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using RentBicycle.Model;
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
    public partial class FormPrintBill : Form
    {

        private int _orderId;
        public FormPrintBill(int orderId)
        {
            InitializeComponent();

            _orderId = orderId;

        }

        private void FormPrintBill_Load(object sender, EventArgs e)
        {
            this.crystalReportBill1.SetDatabaseLogon("group1", "group1", "DESKTOP-FBQCESN", "RentBicycle");

            crystalReportBill.SelectionFormula = "{Orders.Id} = " + _orderId;
            crystalReportBill.ReportSource = crystalReportBill1;
            crystalReportBill.Refresh();
        }

        private void crystalReportBill1_InitReport(object sender, EventArgs e)
        {

        }
    }
}
