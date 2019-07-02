using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SalesAndMonitoring.Database;

namespace SalesAndMonitoring
{
    public partial class frmTransactionBilling : Form
    {
        private Order _order;
        private Order_Detail _orderDetails;

        public frmTransactionBilling()
        {
            InitializeComponent();
            _order = new Order();
            OrderSource.DataSource = BusinessAccessLayer.GetEntity().Orders;
            CustomerSource.DataSource = BusinessAccessLayer.GetEntity().Customers;
            ProductSource.DataSource = BusinessAccessLayer.GetEntity().Products;

        }

        public frmTransactionBilling(int id)
        {
            InitializeComponent();
            _order = new Order();

            if (BusinessAccessLayer.GetEntity().Orders.Where(e => e.OrderID == id).Count() <=0)
            {
                MessageBox.Show("Order Transaction doesnt exist", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _order = BusinessAccessLayer.GetEntity().Orders.Where(e => e.OrderID == id).First();

            OrderSource.DataSource = _order;
            CustomerSource.DataSource = _order.Customer;
            ProductSource.DataSource = BusinessAccessLayer.GetEntity().Products;
            OrderDetailSource.DataSource = _order.Order_Details;

            CalculateSumAmount();
        }


        void CalculateSumAmount()
        {
            try
            {
                var sumAmount =  OrderDetailSource.OfType<Order_Detail>().Sum(e => e.Quantity*e.UnitPrice);
                var sumDiscount = OrderDetailSource.OfType<Order_Detail>().Sum(e => (e.Quantity * e.UnitPrice??0) * ((decimal)(e.Discount??0/100)));
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtGrandtotal.Text.Trim() == "") return;

            var paymentEntry = new frmPaymentEntry();
            paymentEntry.AmountToPay = double.Parse(txtGrandtotal.Text);
            paymentEntry.ShowDialog();

            if (!paymentEntry.IsSubmit) return;

            var payment = new Payment();
            payment.AmountPaid = (decimal)paymentEntry.Cash;
            payment.Balance = (decimal)(paymentEntry.Cash - double.Parse(txtGrandtotal.Text));

            _order.CustomerID = int.Parse(cmbBillto.SelectedValue.ToString() ?? "0");
            _order.IsPaid = (payment.Balance == 0);
            _order.OrderDate = dtpTransDate.Value;
            _order.BillingDate = dtpTransDate.Value;
            _order.Term = 30;
            _order.Payments.Add(payment);

            
            BusinessAccessLayer.GetEntity().SaveChanges();

            MessageBox.Show("transaction saved", "transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }


        void GenerateInvoice()
        {
            var f = new frmInvoice();
            f.OrderBindingSource.DataSource = _order;
            List<ReportParameter> param = new List<ReportParameter>();

            param.Add(new ReportParameter("OrderDate", _order.OrderDate.Value.ToShortDateString()));
            param.Add(new ReportParameter("CustomerName", cmbBillto.Text == "" ? "No Customer" : cmbBillto.Text));
            param.Add(new ReportParameter("CustomerAddress", txtAddress.Text == "" ? "No Address Specified" : txtAddress.Text));
            param.Add(new ReportParameter("CustomerTel", "123-123"));
            param.Add(new ReportParameter("Manager", "The Manager"));
            param.Add(new ReportParameter("SubTotal", txtSubtotal.Text));
            param.Add(new ReportParameter("Discount", txtDiscount.Text));
            param.Add(new ReportParameter("GrandTotal", txtGrandtotal.Text));

            f.reportViewer.LocalReport.SetParameters(param);
            f.ShowDialog();
        }
    }
}