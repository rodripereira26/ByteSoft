Imports Logica

Public Class frmChat

    Private contChat As New ControladorChat
    Private firstUpdate As Boolean = False

    Private Sub frmChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Principal.Singleton.roundedCorners(txtMensaje)

        updateChats()

        Chat.AutoScroll = False

        Chat.HorizontalScroll.Enabled = False

        Chat.AutoScroll = True

        Update()

    End Sub

    Public Sub New()

        InitializeComponent()
        Principal.Singleton.SuperRoundedCorners(txtMensaje)
        Update()

    End Sub

    Private Sub ReloadChat()

        Dim Mensajes As DataTable = contChat.recargarChat

        If Mensajes.Rows.Count <> Chat.Controls.Count Then

            Chat.SuspendLayout()
            Chat.Controls.Clear()

            Dim MensajesASetear As New List(Of Mensaje)

            For Each mensaje As DataRow In Mensajes.Rows

                Dim esEmisor As Boolean = False

                If mensaje.Item(0) = Datos_Temporales.user_temp Then
                    esEmisor = True
                End If

                MensajesASetear.Add(New Vista.Mensaje(esEmisor, mensaje.Item(1), mensaje.Item(2), Nothing))

            Next

            For Each mensaje As Mensaje In MensajesASetear

                mensaje.TopLevel = False
                mensaje.Width = Chat.Width - 25
                Chat.Controls.Add(mensaje)
                mensaje.Show()

            Next

            Chat.ResumeLayout()
            Chat.VerticalScroll.Value = Chat.VerticalScroll.Maximum()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ReloadChat()
    End Sub


    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click

        Datos_Temporales.idchat = Nothing

        If Datos_Temporales.rol = "P" Then
            frmBienvenidaPaciente.Show()
            Me.Dispose()
        Else
            frmListadoChat.Show()
            Me.Dispose()
        End If

    End Sub


    Private Sub finalizar()

        If Chat.Controls.Count > 0 And Datos_Temporales.idchat <> "" Then

            Dim respuesta = MsgBox("¿Desea finalizar la sesión de chat?", vbQuestion + vbYesNo + vbDefaultButton2)

            If respuesta = vbYes Then

                If contChat.finalizarChat() Then

                    Chat.Controls.Clear()
                    MsgBox("Sesión finalizada")
                    updateChats()
                    Timer1.Enabled = False

                Else
                    MsgBox("Error al finalizar el chat")
                End If

            End If
        End If

    End Sub

    Private Sub pbEnviar_Click(sender As Object, e As EventArgs) Handles pbEnviar.Click

        If txtMensaje.Text <> "" Then

            If contChat.enviarMensaje(Datos_Temporales.user_temp, Datos_Temporales.idchat, txtMensaje.Text, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")) Then

                ReloadChat()
                txtMensaje.Text = Nothing
                Chat.VerticalScroll.Value = Chat.VerticalScroll.Maximum()

            Else
                MsgBox("Error al enviar el mensaje")
            End If

        End If
    End Sub




    Private Sub txtMensaje_GotFocus(sender As Object, e As EventArgs)

        If txtMensaje.Text = Nothing Then
            lblEscriba.Visible = True
        Else
            lblEscriba.Visible = False
        End If

    End Sub
    Private Sub txtMensaje_LostFocus(sender As Object, e As EventArgs)

        If txtMensaje.Text = Nothing Then
            lblEscriba.Visible = True
        End If

    End Sub

    Private Sub updateChats()
        dgvMisChats.DataSource = contChat.listarMisChats(Datos_Temporales.user_temp, 0)
        dgvMisChats.Columns("idChat").Visible = False
        dgvFinalizados.DataSource = contChat.listarMisChats(Datos_Temporales.user_temp, 1)
        dgvFinalizados.Columns("idChat").Visible = False

    End Sub

    Private Sub pbCancelar_Click(sender As Object, e As EventArgs) Handles pbCancelar.Click
        finalizar()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        updateChats()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        finalizar()
    End Sub

    Private Sub MetroSetTextBox1_TextChanged(sender As Object) Handles txtMensaje.TextChanged
        If Not (txtMensaje.Text = Nothing) Then
            lblEscriba.Visible = False
        Else
            lblEscriba.Visible = True
        End If
    End Sub

    Private Sub dgvMisChats_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMisChats.CellClick
        Chat.Controls.Clear()
        Dim fila As Integer = dgvMisChats.CurrentCell.RowIndex
        Datos_Temporales.idchat = dgvMisChats.Rows(fila).Cells(columnName:="idChat").Value.ToString
        Dim controladorChat As New ControladorChat
        txtMensaje.Enabled = True
        btnFinalizar.Enabled = True
        pbCancelar.Visible = True
        lblEscriba.Text = "Escriba un mensaje"
        controladorChat.recargarChat()
        setNombreUsuario(dgvMisChats.CurrentCell.Value)
    End Sub

    Private Sub dgvFinalizados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFinalizados.CellClick
        Chat.Controls.Clear()
        Dim fila As Integer = dgvFinalizados.CurrentCell.RowIndex
        Datos_Temporales.idchat = dgvFinalizados.Rows(fila).Cells(columnName:="idChat").Value.ToString
        Dim controladorChat As New ControladorChat
        txtMensaje.Enabled = False
        btnFinalizar.Enabled = False
        pbCancelar.Visible = False
        lblEscriba.Text = "Chat finalizado, no es posible enviar un mensaje"
        controladorChat.recargarChat()
        setNombreUsuario(dgvMisChats.CurrentCell.Value)
    End Sub

    Public Sub setNombreUsuario(cedula As String)
        Dim controladorchat As New ControladorChat
        Dim dt As DataTable = controladorchat.getNombreUsr(cedula)

        lblUsuario.Text = dt.Rows.Item(0).Item(0) & " " & dt.Rows.Item(0).Item(1)

    End Sub
End Class