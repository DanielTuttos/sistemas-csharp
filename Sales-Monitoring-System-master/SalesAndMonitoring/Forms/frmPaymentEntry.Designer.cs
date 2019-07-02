namespace SalesAndMonitoring
{
    partial class frmPaymentEntry
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
            this.CustomerSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(459, 44);
            this.lblHeader.Text = "       Cash Payment";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(382, 277);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(311, 277);
            this.btnSave.Text = "Submit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(477, 8);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-6, 263);
            this.groupBox2.Size = new System.Drawing.Size(477, 8);
            // 
            // CustomerSource
            // 
            this.CustomerSource.DataSource = typeof(SalesAndMonitoring.Database.Customer);
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCash.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerSource, "CustomerName", true));
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(201, 138);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(248, 44);
            this.txtCash.TabIndex = 62;
            this.txtCash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCash_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 39);
            this.label2.TabIndex = 73;
            this.label2.Text = "Cash  P";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerSource, "CustomerName", true));
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(201, 79);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(248, 44);
            this.txtAmount.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 75;
            this.label1.Text = "Amount  P";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtChange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerSource, "CustomerName", true));
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(199, 199);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(248, 44);
            this.txtChange.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 39);
            this.label3.TabIndex = 77;
            this.label3.Text = "Change  P";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPaymentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 310);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPaymentEntry";
            this.Text = "Cash Payment";
            this.Load += new System.EventHandler(this.frmPaymentEntry_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblHeader, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtCash, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtAmount, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtChange, 0);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource CustomerSource;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label3;
    }
}