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
	/// Summary description for EmployeeList.
	/// </summary>
	public class EmployeeList : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.empListSet empListSet1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EmployeeList()
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.empListSet1 = new Yukon.empListSet();
			this.label3 = new System.Windows.Forms.Label();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empListSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "EmployeeID",
														   "FirstName",
														   "LastName"});
			this.comboBox1.Location = new System.Drawing.Point(56, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 8;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(208, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(264, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 5;
			this.label1.Text = "Search";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(184, 8);
			this.label2.Name = "label2";
			this.label2.TabIndex = 7;
			this.label2.Text = "For";
			// 
			// dataGrid1
			// 
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.BackgroundColor = System.Drawing.Color.LightGray;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.DataMember = "Employee";
			this.dataGrid1.DataSource = this.empListSet1;
			this.dataGrid1.FlatMode = true;
			this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 8F);
			this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
			this.dataGrid1.Location = new System.Drawing.Point(8, 48);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.dataGrid1.Size = new System.Drawing.Size(472, 480);
			this.dataGrid1.TabIndex = 9;
			this.dataGrid1.DoubleClick += new System.EventHandler(this.dataGrid1_DoubleClick);
			// 
			// empListSet1
			// 
			this.empListSet1.DataSetName = "empListSet";
			this.empListSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// label3
			// 
			this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empListSet1, "Employee.EmployeeID"));
			this.label3.Location = new System.Drawing.Point(368, 8);
			this.label3.Name = "label3";
			this.label3.TabIndex = 10;
			this.label3.Text = "label3";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Address, EmployeeID, FirstName, JobType, LastName, Salary FROM Employee";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source="".\db\yukon.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Employee(Address, FirstName, JobType, LastName, Salary) VALUES (?, ?," +
				" ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("JobType", System.Data.OleDb.OleDbType.VarChar, 50, "JobType"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Currency, 0, "Salary"));
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Employee", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																					new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
																																																					new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
																																																					new System.Data.Common.DataColumnMapping("JobType", "JobType"),
																																																					new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																					new System.Data.Common.DataColumnMapping("Salary", "Salary")})});
			// 
			// EmployeeList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 542);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Name = "EmployeeList";
			this.Text = "Employee List";
			this.Load += new System.EventHandler(this.EmployeeList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empListSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void EmployeeList_Load(object sender, System.EventArgs e)
		{
			this.oleDbDataAdapter1.Fill(empListSet1);
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if (textBox1.Text=="")
			{
				this.oleDbDataAdapter1.Fill(empListSet1);
			}
			else
			{
				string query = "";
				query = "SELECT * FROM EMPLOYEE WHERE("+comboBox1.SelectedItem+")LIKE('%" + textBox1.Text + "%')";
				OleDbDataAdapter cmdAdapter = new OleDbDataAdapter();
				OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
				cmdAdapter.SelectCommand =cmd;
				cmdAdapter.SelectCommand.CommandType = CommandType.Text;
				this.oleDbConnection1.Open();
				empListSet1.Clear();
				cmdAdapter.Fill(empListSet1,"Employee");
				this.oleDbConnection1.Close();
			}
		}

		private void dataGrid1_DoubleClick(object sender, System.EventArgs e)
		{
			if (label3.Text!="label3")
			{
				Employee Form2 = new Employee();
				Form2.MdiParent = Registration.GetMainMenu();
				Form2.Show();
				Form2.getEmpID(label3.Text);
			}
		}
	}
}
