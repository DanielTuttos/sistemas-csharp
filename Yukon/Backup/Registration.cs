using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Yukon
{
	/// <summary>
	/// Summary description for Registration.
	/// </summary>
	public class Registration : System.Windows.Forms.Form
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.custSet custSet1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Registration()
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.custSet1 = new Yukon.custSet();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.custSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "First Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Last Name";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 96);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Status";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 120);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "Address";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 144);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "Postal Code";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 168);
			this.label7.Name = "label7";
			this.label7.TabIndex = 6;
			this.label7.Text = "City";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 192);
			this.label8.Name = "label8";
			this.label8.TabIndex = 7;
			this.label8.Text = "Phone";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 216);
			this.label9.Name = "label9";
			this.label9.TabIndex = 8;
			this.label9.Text = "Fax";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(8, 240);
			this.label10.Name = "label10";
			this.label10.TabIndex = 9;
			this.label10.Text = "C-Rate";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(8, 264);
			this.label11.Name = "label11";
			this.label11.TabIndex = 10;
			this.label11.Text = "E-Mail";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custSet1, "Customer.CustomerID"));
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(96, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(40, 20);
			this.textBox1.TabIndex = 11;
			this.textBox1.Text = "";
			// 
			// custSet1
			// 
			this.custSet1.DataSetName = "custSet";
			this.custSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custSet1, "Customer.FirstName"));
			this.textBox2.Location = new System.Drawing.Point(96, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(152, 20);
			this.textBox2.TabIndex = 12;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custSet1, "Customer.LastName"));
			this.textBox3.Location = new System.Drawing.Point(96, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(152, 20);
			this.textBox3.TabIndex = 13;
			this.textBox3.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custSet1, "Customer.Address"));
			this.textBox5.Location = new System.Drawing.Point(96, 120);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(280, 20);
			this.textBox5.TabIndex = 15;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custSet1, "Customer.Zipcode"));
			this.textBox6.Location = new System.Drawing.Point(96, 144);
			this.textBox6.Name = "textBox6";
			this.textBox6.TabIndex = 16;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custSet1, "Customer.City"));
			this.textBox7.Location = new System.Drawing.Point(96, 168);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(136, 20);
			this.textBox7.TabIndex = 17;
			this.textBox7.Text = "";
			// 
			// textBox8
			// 
			this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custSet1, "Customer.Phone"));
			this.textBox8.Location = new System.Drawing.Point(96, 192);
			this.textBox8.Name = "textBox8";
			this.textBox8.TabIndex = 18;
			this.textBox8.Text = "";
			// 
			// textBox9
			// 
			this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custSet1, "Customer.Fax"));
			this.textBox9.Location = new System.Drawing.Point(96, 216);
			this.textBox9.Name = "textBox9";
			this.textBox9.TabIndex = 19;
			this.textBox9.Text = "";
			// 
			// textBox10
			// 
			this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custSet1, "Customer.CRate"));
			this.textBox10.Location = new System.Drawing.Point(96, 240);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(40, 20);
			this.textBox10.TabIndex = 20;
			this.textBox10.Text = "";
			// 
			// textBox11
			// 
			this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custSet1, "Customer.Email"));
			this.textBox11.Location = new System.Drawing.Point(96, 264);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(280, 20);
			this.textBox11.TabIndex = 21;
			this.textBox11.Text = "";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(304, 296);
			this.button1.Name = "button1";
			this.button1.TabIndex = 22;
			this.button1.Text = "&Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.custSet1, "Customer.CustomerStatus"));
			this.comboBox1.Items.AddRange(new object[] {
														   "New Customer",
														   "Good Customer",
														   "Normal Customer",
														   "Bad Customer"});
			this.comboBox1.Location = new System.Drawing.Point(96, 96);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 25;
			this.comboBox1.Text = "New Customer";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Address, City, CRate, CustomerID, CustomerStatus, Email, Fax, FirstName, L" +
				"astName, Phone, Zipcode FROM Customer";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source="".\db\yukon.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Customer(Address, City, CRate, CustomerStatus, Email, Fax, FirstName," +
				" LastName, Phone, Zipcode) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CRate", System.Data.OleDb.OleDbType.Double, 0, "CRate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerStatus"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 50, "Email"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 50, "Fax"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Integer, 0, "Phone"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Zipcode", System.Data.OleDb.OleDbType.Integer, 0, "Zipcode"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE Customer SET Address = ?, City = ?, CRate = ?, CustomerStatus = ?, Email = ?, Fax = ?, FirstName = ?, LastName = ?, Phone = ?, Zipcode = ? WHERE (CustomerID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (CRate = ? OR ? IS NULL AND CRate IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (CustomerStatus = ? OR ? IS NULL AND CustomerStatus IS NULL) AND (Email = ? OR ? IS NULL AND Email IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (Zipcode = ? OR ? IS NULL AND Zipcode IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 50, "City"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CRate", System.Data.OleDb.OleDbType.Double, 0, "CRate"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerStatus", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerStatus"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 50, "Email"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 50, "Fax"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.Integer, 0, "Phone"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Zipcode", System.Data.OleDb.OleDbType.Integer, 0, "Zipcode"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerStatus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerStatus", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Email", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Email", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Zipcode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Zipcode", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Zipcode1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Zipcode", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM Customer WHERE (CustomerID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (CRate = ? OR ? IS NULL AND CRate IS NULL) AND (City = ? OR ? IS NULL AND City IS NULL) AND (CustomerStatus = ? OR ? IS NULL AND CustomerStatus IS NULL) AND (Email = ? OR ? IS NULL AND Email IS NULL) AND (Fax = ? OR ? IS NULL AND Fax IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Phone = ? OR ? IS NULL AND Phone IS NULL) AND (Zipcode = ? OR ? IS NULL AND Zipcode IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CRate1", System.Data.OleDb.OleDbType.Double, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "City", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerStatus", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerStatus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_CustomerStatus1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CustomerStatus", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Email", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Email1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Email", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Fax", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Zipcode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Zipcode", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Zipcode1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Zipcode", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
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
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(304, 296);
			this.button2.Name = "button2";
			this.button2.TabIndex = 26;
			this.button2.Text = "&Update";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(224, 296);
			this.button3.Name = "button3";
			this.button3.TabIndex = 27;
			this.button3.Text = "&Remove";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Registration
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 342);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Registration";
			this.Text = "Customer Information";
			this.Load += new System.EventHandler(this.Registration_Load);
			((System.ComponentModel.ISupportInitialize)(this.custSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static Main main;
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			main = new Main();
			Application.Run(main);
		}

		public static Main GetMainMenu()
		{
			return main;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to add '"+textBox2.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				OleDbCommand cmd = new OleDbCommand("INSERT INTO CUSTOMER(LastName,FirstName,CustomerStatus,Address,Zipcode,City,Phone,Fax,Email,CRate) VALUES('"+textBox3.Text+"','"+textBox2.Text+"','"+comboBox1.SelectedItem+"','"+textBox5.Text+"',"+textBox6.Text+",'"+textBox7.Text+"',"+textBox8.Text+","+textBox9.Text+",'"+textBox11.Text+"',"+textBox10.Text+");", this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
		public void GetID(string ID)
		{
			this.button1.Hide();
			this.button2.Show();
			this.button3.Show();
			this.oleDbDataAdapter1.Fill(custSet1);
			string query = "";
			query = "SELECT * FROM CUSTOMER WHERE(CustomerID=" + ID + ")";
			OleDbDataAdapter cmdAdapter = new OleDbDataAdapter();
			OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
			cmdAdapter.SelectCommand =cmd;
			cmdAdapter.SelectCommand.CommandType = CommandType.Text;
			this.oleDbConnection1.Open();
			custSet1.Clear();
			cmdAdapter.Fill(custSet1,"Customer");
			this.oleDbConnection1.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to update '"+textBox2.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
//				OleDbCommand cmd = new OleDbCommand("UPDATE CUSTOMER SET(LastName,FirstName,CustomerStatus,Address,Zipcode,City,Phone,Fax,Email,CRate) VALUES('"+textBox3.Text+"','"+textBox2.Text+"','"+comboBox1.SelectedItem+"','"+textBox5.Text+"',"+textBox6.Text+",'"+textBox7.Text+"',"+textBox8.Text+","+textBox9.Text+",'"+textBox11.Text+"',"+textBox10.Text+") WHERE(CustomerID=" + textBox1.Text + ");", this.oleDbConnection1);
				string query1 = "";
				string query2 = "";
				string query3 = "";
				string query4 = "";
				string query5 = "";
				string query6 = "";
				string query7 = "";
				string query8 = "";
				string query9 = "";
				string query10 = "";
				
				query1 = "UPDATE CUSTOMER SET FirstName='" + textBox2.Text+ "' WHERE(CustomerID=" + textBox1.Text + ")";
				query2 = "UPDATE CUSTOMER SET LastName='" + textBox3.Text + "' WHERE(CustomerID=" + textBox1.Text + ")";
				query3 = "UPDATE CUSTOMER SET CustomerStatus='" + comboBox1.SelectedItem + "' WHERE(CustomerID=" + textBox1.Text + ")";
				query4 = "UPDATE CUSTOMER SET Address='" + textBox5.Text + "' WHERE(CustomerID=" + textBox1.Text + ")";
				query5 = "UPDATE CUSTOMER SET Zipcode=" + textBox6.Text + " WHERE(CustomerID=" + textBox1.Text + ")";
				query6 = "UPDATE CUSTOMER SET City='" + textBox7.Text + "' WHERE(CustomerID=" + textBox1.Text + ")";
				query7 = "UPDATE CUSTOMER SET Phone=" + textBox8.Text + " WHERE(CustomerID=" + textBox1.Text + ")";
				query8 = "UPDATE CUSTOMER SET Fax=" + textBox9.Text + " WHERE(CustomerID=" + textBox1.Text + ")";
				query9 = "UPDATE CUSTOMER SET Email='" + textBox11.Text + "' WHERE(CustomerID=" + textBox1.Text + ")";
				query10 = "UPDATE CUSTOMER SET CRate=" + textBox10.Text + " WHERE(CustomerID=" + textBox1.Text + ")"; 
				
				OleDbCommand cmd1 = new OleDbCommand(query1, this.oleDbConnection1);
				OleDbCommand cmd2 = new OleDbCommand(query2, this.oleDbConnection1);
				OleDbCommand cmd3 = new OleDbCommand(query3, this.oleDbConnection1);
				OleDbCommand cmd4 = new OleDbCommand(query4, this.oleDbConnection1);
				OleDbCommand cmd5 = new OleDbCommand(query5, this.oleDbConnection1);
				OleDbCommand cmd6 = new OleDbCommand(query6, this.oleDbConnection1);
				OleDbCommand cmd7 = new OleDbCommand(query7, this.oleDbConnection1);
				OleDbCommand cmd8 = new OleDbCommand(query8, this.oleDbConnection1);
				OleDbCommand cmd9 = new OleDbCommand(query9, this.oleDbConnection1);
				OleDbCommand cmd10 = new OleDbCommand(query10, this.oleDbConnection1);
				
				this.oleDbConnection1.Open();
				cmd1.ExecuteNonQuery();
				cmd2.ExecuteNonQuery();
				cmd3.ExecuteNonQuery();
				cmd4.ExecuteNonQuery();
				cmd5.ExecuteNonQuery();
				cmd6.ExecuteNonQuery();
				cmd7.ExecuteNonQuery();
				cmd8.ExecuteNonQuery();
				cmd9.ExecuteNonQuery();
				cmd10.ExecuteNonQuery();
				
				this.oleDbConnection1.Close();
				this.Close();
			}
		}

		private void Registration_Load(object sender, System.EventArgs e)
		{
			this.button2.Hide();
			this.button3.Hide();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to delete this Customer?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query = "";
				query = "DELETE FROM CUSTOMER WHERE(CustomerID=" + textBox1.Text + ")";
				OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
	}
}
