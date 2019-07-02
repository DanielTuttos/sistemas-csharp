Imports System.Data.SqlClient
Public Class frmLogin
    Dim frm As New frmMainMenu
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If Len(Trim(UserID.Text)) = 0 Then
            MessageBox.Show("Please enter user id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UserID.Focus()
            Exit Sub
        End If
        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Password.Focus()
            Exit Sub
        End If
       

                MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                UserID.Text = ""
                Password.Text = ""
                UserID.Focus()

            cmd.Dispose()
            con.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        frmChangePassword.Show()
        frmChangePassword.UserID.Text = ""
        frmChangePassword.OldPassword.Text = ""
        frmChangePassword.NewPassword.Text = ""
        frmChangePassword.ConfirmPassword.Text = ""
        frmChangePassword.UserID.Focus()
    End Sub

    Private Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Panel1.Location = New Point(Me.ClientSize.Width / 2 - Panel1.Size.Width / 2, Me.ClientSize.Height / 2 - Panel1.Size.Height / 2)
        Panel1.Anchor = AnchorStyles.None
      
    End Sub

    Private Sub frmLogin_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
    Sub OSKeyboard()
        Dim old As Long
        If Environment.Is64BitOperatingSystem Then
            If Wow64DisableWow64FsRedirection(old) Then
                Process.Start("osk.exe")
                Wow64EnableWow64FsRedirection(old)
            End If
        Else
            Process.Start("osk.exe")
        End If
    End Sub
    Private Sub btnKeyboard_Click(sender As System.Object, e As System.EventArgs) Handles btnKeyboard.Click
        OSKeyboard()
    End Sub

 
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        lblDateTime.Text = Now.ToString()
    End Sub
End Class
