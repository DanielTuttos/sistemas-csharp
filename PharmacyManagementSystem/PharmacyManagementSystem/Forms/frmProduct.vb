Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class frmProduct
    Dim st As String
    Public Sub Reset()
        txtAlias.Text = ""
        txtBarcode.Text = ""
        txtDescription.Text = ""
        txtDiscount.Text = "0.00"
        txtBatchNo.Text = ""
        txtProductName.Text = ""
        txtReorderPoint.Text = ""
        cmbCategory.SelectedIndex = -1
        cmbPurchaseUnit.Text = ""
        cmbSalesUnit.Text = ""
        cmbVAT.SelectedIndex = -1
        cmbWareHouse.SelectedIndex = -1
        txtPurchaseCost.Text = "0.00"
        txtSalesCost.Text = "0.00"
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnRemoveFromGrid.Enabled = False
        btnRemoveFromGridOS.Enabled = False
        DataGridView1.Enabled = True
        btnAddOS.Enabled = True
        dgw.Rows.Clear()
        DataGridView1.Rows.Clear()
        auto()
        txtProductName.Focus()
        Clear()
        lblSet.Text = ""
    End Sub
    Private Function GenerateID() As String
        con = New SqlConnection(cs)
        Dim value As String = "0000"
        Try
            ' Fetch the latest ID from the database
            con.Open()
            cmd = New SqlCommand("SELECT TOP 1 PID FROM Product ORDER BY PID DESC", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("PID")
            End If
            rdr.Close()
            ' Increase the ID by 1
            value += 1
            ' Because incrementing a string with an integer removes 0's
            ' we need to replace them. If necessary.
            If value <= 9 Then 'Value is between 0 and 10
                value = "000" & value
            ElseIf value <= 99 Then 'Value is between 9 and 100
                value = "00" & value
            ElseIf value <= 999 Then 'Value is between 999 and 1000
                value = "0" & value
            End If
        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            value = "0000"
        End Try
        Return value
    End Function
    Sub auto()
        Try
            txtID.Text = GenerateID()
            txtProductCode.Text = "P-" + GenerateID()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Len(Trim(txtProductName.Text)) = 0 Then
                MessageBox.Show("Please enter Product name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtProductName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCategory.Text)) = 0 Then
                MessageBox.Show("Please select category", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbCategory.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbVAT.Text)) = 0 Then
                MessageBox.Show("Please select VAT Commodity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbVAT.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbPurchaseUnit.Text)) = 0 Then
                MessageBox.Show("Please select purchase unit", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbPurchaseUnit.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbSalesUnit.Text)) = 0 Then
                MessageBox.Show("Please select sales unit", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSalesUnit.Focus()
                Exit Sub
            End If
            If Len(Trim(txtDiscount.Text)) = 0 Then
                MessageBox.Show("Please enter discount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDiscount.Focus()
                Exit Sub
            End If
            If Len(Trim(txtReorderPoint.Text)) = 0 Then
                MessageBox.Show("Please enter reorder point", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtReorderPoint.Focus()
                Exit Sub
            End If
            If dgw.Rows.Count = 0 Then
                MessageBox.Show("Please add product images in datagrid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("sorry no opening stock info added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            con = New SqlConnection(cs)
            con.Open()
            Dim ct As String = "select ProductName from Product where ProductName=@d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtProductName.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("Product name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtProductName.Text = ""
                txtProductName.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
            Cursor = Cursors.WaitCursor
            Timer3.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim ck As String = "insert into Product_Join(ProductID,Image) VALUES (" & txtID.Text & ",@img)"
            cmd = New SqlCommand(ck)
            cmd.Connection = con
            ' Prepare command for repeated execution
            cmd.Prepare()

            ' Data to be inserted
            For Each row As DataGridViewRow In dgw.Rows
                If Not row.IsNewRow Then
                    Dim ms As New MemoryStream()
                    Dim img As Image = row.Cells(0).Value
                    Dim bmpImage As New Bitmap(img)
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@img", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            con.Close()
           Dim st As String = "added the new Product '" & txtProductName.Text & "' having Product code '" & txtProductCode.Text & "'"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub FillCategory()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(CategoryName) FROM Category", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbCategory.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbCategory.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub FillTax()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT distinct RTRIM(TaxName) FROM TaxMaster", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dtable = ds.Tables(0)
            cmbVAT.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                cmbVAT.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
 
    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New SqlConnection(cs)
            con.Open()
            Dim cl As String = "select PID from Purchase_Product,Product where Product.PID=Purchase_Product.ProductID and PID=@d1"
            cmd = New SqlCommand(cl)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Purchase Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cl1 As String = "SELECT PID FROM Product INNER JOIN StockTransfer_Join ON Product.PID = StockTransfer_Join.ProductID where PID=@d1"
            cmd = New SqlCommand(cl1)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", Val(txtID.Text))
            rdr = cmd.ExecuteReader()
            If rdr.Read Then
                MessageBox.Show("Unable to delete..Already in use in Stock Transfer/Issue Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not rdr Is Nothing Then
                    rdr.Close()
                End If
                Exit Sub
            End If
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from Product where PID=" & txtID.Text & ""
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "deleted the Product having Product code '" & txtProductCode.Text & "'"
                LogFunc(lblUser.Text, st)
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()

            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgw_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToGrid.Click
        dgw.Rows.Add(Picture.Image)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Picture.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFromGrid.Click
        Try
            For Each row As DataGridViewRow In dgw.SelectedRows
                dgw.Rows.Remove(row)
            Next
            btnRemoveFromGrid.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Cursor = Cursors.Default
        Timer2.Enabled = False
    End Sub


    Private Sub dgw_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        btnRemoveFromGrid.Enabled = True
    End Sub

    Private Sub btnRemove_Click_1(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Picture.Image = My.Resources._12
    End Sub

    Private Sub btnRemoveFromGridOS_Click(sender As System.Object, e As System.EventArgs)
        Try
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
            btnRemoveFromGridOS.Enabled = False
            Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtDiscount_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtDiscount.Text
            Dim selectionStart = Me.txtDiscount.SelectionStart
            Dim selectionLength = Me.txtDiscount.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                'Reject a real number with two many decimal places.
                e.Handled = False
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub txtReorderPoint_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtReorderPoint.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnGetData_Click(sender As System.Object, e As System.EventArgs) Handles btnGetData.Click
       
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Try
            If Len(Trim(txtProductName.Text)) = 0 Then
                MessageBox.Show("Please enter Product name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtProductName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCategory.Text)) = 0 Then
                MessageBox.Show("Please select category", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbCategory.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbVAT.Text)) = 0 Then
                MessageBox.Show("Please select VAT Commodity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbVAT.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbPurchaseUnit.Text)) = 0 Then
                MessageBox.Show("Please select purchase unit", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbPurchaseUnit.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbSalesUnit.Text)) = 0 Then
                MessageBox.Show("Please select sales unit", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbSalesUnit.Focus()
                Exit Sub
            End If
            If Len(Trim(txtDiscount.Text)) = 0 Then
                MessageBox.Show("Please enter discount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDiscount.Focus()
                Exit Sub
            End If
            If Len(Trim(txtReorderPoint.Text)) = 0 Then
                MessageBox.Show("Please enter reorder point", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtReorderPoint.Focus()
                Exit Sub
            End If
            If dgw.Rows.Count = 0 Then
                MessageBox.Show("Please add product images in datagrid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("sorry no opening stock info added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Cursor = Cursors.WaitCursor
            Timer3.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "Update Product set ProductCode=@d2, ProductName=@d3, Alias=@d4, VATCommodity=@d5, Description=@d6, HSNCode=@d7, Category=@d9, SalesUnit=@d12, PurchaseUnit=@d13, Barcode=@d14,DiscountPer=@d15, ReorderPoint=@d16,PurchaseCost=@d18,SalesCost=@d19 where PID=@d1"
            cmd = New SqlCommand(cb)
            cmd.Parameters.AddWithValue("@d1", txtID.Text)
            cmd.Parameters.AddWithValue("@d2", txtProductCode.Text)
            cmd.Parameters.AddWithValue("@d3", txtProductName.Text)
            cmd.Parameters.AddWithValue("@d4", txtAlias.Text)
            cmd.Parameters.AddWithValue("@d5", cmbVAT.Text)
            cmd.Parameters.AddWithValue("@d6", txtDescription.Text)
            cmd.Parameters.AddWithValue("@d7", txtBatchNo.Text)
            cmd.Parameters.AddWithValue("@d9", cmbCategory.Text)
            cmd.Parameters.AddWithValue("@d12", cmbSalesUnit.Text)
            cmd.Parameters.AddWithValue("@d13", cmbPurchaseUnit.Text)
            cmd.Parameters.AddWithValue("@d14", txtBarcode.Text)
            cmd.Parameters.AddWithValue("@d15", Val(txtDiscount.Text))
            cmd.Parameters.AddWithValue("@d16", Val(txtReorderPoint.Text))
            cmd.Parameters.AddWithValue("@d18", Val(txtPurchaseCost.Text))
            cmd.Parameters.AddWithValue("@d19", Val(txtSalesCost.Text))
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            con = New SqlConnection(cs)
            con.Open()
            Dim cq As String = "delete from Product_Join where ProductID=" & txtID.Text & ""
            cmd = New SqlCommand(cq)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con = New SqlConnection(cs)
            con.Open()
            Dim ck As String = "insert into Product_Join(ProductID,Image) VALUES (" & txtID.Text & ",@img)"
            cmd = New SqlCommand(ck)
            cmd.Connection = con
            ' Prepare command for repeated execution
            cmd.Prepare()

            ' Data to be inserted
            For Each row As DataGridViewRow In dgw.Rows
                If Not row.IsNewRow Then
                    Dim ms As New MemoryStream()
                    Dim img As Image = row.Cells(0).Value
                    Dim bmpImage As New Bitmap(img)
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@img", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            con.Close()
            Dim st As String = "updated the Product '" & txtProductName.Text & "' having Product code '" & txtProductCode.Text & "'"
            LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate.Enabled = False
            btnDelete.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Cursor = Cursors.Default
        Timer3.Enabled = False
    End Sub
    Private Sub txtNoOfCarton_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbQtyPerCarton_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQty_KeyPress_1(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbPurchaseUnit_Format(sender As Object, e As System.Windows.Forms.ListControlConvertEventArgs) Handles cmbPurchaseUnit.Format
        If (e.DesiredType Is GetType(String)) Then
            e.Value = e.Value.ToString.Trim
        End If
    End Sub

    Private Sub cmbSalesUnit_Format(sender As Object, e As System.Windows.Forms.ListControlConvertEventArgs) Handles cmbSalesUnit.Format
        If (e.DesiredType Is GetType(String)) Then
            e.Value = e.Value.ToString.Trim
        End If
    End Sub

    Private Sub DataGridView1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        If lblSet.Text = "Not allowed" Then
            btnRemoveFromGridOS.Enabled = False
        Else
            btnRemoveFromGridOS.Enabled = True
        End If
    End Sub

    Private Sub txtPurchaseCost_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurchaseCost.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtPurchaseCost.Text
            Dim selectionStart = Me.txtPurchaseCost.SelectionStart
            Dim selectionLength = Me.txtPurchaseCost.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                'Reject a real number with two many decimal places.
                e.Handled = False
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub txtSalesCost_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalesCost.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsControl(keyChar) Then
            'Allow all control characters.
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = Me.txtSalesCost.Text
            Dim selectionStart = Me.txtSalesCost.SelectionStart
            Dim selectionLength = Me.txtSalesCost.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                'Reject a real number with two many decimal places.
                e.Handled = False
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Sub

    Private Sub btnAddOS_Click(sender As System.Object, e As System.EventArgs) Handles btnAddOS.Click
        Try

            If cmbWareHouse.Text = "" Then
                MessageBox.Show("Please select warehouse", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cmbWareHouse.Focus()
                Exit Sub
            End If
            If txtQty.Text = "" Then
                MessageBox.Show("Please enter qty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtQty.Focus()
                Exit Sub
            End If
            If chkHasExpiryDate.Checked = True Then
                st = "Yes"
            Else
                st = "No"
            End If
            For Each row As DataGridViewRow In DataGridView1.Rows
                If st = "Yes" Then
                    If cmbWareHouse.Text = row.Cells(0).Value And dtpExpiryDate.Text = row.Cells(3).Value Then
                        MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
                If st = "No" Then
                    If cmbWareHouse.Text = row.Cells(0).Value Then
                        MessageBox.Show("Record already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            Next
            If st = "Yes" Then
                DataGridView1.Rows.Add(cmbWareHouse.Text, Val(txtQty.Text), st, dtpExpiryDate.Text)
            Else
                DataGridView1.Rows.Add(cmbWareHouse.Text, Val(txtQty.Text), st, "")
            End If
            Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRemoveFromGridOS_Click_1(sender As System.Object, e As System.EventArgs) Handles btnRemoveFromGridOS.Click
        Try
            If DataGridView1.Rows.Count > 0 Then
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    DataGridView1.Rows.Remove(row)
                Next
                btnRemoveFromGridOS.Enabled = False
                Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Clear()
        cmbWareHouse.SelectedIndex = -1
        txtQty.Text = 0
        chkHasExpiryDate.Checked = False
        dtpExpiryDate.Enabled = False
        btnRemoveFromGridOS.Enabled = False
        dtpExpiryDate.Value = Today
    End Sub

    Private Sub DataGridView1_MouseClick_1(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        btnRemoveFromGridOS.Enabled = True
    End Sub
    Sub fill()
        FillCategory()
        FillTax()
       
    End Sub
    Private Sub frmProduct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Fill()
    End Sub

    Private Sub chkHasExpiryDate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkHasExpiryDate.CheckedChanged
        If chkHasExpiryDate.Checked = True Then
            dtpExpiryDate.Enabled = True
        Else
            dtpExpiryDate.Enabled = False
        End If
    End Sub
End Class
