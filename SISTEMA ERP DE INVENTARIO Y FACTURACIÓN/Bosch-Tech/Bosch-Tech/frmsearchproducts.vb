Public Class frmsearchproducts

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Product Code" Then
            searchvalue = "prod_code"
        ElseIf ComboBox1.Text = "Amount" Then
            searchvalue = "selling_price"
        End If
    End Sub
    Public searchvalue
    Private Sub frmsearchproducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
    End Sub
    Sub searchProducts()
        Dim EntText
        EntText = TextBox1.Text & "%"
        sql = "select * from tbl_product where " & searchvalue & " like   '" & EntText & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Dim i
        i = 0
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(1).Value
            sql = "select * from tbl_category where prod_code='" & DataGridView1.Item(0, i).Value & "'"
            If rs1.State = 1 Then rs1.Close()
            rs1.Open(sql, conn)
            If rs1.EOF = False Then
                DataGridView1.Item(1, i).Value = rs1(2).Value
                DataGridView1.Item(2, i).Value = rs1(1).Value
            End If
            DataGridView1.Item(3, i).Value = rs(2).Value
            DataGridView1.Item(4, i).Value = rs(3).Value
            DataGridView1.Item(5, i).Value = rs(4).Value
            DataGridView1.Item(6, i).Value = rs(5).Value
            'DataGridView1.Item(7, i).Value = rs(5).Value
            rs.MoveNext()
            i = i + 1
        Loop
        If DataGridView1.RowCount = 0 Then
            MsgBox("no such record")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        searchProducts()
        If TextBox1.Text = "" Then
            DataGridView1.Rows.Clear()
        End If
    End Sub
End Class