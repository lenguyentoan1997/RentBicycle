using RentBicycle.ViewModel;
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
    public partial class FormDashboard : Form
    {
        private DashboardViewModel _dashboardViewModel;
        public FormDashboard()
        {
            _dashboardViewModel = new DashboardViewModel();

            InitializeComponent();

            this.Load += delegate { _dashboardViewModel.Load(chartNumber,chartSalaryMonth); };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {    
            if(MessageBox.Show("Do You Want To Save", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.ordersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.rentBicycleDataSet);
            }        
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentBicycleDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.rentBicycleDataSet.Orders);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Wan To Print", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPrintOrdersManagement formPrintOrdersManagement = new FormPrintOrdersManagement();
                formPrintOrdersManagement.ShowDialog();
            }
        }
    }
}
