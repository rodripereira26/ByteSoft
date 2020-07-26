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
        cerrarConexion()

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

        cerrarConexion()

        Return arraySintomas
    End Function

    '''<summary>
    '''Consulta encargada de guardar en la base de datos los síntomas seleccionados por el usuario.
    '''</summary>
    Public Function guardarSintomas(usuario As String, nombreSintoma As ArrayList) As Boolean

        Try

            For Each nom In nombreSintoma

                Command.CommandText = "
                    INSERT INTO paciente_indica_sintoma (cedula, idSintoma, fechaIngreso) 
                    SELECT " & usuario & ", s.idSintoma, '" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "' 
                    FROM sintoma s WHERE s.nombre = '" & nom & "'"
                Command.ExecuteNonQuery()

            Next

            cerrarConexion()
            Return True

        Catch ex As Exception

            cerrarConexion()
            Return False

        End Try

    End Function

End Class
