Imports Acceso_a_Datos
Imports System.Net.Mail
Imports System.Net

Public Class ControladorChat

    Public Function crearChat()

        Dim id As Int16 = ModeloChat.Singleton.CrearChat

        If id <> 0 Then

            Datos_Temporales.idchat = id
            Return id

        End If

        Return False
    End Function

    Public Function entrarChat(cedula As String, id As Int32)

        Return ModeloChat.Singleton.EntrarChat(cedula, id)

    End Function

    Public Function listarChat() As DataTable

        Return ModeloChat.Singleton.ListarChat(Datos_Temporales.userLog)

    End Function

    Public Function enviarMensaje(cedula As String, idchat As Long, mensaje As String, fecha As Date) As Boolean

        If ModeloChat.Singleton.EnviarMensaje(cedula, idchat, mensaje, fecha) Then
            Return True
        End If

        Return False
    End Function

    Public Function recargarChat() As DataTable

        Return ModeloChat.Singleton.RecargarChat(Datos_Temporales.idchat)

    End Function

    Public Function obtenerRespuesta()

        Return ModeloChat.Singleton.ObtenerRespuesta(Datos_Temporales.userLog)

    End Function

    Public Function finalizarChat()

        Return ModeloChat.Singleton.FinalizarChat(Datos_Temporales.idchat)

    End Function

    Public Function verificarCedula(idChat As String) As Boolean

        If ModeloChat.Singleton.VerificarCedula(Datos_Temporales.userLog, idChat) = 0 Then
            Return True
        End If

        Return False
    End Function

    Public Function listarMisChats(cedula As String, finalizado As Byte) As DataTable

        Return ModeloChat.Singleton.MisChats(cedula, finalizado)

    End Function

    Public Function getNombreUsr(cedula As String) As DataTable
        Return ModeloChat.Singleton.GetNombre(cedula)
    End Function

    Public Function getCorreo(cedula As String) As String
        Return ModeloChat.Singleton.GetCorreo(cedula)
    End Function

    Public Function setFormato() As String

        Dim mensaje As String
        Dim tablaMensaje As DataTable = recargarChat()
        Dim tablaNombre As DataTable
        Dim fecha As Date

        For Each datos As DataRow In tablaMensaje.Rows
            fecha = datos.Item(2)
            tablaNombre = getNombreUsr(datos.Item(0))
            mensaje = mensaje & fecha.Year.ToString & "/" & fecha.Month.ToString & "/" & fecha.Day.ToString & ", " & fecha.Hour.ToString & ":" & fecha.Minute.ToString & ":" & fecha.Second.ToString & " - " & tablaNombre.Rows.Item(0).Item(0) & " " & tablaNombre.Rows.Item(0).Item(1) & ": " & datos.Item(1) & vbCrLf
        Next

        Return mensaje
    End Function

    Public Function enviarCorreo(paciente As String, mensaje As String) As Boolean

        Dim correo As New MailMessage()

        Try

            Dim server As New SmtpClient
            correo.Subject = "Historial de chat"
            correo.To.Add(New MailAddress(paciente))
            correo.Body = mensaje

            correo.From = New MailAddress("bytesoftuy@gmail.com")
            server.Credentials = New NetworkCredential("bytesoftuy@gmail.com", "estaeslacontrasenadelproyecto")

            server.Host = "smtp.gmail.com"
            server.Port = 587
            server.EnableSsl = True
            server.Send(correo)
            Return True

        Catch ex As Exception
            Return False
        End Try

        Return False
    End Function

End Class
