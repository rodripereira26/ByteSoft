Public Class frmModular
    Dim p As New Principal
    Public op As Byte = 2

    Private Sub frmPatologiasySintomas_Load(sender As Object, e As EventArgs) Handles Me.Load
        p.roundedCorners(Me)

        Select Case op
            Case 0
                lblTitulo.Text = "MENU PATOLOGÍAS"
                lblListadoDe.Text = "Listado de patologías"
                lblSubtituloIngresar.Text = "Registre patologías manualmente o desde un archivo CSV"
                lblSubtituloListadoDe.Text = "Acceda a todas las patologías registradas y a opciones de eliminar y modificar"
            Case 1
                lblTitulo.Text = "MENU SÍNTOMAS"
                lblListadoDe.Text = "Listado de síntomas"
                lblSubtituloIngresar.Text = "Registre síntomas manualmente o desde un archivo CSV"
                lblSubtituloListadoDe.Text = "Acceda a todos los síntomas registrados y a opciones de eliminar y modificar"
            Case 2
                lblTitulo.Text = "MENU USUARIOS"
                lblListadoDe.Text = "Habilitar pacientes"
                lblSubtituloIngresar.Text = "Registre médicos manualmente o desde un archivo CSV"
                lblSubtituloListadoDe.Text = "Acceda a las peticiones de pacientes para registrarse en la aplicación"
        End Select

    End Sub

    Private Sub pnlIngresar_MouseEnter(sender As Object, e As EventArgs) Handles pnlOpcion1.MouseEnter, lblIngresar.MouseEnter, lblSubtituloIngresar.MouseEnter
        p.hover(pnlOpcion1)
    End Sub

    Private Sub pnlIngresar_MouseLeave(sender As Object, e As EventArgs) Handles pnlOpcion1.MouseLeave, lblIngresar.MouseLeave, lblSubtituloIngresar.MouseLeave
        p.leave(pnlOpcion1)
    End Sub

    Private Sub pnlListado_MouseEnter(sender As Object, e As EventArgs) Handles pnlOpcion2.MouseEnter, lblListadoDe.MouseEnter, lblSubtituloListadoDe.MouseEnter
        p.hover(pnlOpcion2)
    End Sub

    Private Sub pnlListado_MouseLeave(sender As Object, e As EventArgs) Handles pnlOpcion2.MouseLeave, lblSubtituloListadoDe.MouseLeave, lblListadoDe.MouseLeave
        p.leave(pnlOpcion2)
    End Sub

    Private Sub pnlTopBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseDown
        p.moverVentanaDown(Me)
    End Sub

    Private Sub pnlTopBar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseMove
        p.moverVentanaMove(Me)
    End Sub

    Private Sub pnlTopBar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseUp
        p.moverVentanaUp()
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
            Case 1
                frmListado.op = "síntomas"
                frmListado.Visible = True
                Me.Visible = False
            Case 0
                frmListado.op = "patologías"
                frmListado.Visible = True
                Me.Visible = False
            Case 2
                frmHabilitar.Visible = True
                Me.Visible = False
        End Select
    End Sub
End Class
