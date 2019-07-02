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
	/// Summary description for Province.
	/// </summary>
	public class Province : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.provinceSet provinceSet1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Province()
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
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.provinceSet1 = new Yukon.provinceSet();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.provinceSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(112, 96);
			this.button4.Name = "button4";
			this.button4.TabIndex = 31;
			this.button4.Text = "&Update";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(144, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 23);
			this.button3.TabIndex = 30;
			this.button3.Text = "&Next";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(88, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 23);
			this.button2.TabIndex = 29;
			this.button2.Text = "Pre&v";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(200, 96);
			this.button1.Name = "button1";
			this.button1.TabIndex = 28;
			this.button1.Text = "&Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provinceSet1, "Province.ProvinceName"));
			this.textBox2.Location = new System.Drawing.Point(104, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(168, 20);
			this.textBox2.TabIndex = 23;
			this.textBox2.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.provinceSet1, "Province.ProvinceID"));
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(104, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(40, 20);
			this.textBox1.TabIndex = 22;
			this.textBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.TabIndex = 18;
			this.label3.Text = "Province Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.TabIndex = 17;
			this.label2.Text = "Province ID";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT ProvinceID, ProvinceName FROM Province";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Province(ProvinceName) VALUES (?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, "ProvinceName"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE Province SET ProvinceName = ? WHERE (ProvinceID = ?) AND (ProvinceName = ?" +
				" OR ? IS NULL AND ProvinceName IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, "ProvinceName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Province WHERE (ProvinceID = ?) AND (ProvinceName = ? OR ? IS NULL AN" +
				"D ProvinceName IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProvinceName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProvinceName", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source="".\db\yukon.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Province", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("ProvinceID", "ProvinceID"),
																																																					new System.Data.Common.DataColumnMapping("ProvinceName", "ProvinceName")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// provinceSet1
			// 
			this.provinceSet1.DataSetName = "provinceSet";
			this.provinceSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button5.Location = new System.Drawing.Point(24, 96);
			this.button5.Name = "button5";
			this.button5.TabIndex = 32;
			this.button5.Text = "&Remove";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button6.Location = new System.Drawing.Point(32, 8);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(48, 23);
			this.button6.TabIndex = 33;
			this.button6.Text = "&First";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button7.Location = new System.Drawing.Point(200, 8);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(48, 23);
			this.button7.TabIndex = 34;
			this.button7.Text = "&Last";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Province
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 126);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "Province";
			this.Text = "Province";
			this.Load += new System.EventHandler(this.Province_Load);
			((System.ComponentModel.ISupportInitialize)(this.provinceSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Province_Load(object sender, System.EventArgs e)
		{
			this.oleDbDataAdapter1.Fill(provinceSet1);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[provinceSet1,"Province"].Position+=1;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[provinceSet1,"Province"].Position-=1;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to add '"+textBox2.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				OleDbCommand cmd = new OleDbCommand("INSERT INTO PROVINCE (ProvinceName) VALUES ('"+textBox2.Text+"');", this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to update '"+textBox2.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query1 = "";				
				
				query1 = "UPDATE PROVINCE SET ProvinceName='" + textBox2.Text+ "' WHERE(ProvinceID=" + textBox1.Text + ")";
				
				OleDbCommand cmd1 = new OleDbCommand(query1, this.oleDbConnection1);
					
				this.oleDbConnection1.Open();
				cmd1.ExecuteNonQuery();
				
				this.oleDbConnection1.Close();
				this.Close();
			}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to delete this Province?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query = "";
				query = "DELETE FROM PROVINCE WHERE(ProvinceID=" + textBox1.Text + ")";
				OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[provinceSet1,"Province"].Position=0;
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			int records= this.BindingContext[provinceSet1,"Province"].Count;
			this.BindingContext[provinceSet1,"Province"].Position=records;
		}
	}
}
