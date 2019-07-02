Public Class frmpayment

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
      If txtpaidamt.Text = "" Then
            MsgBox("enter the paid amount")
        Else
            Dim billno
            'If cmbbillno.Text = "" Then
            billno = 0
            '    Else
            '    billno = cmbbillno.Text
            'End If
            sql = "insert into tbl_payment (billno,custcode,totalamt,paidamt,balance,date)"
            sql = sql & "values('" & billno & "','" & txtcustcode.Text & "','" & txttotalamt.Text & "','" & txtpaidamt.Text & "','" & txtbalanceamt.Text & "',convert(date,'" & Today.Date & "',103))"
            conn.Execute(sql)
            'sql = "update tbl_bills set status='Paid' where bill_no='" & cmbbillno.Text & "'"
            'conn.Execute(sql)
            sql = "update tbl_prevb set balance='" & txtbalanceamt.Text & "' where cust_code='" & txtcustcode.Text & "'"
            conn.Execute(sql)
            MsgBox("Payment done")
            txtcustcode.Text = ""
            txttotalamt.Text = 0
            txtbalanceamt.Text = 0
            txtpaidamt.Text = 0
            'loadbillno()
        End If
    End Sub
    Sub clear()

    End Sub

    Private Sub frmpayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        'loadbillno()
        loadcustcode()
    End Sub
    Sub loadcustcode()
        txtcustcode.Items.Clear()
        sql = "select cust_code from tbl_cust"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        Do While Not rs.EOF
            txtcustcode.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub
    'Sub loadbillno()
    '    sql = "select * from tbl_bills where status='NotPaid' and cust_code='" & txtcustcode.Text & "'"
    '    If rs.State = 1 Then rs.Close()
    '    rs.Open(sql, conn)
    '    cmbbillno.Items.Clear()
    '    Do While Not rs.EOF
    '        cmbbillno.Items.Add(rs(0).Value)
    '        rs.MoveNext()
    '    Loop
    'End Sub
    Private Sub cmbbillno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'sql = "select * from tbl_bills where bill_no='" & cmbbillno.Text & "'"
        'If rs.State = 1 Then rs.Close()
        'rs.Open(sql, conn)
        'If rs.EOF = False Then
        '    txtcustcode.Text = rs(2).Value
        '    txttotalamt.Text = Math.Round(rs(6).Value)
        'End If
    End Sub

    Private Sub txtpaidamt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpaidamt.KeyDown
        CheckNum(e)
    End Sub

    Private Sub txtpaidamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaidamt.TextChanged
        txtbalanceamt.Text = Val(txttotalamt.Text) - Val(txtpaidamt.Text)
    End Sub

    
    Private Sub txtcustcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcustcode.SelectedIndexChanged
        'loadbillno()
        'sql = "select * from tbl_bills where cust_code='" & txtcustcode.Text & "' and status='NotPaid'"
        'If rs.State = 1 Then rs.Close()
        'rs.Open(sql, conn)
        'If rs.EOF = False Then
        '    txttotalamt.Text = Math.Round(rs(6).Value)
        'Else
        sql = "select balance from tbl_prevb where cust_code='" & txtcustcode.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            txttotalamt.Text = Math.Round(rs(0).Value)
        End If
        'End If

    End Sub
End Class