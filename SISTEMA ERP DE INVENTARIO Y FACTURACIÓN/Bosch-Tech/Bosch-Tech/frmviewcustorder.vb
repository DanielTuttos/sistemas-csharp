Public Class frmviewcustorder

    Private Sub frmviewcustorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadorderno()
        sql = "select distinct(prod_code) from tbl_product"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbprodcode.Items.Clear()
        Do While rs.EOF = False
            cmbprodcode.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub loadorderno()
        sql = "select distinct(cust_order_no) from tbl_customerorder"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbcustornum.Items.Clear()
        Do While rs.EOF = False
            cmbcustornum.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub cmbcustornum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcustornum.SelectedIndexChanged
        Dim i = 0
        sql = "select * from tbl_customerorder where cust_order_no='" & cmbcustornum.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView2.Rows.Clear()
        Do While rs.EOF = False
            cmbordertype.Text = rs(3).Value
            cmbcustcode.Text = rs(2).Value
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = rs(4).Value
            DataGridView2.Item(1, i).Value = rs(5).Value
            
            DateTimePicker1.Value = rs(6).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'custorederno = DataGridView1.CurrentRow.Cells(0).Value
        Me.Hide()
        frmcustorder.Show()
    End Sub
    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        cmbprodcode.Text = DataGridView2.CurrentRow.Cells(0).Value
        txtqty.Text = DataGridView2.CurrentRow.Cells(1).Value
        DataGridView2.Rows.RemoveAt(e.RowIndex)
    End Sub
    Dim i = 0
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If cmbprodcode.Text = "" Then
            MsgBox("Enter the product code")
        ElseIf txtqty.Text = "" Then
            MsgBox("Enter the product qty")
        Else
            For i = 0 To DataGridView2.Rows.Count - 1
                If cmbprodcode.Text = DataGridView2.Item(0, i).Value Then
                    MsgBox("product exist in gridview")
                    Exit Sub
                End If
            Next
            i = DataGridView2.Rows.Count
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = cmbprodcode.Text
            DataGridView2.Item(1, i).Value = txtqty.Text
            cmbprodcode.Text = ""
            txtqty.Text = ""
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "delete from tbl_customerorder where cust_order_no='" & cmbcustornum.Text & "'"
        conn.Execute(sql)
        Dim j = 0
        i = DataGridView2.RowCount
        Do While j < i
            sql = "insert into tbl_customerorder(cust_order_no,cust_code,order_type,prod_code,qty,order_date)"
            sql = sql & "values ('" & cmbcustornum.Text & "','" & cmbcustcode.Text & "','" & cmbordertype.Text & "','" & DataGridView2.Item(0, j).Value & "','" & DataGridView2.Item(1, j).Value & "',convert(date,'" & DateTimePicker1.Value & "',103))"
            conn.Execute(sql)
            j = j + 1

        Loop
        MsgBox("Updated")
    End Sub
End Class