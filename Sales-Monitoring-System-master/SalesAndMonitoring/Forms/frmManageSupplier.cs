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
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesAndMonitoring.Database;

namespace SalesAndMonitoring
{
    public partial class frmManageSupplier : frmManageRecord
    {
        
        public void RefreshData(string msg)
        {
            var entity = BusinessAccessLayer.GetEntity();
            entity.CreateDatabaseScript();
            SupplierSource.DataSource = entity.Suppliers;
        }

        //this will create a single instance of form
        public static frmManageSupplier CreateInstance()
        {
            frmManageSupplier f;
            if (thisform == null)
            {
                thisform = new  frmManageSupplier();
            }
            //dynamic casting
            f = (frmManageSupplier)thisform;
            return f;
        }
  
        private frmManageSupplier()
        {
            InitializeComponent();
            RefreshData("Refresh");
        }

        public override void DbAction(string action)
        {
            switch (action)
            {
                case "add":
                    frmSupplierDataEntry.showAs_Add(RefreshData);
                    break;
                case "view":
                    frmSupplierDataEntry.showAs_View(RefreshData, int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString()));
                    break;
                case "update":
                    frmSupplierDataEntry.showAs_Update(RefreshData, int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString()));
                    break;
                case "delete":
                    break;
            }
        }


        //WE USE THE TEXTCHANGED EVENT TO GET THE USERS SEARCH ENTRY
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbOrderby_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}