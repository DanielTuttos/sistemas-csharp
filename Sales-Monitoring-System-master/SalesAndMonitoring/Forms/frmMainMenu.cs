using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesAndMonitoring
{
    public partial class frmMainMenu : Form
    {
        private frmMain.MsgHandler Selected; 

        public frmMainMenu(frmMain.MsgHandler s)
        {
            InitializeComponent();
            Selected = s;

            listView1.View = View.LargeIcon;
            var item = listView1.Items.Add("Entrar", 0);
            item.Group = listView1.Groups[0];
            item = listView1.Items.Add("Orden de compra", 5);
            item.Group = listView1.Groups[0];
            item = listView1.Items.Add("Lista de orden", 1);
            item.Group = listView1.Groups[0];
            item = listView1.Items.Add("Remesa", 0);
            item.Group = listView1.Groups[0];
            item = listView1.Items.Add("Remesa", 3);
            item.Group = listView1.Groups[0];

            item = listView1.Items.Add("Lista de articulos", 1);
            item.Group = listView1.Groups[2];
            item = listView1.Items.Add("Detalles", 1);
            item.Group = listView1.Groups[2];

            item = listView1.Items.Add("Delivery", 4);
            item.Group = listView1.Groups[1];

            item = listView1.Items.Add("Informe de compra", 1);
            item.Group = listView1.Groups[3];
            item = listView1.Items.Add("Informe de P / O abierto", 1);
            item.Group = listView1.Groups[3];
            item = listView1.Items.Add("AR Cash Report", 1);
            item.Group = listView1.Groups[3];

            listView1.DoDragDrop(listView1.Items.OfType<ListViewItem>().First(), DragDropEffects.Move);
            
            listView1.DoubleClick +=listView1_DoubleClick;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Selected(listView1.SelectedItems[0].Text);
        }
    }
}