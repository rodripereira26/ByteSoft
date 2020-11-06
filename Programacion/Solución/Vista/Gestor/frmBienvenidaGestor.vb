Imports Logica

Public Class frmBienvenidaGestor
    Dim ScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Dim gestor As New ControladorGestor
    Public Shared instancia As frmBienvenidaGestor
    Public Shared Function Singleton() As frmBienvenidaGestor
        If instancia Is Nothing Then
            instancia = New frmBienvenidaGestor

        End If
        Return instancia
    End Function

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Principal.Singleton.CambiarTamaño(Me)
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

                                                    If TypeOf ctrl5 Is Panel Then
                                                        For Each ctrl6 As Control In ctrl5.Controls
                                                            ctrl6.Text = Principal.Singleton.Idioma(ctrl6.Name, ctrl6.Text)
                                                        Next
                                                    End If

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

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        Notificacion(gestor.NotificacionListadoPaciente, lblNotificacion, pnlNotificacion)
        Notificacion(gestor.NotificacionListadoGestor, Label11, GunaElipsePanel2)

        instancia = Me
        pnlFlow.AutoScroll = False
        pnlFlow.HorizontalScroll.Enabled = False
        pnlFlow.HorizontalScroll.Visible = False
        pnlFlow.AutoScroll = True
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlFlow, scroll, True)

    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub
    Public Sub cargarGestores()
        Dim dt As DataTable = gestor.ListadoHabilitarGest

        If pnlFlow.Controls.Count <> dt.Rows.Count Then
            pnlFlow.Controls.Clear()
            pnlFlow.SuspendLayout()

            For Each rows As DataRow In dt.Rows

                pnlFlow.Controls.Add(New UCHabilitarGestor(rows.Item(1) + " " + rows.Item(2) + " " + rows.Item(3), rows.Item(0)))

            Next
            pnlFlow.ResumeLayout()
        End If

    End Sub
    Public Sub cargarPacientes()

        Dim dt As DataTable = gestor.ListadoHabilitarPac

        If pnlFlow.Controls.Count <> dt.Rows.Count Then
            pnlFlow.Controls.Clear()
            pnlFlow.SuspendLayout()

            For Each rows As DataRow In dt.Rows

                pnlFlow.Controls.Add(New UCHabilitarPaciente(rows.Item(1) + " " + rows.Item(2) + " " + rows.Item(3), rows.Item(0)))

            Next
            pnlFlow.ResumeLayout()
        End If
    End Sub

    Private Sub btnPatologia_Click(sender As Object, e As EventArgs) Handles btnPatologiaGestion.Click
        Dim frm As New frmOpciones()
        frm.op = 0
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmOpciones)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomasGestion.Click
        Dim frm As New frmOpciones()
        frm.op = 1
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmOpciones)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistroGestor.Click
        Dim frm As New frmOpciones()
        frm.op = 2
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmOpciones)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click, lblNotificacion.Click

        If pnlFlow.Visible = False Then

            lblNA.Location = New Point(615, 2)
            pnlFlow.Location = New Point(612, 0)
            cargarPacientes()

            pnlFlow.AutoScroll = False
            pnlFlow.HorizontalScroll.Enabled = False
            pnlFlow.HorizontalScroll.Visible = False
            pnlFlow.AutoScroll = True


            If pnlFlow.Controls.Count = 0 Then
                lblNA.Visible = True
            End If

            setTamaños()
            pnlFlow.Visible = True
        Else
            pnlFlow.Visible = False
            scroll.Visible = False
            lblNA.Visible = False
        End If

    End Sub

    Private Sub btnGestores_Click(sender As Object, e As EventArgs) Handles btnGestores.Click

        If pnlFlow.Visible = False Then

            pnlFlow.Location = New Point(570, 0)
            lblNA.Location = New Point(573, 2)
            cargarGestores()

            pnlFlow.AutoScroll = False
            pnlFlow.HorizontalScroll.Enabled = False
            pnlFlow.HorizontalScroll.Visible = False
            pnlFlow.VerticalScroll.Enabled = False
            pnlFlow.VerticalScroll.Visible = False

            pnlFlow.AutoScroll = True


            If pnlFlow.Controls.Count = 0 Then
                lblNA.Visible = True
            End If

            setTamaños()
            pnlFlow.Visible = True
        Else
            pnlFlow.Visible = False
            scroll.Visible = False
            lblNA.Visible = False
        End If

    End Sub
    Public Sub setTamaños()
        If pnlFlow.Controls.Count < 4 Then
            scroll.Enabled = False
            scroll.Visible = False
            pnlFlow.Width = 315
        Else
            pnlFlow.Width = 335
        End If
    End Sub


    Private Sub tempListaPacientes_Tick(sender As Object, e As EventArgs) Handles tempListaPacientes.Tick

        Notificacion(gestor.NotificacionListadoPaciente, lblNotificacion, pnlNotificacion)
        Notificacion(gestor.NotificacionListadoGestor, Label11, GunaElipsePanel2)

    End Sub

    Private Sub Notificacion(consulta As Short, lblNotificacion As Label, pnlNotificacion As Panel)

        Dim notificacion As Int16 = consulta

        If notificacion <> 0 Then

            If notificacion.ToString <> lblNotificacion.Text Then

                pnlNotificacion.Visible = True
                lblNotificacion.Visible = True

                If notificacion > 99 Then
                    lblNotificacion.Text = "99+"
                Else
                    lblNotificacion.Text = notificacion
                End If

                If notificacion < 10 Then
                    lblNotificacion.Location = New Point(2, 1)
                Else
                    lblNotificacion.Location = New Point(-1, 1)
                End If

            End If
        Else
            pnlNotificacion.Visible = False
            lblNotificacion.Visible = False
            lblNotificacion.Text = "0"

        End If
    End Sub

    Public Sub AjustarPnl() Handles pnlFlow.ControlRemoved

        setTamaños()
        Notificacion(gestor.NotificacionListadoPaciente, lblNotificacion, pnlNotificacion)
        Notificacion(gestor.NotificacionListadoGestor, Label11, GunaElipsePanel2)

        If pnlFlow.Controls.Count = 0 Then
            lblNA.Visible = True

        End If


    End Sub
    Public Sub AjustarPnl2() Handles pnlFlow.ControlAdded
        lblNA.Visible = False
    End Sub

    Private Sub Enter(sender As Object, e As EventArgs) Handles Panel7.MouseEnter, Panel5.MouseEnter, Panel3.MouseEnter, Panel1.MouseEnter, lblSubUsu.MouseEnter, lblUsuarioMain.MouseEnter, lblRegistroMain.MouseEnter, lblSubRegis.MouseEnter, lblSintomaMain.MouseEnter, lblSubSin.MouseEnter, lblSubPat.MouseEnter, lblPatologiaMain.MouseEnter, btnUsuariosGestion.MouseEnter, btnSintomasGestion.MouseEnter, btnRegistroGestor.MouseEnter, btnPatologiaGestion.MouseEnter, IconButton1.MouseEnter

        If TypeOf sender IsNot Panel Then
            sender.parent.backcolor = Color.FromArgb(25, 32, 37)
        Else
            sender.backcolor = Color.FromArgb(25, 32, 37)
        End If

    End Sub

    Private Sub Leave(sender As Object, e As EventArgs) Handles Panel7.MouseLeave, Panel5.MouseLeave, Panel3.MouseLeave, Panel1.MouseLeave, lblSubUsu.MouseLeave, lblUsuarioMain.MouseLeave, lblRegistroMain.MouseLeave, lblSubRegis.MouseLeave, lblSintomaMain.MouseLeave, lblSubSin.MouseLeave, lblSubPat.MouseLeave, lblPatologiaMain.MouseLeave, btnUsuariosGestion.MouseLeave, btnSintomasGestion.MouseLeave, btnRegistroGestor.MouseLeave, btnPatologiaGestion.MouseLeave, IconButton1.MouseLeave

        If TypeOf sender IsNot Panel Then
            sender.parent.backcolor = Colores.primario_DARK
        Else
            sender.backcolor = Colores.primario_DARK
        End If
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuariosGestion.Click
        Dim frm As New frmListado(2)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmListado)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If pnlOps.Visible = True Then
            pnlOps.Visible = False
        Else
            pnlOps.Visible = True
        End If
    End Sub


    Private Sub btnVerPerfil_Click(sender As Object, e As EventArgs) Handles btnVerPerfil.Click
        Me.SuspendLayout()
        Dim perfil As New UCVerPerfil()
        Me.Controls.Add(perfil)
        perfil.BringToFront()
        Me.ResumeLayout()
    End Sub

    Private Sub btnCambiarPass_Click(sender As Object, e As EventArgs) Handles btnCambiarPassGestor.Click
        Me.SuspendLayout()
        Dim perfil As New UCVerPerfil()
        perfil.pnlCredenciales.BringToFront()
        perfil.pnlCredenciales.Visible = True
        Me.Controls.Add(perfil)
        perfil.BringToFront()
        Me.ResumeLayout()
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles btnCerrarSesionGestor.Click
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

    Private Sub frmBienvenidaGestor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub
End Class