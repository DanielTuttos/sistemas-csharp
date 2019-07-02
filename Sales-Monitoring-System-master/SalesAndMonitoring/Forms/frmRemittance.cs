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
    public partial class frmRemittance : frmDataEntry
    {

        public frmRemittance(int id = 0)
        {
            InitializeComponent();

            UserSource.DataSource = BusinessAccessLayer.GetEntity().User_tbl;

            var ordersPaid =
                BusinessAccessLayer.GetEntity().Orders.ToList().Where(
                    e => (e.OrderDate >= DateTime.Now.AddHours(-8) && e.OrderDate <= DateTime.Now) || 
                        (e.DeliveryDate >= DateTime.Now.AddHours(-8) && e.DeliveryDate <= DateTime.Now));

            decimal? totalRemit = null;

            totalRemit = ordersPaid.Sum(e => e.Payments.Sum(x => x.AmountPaid));

            label3.Text = (totalRemit??0).ToString("#,###.00");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var remitttance = new Remittance();
            remitttance.DateRemit = DateTime.Now;
            remitttance.UserID = int.Parse(comboBox1.SelectedValue.ToString());

            foreach (var remittanceDetail in RemitDetailSource.OfType<RemittanceDetail>())
            {
                remitttance.RemittanceDetails.Add(remittanceDetail);
            } 


            BusinessAccessLayer.GetEntity().Remittances.AddObject(remitttance);
            BusinessAccessLayer.GetEntity().SaveChanges();
            Close();
            Dispose();
        }

    }
}