Imports Logica
Public Class frmBienvenidaMedico

    Public Sub New()

        InitializeComponent()

        Principal.Singleton.CambiarTamaño(Me)
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



        If Encriptar.Singleton.HASH256(Datos_Temporales.userLog) = ControladorMedico.Singleton.verificarPassMedico().ToLower Then
            Dim advertencia As New UCAdvertencia
            Me.Controls.Add(advertencia)
            advertencia.Location = New Point((Me.Width - advertencia.Width) \ 2, (Me.Height - advertencia.Height) \ 2)
            advertencia.Show()
            advertencia.BringToFront()
        End If
      

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles btnIngresarChatsPaciente.Click
        Dim frm As New frmChat
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmChat)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
 
    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub

    Private Sub timerChat_Tick(sender As Object, e As EventArgs) Handles timerChat.Tick

        Dim notificacion As Object = ControladorChat.Singleton.ListarNotificacionChat

        If notificacion IsNot Nothing Then
            If notificacion <> 0 Then
                If notificacion.ToString <> lblNotiChats.Text Then

                    pnlNoti.Visible = True
                    Me.lblNotiChats.Visible = True

                    If notificacion > 99 Then
                        Me.lblNotiChats.Text = "99+"

                    Else
                        Me.lblNotiChats.Text = cantNotificacion

                    End If

                    If notificacion < 10 Then
                        Me.lblNotiChats.Location = New Point(2, 1)
                    Else
                        Me.lblNotiChats.Location = New Point(-1, 1)
                    End If
                End If
            Else
                pnlNoti.Visible = False
                Me.lblNotiChats.Visible = False
            End If

        End If

    End Sub

    Dim cantNotificacion = 0
    Private Sub timerMsg_Tick(sender As Object, e As EventArgs) Handles timerMsg.Tick

        For Each row As DataRow In ControladorChat.Singleton.Notificacion.Rows 'la cantidad de mensajes nuevos desde que mandaste uno
            If row.Item(0) <> Datos_Temporales.userLog Then
                cantNotificacion += 1
            Else
                Exit For
            End If
        Next

        If cantNotificacion <> 0 Then

            If cantNotificacion.ToString <> lblNotiMsg.Text Then

                pnlNotificacion.Visible = True
                lblNotiMsg.Visible = True

                If cantNotificacion > 99 Then
                    lblNotiMsg.Text = "99+"
                    lblNuevosMsg.Text = Principal.Singleton.Idioma("msgTienesTantosMensajes", "Tienes 99+ mensajes sin responder")
                    lblNuevosMsg.Location = New Point((Me.Width / 2) - (lblNuevosMsg.Width / 2), lblNuevosMsg.Location.Y)
                Else
                    lblNotiMsg.Text = cantNotificacion
                    lblNuevosMsg.Text = Principal.Singleton.Idioma("msgTienesMsg", "Tienes ") & cantNotificacion & Principal.Singleton.Idioma("msgSinResponder", " mensajes sin responder")
                    lblNuevosMsg.Location = New Point((Me.Width / 2) - (lblNuevosMsg.Width / 2), lblNuevosMsg.Location.Y)
                End If

                If cantNotificacion < 10 Then
                    lblNotiMsg.Location = New Point(2, 1)
                Else
                    lblNotiMsg.Location = New Point(-1, 1)
                End If
                lblNuevosMsg.Text = Principal.Singleton.Idioma("msgTienesMsg", "Tienes ") & cantNotificacion & Principal.Singleton.Idioma("msgSinResponder", " mensajes sin responder")
                lblNuevosMsg.Location = New Point((Me.Width / 2) - (lblNuevosMsg.Width / 2), lblNuevosMsg.Location.Y)

            End If
        Else
            pnlNotificacion.Visible = False
            lblNotiMsg.Visible = False
            lblNotiMsg.Text = "0"
            lblNuevosMsg.Text = principal.singleton.idioma("msgSinMensajes","No tienes mensajes nuevos")
            lblNuevosMsg.Location = New Point((Me.Width / 2) - (lblNuevosMsg.Width / 2), lblNuevosMsg.Location.Y)
        End If

        cantNotificacion = 0
    End Sub

    Private Sub btnNoti_Click(sender As Object, e As EventArgs) Handles btnNoti.Click

        Dim dt As DataTable = ControladorChat.Singleton.listarChat
        If FlowLayoutPanel1.Visible = False Then
            FlowLayoutPanel1.Visible = True
            If dt.Rows.Count > 0 Then

                lblNAChats.Visible = False
                FlowLayoutPanel1.Controls.Clear()
                FlowLayoutPanel1.BringToFront()
                FlowLayoutPanel1.SuspendLayout()

                For Each row In dt.Rows
                    Dim uc As New UCSolicitudes(row.item(0), row.item(1), row.item(2) & " " & row.item(3), row.item(4))
                    FlowLayoutPanel1.Controls.Add(uc)
                    uc.Show()
                Next
                FlowLayoutPanel1.ResumeLayout()

            Else
                FlowLayoutPanel1.Controls.Clear()
                lblNAChats.Visible = False
            End If
        Else
            FlowLayoutPanel1.Visible = False
        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If pnlOps.Visible = True Then
            pnlOps.Visible = False
        Else
            pnlOps.Visible = True
        End If
    End Sub

    Private Sub btnVerPerfil_Click(sender As Object, e As EventArgs) Handles btnVerPerfilMedico.Click
        Me.SuspendLayout()
        Dim perfil As New UCVerPerfil()
        Me.Controls.Add(perfil)
        perfil.BringToFront()
        Me.ResumeLayout()
    End Sub

    Private Sub btnCambiarPass_Click(sender As Object, e As EventArgs) Handles btnCambiarPassMedico.Click
        Me.SuspendLayout()
        Dim perfil As New UCVerPerfil()
        perfil.pnlCredenciales.BringToFront()
        perfil.pnlCredenciales.Visible = True
        Me.Controls.Add(perfil)
        perfil.BringToFront()
        Me.ResumeLayout()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles btnCerrarSesionMedico.Click
        Principal.Singleton.CambiarTamaño(frmLogin)
        Dim instancia As frmLogin = Me.ParentForm

        If instancia.mcbRecordarUsuario.Checked Then
            instancia.txtPass.Text = Nothing
            instancia.lblContraseña.Visible = True
            instancia.lblUsuario.Visible = False
        Else
            instancia.txtUsr.Text = Nothing
            instancia.txtPass.Text = Nothing
            instancia.lblContraseña.Visible = True
            instancia.lblUsuario.Visible = True
        End If

        Me.Dispose()
    End Sub

    Private Sub btnReanudar_Click(sender As Object, e As EventArgs) Handles btnListadoPatMedico.Click
        Dim frm As New frmListado(0)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmListado)
        frm.btnEliminarElementos.Visible = False
        frm.btnModificarElemento.Visible = False
        frm.btnRegistrarListado.Visible = False
        frm.btnSeleccionMultiple.Visible = False
        frm.Show()

        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub


End Class