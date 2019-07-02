Public Class frmregistration

    Private Sub frmregistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        status()
        loadpass()
    End Sub
    Sub status()
        sql = "select * from tbl_emp where status='unregistered'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbid.Items.Clear()
        Do While Not rs.EOF
            cmbid.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregister.Click
        If txtpass.Text = "" Or txtuname.Text = "" Or cmbid.Text = "" Then
            MsgBox("Enter all the fields")
        Else
            sql = "select * from tbl_register where u_name='" & txtuname.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("username exist")
            Else
                sql = "insert into tbl_register (Emp_id,u_name,u_pass)"
                sql = sql & "values('" & cmbid.Text & "','" & txtuname.Text & "','" & txtpass.Text & "')"
                conn.Execute(sql)
                sql = "update tbl_emp set status='registered' where Emp_id='" & cmbid.Text & "'"
                conn.Execute(sql)
                MsgBox(" Successfully registered ")
                cmbid.Text = ""
                txtuname.Text = ""
                txtpass.Text = ""
                status()
                loadpass()
            End If
        End If
    End Sub

    Private Sub cmbid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbid.SelectedIndexChanged

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Hide()
        frmmaster.Show()
    End Sub

    Sub loadpass()
        Dim i = 0
        sql = "select * from tbl_register "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub


End Class