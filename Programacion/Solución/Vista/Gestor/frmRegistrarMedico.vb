Imports Logica
Public Class frmRegistrarMedico

    Dim check As New Verificacion

    Private Sub RegistrarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Principal.Singleton.RoundedCorners(Me)
        lblCed.Select()

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles btnRegistrarMedico.Click

        If Principal.Singleton.VerificarCedula(check, txtCed.Text) Then
            If Principal.Singleton.VerificarString(check, txtPrimerNombre.Text, txtPrimerApellido.Text, txtSegundoNombre.Text, txtSegundoApellido.Text) Then
                If check.Verificar_String(txtEspec.Text) Then

                    Dim med As New ControladorMedico(
                            txtCed.Text,
                            txtCed.Text,
                            txtPrimerNombre.Text,
                            txtSegundoNombre.Text,
                            txtPrimerApellido.Text,
                            txtSegundoApellido.Text,
                            txtEspec.Text)

                    If med.registrar() Then
                        MsgBox("Médico registrado con éxito")
                    Else
                        MsgBox("El médico ya fue registrado")
                    End If

                End If
            End If
        Else
            MsgBox("La cédula ingresada no es correcta")
        End If

    End Sub

    Private Sub pnlTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseDown
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub pnlTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseMove
        Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub pnlTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseUp
        Principal.Singleton.moverVentanaUp()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Not (txtCed.Text = Nothing And txtEspec.Text = Nothing And txtPrimerApellido.Text = Nothing And txtPrimerNombre.Text = Nothing And txtSegundoApellido.Text = Nothing And txtSegundoNombre.Text = Nothing) Then
            Dim res = MsgBox("Hay información sin guardar, ¿seguro desea salir?", vbYesNo)
            If res = vbYes Then
                frmModular.Show()
                Me.Close()
            End If
        Else
            frmModular.Show()
            Me.Close()
        End If
    End Sub

End Class