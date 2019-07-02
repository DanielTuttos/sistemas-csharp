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
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesAndMonitoring.Database;

namespace SalesAndMonitoring
{
    public partial class frmManageProduct : frmManageRecord
    {
        private SalesAndMonitoringEntities entity;

        public void RefreshData(string msg)
        {
            entity = new SalesAndMonitoringEntities();
            ProductsSource.DataSource = entity.Products;
        }

        //this will create a single instance of form
        public static frmManageProduct CreateInstance()
        {
            frmManageProduct f;
            if (thisform == null)
            {
                thisform = new frmManageProduct();
            }
            f = (frmManageProduct)thisform;
            return f;
        }

        public override void  DbAction(string action)
        {
            switch (action)
            {
                case "add":
                    frmProductDataEntry.showAs_Add(RefreshData);
                    break;
                case "view":
                    frmProductDataEntry.showAs_View(RefreshData,int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString()));
                    break;
                case "update":
                    frmProductDataEntry.showAs_Update(RefreshData, int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString()));
                    break;
                case "delete":
                    var result = MessageBox.Show("are you sure you want to deleete this record?", "", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        var p = ((Product) ProductsSource.Current);
                        entity.Products.DeleteObject(p);
                        entity.SaveChanges();
                    }

                    break;
            }
        }

        
        private frmManageProduct()
        {
            InitializeComponent();
            RefreshData("Refresh");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbOrderby_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}