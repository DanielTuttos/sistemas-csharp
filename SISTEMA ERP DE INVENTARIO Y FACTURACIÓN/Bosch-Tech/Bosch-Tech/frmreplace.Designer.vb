<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreplace
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
        Me.cmbprodcode = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbbillno = New System.Windows.Forms.ComboBox
        Me.txtqty = New System.Windows.Forms.TextBox
        Me.btnreplace = New System.Windows.Forms.Button
        Me.PQTY = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the Bill Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select the Product Code"
        '
        'cmbprodcode
        '
        Me.cmbprodcode.FormattingEnabled = True
        Me.cmbprodcode.Location = New System.Drawing.Point(252, 80)
        Me.cmbprodcode.Name = "cmbprodcode"
        Me.cmbprodcode.Size = New System.Drawing.Size(140, 21)
        Me.cmbprodcode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity"
        '
        'cmbbillno
        '
        Me.cmbbillno.FormattingEnabled = True
        Me.cmbbillno.Location = New System.Drawing.Point(252, 43)
        Me.cmbbillno.Name = "cmbbillno"
        Me.cmbbillno.Size = New System.Drawing.Size(140, 21)
        Me.cmbbillno.TabIndex = 5
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(250, 151)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(116, 20)
        Me.txtqty.TabIndex = 6
        '
        'btnreplace
        '
        Me.btnreplace.Location = New System.Drawing.Point(140, 199)
        Me.btnreplace.Name = "btnreplace"
        Me.btnreplace.Size = New System.Drawing.Size(87, 23)
        Me.btnreplace.TabIndex = 7
        Me.btnreplace.Text = "Replace"
        Me.btnreplace.UseVisualStyleBackColor = True
        '
        'PQTY
        '
        Me.PQTY.Location = New System.Drawing.Point(252, 107)
        Me.PQTY.Name = "PQTY"
        Me.PQTY.Size = New System.Drawing.Size(116, 20)
        Me.PQTY.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(63, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Purchased quantity"
        '
        'frmreplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bosch_Tech.My.Resources.Resources.ghf4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(533, 262)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PQTY)
        Me.Controls.Add(Me.btnreplace)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.cmbbillno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbprodcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmreplace"
        Me.Text = "frmreplace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbprodcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbbillno As System.Windows.Forms.ComboBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents btnreplace As System.Windows.Forms.Button
    Friend WithEvents PQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
