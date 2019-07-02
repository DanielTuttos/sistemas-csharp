<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnmat = New System.Windows.Forms.Button()
        Me.btnnot = New System.Windows.Forms.Button()
        Me.btnau = New System.Windows.Forms.Button()
        Me.btnapod = New System.Windows.Forms.Button()
        Me.btnalu = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btndocente = New System.Windows.Forms.Button()
        Me.btnmatricula = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnaulas = New System.Windows.Forms.Button()
        Me.btnapoderado = New System.Windows.Forms.Button()
        Me.btnalumno = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btndoc = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pToolsBox = New System.Windows.Forms.Panel()
        Me.ptbinsignia = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonX = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pToolsBox.SuspendLayout()
        CType(Me.ptbinsignia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnmat
        '
        Me.btnmat.BackColor = System.Drawing.Color.Transparent
        Me.btnmat.BackgroundImage = Global.Sistema_Colegio.My.Resources.Resources.Matricula2
        Me.btnmat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnmat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmat.FlatAppearance.BorderSize = 0
        Me.btnmat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnmat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnmat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmat.Location = New System.Drawing.Point(114, 280)
        Me.btnmat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmat.Name = "btnmat"
        Me.btnmat.Size = New System.Drawing.Size(65, 65)
        Me.btnmat.TabIndex = 9
        Me.ToolTip2.SetToolTip(Me.btnmat, "MATRICULA")
        Me.btnmat.UseVisualStyleBackColor = False
        '
        'btnnot
        '
        Me.btnnot.BackColor = System.Drawing.Color.Transparent
        Me.btnnot.BackgroundImage = Global.Sistema_Colegio.My.Resources.Resources.Notas2
        Me.btnnot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnot.FlatAppearance.BorderSize = 0
        Me.btnnot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnnot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnnot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnot.Location = New System.Drawing.Point(259, 277)
        Me.btnnot.Margin = New System.Windows.Forms.Padding(4)
        Me.btnnot.Name = "btnnot"
        Me.btnnot.Size = New System.Drawing.Size(75, 70)
        Me.btnnot.TabIndex = 9
        Me.ToolTip2.SetToolTip(Me.btnnot, "NOTAS")
        Me.btnnot.UseVisualStyleBackColor = False
        '
        'btnau
        '
        Me.btnau.BackColor = System.Drawing.Color.Transparent
        Me.btnau.BackgroundImage = Global.Sistema_Colegio.My.Resources.Resources.Aula2
        Me.btnau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnau.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnau.FlatAppearance.BorderSize = 0
        Me.btnau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnau.Location = New System.Drawing.Point(330, 159)
        Me.btnau.Margin = New System.Windows.Forms.Padding(4)
        Me.btnau.Name = "btnau"
        Me.btnau.Size = New System.Drawing.Size(62, 69)
        Me.btnau.TabIndex = 9
        Me.ToolTip2.SetToolTip(Me.btnau, "AULAS")
        Me.btnau.UseVisualStyleBackColor = False
        '
        'btnapod
        '
        Me.btnapod.BackColor = System.Drawing.Color.Transparent
        Me.btnapod.BackgroundImage = Global.Sistema_Colegio.My.Resources.Resources.Padre2
        Me.btnapod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnapod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnapod.FlatAppearance.BorderSize = 0
        Me.btnapod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnapod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnapod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnapod.Location = New System.Drawing.Point(114, 47)
        Me.btnapod.Margin = New System.Windows.Forms.Padding(4)
        Me.btnapod.Name = "btnapod"
        Me.btnapod.Size = New System.Drawing.Size(65, 65)
        Me.btnapod.TabIndex = 9
        Me.ToolTip2.SetToolTip(Me.btnapod, "APODERADO")
        Me.btnapod.UseVisualStyleBackColor = False
        '
        'btnalu
        '
        Me.btnalu.BackColor = System.Drawing.Color.Transparent
        Me.btnalu.BackgroundImage = Global.Sistema_Colegio.My.Resources.Resources.Alumno1
        Me.btnalu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnalu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnalu.FlatAppearance.BorderSize = 0
        Me.btnalu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnalu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnalu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnalu.Location = New System.Drawing.Point(53, 159)
        Me.btnalu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnalu.Name = "btnalu"
        Me.btnalu.Size = New System.Drawing.Size(75, 78)
        Me.btnalu.TabIndex = 9
        Me.ToolTip2.SetToolTip(Me.btnalu, "ALUMNO")
        Me.btnalu.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Maroon
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button8.Location = New System.Drawing.Point(1394, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(45, 45)
        Me.Button8.TabIndex = 16
        Me.Button8.Text = "X"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'btndocente
        '
        Me.btndocente.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btndocente.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndocente.Location = New System.Drawing.Point(7, 451)
        Me.btndocente.Margin = New System.Windows.Forms.Padding(4)
        Me.btndocente.Name = "btndocente"
        Me.btndocente.Size = New System.Drawing.Size(180, 93)
        Me.btndocente.TabIndex = 0
        Me.btndocente.Text = "DOCENTE"
        Me.btndocente.UseVisualStyleBackColor = False
        '
        'btnmatricula
        '
        Me.btnmatricula.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnmatricula.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmatricula.Location = New System.Drawing.Point(7, 364)
        Me.btnmatricula.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmatricula.Name = "btnmatricula"
        Me.btnmatricula.Size = New System.Drawing.Size(179, 92)
        Me.btnmatricula.TabIndex = 0
        Me.btnmatricula.Text = "MATRICULAR"
        Me.btnmatricula.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(7, 277)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(179, 90)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "NOTAS"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnaulas
        '
        Me.btnaulas.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnaulas.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaulas.Location = New System.Drawing.Point(7, 196)
        Me.btnaulas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaulas.Name = "btnaulas"
        Me.btnaulas.Size = New System.Drawing.Size(180, 86)
        Me.btnaulas.TabIndex = 0
        Me.btnaulas.Text = "AULAS"
        Me.btnaulas.UseVisualStyleBackColor = False
        '
        'btnapoderado
        '
        Me.btnapoderado.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnapoderado.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnapoderado.Location = New System.Drawing.Point(7, 107)
        Me.btnapoderado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnapoderado.Name = "btnapoderado"
        Me.btnapoderado.Size = New System.Drawing.Size(180, 94)
        Me.btnapoderado.TabIndex = 0
        Me.btnapoderado.Text = "APODERADO"
        Me.btnapoderado.UseVisualStyleBackColor = False
        '
        'btnalumno
        '
        Me.btnalumno.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnalumno.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalumno.Location = New System.Drawing.Point(7, 18)
        Me.btnalumno.Margin = New System.Windows.Forms.Padding(4)
        Me.btnalumno.Name = "btnalumno"
        Me.btnalumno.Size = New System.Drawing.Size(179, 90)
        Me.btnalumno.TabIndex = 0
        Me.btnalumno.Text = "ALUMNO"
        Me.btnalumno.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnmatricula)
        Me.GroupBox1.Controls.Add(Me.btndocente)
        Me.GroupBox1.Controls.Add(Me.btnalumno)
        Me.GroupBox1.Controls.Add(Me.btnapoderado)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.btnaulas)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Location = New System.Drawing.Point(12, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 551)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel de Opciones"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Maroon
        Me.Button7.Font = New System.Drawing.Font("MS Reference Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.Location = New System.Drawing.Point(51, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(43, 43)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "-"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btndoc
        '
        Me.btndoc.BackColor = System.Drawing.Color.Transparent
        Me.btndoc.BackgroundImage = Global.Sistema_Colegio.My.Resources.Resources.Docente2
        Me.btndoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btndoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndoc.FlatAppearance.BorderSize = 0
        Me.btndoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btndoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btndoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndoc.Location = New System.Drawing.Point(264, 47)
        Me.btndoc.Margin = New System.Windows.Forms.Padding(4)
        Me.btndoc.Name = "btndoc"
        Me.btndoc.Size = New System.Drawing.Size(70, 65)
        Me.btndoc.TabIndex = 9
        Me.ToolTip2.SetToolTip(Me.btndoc, "DOCENTE")
        Me.btndoc.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.label2)
        Me.GroupBox2.Controls.Add(Me.lblhora)
        Me.GroupBox2.Controls.Add(Me.lblfecha)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 629)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 90)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha y Hora"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.Control
        Me.label2.Location = New System.Drawing.Point(5, 26)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(75, 24)
        Me.label2.TabIndex = 20
        Me.label2.Text = "Fecha:"
        '
        'lblhora
        '
        Me.lblhora.BackColor = System.Drawing.Color.Transparent
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblhora.Location = New System.Drawing.Point(74, 52)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(81, 21)
        Me.lblhora.TabIndex = 23
        Me.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfecha
        '
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblfecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblfecha.Location = New System.Drawing.Point(68, 30)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(116, 19)
        Me.lblfecha.TabIndex = 21
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(5, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Hora:"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'pToolsBox
        '
        Me.pToolsBox.BackColor = System.Drawing.Color.Transparent
        Me.pToolsBox.BackgroundImage = Global.Sistema_Colegio.My.Resources.Resources.fondooo
        Me.pToolsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pToolsBox.Controls.Add(Me.ptbinsignia)
        Me.pToolsBox.Controls.Add(Me.PictureBox1)
        Me.pToolsBox.Controls.Add(Me.btndoc)
        Me.pToolsBox.Controls.Add(Me.btnnot)
        Me.pToolsBox.Controls.Add(Me.btnapod)
        Me.pToolsBox.Controls.Add(Me.btnalu)
        Me.pToolsBox.Controls.Add(Me.btnau)
        Me.pToolsBox.Controls.Add(Me.btnmat)
        Me.pToolsBox.Location = New System.Drawing.Point(415, 78)
        Me.pToolsBox.Name = "pToolsBox"
        Me.pToolsBox.Size = New System.Drawing.Size(450, 400)
        Me.pToolsBox.TabIndex = 26
        '
        'ptbinsignia
        '
        Me.ptbinsignia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbinsignia.Image = Global.Sistema_Colegio.My.Resources.Resources.Insignia_NIXA
        Me.ptbinsignia.Location = New System.Drawing.Point(153, 134)
        Me.ptbinsignia.Name = "ptbinsignia"
        Me.ptbinsignia.Size = New System.Drawing.Size(153, 130)
        Me.ptbinsignia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbinsignia.TabIndex = 11
        Me.ptbinsignia.TabStop = False
        Me.ptbinsignia.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Sistema_Colegio.My.Resources.Resources.Insignia_NIXA
        Me.PictureBox1.Location = New System.Drawing.Point(153, 134)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1362, 50)
        Me.Panel1.TabIndex = 27
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.Image = Global.Sistema_Colegio.My.Resources.Resources.Cabecera1
        Me.PictureBox2.Location = New System.Drawing.Point(374, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(456, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ButtonX)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1216, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(146, 50)
        Me.Panel2.TabIndex = 0
        '
        'ButtonX
        '
        Me.ButtonX.BackColor = System.Drawing.Color.Maroon
        Me.ButtonX.Font = New System.Drawing.Font("MS Reference Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonX.Location = New System.Drawing.Point(100, 4)
        Me.ButtonX.Name = "ButtonX"
        Me.ButtonX.Size = New System.Drawing.Size(43, 43)
        Me.ButtonX.TabIndex = 17
        Me.ButtonX.Text = "x"
        Me.ButtonX.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Sistema_Colegio.My.Resources.Resources.fondo_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pToolsBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuPrincipal"
        Me.Text = "6"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pToolsBox.ResumeLayout(False)
        CType(Me.ptbinsignia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnalu As System.Windows.Forms.Button
    Friend WithEvents btnapod As System.Windows.Forms.Button
    Friend WithEvents btnau As System.Windows.Forms.Button
    Friend WithEvents btnnot As System.Windows.Forms.Button
    Friend WithEvents btnmat As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btndocente As System.Windows.Forms.Button
    Friend WithEvents btnmatricula As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnaulas As System.Windows.Forms.Button
    Friend WithEvents btnapoderado As System.Windows.Forms.Button
    Friend WithEvents btnalumno As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btndoc As System.Windows.Forms.Button
    Friend WithEvents pToolsBox As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonX As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ptbinsignia As System.Windows.Forms.PictureBox
End Class
