Imports Logica
Public Class frmRegistrarMedico

    Dim check As New Verificacion

    Private Sub RegistrarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Principal.Singleton.roundedCorners(Me)
        Label1.Select()

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        If Principal.Singleton.verificarCedula(check, txtCed.Text) Then
            If Principal.Singleton.verificarString(check, txtPrimerNombre.Text, txtPrimerApellido.Text, txtSegundoNombre.Text, txtSegundoApellido.Text) Then
                If check.verificar_string(txtEspe.Text) Then

                    Dim med As New ControladorMedico(
                            txtCed.Text,
                            txtCed.Text,
                            txtPrimerNombre.Text,
                            txtSegundoNombre.Text,
                            txtPrimerApellido.Text,
                            txtSegundoApellido.Text,
                            txtEspe.Text)

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

End Class