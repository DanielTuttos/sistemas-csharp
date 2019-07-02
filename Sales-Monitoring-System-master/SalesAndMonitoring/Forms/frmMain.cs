

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SalesAndMonitoring.Database;

namespace SalesAndMonitoring
{
    public partial class frmMain : Form
    {
        public delegate void MsgHandler(string msg);
        MsgHandler modDbAction;

        //crate a form as container
        Form currForm;

        //---------------------------------------------//
        #region METHODS_PROPERTIES

        private void showLogin()
        {
            frmLogin log = new frmLogin();
            log.ShowDialog();
            if (!log.isValid) { Application.Exit(); }

            statUser.Text = log.getUser;
        }

        private void showSplash()
        {
            new frmSplashScreen().ShowDialog();
        }

        private void showAd()
        {
            var path = new Uri(Application.StartupPath + "\\Flash\\myfile_Webpage.html");          
            
        }

        private void showToolbars(bool[] tb)
        {
            tbAddNew.Visible = tb[0];
            tbView.Visible = tb[1];
            tbUpdate.Visible = tb[2];
            tbDelete.Visible = tb[3];
            tbExit.Visible = tb[4];
        }

        private void showManageSupplier()
        {
            //Create Only One Instance of Form
            frmManageSupplier f = frmManageSupplier.CreateInstance();
            
            f.MdiParent = this;
            f.dataGrid.Width = Width - (imgAd.Width + 35);

            showManaged(f);
            showToolbars(new bool[] { true, true, true, true, true });
        }

        private void showManageProduct()
        {
            //Create Only One Instance of Form
            frmManageProduct f = frmManageProduct.CreateInstance();

            
            //settings for frmManageProduct
            f.MdiParent = this;
            f.dataGrid.Width = Width - (imgAd.Width + 35);

            showManaged(f);
            showToolbars(new bool[] { true, true, true, true, true });
        }

        private void showManageProductDetails()
        {
            //Create Only One Instance of Form
            frmManageProduct f = frmManageProduct.CreateInstance();

            //settings for frmManageProduct
            f.MdiParent = this;
            f.dataGrid.Width = Width - (imgAd.Width + 35);

            showManaged(f);
            showToolbars(new bool[] { false, false, false, false, true });
        }

        private void showOrderList()
        {
            //Create Only One Instance of Form
            frmManageOrderList f = frmManageOrderList.CreateInstance();

            f.MdiParent = this;
            f.dataGrid.Width = Width - (imgAd.Width + 35);

            showManaged(f);
            showToolbars(new bool[] { false, false, false, false, true });
        }


        private void showRemmitanceList()
        {
            //Create Only One Instance of Form
            frmRemittanceList f = frmRemittanceList.CreateInstance();

            f.MdiParent = this;
            f.dataGrid.Width = Width - (imgAd.Width + 35);

            showManaged(f);
            showToolbars(new bool[] { false, false, false, false, true });
        }


        private void showARList()
        {
            //Create Only One Instance of Form
            frmManageAR f = frmManageAR.CreateInstance();

            f.MdiParent = this;
            f.dataGrid.Width = Width - (imgAd.Width + 35);

            showManaged(f);
            showToolbars(new bool[] { false, false, false, false, true });
        }

        private void showManaged(frmManageRecord f)
        {
            
            currForm = f;
            var dbAction = new MsgHandler(f.DbAction);
            modDbAction = dbAction;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void showMenu()
        {
            frmMainMenu f = new frmMainMenu(new MsgHandler(showSelected));
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void showSelected(string msg)
        {
            if (msg.Contains("Walk"))
            {
                new frmTransactionWalkin().ShowDialog();
            }
            else if (msg.Contains("Purchase Order"))
            {
                new frmTransactionOrder().ShowDialog();
            }
            else if (msg.Contains("Delivery"))
            {
                new frmTransactionDelivery().ShowDialog();
            }
            else if (msg == "Order List")
            {
               showOrderList();
            }
            else if (msg.Contains("Remit"))
            {
                new frmRemittance().ShowDialog();
                showRemmitanceList();
            }
            else if (msg == "Item List")
            {
                showManageProduct();
            }
            else if (msg.Contains("Details"))
            {
                showManageProductDetails();
            }
            else if (msg.Contains("Buying Report"))
            {
                var rptRange = new frmDateRangeReport();
                rptRange.Title = "Buying Report Range";
                rptRange.ShowDialog();
                if(!rptRange.IsShow)return;

                var f = new frmProductInventoryReport();
                f.ProductBindingSource.DataSource = BusinessAccessLayer.GetEntity().Products;
                f.ShowDialog();
            }
            else if (msg.Contains("Open P/O Report"))
            {
                var rptRange = new frmDateRangeReport();
                rptRange.Title = "Open P/O Report Range";
                rptRange.ShowDialog();
                if (!rptRange.IsShow) return;

                var f = new frmOpenPOReport();
                f.GetOrderList_ResultBindingSource.DataSource = BusinessAccessLayer.GetEntity().GetOrderList();
                 //.Where(e=> e.DeliveryDate >= rptRange.dtFrom.Value && e.DeliveryDate <= rptRange.dtFrom.Value);
                f.ShowDialog();
            }
            else if (msg.Contains("AR Cash Report"))
            {

            }

            else if (msg.Contains("Account Recievable"))
            {
                showARList();
            }
        }

        #endregion
        //---------------------------------------------//

        //Constructor
        public frmMain()
        {
            var data = BusinessAccessLayer.GetEntity();
            InitializeComponent();
        }

        //Prevent Resizing of Form
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            showMenu();
            showToolbars(new bool[]{false,false,false,false,false});
         //   showAd();
            showSplash();
            showLogin();
        }


        //TOOLBAR METHODS
        private void tbAddNew_Click(object sender, EventArgs e)
        {
            if (modDbAction != null) modDbAction("add");
        }

        private void tbView_Click(object sender, EventArgs e)
        {
            if (modDbAction != null) modDbAction("view");
        }

        private void tbUpdate_Click(object sender, EventArgs e)
        {
            if (modDbAction != null) modDbAction("update");
        }

        private void tbDelete_Click(object sender, EventArgs e)
        {
            if (modDbAction != null) modDbAction("delete");
        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            if (modDbAction != null) modDbAction("exit");
            showToolbars(new bool[] { false, false, false, false, false });
            currForm.Close();
            currForm = null;
        }

        //END OF TOOLBAR METHODS


        //MENU BAR METHODS
        private void table1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if theres other form showed(only one form at a time)
            if (currForm == null)
            {
                showManageSupplier();
            }
        }

        private void table2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if theres other form showed(only one form at a time)
            if (currForm == null)
            {
                showManageProduct();
            }
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if theres other form showed(only one form at a time)
            if (currForm == null)
            {
                
            }
        }


        private void tbNewTrans_Click(object sender, EventArgs e)
        {
            new frmTransactionWalkin().ShowDialog();
        }

        private void statWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tonyfear.netau.net/index.php?option=com_content&view=article&id=2&Itemid=18");
        }

        private void tmrCurTime_Tick(object sender, EventArgs e)
        {
            int strHour = Convert.ToInt32(DateTime.Now.Hour.ToString("00"));
            string strTime = strHour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " AM";
            if (strHour > 12)
            {
                strHour = strHour - 12;
                strTime = strHour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") + " PM";
            }
            statDate.Text = DateTime.Now.Date.ToLongDateString();
            statTime.Text = strTime;
            lblTime.Text = strTime;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutUs().ShowDialog();
        }

        private void mnuNewTrans_Click(object sender, EventArgs e)
        {
            new frmTransactionWalkin().ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLogin();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void internetBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("taskmgr.exe");
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("services.msc");
        }

        private void commandLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe","C:");
        }

        private void systemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmManageUser().ShowDialog();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}