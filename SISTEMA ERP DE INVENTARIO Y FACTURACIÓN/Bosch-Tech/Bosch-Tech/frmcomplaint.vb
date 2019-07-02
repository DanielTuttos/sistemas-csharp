Public Class frmcomplaint

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        sql = "insert into tbl_complaints(complaint_no,cust_code,bill_no,complaint)"
        sql = sql & "values('" & txtcomplaint.Text & "','" & cmbcustcode.Text & "','" & txtbilllno.Text & "','" & txtcustcomplaint.Text & "')"
        conn.Execute(sql)
        MsgBox("Added")
    End Sub
End Class