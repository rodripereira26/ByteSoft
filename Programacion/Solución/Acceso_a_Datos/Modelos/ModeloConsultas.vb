Imports System.Data.Odbc

''' <summary>
''' Clase base para realizar las consultas.
''' </summary>
Public Class ModeloConsultas

    Private Shared instancia As ModeloConsultas

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloConsultas

        If instancia Is Nothing Then
            instancia = New ModeloConsultas
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de devolver en forma de tabla los valores obtenidos a través de la consulta.
    ''' </summary>
    ''' <param name="Comando"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function ConsultaTabla(Comando As String) As DataTable

        Conexion.Singleton.abrirConexion()

        Dim table As New DataTable
        Dim adapter As New OdbcDataAdapter(Comando, Conexion.Singleton.Connection)
        adapter.Fill(table)

        Conexion.Singleton.cerrarConexion()

        Return table
    End Function

    ''' <summary>
    ''' Función genérica encargada de devolver el dato solicitado por la consulta.
    ''' </summary>
    ''' <param name="Comando"></param>
    ''' <returns>La primera fila afectada por la consulta.</returns>
    Public Function ConsultaCampo(Comando As String)

        Conexion.Singleton.abrirConexion()

        Dim command As New OdbcCommand(Comando, Conexion.Singleton.Connection)
        Dim result As String = command.ExecuteScalar()

        Conexion.Singleton.cerrarConexion()

        Return result
    End Function

    ''' <summary>
    ''' Función encargada de devolver los datos solicitados de una columna en forma de ArrayList.
    ''' </summary>
    ''' <param name="Comando"></param>
    ''' <returns>ArrayList con las filas encontradas en la consulta.</returns>
    Public Function ConsultaArray(Comando As String) As ArrayList

        Conexion.Singleton.abrirConexion()

        Dim array As New ArrayList
        Dim tablaIterar As DataTable = ConsultaTabla(Comando)

        For var As Int32 = 0 To tablaIterar.Rows.Count - 1
            array.Add(tablaIterar.Rows.Item(var).Item(0))
        Next

        Conexion.Singleton.cerrarConexion()

        Return array
    End Function

    ''' <summary>
    ''' Función encargada de ejecutar un insert en la base de datos utilizando OdbcParameters.
    ''' </summary>
    ''' <param name="Comando"></param>
    ''' <param name="Parametros"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function InsertParametros(Comando As String, Parametros As List(Of OdbcParameter)) As Boolean

        Conexion.Singleton.abrirConexion()

        Dim insert As New OdbcCommand(Comando, Conexion.Singleton.Connection)

        For Each parametro In Parametros
            insert.Parameters.Add(parametro)
        Next

        If insert.ExecuteNonQuery() >= 1 Then
            Return True
        End If

        Conexion.Singleton.cerrarConexion()

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de ejecutar un insert en la base de datos.
    ''' </summary>
    ''' <param name="Comando"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function InsertarSinParametros(Comando As String) As Boolean

        Conexion.Singleton.abrirConexion()

        Dim insert As New OdbcCommand(Comando, Conexion.Singleton.Connection)

        If insert.ExecuteNonQuery() >= 1 Then
            Return True
        End If

        Conexion.Singleton.cerrarConexion()

        Return False
    End Function

End Class
