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
	/// Summary description for Debt.
	/// </summary>
	public class Debt : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.debtSet debtSet1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Debt()
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.debtSet1 = new Yukon.debtSet();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			((System.ComponentModel.ISupportInitialize)(this.debtSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Invoice ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(40, 40);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Customer Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 64);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Payment Type";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(40, 88);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Total Cost";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(40, 112);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "Amount Paid";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(40, 136);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "Amount Due";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtSet1, "Invoice.AmountPaid"));
			this.textBox1.Location = new System.Drawing.Point(120, 112);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "";
			// 
			// debtSet1
			// 
			this.debtSet1.DataSetName = "debtSet";
			this.debtSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtSet1, "Invoice.AmountDue"));
			this.textBox2.Location = new System.Drawing.Point(120, 136);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 20);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(112, 176);
			this.button1.Name = "button1";
			this.button1.TabIndex = 12;
			this.button1.Text = "&Update";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(192, 176);
			this.button2.Name = "button2";
			this.button2.TabIndex = 13;
			this.button2.Text = "&Close";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label7
			// 
			this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtSet1, "Invoice.InvoiceID"));
			this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label7.Location = new System.Drawing.Point(128, 16);
			this.label7.Name = "label7";
			this.label7.TabIndex = 14;
			this.label7.Text = "label7";
			// 
			// label8
			// 
			this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtSet1, "Invoice.CustomerName"));
			this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label8.Location = new System.Drawing.Point(128, 40);
			this.label8.Name = "label8";
			this.label8.TabIndex = 15;
			this.label8.Text = "label8";
			// 
			// label9
			// 
			this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtSet1, "Invoice.PaymentType"));
			this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label9.Location = new System.Drawing.Point(128, 64);
			this.label9.Name = "label9";
			this.label9.TabIndex = 16;
			this.label9.Text = "label9";
			// 
			// label10
			// 
			this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.debtSet1, "Invoice.TotalCost"));
			this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label10.Location = new System.Drawing.Point(128, 88);
			this.label10.Name = "label10";
			this.label10.TabIndex = 17;
			this.label10.Text = "label10";
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
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CRate", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "CRate", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.Integer, 0, "CustomerID"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CustomerName", System.Data.OleDb.OleDbType.VarWChar, 50, "CustomerName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 50, "Description"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DRate", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "DRate", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DriverCommision", System.Data.OleDb.OleDbType.Currency, 0, "DriverCommision"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DriverName", System.Data.OleDb.OleDbType.VarWChar, 50, "DriverName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Insurance", System.Data.OleDb.OleDbType.Currency, 0, "Insurance"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LRate", System.Data.OleDb.OleDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(15)), ((System.Byte)(0)), "LRate", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PaymentType", System.Data.OleDb.OleDbType.VarWChar, 50, "PaymentType"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Price", System.Data.OleDb.OleDbType.Currency, 0, "Price"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 50, "ProductName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, "ProvinceName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ShippingDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippingDate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TotalCost", System.Data.OleDb.OleDbType.Currency, 0, "TotalCost"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.Integer, 0, "Weight"));
			// 
			// oleDbDataAdapter1
			// 
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
			// 
			// Debt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(280, 214);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Debt";
			this.Text = "Debt Information";
			((System.ComponentModel.ISupportInitialize)(this.debtSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		public void getDebtID(string ID)
		{
			this.oleDbDataAdapter1.Fill(debtSet1);
			string query = "";
			query = "SELECT * FROM INVOICE WHERE(InvoiceID=" + ID + ")";
			OleDbDataAdapter cmdAdapter = new OleDbDataAdapter();
			OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
			cmdAdapter.SelectCommand =cmd;
			cmdAdapter.SelectCommand.CommandType = CommandType.Text;
			this.oleDbConnection1.Open();
			debtSet1.Clear();
			cmdAdapter.Fill(debtSet1,"Invoice");
			this.oleDbConnection1.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to update '"+label8.Text+"' invoice information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query1 = "";
				string query2 = "";
				
				query1 = "UPDATE INVOICE SET AmountPaid=" + textBox1.Text+ " WHERE(InvoiceID=" + label7.Text + ")";
				query2 = "UPDATE INVOICE SET AmountDue=" + textBox2.Text + " WHERE(InvoiceID=" + label7.Text + ")";
				
				OleDbCommand cmd1 = new OleDbCommand(query1, this.oleDbConnection1);
				OleDbCommand cmd2 = new OleDbCommand(query2, this.oleDbConnection1);
				
				this.oleDbConnection1.Open();
				cmd1.ExecuteNonQuery();
				cmd2.ExecuteNonQuery();
				
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
	}
}
