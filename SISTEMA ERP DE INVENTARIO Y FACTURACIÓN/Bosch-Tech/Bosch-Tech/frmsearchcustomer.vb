﻿Public Class frmsearchcustomer

    Private Sub frmsearchcustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
    End Sub
    Public searchvalue
    Sub searchCustomer()
        Dim EntText
        EntText = TextBox1.Text & "%"
        sql = "select * from tbl_cust where " & searchvalue & " like   '" & EntText & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Dim i
        i = 0
        Do While Not rs.EOF
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            DataGridView1.Item(4, i).Value = rs(4).Value
            DataGridView1.Item(5, i).Value = rs(5).Value
            rs.MoveNext()
            i = i + 1
        Loop
        If DataGridView1.RowCount = 0 Then
            MsgBox("no such record")
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Customer Code" Then
            searchvalue = "Cust_code"
        ElseIf ComboBox1.Text = "Customer Name" Then
            searchvalue = "Cust_name"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        searchCustomer()
    End Sub
End Class