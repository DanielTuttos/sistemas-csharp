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
	/// Summary description for Product.
	/// </summary>
	public class Product : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Yukon.productSet productSet1;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Product()
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.productSet1 = new Yukon.productSet();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.productSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Product ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Product Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 72);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Product Weight";
			// 
			// textBox1
			// 
			this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSet1, "Product.ProductID"));
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(120, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(40, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSet1, "Product.PorductName"));
			this.textBox2.Location = new System.Drawing.Point(120, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(144, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productSet1, "Product.Weight"));
			this.textBox3.Location = new System.Drawing.Point(120, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(48, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(192, 104);
			this.button1.Name = "button1";
			this.button1.TabIndex = 6;
			this.button1.Text = "&Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(192, 104);
			this.button2.Name = "button2";
			this.button2.TabIndex = 7;
			this.button2.Text = "&Update";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT PorductName, ProductID, Weight FROM Product";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Product(PorductName, Weight) VALUES (?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PorductName", System.Data.OleDb.OleDbType.VarWChar, 50, "PorductName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.Integer, 0, "Weight"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE Product SET PorductName = ?, Weight = ? WHERE (ProductID = ?) AND (Porduct" +
				"Name = ? OR ? IS NULL AND PorductName IS NULL) AND (Weight = ? OR ? IS NULL AND " +
				"Weight IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PorductName", System.Data.OleDb.OleDbType.VarWChar, 50, "PorductName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Weight", System.Data.OleDb.OleDbType.Integer, 0, "Weight"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PorductName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorductName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PorductName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorductName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Product WHERE (ProductID = ?) AND (PorductName = ? OR ? IS NULL AND P" +
				"orductName IS NULL) AND (Weight = ? OR ? IS NULL AND Weight IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PorductName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorductName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PorductName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PorductName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Weight1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Weight", System.Data.DataRowVersion.Original, null));
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
																										new System.Data.Common.DataTableMapping("Table", "Product", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("PorductName", "PorductName"),
																																																				   new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																				   new System.Data.Common.DataColumnMapping("Weight", "Weight")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// productSet1
			// 
			this.productSet1.DataSetName = "productSet";
			this.productSet1.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(112, 104);
			this.button3.Name = "button3";
			this.button3.TabIndex = 8;
			this.button3.Text = "&Remove";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Product
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(288, 150);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Product";
			this.Text = "Product";
			this.Load += new System.EventHandler(this.Product_Load);
			((System.ComponentModel.ISupportInitialize)(this.productSet1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Product_Load(object sender, System.EventArgs e)
		{
			this.button2.Hide();
			this.button3.Hide();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to add '"+textBox2.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				OleDbCommand cmd = new OleDbCommand("INSERT INTO PRODUCT(PorductName,Weight) VALUES('"+textBox2.Text+"',"+textBox3.Text+");", this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
		public void getProID(string ID)
		{
			this.button1.Hide();
			this.button2.Show();
			this.button3.Show();
			this.oleDbDataAdapter1.Fill(productSet1);
			string query = "";
			query = "SELECT * FROM PRODUCT WHERE(ProductID=" + ID + ")";
			OleDbDataAdapter cmdAdapter = new OleDbDataAdapter();
			OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
			cmdAdapter.SelectCommand =cmd;
			cmdAdapter.SelectCommand.CommandType = CommandType.Text;
			this.oleDbConnection1.Open();
			productSet1.Clear();
			cmdAdapter.Fill(productSet1,"Product");
			this.oleDbConnection1.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to update '"+textBox2.Text+"' information?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query1 = "";
				string query2 = "";
				
				query1 = "UPDATE PRODUCT SET PorductName='" + textBox2.Text+ "' WHERE(ProductID=" + textBox1.Text + ")";
				query2 = "UPDATE PRODUCT SET Weight='" + textBox3.Text + "' WHERE(ProductID=" + textBox1.Text + ")";
				
				OleDbCommand cmd1 = new OleDbCommand(query1, this.oleDbConnection1);
				OleDbCommand cmd2 = new OleDbCommand(query2, this.oleDbConnection1);
				
				this.oleDbConnection1.Open();
				cmd1.ExecuteNonQuery();
				cmd2.ExecuteNonQuery();
				
				this.oleDbConnection1.Close();
				this.Close();
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to delete this product?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				string query = "";
				query = "DELETE FROM PRODUCT WHERE(ProductID=" + textBox1.Text + ")";
				OleDbCommand cmd = new OleDbCommand(query, this.oleDbConnection1);
				this.oleDbConnection1.Open();
				cmd.ExecuteNonQuery();
				this.oleDbConnection1.Close();
				this.Close();
			}
		}
	}
}
