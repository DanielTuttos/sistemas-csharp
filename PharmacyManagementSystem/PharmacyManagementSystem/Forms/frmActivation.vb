Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Public Class frmActivation

    Private Sub frmActivation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If txtActivationID.Text = "" Then
                MessageBox.Show("Please enter activation id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtActivationID.Focus()
                Exit Sub
            End If
            Dim st As String = (txtHardwareID.Text)
            TextBox1.Text = Encryption.MakePassword(st, 659)
            If txtActivationID.Text = TextBox1.Text Then
                MessageBox.Show("Successfully activated", "Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmLogin.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid activation id...Please contact software provider for buying full licence" & vbCrLf & "Contact us at :" & vbCrLf & "Raj Sharma" & vbCrLf & "Email-Sharma.raj@outlook.com" & vbCrLf & "Mobile No. +919827858191", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
