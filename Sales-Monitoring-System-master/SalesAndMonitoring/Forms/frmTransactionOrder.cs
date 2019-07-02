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
using System.Threading.Tasks;

namespace SalesAndMonitoring
{
    public partial class frmTransactionOrder : Form
    {
        private Order _order;
        private Order_Detail _orderDetails;

        public frmTransactionOrder()
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
                    MessageBox.Show("Product Barcode not available", "invalid", MessageBoxButtons.OK,
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

        private void btnSubmitTransaction_Click(object sender, EventArgs e)
        {
            if (txtGrandtotal.Text.Trim() == "") return;

            var result = MessageBox.Show(
                "You must save the transaction before you cant generate Invoice\nDo you want to save transaction?",
                "Saving transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                _order.CustomerID = int.Parse(cmbBillto.SelectedValue.ToString() ?? "0");
                _order.IsPaid = false;
                _order.OrderDate = dtpTransDate.Value;
                _order.BillingDate = dtpTransDate.Value.AddDays(30);
                _order.Term = 30;

                foreach (var orderDetail in OrderDetailSource.OfType<Order_Detail>())
                {
                    _order.Order_Details.Add(orderDetail);
                }

                BusinessAccessLayer.GetEntity().Orders.AddObject(_order);
                BusinessAccessLayer.GetEntity().SaveChanges();

                GenerateInvoice();

                Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
                        
                var products = BusinessAccessLayer.GetEntity().Products.Where(x => x.ProductName.Contains(textBox1.Text.Trim()));


                if (products.Count() <= 0)
                {
                    MessageBox.Show("Product Barcode not available", "invalid", MessageBoxButtons.OK,
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

        private void frmTransactionOrder_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //dataGrid.Rows.Clear();
            //dataGrid.SuspendLayout();

            //try
            //{
            //    var products = BusinessAccessLayer.GetEntity().Products.Where(x => x.ProductName.Contains(textBox1.Text.Trim()));

            //    _orderDetails = new Order_Detail();
            //    _orderDetails.Quantity = 1;
            //    _orderDetails.UnitPrice = products.First().UnitPrice;
            //    _orderDetails.ProductID = products.First().ProductID;
            //    _orderDetails.IsVoid = false;
            //    _orderDetails.IsReturn = false;

            //    OrderDetailSource.Add(_orderDetails);

            //    CalculateSumAmount();
            //    textBox11.Clear();
            //    textBox11.Focus();
            //}

            //catch
            //{

            //}

            //dataGrid.ResumeLayout();
        }
    }
}