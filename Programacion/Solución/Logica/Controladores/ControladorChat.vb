Imports Acceso_a_Datos

Public Class ControladorChat

    Public Function crearChat()

        Dim chat As New ModeloChat
        Dim id As int16 = chat.crearChat

        If id <> 0 Then

            Datos_Temporales.idchat = id
            Return id

        End If

        Return False
    End Function

    Public Function entrarChat(cedula As String, id As Int32)

        Dim chat As New ModeloChat

        Return chat.entrarChat(cedula, id)

    End Function

    Public Function listarChat() As DataTable


        Dim chat As New ModeloChat
        Return chat.listarChat

    End Function

    Public Function enviarMensaje(cedula As String, idchat As Long, mensaje As String, fecha As Date) As Boolean

        Dim chat As New ModeloChat

        If chat.enviarMensaje(cedula, idchat, mensaje, fecha) Then
            Return True
        End If

        Return False
    End Function

    Public Function recargarChat() As DataTable
        Dim chat As New ModeloChat
        Return chat.recargarChat(Datos_Temporales.idchat)
    End Function


End Class
