Imports Logica

Public Class frmChat

    Private contChat As New ControladorChat
    Private firstUpdate As Boolean = False

    Public Sub New()

        InitializeComponent()
        Principal.Singleton.SuperRoundedCorners(txtMensaje)

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



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ReloadChat()
    End Sub

    Private Sub frmChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Principal.Singleton.roundedCorners(txtMensaje)

        Chat.AutoScroll = False

        Chat.HorizontalScroll.Enabled = False

        Chat.AutoScroll = True

    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs)

        Dim respuesta = MsgBox("¿Desea finalizar la sesión de chat?", vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            If contChat.finalizarChat() Then

                Chat.Controls.Clear()
                MsgBox("Sesión finalizada")
                Timer1.Enabled = False

            Else
                MsgBox("Error al finalizar el chat")
            End If

        End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click

        frmListadoChat.Show()
        Me.Dispose()

    End Sub

    Private Sub pbEnviar_Click(sender As Object, e As EventArgs) Handles pbEnviar.Click

        If txtMensaje.Text <> "" Then

            If contChat.enviarMensaje(Datos_Temporales.user_temp, Datos_Temporales.idchat, txtMensaje.Text, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")) Then

                ReloadChat()
                txtMensaje.Clear()
                Chat.VerticalScroll.Value = Chat.VerticalScroll.Maximum()

            Else
                MsgBox("Error al enviar el mensaje")
            End If

        End If
    End Sub

    Private Sub pbCancelar_Click_(sender As Object, e As EventArgs) Handles pbCancelar.Click

        Dim respuesta = MsgBox("¿Desea finalizar la sesión de chat?", vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            If contChat.finalizarChat() Then

                Chat.Controls.Clear()
                MsgBox("Sesión finalizada")
                Timer1.Enabled = False

            Else
                MsgBox("Error al finalizar el chat")
            End If

        End If
    End Sub


End Class