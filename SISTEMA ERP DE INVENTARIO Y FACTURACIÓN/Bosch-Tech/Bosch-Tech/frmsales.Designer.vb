<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbcustorno = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcustcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttotalamt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfinalamount = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttinno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Seleccione el número de pedido del cliente"
        '
        'cmbcustorno
        '
        Me.cmbcustorno.FormattingEnabled = True
        Me.cmbcustorno.Location = New System.Drawing.Point(419, 52)
        Me.cmbcustorno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbcustorno.Name = "cmbcustorno"
        Me.cmbcustorno.Size = New System.Drawing.Size(180, 24)
        Me.cmbcustorno.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column1, Me.Column2, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 137)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1128, 260)
        Me.DataGridView1.TabIndex = 7
        '
        'Column3
        '
        Me.Column3.HeaderText = "ProductCode"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qty"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "UnitPrice"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "TotalPrice"
        Me.Column6.Name = "Column6"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Discount"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Amount after discount"
        Me.Column2.Name = "Column2"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Tax"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "amount after tax"
        Me.Column8.Name = "Column8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Código de cliente"
        '
        'txtcustcode
        '
        Me.txtcustcode.Location = New System.Drawing.Point(233, 100)
        Me.txtcustcode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcustcode.Name = "txtcustcode"
        Me.txtcustcode.Size = New System.Drawing.Size(132, 22)
        Me.txtcustcode.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 400)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Cantidad total"
        '
        'txttotalamt
        '
        Me.txttotalamt.Location = New System.Drawing.Point(328, 398)
        Me.txttotalamt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttotalamt.Name = "txttotalamt"
        Me.txttotalamt.Size = New System.Drawing.Size(132, 22)
        Me.txttotalamt.TabIndex = 34
        Me.txttotalamt.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(131, 442)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Balance anterior"
        '
        'txtbalance
        '
        Me.txtbalance.Location = New System.Drawing.Point(328, 441)
        Me.txtbalance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(132, 22)
        Me.txtbalance.TabIndex = 37
        Me.txtbalance.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 482)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 23)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "El monto a pagar"
        '
        'txtfinalamount
        '
        Me.txtfinalamount.Location = New System.Drawing.Point(328, 486)
        Me.txtfinalamount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfinalamount.Name = "txtfinalamount"
        Me.txtfinalamount.Size = New System.Drawing.Size(132, 22)
        Me.txtfinalamount.TabIndex = 39
        Me.txtfinalamount.Text = "0"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(495, 523)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(142, 62)
        Me.btnsave.TabIndex = 41
        Me.btnsave.Text = "GUARDAR"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(228, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 23)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Numero"
        '
        'txtbillno
        '
        Me.txtbillno.Enabled = False
        Me.txtbillno.Location = New System.Drawing.Point(352, 14)
        Me.txtbillno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(132, 22)
        Me.txtbillno.TabIndex = 43
        '
        'txtcustname
        '
        Me.txtcustname.Location = New System.Drawing.Point(593, 100)
        Me.txtcustname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(132, 22)
        Me.txtcustname.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(417, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 23)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Nombre del cliente"
        '
        'txttinno
        '
        Me.txttinno.Location = New System.Drawing.Point(979, 96)
        Me.txttinno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttinno.Name = "txttinno"
        Me.txttinno.Size = New System.Drawing.Size(132, 22)
        Me.txttinno.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(772, 98)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 23)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Cliente"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(664, 521)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 66)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "IMPRIMIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmsales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.Bosch_Tech.My.Resources.Resources.ghf
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 590)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttinno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbillno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtfinalamount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbalance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txttotalamt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcustcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbcustorno)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmsales"
        Me.Text = "frmsales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbcustorno As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcustcode As System.Windows.Forms.TextBox
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttotalamt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfinalamount As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtbillno As System.Windows.Forms.TextBox
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttinno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
