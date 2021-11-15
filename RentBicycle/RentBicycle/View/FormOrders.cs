using DevExpress.Utils.Drawing.Helpers;
using RentBicycle.Model;
using RentBicycle.ViewModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentBicycle.View
{
    public partial class FormOrders : Form
    {
        private OrderViewModel _orderViewModel = new OrderViewModel();
        private OrdersDetail _ordersDetail;
        private Order _order;
        private Customer _customer;
        private int quantityByCellDataGrid = 0;

        public FormOrders()
        {
            InitializeComponent();

            //add value combobox
            cbbProductName.Items.AddRange(_orderViewModel.GetProductName(lblOrderId));

            cbbProductName.SelectedIndexChanged += delegate { _orderViewModel.GetProductInformation(cbbProductName, picProduct, lblProductId, lblQuantityStock, txtProductQuantity, txtRentHours, txtProductPrice); };
            txtProductQuantity.TextChanged += delegate { _orderViewModel.GetProductInformation(cbbProductName, picProduct, lblProductId, lblQuantityStock, txtProductQuantity, txtRentHours, txtProductPrice); };
            txtRentHours.TextChanged += delegate { _orderViewModel.GetProductInformation(cbbProductName, picProduct, lblProductId, lblQuantityStock, txtProductQuantity, txtRentHours, txtProductPrice); };

            btnAddProduct.Click += delegate
            {
                _orderViewModel.Add(dataGridViewOrder, _ordersDetail = new OrdersDetail()
                {
                    OrderId = Convert.ToInt32(lblOrderId.Text),
                    ProductId = Convert.ToInt32(lblProductId.Text),
                    Quantity = Convert.ToInt32(txtProductQuantity.Text),
                    Price = Convert.ToDecimal(txtProductPrice.Text),
                    RentHours = Convert.ToDecimal(txtRentHours.Text),
                    ProductName = cbbProductName.Text,
                }, lblTotal, lblQuantityStock);
            };


            btnEdit.Click += delegate
            {
                _orderViewModel.Edit(
                  dataGridViewOrder,
                  _ordersDetail = new OrdersDetail()
                  {
                      OrderId = Convert.ToInt32(lblOrderId.Text),
                      ProductId = Convert.ToInt32(lblProductId.Text),
                      Quantity = Convert.ToInt32(txtProductQuantity.Text),
                      Price = Convert.ToDecimal(txtProductPrice.Text),
                      RentHours = Convert.ToDecimal(txtRentHours.Text),
                      ProductName = cbbProductName.Text,
                  }, dataGridViewOrder.CurrentCell.RowIndex, quantityByCellDataGrid, lblQuantityStock);
            };


            btnPayment.Click += delegate
            {
                bool IsCheckPayment;
                IsCheckPayment = _orderViewModel.IsPayment(_order = new Order()
                {
                    CustomerIdentity = txtCusCtitizensIdentity.Text,
                    CustomerName = txtCustomerName.Text,
                    CustomerPhone = txtCustomerPhone.Text,
                    EmployeeId = Helper.InforAccountLogin.Id,
                    Date = DateTime.Now,
                    Total = 0,
                    Status = "renting"
                }, _customer = new Customer()
                {
                    CitizensIdentity = txtCusCtitizensIdentity.Text,
                    Name = txtCustomerName.Text,
                    Phone = txtCustomerPhone.Text,
                }, dataGridViewOrder, lblOrderId);

                if (IsCheckPayment)
                {
                    ClearAll();
                };
            };

        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentBicycleDataSet.OrdersDetail' table. You can move, or remove it, as needed.
            this.ordersDetailTableAdapter.Fill(this.rentBicycleDataSet.OrdersDetail);
            // TODO: This line of code loads data into the 'rentBicycleDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.rentBicycleDataSet.Orders);

            //border radius panel image
            IntPtr panelImgIntPtr = NativeMethods.CreateRoundRectRgn(0, 0, panelImg.Width, panelImg.Height, 40, 40);
            panelImg.Region = Region.FromHrgn(panelImgIntPtr);

            //Filter bindingsource 
            ordersBindingSource.Filter = "Status = 'renting'";
        }

        private void cbbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProductQuantity.Text = "0";
            txtRentHours.Text = "0";
        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewOrder.Rows[e.RowIndex];

                cbbProductName.Text = row.Cells[1].Value.ToString();
                txtProductQuantity.Text = row.Cells[2].Value.ToString();
                txtRentHours.Text = row.Cells[3].Value.ToString();
                txtProductPrice.Text = row.Cells[4].Value.ToString();

                quantityByCellDataGrid = Convert.ToInt32(row.Cells[2].Value);

            }
            catch { }
        }

        private void dataGridViewOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e) => _orderViewModel.CellEndEdit(dataGridViewOrder, e, lblQuantityStock);

        private void dataGridViewOrder_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) => _orderViewModel.CellBeginEdit(dataGridViewOrder, e, lblQuantityStock);

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrder.Columns[e.ColumnIndex].Name == "Delete")
            {
                _orderViewModel.Delete(dataGridViewOrder, e.RowIndex, lblQuantityStock);
            }
        }

        private void ClearAll()
        {
            foreach (Control control1 in groupBox1.Controls)
            {
                if (control1 is DevExpress.XtraEditors.TextEdit)
                {
                    control1.Text = string.Empty;
                }
            }

            foreach (Control control2 in groupBox2.Controls)
            {
                if (control2 is TextBox)
                {
                    control2.Text = string.Empty;
                }
            }
            lblTotal.Text = "0";
        }

        private void dgvTab2OrderDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _orderViewModel.CellRentHoursEdit(dgvTab2OrderStatus, dgvTab2OrderDetail, e, _rowSelected);
        }

        private void dgvTab2OrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTab2OrderDetail.Columns[e.ColumnIndex].Name == "Edit")
            {
                _orderViewModel.Save(tableAdapterManager, rentBicycleDataSet, ordersBindingSource);
            }
        }

        /*
         * Show row position when select
         */
        private int _rowSelected;
        private void dgvTab2OrderStatus_CellClick(object sender, DataGridViewCellEventArgs e) => _rowSelected = e.RowIndex;

        /*
         * 
         */
        private void dgvTab2OrderStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTab2OrderStatus.Columns[e.ColumnIndex].Name == "Done")
            {
                if (MessageBox.Show("Do you want to done bill", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvTab2OrderStatus.Rows[e.RowIndex];
                    row.Cells[6].Value = "done";

                    _orderViewModel.Done(tableAdapterManager, rentBicycleDataSet, ordersBindingSource, dgvTab2OrderDetail);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
