Imports System.Data.SqlClient
Imports System.Data

Public Class frmsupplierorder
    Dim orderno
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

        Dim j = 0
        i = DataGridView1.RowCount
        If cmbordertype.Text = "" Or cmbsuplname.Text = "" Or DataGridView1.RowCount = 0 Then
            MsgBox("Enter all the fileds")

        Else
            Do While j < i
                orderno = txtorderno.Text
                sql = "insert into tbl_supplierorder (sorder_no,order_type,supplier_id,product_code,Qty,order_date,status)"
                sql = sql & " Values('" & txtorderno.Text & "','" & cmbordertype.Text & "','" & supid & "','" & DataGridView1.Item(0, j).Value & "','" & DataGridView1.Item(1, j).Value & "',convert(date,'" & DateTimePicker1.Value & "',103),'Not Delivered')"
                conn.Execute(sql)
                j = j + 1
            Loop

            MsgBox("Added")
            loadorderno()
            clear()
        End If
    End Sub
    Dim supid
    Sub loadorderno()

        Dim i
        sql = "select max(sorder_no) from tbl_supplierorder"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If IsDBNull(rs(0).Value) = True Then
            txtorderno.Text = 100
        Else
            i = rs(0).Value
            txtorderno.Text = i + 1

        End If
    End Sub
    Dim a
    Private Sub frmsupplierorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadorderno()
        loadsupname()
        ListBox1.Visible = False
    End Sub
    Sub loadsupname()
        sql = "select * from tbl_supplier"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbsuplname.Items.Clear()
        Do While Not rs.EOF
            cmbsuplname.Items.Add(rs(1).Value)
            rs.MoveNext()
        Loop
    End Sub


    Private Sub txtprdname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprdname.TextChanged
        If txtprdname.Text <> "" Then
            ListBox1.Visible = True
            sql = "select distinct(Prod_code) from tbl_product where Prod_code like '" & txtprdname.Text & "%' "
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

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        txtprdname.Text = ListBox1.SelectedItem
        ListBox1.Visible = False
    End Sub

    Private Sub cmbsuplname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsuplname.SelectedIndexChanged
        sql = "select * from tbl_supplier where supplier_name='" & cmbsuplname.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        If rs.EOF = False Then
            supid = rs(0).Value
        End If
    End Sub
    Sub clear()
        cmbordertype.Text = ""
        cmbsuplname.Text = ""
        DataGridView1.Rows.Clear()

    End Sub

    Dim i = 0
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If txtprdname.Text = "" Then
            MsgBox("Enter the product code")
        ElseIf txtprdqty.Text = "" Then
            MsgBox("Enter the product qty")
        Else
            For i = 0 To DataGridView1.Rows.Count - 1
                If txtprdname.Text = DataGridView1.Item(0, i).Value Then
                    MsgBox("product exist in gridview")
                    Exit Sub
                End If
            Next
            DataGridView1.Rows.Add()
            DataGridView1.Item(0, i).Value = txtprdname.Text
            DataGridView1.Item(1, i).Value = txtprdqty.Text
            i = i + 1
            txtprdname.Text = ""
            txtprdqty.Text = ""
        End If
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If orderno = "" Then
            MsgBox("Add the record first")
        Else

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
            Dim da As New SqlDataAdapter("select * from tbl_supplierorder where sorder_no=" & orderno & "", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Dim rpt As New CrystalReport2
            rpt.DataSourceConnections.Item(0).SetConnection(Server, Database, User, Password)
            rpt.DataSourceConnections.Item(0).SetLogon(User, Password)
            rpt.SetParameterValue("orderno", orderno)
            frmprintbill.CrystalReportViewer1.ReportSource = rpt
            frmprintbill.CrystalReportViewer1.Refresh()
            'Dim int As New salesReport1
            'int.SetDataSource(ds)
            'Salesreprt.ReportSource = int
            ' int.Refresh()

            frmprintbill.Show()
        End If
    End Sub

    Private Sub btncancl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancl.Click
        Me.Close()

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtorderno.Text = ""
        txtprdname.Text = ""
        txtprdqty.Text = ""
        cmbsuplname.Text = ""
        cmbordertype.Text = ""
    End Sub
End Class