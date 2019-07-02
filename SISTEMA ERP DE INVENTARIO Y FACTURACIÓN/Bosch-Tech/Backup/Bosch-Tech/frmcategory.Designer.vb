<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcategory
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
        Me.btnok = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.txtprodcode = New System.Windows.Forms.TextBox
        Me.txtcategory = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtprodname = New System.Windows.Forms.TextBox
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.btndelete = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category"
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(28, 271)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(65, 35)
        Me.btnok.TabIndex = 2
        Me.btnok.Text = "ADD"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(302, 271)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(87, 33)
        Me.btnreset.TabIndex = 3
        Me.btnreset.Text = "RESET"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'txtprodcode
        '
        Me.txtprodcode.Location = New System.Drawing.Point(237, 39)
        Me.txtprodcode.Name = "txtprodcode"
        Me.txtprodcode.Size = New System.Drawing.Size(152, 20)
        Me.txtprodcode.TabIndex = 4
        '
        'txtcategory
        '
        Me.txtcategory.Location = New System.Drawing.Point(239, 189)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(150, 20)
        Me.txtcategory.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product Name"
        '
        'txtprodname
        '
        Me.txtprodname.Location = New System.Drawing.Point(239, 68)
        Me.txtprodname.Name = "txtprodname"
        Me.txtprodname.Size = New System.Drawing.Size(150, 20)
        Me.txtprodname.TabIndex = 11
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(99, 271)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 35)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.txtprodname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnok)
        Me.Panel1.Controls.Add(Me.txtprodcode)
        Me.Panel1.Controls.Add(Me.txtcategory)
        Me.Panel1.Location = New System.Drawing.Point(32, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 411)
        Me.Panel1.TabIndex = 14
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(239, 103)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(150, 80)
        Me.ListBox1.TabIndex = 17
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(201, 271)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(96, 35)
        Me.btndelete.TabIndex = 15
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column4})
        Me.DataGridView2.Location = New System.Drawing.Point(467, 54)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(360, 211)
        Me.DataGridView2.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product Code"
        Me.Column1.Name = "Column1"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Product name"
        Me.Column6.Name = "Column6"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Category"
        Me.Column4.Name = "Column4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "CATEGORY"
        '
        'frmcategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bosch_Tech.My.Resources.Resources.ghf
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 516)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "frmcategory"
        Me.Text = "Frmcategory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents txtprodcode As System.Windows.Forms.TextBox
    Friend WithEvents txtcategory As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtprodname As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
