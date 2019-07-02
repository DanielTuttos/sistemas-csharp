namespace SalesAndMonitoring
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statWeb = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewTrans = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrCurTime = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbNewTrans = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAddNew = new System.Windows.Forms.ToolStripButton();
            this.tbView = new System.Windows.Forms.ToolStripButton();
            this.tbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbExit = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.imgAd = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statUser,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel3,
            this.statDate,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel5,
            this.statTime,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel10,
            this.statWeb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(841, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Image = global::SalesAndMonitoring.Properties.Resources.users;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 19);
            this.toolStripStatusLabel1.Text = "Username: ";
            // 
            // statUser
            // 
            this.statUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statUser.Name = "statUser";
            this.statUser.Size = new System.Drawing.Size(80, 19);
            this.statUser.Text = " User Logged";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(16, 19);
            this.toolStripStatusLabel7.Text = "   ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Image = global::SalesAndMonitoring.Properties.Resources.calendar_date;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(56, 19);
            this.toolStripStatusLabel3.Text = "Date: ";
            // 
            // statDate
            // 
            this.statDate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statDate.Name = "statDate";
            this.statDate.Size = new System.Drawing.Size(113, 19);
            this.statDate.Text = "September 20, 2009";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(16, 19);
            this.toolStripStatusLabel8.Text = "   ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.Image = global::SalesAndMonitoring.Properties.Resources.clock;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(57, 19);
            this.toolStripStatusLabel5.Text = "Time: ";
            // 
            // statTime
            // 
            this.statTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statTime.Name = "statTime";
            this.statTime.Size = new System.Drawing.Size(60, 19);
            this.statTime.Text = "12:00 AM";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(43, 19);
            this.toolStripStatusLabel9.Text = "            ";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel10.Image = global::SalesAndMonitoring.Properties.Resources.computers;
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(75, 19);
            this.toolStripStatusLabel10.Text = "Website: ";
            // 
            // statWeb
            // 
            this.statWeb.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statWeb.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statWeb.IsLink = true;
            this.statWeb.Name = "statWeb";
            this.statWeb.Size = new System.Drawing.Size(4, 19);
            this.statWeb.Click += new System.EventHandler(this.statWeb_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.accessoriesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewTrans,
            this.toolStripMenuItem1,
            this.logOutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "&Archivo";
            // 
            // mnuNewTrans
            // 
            this.mnuNewTrans.Name = "mnuNewTrans";
            this.mnuNewTrans.Size = new System.Drawing.Size(162, 22);
            this.mnuNewTrans.Text = "New Transaction";
            this.mnuNewTrans.Click += new System.EventHandler(this.mnuNewTrans_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.table1ToolStripMenuItem,
            this.table2ToolStripMenuItem,
            this.manageCustomerToolStripMenuItem,
            this.transactionRecordsToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // table1ToolStripMenuItem
            // 
            this.table1ToolStripMenuItem.Name = "table1ToolStripMenuItem";
            this.table1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.table1ToolStripMenuItem.Text = "Manage Suppliers";
            this.table1ToolStripMenuItem.Click += new System.EventHandler(this.table1ToolStripMenuItem_Click);
            // 
            // table2ToolStripMenuItem
            // 
            this.table2ToolStripMenuItem.Name = "table2ToolStripMenuItem";
            this.table2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.table2ToolStripMenuItem.Text = "Manage Products";
            this.table2ToolStripMenuItem.Click += new System.EventHandler(this.table2ToolStripMenuItem_Click);
            // 
            // manageCustomerToolStripMenuItem
            // 
            this.manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            this.manageCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageCustomerToolStripMenuItem.Text = "Manage Customers";
            this.manageCustomerToolStripMenuItem.Click += new System.EventHandler(this.manageCustomerToolStripMenuItem_Click);
            // 
            // transactionRecordsToolStripMenuItem
            // 
            this.transactionRecordsToolStripMenuItem.Name = "transactionRecordsToolStripMenuItem";
            this.transactionRecordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transactionRecordsToolStripMenuItem.Text = "Transaction Records";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.settingsToolStripMenuItem.Text = "Config";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // accessoriesToolStripMenuItem
            // 
            this.accessoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.internetBrowserToolStripMenuItem,
            this.taskManagerToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.commandLineToolStripMenuItem,
            this.systemInformationToolStripMenuItem});
            this.accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            this.accessoriesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.accessoriesToolStripMenuItem.Text = "Accessorios";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // internetBrowserToolStripMenuItem
            // 
            this.internetBrowserToolStripMenuItem.Name = "internetBrowserToolStripMenuItem";
            this.internetBrowserToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.internetBrowserToolStripMenuItem.Text = "Internet Browser";
            this.internetBrowserToolStripMenuItem.Click += new System.EventHandler(this.internetBrowserToolStripMenuItem_Click);
            // 
            // taskManagerToolStripMenuItem
            // 
            this.taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            this.taskManagerToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.taskManagerToolStripMenuItem.Text = "Task Manager";
            this.taskManagerToolStripMenuItem.Click += new System.EventHandler(this.taskManagerToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // commandLineToolStripMenuItem
            // 
            this.commandLineToolStripMenuItem.Name = "commandLineToolStripMenuItem";
            this.commandLineToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.commandLineToolStripMenuItem.Text = "Command Line";
            this.commandLineToolStripMenuItem.Click += new System.EventHandler(this.commandLineToolStripMenuItem_Click);
            // 
            // systemInformationToolStripMenuItem
            // 
            this.systemInformationToolStripMenuItem.Name = "systemInformationToolStripMenuItem";
            this.systemInformationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.systemInformationToolStripMenuItem.Text = "System Information";
            this.systemInformationToolStripMenuItem.Click += new System.EventHandler(this.systemInformationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyToolStripMenuItem,
            this.monthlyToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportsToolStripMenuItem.Text = "Reportes";
            // 
            // dailyToolStripMenuItem
            // 
            this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            this.dailyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.dailyToolStripMenuItem.Text = "Daily";
            // 
            // monthlyToolStripMenuItem
            // 
            this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.monthlyToolStripMenuItem.Text = "Monthly";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.helpToolStripMenuItem.Text = "Ayuda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tmrCurTime
            // 
            this.tmrCurTime.Enabled = true;
            this.tmrCurTime.Interval = 1000;
            this.tmrCurTime.Tick += new System.EventHandler(this.tmrCurTime_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNewTrans,
            this.toolStripSeparator1,
            this.tbAddNew,
            this.tbView,
            this.tbUpdate,
            this.tbDelete,
            this.toolStripSeparator2,
            this.tbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(841, 52);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbNewTrans
            // 
            this.tbNewTrans.AutoSize = false;
            this.tbNewTrans.Image = global::SalesAndMonitoring.Properties.Resources.applications;
            this.tbNewTrans.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbNewTrans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNewTrans.Name = "tbNewTrans";
            this.tbNewTrans.Size = new System.Drawing.Size(100, 49);
            this.tbNewTrans.Text = "Transaccion";
            this.tbNewTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbNewTrans.Click += new System.EventHandler(this.tbNewTrans_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // tbAddNew
            // 
            this.tbAddNew.AutoSize = false;
            this.tbAddNew.Image = global::SalesAndMonitoring.Properties.Resources.add;
            this.tbAddNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddNew.Name = "tbAddNew";
            this.tbAddNew.Size = new System.Drawing.Size(85, 49);
            this.tbAddNew.Text = "Nuevo";
            this.tbAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbAddNew.Click += new System.EventHandler(this.tbAddNew_Click);
            // 
            // tbView
            // 
            this.tbView.AutoSize = false;
            this.tbView.Image = global::SalesAndMonitoring.Properties.Resources.search;
            this.tbView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbView.Name = "tbView";
            this.tbView.Size = new System.Drawing.Size(85, 49);
            this.tbView.Text = "Ver";
            this.tbView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbView.Click += new System.EventHandler(this.tbView_Click);
            // 
            // tbUpdate
            // 
            this.tbUpdate.AutoSize = false;
            this.tbUpdate.Image = global::SalesAndMonitoring.Properties.Resources.blog_post_edit;
            this.tbUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(85, 49);
            this.tbUpdate.Text = "Editar";
            this.tbUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbUpdate.Click += new System.EventHandler(this.tbUpdate_Click);
            // 
            // tbDelete
            // 
            this.tbDelete.AutoSize = false;
            this.tbDelete.Image = global::SalesAndMonitoring.Properties.Resources.blog_post_delete;
            this.tbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(85, 49);
            this.tbDelete.Text = "Eliminar";
            this.tbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbDelete.Click += new System.EventHandler(this.tbDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // tbExit
            // 
            this.tbExit.AutoSize = false;
            this.tbExit.Image = global::SalesAndMonitoring.Properties.Resources.remove;
            this.tbExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbExit.Name = "tbExit";
            this.tbExit.Size = new System.Drawing.Size(85, 49);
            this.tbExit.Text = "Salir";
            this.tbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(709, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(6, 386);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.Color.DarkGray;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(715, 32);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(123, 39);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "12:00:00 AM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgAd
            // 
            this.imgAd.BackColor = System.Drawing.Color.DarkGray;
            this.imgAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgAd.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgAd.Location = new System.Drawing.Point(715, 76);
            this.imgAd.Name = "imgAd";
            this.imgAd.Size = new System.Drawing.Size(126, 386);
            this.imgAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAd.TabIndex = 11;
            this.imgAd.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(721, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgAd);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewTrans;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem table1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem table2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel statTime;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        private System.Windows.Forms.ToolStripStatusLabel statWeb;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.Timer tmrCurTime;
        private System.Windows.Forms.ToolStripButton tbNewTrans;
        private System.Windows.Forms.ToolStripButton tbAddNew;
        private System.Windows.Forms.ToolStripButton tbView;
        private System.Windows.Forms.ToolStripButton tbUpdate;
        private System.Windows.Forms.ToolStripButton tbDelete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandLineToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem transactionRecordsToolStripMenuItem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripMenuItem systemInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgAd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

