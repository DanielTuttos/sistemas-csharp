Public Class frmchangepass

    Private Sub frmchangepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()

    End Sub
    Sub clear()
        txtoldpass.Text = ""
        txtnewpass.Text = ""
        txtconfirmpass.Text = ""
    End Sub
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If usrtype = "Admin" Then
            sql = "select * from tbl_login where log_uname='" & username & "' and log_upass='" & txtoldpass.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                If txtnewpass.Text <> txtconfirmpass.Text Then
                    MsgBox("Password doesn't match")
                Else
                    sql = "update tbl_login set log_upass='" & txtnewpass.Text & "' where log_uname='" & username & "'"
                    conn.Execute(sql)
                    MsgBox("password changed")
                End If
            Else
                MsgBox("Invalid password")

            End If
            Else
                sql = "select * from tbl_register where u_name='" & username & "' and u_pass='" & txtoldpass.Text & "'"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
            If rs.EOF = False Then
                If txtnewpass.Text <> txtconfirmpass.Text Then
                    MsgBox("Password doesn't match")

                Else
                    sql = "update tbl_register set u_pass='" & txtnewpass.Text & "' where u_name='" & username & "'"
                    conn.Execute(sql)
                    MsgBox("password changed")
                End If
            Else
                MsgBox("Invalid password")
            End If
        End If
        clear()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class