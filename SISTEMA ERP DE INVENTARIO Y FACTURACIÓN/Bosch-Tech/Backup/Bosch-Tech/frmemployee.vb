Imports System.Text.RegularExpressions
Public Class frmemployee
    Public sex
    Sub loadid()
        Dim id
        sql = "select MAX(cast(SUBSTRING(Emp_id,2,len(Emp_id))+1 as int ))from tbl_emp "
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtempid.Text = "E101"
        Else
            If rs.EOF = False Then
                id = rs(0).Value
                id = "E" & id
                txtempid.Text = id


            End If
        End If
    End Sub
    Sub gender()

        If RadioButton1.Checked = True Then
            sex = "Male"
        ElseIf RadioButton2.Checked = True Then
            sex = "Female"
        End If
    End Sub
    Private Sub frmemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadid()
        txtphone.MaxLength = 10
        DateTimePicker1.MaxDate = Today.Date
        loademp()
        btnupdate.Enabled = False
        btndelete.Enabled = False
    End Sub
    Sub loademp()
        Dim i = 0
        sql = "select * from tbl_emp"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(0).Value
            DataGridView1.Item(1, i).Value = rs(1).Value
            DataGridView1.Item(2, i).Value = rs(6).Value
            DataGridView1.Item(3, i).Value = rs(5).Value
            DataGridView1.Item(4, i).Value = rs(2).Value
            DataGridView1.Item(5, i).Value = rs(3).Value
            DataGridView1.Item(6, i).Value = rs(4).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub
    Sub clear()
        txtempname.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        txtadd.Text = ""
        txtphone.Text = ""
        txtemail.Text = ""
        loadid()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = True
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        gender()
       
        'emailaddresscheck = True
        If txtempname.Text = "" Or txtadd.Text = "" Or txtphone.Text = "" Or txtemail.Text = "" Or sex = "" Then
            MsgBox("Enter all the fileds")
        ElseIf txtphone.TextLength < 10 Then
            MsgBox("Mobile number should be of 10 digits")
        Else
            Dim pattern As String = "^[a-z A-Z][\w\.-]*[a-z A-Z 0-9]@[a-z A-Z 0-9][\w\.-]*[a-z A-Z 0-9]\.[a-z A-Z][a-z A-Z\.]*[a-z A-Z]$"
            Dim emailaddressmatch As Match = Regex.Match(txtemail.Text, pattern)
            If emailaddressmatch.Success Then
                sql = "insert into tbl_emp(Emp_id,Emp_name,Emp_add,phone_no,Email,DOJ,gender,status)"
                sql = sql & " values('" & txtempid.Text & "','" & txtempname.Text & "','" & txtadd.Text & "','" & txtphone.Text & "','" & txtemail.Text & "',convert(date,'" & DateTimePicker1.Value & "',103),'" & sex & "','unregistered')"
                conn.Execute(sql)
                MsgBox("Added")
                clear()
                loademp()
            Else
                MsgBox("Enter the valid email ID")
            End If
        End If
        

    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

            TabControl1.SelectedTab = TabPage1
            btnupdate.Enabled = True
            btndelete.Enabled = True
            btnadd.Enabled = False
            txtempid.Text = DataGridView1.CurrentRow.Cells(0).Value
            txtempname.Text = DataGridView1.CurrentRow.Cells(1).Value
            If DataGridView1.CurrentRow.Cells(2).Value = "Male" Then
                RadioButton1.Checked = True
            Else
                RadioButton2.Checked = True
            End If
            DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(3).Value
            txtadd.Text = DataGridView1.CurrentRow.Cells(4).Value
            txtphone.Text = DataGridView1.CurrentRow.Cells(5).Value
            txtemail.Text = DataGridView1.CurrentRow.Cells(6).Value

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        gender()
        If txtphone.TextLength < 10 Then
            MsgBox("Mobile number should be of 10 digits")
        Else
            sql = "update tbl_emp set emp_name='" & txtempname.Text & "',emp_add='" & txtadd.Text & "',phone_no='" & txtphone.Text & "',email='" & txtemail.Text & "', DOJ=convert(date,'" & DateTimePicker1.Value & " ',103),gender='" & sex & "' where emp_id='" & txtempid.Text & "'"
            conn.Execute(sql)
            MsgBox("updated")
            clear()
            btnupdate.Enabled = False
            btndelete.Enabled = False
            btnadd.Enabled = True
            loademp()
            loadid()
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        sql = "delete from tbl_emp where emp_id= '" & txtempid.Text & "'"
        conn.Execute(sql)

        sql = "delete from tbl_register where emp_id= '" & txtempid.Text & "'"
        conn.Execute(sql)
        MsgBox("Deleted")
        clear()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        btnadd.Enabled = True
        loademp()
        loadid()
    End Sub


    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub txtphone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtphone.KeyDown
        CheckNum(e)
    End Sub
End Class