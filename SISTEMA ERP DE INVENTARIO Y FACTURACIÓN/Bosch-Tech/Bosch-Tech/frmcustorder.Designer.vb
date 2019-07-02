<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcustorder
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
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtcustordernum = New System.Windows.Forms.TextBox
        Me.cmbordertype = New System.Windows.Forms.ComboBox
        Me.cmbcustcode = New System.Windows.Forms.ComboBox
        Me.cmbprodcode = New System.Windows.Forms.ComboBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtavqty = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnok = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Order Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer order type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Order date"
        '
        'txtcustordernum
        '
        Me.txtcustordernum.Enabled = False
        Me.txtcustordernum.Location = New System.Drawing.Point(311, 76)
        Me.txtcustordernum.Name = "txtcustordernum"
        Me.txtcustordernum.Size = New System.Drawing.Size(160, 20)
        Me.txtcustordernum.TabIndex = 6
        '
        'cmbordertype
        '
        Me.cmbordertype.FormattingEnabled = True
        Me.cmbordertype.Items.AddRange(New Object() {"Tele_order", "E_mailOrder", "CounterOrder"})
        Me.cmbordertype.Location = New System.Drawing.Point(311, 120)
        Me.cmbordertype.Name = "cmbordertype"
        Me.cmbordertype.Size = New System.Drawing.Size(160, 21)
        Me.cmbordertype.TabIndex = 7
        '
        'cmbcustcode
        '
        Me.cmbcustcode.FormattingEnabled = True
        Me.cmbcustcode.Location = New System.Drawing.Point(311, 164)
        Me.cmbcustcode.Name = "cmbcustcode"
        Me.cmbcustcode.Size = New System.Drawing.Size(160, 21)
        Me.cmbcustcode.TabIndex = 8
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
        Me.txtqty.Location = New System.Drawing.Point(147, 127)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(160, 26)
        Me.txtqty.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(311, 419)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(96, 461)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(83, 31)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "CUSTOMER ORDER"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(215, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(340, 461)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 31)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtavqty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbprodcode)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 214)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 199)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'txtavqty
        '
        Me.txtavqty.Enabled = False
        Me.txtavqty.Location = New System.Drawing.Point(147, 68)
        Me.txtavqty.Name = "txtavqty"
        Me.txtavqty.Size = New System.Drawing.Size(145, 26)
        Me.txtavqty.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Available Qty"
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(147, 169)
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
        Me.Label9.Location = New System.Drawing.Point(6, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Product Quantity"
        '
        'frmcustorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bosch_Tech.My.Resources.Resources.ghf3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1048, 524)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbcustcode)
        Me.Controls.Add(Me.cmbordertype)
        Me.Controls.Add(Me.txtcustordernum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmcustorder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcustordernum As System.Windows.Forms.TextBox
    Friend WithEvents cmbordertype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcustcode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbprodcode As System.Windows.Forms.ComboBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtavqty As System.Windows.Forms.TextBox
End Class
