<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.combouser = New System.Windows.Forms.ComboBox
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.btnlog = New System.Windows.Forms.Button
        Me.btnext = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(472, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Goudy Stout", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(472, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Goudy Stout", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(472, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'combouser
        '
        Me.combouser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combouser.ForeColor = System.Drawing.Color.Brown
        Me.combouser.FormattingEnabled = True
        Me.combouser.Items.AddRange(New Object() {"Admin", "User"})
        Me.combouser.Location = New System.Drawing.Point(678, 193)
        Me.combouser.Name = "combouser"
        Me.combouser.Size = New System.Drawing.Size(188, 21)
        Me.combouser.TabIndex = 3
        '
        'txtuser
        '
        Me.txtuser.ForeColor = System.Drawing.Color.Brown
        Me.txtuser.Location = New System.Drawing.Point(678, 280)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(188, 20)
        Me.txtuser.TabIndex = 4
        '
        'txtpass
        '
        Me.txtpass.ForeColor = System.Drawing.Color.Brown
        Me.txtpass.Location = New System.Drawing.Point(678, 316)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(188, 20)
        Me.txtpass.TabIndex = 5
        '
        'btnlog
        '
        Me.btnlog.BackColor = System.Drawing.Color.Black
        Me.btnlog.Font = New System.Drawing.Font("Goudy Stout", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlog.ForeColor = System.Drawing.Color.White
        Me.btnlog.Location = New System.Drawing.Point(559, 390)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(113, 28)
        Me.btnlog.TabIndex = 6
        Me.btnlog.Text = "LOGIN"
        Me.btnlog.UseVisualStyleBackColor = False
        '
        'btnext
        '
        Me.btnext.BackColor = System.Drawing.Color.Black
        Me.btnext.Font = New System.Drawing.Font("Goudy Stout", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnext.ForeColor = System.Drawing.Color.White
        Me.btnext.Location = New System.Drawing.Point(678, 390)
        Me.btnext.Name = "btnext"
        Me.btnext.Size = New System.Drawing.Size(123, 28)
        Me.btnext.TabIndex = 7
        Me.btnext.Text = "EXIT"
        Me.btnext.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Goudy Stout", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(448, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(497, 51)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "LOGIN HERE..."
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bosch_Tech.My.Resources.Resources.Leopard_Login_Backgrounds_by_LoafNinja
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 478)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnext)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.combouser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmlogin"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents combouser As System.Windows.Forms.ComboBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btnlog As System.Windows.Forms.Button
    Friend WithEvents btnext As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
