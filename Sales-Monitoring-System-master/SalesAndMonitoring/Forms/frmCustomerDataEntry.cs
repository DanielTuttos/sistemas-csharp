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
    public partial class frmCustomerDataEntry : frmDataEntry
    {

        //USING THE DELEGATE TO INVOKE THE REFRESHDATA OF SUPPLIER
        private static frmManageCustomer.MsgHandler modRefreshData;

        private static string dbAction;

        
        public static void showAs_Add(frmManageCustomer.MsgHandler msg)
        {
            modRefreshData = msg;
            var f = new frmCustomerDataEntry();
            var customer = new Customer();
            f.CustomerSource.Add(customer);
            f.CustomerSource.MoveLast();
            f.ShowDialog();
        }

        public static void showAs_View(frmManageCustomer.MsgHandler msg, int id)
        {
            modRefreshData = msg;
            var f = new frmCustomerDataEntry(id);
            f.btnSave.Visible = false;
            f.ShowDialog();
        }

        public static void showAs_Update(frmManageCustomer.MsgHandler msg, int id)
        {
            modRefreshData = msg;
            var f = new frmCustomerDataEntry(id);
            f.ShowDialog();
        }

        
        private frmCustomerDataEntry(int id= 0)
        {
            InitializeComponent();

            if (id <= 0)
            {
                CustomerSource.DataSource = BusinessAccessLayer.GetEntity().Products;
            }
            else
            {
                CustomerSource.DataSource = BusinessAccessLayer.GetEntity().Customers.Where(e => e.ID == id);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BusinessAccessLayer.GetEntity().SaveChanges();
            Close();
            Dispose();
        }
    }
}