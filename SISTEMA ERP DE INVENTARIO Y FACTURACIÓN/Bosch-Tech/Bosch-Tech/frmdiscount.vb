Public Class frmdiscount
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If cmbprod.Text = "" Or txtdiscount.Text = "" Then
            MsgBox("Enter all the values")
        ElseIf txtdiscount.Text > 99 Then
            MsgBox("disc")
            clear()
        Else
            sql = "select * from tbl_dis where prod_code='" & cmbprod.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                If MsgBox("Discount has been already added to this product,Do you want to update it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    sql = "update tbl_dis set discount='" & txtdiscount.Text & "' where prod_code='" & cmbprod.Text & "'"
                    conn.Execute(sql)
                    MsgBox("Successfully Updated")
                    clear()
                Else
                    Exit Sub
                End If
            Else
                sql = "insert into tbl_dis(prod_code,discount)"
                sql = sql & " values('" & cmbprod.Text & "','" & txtdiscount.Text & "')"
                conn.Execute(sql)
                MsgBox("Successfully Added")
                clear()
            End If
        End If
    End Sub

    Private Sub frmdiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        sql = "select distinct(prod_code) from tbl_product"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            cmbprod.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop

    End Sub
    Function CheckNum1(ByVal e As KeyEventArgs)
        If (e.KeyCode < 48 Or e.KeyCode > 57) And e.KeyCode <> 8 And (e.KeyCode < 96 Or e.KeyCode > 105) Then
            If e.KeyCode <> 190 Then
                e.SuppressKeyPress = True

            End If

        End If
        Return 0

    End Function

    Private Sub txtdiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdiscount.KeyDown
        CheckNum1(e)
    End Sub
    Sub clear()
        cmbprod.Text = ""
        txtdiscount.Text = ""
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clear()
    End Sub
End Class