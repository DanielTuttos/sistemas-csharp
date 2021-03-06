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
    public class driverInvoice : DataSet {
        
        private DriverDataTable tableDriver;
        
        public driverInvoice() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected driverInvoice(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Driver"] != null)) {
                    this.Tables.Add(new DriverDataTable(ds.Tables["Driver"]));
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
        public DriverDataTable Driver {
            get {
                return this.tableDriver;
            }
        }
        
        public override DataSet Clone() {
            driverInvoice cln = ((driverInvoice)(base.Clone()));
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
            if ((ds.Tables["Driver"] != null)) {
                this.Tables.Add(new DriverDataTable(ds.Tables["Driver"]));
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
            this.tableDriver = ((DriverDataTable)(this.Tables["Driver"]));
            if ((this.tableDriver != null)) {
                this.tableDriver.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "driverInvoice";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/driverInvoice.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableDriver = new DriverDataTable();
            this.Tables.Add(this.tableDriver);
        }
        
        private bool ShouldSerializeDriver() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void DriverRowChangeEventHandler(object sender, DriverRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class DriverDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnAddress;
            
            private DataColumn columnCommision;
            
            private DataColumn columnDriverID;
            
            private DataColumn columnFirstName;
            
            private DataColumn columnLastName;
            
            private DataColumn columnSalary;
            
            internal DriverDataTable() : 
                    base("Driver") {
                this.InitClass();
            }
            
            internal DriverDataTable(DataTable table) : 
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
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn CommisionColumn {
                get {
                    return this.columnCommision;
                }
            }
            
            internal DataColumn DriverIDColumn {
                get {
                    return this.columnDriverID;
                }
            }
            
            internal DataColumn FirstNameColumn {
                get {
                    return this.columnFirstName;
                }
            }
            
            internal DataColumn LastNameColumn {
                get {
                    return this.columnLastName;
                }
            }
            
            internal DataColumn SalaryColumn {
                get {
                    return this.columnSalary;
                }
            }
            
            public DriverRow this[int index] {
                get {
                    return ((DriverRow)(this.Rows[index]));
                }
            }
            
            public event DriverRowChangeEventHandler DriverRowChanged;
            
            public event DriverRowChangeEventHandler DriverRowChanging;
            
            public event DriverRowChangeEventHandler DriverRowDeleted;
            
            public event DriverRowChangeEventHandler DriverRowDeleting;
            
            public void AddDriverRow(DriverRow row) {
                this.Rows.Add(row);
            }
            
            public DriverRow AddDriverRow(string Address, System.Decimal Commision, string FirstName, string LastName, System.Decimal Salary) {
                DriverRow rowDriverRow = ((DriverRow)(this.NewRow()));
                rowDriverRow.ItemArray = new object[] {
                        Address,
                        Commision,
                        null,
                        FirstName,
                        LastName,
                        Salary};
                this.Rows.Add(rowDriverRow);
                return rowDriverRow;
            }
            
            public DriverRow FindByDriverID(int DriverID) {
                return ((DriverRow)(this.Rows.Find(new object[] {
                            DriverID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                DriverDataTable cln = ((DriverDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new DriverDataTable();
            }
            
            internal void InitVars() {
                this.columnAddress = this.Columns["Address"];
                this.columnCommision = this.Columns["Commision"];
                this.columnDriverID = this.Columns["DriverID"];
                this.columnFirstName = this.Columns["FirstName"];
                this.columnLastName = this.Columns["LastName"];
                this.columnSalary = this.Columns["Salary"];
            }
            
            private void InitClass() {
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnCommision = new DataColumn("Commision", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCommision);
                this.columnDriverID = new DataColumn("DriverID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDriverID);
                this.columnFirstName = new DataColumn("FirstName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFirstName);
                this.columnLastName = new DataColumn("LastName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLastName);
                this.columnSalary = new DataColumn("Salary", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSalary);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnDriverID}, true));
                this.columnDriverID.AutoIncrement = true;
                this.columnDriverID.AllowDBNull = false;
                this.columnDriverID.Unique = true;
            }
            
            public DriverRow NewDriverRow() {
                return ((DriverRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new DriverRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(DriverRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.DriverRowChanged != null)) {
                    this.DriverRowChanged(this, new DriverRowChangeEvent(((DriverRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.DriverRowChanging != null)) {
                    this.DriverRowChanging(this, new DriverRowChangeEvent(((DriverRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.DriverRowDeleted != null)) {
                    this.DriverRowDeleted(this, new DriverRowChangeEvent(((DriverRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.DriverRowDeleting != null)) {
                    this.DriverRowDeleting(this, new DriverRowChangeEvent(((DriverRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveDriverRow(DriverRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class DriverRow : DataRow {
            
            private DriverDataTable tableDriver;
            
            internal DriverRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableDriver = ((DriverDataTable)(this.Table));
            }
            
            public string Address {
                get {
                    try {
                        return ((string)(this[this.tableDriver.AddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDriver.AddressColumn] = value;
                }
            }
            
            public System.Decimal Commision {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableDriver.CommisionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDriver.CommisionColumn] = value;
                }
            }
            
            public int DriverID {
                get {
                    return ((int)(this[this.tableDriver.DriverIDColumn]));
                }
                set {
                    this[this.tableDriver.DriverIDColumn] = value;
                }
            }
            
            public string FirstName {
                get {
                    try {
                        return ((string)(this[this.tableDriver.FirstNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDriver.FirstNameColumn] = value;
                }
            }
            
            public string LastName {
                get {
                    try {
                        return ((string)(this[this.tableDriver.LastNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDriver.LastNameColumn] = value;
                }
            }
            
            public System.Decimal Salary {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableDriver.SalaryColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableDriver.SalaryColumn] = value;
                }
            }
            
            public bool IsAddressNull() {
                return this.IsNull(this.tableDriver.AddressColumn);
            }
            
            public void SetAddressNull() {
                this[this.tableDriver.AddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsCommisionNull() {
                return this.IsNull(this.tableDriver.CommisionColumn);
            }
            
            public void SetCommisionNull() {
                this[this.tableDriver.CommisionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFirstNameNull() {
                return this.IsNull(this.tableDriver.FirstNameColumn);
            }
            
            public void SetFirstNameNull() {
                this[this.tableDriver.FirstNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsLastNameNull() {
                return this.IsNull(this.tableDriver.LastNameColumn);
            }
            
            public void SetLastNameNull() {
                this[this.tableDriver.LastNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsSalaryNull() {
                return this.IsNull(this.tableDriver.SalaryColumn);
            }
            
            public void SetSalaryNull() {
                this[this.tableDriver.SalaryColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class DriverRowChangeEvent : EventArgs {
            
            private DriverRow eventRow;
            
            private DataRowAction eventAction;
            
            public DriverRowChangeEvent(DriverRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public DriverRow Row {
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
