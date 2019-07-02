Imports System.Data.SqlClient
Imports System.IO

Imports Microsoft.SqlServer.Management.Smo
Imports System.Globalization

Public Class frmMainMenu
    Dim Filename As String


    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub
    Sub Backup()
        Try
            Dim dt As DateTime = Today
            Dim destdir As String = "PharmacyDB " & System.DateTime.Now.ToString("dd-MM-yyyy_h-mm-ss") & ".bak"
            Dim objdlg As New SaveFileDialog
            objdlg.FileName = destdir
            objdlg.ShowDialog()
            Filename = objdlg.FileName
            Cursor = Cursors.WaitCursor
            Timer4.Enabled = True
            con = New SqlConnection(cs)
            con.Open()
            Dim cb As String = "backup database PharmacyDB to disk='" & Filename & "'with init,stats=10"
            cmd = New SqlCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BackupToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrationToolStripMenuItem.Click
        frmRegistration.lblUser.Text = lblUser.Text
        frmRegistration.Reset()
        frmRegistration.ShowDialog()
    End Sub

    Private Sub LogsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogsToolStripMenuItem.Click
        frmLogs.Reset()
        frmLogs.lblUser.Text = lblUser.Text
        frmLogs.ShowDialog()
    End Sub

 

    Private Sub CalculatorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub WordpadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WordpadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("wordpad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MSWordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MSWordToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("winword.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TaskManagerToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("TaskMgr.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SystemInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SystemInfoToolStripMenuItem.Click
        frmSystemInfo.ShowDialog()
    End Sub
    Sub LogOut()
        Dim st As String = "Successfully logged out"
        LogFunc(lblUser.Text, st)
        Me.Hide()
        frmLogin.Show()
        frmLogin.UserID.Text = ""
        frmLogin.Password.Text = ""
        frmLogin.UserID.Focus()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Try
            If MessageBox.Show("Do you really want to logout from application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If MessageBox.Show("Do you want backup database before logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Backup()
                    LogOut()
                Else
                    LogOut()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMainMenu_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub CompanyInfoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CompanyInfoToolStripMenuItem.Click
       
    End Sub

    Private Sub CurrencyMasterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CurrencyMasterToolStripMenuItem.Click
        frmCurrency.lblUser.Text = lblUser.Text
        frmCurrency.Reset()
        frmCurrency.ShowDialog()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        frmCategory.lblUser.Text = lblUser.Text
        frmCategory.Reset()
        frmCategory.ShowDialog()
    End Sub

    Private Sub frmMainMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If lblUserType.Text = "Admin" Then
            MasterEntryToolStripMenuItem.Enabled = True
            RegistrationToolStripMenuItem.Enabled = True
            LogsToolStripMenuItem.Enabled = True
            DatabaseToolStripMenuItem.Enabled = True
            CustomerToolStripMenuItem.Enabled = True
            SupplierToolStripMenuItem.Enabled = True
            ProductToolStripMenuItem.Enabled = True
            StockToolStripMenuItem.Enabled = True
            StockInToolStripMenuItem.Enabled = True
            BillingToolStripMenuItem.Enabled = True
            ' RecordToolStripMenuItem.Enabled = True
            ' ReportsToolStripMenuItem.Enabled = True
            VoucherToolStripMenuItem.Enabled = True
            StockIssueToolStripMenuItem.Enabled = True
            PaymentToolStripMenuItem.Enabled = True
        End If
        If lblUserType.Text = "Cashier" Then
            MasterEntryToolStripMenuItem.Enabled = False
            RegistrationToolStripMenuItem.Enabled = False
            LogsToolStripMenuItem.Enabled = False
            DatabaseToolStripMenuItem.Enabled = False
            CustomerToolStripMenuItem.Enabled = True
            SupplierToolStripMenuItem.Enabled = False
            ProductToolStripMenuItem.Enabled = False
            StockToolStripMenuItem.Enabled = False
            StockInToolStripMenuItem.Enabled = True
            BillingToolStripMenuItem.Enabled = True
            ' RecordToolStripMenuItem.Enabled = False
            ' ReportsToolStripMenuItem.Enabled = False
            VoucherToolStripMenuItem.Enabled = False
            StockIssueToolStripMenuItem.Enabled = False
            PaymentToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub WarehouseTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WarehouseTypeToolStripMenuItem.Click
        frmWarehouseType.lblUser.Text = lblUser.Text
        frmWarehouseType.Reset()
        frmWarehouseType.ShowDialog()
    End Sub

    Private Sub WarehouseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WarehouseToolStripMenuItem.Click
        frmWarehouse.lblUser.Text = lblUser.Text
        frmWarehouse.Reset()
        frmWarehouse.ShowDialog()
    End Sub


    Private Sub ExpenseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExpenseToolStripMenuItem.Click
        frmExpense.lblUser.Text = lblUser.Text
        frmExpense.Reset()
        frmExpense.ShowDialog()
    End Sub

    Private Sub TaxTypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TaxTypeToolStripMenuItem.Click
       
    End Sub

    Private Sub TaxToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles TaxToolStripMenuItem1.Click
        frmTax.lblUser.Text = lblUser.Text
        frmTax.Reset()
        frmTax.ShowDialog()
    End Sub

  

   

    Private Sub SupplierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        frmSupplier.lblUser.Text = lblUser.Text
        frmSupplier.Reset()
        frmSupplier.ShowDialog()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        frmCustomer.lblUser.Text = lblUser.Text
        frmCustomer.Reset()
        frmCustomer.ShowDialog()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        frmProduct.lblUser.Text = lblUser.Text
        frmProduct.Reset()
        frmProduct.ShowDialog()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockToolStripMenuItem.Click
        frmPurchase.lblUser.Text = lblUser.Text
        frmPurchase.Reset()
        frmPurchase.ShowDialog()
    End Sub

    Private Sub VoucherToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VoucherToolStripMenuItem.Click

    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PaymentToolStripMenuItem.Click
        frmPayment.lblUser.Text = lblUser.Text
        frmPayment.Reset()
        frmPayment.ShowDialog()
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Cursor = Cursors.Default
        Timer4.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Dim dt As DateTime = Today
        lblDateTime.Text = dt.ToString("dd/MM/yyyy")
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub StockIssueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StockIssueToolStripMenuItem.Click
        frmStockTransfer.lblUser.Text = lblUser.Text
        frmStockTransfer.Reset()
        frmStockTransfer.ShowDialog()
    End Sub

    Private Sub StoreMasterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StoreMasterToolStripMenuItem.Click
        frmStore.lblUser.Text = lblUser.Text
        frmStore.Reset()
        frmStore.ShowDialog()
    End Sub

  

   

   

    Private Sub StockOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
      
    End Sub

    Private Sub LowStockToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
      
    End Sub

    Private Sub ExpiredProductsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmExpiredProductsRecord.Reset()
        frmExpiredProductsRecord.ShowDialog()
    End Sub

  

   

   

    Private Sub BarcodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BarcodeToolStripMenuItem.Click
        frmBarcodeLabelPrinting.ShowDialog()
    End Sub

  


    Private Sub CreditorsAndDebtorsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ExpiredProductsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
     
    End Sub

    Private Sub BillingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BillingToolStripMenuItem.Click
       
    End Sub



    Private Sub CustomersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomersToolStripMenuItem.Click
        frmCustomerRecord1.Reset()
        frmCustomerRecord1.ShowDialog()
    End Sub

  

  

    Private Sub StockINToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles StockINToolStripMenuItem4.Click
        frmStockInRecord.Reset()
        frmStockInRecord.ShowDialog()
    End Sub

    Private Sub StockOUTToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles StockOUTToolStripMenuItem2.Click
        
    End Sub

    Private Sub LowStockToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles LowStockToolStripMenuItem2.Click
        
    End Sub

    Private Sub ExpiredProductsToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ExpiredProductsToolStripMenuItem2.Click
        frmExpiredProductsRecord.Reset()
        frmExpiredProductsRecord.ShowDialog()
    End Sub

    Private Sub StoreStockINToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StoreStockINToolStripMenuItem.Click
        
    End Sub

    Private Sub StoreStockOUTToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StoreStockOUTToolStripMenuItem.Click
      
    End Sub


    Private Sub StoreExpiredProductsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StoreExpiredProductsToolStripMenuItem.Click
       
    End Sub

    Private Sub SalesToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles SalesToolStripMenuItem2.Click
        
    End Sub





    Private Sub SalesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SalesToolStripMenuItem1.Click
      
    End Sub

   

    Private Sub PurchaseDaybookToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PurchaseDaybookToolStripMenuItem1.Click
        frmPurchaseDaybook.Reset()
        frmPurchaseDaybook.ShowDialog()
    End Sub

    Private Sub GeneralDaybookToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles GeneralDaybookToolStripMenuItem1.Click
        frmGeneralDayBook.Reset()
        frmGeneralDayBook.ShowDialog()
    End Sub

    Private Sub SupplierLedgerToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SupplierLedgerToolStripMenuItem1.Click
        frmSupplierLedger.Reset()
        frmSupplierLedger.ShowDialog()
    End Sub

    Private Sub CustomerLedgerToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles CustomerLedgerToolStripMenuItem1.Click
        frmCustomerLedger.Reset()
        frmCustomerLedger.ShowDialog()
    End Sub

    Private Sub GeneralLedgerToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles GeneralLedgerToolStripMenuItem1.Click
        frmGeneralLedger.Reset()
        frmGeneralLedger.ShowDialog()
    End Sub

    Private Sub TrialBalanceToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles TrialBalanceToolStripMenuItem1.Click
        frmTrialBalance.Reset()
        frmTrialBalance.ShowDialog()
    End Sub

    Private Sub StockIssueToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles StockIssueToolStripMenuItem1.Click
        frmStockTransfer.lblUser.Text = lblUser.Text
        frmStockTransfer.Reset()
        frmStockTransfer.ShowDialog()
    End Sub

 

    Private Sub DatabaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        Backup()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            With OpenFileDialog1
                .Filter = ("DB Backup File|*.bak;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Timer4.Enabled = True
                SqlConnection.ClearAllPools()
                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "USE Master ALTER DATABASE PharmacyDB SET Single_User WITH Rollback Immediate Restore database PharmacyDB FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE PharmacyDB SET Multi_User "
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()
                Dim st As String = "Sucessfully performed the restore"
                LogFunc(lblUser.Text, st)
                MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Try
            With OpenFileDialog1
                .Filter = ("DB Backup File|*.bak;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Timer4.Enabled = True
                SqlConnection.ClearAllPools()
                con = New SqlConnection(cs)
                con.Open()
                Dim cb As String = "USE Master ALTER DATABASE PharmacyDB SET Single_User WITH Rollback Immediate Restore database PharmacyDB FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE PharmacyDB SET Multi_User "
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()
                Dim st As String = "Sucessfully performed the restore"
                LogFunc(lblUser.Text, st)
                MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Backup()
    End Sub

    Private Sub BarcodeToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles BarcodeToolStripMenuItem1.Click
        frmBarcodeLabelPrinting.ShowDialog()
    End Sub

    Private Sub BillingToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles BillingToolStripMenuItem1.Click
       
    End Sub

    Private Sub SQLServerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SQLServerToolStripMenuItem.Click
        frmSqlServerSetting.Reset()
        frmSqlServerSetting.lblSet.Text = "Main Form"
        frmSqlServerSetting.ShowDialog()
    End Sub

    Private Sub POSPrinterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles POSPrinterToolStripMenuItem.Click
        frmPrinterSetting.Reset()
        frmPrinterSetting.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        frmSMSSetting.Reset()
        frmSMSSetting.ShowDialog()
    End Sub

    Private Sub SQLServerToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SQLServerToolStripMenuItem1.Click
        frmSqlServerSetting.Reset()
        frmSqlServerSetting.lblSet.Text = "Main Form"
        frmSqlServerSetting.ShowDialog()
    End Sub

    Private Sub POSPrinterToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles POSPrinterToolStripMenuItem1.Click
        frmPrinterSetting.Reset()
        frmPrinterSetting.ShowDialog()
    End Sub

    Private Sub PaymentToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PaymentToolStripMenuItem1.Click
        frmPayment.lblUser.Text = lblUser.Text
        frmPayment.Reset()
        frmPayment.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click
        frmContactMe.ShowDialog()
    End Sub

    Private Sub ProductToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ProductToolStripMenuItem1.Click
        frmProduct.lblUser.Text = lblUser.Text
        frmProduct.Reset()
        frmProduct.ShowDialog()
    End Sub

    Private Sub PurchaseToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PurchaseToolStripMenuItem1.Click
        frmPurchase.lblUser.Text = lblUser.Text
        frmPurchase.Reset()
        frmPurchase.ShowDialog()
    End Sub
End Class