using RentBicycle.ViewModel;
using System;
using System.Windows.Forms;
namespace RentBicycle.View

{
    public partial class FormProducts : Form
    {
        //Declare ProductViewModel
        private ProductViewModel _productViewModel;
        public FormProducts()
        {
            InitializeComponent();

            //initialization productViewModel
            _productViewModel = new ProductViewModel();
            //Data bidingsource at View will be transmitted by Data bidingsource ViewModel
            _productViewModel.ProductBidingSource = productBindingSource1;

            this.Load += delegate { _productViewModel.Load(); };
           
            btnOpenFile.Click += delegate { _productViewModel.OpenFile(picProduct,txtImgName); };

            btnAdd.Click += delegate { _productViewModel.Add(); };

            btnSave.Click += delegate { _productViewModel.Save(); };

            btnDelete.Click += delegate { _productViewModel.Delete(); };

            dataGridViewProducts.Click += delegate { _productViewModel.LoadImgProduct(txtImgName,picProduct); };
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            txtName.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            txtImgName.ReadOnly = true;

            btnOpenFile.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.ClearSelection();
            dataGridViewProducts.Enabled = false;


            txtName.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtQuantity.ReadOnly = false;
            btnDelete.Enabled = true;

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnOpenFile.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;

            picProduct.Image = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            txtName.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtQuantity.ReadOnly = false;
            btnDelete.Enabled = true;

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnOpenFile.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtQuantity.ReadOnly = false;
            btnDelete.Enabled = true;

            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnOpenFile.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtQuantity.ReadOnly = true;

            btnOpenFile.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Wan To Print", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormPrintProducts formPrintProduct = new FormPrintProducts();
                formPrintProduct.ShowDialog();
            }              
        }

    }
}
