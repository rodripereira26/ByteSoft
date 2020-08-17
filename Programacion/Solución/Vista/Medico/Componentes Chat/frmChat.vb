Imports Logica

Public Class frmChat

    Private contChat As New ControladorChat
    Private firstUpdate As Boolean = False

    Public Sub New()
        InitializeComponent()

        Dim a As New Principal 'UNA ATROCIDAD
        a.roundedCorners(Button1)
        a.roundedCorners(txtMensaje)
    End Sub

    Private Sub ReloadChat()
        Dim Mensajes As DataTable = contChat.recargarChat

        If Mensajes.Rows.Count <> Chat.Controls.Count Then
            Chat.SuspendLayout()
            Chat.Controls.Clear()

            Dim MensajesASetear As New List(Of Mensaje)
            For Each mensaje As DataRow In Mensajes.Rows
                Dim esEmisor As Boolean = False
                ' MsgBox(mensaje.Item(0).ToString + " " + Datos_Temporales.user_temp.ToString)
                If mensaje.Item(0) = Datos_Temporales.user_temp Then
                    esEmisor = True
                End If
                MensajesASetear.Add(New Vista.Mensaje(esEmisor, mensaje.Item(1), mensaje.Item(2), Nothing))
            Next

            For Each mensaje As Mensaje In MensajesASetear
                'cambiar esta atrocidad

                mensaje.TopLevel = False
                mensaje.Width = Chat.Width - 25
                Chat.Controls.Add(mensaje)
                mensaje.Show()
            Next
            Chat.ResumeLayout()
            Chat.VerticalScroll.Value = Chat.VerticalScroll.Maximum()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ReloadChat()
    End Sub

    Private Sub frmChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Principal
        p.roundedCorners(txtMensaje)

        Chat.AutoScroll = False

        Chat.HorizontalScroll.Enabled = False

        Chat.AutoScroll = True
    End Sub
End Class