Imports System.Data.SqlClient
Public Class frmsales
    Dim num
    Private Sub frmsales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadbillno()
        num = txtbillno.Text
        loadcustonum()
    End Sub
    Sub loadcustonum()
        sql = "select distinct(cust_order_no) from tbl_customerorder where statu='false'"
        If rs1.State = 1 Then rs1.Close()
        rs1.Open(sql, conn)
        cmbcustorno.Items.Clear()
        Do While rs1.EOF = False
            cmbcustorno.Items.Add(rs1(0).Value)
            rs1.MoveNext()
        Loop
    End Sub
    Sub loadbillno()

        Dim i
        sql = "select max(Bill_no) from tbl_bills"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtbillno.Text = 1
        Else
            i = rs(0).Value
            txtbillno.Text = i + 1

        End If
    End Sub

    Private Sub cmbcustorno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcustorno.SelectedIndexChanged
        Dim i = 0
        Dim amount As Double
        Dim disc As Double
        Dim amt, tax As Double
        sql = "select * from tbl_customerorder where cust_order_no='" & cmbcustorno.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView1.Rows.Clear()
        Do While rs.EOF = False
            DataGridView1.Rows.Add()
            txtcustcode.Text = rs(2).Value
            DataGridView1.Item(0, i).Value = rs(4).Value
            DataGridView1.Item(1, i).Value = rs(5).Value
            sql = "select * from tbl_product where prod_code='" & DataGridView1.Item(0, i).Value & "'"
            If rs1.State = 1 Then rs1.Close()
            rs1.Open(sql, conn)
            If rs1.EOF = False Then
                DataGridView1.Item(2, i).Value = rs1(4).Value
            End If
            DataGridView1.Item(3, i).Value = DataGridView1.Item(2, i).Value * DataGridView1.Item(1, i).Value
            sql = "select * from tbl_dis where prod_code='" & DataGridView1.Item(0, i).Value & "'"
            If rs2.State = 1 Then rs2.Close()
            rs2.Open(sql, conn)
            If rs2.EOF = False Then
                DataGridView1.Item(4, i).Value = rs2(1).Value
            Else
                DataGridView1.Item(4, i).Value = 0
            End If
            'Discount calculation
            amount = DataGridView1.Item(3, i).Value * DataGridView1.Item(4, i).Value / 100
            disc = DataGridView1.Item(3, i).Value - amount
            DataGridView1.Item(5, i).Value = disc
            'Tax calculation
            If DataGridView1.Item(5, i).Value <= 5000 Then
                DataGridView1.Item(6, i).Value = 12.5
                amt = (DataGridView1.Item(5, i).Value * 12.5) / 100
            Else
                DataGridView1.Item(6, i).Value = 14.5
                amt = (DataGridView1.Item(5, i).Value * 14.5) / 100
            End If
            tax = DataGridView1.Item(5, i).Value + amt
            DataGridView1.Item(7, i).Value = tax
            txttotalamt.Text = txttotalamt.Text + tax
            rs.MoveNext()
            i = i + 1
            txtfinalamount.Text = Val(txttotalamt.Text) + Val(txtbalance.Text)

        Loop

    End Sub
    Sub loadclear()
        txtbillno.Text = ""
        cmbcustorno.Text = ""
        txtcustcode.Text = ""
        txtcustname.Text = ""
        txttinno.Text = ""
        txttotalamt.Text = 0
        txtbalance.Text = 0
        txtfinalamount.Text = 0

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim bal, i
        Dim j = 0
        i = DataGridView1.RowCount

        If cmbcustorno.Text = "" Then
            MsgBox("select order number")
        Else
            Do While j < i
                sql = "insert into tbl_sales(Bill_no,cust_order_no,cust_code,cust_name,tin_no,prod_code,qty,uprice,tprice,dscount,amtdscount,tax,amttax,totalamt,prevbalnce,amttopay,paidamount,date)"
                sql = sql & "values('" & txtbillno.Text & "','" & cmbcustorno.Text & "','" & txtcustcode.Text & "','" & txtcustname.Text & "','" & txttinno.Text & "','" & DataGridView1.Item(0, j).Value & "','" & DataGridView1.Item(1, j).Value & "','" & DataGridView1.Item(2, j).Value & "','" & DataGridView1.Item(3, j).Value & "','" & DataGridView1.Item(4, j).Value & "','" & DataGridView1.Item(5, j).Value & "','" & DataGridView1.Item(6, j).Value & "','" & DataGridView1.Item(7, j).Value & "','" & txttotalamt.Text & "','" & txtbalance.Text & "','" & txtfinalamount.Text & "',0,convert(date,'" & Today.Date & "',103))"
                conn.Execute(sql)
                j = j + 1
            Loop
            bal = Val(txtbalance.Text)
            sql = "insert into tbl_bills(Bill_no,cust_order_no,cust_code,Final_amount,Balance_amt,date,TotalAmt,status)"
            sql = sql & "values('" & txtbillno.Text & "','" & cmbcustorno.Text & "','" & txtcustcode.Text & "','" & txttotalamt.Text & "','" & bal & "',convert(date,'" & Today.Date & "',103),'" & txtfinalamount.Text & "','NotPaid')"
            conn.Execute(sql)
            sql = "update tbl_customerorder set statu='True' where cust_order_no='" & cmbcustorno.Text & "'"
            conn.Execute(sql)
            sql = "select * from tbl_prevb where cust_code='" & txtcustcode.Text & "'"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, conn)
            If rs.EOF = False Then
                sql = "update tbl_prevb set balance='" & txtfinalamount.Text & "' where cust_code='" & txtcustcode.Text & "'"
                conn.Execute(sql)
            Else
                sql = "insert into tbl_prevb(cust_code,balance)values('" & txtcustcode.Text & "','" & txtfinalamount.Text & "')"
                conn.Execute(sql)
            End If
            DataGridView1.Rows.Clear()
            MsgBox("Added")
            loadcustonum()
            num = txtbillno.Text
            loadclear()
            loadbillno()
        End If
    End Sub
    Dim addr
    Private Sub txtcustcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcustcode.TextChanged
        sql = "select * from tbl_cust where Cust_code='" & txtcustcode.Text & "'"
        If rs4.State = 1 Then rs4.Close()
        rs4.Open(sql, conn)
        If rs4.EOF = False Then
            txtcustname.Text = rs4(2).Value
            txttinno.Text = rs4(1).Value
            addr = rs4(3).Value
        End If
        'Balance display
        sql = "select * from tbl_prevb where cust_code='" & txtcustcode.Text & "'"
        If rs3.State = 1 Then rs3.Close()
        rs3.Open(sql, conn)
        If rs3.EOF = False Then
            txtbalance.Text = rs3(1).Value

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Dim cmd As New SqlCommand("select * from tbl_setting", con)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If dr.Read = True Then

            Server = dr.Item(0).ToString
            Database = dr.Item(1).ToString
            User = dr.Item(2).ToString
            Password = dr.Item(3).ToString
        End If
        con.Close()

        con.Open()
        Dim da As New SqlDataAdapter("select * from tbl_bills where Bill_no=" & num & "", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim rpt As New CrystalReport1
        rpt.DataSourceConnections.Item(0).SetConnection(Server, Database, User, Password)
        rpt.DataSourceConnections.Item(0).SetLogon(User, Password)
        rpt.SetParameterValue("billno", num)
        rpt.SetParameterValue("addr", addr)
        frmprintbill.CrystalReportViewer1.ReportSource = rpt
        frmprintbill.CrystalReportViewer1.Refresh()
        'Dim int As New salesReport1
        'int.SetDataSource(ds)
        'Salesreprt.ReportSource = int
        ' int.Refresh()

        frmprintbill.Show()
    End Sub
End Class