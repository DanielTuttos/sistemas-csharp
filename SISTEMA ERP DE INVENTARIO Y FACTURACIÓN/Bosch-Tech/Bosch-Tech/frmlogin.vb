Public Class frmlogin

    Private Sub btnlog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlog.Click
        If combouser.Text = "" And txtuser.Text = "" And txtpass.Text = "" Then
            MsgBox("Enter all the Fields")
        ElseIf combouser.Text = "" Then
            MsgBox("select user type")
        ElseIf txtuser.Text = "" Then
            MsgBox("Enter the username")
        ElseIf txtpass.Text = "" Then
            MsgBox("Enter the password")
        Else
            If combouser.Text = "Admin" Then
                sql = "select * from tbl_log where log_utype='" & combouser.Text & "' and log_uname='" & txtuser.Text & "' and log_upass='" & txtpass.Text & "'"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
                If rs.EOF = False Then
                    usrtype = combouser.Text
                    username = txtuser.Text
                    Password = txtpass.Text
                    MsgBox("Login Success")
                    txtuser.Text = ""
                    txtpass.Text = ""
                    combouser.Text = ""
                    Me.Hide()
                    frmmaster.Show()

                Else
                    MsgBox("Login Failed")
                End If
            End If
            If combouser.Text = "User" Then
                sql = "select * from tbl_register where u_name='" & txtuser.Text & "' and u_pass='" & txtpass.Text & "'"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
                If rs.EOF = False Then
                    usrtype = combouser.Text
                    username = txtuser.Text
                    Password = txtpass.Text
                    MsgBox("Login Success")
                    txtuser.Text = ""
                    txtpass.Text = ""
                    combouser.Text = ""
                    Me.Hide()
                    frmmaster.Show()
                Else

                    MsgBox("Login failed")
                    combouser.Text = ""
                    txtuser.Text = ""
                    txtpass.Text = ""
                End If
            End If
        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "insert into tbl_login (log_utype,log_uname,log_upass)"
        sql = sql & "values ('" & combouser.Text & "','" & txtuser.Text & "','" & txtpass.Text & "')"
        conn.Execute(sql)
        MsgBox("record inserted ")


    End Sub

    Private Sub btnRst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnext.Click
        End
    End Sub
End Class
