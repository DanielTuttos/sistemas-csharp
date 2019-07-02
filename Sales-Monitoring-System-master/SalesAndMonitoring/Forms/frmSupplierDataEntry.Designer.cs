namespace SalesAndMonitoring
{
    partial class frmSupplierDataEntry
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SupplierSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(577, 44);
            this.lblHeader.Text = "       Supplier\'s Info";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(493, 291);
            this.btnCancel.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(422, 291);
            this.btnSave.TabIndex = 13;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(588, 8);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-6, 277);
            this.groupBox2.Size = new System.Drawing.Size(588, 8);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SupplierSource, "CompanyName", true));
            this.textBox2.Location = new System.Drawing.Point(102, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Company Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SupplierSource, "ContactName", true));
            this.textBox3.Location = new System.Drawing.Point(102, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(456, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Contact Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SupplierSource, "ContactTitle", true));
            this.textBox4.Location = new System.Drawing.Point(102, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(456, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Contact Title";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SupplierSource, "Address", true));
            this.textBox5.Location = new System.Drawing.Point(102, 148);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(456, 20);
            this.textBox5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SupplierSource, "PostalCode", true));
            this.textBox8.Location = new System.Drawing.Point(102, 174);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(456, 20);
            this.textBox8.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Postal Code";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SupplierSource, "Phone", true));
            this.textBox10.Location = new System.Drawing.Point(102, 200);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(456, 20);
            this.textBox10.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Phone";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SupplierSource, "Fax", true));
            this.textBox11.Location = new System.Drawing.Point(102, 226);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(456, 20);
            this.textBox11.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Fax";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SupplierSource, "HomePage", true));
            this.textBox12.Location = new System.Drawing.Point(102, 252);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(456, 20);
            this.textBox12.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Home Page";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SupplierSource
            // 
            this.SupplierSource.DataSource = typeof(SalesAndMonitoring.Database.Supplier);
            // 
            // frmSupplierDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 321);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSupplierDataEntry";
            this.Text = "";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblHeader, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.textBox8, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.textBox10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.textBox11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.textBox12, 0);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource SupplierSource;
    }
}