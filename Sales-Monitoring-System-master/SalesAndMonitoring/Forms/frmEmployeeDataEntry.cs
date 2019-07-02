using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesAndMonitoring
{
    public partial class frmEmployeeDataEntry : frmDataEntry
    {

        //USING THE DELEGATE TO INVOKE THE REFRESHDATA OF SUPPLIER
        private static frmManageEmployee.MsgHandler modRefreshData;

        private static string dbAction;

        //SHOWING THIS FORM AS_XXXX
        public static void showAs_Add(frmManageEmployee.MsgHandler msg)
        {
            dbAction = "add";
            modRefreshData = msg;
            frmEmployeeDataEntry f = new frmEmployeeDataEntry();
            f.ShowDialog();
        }

        public static void showAs_View(frmManageEmployee.MsgHandler msg, string[] obj)
        {
            
            
        }

        public static void showAs_Update(frmManageEmployee.MsgHandler msg, string[] obj)
        {
           
        }

      

        private frmEmployeeDataEntry()
        {
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

    }
}