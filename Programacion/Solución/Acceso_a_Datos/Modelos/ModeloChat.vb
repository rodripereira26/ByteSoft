Imports System.Data.Odbc

Public Class ModeloChat

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
        parametros.Add(New OdbcParameter("fechaIngreso", DateTime.Now.ToString("yyyy-MM-dd")))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            Return True

        End If

        Return False
    End Function

    Public Function listarChat() As DataTable

        Dim consulta As String = "SELECT DISTINCT cedula, u.idChat 
                            FROM chat c, usuario_entra_chat u, patologia p, paciente_obtiene_diagnostico up 
                            WHERE u.cedula = up.cedulaPaciente AND p.idPatologia = up.idPatologia AND c.idChat = u.idChat AND finalizado = 0
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

End Class
