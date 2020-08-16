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

End Class
