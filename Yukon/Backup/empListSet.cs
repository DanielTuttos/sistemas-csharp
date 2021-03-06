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
    public class empListSet : DataSet {
        
        private EmployeeDataTable tableEmployee;
        
        public empListSet() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected empListSet(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Employee"] != null)) {
                    this.Tables.Add(new EmployeeDataTable(ds.Tables["Employee"]));
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
        public EmployeeDataTable Employee {
            get {
                return this.tableEmployee;
            }
        }
        
        public override DataSet Clone() {
            empListSet cln = ((empListSet)(base.Clone()));
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
            if ((ds.Tables["Employee"] != null)) {
                this.Tables.Add(new EmployeeDataTable(ds.Tables["Employee"]));
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
            this.tableEmployee = ((EmployeeDataTable)(this.Tables["Employee"]));
            if ((this.tableEmployee != null)) {
                this.tableEmployee.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "empListSet";
            this.Prefix = "";
            this.Namespace = "http://www.tempuri.org/empListSet.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableEmployee = new EmployeeDataTable();
            this.Tables.Add(this.tableEmployee);
        }
        
        private bool ShouldSerializeEmployee() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void EmployeeRowChangeEventHandler(object sender, EmployeeRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeeDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnEmployeeID;
            
            private DataColumn columnFirstName;
            
            private DataColumn columnLastName;
            
            private DataColumn columnAddress;
            
            private DataColumn columnJobType;
            
            private DataColumn columnSalary;
            
            internal EmployeeDataTable() : 
                    base("Employee") {
                this.InitClass();
            }
            
            internal EmployeeDataTable(DataTable table) : 
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
            
            internal DataColumn EmployeeIDColumn {
                get {
                    return this.columnEmployeeID;
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
            
            internal DataColumn AddressColumn {
                get {
                    return this.columnAddress;
                }
            }
            
            internal DataColumn JobTypeColumn {
                get {
                    return this.columnJobType;
                }
            }
            
            internal DataColumn SalaryColumn {
                get {
                    return this.columnSalary;
                }
            }
            
            public EmployeeRow this[int index] {
                get {
                    return ((EmployeeRow)(this.Rows[index]));
                }
            }
            
            public event EmployeeRowChangeEventHandler EmployeeRowChanged;
            
            public event EmployeeRowChangeEventHandler EmployeeRowChanging;
            
            public event EmployeeRowChangeEventHandler EmployeeRowDeleted;
            
            public event EmployeeRowChangeEventHandler EmployeeRowDeleting;
            
            public void AddEmployeeRow(EmployeeRow row) {
                this.Rows.Add(row);
            }
            
            public EmployeeRow AddEmployeeRow(string FirstName, string LastName, string Address, string JobType, System.Decimal Salary) {
                EmployeeRow rowEmployeeRow = ((EmployeeRow)(this.NewRow()));
                rowEmployeeRow.ItemArray = new object[] {
                        null,
                        FirstName,
                        LastName,
                        Address,
                        JobType,
                        Salary};
                this.Rows.Add(rowEmployeeRow);
                return rowEmployeeRow;
            }
            
            public EmployeeRow FindByEmployeeID(int EmployeeID) {
                return ((EmployeeRow)(this.Rows.Find(new object[] {
                            EmployeeID})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                EmployeeDataTable cln = ((EmployeeDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new EmployeeDataTable();
            }
            
            internal void InitVars() {
                this.columnEmployeeID = this.Columns["EmployeeID"];
                this.columnFirstName = this.Columns["FirstName"];
                this.columnLastName = this.Columns["LastName"];
                this.columnAddress = this.Columns["Address"];
                this.columnJobType = this.Columns["JobType"];
                this.columnSalary = this.Columns["Salary"];
            }
            
            private void InitClass() {
                this.columnEmployeeID = new DataColumn("EmployeeID", typeof(int), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnEmployeeID);
                this.columnFirstName = new DataColumn("FirstName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFirstName);
                this.columnLastName = new DataColumn("LastName", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnLastName);
                this.columnAddress = new DataColumn("Address", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAddress);
                this.columnJobType = new DataColumn("JobType", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnJobType);
                this.columnSalary = new DataColumn("Salary", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnSalary);
                this.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[] {
                                this.columnEmployeeID}, true));
                this.columnEmployeeID.AutoIncrement = true;
                this.columnEmployeeID.AllowDBNull = false;
                this.columnEmployeeID.Unique = true;
            }
            
            public EmployeeRow NewEmployeeRow() {
                return ((EmployeeRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new EmployeeRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(EmployeeRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.EmployeeRowChanged != null)) {
                    this.EmployeeRowChanged(this, new EmployeeRowChangeEvent(((EmployeeRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.EmployeeRowChanging != null)) {
                    this.EmployeeRowChanging(this, new EmployeeRowChangeEvent(((EmployeeRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.EmployeeRowDeleted != null)) {
                    this.EmployeeRowDeleted(this, new EmployeeRowChangeEvent(((EmployeeRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.EmployeeRowDeleting != null)) {
                    this.EmployeeRowDeleting(this, new EmployeeRowChangeEvent(((EmployeeRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveEmployeeRow(EmployeeRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeeRow : DataRow {
            
            private EmployeeDataTable tableEmployee;
            
            internal EmployeeRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableEmployee = ((EmployeeDataTable)(this.Table));
            }
            
            public int EmployeeID {
                get {
                    return ((int)(this[this.tableEmployee.EmployeeIDColumn]));
                }
                set {
                    this[this.tableEmployee.EmployeeIDColumn] = value;
                }
            }
            
            public string FirstName {
                get {
                    try {
                        return ((string)(this[this.tableEmployee.FirstNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployee.FirstNameColumn] = value;
                }
            }
            
            public string LastName {
                get {
                    try {
                        return ((string)(this[this.tableEmployee.LastNameColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployee.LastNameColumn] = value;
                }
            }
            
            public string Address {
                get {
                    try {
                        return ((string)(this[this.tableEmployee.AddressColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployee.AddressColumn] = value;
                }
            }
            
            public string JobType {
                get {
                    try {
                        return ((string)(this[this.tableEmployee.JobTypeColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployee.JobTypeColumn] = value;
                }
            }
            
            public System.Decimal Salary {
                get {
                    try {
                        return ((System.Decimal)(this[this.tableEmployee.SalaryColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("Cannot get value because it is DBNull.", e);
                    }
                }
                set {
                    this[this.tableEmployee.SalaryColumn] = value;
                }
            }
            
            public bool IsFirstNameNull() {
                return this.IsNull(this.tableEmployee.FirstNameColumn);
            }
            
            public void SetFirstNameNull() {
                this[this.tableEmployee.FirstNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsLastNameNull() {
                return this.IsNull(this.tableEmployee.LastNameColumn);
            }
            
            public void SetLastNameNull() {
                this[this.tableEmployee.LastNameColumn] = System.Convert.DBNull;
            }
            
            public bool IsAddressNull() {
                return this.IsNull(this.tableEmployee.AddressColumn);
            }
            
            public void SetAddressNull() {
                this[this.tableEmployee.AddressColumn] = System.Convert.DBNull;
            }
            
            public bool IsJobTypeNull() {
                return this.IsNull(this.tableEmployee.JobTypeColumn);
            }
            
            public void SetJobTypeNull() {
                this[this.tableEmployee.JobTypeColumn] = System.Convert.DBNull;
            }
            
            public bool IsSalaryNull() {
                return this.IsNull(this.tableEmployee.SalaryColumn);
            }
            
            public void SetSalaryNull() {
                this[this.tableEmployee.SalaryColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class EmployeeRowChangeEvent : EventArgs {
            
            private EmployeeRow eventRow;
            
            private DataRowAction eventAction;
            
            public EmployeeRowChangeEvent(EmployeeRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public EmployeeRow Row {
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
