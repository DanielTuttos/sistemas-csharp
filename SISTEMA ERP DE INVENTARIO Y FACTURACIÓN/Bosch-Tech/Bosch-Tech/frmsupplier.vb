Imports System.Text.RegularExpressions
Public Class frmsupplier

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        sql = "select * from tbl_supplier where supplier_id='" & txtsupplierid.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            MsgBox("Supplier ID Exist..!!!")
        Else


            If txtsupplierid.Text = "" Or txtsuppliername.Text = "" Or txtadd.Text = "" Or txtcontact.Text = "" Then
                MsgBox("Enter all the fileds")
            ElseIf txtcontact.TextLength < 10 Then
                MsgBox("Mobile num should be of 10 digits")

            Else
                Dim pattern As String = "^[a-z A-Z][\w\.-]*[a-z A-Z 0-9]@[a-z A-Z 0-9][\w\.-]*[a-z A-Z 0-9]\.[a-z A-Z][a-z A-Z\.]*[a-z A-Z]$"
                Dim emailaddressmatch As Match = Regex.Match(txtemail.Text, pattern)
                If emailaddressmatch.Success Then
                    'emailaddresscheck = True
                    sql = "insert into tbl_supplier (supplier_id,supplier_name,address,contact_no,EmailId)"
                    sql = sql & "values('" & txtsupplierid.Text & "','" & txtsuppliername.Text & "','" & txtadd.Text & "','" & txtcontact.Text & "','" & txtemail.Text & "')"
                    conn.Execute(sql)
                    MsgBox("added")
                    loadsupplier()
                    reset()
                Else
                    MsgBox("error")
                End If

            End If
        End If
    End Sub
    Sub reset()
        txtsupplierid.Text = ""
        txtsuppliername.Text = ""
        txtadd.Text = ""
        txtcontact.Text = ""
        txtemail.Text = ""
    End Sub
    Sub loadsupplier()
        Dim i = 0
        sql = "select * from tbl_supplier "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(2).Value
            DataGridView1.Item(3, i).Value = rs(3).Value
            DataGridView1.Item(4, i).Value = rs(4).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub
    Private Sub frmsupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadsupplier()
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        reset()
        txtsupplierid.Enabled = True
        btnadd.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False

    End Sub


    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update tbl_supplier set supplier_name='" & txtsuppliername.Text & "',address='" & txtadd.Text & "',contact_no='" & txtcontact.Text & "' where supplier_id='" & txtsupplierid.Text & "'"
        conn.Execute(sql)
        MsgBox("Updated")
        txtsupplierid.Enabled = True
        btnadd.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        loadsupplier()
        reset()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtsupplierid.Enabled = False
        btnadd.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        txtsupplierid.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtsuppliername.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtadd.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtcontact.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtemail.Text = DataGridView1.CurrentRow.Cells(4).Value

    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = " delete from tbl_supplier where supplier_id='" & txtsupplierid.Text & "'"
        conn.Execute(sql)
        MsgBox("Deleted")
        btnadd.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False
        loadsupplier()
        reset()
    End Sub


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmmaster.Show()
        Me.Hide()

    End Sub

    Private Sub txtcontact_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcontact.KeyDown
        CheckNum(e)
    End Sub

    Private Sub txtsuppliername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsuppliername.KeyDown
        CheckAlpha(e)
    End Sub


End Class