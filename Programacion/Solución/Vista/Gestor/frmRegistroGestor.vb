Imports Logica
Public Class frmRegistroGestor

    Dim pass As String
    Dim aliTel As New ArrayList
    Dim check As New Verificacion
    Dim seg As New Encriptar
    Dim path As String

    Public Sub New()

        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTelefonos, scroll, True)
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

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrarGestor.Click

        If Principal.Singleton.VerificarCedula(check, txtCI.Text) Then
            If Principal.Singleton.VerificarContraseña(seg, txtCon.Text, txtRepCon.Text) Then
                pass = seg.HASH256(txtCon.Text)
                If Principal.Singleton.VerificarString(check, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApe.Text) Then
                    If Principal.Singleton.VerificarEmail(check, txtMail.Text) Then
                        If Principal.Singleton.VerificarTelefonos(dgvTelefonos, aliTel) Then

                            Dim ges As New ControladorGestor(txtCI.Text,
                                                 pass,
                                                 txtPNom.Text.ToUpper,
                                                 txtSNom.Text.ToUpper,
                                                 txtPApe.Text.ToUpper,
                                                 txtSApe.Text.ToUpper,
                                                 aliTel,
                                                 txtMail.Text, Principal.Singleton.Base64(path))

                            If ges.VerificarBaja(txtCI.Text) Then

                                If ges.Registrar Then
                                    MsgBox(Principal.Singleton.Idioma("msgboRegistrarGestor", "Gestor registrado con éxito"))

                                    Principal.Singleton.limpiar(txtCI, txtCon, txtRepCon, txtPApe, txtPNom, txtSApe, txtSNom, txtMail, dgvTelefonos, aliTel)

                                Else
                                    MsgBox(Principal.Singleton.Idioma("msgboxErrorGestor", "El usuario ya fue registrado"))
                                End If

                            Else
                                Dim respuesta As Integer = MsgBox(Principal.Singleton.Idioma("msgboxEstaDadoDeBaja", "Usted se encuentra dado de baja. ¿Desea reingresar al sistema?"), vbQuestion + vbYesNo + vbDefaultButton2)

                                If respuesta = vbYes Then
                                    ges.ReingresarUsuario(txtCI.Text)
                                    MsgBox(Principal.Singleton.Idioma("msgboRegistrarGestor", "Gestor registrado con éxito"))
                                    Principal.Singleton.limpiar(txtCI, txtCon, txtRepCon, txtPApe, txtPNom, txtSApe, txtSNom, txtMail, dgvTelefonos, aliTel)
                                End If
                            End If
                        Else

                            MsgBox(Principal.Singleton.Idioma("msgboxTelefonoError", "Ha ingresado un teléfono incorrecto"))

                        End If
                    End If
                End If
            End If

        Else
            MsgBox(Principal.Singleton.Idioma("msgboxCedulaError", "La cédula ingresada no es correcta"))

        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarGestor.Click

        dgvTelefonos.Rows.Add()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvTelefonos.Rows.Count > 0 Then
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.CurrentRow.Index)
        ElseIf dgvTelefonos.Rows.Count < 0 Then
            btnEliminar.Enabled = False
        End If

    End Sub

    Private Sub dgvTelefonos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvTelefonos.RowsAdded

        btnEliminar.Enabled = True

    End Sub

    Private Sub btnAtras_Click_1(sender As Object, e As EventArgs) Handles btnAtras.Click
        Principal.Singleton.CambiarTamaño(frmOpciones)
        Me.Dispose()
    End Sub

    Private Sub btnImg_Click(sender As Object, e As EventArgs) Handles btnImg.Click
        Dim dial As New OpenFileDialog

        dial.Title = Principal.Singleton.Idioma("txtTitleRegGestor", "Seleccione una fotografía")
        dial.Filter = "Image Files (*.jpg;*.jpeg;*bmp;*.png;)|*.jpg;*.jpeg;*bmp;*.png;"


        If dial.ShowDialog = DialogResult.OK Then
            path = dial.FileName
            GunaPictureBox1.Image = Image.FromFile(path)
        End If

    End Sub

    Private Sub dgvTelefonos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvTelefonos.RowsRemoved
        If dgvTelefonos.Rows.Count < 0 Then
            btnEliminar.Enabled = False
        End If

    End Sub
End Class