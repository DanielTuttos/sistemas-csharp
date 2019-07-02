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
	/// Summary description for Ampher.
	/// </summary>
	public class Ampher : System.Windows.Forms.Form
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
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.ampherSet ampherSet1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Ampher()
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.ampherSet1 = new Yukon.ampherSet();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ampherSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 40);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Ampher ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Province ID";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 88);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Ampher Name";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 112);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "C-Rate";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 136);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "L-Rate";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 160);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "D-Rate";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ampherSet1, "Ampher.AmpherID"));
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(112, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(40, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ampherSet1, "Ampher.ProvinceID"));
			this.textBox2.Location = new System.Drawing.Point(112, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(40, 20);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ampherSet1, "Ampher.AmpherName"));
			this.textBox3.Location = new System.Drawing.Point(112, 88);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(168, 20);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ampherSet1, "Ampher.CRate"));
			this.textBox4.Location = new System.Drawing.Point(112, 112);
			this.textBox4.Name = "textBox4";
			this.textBox4.TabIndex = 9;
			this.textBox4.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ampherSet1, "Ampher.LRate"));
			this.textBox5.Location = new System.Drawing.Point(112, 136);
			this.textBox5.Name = "textBox5";
			this.textBox5.TabIndex = 10;
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ampherSet1, "Ampher.DRate"));
			this.textBox6.Location = new System.Drawing.Point(112, 160);
			this.textBox6.Name = "textBox6";
			this.textBox6.TabIndex = 11;
			this.textBox6.Text = "";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(208, 192);
			this.button1.Name = "button1";
			this.button1.TabIndex = 12;
			this.button1.Text = "&Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(96, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "Pre&v";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(152, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "&Next";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(120, 192);
			this.button4.Name = "button4";
			this.button4.TabIndex = 15;
			this.button4.Text = "&Update";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT AmpherID, AmpherName, CRate, DRate, LRate, ProvinceID FROM Ampher";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Ampher(AmpherName, CRate, DRate, LRate, ProvinceID) VALUES (?, ?, ?, " +
				"?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("AmpherName", System.Data.OleDb.OleDbType.VarWChar, 50, "AmpherName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("CRate", System.Data.OleDb.OleDbType.VarChar, 50, "CRate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DRate", System.Data.OleDb.OleDbType.VarChar, 50, "DRate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LRate", System.Data.OleDb.OleDbType.VarChar, 50, "LRate"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("ProvinceID", System.Data.OleDb.OleDbType.Integer, 0, "ProvinceID"));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source="".\db\yukon.mdb"";Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Ampher", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("AmpherID", "AmpherID"),
																																																				  new System.Data.Common.DataColumnMapping("AmpherName", "AmpherName"),
																																																				  new System.Data.Common.DataColumnMapping("CRate", "CRate"),
																																																				  new System.Data.Common.DataColumnMapping("DRate", "DRate"),
																																																				  new System.Data.Common.DataColumnMapping("LRate", "LRate"),
																																																				  new System.Data.Common.DataColumnMapping("ProvinceID", "ProvinceID")})});
			// 
			// ampherSet1
			// 
			this.ampherSet1.DataSetName = "ampherSet";
			this.ampherSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button5.Location = new System.Drawing.Point(32, 192);
			this.button5.Name = "button5";
			this.button5.TabIndex = 16;
			this.button5.Text = "&Remove";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button6.Location = new System.Drawing.Point(40, 8);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(48, 23);
			this.button6.TabIndex = 17;
			this.button6.Text = "&First";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button7.Location = new System.Drawing.Point(208, 8);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(48, 23);
			this.button7.TabIndex = 18;
			this.button7.Text = "&Last";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Ampher
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 230);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox6);
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
			this.Name = "Ampher";
			this.Text = "Ampher";
			this.Load += new System.EventHandler(this.Ampher_Load);
			((System.ComponentModel.ISupportInitialize)(this.ampherSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[ampherSet1,"Ampher"].Position+=1;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[ampherSet1,"Ampher"].Position-=1;
		}

		private void Ampher_Load(object sender, System.EventArgs e)
		{
			this.oleDbDataAdapter1.Fill(ampherSet1);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to add '"+textBox3.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				OleDbCommand cmd = new OleDbCommand("INSERT INTO AMPHER(ProvinceID,AmpherName,CRate,LRate,DRate) VALUES("+textBox2.Text+",'"+textBox3.Text+"',"+textBox4.Text+","+textBox5.Text+","+textBox6.Text+");", this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to update '"+textBox3.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query1 = "";
				string query2 = "";
				string query3 = "";
				string query4 = "";
				string query5 = "";
				
				
				query1 = "UPDATE AMPHER SET ProvinceID=" + textBox2.Text+ " WHERE(AmpherID=" + textBox1.Text + ")";
				query2 = "UPDATE AMPHER SET AmpherName='" + textBox3.Text + "' WHERE(AmpherID=" + textBox1.Text + ")";
				query3 = "UPDATE AMPHER SET CRate=" + textBox4.Text + " WHERE(AmpherID=" + textBox1.Text + ")";
				query4 = "UPDATE AMPHER SET LRate=" + textBox5.Text + " WHERE(AmpherID=" + textBox1.Text + ")";
				query5 = "UPDATE AMPHER SET DRate=" + textBox6.Text + " WHERE(AmpherID=" + textBox1.Text + ")";
				
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

		private void button5_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to delete this Ampher?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query = "";
				query = "DELETE FROM AMPHER WHERE(AmpherID=" + textBox1.Text + ")";
				OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[ampherSet1,"Ampher"].Position=0;
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			int records= this.BindingContext[ampherSet1,"Ampher"].Count;
			this.BindingContext[ampherSet1,"Ampher"].Position=records;
		}
	}
}
