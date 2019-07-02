<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsupplierorder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtorderno = New System.Windows.Forms.TextBox
        Me.txtprdname = New System.Windows.Forms.TextBox
        Me.txtprdqty = New System.Windows.Forms.TextBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btncancl = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cmbordertype = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnok = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbsuplname = New System.Windows.Forms.ComboBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Supplier Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Product Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Product Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(72, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Order Date"
        '
        'txtorderno
        '
        Me.txtorderno.Enabled = False
        Me.txtorderno.Location = New System.Drawing.Point(257, 58)
        Me.txtorderno.Name = "txtorderno"
        Me.txtorderno.Size = New System.Drawing.Size(200, 20)
        Me.txtorderno.TabIndex = 6
        '
        'txtprdname
        '
        Me.txtprdname.Location = New System.Drawing.Point(147, 25)
        Me.txtprdname.Name = "txtprdname"
        Me.txtprdname.Size = New System.Drawing.Size(200, 26)
        Me.txtprdname.TabIndex = 10
        '
        'txtprdqty
        '
        Me.txtprdqty.Location = New System.Drawing.Point(147, 66)
        Me.txtprdqty.Name = "txtprdqty"
        Me.txtprdqty.Size = New System.Drawing.Size(200, 26)
        Me.txtprdqty.TabIndex = 11
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(72, 468)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(103, 30)
        Me.btnadd.TabIndex = 13
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(213, 468)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(103, 30)
        Me.btnreset.TabIndex = 14
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btncancl
        '
        Me.btncancl.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancl.Location = New System.Drawing.Point(336, 468)
        Me.btncancl.Name = "btncancl"
        Me.btncancl.Size = New System.Drawing.Size(103, 30)
        Me.btncancl.TabIndex = 15
        Me.btncancl.Text = "CANCEL"
        Me.btncancl.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(258, 367)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'cmbordertype
        '
        Me.cmbordertype.FormattingEnabled = True
        Me.cmbordertype.Items.AddRange(New Object() {"Teleorder", "Emailorder", "CounterOrder"})
        Me.cmbordertype.Location = New System.Drawing.Point(258, 88)
        Me.cmbordertype.Name = "cmbordertype"
        Me.cmbordertype.Size = New System.Drawing.Size(200, 21)
        Me.cmbordertype.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtprdname)
        Me.GroupBox1.Controls.Add(Me.txtprdqty)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(66, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 159)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(147, 111)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 28)
        Me.btnok.TabIndex = 13
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(147, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 95)
        Me.ListBox1.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(393, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(253, 114)
        Me.DataGridView1.TabIndex = 12
        '
        'Column1
        '
        Me.Column1.HeaderText = "ProductCode"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 21)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "SUPPLIER ORDER"
        '
        'cmbsuplname
        '
        Me.cmbsuplname.FormattingEnabled = True
        Me.cmbsuplname.Location = New System.Drawing.Point(258, 129)
        Me.cmbsuplname.Name = "cmbsuplname"
        Me.cmbsuplname.Size = New System.Drawing.Size(200, 21)
        Me.cmbsuplname.TabIndex = 21
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(459, 468)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(112, 30)
        Me.btnprint.TabIndex = 25
        Me.btnprint.Text = "PRINT"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'frmsupplierorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.Bosch_Tech.My.Resources.Resources.ghf2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(848, 552)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.cmbsuplname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbordertype)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btncancl)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtorderno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmsupplierorder"
        Me.Text = "frmsupplierorder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtorderno As System.Windows.Forms.TextBox
    Friend WithEvents txtprdname As System.Windows.Forms.TextBox
    Friend WithEvents txtprdqty As System.Windows.Forms.TextBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btncancl As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbordertype As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbsuplname As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
