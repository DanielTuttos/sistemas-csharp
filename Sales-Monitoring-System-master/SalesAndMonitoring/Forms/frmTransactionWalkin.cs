using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesAndMonitoring.Database;

namespace SalesAndMonitoring
{
    public partial class frmTransactionWalkin : Form
    {
        private Order _order;
        private Order_Detail _orderDetails;

        public frmTransactionWalkin()
        {
            InitializeComponent();
            _order = new Order();
            OrderSource.DataSource = BusinessAccessLayer.GetEntity().Orders;
            CustomerSource.DataSource = BusinessAccessLayer.GetEntity().Customers;
            ProductSource.DataSource = BusinessAccessLayer.GetEntity().Products;

            textBox11.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var products = BusinessAccessLayer.GetEntity().Products.Where(x => x.ProductName.Contains(textBox1.Text.Trim()));

                if(products.Count() <=0)
                {
                    MessageBox.Show("Product not available", "invalid", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return; 
                }
                _orderDetails = new Order_Detail();
                _orderDetails.Quantity = 1;
                _orderDetails.UnitPrice = products.First().UnitPrice;
                _orderDetails.ProductID = products.First().ProductID;
                _orderDetails.IsVoid = false;
                _orderDetails.IsReturn = false;

                OrderDetailSource.Add(_orderDetails);

                CalculateSumAmount();
                textBox11.Clear();
                textBox11.Focus();
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if(txtGrandtotal.Text.Trim() == "")return;

            var paymentEntry = new frmPaymentEntry();
            paymentEntry.AmountToPay = double.Parse(txtGrandtotal.Text);
            paymentEntry.ShowDialog();

            if(!paymentEntry.IsSubmit)return;

            var payment = new Payment();
            payment.AmountPaid = (decimal)paymentEntry.Cash;
            payment.Balance = (decimal)(paymentEntry.Cash - double.Parse(txtGrandtotal.Text));

            _order.CustomerID = int.Parse(cmbBillto.SelectedValue.ToString()??"0");
            _order.IsPaid = (payment.Balance == 0);
            _order.OrderDate = dtpTransDate.Value;
            _order.BillingDate = dtpTransDate.Value;
            _order.Term = 30;
            _order.Payments.Add(payment);

            foreach (var orderDetail in OrderDetailSource.OfType<Order_Detail>())
            {
                _order.Order_Details.Add(orderDetail);
              
            }

            BusinessAccessLayer.GetEntity().Orders.AddObject(_order);
            BusinessAccessLayer.GetEntity().SaveChanges();

            MessageBox.Show("transaction saved", "transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        void CalculateSumAmount()
        {
            try
            {
                var sumAmount =  OrderDetailSource.OfType<Order_Detail>().Sum(e => e.Quantity * e.UnitPrice);
                var sumDiscount = OrderDetailSource.OfType<Order_Detail>().Sum(e => (e.Quantity * e.UnitPrice) * ((decimal)(e.Discount??0 * 0.01)));
                txtDiscount.Text = sumDiscount.ToString();
                txtSubtotal.Text = sumAmount.ToString();
                txtGrandtotal.Text = (sumAmount - sumDiscount).ToString();
            }
            catch
            {
                
            }
        }

        private void dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateSumAmount();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}