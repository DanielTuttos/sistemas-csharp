namespace SalesAndMonitoring
{
    partial class frmCustomerDataEntry
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
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(568, 44);
            this.lblHeader.Text = "       Customer\'s Info";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(491, 208);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(420, 208);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(586, 8);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-6, 194);
            this.groupBox2.Size = new System.Drawing.Size(586, 8);
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerSource, "Fax", true));
            this.textBox11.Location = new System.Drawing.Point(100, 164);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(456, 20);
            this.textBox11.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 82;
            this.label11.Text = "Fax";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerSource, "Phone", true));
            this.textBox10.Location = new System.Drawing.Point(100, 138);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(456, 20);
            this.textBox10.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Phone";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerSource, "Mobile", true));
            this.textBox6.Location = new System.Drawing.Point(101, 112);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(456, 20);
            this.textBox6.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Mobile";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerSource, "Address", true));
            this.textBox5.Location = new System.Drawing.Point(100, 86);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(456, 20);
            this.textBox5.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerSource, "CustomerName", true));
            this.textBox2.Location = new System.Drawing.Point(100, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 20);
            this.textBox2.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Customer Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerSource
            // 
            this.CustomerSource.DataSource = typeof(SalesAndMonitoring.Database.Customer);
            // 
            // frmCustomerDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 241);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCustomerDataEntry";
            this.Text = "frmCustomerDataEntry";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblHeader, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBox6, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.textBox10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.textBox11, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource CustomerSource;
    }
}