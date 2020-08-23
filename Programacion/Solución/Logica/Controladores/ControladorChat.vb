Imports Acceso_a_Datos

Public Class ControladorChat

    Public Function crearChat()

        Dim id As Int16 = ModeloChat.Singleton.crearChat

        If id <> 0 Then

            Datos_Temporales.idchat = id
            Return id

        End If

        Return False
    End Function

    Public Function entrarChat(cedula As String, id As Int32)

        Return ModeloChat.Singleton.entrarChat(cedula, id)

    End Function

    Public Function listarChat() As DataTable

        Return ModeloChat.Singleton.listarChat

    End Function

    Public Function enviarMensaje(cedula As String, idchat As Long, mensaje As String, fecha As Date) As Boolean

        If ModeloChat.Singleton.enviarMensaje(cedula, idchat, mensaje, fecha) Then
            Return True
        End If

        Return False
    End Function

    Public Function recargarChat() As DataTable

        Return ModeloChat.Singleton.recargarChat(Datos_Temporales.idchat)

    End Function

    Public Function obtenerRespuesta()

        Return ModeloChat.Singleton.obtenerRespuesta(Datos_Temporales.idchat)

    End Function

    Public Function finalizarChat()

        Return ModeloChat.Singleton.finalizarChat(Datos_Temporales.idchat)

    End Function

    Public Function verificarCedula(idChat As String) As Boolean

        If ModeloChat.Singleton.verificarCedula(Datos_Temporales.user_temp, idChat) = 0 Then
            Return True
        End If

        Return False
    End Function

    Public Function listarMisChats(cedula As String, finalizado As Byte) As DataTable

        Return ModeloChat.Singleton.misChats(cedula, finalizado)

    End Function

    Public Function getNombreUsr(cedula As String) As DataTable
        Return ModeloChat.Singleton.getNombreusr(cedula)
    End Function
End Class
