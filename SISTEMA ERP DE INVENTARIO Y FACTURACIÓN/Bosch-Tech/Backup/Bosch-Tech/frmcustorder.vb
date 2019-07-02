Public Class frmcustorder

    Private Sub frmcustorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadorderno()
        sql = "select * from tbl_cust"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbcustcode.Items.Clear()
        Do While rs.EOF = False
            cmbcustcode.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
        sql = "select distinct(prod_code) from tbl_product"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbprodcode.Items.Clear()
        Do While rs.EOF = False
            cmbprodcode.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
        'If custorederno <> "" Then
        '    sql = "select * from tbl_cust_order where cust_order_no='" & custorederno & "'"
        '    If rs.State = 1 Then rs.Close()
        '    rs.Open(sql, conn)
        '    If rs.EOF = False Then
        '        txtcustordernum.Text = rs(0).Value
        '        cmbordertype.Text = rs(2).Value
        '        cmbcustcode.Text = rs(1).Value
        '        txtqty.Text = rs(4).Value
        '        DateTimePicker1.Value = rs(5).Value
        '        cmbprodcode.Text = rs(3).Value
        '    End If
        '    custorederno = ""
        'End If
    End Sub
    Sub loadorderno()

        Dim i
        sql = "select max(cust_order_no) from tbl_customerorder"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtcustordernum.Text = 1
        Else
            i = rs(0).Value
            txtcustordernum.Text = i + 1

        End If
    End Sub

    Sub clear()
        txtcustordernum.Text = "'"
        cmbcustcode.Text = ""
        cmbordertype.Text = ""
        cmbprodcode.Text = ""
        txtqty.Text = ""
        DateTimePicker1.Value = Today.Date
    End Sub
    
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim j = 0
        i = DataGridView2.RowCount
        If cmbordertype.Text = "" Or cmbcustcode.Text = "" Or DataGridView2.RowCount = 0 Then
            MsgBox("Enter all the fileds")
        Else
            Do While j < i
                sql = "insert into tbl_customerorder(cust_order_no,cust_code,order_type,prod_code,qty,order_date,statu)"
                sql = sql & "values ('" & txtcustordernum.Text & "','" & cmbcustcode.Text & "','" & cmbordertype.Text & "','" & DataGridView2.Item(0, j).Value & "','" & DataGridView2.Item(1, j).Value & "',convert(date,'" & DateTimePicker1.Value & "',103),'false')"
                conn.Execute(sql)
                sql = "update tbl_stock set qty=qty-'" & DataGridView2.Item(1, j).Value & "' where Prod_code='" & DataGridView2.Item(0, j).Value & "' "
                conn.Execute(sql)
                j = j + 1

            Loop
            MsgBox(" Successfully Added..!!")
            clear()
            DataGridView2.Rows.Clear()
            loadorderno()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clear()
    End Sub
    Dim i = 0
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If Val(txtavqty.Text) < Val(txtqty.Text) Then
            MsgBox("Stock is less")
        Else
            If cmbprodcode.Text = "" Then
                MsgBox("Enter the product code")
            ElseIf txtqty.Text = "" Then
                MsgBox("Enter the product qty")
            Else
                For i = 0 To DataGridView2.Rows.Count - 1
                    If cmbprodcode.Text = DataGridView2.Item(0, i).Value Then
                        MsgBox("Product exist in gridview")
                        Exit Sub
                    End If
                Next
                DataGridView2.Rows.Add()
                DataGridView2.Item(0, i).Value = cmbprodcode.Text
                DataGridView2.Item(1, i).Value = txtqty.Text
                
                i = i + 1
                cmbprodcode.Text = ""
                txtqty.Text = ""
                txtavqty.Text = ""
            End If
        End If
    End Sub

    
    Private Sub cmbprodcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprodcode.SelectedIndexChanged
        sql = "select * from tbl_stock where Prod_code='" & cmbprodcode.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txtavqty.Text = rs(1).Value

        End If
    End Sub
End Class