Public Class frmcategory
    Dim rs1 As New ADODB.Recordset
    Private Sub frmcategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadcat()
        ListBox1.Visible = False
        btnUpdate.Enabled = False
        btndelete.Enabled = False
        'loadcatid()

    End Sub

    Sub loadcat()
        Dim i = 0
        sql = "select * from tbl_category"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView2.Rows.Clear()
        Do While rs.EOF = False
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = rs(0).Value
            DataGridView2.Item(1, i).Value = rs(2).Value
            DataGridView2.Item(2, i).Value = rs(1).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub
    Sub clear()
        txtprodcode.Text = ""
        txtprodname.Text = ""
        txtcategory.Text = ""
    End Sub
    

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If txtcategory.Text = "" Then
            MsgBox("Enter all the fields")
        ElseIf txtprodcode.Text = "" Then
            MsgBox("Enter all the fields")
        ElseIf txtprodname.Text = "" Then
            MsgBox("Enter all the fields")
        Else
            sql = "select * from tbl_category where Prod_code='" & txtprodcode.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                MsgBox("Product code exist")
            Else

                sql = "select * from tbl_category where Category='" & txtcategory.Text & "' and Prodname='" & txtprodname.Text & "'"
                If rs.State = 1 Then rs.Close()
                rs.Open(sql, conn)
                If rs.EOF = False Then
                    MsgBox("Category and product name already Exist!!!!")
                Else

                    sql = "insert into tbl_category (Prod_code,Category,Prodname)"
                    sql = sql & "values('" & txtprodcode.Text & "','" & txtcategory.Text & "','" & txtprodname.Text & "')"
                    conn.Execute(sql)
                    MsgBox("values inserted")
                    clear()
                    loadcat()


                End If
            End If
        End If
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        btnUpdate.Enabled = True
        btndelete.Enabled = True
        btnok.Enabled = False
        txtprodcode.Enabled = False
        txtprodcode.Text = DataGridView2.CurrentRow.Cells(0).Value
        txtprodname.Text = DataGridView2.CurrentRow.Cells(1).Value
        ListBox1.Visible = False
        txtcategory.Text = DataGridView2.CurrentRow.Cells(2).Value

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtcategory.Text = "" Then
            MsgBox("Enter the category")
        ElseIf txtprodcode.Text = "" Then
            MsgBox("Enter the product code")
        ElseIf txtprodname.Text = "" Then
            MsgBox("Enter the product name")
        Else
           

            'sql = "select * from tbl_category where Category='" & txtcategory.Text & "' and Prodname='" & txtprodname.Text & "'"
            'If rs.State = 1 Then rs.Close()
            'rs.Open(sql, conn)
            'If rs.EOF = False Then
            '    MsgBox("Category and product name already Exist!!!!")
            'Else
            sql = "update tbl_category set category='" & txtcategory.Text & "',prodname='" & txtprodname.Text & "' where prod_code='" & txtprodcode.Text & "'"
            conn.Execute(sql)
            MsgBox("Successfully updated")
            clear()
            loadcat()
            txtprodcode.Enabled = True
            'End If

        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "select * from tbl_stock where qty>0 and Prod_code='" & txtprodcode.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            MsgBox("Cannot delete..product exist in stock")
        Else

            sql = "delete from tbl_category where Prod_code='" & txtprodcode.Text & "'"
            conn.Execute(sql)
            sql = "delete from tbl_product where Prod_code='" & txtprodcode.Text & "'"
            conn.Execute(sql)
            sql = "delete from tbl_stock where Prod_code='" & txtprodcode.Text & "'"
            conn.Execute(sql)
            MsgBox("Successfully Deleted")

            btnok.Enabled = True
            btnUpdate.Enabled = False
            btndelete.Enabled = False
            clear()
            loadcat()
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        txtprodname.Text = ListBox1.Text
        ListBox1.Visible = False
    End Sub


    Private Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnnew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtprodname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprodname.TextChanged
        If txtprodname.Text <> "" Then
            ListBox1.Visible = True
            sql = "select distinct(Prodname) from tbl_category where Prodname like '" & txtprodname.Text & "%' "
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            ListBox1.Items.Clear()
            Do While rs.EOF = False
                ListBox1.Items.Add(rs(0).Value)
                rs.MoveNext()
            Loop
            If ListBox1.Items.Count = 0 Then
                ListBox1.Visible = False
            End If
        Else
            ListBox1.Visible = False
        End If

        'txtprodname.SelectionStart = Len(txtprodname.Text)
        'If txtprodname.Text <> "" Then
        '    Dim pl = ""
        '    pl = txtprodname.Text & "%"

        '    sql = "select Prodname from tbl_category where (Prodname like '" & pl & "%')"
        '    ListBox1.Items.Clear()
        '    ListBox1.Visible = True
        '    If rs.State = 1 Then rs.Close()
        '    rs.Open(sql, conn)
        '    If rs.EOF = False Then
        '        ListBox1.Items.Add(rs(0).Value)
        '    End If


        '    'If reader.RecordsAffected > 0 Then

        '    If ListBox1.Items.Count = 0 Then
        '        ListBox1.Visible = False
        '    End If
        'Else
        '    ListBox1.Visible = False
        'End If

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clear()
        btnUpdate.Enabled = False
        btndelete.Enabled = False
        btnok.Enabled = True
        txtprodcode.Enabled = True
    End Sub

    Private Sub txtprodcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprodcode.TextChanged

    End Sub


    
End Class