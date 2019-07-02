Imports System.Data.SqlClient
Imports System.Data

Public Class frmviewsuporder
    Dim orderno
    Private Sub frmviewsuporder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        loadorderno()
        'loadproduct()
    End Sub
    Sub loadorderno()
        sql = "select distinct(sorder_no) from tbl_supplierorder where status='Not Delivered'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        cmbsuporderno.Items.Clear()
        Do While rs.EOF = False
            cmbsuporderno.Items.Add(rs(0).Value)
            rs.MoveNext()
        Loop
    End Sub


    Private Sub cmbsuporderno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsuporderno.SelectedIndexChanged

        Dim i = 0
        sql = "select * from tbl_supplierorder where sorder_no='" & cmbsuporderno.Text & "'"
        If rs.State = 1 Then rs.Close()
        rs.Open(sql, conn)
        DataGridView2.Rows.Clear()
        Do While Not rs.EOF
            cmbordertype.Text = rs(2).Value
            supid = rs(3).Value

            DateTimePicker1.Value = rs(6).Value
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = rs(4).Value
            DataGridView2.Item(1, i).Value = rs(5).Value
            sql = "select * from tbl_supplier where supplier_id='" & supid & "'"
            If rs1.State = 1 Then rs1.Close()
            rs1.Open(sql, conn)
            If rs1.EOF = False Then
                cmbsuplname.Text = rs1(1).Value
            End If
            rs.MoveNext()
            i = i + 1
        Loop
    End Sub


    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        txtprodcode.Text = DataGridView2.CurrentRow.Cells(0).Value
        txtprdqty.Text = DataGridView2.CurrentRow.Cells(1).Value
        DataGridView2.Rows.RemoveAt(e.RowIndex)
    End Sub
    Dim i = 0
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If ComboBox1.Text = "" Then
            MsgBox("select status")
        Else
            sql = "delete from tbl_supplierorder where sorder_no='" & cmbsuporderno.Text & "'"
            conn.Execute(sql)
            Dim j = 0
            i = DataGridView2.RowCount
            Do While j < i
                orderno = cmbsuporderno.Text
                sql = "insert into tbl_supplierorder (sorder_no,order_type,supplier_id,product_code,Qty,order_date,status,delivered_date)"
                sql = sql & " Values('" & cmbsuporderno.Text & "','" & cmbordertype.Text & "','" & supid & "','" & DataGridView2.Item(0, j).Value & "','" & DataGridView2.Item(1, j).Value & "',convert(date,'" & DateTimePicker1.Value & "',103),'" & ComboBox1.Text & "',convert(date,'" & Today.Date & "',103))"
                conn.Execute(sql)
                j = j + 1
            Loop
            DataGridView2.Rows.Clear()
            MsgBox("Updated")

        End If
    End Sub


    Dim supid

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If txtprodcode.Text = "" Then
            MsgBox("Enter the product code")
        ElseIf txtprdqty.Text = "" Then
            MsgBox("Enter the product qty")
        Else
            For i = 0 To DataGridView2.Rows.Count - 1
                If txtprodcode.Text = DataGridView2.Item(0, i).Value Then
                    MsgBox("product exist in gridview")
                    Exit Sub
                End If
            Next
            i = DataGridView2.Rows.Count
            DataGridView2.Rows.Add()
            DataGridView2.Item(0, i).Value = txtprodcode.Text
            DataGridView2.Item(1, i).Value = txtprdqty.Text
            txtprodcode.Text = ""
            txtprdqty.Text = ""
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        DataGridView2.Rows.Clear()

    End Sub

    Private Sub cmbsuplname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsuplname.SelectedIndexChanged

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

   

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class