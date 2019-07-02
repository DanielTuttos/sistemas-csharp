/*--------------------------------------------------------------------------------------------------------------*/
// PROGRAMMER: WINSTON L. GUBANTES
// REFERENCES: VISUAL C# PROGRAMMING BY: BARBARA DOYLE
//             VISUAL BASIC .NET HOW TO PROGRAM BY: DEITEL & TIM R. NIETO
// PURPOSE: SAMPLE OF DATA ENTRY
// LANGUAGE: C# .NET
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
    public partial class frmDateRangeReport : Form
    {
        public bool isClosing = false;

        public string Title
        {
            get { return lblHeader.Text; }
            set { lblHeader.Text = value; }
        }

        public bool IsShow { get; set; }

        public frmDateRangeReport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isClosing = true;
            DialogResult dr = MessageBox.Show("Are you sure you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmDataEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            //prevents the close button of form to perform close
            if (!isClosing)
            {
                e.Cancel = true;
                return;
            }
            isClosing = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IsShow = true;
            isClosing = true;
            Close();
        }
    }
}