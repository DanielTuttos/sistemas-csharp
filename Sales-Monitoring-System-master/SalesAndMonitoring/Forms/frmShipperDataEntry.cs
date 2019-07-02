using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesAndMonitoring
{
    public partial class frmShipperDataEntry : frmDataEntry
    {
        //USING THE DELEGATE TO INVOKE THE REFRESHDATA OF SUPPLIER
        private static frmManageShipper.MsgHandler modRefreshData;

        private static string dbAction;

        //SHOWING THIS FORM AS_XXXX
        public static void showAs_Add(frmManageShipper.MsgHandler msg)
        {
            dbAction = "add";
            modRefreshData = msg;
            frmShipperDataEntry f = new frmShipperDataEntry();
            f.ShowDialog();
        }

        public static void showAs_View(frmManageShipper.MsgHandler msg, string[] obj)
        {
        }

        public static void showAs_Update(frmManageShipper.MsgHandler msg, string[] obj)
        {
           
        }

       

        public frmShipperDataEntry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}