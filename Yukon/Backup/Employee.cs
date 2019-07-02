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
	/// Summary description for Employee.
	/// </summary>
	public class Employee : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.empSet empSet1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Employee()
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
			this.empSet1 = new Yukon.empSet();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.empSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Employee ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "First Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 72);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Last Name";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 96);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Address";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 120);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "Job Type";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 144);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "Salary";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empSet1, "Employee.EmployeeID"));
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(112, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(48, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "";
			// 
			// empSet1
			// 
			this.empSet1.DataSetName = "empSet";
			this.empSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empSet1, "Employee.FirstName"));
			this.textBox2.Location = new System.Drawing.Point(112, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 20);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empSet1, "Employee.LastName"));
			this.textBox3.Location = new System.Drawing.Point(112, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(160, 20);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empSet1, "Employee.Address"));
			this.textBox4.Location = new System.Drawing.Point(112, 96);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(288, 20);
			this.textBox4.TabIndex = 9;
			this.textBox4.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empSet1, "Employee.Salary"));
			this.textBox5.Location = new System.Drawing.Point(112, 144);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(128, 20);
			this.textBox5.TabIndex = 10;
			this.textBox5.Text = "";
			// 
			// comboBox1
			// 
			this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.empSet1, "Employee.JobType"));
			this.comboBox1.Items.AddRange(new object[] {
														   "Accountant",
														   "Clerk",
														   "Manager"});
			this.comboBox1.Location = new System.Drawing.Point(112, 120);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 11;
			this.comboBox1.Text = "Accountant";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(320, 176);
			this.button1.Name = "button1";
			this.button1.TabIndex = 12;
			this.button1.Text = "&Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(320, 176);
			this.button2.Name = "button2";
			this.button2.TabIndex = 13;
			this.button2.Text = "&Update";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(240, 176);
			this.button3.Name = "button3";
			this.button3.TabIndex = 14;
			this.button3.Text = "&Remove";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Employee
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(416, 222);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Employee";
			this.Text = "Employee Information";
			this.Load += new System.EventHandler(this.Employee_Load);
			((System.ComponentModel.ISupportInitialize)(this.empSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to add '"+textBox2.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				OleDbCommand cmd = new OleDbCommand("INSERT INTO EMPLOYEE(LastName,FirstName,Address,JobType,Salary) VALUES('"+textBox3.Text+"','"+textBox2.Text+"','"+textBox4.Text+"','"+comboBox1.SelectedItem+"','"+textBox5.Text+"');", this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
		
		public void getEmpID(string ID)
		{
			this.button1.Hide();
			this.button2.Show();
			this.button3.Show();
			this.oleDbDataAdapter1.Fill(empSet1);
			string query = "";
			query = "SELECT * FROM EMPLOYEE WHERE(EmployeeID=" + ID + ")";
			OleDbDataAdapter cmdAdapter = new OleDbDataAdapter();
			OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
			cmdAdapter.SelectCommand =cmd;
			cmdAdapter.SelectCommand.CommandType = CommandType.Text;
			this.oleDbConnection1.Open();
			empSet1.Clear();
			cmdAdapter.Fill(empSet1,"Employee");
			this.oleDbConnection1.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to update '"+textBox2.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query1 = "";
				string query2 = "";
				string query3 = "";
				string query4 = "";
				string query5 = "";
				
				
				query1 = "UPDATE EMPLOYEE SET FirstName='" + textBox2.Text+ "' WHERE(EmployeeID=" + textBox1.Text + ")";
				query2 = "UPDATE EMPLOYEE SET LastName='" + textBox3.Text + "' WHERE(EmployeeID=" + textBox1.Text + ")";
				query3 = "UPDATE EMPLOYEE SET JobType='" + comboBox1.SelectedItem + "' WHERE(EmployeeID=" + textBox1.Text + ")";
				query4 = "UPDATE EMPLOYEE SET Address='" + textBox4.Text + "' WHERE(EmployeeID=" + textBox1.Text + ")";
				query5 = "UPDATE EMPLOYEE SET Salary=" + textBox5.Text + " WHERE(EmployeeID=" + textBox1.Text + ")";
				
				OleDbCommand cmd1 = new OleDbCommand(query1, this.oleDbConnection1);
				OleDbCommand cmd2 = new OleDbCommand(query2, this.oleDbConnection1);
				OleDbCommand cmd3 = new OleDbCommand(query3, this.oleDbConnection1);
				OleDbCommand cmd4 = new OleDbCommand(query4, this.oleDbConnection1);
				OleDbCommand cmd5 = new OleDbCommand(query5, this.oleDbConnection1);
				
				this.oleDbConnection1.Open();
				cmd1.ExecuteNonQuery();
				cmd2.ExecuteNonQuery();
				cmd3.ExecuteNonQuery();
				cmd4.ExecuteNonQuery();
				cmd5.ExecuteNonQuery();
				
				this.oleDbConnection1.Close();
				this.Close();
			}
		}

		private void Employee_Load(object sender, System.EventArgs e)
		{
			this.button2.Hide();
			this.button3.Hide();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to delete this Employee?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query = "";
				query = "DELETE FROM EMPLOYEE WHERE(EmployeeID=" + textBox1.Text + ")";
				OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
	}
}