Imports Logica
Imports System.IO

Public Class frmLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblLogin.Select()
        CargarUsuario()
        If txtUsr.Text <> "" Then
            lblUsuario.Visible = False
        End If
    End Sub
    Sub New()
        ObtenerRuta()

        Try
            If Datos_Temporales.pathConf IsNot Nothing Then
                Configuracion.Singleton.CargarConfiguracion()
            End If

        Catch ex As Exception
            MsgBox("Error al cargar la configuración del sistema")
        End Try

        UCAjustes.Singleton.VerificarArchivo()
        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        Principal.Singleton.CambiarTamaño(Me)


        For Each var As Control In pnlContenedor.Controls



        Next

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

            If Principal.Singleton.Idioma(var.Name, var.Text) <> "" Then
                var.Text = Principal.Singleton.Idioma(var.Name, var.Text)

                If var.Name <> "lblContraseña" And var.Name <> "lblUsuario" Then
                    var.Left = (Me.ClientSize.Width - var.Width) / 2
                End If

            End If
        Next


    End Sub

    Public Sub ObtenerRuta()

        Dim array As New ArrayList
        Dim matriz() As String = Split(Application.StartupPath, "\")
        Dim sec As String

        Try
            If Directory.Exists(Path.Combine(Application.StartupPath, "conf\")) Then
                Datos_Temporales.pathConf = Path.Combine(Application.StartupPath, "conf\")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar el idioma")
        End Try



    End Sub

    Private Sub CargarUsuario()

        If Configuracion.Singleton.usuario <> Nothing Then
            If Datos_Temporales.rol <> Datos_Temporales.enumRol.Paciente Then
                txtUsr.Text = Configuracion.Singleton.usuario
                mcbRecordarUsuario.Checked = True
            End If

        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        ingresarUsuario()
    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub

    Private Sub ingresarUsuario()

        Dim seg As New Encriptar
        Dim log As New ControladorUsuario

        If txtUsr.Text <> "" And txtPass.Text <> "" Then
            If IsNumeric(txtUsr.Text) Then
                If log.verificarUsuario(txtUsr.Text, seg.HASH256(txtPass.Text)) And log.verificarRol(txtUsr.Text) Then

                    If Datos_Temporales.pathConf IsNot Nothing Then
                        If mcbRecordarUsuario.Checked Then
                            Configuracion.Singleton.usuario = txtUsr.Text
                            Configuracion.Singleton.GuardarConfiguracion()
                        Else
                            Configuracion.Singleton.usuario = Nothing
                            Configuracion.Singleton.GuardarConfiguracion()
                        End If
                    End If

                    Datos_Temporales.userLog = txtUsr.Text


                    Select Case Datos_Temporales.rol

                        Case Datos_Temporales.enumRol.Paciente
                            Dim paciente As New ControladorPaciente

                            If paciente.verificar(txtUsr.Text) Then
                                Dim frm As New frmBienvenidaPaciente 'frmBienvenidaPaciente
                                Configuracion.Singleton.SetConnection()
                                Me.SuspendLayout()
                                Principal.Singleton.CambiarTamaño(frm.Width, frm.Height)
                                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)

                                frm.Show()
                                pnlContenedor.Hide()
                                pnlInstancia.Show()
                                Me.ResumeLayout()
                            Else
                                MsgBox(Principal.Singleton.Idioma("msgPacienteHabilitado", "asdasd"))
                            End If

                        Case Datos_Temporales.enumRol.Gestor

                            Dim gestor As New ControladorGestor

                            If gestor.verificar(txtUsr.Text) Then

                                Dim frm As New frmBienvenidaGestor
                                Configuracion.Singleton.SetConnection()
                                Me.SuspendLayout()
                                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                                Principal.Singleton.CambiarTamaño(frm)
                                frm.Show()
                                pnlContenedor.Hide()
                                pnlInstancia.Show()
                                Me.ResumeLayout()
                            Else
                                MsgBox(Principal.Singleton.Idioma("msgNoEstasHabilitado", "Usted no se encuentra habilitado para ingresar al sistema"))
                            End If

                        Case Datos_Temporales.enumRol.Medico
                            Dim frm As New frmBienvenidaMedico
                            Configuracion.Singleton.SetConnection()
                            Me.SuspendLayout()
                            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                            Principal.Singleton.CambiarTamaño(frm)
                            frm.Show()
                            pnlContenedor.Hide()
                            pnlInstancia.Show()
                            Me.ResumeLayout()

                    End Select

                Else

                    MsgBox(Principal.Singleton.Idioma("msgLoginIncorrecto", "Los datos de inicio son incorrectos"))

                End If

            Else
                MsgBox(Principal.Singleton.Idioma("msgCedulaInvalida", "La cédula ingresada es invalida"))
            End If

        Else
            MsgBox(Principal.Singleton.Idioma("msgCamposIncompletos", "asdas"))

        End If

    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsr.KeyDown, txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            ingresarUsuario()
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs)
        ingresarUsuario()
    End Sub

    Private Sub lblCrearCuenta_Click(sender As Object, e As EventArgs) Handles lblCrearCuenta.Click

        If Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente Then
            Dim frm As New frmRegistroPaciente
            Me.SuspendLayout()
            Principal.Singleton.CambiarTamaño(frm.Width, frm.Height)
            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)

            frm.Show()
            pnlContenedor.Hide()
            pnlInstancia.Show()
            Me.ResumeLayout()
        Else
            Dim frm As New frmRegistroGestor
            Me.SuspendLayout()
            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
            Principal.Singleton.CambiarTamaño(frm)
            frm.Show()
            pnlContenedor.Hide()
            pnlInstancia.Show()
            Me.ResumeLayout()
        End If

    End Sub

    Private Sub btnAjustes_Click(sender As Object, e As EventArgs) Handles btnAjustes.Click

        If UcAjustes1.Visible = False Then
            UcAjustes1.Visible = True
            UcAjustes1.cbIdiomas.SelectedIndex = Configuracion.Singleton.lenguaje
            lblCrearCuenta.Visible = False
        Else
            If Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente Then
                lblCrearCuenta.Visible = True
            End If

            UcAjustes1.Visible = False
        End If
    End Sub

    Private Sub btnIngresar_Click_1(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ingresarUsuario()
    End Sub

    Dim bool As Boolean = False
    Private Sub txtPass_GotFocus(sender As Object, e As EventArgs) Handles txtPass.GotFocus

        If txtPass.Text = "" Then
            lblContraseña.Visible = False

        End If

    End Sub
    Private Sub txtPass_LostFocus(sender As Object, e As EventArgs) Handles txtPass.LostFocus

        If txtPass.Text = "" Then
            lblContraseña.Visible = True

        End If

    End Sub
    Private Sub txtUsr_GotFocus(sender As Object, e As EventArgs) Handles txtUsr.GotFocus

        If txtUsr.Text = "" Then
            lblUsuario.Visible = False

        End If

    End Sub
    Private Sub txtUsr_LostFocus(sender As Object, e As EventArgs) Handles txtUsr.LostFocus

        If txtUsr.Text = "" Then
            lblUsuario.Visible = True

        End If

    End Sub

    Private Sub lblUsuario_Click(sender As Object, e As EventArgs) Handles lblUsuario.Click
        txtUsr.Focus()
    End Sub

    Private Sub lblContraseña_Click(sender As Object, e As EventArgs) Handles lblContraseña.Click
        txtPass.Focus()
    End Sub

    Private Sub frmLogin_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        lblApp.Select()
    End Sub

    Private Sub UcAjustes1_Load(sender As Object, e As EventArgs) Handles UcAjustes1.Load

    End Sub
End Class