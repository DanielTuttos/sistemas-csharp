using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesAndMonitoring
{
    public partial class frmManageEmployee : frmManageRecord
    {

        public void RefreshData(string s)
        {
            
        }

        //this will create a single instance of form
        public static frmManageEmployee CreateInstance()
        {
            frmManageEmployee f;
            if (thisform == null)
            {
                thisform = new frmManageEmployee();
            }
            //dynamic casting
            f = (frmManageEmployee)thisform;
            return f;
        }

        

        

        private frmManageEmployee()
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