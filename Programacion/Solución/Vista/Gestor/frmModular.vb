Public Class frmModular

    Public op As Byte

    Private Sub frmPatologiasySintomas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Principal.Singleton.roundedCorners(Me)

        Select Case op
            Case 0
                lblTitulo.Text = "MENU PATOLOGÍAS"
                lblTitulo2.Text = "Listado de patologías"
                lblSubtitulo1.Text = "Registre patologías manualmente o desde un archivo CSV"
                lblSubtitulo2.Text = "Acceda a todas las patologías registradas y a opciones de eliminar y modificar"
            Case 1
                lblTitulo.Text = "MENU SÍNTOMAS"
                lblTitulo2.Text = "Listado de síntomas"
                lblSubtitulo1.Text = "Registre síntomas manualmente o desde un archivo CSV"
                lblSubtitulo2.Text = "Acceda a todos los síntomas registrados y a opciones de eliminar y modificar"
            Case 2
                lblTitulo.Text = "MENU USUARIOS"
                lblTitulo1.Text = "Registrar médico"
                lblTitulo2.Text = "Registrar gestor"
                lblSubtitulo1.Text = "Registre médicos manualmente o desde un archivo CSV"
                lblSubtitulo2.Text = "Registre gestores manualmente o desde un archivo CSV"
        End Select

    End Sub

    Private Sub pnlIngresar_MouseEnter(sender As Object, e As EventArgs) Handles pnlOpcion1.MouseEnter, lblTitulo1.MouseEnter, lblSubtitulo1.MouseEnter
        Principal.Singleton.hover(pnlOpcion1)
    End Sub

    Private Sub pnlIngresar_MouseLeave(sender As Object, e As EventArgs) Handles pnlOpcion1.MouseLeave, lblTitulo1.MouseLeave, lblSubtitulo1.MouseLeave
        Principal.Singleton.leave(pnlOpcion1)
    End Sub

    Private Sub pnlListado_MouseEnter(sender As Object, e As EventArgs) Handles pnlOpcion2.MouseEnter, lblTitulo2.MouseEnter, lblSubtitulo2.MouseEnter
        Principal.Singleton.hover(pnlOpcion2)
    End Sub

    Private Sub pnlListado_MouseLeave(sender As Object, e As EventArgs) Handles pnlOpcion2.MouseLeave, lblSubtitulo2.MouseLeave, lblTitulo2.MouseLeave
        Principal.Singleton.leave(pnlOpcion2)
    End Sub

    Private Sub pnlTopBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseDown
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub pnlTopBar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseMove
        Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub pnlTopBar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseUp
        Principal.Singleton.moverVentanaUp()
    End Sub

    Private Sub pnlOpcion1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlOpcion1.MouseDown

        If op = 0 Then
            frmRegistrarPatologia.Visible = True
            Me.Visible = False
        ElseIf op = 1 Then
            frmRegistrarSintoma.Visible = True
            Me.Visible = False
        Else
            frmRegistrarMedico.Visible = True
            Me.Visible = False
        End If

    End Sub

    Private Sub pnlOpcion2_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlOpcion2.MouseDown

        Select Case op
            Case 2
                frmRegistroGestor.Show()
                Me.Hide()
            Case 1
                frmListadoPatologiasySintomas.op = "síntomas"
                frmListadoPatologiasySintomas.Visible = True
                Me.Visible = False
            Case 0
                frmListadoPatologiasySintomas.op = "patologías"
                frmListadoPatologiasySintomas.Visible = True
                Me.Visible = False

        End Select

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        frmBienvenidaGestor.Show()
        Me.Close()
    End Sub
End Class
