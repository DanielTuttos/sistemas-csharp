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
	/// Summary description for Driver.
	/// </summary>
	public class Driver : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.driverSet driverSet1;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Driver()
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
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.driverSet1 = new Yukon.driverSet();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.driverSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(328, 152);
			this.button2.Name = "button2";
			this.button2.TabIndex = 27;
			this.button2.Text = "&Update";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 120);
			this.label5.Name = "label5";
			this.label5.TabIndex = 18;
			this.label5.Text = "Salary";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 96);
			this.label4.Name = "label4";
			this.label4.TabIndex = 17;
			this.label4.Text = "Address";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 72);
			this.label3.Name = "label3";
			this.label3.TabIndex = 16;
			this.label3.Text = "Last Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 15;
			this.label2.Text = "First Name";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 14;
			this.label1.Text = "Driver ID";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(328, 152);
			this.button1.Name = "button1";
			this.button1.TabIndex = 26;
			this.button1.Text = "&Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverSet1, "Driver.Salary"));
			this.textBox5.Location = new System.Drawing.Point(112, 120);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(128, 20);
			this.textBox5.TabIndex = 24;
			this.textBox5.Text = "";
			// 
			// driverSet1
			// 
			this.driverSet1.DataSetName = "driverSet";
			this.driverSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverSet1, "Driver.Address"));
			this.textBox4.Location = new System.Drawing.Point(112, 96);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(288, 20);
			this.textBox4.TabIndex = 23;
			this.textBox4.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverSet1, "Driver.LastName"));
			this.textBox3.Location = new System.Drawing.Point(112, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(160, 20);
			this.textBox3.TabIndex = 22;
			this.textBox3.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverSet1, "Driver.FirstName"));
			this.textBox2.Location = new System.Drawing.Point(112, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(160, 20);
			this.textBox2.TabIndex = 21;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driverSet1, "Driver.DriverID"));
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(112, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(48, 20);
			this.textBox1.TabIndex = 20;
			this.textBox1.Text = "";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Address, Commision, DriverID, FirstName, LastName, Salary FROM Driver";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source="".\db\yukon.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Driver(Address, Commision, FirstName, LastName, Salary) VALUES (?, ?," +
				" ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commision", System.Data.OleDb.OleDbType.Currency, 0, "Commision"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Currency, 0, "Salary"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE Driver SET Address = ?, Commision = ?, FirstName = ?, LastName = ?, Salary = ? WHERE (DriverID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (Commision = ? OR ? IS NULL AND Commision IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Salary = ? OR ? IS NULL AND Salary IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 50, "Address"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Commision", System.Data.OleDb.OleDbType.Currency, 0, "Commision"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, "FirstName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 50, "LastName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Currency, 0, "Salary"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commision", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commision1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commision", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Salary", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salary1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Salary", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM Driver WHERE (DriverID = ?) AND (Address = ? OR ? IS NULL AND Address IS NULL) AND (Commision = ? OR ? IS NULL AND Commision IS NULL) AND (FirstName = ? OR ? IS NULL AND FirstName IS NULL) AND (LastName = ? OR ? IS NULL AND LastName IS NULL) AND (Salary = ? OR ? IS NULL AND Salary IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DriverID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "DriverID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Address", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commision", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Commision1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Commision", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_FirstName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LastName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LastName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Salary", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salary1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Salary", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Driver", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("Address", "Address"),
																																																				  new System.Data.Common.DataColumnMapping("Commision", "Commision"),
																																																				  new System.Data.Common.DataColumnMapping("DriverID", "DriverID"),
																																																				  new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
																																																				  new System.Data.Common.DataColumnMapping("LastName", "LastName"),
																																																				  new System.Data.Common.DataColumnMapping("Salary", "Salary")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(248, 152);
			this.button3.Name = "button3";
			this.button3.TabIndex = 29;
			this.button3.Text = "&Remove";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Driver
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 190);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Driver";
			this.Text = "Driver";
			this.Load += new System.EventHandler(this.Driver_Load);
			((System.ComponentModel.ISupportInitialize)(this.driverSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to add '"+textBox2.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				OleDbCommand cmd = new OleDbCommand("INSERT INTO DRIVER(LastName,FirstName,Address,Salary,Commision) VALUES('"+textBox3.Text+"','"+textBox2.Text+"','"+textBox4.Text+"',"+textBox5.Text+",'0');", this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
		public void getDriID(string ID)
		{
			this.button1.Hide();
			this.button2.Show();
			this.button3.Show();
			this.oleDbDataAdapter1.Fill(driverSet1);
			string query = "";
			query = "SELECT * FROM DRIVER WHERE(DriverID=" + ID + ")";
			OleDbDataAdapter cmdAdapter = new OleDbDataAdapter();
			OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
			cmdAdapter.SelectCommand =cmd;
			cmdAdapter.SelectCommand.CommandType = CommandType.Text;
			this.oleDbConnection1.Open();
			driverSet1.Clear();
			cmdAdapter.Fill(driverSet1,"Driver");
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
				
				
				query1 = "UPDATE DRIVER SET FirstName='" + textBox2.Text+ "' WHERE(DriverID=" + textBox1.Text + ")";
				query2 = "UPDATE DRIVER SET LastName='" + textBox3.Text + "' WHERE(DriverID=" + textBox1.Text + ")";
				query3 = "UPDATE DRIVER SET Commision='0' WHERE(DriverID=" + textBox1.Text + ")";
				query4 = "UPDATE DRIVER SET Address='" + textBox4.Text + "' WHERE(DriverID=" + textBox1.Text + ")";
				query5 = "UPDATE DRIVER SET Salary=" + textBox5.Text + " WHERE(DriverID=" + textBox1.Text + ")";
				
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

		private void Driver_Load(object sender, System.EventArgs e)
		{
			this.button2.Hide();
			this.button3.Hide();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to delete this Driver?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query = "";
				query = "DELETE FROM DRIVER WHERE(DriverID=" + textBox1.Text + ")";
				OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
	}
}
