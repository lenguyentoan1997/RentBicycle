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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentBicycleDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.rentBicycleDataSet.Customers);
            // TODO: This line of code loads data into the 'rentBicycleDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.rentBicycleDataSet.Customers);

        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Save","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.rentBicycleDataSet);
            }
        }

    }
}
