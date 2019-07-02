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
    public partial class frmManageCustomer : frmManageRecord
    {

        public void RefreshData(string msg)
        {
            var entity = BusinessAccessLayer.GetEntity();
            CustomerSource.DataSource = entity.Customers;
        }

        //this will create a single instance of form
        public static frmManageCustomer CreateInstance()
        {
            frmManageCustomer f;
            if (thisform == null)
            {
                thisform = new frmManageCustomer();
            }
            //dynamic casting
            f = (frmManageCustomer) thisform;
            return f;
        }

       

        private frmManageCustomer()
        {
            InitializeComponent();
            RefreshData("Refresh");
        }


        public override void DbAction(string action)
        {
            switch (action)
            {
                case "add":
                    frmCustomerDataEntry.showAs_Add(RefreshData);
                    break;
                case "view":
                    frmCustomerDataEntry.showAs_View(RefreshData, int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString()));
                    break;
                case "update":
                    frmCustomerDataEntry.showAs_Update(RefreshData, int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString()));
                    break;
                case "delete":
                    break;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbOrderby_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }


    }
}