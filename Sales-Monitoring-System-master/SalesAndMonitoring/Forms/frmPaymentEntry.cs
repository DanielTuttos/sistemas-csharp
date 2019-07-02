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
    public partial class frmPaymentEntry : frmDataEntry
    {
        public double Cash
        {
            get
            {
                double cash;
                double.TryParse(txtCash.Text, out cash);
                return cash;
            }
        }

        public double AmountToPay { get; set; }

        public bool IsSubmit { get; set; }

        public frmPaymentEntry()
        {
            InitializeComponent();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {

            double cash;
            double.TryParse(txtCash.Text, out cash);
            if (cash <= 0)
            {
                MessageBox.Show("Invalid Cash Input", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(AmountToPay > cash)
            {
                MessageBox.Show("Not enough cash\nPlease Pay P" + AmountToPay.ToString(), "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            IsSubmit = true;
            isClosing = true;
            Close();
        }


        private void frmPaymentEntry_Load(object sender, EventArgs e)
        {
            txtAmount.Text = AmountToPay.ToString("#,##0.00");
            txtChange.Text = "0.00";
        }

        private void txtCash_KeyUp(object sender, KeyEventArgs e)
        {
            double cash;
            double.TryParse(txtCash.Text, out cash);

            txtChange.Text = (cash - AmountToPay).ToString("#,##0.00");
        }
    }
}