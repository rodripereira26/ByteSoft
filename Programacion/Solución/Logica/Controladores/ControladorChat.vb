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


End Class
