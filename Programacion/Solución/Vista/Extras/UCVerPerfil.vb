Imports Logica
Public Class UCVerPerfil
    Private pac As New ControladorPaciente
    Private ges As New ControladorGestor
    Private med As New ControladorMedico
    Private usu As New ControladorUsuario
    Private _pNom, _sNom, _pApe, _sApe, _email As String
    Private path As String
    Private _especializacion As String
    Private _fecNac, _edad, _sexo As String
    Private cambiados As Boolean = False
    Dim aliPatologias As New ArrayList
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Select Case Datos_Temporales.rol

            Case Datos_Temporales.enumRol.Paciente
                Dim aliPatologias As New ArrayList
                Dim alitel As New ArrayList
                If txtPNom.Text <> "" And txtPApe.Text <> "" And txtSApePerfil.Text <> "" And txtMail.Text <> "" Then 'txtPass.Text <> "" And txtRepPass.Text <> "" And

                    If Principal.Singleton.VerificarString(Verificacion.Singleton, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApePerfil.Text) Then
                        If Principal.Singleton.VerificarEmail(Verificacion.Singleton, txtMail.Text) Then

                            If Principal.Singleton.VerificarTelefonos(dgvTelefonos, alitel) Then
                                Dim pac As New ControladorPaciente(Datos_Temporales.userLog,
                                                           txtPNom.Text.ToUpper,
                                                           txtSNom.Text.ToUpper,
                                                           txtPApe.Text.ToUpper,
                                                           txtSApePerfil.Text.ToUpper,
                                                           alitel,
                                                           txtMail.Text,
                                                           _sexo,
                                                           _fecNac,
                                                           Principal.Singleton.Base64(path)
                                                           )

                                If pac.updateUsuario() Then
                                    If pac.updatePaciente(Datos_Temporales.userLog) Then

                                        If pac.updateTelefonos(alitel) Then

                                            MsgBox(Principal.Singleton.Idioma("msgboxUpdate", "Su perfil ha sido modificado con exito"))
                                            setVariablesUsuario()
                                            setTelefonosUsuario()
                                            setVariablesPaciente()
                                            alitel.Clear()
                                        Else
                                            MsgBox(Principal.Singleton.Idioma("msgErrorUpdateTel", "Error al modificar los teléfonos"))
                                            alitel.Clear()
                                        End If

                                    End If
                                Else
                                    MsgBox(Principal.Singleton.Idioma("msgboxErrorUpdatePac", "Error al modificar el perfil"))
                                    alitel.Clear()
                                End If

                            Else
                                MsgBox(Principal.Singleton.Idioma("msgboxErrorTel", "Ha ingresado un teléfono incorrecto"))

                            End If
                        Else
                            MsgBox(Principal.Singleton.Idioma("msgboxErrorMail", "Debe ingresar un e-mail correcto"))
                        End If
                    End If

                Else
                    MsgBox(Principal.Singleton.Idioma("msgboxErrorCamposPerfil", "Debe rellenar los campos"))
                End If


            Case Datos_Temporales.enumRol.Gestor

                Dim alitel As New ArrayList
                If txtPNom.Text <> "" And txtPApe.Text <> "" And txtSApePerfil.Text <> "" And txtMail.Text <> "" Then 'txtPass.Text <> "" And txtRepPass.Text <> "" And

                    If Principal.Singleton.VerificarString(Verificacion.Singleton, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApePerfil.Text) Then
                        If Principal.Singleton.VerificarEmail(Verificacion.Singleton, txtMail.Text) Then
                            If Principal.Singleton.VerificarTelefonos(dgvTelefonos, alitel) Then
                                Dim ges As New ControladorGestor(Datos_Temporales.userLog,
                                                           txtPNom.Text.ToUpper,
                                                           txtSNom.Text.ToUpper,
                                                           txtPApe.Text.ToUpper,
                                                           txtSApePerfil.Text.ToUpper,
                                                           alitel,
                                                           txtMail.Text,
                                                           Principal.Singleton.Base64(path)
                                                           )

                                If ges.updateUsuario() Then

                                    If ges.updateTelefonos(alitel) Then

                                        MsgBox(Principal.Singleton.Idioma("msgboxUpdate", "Su perfil ha sido modificado con exito"))
                                        setVariablesUsuario()
                                        setTelefonosUsuario()
                                    Else
                                        MsgBox(Principal.Singleton.Idioma("msgErrorUpdateTel", "Error al modificar los teléfonos"))
                                        alitel.Clear()
                                    End If
                                Else
                                    MsgBox(Principal.Singleton.Idioma("msgboxErrorUpdatePac", "Error al modificar el perfil"))
                                    alitel.Clear()
                                End If

                            Else
                                MsgBox(Principal.Singleton.Idioma("msgboxErrorTel", "Ha ingresado un teléfono incorrecto"))

                            End If
                        Else
                            MsgBox(Principal.Singleton.Idioma("msgboxErrorMail", "Debe ingresar un e-mail correcto"))
                        End If
                    End If

                Else
                    MsgBox(Principal.Singleton.Idioma("msgboxErrorCamposPerfil", "Debe rellenar los campos"))
                End If

            Case Datos_Temporales.enumRol.Medico

                If txtPNom.Text <> "" And txtPApe.Text <> "" And txtSApePerfil.Text <> "" And txtMail.Text <> "" Then


                    If Principal.Singleton.VerificarString(Verificacion.Singleton, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApePerfil.Text) Then

                        If Verificacion.Singleton.VerificarEmail(txtMail.Text) Then

                            Dim med As New ControladorMedico(
                                    Datos_Temporales.userLog,
                                    "", txtPNom.Text.ToUpper(),
                                    txtSNom.Text.ToUpper,
                                    txtPApe.Text.ToUpper,
                                    txtSApePerfil.Text.ToUpper,
                                    txtEspe.Text.ToUpper,
                                    txtMail.Text,
                                    Principal.Singleton.Base64(path))

                            If med.updateUsuario() Then

                                If med.updateMedico(Datos_Temporales.userLog) Then
                                    MsgBox(Principal.Singleton.Idioma("msgboxUpdate", "Su perfil ha sido modificado con exito"))
                                    setVariablesUsuario()
                                    setVariableMedico()
                                Else
                                    MsgBox(Principal.Singleton.Idioma("msgboxErrorUpdatePac", "Error al modificar el perfil"))
                                End If


                            End If
                        End If
                    End If
                End If
        End Select
    End Sub

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
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTelefonos, scroll, True)

        Me.Top = 0
        Select Case Datos_Temporales.rol

            Case Datos_Temporales.enumRol.Paciente
                'btnRegistrar.BringToFront()
                Me.Location = New Point((frmBienvenidaPaciente.Width - Me.Width) \ 2, Me.Location.Y)
                pnlCredenciales.Visible = False
                lblEspecPerfil.Visible = False
                pnlMedico.Visible = False
                pnlMedYo.Visible = False
                btnModPatologias.Visible = True
                setVariablesUsuario()
                setTelefonosUsuario()
                setVariablesPaciente()


            Case Datos_Temporales.enumRol.Gestor
                btnModPatologias.Visible = False
                'btnRegistrar.BringToFront()
                Me.Location = New Point((frmBienvenidaGestor.Width - Me.Width) \ 2, Me.Location.Y)
                pnlCredenciales.Visible = False
                lblEspecPerfil.Visible = False
                pnlMedico.Visible = False
                pnlPaciente.Visible = False
                pnlMedYo.Visible = False
                setVariablesUsuario()
                setTelefonosUsuario()

            Case Datos_Temporales.enumRol.Medico
                btnModPatologias.Visible = False
                pnlCredenciales.Visible = False
                Me.Location = New Point((frmBienvenidaMedico.Width - Me.Width) \ 2, Me.Location.Y)
                ' pnlMedYo.Location = pnlPaciente.Location
                lblEspecPerfil.Visible = True
                txtEspe.Visible = True
                pnlMedico.Visible = True
                btnAceptarPerfil.Visible = False
                btnEliminarPerfil.Visible = False
                pnlPaciente.Visible = False
                dgvTelefonos.Visible = False
                lblTel.Visible = False
                lblTelefonosPerfil.Visible = False
                lblTelesPerfil.Visible = False

                setVariablesUsuario()
                setVariableMedico()
        End Select

    End Sub
    Private Sub setVariableMedico()
        Dim Mayus = med.getInformacionMedico(Datos_Temporales.userLog)
        _especializacion = Mayus.ToString.Substring(0, 1).ToUpper + Mayus.ToString.Substring(1).ToLower
        txtEspe.Text = _especializacion
        lblEspe.Text = _especializacion
    End Sub
    Private Sub setVariablesPaciente()
        Dim datos As DataRow = pac.getDatosPacientePerfil(Datos_Temporales.userLog).Rows(0)

        _edad = datos.Item(0).ToString.Substring(0, 1).ToUpper + datos.Item(0).ToString.Substring(1).ToLower
        lblEd.Text = _edad

        _sexo = datos.Item(1)
        lblSex.Text = _sexo

        If _sexo = "M" Then
            lblSex.Text = Principal.Singleton.Idioma("lblSex1", "Masculino")
        Else
            lblSex.Text = Principal.Singleton.Idioma("lblSex2", "Femenino")
        End If

        _fecNac = datos.Item(2)
        Dim patologias As DataTable = pac.getPatologiasCronicas(Datos_Temporales.userLog)

        If patologias.Rows.Count > 0 Then
            For Each patologia As DataRow In patologias.Rows
                lblPatCron.Text += patologia.Item(0) & ", "
                'dgvPatologias.Rows.Add(patologia.Item(0)).ToString()
                aliPatologias.Add(patologia.Item(0))
            Next
        Else
            lblPatCron.Text = Principal.Singleton.Idioma(lblPatCron.Name, "Usted no tiene patologías crónicas")
            lblPatCron.Text.TrimEnd(", ")
        End If

    End Sub
    Private Sub setVariablesUsuario()

        'SET VARIABLES
        Dim datos As DataRow = usu.getDatosUsuario(Datos_Temporales.userLog).rows(0)
        _pNom = datos.Item(1).ToString.Substring(0, 1).ToUpper + datos.Item(1).ToString.Substring(1).ToLower

        If datos.Item(2).ToString() <> "" Then
            _sNom = datos.Item(2).ToString.Substring(0, 1).ToUpper + datos.Item(2).ToString.Substring(1).ToLower
        Else
            _sNom = ""
            lblSNomPerfil.Visible = False
            txtSNom.Visible = False
            lblPApePerfil.Location = New Point(40, 262)
            txtPApe.Location = New Point(40, 289)
            lblSApePerfil.Location = New Point(40, 374)
            txtSApePerfil.Location = New Point(40, 406)
            'pnlMedYo.Location = New Point(40, 503)
            pnlMedYo.Location = New Point(34, 454)
        End If

        _pApe = datos.Item(3).ToString.Substring(0, 1).ToUpper + datos.Item(3).ToString.Substring(1).ToLower
        _sApe = datos.Item(4).ToString.Substring(0, 1).ToUpper + datos.Item(4).ToString.Substring(1).ToLower
        _email = datos.Item(5).ToString.Substring(0, 1).ToUpper + datos.Item(5).ToString.Substring(1).ToLower

        If datos.Item(6).ToString() <> "" Then
            GunaCirclePictureBox1.Image = Principal.Singleton.Base64ToImage(datos.Item(6))
        Else
            GunaCirclePictureBox1.Image = My.Resources.nopic
        End If

        'SET TEXTOS
        lblEmailPerfil.Text = _email
        txtMail.Text = _email

        lblNomPerfil.Text = _pNom & " " & _sNom & " " & _pApe & " " & _sApe

        txtPNom.Text = _pNom
        txtSNom.Text = _sNom
        txtPApe.Text = _pApe
        txtSApePerfil.Text = _sApe
        cambiados = True
    End Sub

    Private Sub txtPNom_TextChanged(sender As Object, e As EventArgs) Handles txtSNom.TextChanged, txtSApePerfil.TextChanged, txtPNom.TextChanged, txtPApe.TextChanged, txtEspe.TextChanged, txtMail.TextChanged, txtEspe.TextChanged

        If cambiados Then
            If _pNom <> txtPNom.Text Or _sNom <> txtSNom.Text Or _pApe <> txtPApe.Text Or _sApe <> txtSApePerfil.Text Or _email <> txtMail.Text Or _especializacion <> txtEspe.Text Then
                btnRegistrar.Enabled = True
            Else
                btnRegistrar.Enabled = False
            End If
        End If
    End Sub

    Private Sub dgvTelefonos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellValueChanged

        Dim i = 0
        Dim contador As Short = 0

        For Each telefono In alitel

            If telefono = dgvTelefonos.Rows(i).Cells(0).Value Then
                contador += 1
            End If
            i += 1
        Next

        If contador <> alitel.Count Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub
    Dim alitel As New ArrayList

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarPerfil.Click
        dgvTelefonos.Rows.Add()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminarPerfil.Click
        If dgvTelefonos.Rows.Count > 0 Then
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.CurrentRow.Index)
        ElseIf dgvTelefonos.Rows.Count < 0 Then
            btnEliminarPerfil.Enabled = False
        End If
    End Sub

    Private Sub setTelefonosUsuario()

        Dim telefonos As DataTable = ges.getTelefonosUsuario
        If telefonos.Rows.Count > 0 Then
            For Each telefono As DataRow In telefonos.Rows
                lblTel.Text += telefono.Item(0) & ", "
                dgvTelefonos.Rows.Add(telefono.Item(0)).ToString()
                alitel.Add(telefono.Item(0))
            Next
        Else
            lblTel.Text = Principal.Singleton.Idioma(lblTel.Name, "No hay teléfonos registrados")
        End If
        lblTel.Text.TrimEnd(", ")

    End Sub

    Private Sub btnVerPatologias_Click(sender As Object, e As EventArgs) Handles btnVerPatologias.Click
        If pnlPatologias.Visible = True Then
            pnlPatologias.Visible = False
        Else
            pnlPatologias.Visible = True
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.Dispose()
    End Sub

    Private Sub btnModPatologias_Click(sender As Object, e As EventArgs) Handles btnModPatologias.Click

        Dim instancia As frmBienvenidaPaciente = Me.ParentForm
        Dim frm As New frmIngresarSintomas(aliPatologias, 1)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(instancia.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
        frm.Show()
        instancia.pnlContenedor.Hide()
        instancia.pnlInstancia.Show()
        Me.ResumeLayout()
        Me.Dispose()
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificarPerfil.Click
        pnlMain.BringToFront()
        transicion.Hide(pnlMain)
        transicion.Show(pnlYo)
        btnRegistrar.Visible = True
        btnRegistrar.BringToFront()
    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        pnlYo.BringToFront()
        transicion.Hide(pnlYo)
        transicion.Show(pnlMain)
        btnRegistrar.BringToFront()
    End Sub
    Private Sub Mostrar_pnlContacto(sender As Object, e As EventArgs) Handles IconButton2.Click
        pnlYo.BringToFront()
        transicion.Hide(pnlYo)
        transicion.Show(pnlContacto)
        btnRegistrar.BringToFront()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        pnlContacto.BringToFront()
        transicion.Hide(pnlContacto)
        transicion.Show(pnlYo)
        btnRegistrar.BringToFront()
    End Sub

    'Private Sub dgvTelefonos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvTelefonos.CellBeginEdit
    '    MsgBox(dgvTelefonos(e.ColumnIndex, e.RowIndex).Value).ToString()
    'End Sub
    'Private Sub dgvTelefonos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellEndEdit
    '    MsgBox(dgvTelefonos(e.ColumnIndex, e.RowIndex).Value).ToString()
    'End Sub
End Class
