using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesAndMonitoring
{
    public partial class frmManageShipper : frmManageRecord
    {

     
        public void RefreshData(string s)
        {

        }

        //this will create a single instance of form
        public static frmManageShipper CreateInstance()
        {
            frmManageShipper f;
            if (thisform == null)
            {
                thisform = new frmManageShipper();
            }
            f = (frmManageShipper)thisform;
            return f;
        }

      
        private void AddRecord()
        {
            //create a single instance of frmSupplierDE, then pass the delegate method to be invoke 
            frmShipperDataEntry.showAs_Add(new MsgHandler(RefreshData));
        }

        private void ViewRecord()
        {
            
        }

        private void UpdateRecord()
        {
            
        }

        private void DeleteRecord()
        {
           
        }


        public void DbAction(string msg)
        {

           

        }
       
        private frmManageShipper()
        {
            InitializeComponent();
            RefreshData(" ");
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