namespace SalesAndMonitoring
{
    partial class frmRemittance
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UserSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfTenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remittanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemitDetailSource = new System.Windows.Forms.BindingSource(this.components);
            this.RemitSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemitDetailSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemitSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Size = new System.Drawing.Size(836, 44);
            this.lblHeader.Text = "       Remittance";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(752, 544);
            this.btnCancel.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(681, 544);
            this.btnSave.TabIndex = 13;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(847, 8);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(-6, 530);
            this.groupBox2.Size = new System.Drawing.Size(847, 8);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 74);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cashier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cashier Fullname:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.UserSource;
            this.comboBox1.DisplayMember = "Fullname";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(342, 32);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            // 
            // UserSource
            // 
            this.UserSource.DataSource = typeof(SalesAndMonitoring.Database.User_tbl);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(593, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(661, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "0.00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGrid);
            this.groupBox4.Location = new System.Drawing.Point(12, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(805, 304);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cheque";
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.remitIDDataGridViewTextBoxColumn,
            this.typeOfTenderDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.checkNoDataGridViewTextBoxColumn,
            this.dateCheckDataGridViewTextBoxColumn,
            this.remittanceDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.RemitDetailSource;
            this.dataGrid.Location = new System.Drawing.Point(20, 29);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGrid.Size = new System.Drawing.Size(764, 257);
            this.dataGrid.TabIndex = 74;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // remitIDDataGridViewTextBoxColumn
            // 
            this.remitIDDataGridViewTextBoxColumn.DataPropertyName = "RemitID";
            this.remitIDDataGridViewTextBoxColumn.HeaderText = "RemitID";
            this.remitIDDataGridViewTextBoxColumn.Name = "remitIDDataGridViewTextBoxColumn";
            this.remitIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeOfTenderDataGridViewTextBoxColumn
            // 
            this.typeOfTenderDataGridViewTextBoxColumn.DataPropertyName = "TypeOfTender";
            this.typeOfTenderDataGridViewTextBoxColumn.HeaderText = "TypeOfTender";
            this.typeOfTenderDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "CASH",
            "CHEQUE"});
            this.typeOfTenderDataGridViewTextBoxColumn.Name = "typeOfTenderDataGridViewTextBoxColumn";
            this.typeOfTenderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeOfTenderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // checkNoDataGridViewTextBoxColumn
            // 
            this.checkNoDataGridViewTextBoxColumn.DataPropertyName = "CheckNo";
            this.checkNoDataGridViewTextBoxColumn.HeaderText = "CheckNo";
            this.checkNoDataGridViewTextBoxColumn.Name = "checkNoDataGridViewTextBoxColumn";
            // 
            // dateCheckDataGridViewTextBoxColumn
            // 
            this.dateCheckDataGridViewTextBoxColumn.DataPropertyName = "DateCheck";
            this.dateCheckDataGridViewTextBoxColumn.HeaderText = "DateCheck";
            this.dateCheckDataGridViewTextBoxColumn.Name = "dateCheckDataGridViewTextBoxColumn";
            // 
            // remittanceDataGridViewTextBoxColumn
            // 
            this.remittanceDataGridViewTextBoxColumn.DataPropertyName = "Remittance";
            this.remittanceDataGridViewTextBoxColumn.HeaderText = "Remittance";
            this.remittanceDataGridViewTextBoxColumn.Name = "remittanceDataGridViewTextBoxColumn";
            this.remittanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // RemitDetailSource
            // 
            this.RemitDetailSource.DataSource = typeof(SalesAndMonitoring.Database.RemittanceDetail);
            // 
            // RemitSource
            // 
            this.RemitSource.DataSource = typeof(SalesAndMonitoring.Database.Remittance);
            // 
            // frmRemittance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 574);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRemittance";
            this.Text = "";
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblHeader, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemitDetailSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemitSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource UserSource;
        private System.Windows.Forms.BindingSource RemitSource;
        private System.Windows.Forms.BindingSource RemitDetailSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeOfTenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remittanceDataGridViewTextBoxColumn;
    }
}