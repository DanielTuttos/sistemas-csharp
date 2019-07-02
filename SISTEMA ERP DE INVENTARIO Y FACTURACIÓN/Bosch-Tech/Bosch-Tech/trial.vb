Public Class trial

    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        sql = "insert into trial (emp_n0,emp_name,emp_des,emp_add)"
        sql = sql & "values('" & txtNum.Text & "','" & txtName.Text & "','" & txt_des.Text & "','" & txtAdd.Text & "')"
        conn.Execute(sql)
        MsgBox("values are insereted")
        Reset()
        loadgrid()
    End Sub
    Sub loadgrid()
        Dim i = 0
        sql = "select * from trial"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub
    Sub Reset()
        txtNum.Text = ""
        txtName.Text = ""
        txt_des.Text = ""
        txtAdd.Text = ""

    End Sub

    Private Sub trial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadgrid()
    End Sub

    
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtNum.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtName.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_des.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtAdd.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update trial set emp_n0='" & txtNum.Text & "',emp_name='" & txtName.Text & "',emp_des='" & txt_des.Text & "',emp_add='" & txtAdd.Text & "' where emp_n0='" & DataGridView1.CurrentRow.Cells(0).Value & "' "
        conn.Execute(sql)
        MsgBox("updated")
        Reset()

        loadgrid()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from trial where emp_n0='" & txtNum.Text & " '"
        conn.Execute(sql)
        MsgBox("deleted")
        Reset()
        loadgrid()

    End Sub
End Class