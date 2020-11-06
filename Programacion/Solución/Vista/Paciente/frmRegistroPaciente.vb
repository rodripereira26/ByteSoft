Imports Logica

Public Class frmRegistroPaciente

    Dim aliTel As New ArrayList
    Public aliPatologias As New ArrayList
    Dim check As New Verificacion
    Dim seg As New Encriptar
    Dim pass As String
    Dim sexo As String
    Dim path As String

    Public Sub New()

        InitializeComponent()

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
        Configuracion.Singleton.SetConnection()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTelefonos, scroll, True)

    End Sub

    Private Sub btnSoli_Click(sender As Object, e As EventArgs) Handles btnSoliCuentaPac.Click

        If txtCI.Text <> "" And txtPass.Text <> "" And txtRepPass.Text <> "" And txtPNom.Text <> "" And txtPApe.Text <> "" And txtSApe.Text <> "" And txtMail.Text <> "" Then
            If Principal.Singleton.VerificarCedula(check, txtCI.Text) Then
                If Principal.Singleton.VerificarContraseña(seg, txtPass.Text, txtRepPass.Text) Then
                    pass = seg.HASH256(txtPass.Text)
                    If Principal.Singleton.VerificarString(check, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApe.Text) Then
                        If Principal.Singleton.VerificarEmail(check, txtMail.Text) Then
                            If Principal.Singleton.VerificarTelefonos(dgvTelefonos, aliTel) Then

                                If txtFecNac.MaskCompleted Then

                                    If cbM.Checked Or cbF.Checked Then


                                        If cbM.Checked Then
                                            sexo = "M"
                                        Else
                                            sexo = "F"
                                        End If

                                        Dim pac As New ControladorPaciente(txtCI.Text,
                                                           pass,
                                                           txtPNom.Text.ToUpper,
                                                           txtSNom.Text.ToUpper,
                                                           txtPApe.Text.ToUpper,
                                                           txtSApe.Text.ToUpper,
                                                           aliTel,
                                                           txtMail.Text,
                                                           sexo,
                                                           txtFecNac.Text, Principal.Singleton.Base64(path)
                                                           )

                                        If pac.VerificarBaja(txtCI.Text) Then

                                            If pac.RegistarUsuario Then
                                                If pac.RegistrarPaciente() Then
                                                    If pac.RegistrarTelefonos Then
                                                        If pac.IngresarPatologias(aliPatologias) Then
                                                            MsgBox(principal.singleton.idioma("msgRegistroHechoEsperarHabilitacion","Su registro ha sido solicitado con éxito, debe esperar a ser habilitiado"))
                                                            Principal.Singleton.limpiar(txtCI, txtPass, txtRepPass, txtPNom,
                                                            txtPApe,
                                                                    txtSApe, txtSNom,
                                                                   txtMail, dgvTelefonos, aliTel)
                                                            txtFecNac.Clear()
                                                            cbM.Checked = False
                                                            cbF.Checked = False
                                                            aliTel.Clear()
                                                            path = Nothing
                                                            GunaPictureBox1.Image = Nothing
                                                            aliPatologias.Clear()
                                                        Else
                                                            MsgBox(principal.singleton.idioma("msgErrorRegistroPatologiaPaciente","Error al registrar las patologías"))
                                                            aliPatologias.Clear()
                                                            aliTel.Clear()
                                                        End If

                                                    Else
                                                        MsgBox(principal.singleton.idioma("msgErrorRegistroTelPaciente","Error al registrar los teléfonos"))
                                                        aliTel.Clear()
                                                    End If
                                                Else
                                                    MsgBox(principal.singleton.idioma("msgPacienteYaRegistrado"," "))
                                                    aliTel.Clear()
                                                End If
                                            Else
                                                MsgBox(principal.singleton.idioma("msgUsuarioYaingresadopaciente","El usuario ya fue ingresado"))
                                                aliTel.Clear()
                                            End If

                                        Else
                                            Dim respuesta As Integer = MsgBox(Principal.Singleton.Idioma("msgPacienteDadoDeBaja", "Usted se encuentra dado de baja. ¿Desea solicitar reingresar al sistema? (Se mantendrá su información anterior)"), vbQuestion + vbYesNo + vbDefaultButton2)

                                            If respuesta = vbYes Then
                                                pac.ReingresarUsuario(txtCI.Text)
                                                MsgBox(Principal.Singleton.Idioma("msgRegistroSOlicitadoESPERAR", "Su registro ha sido solicitado con éxito, debe esperar a ser habilitiado"))
                                                Principal.Singleton.limpiar(txtCI, txtPass, txtRepPass, txtPNom,
                                                                txtPApe,
                                                                txtSApe, txtSNom,
                                                                txtMail, dgvTelefonos, aliTel)
                                                txtFecNac.Clear()
                                                cbM.Checked = False
                                                cbF.Checked = False
                                                GunaPictureBox1.Image = Nothing
                                                path = Nothing
                                            End If

                                        End If

                                    Else
                                        MsgBox(Principal.Singleton.Idioma("msgIngresarSexoPaciente", "Debe ingresar un sexo"))
                                    End If
                                Else
                                    MsgBox(Principal.Singleton.Idioma("msgIngresarFechaNacimiento", "Debe ingresar su fecha de nacimiento"))
                                End If

                            Else
                                MsgBox(Principal.Singleton.Idioma("msgTelefonoIncorrectoPaciente", "Ha ingresado un teléfono incorrecto"))

                            End If
                        Else
                            MsgBox(Principal.Singleton.Idioma("msgIngresoEmailIncorrectoPaciente", "Debe ingresar un e-mail correcto"))
                        End If

                    End If
                Else
                    MsgBox(Principal.Singleton.Idioma("msgContrasenanocoincidepaciente", "Las contraseñas no coinciden"))
                End If
            Else
                MsgBox(Principal.Singleton.Idioma("msgCedulaIncorrectapacc", "La cédula ingresada no es correcta"))
            End If
        Else
            MsgBox(Principal.Singleton.Idioma("msgRellenarCamposPacc", "Debe rellenar los campos"))
        End If

    End Sub

    Private Sub txtFecNac_GotFocus(sender As Object, e As EventArgs) Handles txtFecNac.GotFocus
        sepFecNac.LineColor = Color.FromArgb(100, 88, 255)
        txtFecNac.Select(0, 0)
    End Sub

    Private Sub txtFecNac_Lost(sender As Object, e As EventArgs) Handles txtFecNac.LostFocus
        sepFecNac.LineColor = Color.Silver
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarRegPac.Click

        If dgvTelefonos.Rows.Count = 0 Then
            dgvTelefonos.Rows.Add()

        ElseIf dgvTelefonos.Rows.Count > 0 Then

            If dgvTelefonos.Rows(dgvTelefonos.Rows.Count - 1).Cells(0).Value <> "" Or dgvTelefonos.Rows.Count = 0 Then
                dgvTelefonos.Rows.Add()
            End If

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminarRegPac.Click

        If dgvTelefonos.Rows.Count > 0 Then
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.CurrentRow.Index)
        End If

    End Sub

    Private Sub dgvTelefonos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvTelefonos.RowsAdded

        btnEliminarRegPac.Enabled = True
        If dgvTelefonos.Rows.Count = 10 Then
            btnAceptarRegPac.Enabled = False
        End If

    End Sub

    Private Sub dgvTelefonos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvTelefonos.RowsRemoved

        btnAceptarRegPac.Enabled = True

        If dgvTelefonos.Rows.Count = 0 Then
            btnEliminarRegPac.Enabled = False
        End If

    End Sub

    Private Sub btnAtras_Click_1(sender As Object, e As EventArgs) Handles btnAtras.Click
        Principal.Singleton.CambiarTamaño(frmLogin)
        Me.Dispose()
    End Sub

    Private Sub btnPatCron_Click(sender As Object, e As EventArgs) Handles btnPatCron.Click

        Dim frm As New frmIngresarSintomas(ControladorPatologia.Singleton.getTodasPatologias, 2)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()

    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub

End Class