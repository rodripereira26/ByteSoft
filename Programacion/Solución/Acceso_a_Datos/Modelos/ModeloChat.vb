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
                            WHERE u.cedula = up.cedulaPaciente AND p.idPatologia = up.idPatologia AND c.idChat = u.idChat AND finalizado = 0 AND up.fecha = u.fechaIngreso 
                            ORDER BY prioridad ASC "

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)

    End Function

End Class
