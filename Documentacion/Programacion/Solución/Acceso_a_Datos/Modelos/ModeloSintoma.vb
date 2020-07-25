'''<summary>
'''Clase encargada de las consultas pertenecientes a los síntomas.
'''</summary>
Public Class ModeloSintoma
    Inherits Conexion

    '''<summary>
    '''Consulta encargada de registrar los síntomas.
    '''</summary>
    Public Function Registrar(nombre As String, descripcion As String) As Boolean

        Command.CommandText = "
        INSERT INTO 
            sintoma (nombre, descripcion) 
        VALUES ('" & nombre & "','" & descripcion & "')"

        Command.ExecuteNonQuery()

        Return True
    End Function

    '''<summary>
    '''Consulta encargada de obtener los síntomas existentes en la base de datos.
    '''</summary>
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
