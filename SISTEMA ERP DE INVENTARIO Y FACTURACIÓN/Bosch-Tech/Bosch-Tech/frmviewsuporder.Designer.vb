<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewsuporder
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
        Me.cmbsuporderno = New System.Windows.Forms.ComboBox
        Me.cmbsuplname = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtprodcode = New System.Windows.Forms.TextBox
        Me.btnok = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtprdqty = New System.Windows.Forms.TextBox
        Me.cmbordertype = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnupdate = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnprint = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Select Order No"
        '
        'cmbsuporderno
        '
        Me.cmbsuporderno.FormattingEnabled = True
        Me.cmbsuporderno.Location = New System.Drawing.Point(189, 9)
        Me.cmbsuporderno.Name = "cmbsuporderno"
        Me.cmbsuporderno.Size = New System.Drawing.Size(121, 21)
        Me.cmbsuporderno.TabIndex = 20
        '
        'cmbsuplname
        '
        Me.cmbsuplname.FormattingEnabled = True
        Me.cmbsuplname.Location = New System.Drawing.Point(198, 92)
        Me.cmbsuplname.Name = "cmbsuplname"
        Me.cmbsuplname.Size = New System.Drawing.Size(200, 21)
        Me.cmbsuplname.TabIndex = 28
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtprodcode)
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtprdqty)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 159)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'txtprodcode
        '
        Me.txtprodcode.Location = New System.Drawing.Point(192, 25)
        Me.txtprodcode.Name = "txtprodcode"
        Me.txtprodcode.Size = New System.Drawing.Size(100, 26)
        Me.txtprodcode.TabIndex = 32
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(147, 98)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 28)
        Me.btnok.TabIndex = 13
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView2.Location = New System.Drawing.Point(412, 25)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(253, 114)
        Me.DataGridView2.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductCode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
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
        'txtprdqty
        '
        Me.txtprdqty.Location = New System.Drawing.Point(134, 66)
        Me.txtprdqty.Name = "txtprdqty"
        Me.txtprdqty.Size = New System.Drawing.Size(200, 26)
        Me.txtprdqty.TabIndex = 11
        '
        'cmbordertype
        '
        Me.cmbordertype.FormattingEnabled = True
        Me.cmbordertype.Items.AddRange(New Object() {"Teleorder", "Emailorder", "CounterOrder"})
        Me.cmbordertype.Location = New System.Drawing.Point(198, 51)
        Me.cmbordertype.Name = "cmbordertype"
        Me.cmbordertype.Size = New System.Drawing.Size(200, 21)
        Me.cmbordertype.TabIndex = 26
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(177, 381)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Order Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Supplier Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Order Type"
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(399, 381)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(102, 33)
        Me.btnupdate.TabIndex = 29
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Delivered", "Not Delivered"})
        Me.ComboBox1.Location = New System.Drawing.Point(198, 326)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 19)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Status"
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(507, 372)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(112, 30)
        Me.btnprint.TabIndex = 32
        Me.btnprint.Text = "PRINT"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'frmviewsuporder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bosch_Tech.My.Resources.Resources.ghf2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(870, 462)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.cmbsuplname)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbordertype)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbsuporderno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmviewsuporder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbsuporderno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsuplname As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtprdqty As System.Windows.Forms.TextBox
    Friend WithEvents cmbordertype As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtprodcode As System.Windows.Forms.TextBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
End Class
