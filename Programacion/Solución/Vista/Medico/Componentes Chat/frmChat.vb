Imports Logica

Public Class frmChat

    Private contChat As New ControladorChat
    Private Mensajes As DataTable = contChat.recargarChat

    Private Sub ReloadChat()

        Dim MensajesASetear As New List(Of Mensaje)
        For Each mensaje As DataRow In Mensajes.Rows
            Dim esEmisor As Boolean
            If mensaje.Item(0) = Logica.Datos_Temporales.user_temp Then
                esEmisor = True
            End If
            MensajesASetear.Add(New Vista.Mensaje(esEmisor, mensaje.Item(1), mensaje.Item(2), Nothing))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtMensaje.Text <> "" Then

            If contChat.enviarMensaje(Datos_Temporales.user_temp, Datos_Temporales.idchat, txtMensaje.Text, DateTime.Now.ToString("yyyy-MM-dd 00:00:00")) Then
                ReloadChat()
            Else
                MsgBox("Error al enviar el mensaje")
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ReloadChat()
    End Sub
End Class