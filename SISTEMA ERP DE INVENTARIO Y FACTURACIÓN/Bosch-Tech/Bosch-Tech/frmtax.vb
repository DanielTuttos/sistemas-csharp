Public Class frmtax

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "insert into tbl_tax(prod_code,tax)"
        sql = sql & " values('" & cmbprod.Text & "','" & txttaxrate.Text & "')"
        conn.Execute(sql)
        MsgBox("Added")
    End Sub

    Private Sub cmbtax_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprod.SelectedIndexChanged
        
    End Sub

    Private Sub frmtax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        sql = "select * from tbl_category"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmbprod.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
End Class