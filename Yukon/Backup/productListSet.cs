﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace Yukon {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class productListSet : DataSet {
        
        private ProductDataTable tableProduct;
        
        public productListSet() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected productListSet(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Product"] != null)) {
                    this.Tables.Add(new ProductDataTable(ds.Tables["Product"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public ProductDataTable Product {
            get {
                return this.tableProduct;
            }
        }
        
        public override DataSet Clone() {
            productListSet cln = ((productListSet)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["Product"] != null)) {
                this.Tables.Add(new ProductDataTable(ds.Tables["Product"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tableProduct = ((ProductDataTable)(this.Tables["Product"]));
            if ((this.tableProduct != null)) {
                this.tableProduct.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "productListSet";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/productListSet.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableProduct = new ProductDataTable();
            this.Tables.Add(this.tableProduct);
        }
        
        private bool ShouldSerializeProduct() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void ProductRowChangeEventHandler(object sender, ProductRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ProductDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnProductID;
            
            private DataColumn columnPorductName;
            
            private DataColumn columnWeight;
            
            internal ProductDataTable() : 
                    base("Product") {
                this.InitClass();
            }
            
            internal ProductDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn ProductIDColumn {
                get {
                    return this.columnProductID;
                }
            }
            
            internal DataColumn PorductNameColumn {
                get {
                    return this.columnPorductName;
                }
            }
            
            internal DataColumn WeightColumn {
                get {
                    return this.columnWeight;
                }
            }
            
            public ProductRow this[int index] {
                get {
                    return ((ProductRow)(this.Rows[index]));
                }
            }
            
            public event ProductRowChangeEventHandler ProductRowChanged;
            
            public event ProductRowChangeEventHandler ProductRowChanging;
            
            public event ProductRowChangeEventHandler ProductRowDeleted;
            
            public event ProductRowChangeEventHandler ProductRowDeleting;
            
            public void AddProductRow(ProductRow row) {
                this.Rows.Add(row);
            }
            
            public ProductRow AddProductRow(string PorductName, int Weight) {
                ProductRow rowProductRow = ((ProductRow)(this.NewRow()));
                rowProductRow.ItemArray = new object[] {
                        null,
                        PorductName,
                        Weight};
                this.Rows.Add(rowProductRow);
                return rowProductRow;
            }
            
            public ProductRow FindByProductID(int ProductID) {
                return ((ProductRow)(this.Rows.Find(new object[] {
                            ProductID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                ProductDataTable cln = ((ProductDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new ProductDataTable();
            }
            
            internal void InitVars() {
                this.columnProductID = this.Columns["ProductID"];
                this.columnPorductName = this.Columns["PorductName"];
                this.columnWeight = this.Columns["Weight"];
            }
            
            private void InitClass() {
                this.columnProductID = new DataColumn("ProductID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnProductID);
                this.columnPorductName = new DataColumn("PorductName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPorductName);
                this.columnWeight = new DataColumn("Weight", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnWeight);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnProductID}, true));
                this.columnProductID.AutoIncrement = true;
                this.columnProductID.AllowDBNull = false;
                this.columnProductID.Unique = true;
            }
            
            public ProductRow NewProductRow() {
                return ((ProductRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new ProductRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(ProductRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.ProductRowChanged != null)) {
                    this.ProductRowChanged(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.ProductRowChanging != null)) {
                    this.ProductRowChanging(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.ProductRowDeleted != null)) {
                    this.ProductRowDeleted(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.ProductRowDeleting != null)) {
                    this.ProductRowDeleting(this, new ProductRowChangeEvent(((ProductRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveProductRow(ProductRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ProductRow : DataRow {
            
            private ProductDataTable tableProduct;
            
            internal ProductRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableProduct = ((ProductDataTable)(this.Table));
            }
            
            public int ProductID {
                get {
                    return ((int)(this[this.tableProduct.ProductIDColumn]));
                }
                set {
                    this[this.tableProduct.ProductIDColumn] = value;
                }
            }
            
            public string PorductName {
                get {
                    try {
                        return ((string)(this[this.tableProduct.PorductNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProduct.PorductNameColumn] = value;
                }
            }
            
            public int Weight {
                get {
                    try {
                        return ((int)(this[this.tableProduct.WeightColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableProduct.WeightColumn] = value;
                }
            }
            
            public bool IsPorductNameNull() {
                return this.IsNull(this.tableProduct.PorductNameColumn);
            }
            
            public void SetPorductNameNull() {
                this[this.tableProduct.PorductNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsWeightNull() {
                return this.IsNull(this.tableProduct.WeightColumn);
            }
            
            public void SetWeightNull() {
                this[this.tableProduct.WeightColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class ProductRowChangeEvent : EventArgs {
            
            private ProductRow eventRow;
            
            private DataRowAction eventAction;
            
            public ProductRowChangeEvent(ProductRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public ProductRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
