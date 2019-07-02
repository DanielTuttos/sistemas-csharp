/*--------------------------------------------------------------------------------------------------------------*/
// PROGRAMMER: WINSTON L. GUBANTES
// REFERENCES: VISUAL C# PROGRAMMING BY: BARBARA DOYLE
//             VISUAL BASIC .NET HOW TO PROGRAM BY: DEITEL & TIM R. NIETO
//
// PURPOSE: 
// LANGUAGE: C# .NET
/*--------------------------------------------------------------------------------------------------------------*/

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
    public partial class frmProductDataEntry : frmDataEntry
    {
        //USING THE DELEGATE TO INVOKE THE REFRESHDATA OF SUPPLIER
        private static frmManageProduct.MsgHandler modRefreshData;

        private static string dbAction;

        //SHOWING THIS FORM AS_XXXX
        public static void showAs_Add(frmManageProduct.MsgHandler msg)
        {
            modRefreshData = msg;
            var f = new frmProductDataEntry();
            var product = new Product();
            f.bindingProduct.Add(product);
            f.bindingProduct.MoveLast();
            f.ShowDialog();
        }

        public static void showAs_View(frmManageProduct.MsgHandler msg, int id)
        {
            modRefreshData = msg;
            var f = new frmProductDataEntry(id);
            f.btnSave.Visible = false;
            f.ShowDialog();
        }

        public static void showAs_Update(frmManageProduct.MsgHandler msg, int id)
        {
            modRefreshData = msg;
            var f = new frmProductDataEntry(id);
            f.ShowDialog();
        }
     

        private frmProductDataEntry(int id=0)
        {
            InitializeComponent();

            bindingSupplier.DataSource = BusinessAccessLayer.GetEntity().Suppliers;
            if (id <= 0)
            {
                bindingProduct.DataSource = BusinessAccessLayer.GetEntity().Products;
            }
            else
            {
                bindingProduct.DataSource = BusinessAccessLayer.GetEntity().Products.Where(e=> e.ProductID == id);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BusinessAccessLayer.GetEntity().SaveChanges();
            modRefreshData("");
            Close();
            Dispose();
        }

    }
}