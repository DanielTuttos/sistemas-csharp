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
	/// Summary description for Main.
	/// </summary>
	public class Main : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.profileSet profileSet1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.MenuItem menuItem21;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Main()
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button7 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.profileSet1 = new Yukon.profileSet();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.panel1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.profileSet1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem14,
																					  this.menuItem1,
																					  this.menuItem6,
																					  this.menuItem18});
			// 
			// menuItem14
			// 
			this.menuItem14.Enabled = false;
			this.menuItem14.Index = 0;
			this.menuItem14.Text = "Yukon Express Co., Ltd  ";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem15,
																					  this.menuItem4});
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5,
																					  this.menuItem9,
																					  this.menuItem11,
																					  this.menuItem13});
			this.menuItem2.Text = "&Add";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "New &Customer";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 1;
			this.menuItem9.Text = "New &Employee";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 2;
			this.menuItem11.Text = "New Dri&ver";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 3;
			this.menuItem13.Text = "New &Product";
			this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "-";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 2;
			this.menuItem15.Text = "Log &Off";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "E&xit";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem10,
																					  this.menuItem12,
																					  this.menuItem17,
																					  this.menuItem16});
			this.menuItem6.Text = "&View";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 0;
			this.menuItem7.Text = "&Customer List";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 1;
			this.menuItem8.Text = "&Employee List";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 2;
			this.menuItem10.Text = "Dri&ver List";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 3;
			this.menuItem12.Text = "&Product List";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 4;
			this.menuItem17.Text = "-";
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 5;
			this.menuItem16.Text = "&Debt List";
			this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 3;
			this.menuItem18.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem19,
																					   this.menuItem20,
																					   this.menuItem21});
			this.menuItem18.Text = "A&dvanced";
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 0;
			this.menuItem19.Text = "Am&pher...";
			this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 1;
			this.menuItem20.Text = "Province...";
			this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 2;
			this.menuItem21.Text = "&Invoice...";
			this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(128, 462);
			this.panel1.TabIndex = 1;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button7);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(0, 216);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(128, 48);
			this.groupBox4.TabIndex = 10;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Enter Transaction";
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button7.Location = new System.Drawing.Point(8, 16);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(112, 23);
			this.button7.TabIndex = 9;
			this.button7.Text = "&Invoice";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(0, 160);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(128, 48);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Transaction List";
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button6.Location = new System.Drawing.Point(8, 16);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(112, 23);
			this.button6.TabIndex = 7;
			this.button6.Text = "Debt";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(0, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(128, 144);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "View List";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(8, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Customer";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(8, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Employee";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(8, 80);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Driver";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(8, 112);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Product";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(128, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(576, 462);
			this.panel2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileSet1, "UserAccess.Password"));
			this.label3.Location = new System.Drawing.Point(312, 320);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "label3";
			// 
			// profileSet1
			// 
			this.profileSet1.DataSetName = "profileSet";
			this.profileSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button5.Location = new System.Drawing.Point(488, 432);
			this.button5.Name = "button5";
			this.button5.TabIndex = 1;
			this.button5.Text = "Log&in";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(272, 344);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(296, 80);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Authentication Access";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(72, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '•';
			this.textBox2.Size = new System.Drawing.Size(216, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(72, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(216, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "User Name";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT [Password], UserName FROM UserAccess";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source="".\db\yukon.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO UserAccess([Password], UserName) VALUES (?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Password", System.Data.OleDb.OleDbType.VarWChar, 50, "Password"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserName", System.Data.OleDb.OleDbType.VarWChar, 50, "UserName"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE UserAccess SET [Password] = ?, UserName = ? WHERE (UserName = ?) AND ([Pas" +
				"sword] = ? OR ? IS NULL AND [Password] IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Password", System.Data.OleDb.OleDbType.VarWChar, 50, "Password"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("UserName", System.Data.OleDb.OleDbType.VarWChar, 50, "UserName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Password", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Password", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Password1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Password", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM UserAccess WHERE (UserName = ?) AND ([Password] = ? OR ? IS NULL AND " +
				"[Password] IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_UserName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "UserName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Password", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Password", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Password1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Password", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "UserAccess", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("Password", "Password"),
																																																					  new System.Data.Common.DataColumnMapping("UserName", "UserName")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// Main
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 462);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "Main";
			this.Text = "Yukon Express Management Information System";
			this.Load += new System.EventHandler(this.Main_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.profileSet1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			Registration newMDIChild = new Registration();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			CustomerList newMDIChild = new CustomerList();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			EmployeeList newMDIChild = new EmployeeList();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			Employee newMDIChild = new Employee();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			DriverList newMDIChild = new DriverList();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			Driver newMDIChild = new Driver();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			ProductList newMDIChild = new ProductList();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			Product newMDIChild = new Product();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			CustomerList newMDIChild = new CustomerList();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			EmployeeList newMDIChild = new EmployeeList();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			DriverList newMDIChild = new DriverList();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			ProductList newMDIChild = new ProductList();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			//get username
			if (textBox1.Text!="")
			{
				string query = "";
				query = "SELECT * FROM USERACCESS WHERE(UserName='" + textBox1.Text + "')";
				OleDbDataAdapter cmdAdapter = new OleDbDataAdapter();
				OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
				cmdAdapter.SelectCommand =cmd;
				cmdAdapter.SelectCommand.CommandType = CommandType.Text;
				this.oleDbConnection1.Open();
				profileSet1.Clear();
				cmdAdapter.Fill(profileSet1,"UserAccess");
				this.oleDbConnection1.Close();
			}
			int found = BindingContext[profileSet1,"UserAccess"].Count;
			int valid=0;
			//check password
			if(found!=0)
			{
				if (textBox2.Text==label3.Text)
					valid=1;
			}
			if (valid==1)
			{
				//check profile
				panel2.Hide();
				this.menuItem1.Visible = true;
				this.menuItem6.Visible = true;
				this.menuItem18.Visible = true;
				panel1.Show();
				textBox1.Text="";
				textBox2.Text="";
			}
			else
			{
				MessageBox.Show("You have entered an invalid user name and/or password. Please try again.","Invalid User Name or Password",MessageBoxButtons.OK,MessageBoxIcon.Error);
				textBox2.Text="";
			}
		
		}

		private void Main_Load(object sender, System.EventArgs e)
		{
			this.menuItem6.Visible = false;
			this.menuItem1.Visible = false;
			this.menuItem18.Visible = false;
			this.label3.Hide();
			this.panel1.Hide();
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			this.panel2.Show();
			this.menuItem1.Visible = false;
			this.menuItem6.Visible = false;
			this.menuItem18.Visible = false;
			this.panel1.Hide();
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			DebtList newMDIChild = new DebtList();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			DebtList newMDIChild = new DebtList();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			Ampher newMDIChild = new Ampher();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			Province newMDIChild = new Province();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			Invoice newMDIChild = new Invoice();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			viewInvoice newMDIChild = new viewInvoice();
			newMDIChild.MdiParent = this;
			newMDIChild.Show();
		}
	}
}
