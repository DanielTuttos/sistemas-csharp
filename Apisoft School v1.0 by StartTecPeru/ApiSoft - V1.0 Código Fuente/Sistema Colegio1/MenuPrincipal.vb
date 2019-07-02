Public Class MenuPrincipal

    Private Sub btnalu_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnalu.MouseMove
        btnalu.BackgroundImage = My.Resources.Alumno2
        btnmat.BackgroundImage = My.Resources.Matricula2
        btnapod.BackgroundImage = My.Resources.Padre2
    End Sub

    Private Sub btnapod_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnapod.MouseMove
        btnapod.BackgroundImage = My.Resources.Padre1
        btnalu.BackgroundImage = My.Resources.Alumno1
        btndoc.BackgroundImage = My.Resources.Docente2
    End Sub

    Private Sub btndoc_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndoc.MouseMove
        btndoc.BackgroundImage = My.Resources.Docente1
        btnapod.BackgroundImage = My.Resources.Padre2
        btnau.BackgroundImage = My.Resources.Aula2
    End Sub

    Private Sub btnau_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnau.MouseMove
        btnau.BackgroundImage = My.Resources.Aula1
        btndoc.BackgroundImage = My.Resources.Docente2
        btnnot.BackgroundImage = My.Resources.Notas2
    End Sub

    Private Sub btnnot_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnnot.MouseMove
        btnnot.BackgroundImage = My.Resources.Notas1
        btnmat.BackgroundImage = My.Resources.Matricula2
    End Sub

    Private Sub btnmat_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnmat.MouseMove
        btnmat.BackgroundImage = My.Resources.Matricula1
        btnnot.BackgroundImage = My.Resources.Notas2
        btnalu.BackgroundImage = My.Resources.Alumno1
    End Sub

    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        btnalumno.BackColor = Color.CadetBlue
    End Sub

    Private Sub btnapod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnapod.Click
        Dim ra As New Opcion_Apoderado
        ra.ShowDialog()
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.Text = Mid(Me.Text, 2) + Microsoft.VisualBasic.Left(Me.Text, 1)

    End Sub

    Private Sub btnmat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmat.Click
        Dim mt As New Opcion_Matricula
        mt.ShowDialog()

    End Sub

    Private Sub btnnot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnot.Click
        Dim nt As New Opcion_Notas
        nt.ShowDialog()

    End Sub

    Private Sub ButtonX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX.Click
        Dim confirma = MsgBox("Está seguro que Desea Salir?", vbYesNo + vbExclamation, "Atención!!")
        If confirma = vbYes Then
            Me.Close()
            Login.Close()
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.WindowState = 1
    End Sub

    Private Sub MenuPrincipal_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        cargarimages()
        cargarbuttons()

    End Sub


    Private Sub btnalu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalu.Click
        Dim ra As New RegAl
        ra.ShowDialog()

    End Sub

    Private Sub btndoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndoc.Click
        Dim dc As New Opcion_Docente
        dc.showdialog()


    End Sub

    Private Sub btnau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnau.Click
        Dim au As New Aula
        au.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalumno.Click
        Dim ra As New RegAl
        ra.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnapoderado.Click
        Dim ra As New Opcion_Apoderado
        ra.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaulas.Click
        Dim au As New Aula
        au.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim nt As New Opcion_Notas
        nt.ShowDialog()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmatricula.Click
        Dim mt As New Opcion_Matricula
        mt.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndocente.Click
        Dim dc As New Opcion_Docente
        dc.ShowDialog()

    End Sub

    Private Sub Button1_MouseMove_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnalumno.MouseMove
        btnalumno.BackColor = Color.SkyBlue
        btnapoderado.BackColor = Color.LightBlue
        btnaulas.BackColor = Color.LightBlue
        Button4.BackColor = Color.LightBlue
        btnmatricula.BackColor = Color.LightBlue
        btndocente.BackColor = Color.LightBlue
    End Sub

    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnapoderado.MouseMove
        btnapoderado.BackColor = Color.SkyBlue
        btnalumno.BackColor = Color.LightBlue
        btnaulas.BackColor = Color.LightBlue
        Button4.BackColor = Color.LightBlue
        btnmatricula.BackColor = Color.LightBlue
        btndocente.BackColor = Color.LightBlue
    End Sub

    Private Sub Button3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnaulas.MouseMove
        btnaulas.BackColor = Color.SkyBlue
        btnapoderado.BackColor = Color.LightBlue
        btnalumno.BackColor = Color.LightBlue
        Button4.BackColor = Color.LightBlue
        btnmatricula.BackColor = Color.LightBlue
        btndocente.BackColor = Color.LightBlue
    End Sub

    Private Sub Button4_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button4.MouseMove
        Button4.BackColor = Color.SkyBlue
        btnaulas.BackColor = Color.LightBlue
        btnalumno.BackColor = Color.LightBlue
        btnapoderado.BackColor = Color.LightBlue
        btnmatricula.BackColor = Color.LightBlue
        btndocente.BackColor = Color.LightBlue
    End Sub

    Private Sub Button5_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnmatricula.MouseMove
        btnmatricula.BackColor = Color.SkyBlue
        Button4.BackColor = Color.LightBlue
        btnaulas.BackColor = Color.LightBlue
        btnalumno.BackColor = Color.LightBlue
        btnapoderado.BackColor = Color.LightBlue
        btndocente.BackColor = Color.LightBlue
    End Sub

    Private Sub Button6_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btndocente.MouseMove
        btndocente.BackColor = Color.SkyBlue
        btnmatricula.BackColor = Color.LightBlue
        btnaulas.BackColor = Color.LightBlue
        btnalumno.BackColor = Color.LightBlue
        btnapoderado.BackColor = Color.LightBlue
        Button4.BackColor = Color.LightBlue
    End Sub

    Private Sub cargarimages()
        PictureBox1.Image = My.Resources.Insignia_NIXA
        btnmat.BackgroundImage = My.Resources.Matricula2
        btnapod.BackgroundImage = My.Resources.Padre2
        btnnot.BackgroundImage = My.Resources.Notas2
        btnalu.BackgroundImage = My.Resources.Alumno1
        btndoc.BackgroundImage = My.Resources.Docente2
        btnau.BackgroundImage = My.Resources.Aula2
    End Sub

    Private Sub cargarbuttons()
        btnalumno.BackColor = Color.LightBlue
        btnapoderado.BackColor = Color.LightBlue
        btnaulas.BackColor = Color.LightBlue
        Button4.BackColor = Color.LightBlue
        btnmatricula.BackColor = Color.LightBlue
        btndocente.BackColor = Color.LightBlue
    End Sub

    
    Private Sub MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarbuttons()
        cargarimages()
        definirprivilegios()
        centrarmenu()
    End Sub

    Private Sub centrarmenu()
        Dim AnchoForm As Integer = Me.Size.Width()
        Dim AltoForm As Integer = Me.Size.Height()
        'Me.Size.Hei

        Dim posx As Double = (((AnchoForm - GroupBox1.Size.Width) / 2) - (pToolsBox.Size.Width / 2)) + GroupBox1.Width
        Dim posy As Double = (AltoForm / 2)
        ' MsgBox(AltoForm & " O" & posy)
        pToolsBox.Location = New Point(posx, 200)
        PictureBox2.Location = New Point((Me.Width / 2) - (PictureBox2.Width / 2), PictureBox2.Location.Y)
    End Sub



    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'cada segundo debemos de mostrar la hora
        lblhora.Text = Now.ToLongTimeString() 'Hora en formato largo
        lblfecha.Text = Now.ToShortDateString() 'fecha en formato corto
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim a As New RegAño
        a.ShowDialog()
    End Sub

    Private Sub definirprivilegios()
        'If usuario = "Alex" Or usuario = "Christopher" Or usuario = "Juan" Then
        '    btnalu.Enabled = False
        '    btnapod.Enabled = False
        '    btnau.Enabled = False
        '    btndoc.Enabled = False
        'End If
        PictureBox1.Visible = True
        If usuario = "UsuarioA" Or usuario = "USUARIOA" Or usuario = "usuarioa" Or usuario = "UsuarioB" Or usuario = "USUARIOB" Or usuario = "usuariob" Or usuario = "UsuarioC" Or usuario = "USUARIOC" Or usuario = "usuarioc" Then
            btnalu.Enabled = False
            btnalumno.Enabled = False
            btnapod.Enabled = False
            btnapoderado.Enabled = False
            btnmat.Enabled = False
            btnmatricula.Enabled = False
            btnau.Enabled = False
            btnaulas.Enabled = False
            btndoc.Enabled = False
            btndocente.Enabled = False
            ptbinsignia.Visible = True
            PictureBox1.Visible = False
            PictureBox1.Image = My.Resources.Insignia_NIXA
            ' ptbinsignia.Image = My.Resources.Insignia_NIXA
        Else
            If usuario = "secretaria" Or usuario = "Secretaria" Or usuario = "SECRETARIA" Then
                ptbinsignia.Enabled = False
                ptbinsignia.Visible = True
                PictureBox1.Visible = False
                PictureBox1.Image = My.Resources.Insignia_NIXA
            End If
        End If

    End Sub

   
End Class