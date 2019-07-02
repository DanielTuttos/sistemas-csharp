<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewcustorder
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
        Me.label1 = New System.Windows.Forms.Label
        Me.cmbcustornum = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnok = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbprodcode = New System.Windows.Forms.ComboBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cmbcustcode = New System.Windows.Forms.ComboBox
        Me.cmbordertype = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnupdate = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(79, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(163, 19)
        Me.label1.TabIndex = 19
        Me.label1.Text = "Select Customer Order"
        '
        'cmbcustornum
        '
        Me.cmbcustornum.FormattingEnabled = True
        Me.cmbcustornum.Location = New System.Drawing.Point(320, 25)
        Me.cmbcustornum.Name = "cmbcustornum"
        Me.cmbcustornum.Size = New System.Drawing.Size(160, 21)
        Me.cmbcustornum.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbprodcode)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 159)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'btnok
        '
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
        Me.DataGridView2.Location = New System.Drawing.Point(393, 39)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Product Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Product Quantity"
        '
        'cmbprodcode
        '
        Me.cmbprodcode.FormattingEnabled = True
        Me.cmbprodcode.Location = New System.Drawing.Point(147, 28)
        Me.cmbprodcode.Name = "cmbprodcode"
        Me.cmbprodcode.Size = New System.Drawing.Size(160, 27)
        Me.cmbprodcode.TabIndex = 9
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(147, 61)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(160, 26)
        Me.txtqty.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(320, 364)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker1.TabIndex = 34
        '
        'cmbcustcode
        '
        Me.cmbcustcode.FormattingEnabled = True
        Me.cmbcustcode.Location = New System.Drawing.Point(320, 109)
        Me.cmbcustcode.Name = "cmbcustcode"
        Me.cmbcustcode.Size = New System.Drawing.Size(160, 21)
        Me.cmbcustcode.TabIndex = 33
        '
        'cmbordertype
        '
        Me.cmbordertype.FormattingEnabled = True
        Me.cmbordertype.Items.AddRange(New Object() {"Tele_order", "E_mailOrder", "CounterOrder"})
        Me.cmbordertype.Location = New System.Drawing.Point(320, 65)
        Me.cmbordertype.Name = "cmbordertype"
        Me.cmbordertype.Size = New System.Drawing.Size(160, 21)
        Me.cmbordertype.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(79, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Order date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Customer code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Customer order type"
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(247, 410)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(99, 41)
        Me.btnupdate.TabIndex = 36
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'frmviewcustorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bosch_Tech.My.Resources.Resources.ghf4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(761, 463)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbcustcode)
        Me.Controls.Add(Me.cmbordertype)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbcustornum)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmviewcustorder"
        Me.Text = "frmviewcustorder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents cmbcustornum As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbprodcode As System.Windows.Forms.ComboBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbcustcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbordertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnupdate As System.Windows.Forms.Button
End Class
