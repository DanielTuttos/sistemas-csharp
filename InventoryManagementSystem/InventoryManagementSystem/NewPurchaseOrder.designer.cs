namespace InventoryManagementSystem
{
    partial class NewPurchaseOrder
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
            this.lblPONum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvItemDetail = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataSet = new InventoryManagementSystem.StockDataSet();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSupplierName = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPONumber = new System.Windows.Forms.Label();
            this.itemsTableAdapter = new InventoryManagementSystem.StockDataSetTableAdapters.ItemsTableAdapter();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPONum
            // 
            this.lblPONum.AutoSize = true;
            this.lblPONum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPONum.Location = new System.Drawing.Point(115, 112);
            this.lblPONum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPONum.Name = "lblPONum";
            this.lblPONum.Size = new System.Drawing.Size(260, 25);
            this.lblPONum.TabIndex = 1;
            this.lblPONum.Text = "Número de orden de compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tienda";
            // 
            // dgvItemDetail
            // 
            this.dgvItemDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItemDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Description,
            this.UnitValue,
            this.TotalValue});
            this.dgvItemDetail.Location = new System.Drawing.Point(128, 325);
            this.dgvItemDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvItemDetail.Name = "dgvItemDetail";
            this.dgvItemDetail.Size = new System.Drawing.Size(732, 283);
            this.dgvItemDetail.TabIndex = 2;
            this.dgvItemDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemDetail_CellEndEdit);
            this.dgvItemDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemDetail_CellValueChanged);
            this.dgvItemDetail.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvItemDetail_CurrentCellDirtyStateChanged);
            // 
            // Item
            // 
            this.Item.DataSource = this.itemsBindingSource;
            this.Item.DisplayMember = "ItemCode";
            this.Item.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ValueMember = "ItemCode";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.stockDataSet;
            // 
            // stockDataSet
            // 
            this.stockDataSet.DataSetName = "StockDataSet";
            this.stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UnitValue
            // 
            this.UnitValue.HeaderText = "UnitValue (INR)";
            this.UnitValue.Name = "UnitValue";
            // 
            // TotalValue
            // 
            this.TotalValue.HeaderText = "TotalValue";
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.ReadOnly = true;
            // 
            // cbSupplierName
            // 
            this.cbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierName.FormattingEnabled = true;
            this.cbSupplierName.Location = new System.Drawing.Point(328, 162);
            this.cbSupplierName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSupplierName.Name = "cbSupplierName";
            this.cbSupplierName.Size = new System.Drawing.Size(328, 24);
            this.cbSupplierName.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(191, 214);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 25);
            this.lblDate.TabIndex = 5;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(215, 263);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(328, 24);
            this.cbLocation.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(101, 16);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(108, 66);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(19, 20);
            this.lblTotalValue.TabIndex = 7;
            this.lblTotalValue.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.lblTotalValue);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(593, 634);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 101);
            this.panel1.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 673);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save and Print ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPONumber
            // 
            this.lblPONumber.AutoSize = true;
            this.lblPONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPONumber.Location = new System.Drawing.Point(353, 112);
            this.lblPONumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Size = new System.Drawing.Size(0, 25);
            this.lblPONumber.TabIndex = 5;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.stockDataSet;
            // 
            // itemsBindingSource2
            // 
            this.itemsBindingSource2.DataMember = "Items";
            this.itemsBindingSource2.DataSource = this.stockDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(828, 65);
            this.label4.TabIndex = 1;
            this.label4.Text = "Formulario de orden de compra";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(295, 673);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(439, 673);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 28);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // NewPurchaseOrder
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1063, 729);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lblPONumber);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbSupplierName);
            this.Controls.Add(this.dgvItemDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPONum);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1081, 776);
            this.MinimumSize = new System.Drawing.Size(1081, 776);
            this.Name = "NewPurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de orden de compra";
            this.Load += new System.EventHandler(this.NewPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPONum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private StockDataSet stockDataSet;
        private InventoryManagementSystem.StockDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridView dgvItemDetail;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Windows.Forms.BindingSource itemsBindingSource2;
        private System.Windows.Forms.ComboBox cbSupplierName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPONumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewComboBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
        private System.Windows.Forms.Button btnReset;
    }
}