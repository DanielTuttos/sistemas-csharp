Imports System.Data.SqlClient
Public Class frmBarcodeLabelPrinting

    Sub fillCombo()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT ProductName FROM Product order by 1", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbProductName.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbProductName.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub frmBarcodeLabelPrinting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillCombo()
        cmbProductName.Text = ""
        txtNoOfCopies.Text = ""
    End Sub

    Private Sub txtNoOfCopies_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoOfCopies.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnShowAll_Click(sender As System.Object, e As System.EventArgs) Handles btnShowAll.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim rpt As New rptBarcodeLabelPrinting()
            Dim myConnection As SqlConnection = Nothing
            Dim MyCommand As New SqlCommand()
            Dim myDS As New DataSet()
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            Dim st As String = "Select * from Product order by ProductName"
            Dim st1 As String = "Select * from Company"
            Dim myDA As New SqlDataAdapter(st, cs)
            Dim myDA1 As New SqlDataAdapter(st1, cs)
            myDA.Fill(myDS, "Product")
            myDA1.Fill(myDS, "Company")
            rpt.SetDataSource(myDS)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub

    Private Sub cmbProductName_Format(sender As System.Object, e As System.Windows.Forms.ListControlConvertEventArgs) Handles cmbProductName.Format
        If (e.DesiredType Is GetType(String)) Then
            e.Value = e.Value.ToString.Trim
        End If
    End Sub
End Class