Imports Acceso_a_Datos

Public Class ControladorChat

    Public Function crearChat()

        Dim chat As New ModeloChat
        dim id as int16 = chat.crearChat

        If id <> 0 Then

            Datos_Temporales.idchat = id
            Return id

        End If

        return false
    End Function




End Class
