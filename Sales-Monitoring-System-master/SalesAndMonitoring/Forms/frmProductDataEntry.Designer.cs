namespace SalesAndMonitoring
{
    partial class frmProductDataEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.bindingProduct = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.ComboBox();
            this.bindingSupplier = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(570, 44);
            this.lblHeader.Text = "       Product\'s Info";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(493, 290);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(422, 290);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(588, 8);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-6, 276);
            this.groupBox2.Size = new System.Drawing.Size(588, 8);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProduct, "ReorderLevel", true));
            this.textBox9.Location = new System.Drawing.Point(102, 242);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(456, 20);
            this.textBox9.TabIndex = 67;
            // 
            // bindingProduct
            // 
            this.bindingProduct.DataSource = typeof(SalesAndMonitoring.Database.Product);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Reorder Level";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProduct, "UnitsOnOrder", true));
            this.textBox8.Location = new System.Drawing.Point(102, 216);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(456, 20);
            this.textBox8.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Units on Order";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProduct, "UnitsInStock", true));
            this.textBox7.Location = new System.Drawing.Point(102, 190);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(456, 20);
            this.textBox7.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Units in Stock";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProduct, "UnitPrice", true));
            this.textBox6.Location = new System.Drawing.Point(101, 164);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(456, 20);
            this.textBox6.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "UnitPrice";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProduct, "QuantityPerUnit", true));
            this.textBox5.Location = new System.Drawing.Point(101, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(456, 20);
            this.textBox5.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Quantity/Unit";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Supplier Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProduct, "ProductName", true));
            this.textBox2.Location = new System.Drawing.Point(101, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 20);
            this.textBox2.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Product Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProduct, "Barcode", true));
            this.textBox1.Location = new System.Drawing.Point(101, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Barcode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingProduct, "SupplierID", true));
            this.textBox3.DataSource = this.bindingSupplier;
            this.textBox3.DisplayMember = "CompanyName";
            this.textBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBox3.FormattingEnabled = true;
            this.textBox3.Location = new System.Drawing.Point(101, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(457, 21);
            this.textBox3.TabIndex = 79;
            this.textBox3.ValueMember = "SupplierID";
            // 
            // bindingSupplier
            // 
            this.bindingSupplier.DataSource = typeof(SalesAndMonitoring.Database.Supplier);
            // 
            // frmProductDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 323);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProductDataEntry";
            this.Text = "frmProductDataEntry";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblHeader, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBox6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.textBox7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.textBox8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.textBox9, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox textBox3;
        private System.Windows.Forms.BindingSource bindingProduct;
        private System.Windows.Forms.BindingSource bindingSupplier;
    }
}