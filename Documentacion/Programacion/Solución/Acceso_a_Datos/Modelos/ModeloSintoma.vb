
Public Class ModeloSintoma
    Inherits Conexion

    Public Function Registrar(nombre As String, descripcion As String)
        Command.CommandText = "
        INSERT INTO 
            sintoma (nombre, descripcion) 
        VALUES ('" & nombre & "','" & descripcion & "')"
        Command.ExecuteNonQuery()
    End Function

    Public Function traerSintomas() As ArrayList

        Dim arraySintomas As New ArrayList
        Command.CommandText = "SELECT nombre FROM sintoma"
        Reader = Command.ExecuteReader

        If Reader.HasRows Then
            Dim i = 0
            While Reader.Read
                arraySintomas.Add(Reader.GetString(0))
                i += 1
            End While
        End If

        Return arraySintomas
    End Function

End Class
