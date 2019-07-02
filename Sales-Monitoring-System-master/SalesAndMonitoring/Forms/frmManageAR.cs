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
    public partial class frmManageAR : frmManageRecord
    {

        public void RefreshData(string msg)
        {
            var entity = BusinessAccessLayer.GetEntity();
            OrderSource.DataSource = entity.GetAccountReceivable();
        }

        //this will create a single instance of form
        public static frmManageAR CreateInstance()
        {
            frmManageAR f;
            if (thisform == null)
            {
                thisform = new frmManageAR();
            }
            f = (frmManageAR)thisform;
            return f;
        }

        public override void  DbAction(string action)
        {
            switch (action)
            {
                case "add":

                    break;
                case "view":

                    break;
                case "update":

                    break;
                case "delete":
                    break;
            }
        }


        private frmManageAR()
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

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count <= 0) return;

            var id = int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString());

            new frmTransactionBilling(id).ShowDialog();
            RefreshData("Refresh");
        }
    }
}