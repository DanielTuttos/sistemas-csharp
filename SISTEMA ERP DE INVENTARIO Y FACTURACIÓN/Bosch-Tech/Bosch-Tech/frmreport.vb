Public Class frmreport
    Public m As Integer
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "January" Then
            m = "1"
        ElseIf ComboBox1.Text = "February" Then
            m = "2"
        ElseIf ComboBox1.Text = "March" Then
            m = "3"
        ElseIf ComboBox1.Text = "April" Then
            m = "4"
        ElseIf ComboBox1.Text = "May" Then
            m = "5"
        ElseIf ComboBox1.Text = "June" Then
            m = "6"
        ElseIf ComboBox1.Text = "July" Then
            m = "7"
        ElseIf ComboBox1.Text = "August" Then
            m = "8"
        ElseIf ComboBox1.Text = "September" Then
            m = "9"
        ElseIf ComboBox1.Text = "October" Then
            m = "10"
        ElseIf ComboBox1.Text = "November" Then
            m = "11"
        ElseIf ComboBox1.Text = "December" Then
            m = "12"
        End If
    End Sub
    Sub year()
        Dim j
        For j = 2010 To 2030
            ComboBox2.Items.Add(j)


        Next j
        j = j + 1
    End Sub
    Private Sub frmreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        viewall()
        year()
    End Sub
    Sub viewall()
        Dim i = 0
        sql = "Select * from tbl_payment where year(date)='" & Now.Year & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Label1.Text = 0
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = rs(1).Value
            DataGridView1.Item(1, i).Value = rs(2).Value
            DataGridView1.Item(2, i).Value = rs(3).Value
            DataGridView1.Item(3, i).Value = rs(4).Value
            DataGridView1.Item(4, i).Value = rs(5).Value
            DataGridView1.Item(5, i).Value = rs(6).Value
            Label1.Text = Label1.Text + DataGridView1.Item(3, i).Value
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub
 
    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewall.Click
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        viewall()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub btnview_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Dim i = 0
        Dim amt As Double
        If ComboBox1.Text = "" Then
            MsgBox("select the month")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("select the month")
        Else

            sql = "Select * from tbl_payment where month(date)='" & m & "' and year(date)='" & ComboBox2.Text & "' "
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            DataGridView1.Rows.Clear()
            Label1.Text = 0
            Do While rs.EOF = False
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = rs(1).Value
                DataGridView1.Item(1, i).Value = rs(2).Value
                DataGridView1.Item(2, i).Value = rs(3).Value
                DataGridView1.Item(3, i).Value = rs(4).Value
                DataGridView1.Item(4, i).Value = rs(5).Value
                DataGridView1.Item(5, i).Value = rs(6).Value
                Label1.Text = Label1.Text + DataGridView1.Item(3, i).Value
                rs.MoveNext()
                i = i + 1
            Loop
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class