<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchangepass
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
        Me.txtoldpass = New System.Windows.Forms.TextBox
        Me.txtnewpass = New System.Windows.Forms.TextBox
        Me.txtconfirmpass = New System.Windows.Forms.TextBox
        Me.btnok = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter the old password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter the new password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirm password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtoldpass
        '
        Me.txtoldpass.Location = New System.Drawing.Point(280, 93)
        Me.txtoldpass.Name = "txtoldpass"
        Me.txtoldpass.Size = New System.Drawing.Size(100, 20)
        Me.txtoldpass.TabIndex = 4
        '
        'txtnewpass
        '
        Me.txtnewpass.Location = New System.Drawing.Point(280, 143)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpass.Size = New System.Drawing.Size(100, 20)
        Me.txtnewpass.TabIndex = 5
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.Location = New System.Drawing.Point(280, 195)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpass.Size = New System.Drawing.Size(100, 20)
        Me.txtconfirmpass.TabIndex = 6
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(83, 274)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(93, 33)
        Me.btnok.TabIndex = 7
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(204, 274)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(101, 33)
        Me.btncancel.TabIndex = 8
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'frmchangepass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bosch_Tech.My.Resources.Resources.ghf1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(518, 400)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.txtconfirmpass)
        Me.Controls.Add(Me.txtnewpass)
        Me.Controls.Add(Me.txtoldpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmchangepass"
        Me.Text = "frmchangepass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtoldpass As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpass As System.Windows.Forms.TextBox
    Friend WithEvents txtconfirmpass As System.Windows.Forms.TextBox
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
