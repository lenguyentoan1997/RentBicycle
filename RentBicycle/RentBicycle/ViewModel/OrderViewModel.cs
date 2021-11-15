using RentBicycle.Model;
using RentBicycle.Model.RentBicycleDataSetTableAdapters;
using RentBicycle.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentBicycle.ViewModel
{
    class OrderViewModel
    {
        private RentBicycleEntities _database;

        public OrderViewModel() => _database = new RentBicycleEntities();
        private static List<Product> s_ProductList { get; set; }

        List<OrdersDetail> OrderDetailList = new List<OrdersDetail>();

        public BindingSource OrderDetailBindingSource { get; set; }
        public BindingSource OrderBindingSource { get; set; }

        private int _oldValueProdQuantity;
        private decimal _oldValueRentHours;

        /*
         * Get last order id in database
         */
        public int GetLastOrderId() => _database.Orders.ToList().LastOrDefault().Id;

        public object[] GetProductName(Label lblOrderId)
        {
            _database.Products.Load();

            s_ProductList = _database.Products.Local.ToList();

            object[] productName = s_ProductList.Select(x => x.Name).Cast<object>().ToArray();

            lblOrderId.Text = (GetLastOrderId() + 1).ToString();

            return productName;
        }

        public decimal RentalPricePerProd(decimal productPrice, int productQuantity, decimal rentHours) => productPrice * productQuantity * rentHours;

        public void GetProductInformation(ComboBox cbbProductName, PictureBox picProduct, Label lblProductId, Label lblQuantityStock, TextBox txtProductQuantity, TextBox txtRentHours, TextBox txtProductPrice)
        {
            var product = s_ProductList.Where(x => x.Name == cbbProductName.Text).Select(x => new { x.Id, x.Price, x.Img, x.Quantity });

            // find img name by value of combobox Product Name
            string imgName = product.Select(x => x.Img).FirstOrDefault().ToString();
            //Show img on PictureBox
            picProduct.Image = Image.FromFile(Helper.GetPathImg(imgName));

            string productId = product.Select(x => x.Id).FirstOrDefault().ToString();
            lblProductId.Text = productId;

            int productQuantityCurrent = 0;

            if (!string.IsNullOrEmpty(txtProductQuantity.Text))
            {
                productQuantityCurrent = Convert.ToInt32(txtProductQuantity.Text);
                if (string.IsNullOrEmpty(txtRentHours.Text))
                {
                    txtRentHours.Text = "0";
                }
                else
                {
                    //calculate Bicycle rental price when quantity and rental hours is different 0
                    txtProductPrice.Text = (RentalPricePerProd(Convert.ToDecimal(product.Select(x => x.Price).FirstOrDefault()), Convert.ToInt32(txtProductQuantity.Text), Convert.ToDecimal(txtRentHours.Text))).ToString();
                }
            }
            else
            {
                txtProductPrice.Text = "0";
            }

            string productQuantity = product.Select(x => x.Quantity).FirstOrDefault().ToString();
            lblQuantityStock.Text = productQuantity;
        }

        /*Check number order bicycle > quantityStock return false */
        public bool IsCheckNumberBicycle(int? detailQuantity, int? productId)
        {
            int productQuantity = Convert.ToInt32(s_ProductList.Where(x => x.Id == productId).Select(x => x.Quantity).FirstOrDefault());

            if (productQuantity >= detailQuantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Total Bill
        public decimal? CalculatorTotalProduct()
        {
            decimal? total = 0;
            OrderDetailList.ForEach(x => total += x.Price);

            return total;
        }

        public void DataGridViewRestart(DataGridView dataGridViewOrder)
        {
            try
            {
                dataGridViewOrder.DataSource = "";
                dataGridViewOrder.DataSource = OrderDetailList;
            }
            catch
            {

            }

        }

        public void Add(DataGridView dataGridViewOrder, OrdersDetail detail, Label lblTotal, Label lblQuantityStock)
        {
            if (detail.Quantity != 0 && detail.Price != 0 && detail.RentHours != 0)
            {
                if (IsCheckNumberBicycle(detail.Quantity, detail.ProductId))
                {
                    int? quantityProCurrentStock = 0;

                    //Check if the number of rental bicycle is less than the number of bicycle in stock
                    if (OrderDetailList.Exists(x => x.ProductId == detail.ProductId && x.RentHours == detail.RentHours))
                    {
                        foreach (var item in OrderDetailList)
                        {
                            if (item.ProductId == detail.ProductId && item.RentHours == detail.RentHours)
                            {
                                item.Quantity += detail.Quantity;
                                item.Price += detail.Price;
                            }
                        }
                    }
                    else
                    {
                        OrderDetailList.Add(detail);
                    }

                    s_ProductList.ForEach(x => { if (x.Id == detail.ProductId) { x.Quantity -= detail.Quantity; quantityProCurrentStock = x.Quantity; }; });
                    lblQuantityStock.Text = quantityProCurrentStock.ToString();

                    DataGridViewRestart(dataGridViewOrder);

                    lblTotal.Text = CalculatorTotalProduct().ToString();
                }
                else
                {
                    MessageBox.Show("The number of bicycle is not enough", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * edit column datagridview
         */
        public void CellEndEdit(DataGridView dataGridViewOrder, DataGridViewCellEventArgs e, Label lblQuantityStock)
        {
            if (e.ColumnIndex == 2)
            {
                int newValue = (int)dataGridViewOrder[2, e.RowIndex].Value;

                for (int i = 0; i < OrderDetailList.Count; i++)
                {
                    if (i == e.RowIndex)
                    {
                        //get product consists of quantity , price 
                        var product = s_ProductList.Where(x => x.Id == OrderDetailList[i].ProductId).Select(x => new { x.Quantity, x.Price });
                        int quantityStock = Convert.ToInt32(product.Select(x => x.Quantity).FirstOrDefault());
                        decimal productPrice = Convert.ToDecimal(product.Select(x => x.Price).FirstOrDefault());

                        if (newValue > quantityStock || newValue <= 0)
                        {
                            if (newValue <= 0)
                            {
                                MessageBox.Show("Quantity > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dataGridViewOrder[3, e.RowIndex].Value = _oldValueProdQuantity;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("The number of bicycle is not enough", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dataGridViewOrder[3, e.RowIndex].Value = _oldValueProdQuantity;
                                break;
                            }

                        }
                        else
                        {
                            //update quantity stock if client edit on datagirdview
                            var updateQuantityStock = s_ProductList.Where(x => x.Id == OrderDetailList[i].ProductId).Select(x => x.Quantity -= OrderDetailList[i].Quantity).FirstOrDefault().ToString();

                            OrderDetailList[i].Price = RentalPricePerProd(productPrice, (int)OrderDetailList[i].Quantity, (decimal)OrderDetailList[i].RentHours);

                            lblQuantityStock.Text = updateQuantityStock;

                            DataGridViewRestart(dataGridViewOrder);
                        }
                        break;
                    }
                }
            }
            if (e.ColumnIndex == 3)
            {
                decimal newValue = (decimal)dataGridViewOrder[4, e.RowIndex].Value;
                if (newValue <= 0)
                {
                    MessageBox.Show("RentalHorus > 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridViewOrder[3, e.RowIndex].Value = _oldValueRentHours;
                }
                else
                {
                    for (int i = 0; i < OrderDetailList.Count; i++)
                    {
                        if (i == e.RowIndex)
                        {
                            decimal productPrice = Convert.ToDecimal(s_ProductList.Where(x => x.Id == OrderDetailList[i].ProductId).Select(x => x.Price).FirstOrDefault());

                            OrderDetailList[i].Price = RentalPricePerProd(productPrice, (int)OrderDetailList[i].Quantity, (decimal)OrderDetailList[i].RentHours);

                            DataGridViewRestart(dataGridViewOrder);
                        }
                    }
                }
            }

        }

        /*
         *edit column datagridview
         */
        public void CellBeginEdit(DataGridView dataGridViewOrder, DataGridViewCellCancelEventArgs e, Label lblQuantityStock)
        {
            //edit Column index 2
            if (e.ColumnIndex == 2)
            {
                //value before edit
                _oldValueProdQuantity = (int)dataGridViewOrder[2, e.RowIndex].Value;

                for (int i = 0; i <= OrderDetailList.Count; i++)
                {
                    if (i == e.RowIndex)
                    {
                        //Update Quantity Stock = pre-edit value + quantity stock current
                        var quantityStock = s_ProductList.Where(x => x.Id == OrderDetailList[i].ProductId).Select(x => x.Quantity += OrderDetailList[i].Quantity);

                        lblQuantityStock.Text = quantityStock.FirstOrDefault().ToString();

                        break;
                    }
                }
            }
            else if (e.ColumnIndex == 3)
            {
                _oldValueRentHours = (decimal)dataGridViewOrder[3, e.RowIndex].Value;
            }
        }

        /*
         * click button edit
         */
        public void Edit(DataGridView dataGridViewOrder, OrdersDetail ordersDetail, int rowIndex, int quantityByCellDataGrid, Label lblQuantityStock)
        {
            for (int i = 0; i < s_ProductList.Count; i++)
            {
                if (i == rowIndex)
                {
                    if (ordersDetail.Quantity != quantityByCellDataGrid && quantityByCellDataGrid > 0)
                    {
                        //quantityByCellDataGrid quantity current in datagridview
                        if (IsCheckNumberBicycle(quantityByCellDataGrid + ordersDetail.Quantity, ordersDetail.ProductId))
                        {
                            OrderDetailList[i] = ordersDetail;
                            //Update quantityStock
                            var quantityStock = s_ProductList.Where(x => x.Id == ordersDetail.ProductId).Select(x => x.Quantity = (x.Quantity - ordersDetail.Quantity + quantityByCellDataGrid));

                            lblQuantityStock.Text = quantityStock.FirstOrDefault().ToString();
                            quantityByCellDataGrid = 0;
                            DataGridViewRestart(dataGridViewOrder);

                            MessageBox.Show("Update Success");
                        }
                        else
                        {
                            MessageBox.Show("Update Error", "Error");
                        }
                    }
                    break;
                }
            }
        }

        /*
         * click link delete
         */
        public void Delete(DataGridView dataGridViewOrder, int rowIndex, Label lblQuantityStock)
        {
            if (MessageBox.Show("Do you want to Delete Product", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Add the number of products to the Quantity Stock
                var quantityStock = s_ProductList.Where(x => x.Id == OrderDetailList[rowIndex].ProductId).Select(x => x.Quantity += OrderDetailList[rowIndex].Quantity);

                lblQuantityStock.Text = quantityStock.FirstOrDefault().ToString();

                OrderDetailList.RemoveAt(rowIndex);

                DataGridViewRestart(dataGridViewOrder);
            }
        }

        /*
         * Payment
         */
        public bool IsPayment(Order order, Customer customer, DataGridView dataGridViewOrder, Label lblOrderId)
        {
            if (MessageBox.Show("Do You Wan To Payment", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(order.CustomerIdentity) && !string.IsNullOrEmpty(order.CustomerName) && !string.IsNullOrEmpty(order.CustomerPhone))
                {
                    if (IsValidateName(customer.Name, customer.Phone))
                    {
                        if (OrderDetailList != null)
                        {
                            order.Total = CalculatorTotalProduct();

                            //Check customer Id exists
                            foreach (var item in _database.Customers)
                            {
                                if (item.CitizensIdentity == customer.CitizensIdentity)
                                {
                                    break;
                                }
                                else
                                {
                                    _database.Customers.Add(customer);
                                }
                            }

                            _database.Orders.Add(order);

                            _database.OrdersDetails.AddRange(OrderDetailList);

                            _database.SaveChanges();

                            FormPrintBill formPrintBill = new FormPrintBill(order.Id);
                            formPrintBill.ShowDialog();

                            OrderDetailList.Clear();

                            lblOrderId.Text = (GetLastOrderId() + 1).ToString();
                            DataGridViewRestart(dataGridViewOrder);

                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No products to Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone Or Name wrong format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Fields Customer cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            return false;
        }

        public bool IsValidateName(string name,string phone)
        {
            Regex regexName = new Regex(@"^([a-zA-Z]+\s{1}[a-zA-Z]{1,}|[a-zA-Z]+\s{1}[a-zA-Z]{2,}\s{1}[a-zA-Z]{1,})$");
            var regexPhone = new Regex(@"^([0-9]{10})+$");
            if (regexName.IsMatch(name) && regexPhone.IsMatch(phone))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        /*************************************************************************************************************************************************/
        /*************************************************************************************************************************************************/
        //                                                                ORDER STATUS                                                                   //
        /*************************************************************************************************************************************************/
        /*************************************************************************************************************************************************/


        /*
         * update price dbo.Ordersdetail,total dbo.Orders when user click column Rent Hours in dgvTab2OrderDetail  
         */
        public void CellRentHoursEdit(DataGridView dgvTab2OrderStatus, DataGridView dgvTab2OrderDetail, DataGridViewCellEventArgs e, int dgvTab2OrderStatusRowSeleted)
        {
            DataGridViewRow rowDGVTab2OrderDetail = dgvTab2OrderDetail.Rows[e.RowIndex];

            //Product Price By Product Id == Product Id in row datagridview Tab2 OrderDetail
            decimal productPriceByProId = Convert.ToDecimal(s_ProductList.Where(x => x.Id == Convert.ToInt32(rowDGVTab2OrderDetail.Cells[1].Value)).Select(x => x.Price).FirstOrDefault());

            //
            rowDGVTab2OrderDetail.Cells[5].Value = Convert.ToDecimal(rowDGVTab2OrderDetail.Cells[3].Value) * Convert.ToInt32(rowDGVTab2OrderDetail.Cells[4].Value) * productPriceByProId;

            decimal total = 0;

            for (int i = 0; i < dgvTab2OrderDetail.Rows.Count; i++)
            {
                DataGridViewRow row = dgvTab2OrderDetail.Rows[i];
                total += Convert.ToDecimal(row.Cells[5].Value);
            }

            DataGridViewRow rowDGVTab2OrderStatus = dgvTab2OrderStatus.Rows[dgvTab2OrderStatusRowSeleted];

            rowDGVTab2OrderStatus.Cells[5].Value = total;
        }

        public void Save(TableAdapterManager tableAdapterManager, RentBicycleDataSet rentBicycleDataSet, BindingSource ordersBindingSource)
        {
            if (MessageBox.Show("Do you want to edit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ordersBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(rentBicycleDataSet);

                MessageBox.Show("Edit Rental Hours Success");
            }

        }

        public void Done(TableAdapterManager tableAdapterManager, RentBicycleDataSet rentBicycleDataSet, BindingSource ordersBindingSource, DataGridView dgvOrderDetail)
        {
            int count = 0;

            //when completing the bill,add the number of products in stock
            foreach (var product in s_ProductList)
            {
                for (int i = 0; i < dgvOrderDetail.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvOrderDetail.Rows[i];
                    if (product.Id == Convert.ToInt32(row.Cells[1].Value))
                    {
                        product.Quantity += Convert.ToInt32(row.Cells[4].Value);
                        count++;
                    }
                }
                if (count == dgvOrderDetail.Rows.Count)
                {
                    break;
                }
            }

            ordersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(rentBicycleDataSet);
            _database.SaveChanges();

            MessageBox.Show("The Customer has returned the bicycle");
        }


    }
}
