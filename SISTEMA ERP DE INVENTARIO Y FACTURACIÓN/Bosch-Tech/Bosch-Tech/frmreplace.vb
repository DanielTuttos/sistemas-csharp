Public Class frmreplace
    Dim orderno, qty, qty1
    Private Sub cmbbillno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbillno.SelectedIndexChanged
        sql = "SELECT tbl_customerorder.cust_order_no,tbl_bills.Bill_no,tbl_customerorder.qty,tbl_customerorder.prod_code FROM tbl_customerorder INNER JOIN tbl_bills ON tbl_customerorder.cust_order_no = tbl_bills.cust_order_no WHERE(tbl_bills.Bill_no = '" & cmbbillno.Text & "')"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbprodcode.Items.Clear()
        Do While Not rs.EOF
            cmbprodcode.Items.Add(rs(3).Value)
            orderno = rs(0).Value
            rs.MoveNext()
        Loop

    End Sub

    Private Sub frmreplace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        sql = "SELECT * from tbl_bills"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmbbillno.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub cmbprodcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbprodcode.SelectedIndexChanged
        sql = "select sum(qty) from tbl_scrap where Bill_no='" & cmbbillno.Text & "' and prod_code='" & cmbprodcode.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        
        If rs.EOF = False Then
            If IsDBNull(rs(0).Value) = False Then


                qty1 = rs(0).Value
                MsgBox(qty1 & "quantities has been replaced for this product")
                sql = "select * from tbl_customerorder where cust_order_no='" & orderno & "' and prod_code='" & cmbprodcode.Text & "'"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
                If rs.EOF = False Then
                    qty = rs(5).Value
                    PQTY.Text = qty - qty1
                End If

            Else

                sql = "select * from tbl_customerorder where cust_order_no='" & orderno & "' and prod_code='" & cmbprodcode.Text & "'"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
                If rs.EOF = False Then
                    qty = rs(5).Value
                    PQTY.Text = qty
                End If
            End If
        End If
    End Sub

    Private Sub btnreplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreplace.Click
        If cmbbillno.Text = "" Or cmbprodcode.Text = "" Or txtqty.Text = "" Then
            MsgBox("enter all the fields")
        Else
            If Val(txtqty.Text) > Val(PQTY.Text) Then
                MsgBox("replacing quantity should be lesser than previous quantity ")
            Else
                sql = "insert into tbl_scrap(bill_no,prod_code,qty)"
                sql = sql & "values('" & cmbbillno.Text & "','" & cmbprodcode.Text & "','" & txtqty.Text & "')"
                conn.Execute(sql)

                sql = "update tbl_stock set qty=qty-'" & txtqty.Text & "' where prod_code='" & cmbprodcode.Text & "'"
                conn.Execute(sql)

                MsgBox("Added")
                cmbbillno.Text = ""
                cmbprodcode.Text = ""
                PQTY.Text = ""
                txtqty.Text = ""
            End If
        End If
    End Sub

    
End Class