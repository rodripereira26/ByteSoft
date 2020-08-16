Imports System.Data.Odbc

Public Class ModeloConsultas

    Private Shared instancia As ModeloConsultas

    Public Shared Function Singleton() As ModeloConsultas

        If instancia Is Nothing Then
            instancia = New ModeloConsultas
        End If

        Return instancia
    End Function

    Public Function ConsultaTabla(Comando As String) As DataTable

        Conexion.Singleton.CheckConexion()
        Dim table As New DataTable
        Dim adapter As New OdbcDataAdapter(Comando, Conexion.Singleton.Connection)
        adapter.Fill(table)

        Return table
    End Function

    Public Function ConsultaCampo(Comando As String)

        Conexion.Singleton.CheckConexion()
        Dim command As New OdbcCommand(Comando, Conexion.Singleton.Connection)

        Return command.ExecuteScalar()
    End Function

    Public Function ConsultaArray(Comando As String) As ArrayList

        Conexion.Singleton.CheckConexion()
        Dim array As New ArrayList

        Dim tablaIterar As DataTable = ConsultaTabla(Comando)

        For var As Int32 = 0 To tablaIterar.Rows.Count - 1
            array.Add(tablaIterar.Rows.Item(var).Item(0))
        Next

        Return array
    End Function

    Public Function InsertParametros(Comando As String, Parametros As List(Of OdbcParameter)) As Boolean

        Conexion.Singleton.CheckConexion()
        Dim insert As New OdbcCommand(Comando, Conexion.Singleton.Connection)

        For Each parametro In Parametros
            insert.Parameters.Add(parametro)
        Next

        If insert.ExecuteNonQuery() >= 1 Then
            Return True
        End If

        Return False
    End Function

    Public Function InsertarSinParametros(Comando As String) As Boolean

        Conexion.Singleton.CheckConexion()
        Dim insert As New OdbcCommand(Comando, Conexion.Singleton.Connection)

        If insert.ExecuteNonQuery() >= 1 Then
            Return True
        End If

        Return False
    End Function

End Class
