<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UserID As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.UserType = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnKeyboard = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UsernameLabel.ForeColor = System.Drawing.Color.DarkViolet
        Me.UsernameLabel.Location = New System.Drawing.Point(204, 21)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(84, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User ID"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PasswordLabel.ForeColor = System.Drawing.Color.DarkViolet
        Me.PasswordLabel.Location = New System.Drawing.Point(206, 85)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(96, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserID
        '
        Me.UserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserID.ForeColor = System.Drawing.Color.DarkViolet
        Me.UserID.Location = New System.Drawing.Point(209, 47)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(237, 35)
        Me.UserID.TabIndex = 0
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.DarkViolet
        Me.Password.Location = New System.Drawing.Point(209, 111)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Password.Size = New System.Drawing.Size(237, 35)
        Me.Password.TabIndex = 1
        '
        'UserType
        '
        Me.UserType.Location = New System.Drawing.Point(294, 21)
        Me.UserType.Name = "UserType"
        Me.UserType.Size = New System.Drawing.Size(55, 20)
        Me.UserType.TabIndex = 10
        Me.UserType.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DarkViolet
        Me.LinkLabel2.Location = New System.Drawing.Point(207, 246)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(138, 21)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Change Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel1.Controls.Add(Me.btnKeyboard)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Controls.Add(Me.UserType)
        Me.Panel1.Controls.Add(Me.LinkLabel2)
        Me.Panel1.Controls.Add(Me.UserID)
        Me.Panel1.Controls.Add(Me.PasswordLabel)
        Me.Panel1.Controls.Add(Me.Cancel)
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Controls.Add(Me.OK)
        Me.Panel1.Controls.Add(Me.LogoPictureBox)
        Me.Panel1.Location = New System.Drawing.Point(122, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 282)
        Me.Panel1.TabIndex = 0
        '
        'btnKeyboard
        '
        Me.btnKeyboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKeyboard.BackColor = System.Drawing.Color.Transparent
        Me.btnKeyboard.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnKeyboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnKeyboard.FlatAppearance.BorderSize = 0
        Me.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeyboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeyboard.Image = Global.PharmacyManagementSystem.My.Resources.Resources.ModernXP_09_Keyboard_icon__1_1
        Me.btnKeyboard.Location = New System.Drawing.Point(345, 230)
        Me.btnKeyboard.Name = "btnKeyboard"
        Me.btnKeyboard.Size = New System.Drawing.Size(52, 49)
        Me.btnKeyboard.TabIndex = 59
        Me.btnKeyboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKeyboard.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.DarkViolet
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Image = Global.PharmacyManagementSystem.My.Resources.Resources.Button_Delete_icon
        Me.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel.Location = New System.Drawing.Point(337, 172)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(109, 53)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "&Cancel"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.DarkViolet
        Me.OK.FlatAppearance.BorderSize = 0
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.White
        Me.OK.Image = Global.PharmacyManagementSystem.My.Resources.Resources.Button_Ok_icon1
        Me.OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OK.Location = New System.Drawing.Point(210, 172)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(121, 53)
        Me.OK.TabIndex = 2
        Me.OK.Text = "&Login"
        Me.OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OK.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.OrangeRed
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(18, 21)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(180, 204)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.DarkViolet
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(760, 50)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Login Form"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.BackColor = System.Drawing.Color.DarkViolet
        Me.lblDateTime.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDateTime.Location = New System.Drawing.Point(516, 15)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(109, 28)
        Me.lblDateTime.TabIndex = 14
        Me.lblDateTime.Text = "DateTime"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(759, 596)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserType As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnKeyboard As System.Windows.Forms.Button
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
