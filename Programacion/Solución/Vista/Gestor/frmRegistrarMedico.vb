Imports Logica
Public Class frmRegistrarMedico

    Dim check As New Verificacion
    Dim path As String

    Public Sub New()

        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        For Each var As Control In Me.Controls

            If TypeOf var Is Panel Then

                For Each ctrl As Control In var.Controls

                    ctrl.Text = Principal.Singleton.Idioma(ctrl.Name, ctrl.Text)

                    If TypeOf ctrl Is Panel Then

                        For Each ctrl2 As Control In ctrl.Controls
                            ctrl2.Text = Principal.Singleton.Idioma(ctrl2.Name, ctrl2.Text)

                            If TypeOf ctrl2 Is Panel Then

                                For Each ctrl3 As Control In ctrl2.Controls
                                    ctrl3.Text = Principal.Singleton.Idioma(ctrl3.Name, ctrl3.Text)
                                    If TypeOf ctrl3 Is Panel Then
                                        For Each ctrl4 As Control In ctrl3.Controls
                                            ctrl4.Text = Principal.Singleton.Idioma(ctrl4.Name, ctrl4.Text)

                                            If TypeOf ctrl4 Is Panel Then
                                                For Each ctrl5 As Control In ctrl4.Controls
                                                    ctrl5.Text = Principal.Singleton.Idioma(ctrl5.Name, ctrl5.Text)

                                                Next

                                            End If
                                        Next

                                    End If
                                Next
                            End If
                        Next

                    End If
                Next


            End If

            var.Text = Principal.Singleton.Idioma(var.Name, var.Text)
        Next

    End Sub

    Private Sub btnRegistrarMedico_Click(sender As Object, e As EventArgs) Handles btnRegistrarMedico.Click
        If txtCed.Text <> "" And txtPrimerNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" And txtEspec.Text <> "" And txtMail.Text <> "" Then

            If Principal.Singleton.VerificarCedula(check, txtCed.Text) Then
                If Principal.Singleton.VerificarString(check, txtPrimerNombre.Text, txtPrimerApellido.Text, txtSegundoNombre.Text, txtSegundoApellido.Text) Then
                    If check.Verificar_String(txtEspec.Text) Then
                        If check.VerificarEmail(txtMail.Text) Then

                            Dim med As New ControladorMedico(
                                txtCed.Text,
                                Encriptar.Singleton.HASH256(txtCed.Text),
                                txtPrimerNombre.Text.ToUpper,
                                txtSegundoNombre.Text.ToUpper,
                                txtPrimerApellido.Text.ToUpper,
                                txtSegundoApellido.Text.ToUpper,
                                txtEspec.Text.ToUpper,
                                txtMail.Text(), Principal.Singleton.Base64(path))

                            If med.VerificarBaja(txtCed.Text) Then

                                If med.RegistarUsuario() Then
                                    If med.RegistrarMedico Then
                                        MsgBox(Principal.Singleton.Idioma("msgRegistroMedicoExistoso", "Médico registrado con éxito"))
                                        limpiar()
                                    Else
                                        MsgBox(Principal.Singleton.Idioma("msgMedicoRegistrado", "El médico ya fue registrado"))
                                    End If
                                Else
                                    MsgBox(Principal.Singleton.Idioma("msgUsuarioRegistradoMed", "El usuario ya fue registrado"))
                                End If

                            Else
                                Dim respuesta As Integer = MsgBox(Principal.Singleton.Idioma("msgMedicoDadodeBaja", "El médico se ecuentra dado de baja. ¿Desea reingresar al sistema?"), vbQuestion + vbYesNo + vbDefaultButton2)

                                If respuesta = vbYes Then
                                    med.ReingresarUsuario(txtCed.Text)
                                    limpiar()
                                End If

                            End If

                        Else
                            MsgBox(Principal.Singleton.Idioma("msgCorreoIncorrectoMed", "El correo ingresado no es correcto"))
                        End If

                    End If
                End If
            Else
                MsgBox(Principal.Singleton.Idioma("msgCedulaIncorrectaMed", "La cédula ingresada no es correcta"))
            End If
        Else
            MsgBox(Principal.Singleton.Idioma("msgRellenarCamposMed", "Debe rellenar los campos"))
        End If
    End Sub
    Private Sub limpiar()
        txtCed.Text = Nothing
        txtPrimerNombre.Text = Nothing
        txtSegundoApellido.Text = Nothing
        txtSegundoNombre.Text = Nothing
        txtPrimerNombre.Text = Nothing
        txtPrimerApellido.Text = Nothing
        txtEspec.Text = Nothing
        txtMail.Text = Nothing
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Not (txtCed.Text = Nothing And txtEspec.Text = Nothing And txtPrimerApellido.Text = Nothing And txtPrimerNombre.Text = Nothing And txtSegundoApellido.Text = Nothing And txtSegundoNombre.Text = Nothing) Then
            Dim res = MsgBox(Principal.Singleton.Idioma("msgInformacionSinGuardar", "Hay información sin guardar, ¿Seguro desea salir?"), vbYesNo)
            If res = vbYes Then
                Principal.Singleton.CambiarTamaño(frmOpciones)
                Me.Dispose()
            End If
        Else
            Principal.Singleton.CambiarTamaño(frmOpciones)
            Me.Dispose()
        End If
    End Sub

    Private Sub btnImg_Click(sender As Object, e As EventArgs) Handles btnImg.Click
        Dim dial As New OpenFileDialog

        dial.Title = "Seleccione una fotografía"
        dial.Filter = "Image Files (*.jpg;*.jpeg;*bmp;*.png;)|*.jpg;*.jpeg;*bmp;*.png;"


        If dial.ShowDialog = DialogResult.OK Then
            path = dial.FileName
            GunaPictureBox1.Image = Image.FromFile(path)
        End If

    End Sub
End Class