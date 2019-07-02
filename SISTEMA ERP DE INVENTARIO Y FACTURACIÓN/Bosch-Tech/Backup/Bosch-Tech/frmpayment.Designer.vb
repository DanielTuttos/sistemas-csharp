<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpayment
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtpaidamt = New System.Windows.Forms.TextBox
        Me.txtbalanceamt = New System.Windows.Forms.TextBox
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txttotalamt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtcustcode = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Paid Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Balance Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PAYMENT"
        '
        'txtpaidamt
        '
        Me.txtpaidamt.Location = New System.Drawing.Point(250, 227)
        Me.txtpaidamt.Name = "txtpaidamt"
        Me.txtpaidamt.Size = New System.Drawing.Size(100, 20)
        Me.txtpaidamt.TabIndex = 7
        Me.txtpaidamt.Text = "0"
        '
        'txtbalanceamt
        '
        Me.txtbalanceamt.Enabled = False
        Me.txtbalanceamt.Location = New System.Drawing.Point(250, 186)
        Me.txtbalanceamt.Name = "txtbalanceamt"
        Me.txtbalanceamt.Size = New System.Drawing.Size(100, 20)
        Me.txtbalanceamt.TabIndex = 8
        Me.txtbalanceamt.Tag = ""
        Me.txtbalanceamt.Text = "0"
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(144, 270)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 34)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Customer code"
        '
        'txttotalamt
        '
        Me.txttotalamt.Enabled = False
        Me.txttotalamt.Location = New System.Drawing.Point(250, 137)
        Me.txttotalamt.Name = "txttotalamt"
        Me.txttotalamt.Size = New System.Drawing.Size(100, 20)
        Me.txttotalamt.TabIndex = 36
        Me.txttotalamt.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Total Amount"
        '
        'txtcustcode
        '
        Me.txtcustcode.FormattingEnabled = True
        Me.txtcustcode.Location = New System.Drawing.Point(250, 95)
        Me.txtcustcode.Name = "txtcustcode"
        Me.txtcustcode.Size = New System.Drawing.Size(121, 21)
        Me.txtcustcode.TabIndex = 37
        '
        'frmpayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bosch_Tech.My.Resources.Resources.ghf
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(462, 355)
        Me.Controls.Add(Me.txtcustcode)
        Me.Controls.Add(Me.txttotalamt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtbalanceamt)
        Me.Controls.Add(Me.txtpaidamt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmpayment"
        Me.Text = "frmpayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpaidamt As System.Windows.Forms.TextBox
    Friend WithEvents txtbalanceamt As System.Windows.Forms.TextBox
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttotalamt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcustcode As System.Windows.Forms.ComboBox
End Class
