
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class frmPrinterSetting
    Dim st2 As String
    Sub Reset()
        cmbPrinterType.SelectedIndex = -1
        cmbPrinter.SelectedIndex = -1
        chkIsEnabled.Checked = True
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        chkIsEnabled.Checked = False
        cmbPrinterType.Focus()
    End Sub
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(cmbPrinterType.Text)) = 0 Then
            MessageBox.Show("Please select printer type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPrinterType.Focus()
            Exit Sub
        End If
        If Len(Trim(cmbPrinter.Text)) = 0 Then
            MessageBox.Show("Please select printer", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbPrinter.Focus()
            Exit Sub
        End If
    End Sub


   

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
      
    End Sub
   

    Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles dgw.MouseClick
        Try
            If dgw.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = dgw.SelectedRows(0)
                txtID.Text = dr.Cells(0).Value.ToString()
                cmbPrinterType.Text = dr.Cells(1).Value.ToString()
                cmbPrinter.Text = dr.Cells(2).Value.ToString()
                If dr.Cells(3).Value.ToString() = "Yes" Then
                    chkIsEnabled.Checked = True
                Else
                    chkIsEnabled.Checked = False
                End If
                btnUpdate.Enabled = True
                btnDelete.Enabled = True
                btnSave.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgw_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgw.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If dgw.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            dgw.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ButtonHighlight
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    End Class