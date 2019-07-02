Public Class frmproduct

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub clear()
        txtserialno.Text = ""
        cmbprodcode.Text = ""
        txtcat.Text = ""
        txtprodname.Text = ""
        txtqty.Text = ""
        txtnetprice.Text = ""
        txtsellprice.Text = ""


    End Sub
    Sub loadprod()
        Dim i = 0
        sql = "select * from tbl_product "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            sql = "select * from tbl_category where prod_code='" & DataGridView1.Item(1, i).Value & "'"
            If rs1.State = 1 Then rs1.Close()
            rs1.Open(sql, conn)
            If rs1.EOF = False Then
                DataGridView1.Item(2, i).Value = rs1(2).Value
                DataGridView1.Item(3, i).Value = rs1(1).Value
            End If

            DataGridView1.Item(4, i).Value = rs(2).Value
            DataGridView1.Item(5, i).Value = rs(3).Value
            DataGridView1.Item(6, i).Value = rs(4).Value
            DataGridView1.Item(7, i).Value = rs(5).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub
    Private Sub frmprodcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()

        sql = "select * from tbl_category"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbprodcode.Items.Clear()

        Do While rs.EOF = False
            cmbprodcode.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
        loadslno()
        loadprod()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = True

    End Sub
    Sub loadslno()
        Dim id
        sql = "select MAX(cast(SUBSTRING(serialno,2,len(serialno))+1 as int ))from tbl_product "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtserialno.Text = "S101"
        Else
            If rs.EOF = False Then
                id = rs(0).Value
                id = "S" & id
                txtserialno.Text = id


            End If
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If Val(txtnetprice.Text) > Val(txtsellprice.Text) Then
            MsgBox("Selling price should be greater than netprice")
        ElseIf cmbprodcode.Text = "" Or txtqty.Text = "" Or txtnetprice.Text = "" Or txtsellprice.Text = "" Then
            MsgBox("Enter all the fileds")
        Else

            sql = "insert into tbl_product(serialno,prod_code,qty,net_price,selling_price,date) "
            sql = sql & "values('" & txtserialno.Text & "','" & cmbprodcode.Text & "', '" & txtqty.Text & "', '" & txtnetprice.Text & "', '" & txtsellprice.Text & "',convert(date,'" & DateTimePicker1.Value & "',103))"
            conn.Execute(sql)

            sql = "select * from tbl_stock where prod_code='" & cmbprodcode.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                sql = "update tbl_stock set qty=qty+ '" & txtqty.Text & "' where prod_code='" & cmbprodcode.Text & "'"
                conn.Execute(sql)
            Else
                sql = "insert into tbl_stock(prod_code,qty,updated_date)"
                sql = sql & " values('" & cmbprodcode.Text & "','" & txtqty.Text & "',convert(date,'" & DateTimePicker1.Value & "',103))"
                conn.Execute(sql)

            End If

            MsgBox("product added")
            clear()
            loadslno()
            loadprod()
        End If
    End Sub

    Private Sub cmbprodcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprodcode.SelectedIndexChanged
        sql = "select * from tbl_category where prod_code='" & cmbprodcode.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtcat.Text = rs(1).Value
            txtprodname.Text = rs(2).Value
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clear()
        loadslno()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = True
    End Sub


    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update tbl_product set prod_code='" & cmbprodcode.Text & "',qty='" & txtqty.Text & "',net_price='" & txtnetprice.Text & "',selling_price='" & txtsellprice.Text & "',date=convert(date,'" & Today.Date & "',103) where serialno='" & txtserialno.Text & "'"
        conn.Execute(sql)

        'Deleting stock table
        sql = "delete from tbl_stock"
        conn.Execute(sql)
        'Update stock table
        sql = "select prod_code,sum(qty) from tbl_product group by prod_code"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            sql = "insert into tbl_stock(prod_code,qty,updated_date)"
            sql = sql & "values('" & rs(0).Value & "','" & rs(1).Value & "',convert(date,'" & Today.Date & "',103))"
            conn.Execute(sql)
            rs.MoveNext()
        Loop
        MsgBox("Updated")
        clear()
        loadslno()
        loadprod()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = True

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TabPage1.Show()
        btnupdate.Enabled = True
        btndelete.Enabled = True
        btnadd.Enabled = False

        txtserialno.Text = DataGridView1.CurrentRow.Cells(0).Value
        cmbprodcode.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtcat.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtprodname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtqty.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtnetprice.Text = DataGridView1.CurrentRow.Cells(5).Value
        txtsellprice.Text = DataGridView1.CurrentRow.Cells(6).Value
    End Sub


    
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_product where serialno='" & txtserialno.Text & "'"
        conn.Execute(sql)
        'Deleting stock table
        sql = "delete from tbl_stock"
        conn.Execute(sql)
        'Update stock table
        sql = "select prod_code,sum(qty) from tbl_product group by prod_code"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            sql = "insert into tbl_stock(prod_code,qty,updated_date)"
            sql = sql & "values('" & rs(0).Value & "','" & rs(1).Value & "',convert(date,'" & Today.Date & "',103))"
            conn.Execute(sql)
            rs.MoveNext()
        Loop

        MsgBox("Deleted")
        clear()
        loadprod()
        loadslno()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = True

    End Sub

    
    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class