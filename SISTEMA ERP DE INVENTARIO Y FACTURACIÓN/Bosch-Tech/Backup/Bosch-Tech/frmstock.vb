Public Class frmstock

    Private Sub frmstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadall()
        loadprodcode()
    End Sub
    Sub loadprodcode()
        sql = "select distinct(prod_code) from tbl_product"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbprodcode.Items.Clear()
        Do While rs.EOF = False
            cmbprodcode.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    Sub loadall()
        Dim i = 0
        sql = "select * from tbl_stock"
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

    Private Sub cmbprodcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprodcode.SelectedIndexChanged
        Dim i = 0
        sql = "Select * from tbl_stock where prod_code='" & cmbprodcode.Text & "' "
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

    Private Sub btnviewall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewall.Click
        cmbprodcode.Text = ""
        loadall()
    End Sub
End Class