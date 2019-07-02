namespace SalesAndMonitoring
{
    partial class frmTransactionWalkin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBillto = new System.Windows.Forms.ComboBox();
            this.CustomerSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.dtpTransDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGrandtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.orderDetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderlIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProductSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isVoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDetailSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.OrderSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(-12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 8);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Bill To:";
            // 
            // cmbBillto
            // 
            this.cmbBillto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBillto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbBillto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbBillto.DataSource = this.CustomerSource;
            this.cmbBillto.DisplayMember = "CustomerName";
            this.cmbBillto.FormattingEnabled = true;
            this.cmbBillto.Location = new System.Drawing.Point(74, 65);
            this.cmbBillto.Name = "cmbBillto";
            this.cmbBillto.Size = new System.Drawing.Size(259, 21);
            this.cmbBillto.TabIndex = 37;
            this.cmbBillto.ValueMember = "ID";
            // 
            // CustomerSource
            // 
            this.CustomerSource.DataSource = typeof(SalesAndMonitoring.Database.Customer);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(-10, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 8);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Transaction #:";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(619, 112);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(184, 20);
            this.textBox11.TabIndex = 56;
            this.textBox11.Text = "Generated Transaction Number";
            // 
            // dtpTransDate
            // 
            this.dtpTransDate.Location = new System.Drawing.Point(619, 137);
            this.dtpTransDate.Name = "dtpTransDate";
            this.dtpTransDate.Size = new System.Drawing.Size(184, 20);
            this.dtpTransDate.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(504, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Transaction Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGrandtotal);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(564, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 94);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            // 
            // txtGrandtotal
            // 
            this.txtGrandtotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtGrandtotal.Enabled = false;
            this.txtGrandtotal.Location = new System.Drawing.Point(93, 67);
            this.txtGrandtotal.Name = "txtGrandtotal";
            this.txtGrandtotal.Size = new System.Drawing.Size(116, 20);
            this.txtGrandtotal.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Grand Total";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Location = new System.Drawing.Point(93, 41);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(116, 20);
            this.txtDiscount.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Discount";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(93, 15);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(116, 20);
            this.txtSubtotal.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Sub Total";
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.BackColor = System.Drawing.Color.DarkGray;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Image = global::SalesAndMonitoring.Properties.Resources.users;
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Location = new System.Drawing.Point(-1, -1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(820, 44);
            this.lblHeader.TabIndex = 34;
            this.lblHeader.Text = "       Walk-in Transaction";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(24, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 31);
            this.textBox1.TabIndex = 72;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "ENTER DESCRIPTION:";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDetailIDDataGridViewTextBoxColumn,
            this.orderlIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.ProductName,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.isVoidDataGridViewTextBoxColumn,
            this.isReturnDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.OrderDetailSource;
            this.dataGrid.Location = new System.Drawing.Point(24, 207);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGrid.Size = new System.Drawing.Size(764, 111);
            this.dataGrid.TabIndex = 73;
            this.dataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellValueChanged);
            // 
            // orderDetailIDDataGridViewTextBoxColumn
            // 
            this.orderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "OrderDetailID";
            this.orderDetailIDDataGridViewTextBoxColumn.HeaderText = "OrderDetailID";
            this.orderDetailIDDataGridViewTextBoxColumn.Name = "orderDetailIDDataGridViewTextBoxColumn";
            this.orderDetailIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderlIDDataGridViewTextBoxColumn
            // 
            this.orderlIDDataGridViewTextBoxColumn.DataPropertyName = "OrderlID";
            this.orderlIDDataGridViewTextBoxColumn.HeaderText = "OrderlID";
            this.orderlIDDataGridViewTextBoxColumn.Name = "orderlIDDataGridViewTextBoxColumn";
            this.orderlIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductID";
            this.ProductName.DataSource = this.ProductSource;
            this.ProductName.DisplayMember = "ProductName";
            this.ProductName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.ValueMember = "ProductID";
            // 
            // ProductSource
            // 
            this.ProductSource.DataSource = typeof(SalesAndMonitoring.Database.Product);
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // isVoidDataGridViewTextBoxColumn
            // 
            this.isVoidDataGridViewTextBoxColumn.DataPropertyName = "IsVoid";
            this.isVoidDataGridViewTextBoxColumn.HeaderText = "IsVoid";
            this.isVoidDataGridViewTextBoxColumn.Name = "isVoidDataGridViewTextBoxColumn";
            this.isVoidDataGridViewTextBoxColumn.Visible = false;
            // 
            // isReturnDataGridViewTextBoxColumn
            // 
            this.isReturnDataGridViewTextBoxColumn.DataPropertyName = "IsReturn";
            this.isReturnDataGridViewTextBoxColumn.HeaderText = "IsReturn";
            this.isReturnDataGridViewTextBoxColumn.Name = "isReturnDataGridViewTextBoxColumn";
            this.isReturnDataGridViewTextBoxColumn.Visible = false;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            this.orderDataGridViewTextBoxColumn.Visible = false;
            // 
            // OrderDetailSource
            // 
            this.OrderDetailSource.DataSource = typeof(SalesAndMonitoring.Database.Order_Detail);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::SalesAndMonitoring.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(354, 332);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 79);
            this.btnSearch.TabIndex = 74;
            this.btnSearch.Text = "SEARCH ITEM";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCash
            // 
            this.btnCash.Image = global::SalesAndMonitoring.Properties.Resources.database;
            this.btnCash.Location = new System.Drawing.Point(459, 332);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(99, 79);
            this.btnCash.TabIndex = 77;
            this.btnCash.Text = "CASH PAYMENT";
            this.btnCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // OrderSource
            // 
            this.OrderSource.DataSource = typeof(SalesAndMonitoring.Database.Order);
            // 
            // PaymentSource
            // 
            this.PaymentSource.DataSource = typeof(SalesAndMonitoring.Database.Payment);
            // 
            // frmTransactionWalkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 426);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtpTransDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbBillto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransactionWalkin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Walk-in Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBillto;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.DateTimePicker dtpTransDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGrandtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource OrderDetailSource;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource OrderSource;
        private System.Windows.Forms.BindingSource CustomerSource;
        private System.Windows.Forms.BindingSource ProductSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderlIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isVoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isReturnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource PaymentSource;
    }
}