Imports Logica
Public Class frmChat

    Public Property maxID As Int32
    Public instanciaChat As UCChat = New UCChat()
    Private contChat As New ControladorChat
    Private firstUpdate As Boolean = False
    Private contPac As New ControladorPaciente
    Private id As New ArrayList
    Dim ScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Dim scrollHelper2 As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Dim pat As New ControladorPatologia

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

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        ScrollHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(Chat, scroll, True)
        scrollHelper2 = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlChats, scroll2, True)

        If Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente Then
            Datos_Temporales.idchat = ControladorChat.Singleton.ObtenerChatPaciente
        End If

    End Sub
    Private Sub frmChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente Then

            Dim i As Integer = 120
            Timer1.Enabled = True
            Me.CenterToScreen()
            Me.SuspendLayout()

            pnlWrapChat.Width += i
            pnlWrapChat.Location = New Point((Me.Width - pnlWrapChat.Width) \ 2, (Me.Height - pnlWrapChat.Height) \ 2)

            Panel1.Width += i
            txtMsg.Width += i
            txtMsg.Location = New Point(txtMsg.Location.X + i, txtMsg.Location.Y)

            Chat.Location = New Point(Chat.Location.X - i, Chat.Location.Y)
            Chat.Width += i
            pnlUsuario.BringToFront()

            'If foto <> "" Then
            '    GunaCirclePictureBox1.Image = Principal.Singleton.Base64ToImage(foto)
            'Else
            '    GunaCirclePictureBox1.Image = My.Resources.nopic
            'End If
            ' pbPerfil.Image =
            'Chat.Location = New Point(Chat.Location.X, Chat.Location.Y - 50)

            Me.ResumeLayout()
            btnFinalizar.Visible = False
            btnVerSintomasDiagPac.Visible = False
            pnlChats.Visible = False
            scroll.Visible = False
            pbEnviar.Visible = True
            txtMsg.Visible = True
            lblEscriba.Visible = True
            pnlEnviar.Visible = True
            pnlUsuario.Visible = False
            pnlUsuario.Enabled = False
        Else
            CargarPanel(contChat.ListarMisChats(0))
            id.Reverse()
            CambiarOrden()
        End If

        Chat.HorizontalScroll.Enabled = False
        Chat.HorizontalScroll.Visible = False

        Update()

    End Sub
    Private Sub CargarPanel(Listado As DataTable)


        pnlChats.SuspendLayout()
        pnlChats.Controls.Clear()

        For Each filaTodas As DataRow In Listado.Rows

            Dim form As New UCChat(filaTodas.Item(2).ToString.Substring(0, 1).ToUpper + filaTodas.Item(2).ToString.Substring(1).ToLower & " " & filaTodas.Item(3).ToString.Substring(0, 1).ToUpper + filaTodas.Item(3).ToString.Substring(1).ToLower, "", Nothing, filaTodas.Item(1), filaTodas.Item(0), filaTodas.Item(4))

            pnlChats.Controls.Add(form)
            form.Show()
            id.Add(filaTodas.Item(1))

        Next



        pnlChats.ResumeLayout()

    End Sub
    Public Sub ReloadChat()

        Dim Mensajes As DataTable = contChat.recargarChat
        maxID = 0

        Chat.SuspendLayout()
        Chat.Controls.Clear()

        For Each mensaje As DataRow In Mensajes.Rows

            Dim esEmisor As Boolean = False

            If mensaje.Item(0) = Datos_Temporales.userLog Then
                esEmisor = True
            End If

            Dim msj As New UCMensaje(esEmisor, mensaje.Item(1), mensaje.Item(2), mensaje.Item(3), Nothing)

            If msj.idMsj > maxID Then
                maxID = msj.idMsj
            End If

            msj.Width = Chat.Width - 25
            Chat.Controls.Add(msj)
            msj.Show()
        Next

        Chat.ResumeLayout()
        Chat.VerticalScroll.Value = Chat.VerticalScroll.Maximum

    End Sub
    Private Sub ReloadSentMessage()

        Dim SetearLista As Boolean = False
        Dim Mensajes As DataTable = contChat.RecargarChatNuevoMSJ(maxID)

        Chat.SuspendLayout()

        For Each var As DataRow In Mensajes.Rows
            Dim esEmisor As Boolean = False

            If var.Item(0) = Datos_Temporales.userLog Then
                esEmisor = True
            End If

            Dim msj As New UCMensaje(esEmisor, var.Item(1), var.Item(2), var.Item(3), Nothing)
            maxID = msj.idMsj
            msj.Width = Chat.Width - 25
            Chat.Controls.Add(msj)
            msj.Show()

            instanciaChat.lblMensaje.Text = var.Item(1)
            instanciaChat.SetDate(var.ItemArray(2))
            ActualizarPanel()
        Next

        Chat.ResumeLayout()
        Chat.VerticalScroll.Value = Chat.VerticalScroll.Maximum()

    End Sub
    Private Sub ActualizarMensajes_Tick(sender As Object, e As EventArgs) Handles ActualizarMensajes.Tick
        If Chat.Controls.Count = 0 Then
            ReloadChat()
        Else
            ReloadSentMessage()
        End If
    End Sub
    Private Sub ActualizarChats_Tick(sender As Object, e As EventArgs) Handles ActualizarChats.Tick
        ActualizarPanel()
    End Sub
    Private Function Finalizar() As Boolean
        If Chat.Controls.Count > 0 And Datos_Temporales.idchat <> "" Then

            Dim respuesta = MsgBox(principal.singleton.idioma("msgFinalizarChat", "¿Desea finalizar la sesión de chat?"), vbQuestion + vbYesNo + vbDefaultButton2)

            If respuesta = vbYes Then
                If contChat.finalizarChat() Then
                    MsgBox(principal.singleton.idioma("msgSesionFinalizada", "Sesión finalizada"))
                    ''cambiar acá las cosas que van a pasar al finalizar el chat
                    Return True
                Else
                    MsgBox(principal.singleton.idioma("msgErrorFinalizarChat", "Error al finalizar el chat"))
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Private Sub enviarMensaje()
        If txtMsg.Text <> "" Then
            If Datos_Temporales.idchat IsNot Nothing Then
                If contChat.enviarMensaje(Datos_Temporales.userLog, Datos_Temporales.idchat, txtMsg.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")) Then
                    lblEscriba.Focus()
                    ReloadSentMessage()
                    txtMsg.Text = Nothing
                Else
                    MsgBox(principal.singleton.idioma("msgErrorEnviarMensaje", "Error al enviar el mensaje"))
                End If
            End If
        End If
    End Sub
    Private Sub txtMensaje_GotFocus(sender As Object, e As EventArgs)
        If txtMsg.Text = Nothing Then
            lblEscriba.Visible = True
        Else
            lblEscriba.Visible = False
        End If
    End Sub
    Private Sub txtMensaje_LostFocus(sender As Object, e As EventArgs)
        If txtMsg.Text = Nothing Then
            lblEscriba.Visible = True
        End If
    End Sub
    Private Sub pbCancelar_Click(sender As Object, e As EventArgs)
        Finalizar()
    End Sub
    Private Sub lblEscriba_Click(sender As Object, e As EventArgs) Handles lblEscriba.Click
        txtMsg.Focus()
    End Sub
    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        If Finalizar() Then

            Dim correoPaciente = contChat.getCorreo()
            Dim mensajeEnviar = contChat.setFormato

            If correoPaciente <> Nothing And mensajeEnviar <> Nothing Then
                If contChat.enviarCorreo(correoPaciente, mensajeEnviar) Then
                    MsgBox(principal.singleton.idioma("msgHistorialChatEnviado", "Se ha enviado el historial al paciente"))

                    enviarObservacion()
                    Datos_Temporales.idchat = Nothing
                    Chat.Controls.Clear()
                Else
                    MsgBox(principal.singleton.idioma("msgErrorEnviarCorreo", "Error al enviar el correo"))
                End If
            Else
                MsgBox(principal.singleton.idioma("msgErrorGenerarMensaje", "Error al generar el mensaje"))
            End If


        End If
    End Sub
    Public Sub enviarObservacion()

        Dim ucObs As New UCObservacion(lblUsuario.Text)
        Me.Controls.Add(ucObs)
        ucObs.Location = New Point((Me.Width - ucObs.Width) \ 2, (Me.Height - ucObs.Height) \ 2)
        ucObs.Show()
        ucObs.BringToFront()
    End Sub
    Private Sub txtMsg_TextChanged(sender As Object, e As EventArgs) Handles txtMsg.TextChanged
        If Not (txtMsg.Text = Nothing) Then
            lblEscriba.Visible = False
        Else
            lblEscriba.Visible = True
        End If
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtrasChat.Click

        If Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente Then
            Timer1.Enabled = False
            Principal.Singleton.CambiarTamaño(frmBienvenidaPaciente)
            Me.Dispose()

        Else
            Datos_Temporales.idchat = Nothing
            Principal.Singleton.CambiarTamaño(frmBienvenidaMedico)
            Me.Dispose()
        End If
    End Sub
    Private Sub pnlUsuario_Click(sender As Object, e As EventArgs) Handles pnlUsuario.Click
        If UcFicha1.Visible = False Then
            UcFicha1.Visible = True
            UcFicha1.BringToFront()

            Dim dt As DataTable = contPac.getDatosPacienteFicha(Datos_Temporales.pacienteSelecionado)

            For Each datarow As DataRow In dt.Rows
                UcFicha1.lblNomFicha.Text += " " & datarow.Item(0) & " " & datarow.Item(2) & " " & datarow.Item(3)
                Dim fechaNacimiento As Date = datarow.Item(4)
                Dim edad As Integer = Date.Now.Year - fechaNacimiento.Year
                UcFicha1.lblEdadFicha.Text += " " & edad.ToString
                UcFicha1.lblSexoFicha.Text += " " & datarow.Item(5)
                UcFicha1.lblMailFicha.Text += " " & datarow.Item(6)
            Next
            'UcFicha1.dgvPatCron.DataSource = contPac.getPatologiasCronicas(Datos_Temporales.pacienteSelecionado)
        Else
            UcFicha1.Visible = False
            UcFicha1.lblEdadFicha.Text = principal.singleton.idioma("msgEdadFicha", "Edad:")
            UcFicha1.lblMailFicha.Text = principal.singleton.idioma("msgMailFicha", "Mail:")
            UcFicha1.lblSexoFicha.Text = principal.singleton.idioma("msgSexoFicha", "Sexo:")
            UcFicha1.lblNomFicha.Text = principal.singleton.idioma("msgNombreFicha", "Nombre completo:")
        End If
    End Sub

    Private Sub CambiarOrden()

        Dim dt2 As DataTable = ControladorChat.Singleton.orden
        Dim contador As Integer = 0

        If dt2.Rows.Count = id.Count Then
            For i As Integer = 0 To dt2.Rows.Count - 1
                If dt2.Rows(i).Item(0) = id.Item(i) Then
                    contador += 1
                Else
                    Exit For
                End If
            Next
        End If

        If contador <> dt2.Rows.Count Then
            id.Clear()
            For Each fila As DataRow In dt2.Rows
                For Each control As UCChat In pnlChats.Controls
                    If fila.Item(0) = control.lblidChat.Text Then
                        control.lblMensaje.Text = fila.Item(1)
                        control.SetDate(fila.Item(2))
                        pnlChats.Controls.SetChildIndex(control, 0)
                    End If
                Next
                id.Add(fila.Item(0))
            Next
        End If

    End Sub
    Private Sub ActualizarPanel()

        Dim dt As DataTable = contChat.ListarMisChats(0)

        If dt.Rows.Count <> pnlChats.Controls.Count Then
            CargarPanel(dt)
            id.Reverse()
            CambiarOrden()
        Else
            CambiarOrden()
        End If

    End Sub
    Private Sub txtMsg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMsg.KeyDown
        If e.KeyCode = Keys.Enter Then
            enviarMensaje()
        End If
    End Sub
    Private Sub pbEnviar_Click(sender As Object, e As EventArgs) Handles pbEnviar.Click
        enviarMensaje()
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtMsg.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
        End If
    End Sub
    Dim finalizado As Boolean = True
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If (contChat.verificarEstadoChat) Then
            If finalizado Then
                finalizado = False
                MsgBox(principal.singleton.idioma("msgLaSesionFinalizo", "La sesión de chat ha finalizado"))
                Principal.Singleton.CambiarTamaño(frmBienvenidaPaciente)
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub FinalizarInstancia() Handles pnlInstancia.ControlRemoved
        pnlContenedor.Show()
    End Sub

    Private Sub btnSintomasDiag_Click(sender As Object, e As EventArgs) Handles btnVerSintomasDiagPac.Click
        Dim frm As New frmObtenerDiagnostico(pat.traerUltimoDiagnostico(Datos_Temporales.pacienteSelecionado), 1, Datos_Temporales.pacienteSelecionado)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmObtenerDiagnostico)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

End Class