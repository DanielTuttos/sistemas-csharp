/*--------------------------------------------------------------------------------------------------------------*/
// PROGRAMMER: WINSTON L. GUBANTES
// REFERENCES: VISUAL C# PROGRAMMING BY: BARBARA DOYLE
//             VISUAL BASIC .NET HOW TO PROGRAM BY: DEITEL & TIM R. NIETO
//
// PURPOSE:    SAMPLE OF MANAGING RECORDS, FEATURES: SEARCH, ADD, EDIT, DELETE
// LANGUAGE:   C# .NET
/*--------------------------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesAndMonitoring
{
    public partial class frmOpenPOReport : Form
    {

        //USING A DELEGATES TO POINT THE REFRESHDATA FUNCTION OF frmManage Derivatives
        public delegate void MsgHandler(string msg);

        //create a static form
        protected static frmManageRecord thisform;

        public frmOpenPOReport()
        {
            InitializeComponent();
        }

        public virtual void DbAction(string action){}

        private void frmManageRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            thisform = null;
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }
    }
}