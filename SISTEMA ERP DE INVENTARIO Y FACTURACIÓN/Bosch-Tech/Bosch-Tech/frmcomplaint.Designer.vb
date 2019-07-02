<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcomplaint
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcomplaint = New System.Windows.Forms.TextBox
        Me.txtbilllno = New System.Windows.Forms.TextBox
        Me.txtcustcomplaint = New System.Windows.Forms.TextBox
        Me.cmbcustcode = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnok = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Complaint Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bill Number"
        '
        'txtcomplaint
        '
        Me.txtcomplaint.Location = New System.Drawing.Point(221, 60)
        Me.txtcomplaint.Name = "txtcomplaint"
        Me.txtcomplaint.Size = New System.Drawing.Size(100, 20)
        Me.txtcomplaint.TabIndex = 4
        '
        'txtbilllno
        '
        Me.txtbilllno.Location = New System.Drawing.Point(221, 133)
        Me.txtbilllno.Name = "txtbilllno"
        Me.txtbilllno.Size = New System.Drawing.Size(100, 20)
        Me.txtbilllno.TabIndex = 6
        '
        'txtcustcomplaint
        '
        Me.txtcustcomplaint.Location = New System.Drawing.Point(193, 185)
        Me.txtcustcomplaint.Multiline = True
        Me.txtcustcomplaint.Name = "txtcustcomplaint"
        Me.txtcustcomplaint.Size = New System.Drawing.Size(238, 122)
        Me.txtcustcomplaint.TabIndex = 7
        '
        'cmbcustcode
        '
        Me.cmbcustcode.FormattingEnabled = True
        Me.cmbcustcode.Location = New System.Drawing.Point(221, 96)
        Me.cmbcustcode.Name = "cmbcustcode"
        Me.cmbcustcode.Size = New System.Drawing.Size(121, 21)
        Me.cmbcustcode.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Complaint"
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(45, 283)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(75, 23)
        Me.btnok.TabIndex = 10
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'frmcomplaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 386)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbcustcode)
        Me.Controls.Add(Me.txtcustcomplaint)
        Me.Controls.Add(Me.txtbilllno)
        Me.Controls.Add(Me.txtcomplaint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmcomplaint"
        Me.Text = "frmcomplaint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcomplaint As System.Windows.Forms.TextBox
    Friend WithEvents txtbilllno As System.Windows.Forms.TextBox
    Friend WithEvents txtcustcomplaint As System.Windows.Forms.TextBox
    Friend WithEvents cmbcustcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
End Class
