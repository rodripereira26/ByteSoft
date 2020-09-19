Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class Serializacion

    Private Shared instancia As Serializacion

    Public Shared Function Singleton() As Serializacion

        If instancia Is Nothing Then
            instancia = New Serializacion
        End If

        Return instancia
    End Function

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

    Public Function Deserializar(archivo As String) As Object

        Dim stream As New FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.None)
        Dim decodificar As New BinaryFormatter
        Dim clase As Object = Nothing
        clase = CType(decodificar.Deserialize(stream), Object)
        stream.Close()
        Return clase

    End Function

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
