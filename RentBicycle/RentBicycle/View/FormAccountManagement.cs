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
    public partial class FormAccountManagement : Form
    {
        public FormAccountManagement()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rentBicycleDataSet);

        }

        private void FormAccountManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentBicycleDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.rentBicycleDataSet.Users);
            // TODO: This line of code loads data into the 'rentBicycleDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.rentBicycleDataSet.Users);

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Save", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.rentBicycleDataSet);
            }
        }

    }
}
