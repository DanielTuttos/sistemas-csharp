Imports System.IO
Imports System.Text

Public Class frmmaster

    Private Sub frmmaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        If usrtype = "User" Then
            AddNewEmployeeToolStripMenuItem.Visible = False
            RegisterEmployeeToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub MasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionToolStripMenuItem.Click

    End Sub
    Private Sub AddNewEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewEmployeeToolStripMenuItem.Click
        frmemployee.Show()
    End Sub

    Private Sub RegisterEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterEmployeeToolStripMenuItem.Click
        frmregistration.Show()

    End Sub

    Private Sub AddCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCategoryToolStripMenuItem.Click
        frmcategory.Show()
    End Sub


    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click

        ''Shell("C:\Windows\System32\notepad.exe")
        'System.Diagnostics.Process.Start("D:\Bosch-Tech\Bosch-Tech\My Project\help.html")
        ''Shell("E:\Bosch-Tech\Bosch-Tech\My Project\help.html")

        Dim ruta As String = Application.StartupPath + "\help.html"

        'Comprobamos que la ruta exista
        If File.Exists(ruta) Then
            Process.Start(ruta)
        End If


    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmchangepass.Show()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        frmsupplierorder.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        frmviewsuporder.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmcust.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        frmlogin.Show()
        Me.Close()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        frmsupplier.Show()
    End Sub


    Private Sub AddToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmcust.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AddToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem2.Click
        frmcustorder.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem2.Click
        frmviewcustorder.Show()
    End Sub

    Private Sub CustomerOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerOrderToolStripMenuItem.Click

    End Sub

    Private Sub MinimalStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimalStockToolStripMenuItem.Click
        frmproduct.Show()
    End Sub
    Private Sub ViewStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStockToolStripMenuItem.Click
        frmstock.Show()
    End Sub

    Private Sub SupplierBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierBillToolStripMenuItem.Click

    End Sub

    Private Sub CustomerBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerBillToolStripMenuItem.Click
        frmsales.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem1.Click
        frmreport.Show()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolStripMenuItem.Click
        frmreplace.Show()
    End Sub

    Private Sub SearchCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCustomerToolStripMenuItem.Click
        frmsearchcustomer.Show()
    End Sub

    Private Sub SearchProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchProductsToolStripMenuItem.Click
        frmsearchproducts.Show()
    End Sub

    Private Sub DamagedProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamagedProductsToolStripMenuItem.Click
        frmscrap.Show()
    End Sub

    Private Sub AddCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomerToolStripMenuItem.Click
        frmcust.Show()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click
        frmpayment.Show()
    End Sub
End Class