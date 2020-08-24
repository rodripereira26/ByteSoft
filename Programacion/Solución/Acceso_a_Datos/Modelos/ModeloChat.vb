Imports System.Data.Odbc

Public Class ModeloChat

    Private Shared instancia As ModeloChat

    Public Shared Function Singleton() As ModeloChat

        If instancia Is Nothing Then
            instancia = New ModeloChat
        End If

        Return instancia
    End Function

    Public Function crearChat()

        Dim consulta As String = "INSERT INTO chat (finalizado) VALUES (?)"
        Dim id As String = "SELECT idChat FROM chat ORDER BY idChat DESC LIMIT 1"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("finalizado", 0))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            Return ModeloConsultas.Singleton.ConsultaCampo(id)
        End If

    End Function

    Public Function entrarChat(cedula As String, id As Int32) As Boolean

        Dim consulta As String = "INSERT INTO usuario_entra_chat (cedula, idChat, fechaIngreso) VALUES (?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("idChat", id))
        parametros.Add(New OdbcParameter("fechaIngreso", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            Return True

        End If

        Return False
    End Function

    Public Function listarChat() As DataTable

        Dim consulta As String = "SELECT DISTINCT u.cedula, u.idChat FROM chat c, usuario_entra_chat u, patologia p, paciente_obtiene_diagnostico up, usuario us
                            WHERE u.cedula = up.cedulaPaciente AND p.idPatologia = up.idPatologia AND c.idChat = u.idChat AND us.cedula = u.cedula AND finalizado = 0
                            ORDER BY prioridad ASC "

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)

    End Function

    Public Function enviarMensaje(cedula As String, idChat As Long, mensaje As String, fechaEnvio As Date)

        Dim consulta As String = "INSERT INTO mensaje (cedula, idChat, mensaje, fechaEnvio) VALUES (?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("idChat", idChat))
        parametros.Add(New OdbcParameter("mensaje", mensaje))
        parametros.Add(New OdbcParameter("fechaEnvio", fechaEnvio))

        Return ModeloConsultas.Singleton.InsertParametros(consulta, parametros)
    End Function

    Public Function recargarChat(idChat As Int32) As DataTable
        Dim consulta As String = "SELECT cedula, mensaje, fechaEnvio FROM mensaje WHERE idChat = " + idChat.ToString

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)

    End Function

    Public Function obtenerRespuesta(idChat As Int32) As Int16

        Dim consulta As String = "SELECT count(*) FROM mensaje WHERE idChat =  " + idChat.ToString

        Return ModeloConsultas.Singleton.ConsultaCampo(consulta)
    End Function

    Public Function finalizarChat(idChat As String) As Boolean

        Dim consulta As String = "UPDATE chat SET finalizado = 1 WHERE idChat = " + idChat

        Return ModeloConsultas.Singleton.InsertarSinParametros(consulta)
    End Function

    Public Function verificarCedula(cedula As String, idChat As String) As Int16

        Dim consulta = "SELECT count(*) FROM usuario_entra_chat pc, medico m 
                       WHERE m.cedula = pc.cedula AND pc.cedula = " + cedula + " AND idChat = " + idChat + " AND fechaIngreso = CURRENT_DATE"

        Return ModeloConsultas.Singleton.ConsultaCampo(consulta)
    End Function

    Public Function misChats(cedula As String, finalizado As Byte)
        Dim consulta As String = "SELECT p.cedula, c.idChat FROM paciente p, usuario_entra_chat uc, medico m, chat c WHERE uc.cedula=p.cedula AND c.idChat = uc.idChat AND finalizado = '" & finalizado & "' AND m.cedula = " + cedula
        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function
    Public Function getNombreusr(cedula As String) As DataTable
        Dim consulta As String = "SELECT pNom, pApe FROM usuario WHERE cedula = " & cedula
        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    Public Function getCorreo(cedula As String) As String
        Dim consulta As String = "SELECT correo FROM usuario WHERE cedula = " + cedula
        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), String)
    End Function
End Class
