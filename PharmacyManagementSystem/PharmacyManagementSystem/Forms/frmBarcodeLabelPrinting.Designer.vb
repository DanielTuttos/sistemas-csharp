<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarcodeLabelPrinting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBarcodeLabelPrinting))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNoOfCopies = New System.Windows.Forms.TextBox()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerateBarcode = New System.Windows.Forms.Button()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label6 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNoOfCopies)
        Me.GroupBox2.Controls.Add(Me.btnShowAll)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnGenerateBarcode)
        Me.GroupBox2.Controls.Add(Me.cmbProductName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(535, 96)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Info"
        '
        'txtNoOfCopies
        '
        Me.txtNoOfCopies.Location = New System.Drawing.Point(116, 61)
        Me.txtNoOfCopies.Name = "txtNoOfCopies"
        Me.txtNoOfCopies.Size = New System.Drawing.Size(100, 24)
        Me.txtNoOfCopies.TabIndex = 25
        Me.txtNoOfCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnShowAll
        '
        Me.btnShowAll.BackColor = System.Drawing.Color.OrangeRed
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnShowAll.Location = New System.Drawing.Point(408, 59)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(113, 28)
        Me.btnShowAll.TabIndex = 24
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "No. of Copies :"
        '
        'btnGenerateBarcode
        '
        Me.btnGenerateBarcode.BackColor = System.Drawing.Color.Indigo
        Me.btnGenerateBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateBarcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGenerateBarcode.Location = New System.Drawing.Point(408, 24)
        Me.btnGenerateBarcode.Name = "btnGenerateBarcode"
        Me.btnGenerateBarcode.Size = New System.Drawing.Size(113, 28)
        Me.btnGenerateBarcode.TabIndex = 23
        Me.btnGenerateBarcode.Text = "Generate Barcode"
        Me.btnGenerateBarcode.UseVisualStyleBackColor = False
        '
        'cmbProductName
        '
        Me.cmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(116, 27)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(277, 25)
        Me.cmbProductName.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Product Name :"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(1, 146)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(906, 369)
        Me.CrystalReportViewer1.TabIndex = 4
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Timer1
        '
        '
        'label6
        '
        Me.label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label6.BackColor = System.Drawing.Color.Indigo
        Me.label6.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(0, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(912, 41)
        Me.label6.TabIndex = 336
        Me.label6.Text = "Barcode Lable Printing"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBarcodeLabelPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(911, 515)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBarcodeLabelPrinting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcode Label Printing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnGenerateBarcode As System.Windows.Forms.Button
    Friend WithEvents txtNoOfCopies As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents label6 As System.Windows.Forms.Label
End Class
