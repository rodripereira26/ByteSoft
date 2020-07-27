Imports Logica
Public Class frmRegistrarMedico

    Dim p As New Principal
    Dim check As New Verificacion

    Private Sub RegistrarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        p.roundedCorners(Me)
        Label1.Select()

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        If p.verificarCedula(check, txtCed.Text) Then
            If p.verificarString(check, txtPrimerNombre.Text, txtPrimerApellido.Text, txtSegundoNombre.Text, txtSegundoApellido.Text) Then
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

End Class