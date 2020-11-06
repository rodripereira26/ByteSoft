Imports Acceso_a_Datos
Imports System.Net.Mail
Imports System.Net

Public Class ControladorChat

    Private Shared instancia As ControladorChat

    Public Shared Function Singleton() As ControladorChat
        If instancia Is Nothing Then
            instancia = New ControladorChat
        End If
        Return instancia
    End Function


    Public Function crearChat() As Boolean

        Try
            Dim id As String = ModeloChat.Singleton.CrearChat(Datos_Temporales.userLog)
            If id <> Nothing Then
                Datos_Temporales.idchat = id
                Return True
            End If
        Catch ex As Odbc.OdbcException
            Return False
        Catch ex As NullReferenceException
            Return False
        End Try

        Return False
    End Function

    Public Function entrarChat(cedula As String, id As Int32)

        Return ModeloChat.Singleton.EntrarChat(cedula, id)

    End Function

    Public Function listarChat() As DataTable

        Return ModeloChat.Singleton.ListarChat(Datos_Temporales.userLog)

    End Function

    Public Function ListarNotificacionChat() As Object
        Try
            Return ModeloChat.Singleton.NotificacionChat(Datos_Temporales.userLog)
        Catch ex As Odbc.OdbcException
            Return Nothing
        End Try
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

    Public Function RecargarChatNuevoMSJ(idMsj) As DataTable

        Return ModeloChat.Singleton.RecargarChatNuevoMSJ(Datos_Temporales.idchat, idMsj)

    End Function

    Public Function obtenerRespuesta() As Int16


        Return ModeloChat.Singleton.ObtenerRespuesta(Datos_Temporales.userLog)

    End Function

    Public Function VerificarMensaje() As Int16

        Return ModeloChat.Singleton.VerificarMensaje(Datos_Temporales.userLog)

    End Function

    Public Function DenegarChat() As Boolean

        Try
            Return ModeloChat.Singleton.DenegarChat(Datos_Temporales.userLog)
        Catch ex As Exception
            Return False
        End Try

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

    Public Overloads Function ListarMisChats(finalizado As Byte) As DataTable

        Return ModeloChat.Singleton.MisChats(Datos_Temporales.userLog, finalizado)

    End Function

    Public Overloads Function ListarMisChats()
        Return ModeloChat.Singleton.MisChats(Datos_Temporales.userLog)
    End Function

    Public Function getNombreUsr(cedula As String) As DataTable
        Return ModeloChat.Singleton.GetNombre(cedula)
    End Function

    Public Function getCorreo() As String
        Return ModeloChat.Singleton.GetCorreo(Datos_Temporales.pacienteSelecionado)
    End Function

    Public Function setFormato() As String

        Dim mensaje As String
        Dim tablaMensaje As DataTable = recargarChat()
        Dim tablaNombre As DataTable
        Dim fecha As Date

        For Each datos As DataRow In tablaMensaje.Rows
            Dim hora As String = ""
            fecha = datos.Item(2)

            If fecha.Hour < 10 Then
                hora = "0" & fecha.Hour().ToString() & ":"
            Else
                hora = fecha.Hour().ToString() & ":"
            End If

            If fecha.Minute < 10 Then
                hora = hora & "0" & fecha.Minute.ToString & ":"
            Else
                hora = hora & fecha.Minute.ToString & ":"
            End If

            If fecha.Second < 10 Then
                hora = hora & "0" & fecha.Second.ToString
            Else
                hora = hora & fecha.Second.ToString
            End If

            tablaNombre = getNombreUsr(datos.Item(0))
            mensaje = mensaje & fecha.Year.ToString & "/" & fecha.Month.ToString & "/" & fecha.Day.ToString & ", " & hora & " - " & tablaNombre.Rows.Item(0).Item(0) & " " & tablaNombre.Rows.Item(0).Item(1) & ": " & datos.Item(1) & vbCrLf
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

    End Function

    Public Function GetMensaje(idChat As Int32) As DataTable
        Return ModeloChat.Singleton.GetMensaje(idChat)
    End Function

    Public Function Notificacion() As DataTable
        Return ModeloChat.Singleton.Notificacion(Datos_Temporales.userLog)
    End Function
    Public Function verificarEstadoChat() As Boolean

        Try
            Dim resultado As Object = ModeloChat.Singleton.verificarEstadoChat(Datos_Temporales.userLog)
            If (resultado = "1") Or (resultado = Nothing) Then
                Return True
            End If
        Catch ex As Odbc.OdbcException
            Return False
        End Try

        Return False
    End Function

    Public Function ObtenerChatPaciente() As Integer
        Try
            Return ModeloChat.Singleton.ObtenerChatPaciente(Datos_Temporales.userLog)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function orden() As DataTable
        Return ModeloChat.Singleton.ordern(Datos_Temporales.userLog)
    End Function
    Public Function enviarObservacion(observacion As String, derivacion As String) As Boolean
        Return ModeloChat.Singleton.enviarObservacion(Datos_Temporales.pacienteSelecionado, Datos_Temporales.userLog, observacion, derivacion)
    End Function
    'Public Function getFotoMedico(cedula As String) As 

    'End Function
End Class
