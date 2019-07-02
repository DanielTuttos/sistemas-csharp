

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
    public partial class frmRemittanceList : frmManageRecord
    {

        public void RefreshData(string msg)
        {
            var entity = BusinessAccessLayer.GetEntity();
            BillingSource.DataSource = entity.RemittanceDetails;
        }

        //this will create a single instance of form
        public static frmRemittanceList CreateInstance()
        {
            frmRemittanceList f;
            if (thisform == null)
            {
                thisform = new frmRemittanceList();
            }
            f = (frmRemittanceList)thisform;
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


        private frmRemittanceList()
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