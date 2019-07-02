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
    public partial class frmSupplierDataEntry : frmDataEntry
    {
        //USING THE DELEGATE TO INVOKE THE REFRESHDATA OF SUPPLIER
        private static frmManageSupplier.MsgHandler modRefreshData;

        private static string dbAction;

        //SHOWING THIS FORM AS_XXXX
        public static void showAs_Add(frmManageSupplier.MsgHandler msg)
        {
            modRefreshData = msg;
            var f = new frmSupplierDataEntry();
            var supplier = new Supplier();
            f.SupplierSource.Add(supplier);
            f.SupplierSource.MoveLast();
            f.ShowDialog();
        }

        public static void showAs_View(frmManageSupplier.MsgHandler msg, int id)
        {
            modRefreshData = msg;
            var f = new frmSupplierDataEntry(id);
            f.btnSave.Visible = false;
            f.ShowDialog();
        }

        public static void showAs_Update(frmManageSupplier.MsgHandler msg, int id)
        {
            modRefreshData = msg;
            var f = new frmSupplierDataEntry(id);
            f.ShowDialog();
        }



        private frmSupplierDataEntry(int id = 0)
        {
            InitializeComponent();


            if (id <= 0)
            {
                SupplierSource.DataSource = BusinessAccessLayer.GetEntity().Suppliers;
            }
            else
            {
                SupplierSource.DataSource = BusinessAccessLayer.GetEntity().Suppliers.Where(e=> e.SupplierID == id);
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