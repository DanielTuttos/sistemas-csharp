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
	/// Summary description for Invoice.
	/// </summary>
	public class Invoice : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox15;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.invoiceSet invoiceSet1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private Yukon.custInvoice custInvoice1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private Yukon.proInvoice proInvoice1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private Yukon.ampInvoice ampInvoice1;
		private System.Windows.Forms.Label provinceID;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter5;
		private Yukon.driverInvoice driverInvoice1;
		private System.Windows.Forms.Label driverComm;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter6;
		private Yukon.prodInvoice prodInvoice1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label productID;
		private System.Windows.Forms.Label combo1;
		private System.Windows.Forms.Label combo2;
		private System.Windows.Forms.Label combo3;
		private System.Windows.Forms.Label combo4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Invoice()
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.combo2 = new System.Windows.Forms.Label();
			this.ampInvoice1 = new Yukon.ampInvoice();
			this.combo1 = new System.Windows.Forms.Label();
			this.proInvoice1 = new Yukon.proInvoice();
			this.provinceID = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.custInvoice1 = new Yukon.custInvoice();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.combo3 = new System.Windows.Forms.Label();
			this.driverInvoice1 = new Yukon.driverInvoice();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.combo4 = new System.Windows.Forms.Label();
			this.prodInvoice1 = new Yukon.prodInvoice();
			this.productID = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.driverComm = new System.Windows.Forms.Label();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.invoiceSet1 = new Yukon.invoiceSet();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter5 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter6 = new System.Data.OleDb.OleDbDataAdapter();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ampInvoice1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proInvoice1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.custInvoice1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.driverInvoice1)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.prodInvoice1)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.invoiceSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Invoice ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer ID";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Customer Name";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 88);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Shipping Address";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 112);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "Province";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 136);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "Ampher";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 16);
			this.label7.Name = "label7";
			this.label7.TabIndex = 6;
			this.label7.Text = "Driver Name";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 40);
			this.label8.Name = "label8";
			this.label8.TabIndex = 7;
			this.label8.Text = "Shipping Date";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 16);
			this.label9.Name = "label9";
			this.label9.TabIndex = 8;
			this.label9.Text = "Payment Type";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 64);
			this.label10.Name = "label10";
			this.label10.TabIndex = 9;
			this.label10.Text = "Arrival Date";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 16);
			this.label11.Name = "label11";
			this.label11.TabIndex = 10;
			this.label11.Text = "Description";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 40);
			this.label12.Name = "label12";
			this.label12.TabIndex = 11;
			this.label12.Text = "Product Name";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 88);
			this.label13.Name = "label13";
			this.label13.TabIndex = 12;
			this.label13.Text = "C-Rate";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 112);
			this.label14.Name = "label14";
			this.label14.TabIndex = 13;
			this.label14.Text = "L-Rate";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(8, 136);
			this.label15.Name = "label15";
			this.label15.TabIndex = 14;
			this.label15.Text = "D-Rate";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 64);
			this.label16.Name = "label16";
			this.label16.TabIndex = 15;
			this.label16.Text = "Weight";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(8, 40);
			this.label17.Name = "label17";
			this.label17.TabIndex = 16;
			this.label17.Text = "Price";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(8, 112);
			this.label18.Name = "label18";
			this.label18.TabIndex = 17;
			this.label18.Text = "Total Cost";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 136);
			this.label19.Name = "label19";
			this.label19.TabIndex = 18;
			this.label19.Text = "Amount Paid";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(8, 160);
			this.label20.Name = "label20";
			this.label20.TabIndex = 19;
			this.label20.Text = "Amount Due";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(8, 64);
			this.label21.Name = "label21";
			this.label21.TabIndex = 20;
			this.label21.Text = "Insurance";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(8, 88);
			this.label22.Name = "label22";
			this.label22.TabIndex = 21;
			this.label22.Text = "Driver Comission";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.combo2);
			this.groupBox1.Controls.Add(this.combo1);
			this.groupBox1.Controls.Add(this.provinceID);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
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
			this.groupBox1.Location = new System.Drawing.Point(16, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(424, 160);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer Information";
			// 
			// combo2
			// 
			this.combo2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ampInvoice1, "Ampher.AmpherName"));
			this.combo2.Location = new System.Drawing.Point(296, 136);
			this.combo2.Name = "combo2";
			this.combo2.TabIndex = 14;
			this.combo2.Text = "label23";
			// 
			// ampInvoice1
			// 
			this.ampInvoice1.DataSetName = "ampInvoice";
			this.ampInvoice1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// combo1
			// 
			this.combo1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proInvoice1, "Province.ProvinceName"));
			this.combo1.Location = new System.Drawing.Point(296, 128);
			this.combo1.Name = "combo1";
			this.combo1.TabIndex = 13;
			this.combo1.Text = "label23";
			// 
			// proInvoice1
			// 
			this.proInvoice1.DataSetName = "proInvoice";
			this.proInvoice1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// provinceID
			// 
			this.provinceID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proInvoice1, "Province.ProvinceID"));
			this.provinceID.Location = new System.Drawing.Point(304, 120);
			this.provinceID.Name = "provinceID";
			this.provinceID.TabIndex = 12;
			this.provinceID.Text = "provinceID";
			this.provinceID.TextChanged += new System.EventHandler(this.provinceID_TextChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.ampInvoice1;
			this.comboBox2.DisplayMember = "Ampher.AmpherName";
			this.comboBox2.Location = new System.Drawing.Point(112, 136);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(168, 21);
			this.comboBox2.TabIndex = 11;
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.proInvoice1;
			this.comboBox1.DisplayMember = "Province.ProvinceName";
			this.comboBox1.Location = new System.Drawing.Point(112, 112);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(168, 21);
			this.comboBox1.TabIndex = 10;
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custInvoice1, "Customer.Address"));
			this.textBox4.Location = new System.Drawing.Point(112, 88);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(296, 20);
			this.textBox4.TabIndex = 9;
			this.textBox4.Text = "";
			// 
			// custInvoice1
			// 
			this.custInvoice1.DataSetName = "custInvoice";
			this.custInvoice1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custInvoice1, "Customer.FirstName"));
			this.textBox3.Location = new System.Drawing.Point(112, 64);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(152, 20);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(112, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(40, 20);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(112, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(40, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.combo3);
			this.groupBox2.Controls.Add(this.dateTimePicker2);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.comboBox3);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(16, 160);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(424, 88);
			this.groupBox2.TabIndex = 23;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Transportation Details";
			// 
			// combo3
			// 
			this.combo3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverInvoice1, "Driver.FirstName"));
			this.combo3.Location = new System.Drawing.Point(288, 16);
			this.combo3.Name = "combo3";
			this.combo3.TabIndex = 13;
			this.combo3.Text = "label23";
			// 
			// driverInvoice1
			// 
			this.driverInvoice1.DataSetName = "driverInvoice";
			this.driverInvoice1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(112, 64);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.TabIndex = 12;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(112, 40);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.TabIndex = 11;
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.driverInvoice1;
			this.comboBox3.DisplayMember = "Driver.FirstName";
			this.comboBox3.Location = new System.Drawing.Point(112, 16);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(168, 21);
			this.comboBox3.TabIndex = 10;
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.combo4);
			this.groupBox3.Controls.Add(this.productID);
			this.groupBox3.Controls.Add(this.textBox9);
			this.groupBox3.Controls.Add(this.textBox8);
			this.groupBox3.Controls.Add(this.textBox7);
			this.groupBox3.Controls.Add(this.textBox6);
			this.groupBox3.Controls.Add(this.comboBox4);
			this.groupBox3.Controls.Add(this.textBox5);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(16, 248);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(424, 160);
			this.groupBox3.TabIndex = 24;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Package Information";
			// 
			// combo4
			// 
			this.combo4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodInvoice1, "Product.PorductName"));
			this.combo4.Location = new System.Drawing.Point(240, 80);
			this.combo4.Name = "combo4";
			this.combo4.TabIndex = 23;
			this.combo4.Text = "label23";
			// 
			// prodInvoice1
			// 
			this.prodInvoice1.DataSetName = "prodInvoice";
			this.prodInvoice1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// productID
			// 
			this.productID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodInvoice1, "Product.ProductID"));
			this.productID.Location = new System.Drawing.Point(296, 48);
			this.productID.Name = "productID";
			this.productID.TabIndex = 22;
			this.productID.Text = "productID";
			// 
			// textBox9
			// 
			this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ampInvoice1, "Ampher.DRate"));
			this.textBox9.Location = new System.Drawing.Point(112, 136);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(40, 20);
			this.textBox9.TabIndex = 21;
			this.textBox9.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ampInvoice1, "Ampher.LRate"));
			this.textBox8.Location = new System.Drawing.Point(112, 112);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(40, 20);
			this.textBox8.TabIndex = 20;
			this.textBox8.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ampInvoice1, "Ampher.CRate"));
			this.textBox7.Location = new System.Drawing.Point(112, 88);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(40, 20);
			this.textBox7.TabIndex = 19;
			this.textBox7.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodInvoice1, "Product.Weight"));
			this.textBox6.Location = new System.Drawing.Point(112, 64);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(64, 20);
			this.textBox6.TabIndex = 18;
			this.textBox6.Text = "";
			this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// comboBox4
			// 
			this.comboBox4.DataSource = this.prodInvoice1;
			this.comboBox4.DisplayMember = "Product.PorductName";
			this.comboBox4.Location = new System.Drawing.Point(112, 40);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(168, 21);
			this.comboBox4.TabIndex = 17;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(112, 16);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(296, 20);
			this.textBox5.TabIndex = 16;
			this.textBox5.Text = "";
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
			this.groupBox4.Controls.Add(this.driverComm);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(16, 408);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(424, 184);
			this.groupBox4.TabIndex = 25;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Payment Details";
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(112, 160);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(160, 20);
			this.textBox15.TabIndex = 28;
			this.textBox15.Text = "0";
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(112, 136);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(160, 20);
			this.textBox14.TabIndex = 27;
			this.textBox14.Text = "0";
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(112, 112);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(160, 20);
			this.textBox13.TabIndex = 26;
			this.textBox13.Text = "";
			// 
			// textBox12
			// 
			this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverInvoice1, "Driver.Commision"));
			this.textBox12.Location = new System.Drawing.Point(112, 88);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(160, 20);
			this.textBox12.TabIndex = 25;
			this.textBox12.Text = "";
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(112, 64);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(160, 20);
			this.textBox11.TabIndex = 24;
			this.textBox11.Text = "";
			this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(112, 40);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(160, 20);
			this.textBox10.TabIndex = 23;
			this.textBox10.Text = "";
			// 
			// comboBox5
			// 
			this.comboBox5.Items.AddRange(new object[] {
														   "Cash",
														   "Credit"});
			this.comboBox5.Location = new System.Drawing.Point(112, 16);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(72, 21);
			this.comboBox5.TabIndex = 22;
			this.comboBox5.Text = "Credit";
			this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
			// 
			// driverComm
			// 
			this.driverComm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverInvoice1, "Driver.Commision"));
			this.driverComm.Location = new System.Drawing.Point(288, 88);
			this.driverComm.Name = "driverComm";
			this.driverComm.TabIndex = 13;
			this.driverComm.Text = "driverComm";
			this.driverComm.TextChanged += new System.EventHandler(this.driverComm_TextChanged);
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
			// invoiceSet1
			// 
			this.invoiceSet1.DataSetName = "invoiceSet";
			this.invoiceSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT Address, City, CRate, CustomerID, CustomerStatus, Email, Fax, FirstName, L" +
				"astName, Phone, Zipcode FROM Customer";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Customer(Address, City, CRate, CustomerStatus, Email, Fax, FirstName," +
				" LastName, Phone, Zipcode) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("CRate", System.Data.OleDb.OleDbType.Double, 0, "CRate"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerStatus"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 50, "Email"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 50, "Fax"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Integer, 0, "Phone"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Zipcode", System.Data.OleDb.OleDbType.Integer, 0, "Zipcode"));
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE Customer SET Address = ?, City = ?, CRate = ?, CustomerStatus = ?, Email = ?, Fax = ?, FirstName = ?, LastName = ?, Phone = ?, Zipcode = ? WHERE (CustomerID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (CRate = ? OR ? IS NULL AND CRate IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (CustomerStatus = ? OR ? IS NULL AND CustomerStatus IS NULL) AND (Email = ? OR ? IS NULL AND Email IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (Zipcode = ? OR ? IS NULL AND Zipcode IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("CRate", System.Data.OleDb.OleDbType.Double, 0, "CRate"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerStatus"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 50, "Email"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 50, "Fax"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Integer, 0, "Phone"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Zipcode", System.Data.OleDb.OleDbType.Integer, 0, "Zipcode"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerStatus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerStatus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Email", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Email", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Zipcode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Zipcode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Zipcode1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Zipcode", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM Customer WHERE (CustomerID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (CRate = ? OR ? IS NULL AND CRate IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (CustomerStatus = ? OR ? IS NULL AND CustomerStatus IS NULL) AND (Email = ? OR ? IS NULL AND Email IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (Zipcode = ? OR ? IS NULL AND Zipcode IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerStatus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerStatus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Email", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Email", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Zipcode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Zipcode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Zipcode1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Zipcode", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Customer", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																					new System.Data.Common.DataColumnMapping("City", "City"),
																																																					new System.Data.Common.DataColumnMapping("CRate", "CRate"),
																																																					new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
																																																					new System.Data.Common.DataColumnMapping("CustomerStatus", "CustomerStatus"),
																																																					new System.Data.Common.DataColumnMapping("Email", "Email"),
																																																					new System.Data.Common.DataColumnMapping("Fax", "Fax"),
																																																					new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
																																																					new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																					new System.Data.Common.DataColumnMapping("Phone", "Phone"),
																																																					new System.Data.Common.DataColumnMapping("Zipcode", "Zipcode")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = "SELECT ProvinceID, ProvinceName FROM Province";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand3
			// 
			this.oleDbInsertCommand3.CommandText = "INSERT INTO Province(ProvinceName) VALUES (?)";
			this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, "ProvinceName"));
			// 
			// oleDbUpdateCommand3
			// 
			this.oleDbUpdateCommand3.CommandText = "UPDATE Province SET ProvinceName = ? WHERE (ProvinceID = ?) AND (ProvinceName = ?" +
				" OR ? IS NULL AND ProvinceName IS NULL)";
			this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, "ProvinceName"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand3
			// 
			this.oleDbDeleteCommand3.CommandText = "DELETE FROM Province WHERE (ProvinceID = ?) AND (ProvinceName = ? OR ? IS NULL AN" +
				"D ProvinceName IS NULL)";
			this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
			this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Province", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("ProvinceID", "ProvinceID"),
																																																					new System.Data.Common.DataColumnMapping("ProvinceName", "ProvinceName")})});
			this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
			// 
			// oleDbSelectCommand4
			// 
			this.oleDbSelectCommand4.CommandText = "SELECT AmpherID, AmpherName, CRate, DRate, LRate, ProvinceID FROM Ampher";
			this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand4
			// 
			this.oleDbInsertCommand4.CommandText = "INSERT INTO Ampher(AmpherName, CRate, DRate, LRate, ProvinceID) VALUES (?, ?, ?, " +
				"?, ?)";
			this.oleDbInsertCommand4.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("AmpherName", System.Data.OleDb.OleDbType.VarWChar, 50, "AmpherName"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("CRate", System.Data.OleDb.OleDbType.VarChar, 50, "CRate"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("DRate", System.Data.OleDb.OleDbType.VarChar, 50, "DRate"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("LRate", System.Data.OleDb.OleDbType.VarChar, 50, "LRate"));
			this.oleDbInsertCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProvinceID", System.Data.OleDb.OleDbType.Integer, 0, "ProvinceID"));
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.InsertCommand = this.oleDbInsertCommand4;
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Ampher", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("AmpherID", "AmpherID"),
																																																				  new System.Data.Common.DataColumnMapping("AmpherName", "AmpherName"),
																																																				  new System.Data.Common.DataColumnMapping("CRate", "CRate"),
																																																				  new System.Data.Common.DataColumnMapping("DRate", "DRate"),
																																																				  new System.Data.Common.DataColumnMapping("LRate", "LRate"),
																																																				  new System.Data.Common.DataColumnMapping("ProvinceID", "ProvinceID")})});
			// 
			// oleDbSelectCommand5
			// 
			this.oleDbSelectCommand5.CommandText = "SELECT Address, Commision, DriverID, FirstName, LastName, Salary FROM Driver";
			this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand5
			// 
			this.oleDbInsertCommand5.CommandText = "INSERT INTO Driver(Address, Commision, FirstName, LastName, Salary) VALUES (?, ?," +
				" ?, ?, ?)";
			this.oleDbInsertCommand5.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commision", System.Data.OleDb.OleDbType.Currency, 0, "Commision"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Currency, 0, "Salary"));
			// 
			// oleDbUpdateCommand4
			// 
			this.oleDbUpdateCommand4.CommandText = @"UPDATE Driver SET Address = ?, Commision = ?, FirstName = ?, LastName = ?, Salary = ? WHERE (DriverID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (Commision = ? OR ? IS NULL AND Commision IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Salary = ? OR ? IS NULL AND Salary IS NULL)";
			this.oleDbUpdateCommand4.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commision", System.Data.OleDb.OleDbType.Currency, 0, "Commision"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Currency, 0, "Salary"));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commision", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commision1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Salary", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salary1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Salary", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand4
			// 
			this.oleDbDeleteCommand4.CommandText = @"DELETE FROM Driver WHERE (DriverID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (Commision = ? OR ? IS NULL AND Commision IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Salary = ? OR ? IS NULL AND Salary IS NULL)";
			this.oleDbDeleteCommand4.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commision", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commision1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Salary", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand4.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salary1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Salary", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter5
			// 
			this.oleDbDataAdapter5.DeleteCommand = this.oleDbDeleteCommand4;
			this.oleDbDataAdapter5.InsertCommand = this.oleDbInsertCommand5;
			this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
			this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Driver", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																				  new System.Data.Common.DataColumnMapping("Commision", "Commision"),
																																																				  new System.Data.Common.DataColumnMapping("DriverID", "DriverID"),
																																																				  new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
																																																				  new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																				  new System.Data.Common.DataColumnMapping("Salary", "Salary")})});
			this.oleDbDataAdapter5.UpdateCommand = this.oleDbUpdateCommand4;
			// 
			// oleDbSelectCommand6
			// 
			this.oleDbSelectCommand6.CommandText = "SELECT PorductName, ProductID, Weight FROM Product";
			this.oleDbSelectCommand6.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand6
			// 
			this.oleDbInsertCommand6.CommandText = "INSERT INTO Product(PorductName, Weight) VALUES (?, ?)";
			this.oleDbInsertCommand6.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("PorductName", System.Data.OleDb.OleDbType.VarWChar, 50, "PorductName"));
			this.oleDbInsertCommand6.Parameters.Add(new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.Integer, 0, "Weight"));
			// 
			// oleDbUpdateCommand5
			// 
			this.oleDbUpdateCommand5.CommandText = "UPDATE Product SET PorductName = ?, Weight = ? WHERE (ProductID = ?) AND (Porduct" +
				"Name = ? OR ? IS NULL AND PorductName IS NULL) AND (Weight = ? OR ? IS NULL AND " +
				"Weight IS NULL)";
			this.oleDbUpdateCommand5.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("PorductName", System.Data.OleDb.OleDbType.VarWChar, 50, "PorductName"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.Integer, 0, "Weight"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PorductName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorductName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PorductName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorductName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand5
			// 
			this.oleDbDeleteCommand5.CommandText = "DELETE FROM Product WHERE (ProductID = ?) AND (PorductName = ? OR ? IS NULL AND P" +
				"orductName IS NULL) AND (Weight = ? OR ? IS NULL AND Weight IS NULL)";
			this.oleDbDeleteCommand5.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PorductName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorductName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PorductName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorductName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter6
			// 
			this.oleDbDataAdapter6.DeleteCommand = this.oleDbDeleteCommand5;
			this.oleDbDataAdapter6.InsertCommand = this.oleDbInsertCommand6;
			this.oleDbDataAdapter6.SelectCommand = this.oleDbSelectCommand6;
			this.oleDbDataAdapter6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Product", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("PorductName", "PorductName"),
																																																				   new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																				   new System.Data.Common.DataColumnMapping("Weight", "Weight")})});
			this.oleDbDataAdapter6.UpdateCommand = this.oleDbUpdateCommand5;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(360, 592);
			this.button1.Name = "button1";
			this.button1.TabIndex = 26;
			this.button1.Text = "&Submit";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(272, 592);
			this.button2.Name = "button2";
			this.button2.TabIndex = 27;
			this.button2.Text = "&Cancel";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Invoice
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(456, 622);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Invoice";
			this.Text = "Invoice Inormation";
			this.Load += new System.EventHandler(this.Invoice_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ampInvoice1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proInvoice1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.custInvoice1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.driverInvoice1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.prodInvoice1)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.invoiceSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Invoice_Load(object sender, System.EventArgs e)
		{
			this.provinceID.Hide();
			this.driverComm.Hide();
			this.productID.Hide();
			this.combo1.Hide();
			this.combo2.Hide();
			this.combo3.Hide();
			this.combo4.Hide();
			this.oleDbDataAdapter1.Fill(invoiceSet1);
			this.oleDbDataAdapter3.Fill(proInvoice1);
			this.oleDbDataAdapter4.Fill(ampInvoice1);
			this.oleDbDataAdapter5.Fill(driverInvoice1);
			this.oleDbDataAdapter6.Fill(prodInvoice1);
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
			string query = "";
			query = "SELECT * FROM CUSTOMER WHERE CustomerID LIKE('%" + textBox2.Text + "%')";
			OleDbDataAdapter cmdAdapter = new OleDbDataAdapter();
			OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
			cmdAdapter.SelectCommand =cmd;
			cmdAdapter.SelectCommand.CommandType = CommandType.Text;
			this.oleDbConnection1.Open();
			custInvoice1.Clear();
			cmdAdapter.Fill(custInvoice1,"Customer");
			this.oleDbConnection1.Close();
		}

		private void provinceID_TextChanged(object sender, System.EventArgs e)
		{
			string query = "";
			query = "SELECT * FROM AMPHER WHERE ProvinceID =" + provinceID.Text + ";";
			OleDbDataAdapter cmdAdapter = new OleDbDataAdapter();
			OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
			cmdAdapter.SelectCommand =cmd;
			cmdAdapter.SelectCommand.CommandType = CommandType.Text;
			this.oleDbConnection1.Open();
			ampInvoice1.Clear();
			cmdAdapter.Fill(ampInvoice1,"Ampher");
			this.oleDbConnection1.Close();
		}

		private void driverComm_TextChanged(object sender, System.EventArgs e)
		{
			textBox12.Text = driverComm.Text;
		}

		private void textBox6_TextChanged(object sender, System.EventArgs e)
		{
			double weight = Convert.ToDouble(textBox6.Text);
			double crate = Convert.ToDouble(textBox7.Text);
			double drate = Convert.ToDouble(textBox8.Text);
			double lrate = Convert.ToDouble(textBox9.Text);
			double tempCalc = (crate+drate+lrate);
			if (tempCalc >= 1.5)
				tempCalc = 1.5;
			else if (tempCalc <= 0.5)
				tempCalc = 0.5;
			else
			{
			}

			double price = weight * tempCalc;
			double insurance = (3 * price)/100;
			double driComm = (10 * price)/100;
			textBox10.Text = price.ToString();
			textBox11.Text = insurance.ToString();
			textBox12.Text = driComm.ToString();
		}

		private void textBox11_TextChanged(object sender, System.EventArgs e)
		{
			double price = Convert.ToDouble(textBox10.Text);
			double insurance = Convert.ToDouble(textBox11.Text);
			double driver = Convert.ToDouble(textBox12.Text);
			double total = price + insurance + driver;
			textBox13.Text = total.ToString();
		}

		private void comboBox5_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.comboBox5.SelectedItem=="Cash")
			{
				label20.Hide();
				textBox15.Hide();
			}
			else
			{
				label20.Show();
				textBox15.Show();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to do this order?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				OleDbCommand cmd = new OleDbCommand("INSERT INTO INVOICE(CustomerID,CustomerName,Address,ProvinceName,AmpherName,DriverName,DriverCommision,ShippingDate,PaymentType,ArrivalDate,Description,TotalCost,AmountPaid,AmountDue,ProductID,ProductName,Insurance,CRate,LRate,DRate,Weight,Price) VALUES("+textBox2.Text+",'"+textBox3.Text+"','"+textBox4.Text+"','"+combo1.Text+"','"+combo2.Text+"','"+combo3.Text+"',"+textBox12.Text+",'"+dateTimePicker1.Value+"','"+comboBox5.SelectedItem+"','"+dateTimePicker2.Value+"','"+textBox5.Text+"',"+textBox13.Text+","+textBox14.Text+","+textBox15.Text+","+productID.Text+",'"+combo4.Text+"',"+textBox11.Text+","+textBox7.Text+","+textBox8.Text+","+textBox9.Text+","+textBox6.Text+","+textBox10.Text+");", this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
	}
}
