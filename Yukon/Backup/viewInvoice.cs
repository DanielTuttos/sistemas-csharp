using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Yukon
{
	/// <summary>
	/// Summary description for viewInvoice.
	/// </summary>
	public class viewInvoice : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.invView invView1;
		private System.Windows.Forms.TextBox provBox16;
		private System.Windows.Forms.TextBox ampherBox17;
		private System.Windows.Forms.TextBox driverBox16;
		private System.Windows.Forms.TextBox productBox16;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public viewInvoice()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.invView1 = new Yukon.invView();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.productBox16 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.driverBox16 = new System.Windows.Forms.TextBox();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ampherBox17 = new System.Windows.Forms.TextBox();
			this.provBox16 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.invView1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.textBox15);
			this.groupBox4.Controls.Add(this.textBox14);
			this.groupBox4.Controls.Add(this.textBox13);
			this.groupBox4.Controls.Add(this.textBox12);
			this.groupBox4.Controls.Add(this.textBox11);
			this.groupBox4.Controls.Add(this.textBox10);
			this.groupBox4.Controls.Add(this.comboBox5);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(16, 528);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(424, 200);
			this.groupBox4.TabIndex = 29;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Payment Details";
			// 
			// textBox15
			// 
			this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.AmountDue"));
			this.textBox15.Location = new System.Drawing.Point(112, 168);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(160, 20);
			this.textBox15.TabIndex = 28;
			this.textBox15.Text = "0";
			// 
			// invView1
			// 
			this.invView1.DataSetName = "invView";
			this.invView1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// textBox14
			// 
			this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.AmountPaid"));
			this.textBox14.Location = new System.Drawing.Point(112, 144);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(160, 20);
			this.textBox14.TabIndex = 27;
			this.textBox14.Text = "0";
			// 
			// textBox13
			// 
			this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.TotalCost"));
			this.textBox13.Location = new System.Drawing.Point(112, 120);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(160, 20);
			this.textBox13.TabIndex = 26;
			this.textBox13.Text = "";
			// 
			// textBox12
			// 
			this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.DriverCommision"));
			this.textBox12.Location = new System.Drawing.Point(112, 96);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(160, 20);
			this.textBox12.TabIndex = 25;
			this.textBox12.Text = "";
			// 
			// textBox11
			// 
			this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.Insurance"));
			this.textBox11.Location = new System.Drawing.Point(112, 72);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(160, 20);
			this.textBox11.TabIndex = 24;
			this.textBox11.Text = "";
			// 
			// textBox10
			// 
			this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.Price"));
			this.textBox10.Location = new System.Drawing.Point(112, 48);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(160, 20);
			this.textBox10.TabIndex = 23;
			this.textBox10.Text = "";
			// 
			// comboBox5
			// 
			this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.invView1, "Invoice.PaymentType"));
			this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invView1, "Invoice.PaymentType"));
			this.comboBox5.Items.AddRange(new object[] {
														   "Cash",
														   "Credit"});
			this.comboBox5.Location = new System.Drawing.Point(112, 24);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(72, 21);
			this.comboBox5.TabIndex = 22;
			this.comboBox5.Text = "Credit";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 24);
			this.label9.Name = "label9";
			this.label9.TabIndex = 8;
			this.label9.Text = "Payment Type";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(8, 48);
			this.label17.Name = "label17";
			this.label17.TabIndex = 16;
			this.label17.Text = "Price";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(8, 120);
			this.label18.Name = "label18";
			this.label18.TabIndex = 17;
			this.label18.Text = "Total Cost";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 144);
			this.label19.Name = "label19";
			this.label19.TabIndex = 18;
			this.label19.Text = "Amount Paid";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(8, 168);
			this.label20.Name = "label20";
			this.label20.TabIndex = 19;
			this.label20.Text = "Amount Due";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 72);
			this.label21.Name = "label21";
			this.label21.TabIndex = 20;
			this.label21.Text = "Insurance";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(8, 96);
			this.label22.Name = "label22";
			this.label22.TabIndex = 21;
			this.label22.Text = "Driver Comission";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.groupBox3.Controls.Add(this.productBox16);
			this.groupBox3.Controls.Add(this.textBox9);
			this.groupBox3.Controls.Add(this.textBox8);
			this.groupBox3.Controls.Add(this.textBox7);
			this.groupBox3.Controls.Add(this.textBox6);
			this.groupBox3.Controls.Add(this.textBox5);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(16, 344);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(424, 176);
			this.groupBox3.TabIndex = 28;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Package Information";
			// 
			// productBox16
			// 
			this.productBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.ProductName"));
			this.productBox16.Location = new System.Drawing.Point(112, 48);
			this.productBox16.Name = "productBox16";
			this.productBox16.Size = new System.Drawing.Size(128, 20);
			this.productBox16.TabIndex = 22;
			this.productBox16.Text = "";
			// 
			// textBox9
			// 
			this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.DRate"));
			this.textBox9.Location = new System.Drawing.Point(112, 144);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(40, 20);
			this.textBox9.TabIndex = 21;
			this.textBox9.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.LRate"));
			this.textBox8.Location = new System.Drawing.Point(112, 120);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(40, 20);
			this.textBox8.TabIndex = 20;
			this.textBox8.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.CRate"));
			this.textBox7.Location = new System.Drawing.Point(112, 96);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(40, 20);
			this.textBox7.TabIndex = 19;
			this.textBox7.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.Weight"));
			this.textBox6.Location = new System.Drawing.Point(112, 72);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(64, 20);
			this.textBox6.TabIndex = 18;
			this.textBox6.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.Description"));
			this.textBox5.Location = new System.Drawing.Point(112, 24);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(296, 20);
			this.textBox5.TabIndex = 16;
			this.textBox5.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 48);
			this.label12.Name = "label12";
			this.label12.TabIndex = 11;
			this.label12.Text = "Product Name";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 24);
			this.label11.Name = "label11";
			this.label11.TabIndex = 10;
			this.label11.Text = "Description";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 72);
			this.label16.Name = "label16";
			this.label16.TabIndex = 15;
			this.label16.Text = "Weight";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 96);
			this.label13.Name = "label13";
			this.label13.TabIndex = 12;
			this.label13.Text = "C-Rate";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 120);
			this.label14.Name = "label14";
			this.label14.TabIndex = 13;
			this.label14.Text = "L-Rate";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(8, 144);
			this.label15.Name = "label15";
			this.label15.TabIndex = 14;
			this.label15.Text = "D-Rate";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.driverBox16);
			this.groupBox2.Controls.Add(this.dateTimePicker2);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(16, 232);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(424, 104);
			this.groupBox2.TabIndex = 27;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Transportation Details";
			// 
			// driverBox16
			// 
			this.driverBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.DriverName"));
			this.driverBox16.Location = new System.Drawing.Point(112, 24);
			this.driverBox16.Name = "driverBox16";
			this.driverBox16.Size = new System.Drawing.Size(128, 20);
			this.driverBox16.TabIndex = 14;
			this.driverBox16.Text = "";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invView1, "Invoice.ArrivalDate"));
			this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.ArrivalDate"));
			this.dateTimePicker2.Location = new System.Drawing.Point(112, 72);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.TabIndex = 12;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.ShippingDate"));
			this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invView1, "Invoice.ShippingDate"));
			this.dateTimePicker1.Location = new System.Drawing.Point(112, 48);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 24);
			this.label7.Name = "label7";
			this.label7.TabIndex = 6;
			this.label7.Text = "Driver Name";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 48);
			this.label8.Name = "label8";
			this.label8.TabIndex = 7;
			this.label8.Text = "Shipping Date";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 72);
			this.label10.Name = "label10";
			this.label10.TabIndex = 9;
			this.label10.Text = "Arrival Date";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ampherBox17);
			this.groupBox1.Controls.Add(this.provBox16);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(16, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(424, 176);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer Information";
			// 
			// ampherBox17
			// 
			this.ampherBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.AmpherName"));
			this.ampherBox17.Location = new System.Drawing.Point(112, 144);
			this.ampherBox17.Name = "ampherBox17";
			this.ampherBox17.Size = new System.Drawing.Size(128, 20);
			this.ampherBox17.TabIndex = 11;
			this.ampherBox17.Text = "";
			// 
			// provBox16
			// 
			this.provBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.ProvinceName"));
			this.provBox16.Location = new System.Drawing.Point(112, 120);
			this.provBox16.Name = "provBox16";
			this.provBox16.Size = new System.Drawing.Size(128, 20);
			this.provBox16.TabIndex = 10;
			this.provBox16.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.Address"));
			this.textBox4.Location = new System.Drawing.Point(112, 96);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(296, 20);
			this.textBox4.TabIndex = 9;
			this.textBox4.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.CustomerName"));
			this.textBox3.Location = new System.Drawing.Point(112, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(152, 20);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.CustomerID"));
			this.textBox2.Location = new System.Drawing.Point(112, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(40, 20);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invView1, "Invoice.InvoiceID"));
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(112, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(40, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer ID";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 144);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "Ampher";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 96);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Shipping Address";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Invoice ID";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Customer Name";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 120);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "Province";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = @"SELECT Address, AmountDue, AmountPaid, AmpherName, ArrivalDate, CRate, CustomerID, CustomerName, Description, DRate, DriverCommision, DriverName, Insurance, InvoiceID, LRate, PaymentType, Price, ProductID, ProductName, ProvinceName, ShippingDate, TotalCost, Weight FROM Invoice";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source="".\db\yukon.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = @"INSERT INTO Invoice(Address, AmountDue, AmountPaid, AmpherName, ArrivalDate, CRate, CustomerID, CustomerName, Description, DRate, DriverCommision, DriverName, Insurance, LRate, PaymentType, Price, ProductID, ProductName, ProvinceName, ShippingDate, TotalCost, Weight) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 250, "Address"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("AmountDue", System.Data.OleDb.OleDbType.Currency, 0, "AmountDue"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("AmountPaid", System.Data.OleDb.OleDbType.Currency, 0, "AmountPaid"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("AmpherName", System.Data.OleDb.OleDbType.VarWChar, 50, "AmpherName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ArrivalDate", System.Data.OleDb.OleDbType.DBDate, 0, "ArrivalDate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CRate", System.Data.OleDb.OleDbType.Double, 0, "CRate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.Integer, 0, "CustomerID"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DRate", System.Data.OleDb.OleDbType.Double, 0, "DRate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DriverCommision", System.Data.OleDb.OleDbType.Currency, 0, "DriverCommision"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DriverName", System.Data.OleDb.OleDbType.VarWChar, 50, "DriverName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Insurance", System.Data.OleDb.OleDbType.Currency, 0, "Insurance"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LRate", System.Data.OleDb.OleDbType.Double, 0, "LRate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PaymentType", System.Data.OleDb.OleDbType.VarWChar, 50, "PaymentType"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, "ProvinceName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShippingDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippingDate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TotalCost", System.Data.OleDb.OleDbType.Currency, 0, "TotalCost"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.Integer, 0, "Weight"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE Invoice SET Address = ?, AmountDue = ?, AmountPaid = ?, AmpherName = ?, Ar" +
				"rivalDate = ?, CRate = ?, CustomerID = ?, CustomerName = ?, Description = ?, DRa" +
				"te = ?, DriverCommision = ?, DriverName = ?, Insurance = ?, LRate = ?, PaymentTy" +
				"pe = ?, Price = ?, ProductID = ?, ProductName = ?, ProvinceName = ?, ShippingDat" +
				"e = ?, TotalCost = ?, Weight = ? WHERE (InvoiceID = ?) AND (Address = ? OR ? IS " +
				"NULL AND Address IS NULL) AND (AmountDue = ? OR ? IS NULL AND AmountDue IS NULL)" +
				" AND (AmountPaid = ? OR ? IS NULL AND AmountPaid IS NULL) AND (AmpherName = ? OR" +
				" ? IS NULL AND AmpherName IS NULL) AND (ArrivalDate = ? OR ? IS NULL AND Arrival" +
				"Date IS NULL) AND (CRate = ? OR ? IS NULL AND CRate IS NULL) AND (CustomerID = ?" +
				" OR ? IS NULL AND CustomerID IS NULL) AND (CustomerName = ? OR ? IS NULL AND Cus" +
				"tomerName IS NULL) AND (DRate = ? OR ? IS NULL AND DRate IS NULL) AND (Descripti" +
				"on = ? OR ? IS NULL AND Description IS NULL) AND (DriverCommision = ? OR ? IS NU" +
				"LL AND DriverCommision IS NULL) AND (DriverName = ? OR ? IS NULL AND DriverName " +
				"IS NULL) AND (Insurance = ? OR ? IS NULL AND Insurance IS NULL) AND (LRate = ? O" +
				"R ? IS NULL AND LRate IS NULL) AND (PaymentType = ? OR ? IS NULL AND PaymentType" +
				" IS NULL) AND (Price = ? OR ? IS NULL AND Price IS NULL) AND (ProductID = ? OR ?" +
				" IS NULL AND ProductID IS NULL) AND (ProductName = ? OR ? IS NULL AND ProductNam" +
				"e IS NULL) AND (ProvinceName = ? OR ? IS NULL AND ProvinceName IS NULL) AND (Shi" +
				"ppingDate = ? OR ? IS NULL AND ShippingDate IS NULL) AND (TotalCost = ? OR ? IS " +
				"NULL AND TotalCost IS NULL) AND (Weight = ? OR ? IS NULL AND Weight IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 250, "Address"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("AmountDue", System.Data.OleDb.OleDbType.Currency, 0, "AmountDue"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("AmountPaid", System.Data.OleDb.OleDbType.Currency, 0, "AmountPaid"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("AmpherName", System.Data.OleDb.OleDbType.VarWChar, 50, "AmpherName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ArrivalDate", System.Data.OleDb.OleDbType.DBDate, 0, "ArrivalDate"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CRate", System.Data.OleDb.OleDbType.Double, 0, "CRate"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.Integer, 0, "CustomerID"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DRate", System.Data.OleDb.OleDbType.Double, 0, "DRate"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DriverCommision", System.Data.OleDb.OleDbType.Currency, 0, "DriverCommision"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DriverName", System.Data.OleDb.OleDbType.VarWChar, 50, "DriverName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Insurance", System.Data.OleDb.OleDbType.Currency, 0, "Insurance"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LRate", System.Data.OleDb.OleDbType.Double, 0, "LRate"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PaymentType", System.Data.OleDb.OleDbType.VarWChar, 50, "PaymentType"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, "ProvinceName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShippingDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippingDate"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TotalCost", System.Data.OleDb.OleDbType.Currency, 0, "TotalCost"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.Integer, 0, "Weight"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_InvoiceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "InvoiceID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmountDue", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmountDue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmountDue1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmountDue", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmountPaid", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmountPaid", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmountPaid1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmountPaid", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmpherName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmpherName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmpherName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmpherName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ArrivalDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ArrivalDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ArrivalDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ArrivalDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DRate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DRate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverCommision", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverCommision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverCommision1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverCommision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Insurance", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Insurance", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Insurance1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Insurance", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LRate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LRate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PaymentType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PaymentType", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PaymentType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PaymentType", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Price", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Price", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShippingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippingDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShippingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippingDate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TotalCost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalCost", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TotalCost1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalCost", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM Invoice WHERE (InvoiceID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (AmountDue = ? OR ? IS NULL AND AmountDue IS NULL) AND (AmountPaid = ? OR ? IS NULL AND AmountPaid IS NULL) AND (AmpherName = ? OR ? IS NULL AND AmpherName IS NULL) AND (ArrivalDate = ? OR ? IS NULL AND ArrivalDate IS NULL) AND (CRate = ? OR ? IS NULL AND CRate IS NULL) AND (CustomerID = ? OR ? IS NULL AND CustomerID IS NULL) AND (CustomerName = ? OR ? IS NULL AND CustomerName IS NULL) AND (DRate = ? OR ? IS NULL AND DRate IS NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (DriverCommision = ? OR ? IS NULL AND DriverCommision IS NULL) AND (DriverName = ? OR ? IS NULL AND DriverName IS NULL) AND (Insurance = ? OR ? IS NULL AND Insurance IS NULL) AND (LRate = ? OR ? IS NULL AND LRate IS NULL) AND (PaymentType = ? OR ? IS NULL AND PaymentType IS NULL) AND (Price = ? OR ? IS NULL AND Price IS NULL) AND (ProductID = ? OR ? IS NULL AND ProductID IS NULL) AND (ProductName = ? OR ? IS NULL AND ProductName IS NULL) AND (ProvinceName = ? OR ? IS NULL AND ProvinceName IS NULL) AND (ShippingDate = ? OR ? IS NULL AND ShippingDate IS NULL) AND (TotalCost = ? OR ? IS NULL AND TotalCost IS NULL) AND (Weight = ? OR ? IS NULL AND Weight IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_InvoiceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "InvoiceID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 250, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmountDue", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmountDue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmountDue1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmountDue", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmountPaid", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmountPaid", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmountPaid1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmountPaid", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmpherName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmpherName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AmpherName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AmpherName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ArrivalDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ArrivalDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ArrivalDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ArrivalDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DRate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DRate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Description", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverCommision", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverCommision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverCommision1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverCommision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Insurance", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Insurance", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Insurance1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Insurance", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LRate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LRate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PaymentType", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PaymentType", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PaymentType1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PaymentType", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Price", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Price", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Price1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Price", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShippingDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippingDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ShippingDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ShippingDate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TotalCost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalCost", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TotalCost1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TotalCost", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Invoice", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																				   new System.Data.Common.DataColumnMapping("AmountDue", "AmountDue"),
																																																				   new System.Data.Common.DataColumnMapping("AmountPaid", "AmountPaid"),
																																																				   new System.Data.Common.DataColumnMapping("AmpherName", "AmpherName"),
																																																				   new System.Data.Common.DataColumnMapping("ArrivalDate", "ArrivalDate"),
																																																				   new System.Data.Common.DataColumnMapping("CRate", "CRate"),
																																																				   new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
																																																				   new System.Data.Common.DataColumnMapping("CustomerName", "CustomerName"),
																																																				   new System.Data.Common.DataColumnMapping("Description", "Description"),
																																																				   new System.Data.Common.DataColumnMapping("DRate", "DRate"),
																																																				   new System.Data.Common.DataColumnMapping("DriverCommision", "DriverCommision"),
																																																				   new System.Data.Common.DataColumnMapping("DriverName", "DriverName"),
																																																				   new System.Data.Common.DataColumnMapping("Insurance", "Insurance"),
																																																				   new System.Data.Common.DataColumnMapping("InvoiceID", "InvoiceID"),
																																																				   new System.Data.Common.DataColumnMapping("LRate", "LRate"),
																																																				   new System.Data.Common.DataColumnMapping("PaymentType", "PaymentType"),
																																																				   new System.Data.Common.DataColumnMapping("Price", "Price"),
																																																				   new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																				   new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
																																																				   new System.Data.Common.DataColumnMapping("ProvinceName", "ProvinceName"),
																																																				   new System.Data.Common.DataColumnMapping("ShippingDate", "ShippingDate"),
																																																				   new System.Data.Common.DataColumnMapping("TotalCost", "TotalCost"),
																																																				   new System.Data.Common.DataColumnMapping("Weight", "Weight")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button7.Location = new System.Drawing.Point(280, 16);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(48, 23);
			this.button7.TabIndex = 33;
			this.button7.Text = "&Last";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button6.Location = new System.Drawing.Point(112, 16);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(48, 23);
			this.button6.TabIndex = 32;
			this.button6.Text = "&First";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(224, 16);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 23);
			this.button3.TabIndex = 31;
			this.button3.Text = "&Next";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(168, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 23);
			this.button2.TabIndex = 30;
			this.button2.Text = "Pre&v";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(368, 16);
			this.button1.Name = "button1";
			this.button1.TabIndex = 34;
			this.button1.Text = "&Remove";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// viewInvoice
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(456, 746);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Name = "viewInvoice";
			this.Text = "Invoice Information";
			this.Load += new System.EventHandler(this.viewInvoice_Load);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.invView1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void viewInvoice_Load(object sender, System.EventArgs e)
		{
			this.oleDbDataAdapter1.Fill(invView1);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[invView1,"Invoice"].Position+=1;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[invView1,"Invoice"].Position-=1;
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[invView1,"Invoice"].Position=0;
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			int records = this.BindingContext[invView1,"Invoice"].Count;
			this.BindingContext[invView1,"Invoice"].Position=records;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to delete this Invoice?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query = "";
				query = "DELETE FROM INVOICE WHERE(InvoiceID=" + textBox1.Text + ")";
				OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
	}
}
