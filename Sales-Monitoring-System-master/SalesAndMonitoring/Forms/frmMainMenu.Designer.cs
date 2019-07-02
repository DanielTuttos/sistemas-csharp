namespace SalesAndMonitoring
{
    partial class frmMainMenu
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
            System.Windows.Forms.ImageList ImageList1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("SALES", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("DELIVERY", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("INVENTORY", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("REPORTS", System.Windows.Forms.HorizontalAlignment.Left);
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ImageList1
            // 
            ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            ImageList1.Images.SetKeyName(0, "kuser.ico");
            ImageList1.Images.SetKeyName(1, "klipper.ico");
            ImageList1.Images.SetKeyName(2, "agt_family.ico");
            ImageList1.Images.SetKeyName(3, "personal.ico");
            ImageList1.Images.SetKeyName(4, "galeon.ico");
            ImageList1.Images.SetKeyName(5, "date.ico");
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.DarkGray;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Image = global::SalesAndMonitoring.Properties.Resources.users;
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(504, 37);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "       Main Menu";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(-3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 8);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.AutoArrange = false;
            this.listView1.GridLines = true;
            listViewGroup1.Header = "SALES";
            listViewGroup1.Name = "GroupSales";
            listViewGroup2.Header = "DELIVERY";
            listViewGroup2.Name = "GroupDelivery";
            listViewGroup3.Header = "INVENTORY";
            listViewGroup3.Name = "GroupInventory";
            listViewGroup4.Header = "REPORTS";
            listViewGroup4.Name = "GroupReport";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listView1.LargeImageList = ImageList1;
            this.listView1.Location = new System.Drawing.Point(12, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(476, 328);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(504, 394);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;

    }
}