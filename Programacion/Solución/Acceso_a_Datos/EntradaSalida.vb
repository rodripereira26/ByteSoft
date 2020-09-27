Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

''' <summary>
''' Clase encargada de administrar la entrada y salida de los datos.
''' </summary>
Public Class EntradaSalida

    Private Shared instancia As EntradaSalida

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As EntradaSalida

        If instancia Is Nothing Then
            instancia = New EntradaSalida
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de serializar en disco un objeto.
    ''' </summary>
    ''' <param name="objeto"></param>
    ''' <param name="archivo"></param>
    ''' <returns>True si se completó la serialización.</returns>
    Public Function Serializar(objeto As Object, archivo As String) As Boolean

        Try
            Dim stream As New FileStream(archivo, FileMode.Create, FileAccess.Write, FileShare.None)
            Dim formatter As New BinaryFormatter

            formatter.Serialize(stream, objeto)
            stream.Close()
            Return True
        Catch
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Función encargada de deserializar del disco un objeto.
    ''' </summary>
    ''' <param name="archivo"></param>
    ''' <returns>Objeto que fue serializado.</returns>
    Public Function Deserializar(archivo As String) As Object

        Dim stream As New FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.None)
        Dim decodificar As New BinaryFormatter
        Dim clase As Object = Nothing

        clase = CType(decodificar.Deserialize(stream), Object)
        stream.Close()

        Return clase
    End Function

    ''' <summary>
    ''' Función encargada de leer el archivo CSV que contiene un idioma.
    ''' </summary>
    ''' <param name="archivo"></param>
    ''' <returns>DataTable con la información del idioma.</returns>
    Public Function LeerCSV(archivo As String) As DataTable

        Dim reader As New StreamReader(archivo & ".csv")
        Dim tabla As New DataTable
        Dim datos As String()

        tabla.Columns.Add("Nombre", GetType(String))
        tabla.Columns.Add("Valor", GetType(String))

        While Not reader.EndOfStream
            Dim linea As String = reader.ReadLine
            datos = Split(linea, ";")
            tabla.Rows.Add(datos)
        End While

        reader.Close()

        Return tabla
    End Function

End Class
