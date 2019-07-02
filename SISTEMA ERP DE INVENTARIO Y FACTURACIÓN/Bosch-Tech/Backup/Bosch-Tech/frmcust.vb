Imports System.Text.RegularExpressions

Public Class frmcust

    Private Sub frmcust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadcust()
        loadid()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        txtphone.MaxLength = 10
    End Sub
    Sub loadid()
        Dim id
        sql = "select MAX(cast(SUBSTRING(cust_code,2,len(cust_code))+1 as int ))from tbl_cust "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtcustcode.Text = "C101"
        Else
            If rs.EOF = False Then
                id = rs(0).Value
                id = "C" & id
                txtcustcode.Text = id


            End If
        End If
    End Sub


    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim pattern As String = "^[a-z A-Z][\w\.-]*[a-z A-Z 0-9]@[a-z A-Z 0-9][\w\.-]*[a-z A-Z 0-9]\.[a-z A-Z][a-z A-Z\.]*[a-z A-Z]$"
        Dim emailaddressmatch As Match = Regex.Match(txtemail.Text, pattern)
        If emailaddressmatch.Success Then
            'emailaddresscheck = True
            If txttin.Text = "" Or txtname.Text = "" Or txtadd.Text = "" Or txtphone.Text = "" Or txtemail.Text = "" Then
                MsgBox("Enter all the fileds")
            ElseIf txtphone.TextLength < 10 Then
                MsgBox("Mobile number should be of 10 digits")
            Else
                sql = "insert into tbl_cust(Cust_code,Tin_no,Cust_name,Address,Phone_no,email_id)"
                sql = sql & "values('" & txtcustcode.Text & "', '" & txttin.Text & "', '" & txtname.Text & "', '" & txtadd.Text & "', '" & txtphone.Text & "', '" & txtemail.Text & "')"
                conn.Execute(sql)
                MsgBox("Added")
                clear()
                loadcust()
                loadid()
            End If
        Else
            MsgBox("enter the valid email id")
        End If
        


    End Sub
    Sub loadcust()
        Dim i = 0
        sql = "select * from tbl_cust "
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
            DataGridView1.Item(5, i).Value = rs(5).Value
            rs.MoveNext()
            i = i + 1
        Loop

    End Sub


    Sub clear()

        txttin.Text = ""
        txtname.Text = ""
        txtadd.Text = ""
        txtphone.Text = ""
        txtemail.Text = ""



    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clear()
        loadid()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = " delete from tbl_cust where cust_code='" & txtcustcode.Text & "'"
        conn.Execute(sql)
        MsgBox("Deleted")
        btnadd.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False

        clear()
        loadcust()

    End Sub


    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnadd.Enabled = False
        btnupdate.Enabled = True
        btndelete.Enabled = True
        txtcustcode.Text = DataGridView1.CurrentRow.Cells(0).Value
        txttin.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtadd.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtphone.Text = DataGridView1.CurrentRow.Cells(4).Value
        txtemail.Text = DataGridView1.CurrentRow.Cells(5).Value

    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        sql = "update tbl_cust set Tin_no='" & txttin.Text & "',Cust_name='" & txtname.Text & "',address='" & txtadd.Text & "',phone_no='" & txtphone.Text & "', Email_id='" & txtemail.Text & "' where Cust_code='" & txtcustcode.Text & "'"
        conn.Execute(sql)
        MsgBox("Updated")
        btnadd.Enabled = True
        btnupdate.Enabled = False
        btndelete.Enabled = False

        clear()
        loadcust()

    End Sub


End Class