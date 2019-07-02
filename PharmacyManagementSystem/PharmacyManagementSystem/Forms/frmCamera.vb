Public Class frmCamera
    Public CamMgr As TouchlessLib.TouchlessMgr
   
    Private Sub cmbCamera_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCamera.SelectedIndexChanged
        CamMgr.CurrentCamera = CamMgr.Cameras.ElementAt(cmbCamera.SelectedIndex)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        picFeed.Image = CamMgr.CurrentCamera.GetCurrentImage()
    End Sub

    Private Sub btnCapture_Click(sender As System.Object, e As System.EventArgs) Handles btnCapture.Click
        picPreview.Image = CamMgr.CurrentCamera.GetCurrentImage()
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim sTempFileName As String = System.IO.Path.GetTempFileName()
        TempFileNames2 = sTempFileName
        Dim b As Bitmap = picPreview.Image
        b.Save(sTempFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        Timer1.Enabled = False
        CamMgr.CurrentCamera.Dispose()
        CamMgr.Cameras.Item(cmbCamera.SelectedIndex).Dispose()
        CamMgr.Dispose()

        Me.Close()
    End Sub


End Class
