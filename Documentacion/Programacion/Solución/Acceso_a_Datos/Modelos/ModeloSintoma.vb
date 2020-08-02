'''<summary>
'''Clase encargada de las consultas pertenecientes a los síntomas.
'''</summary>
Public Class ModeloSintoma
    Inherits Conexion

    '''<summary>
    '''Consulta encargada de registrar los síntomas.
    '''</summary>
    Public Function Registrar(nombre As String, descripcion As String) As Boolean

        Try
            Command.CommandText = "
            INSERT INTO 
                sintoma (nombre, descripcion) 
            VALUES ('" & nombre & "','" & descripcion & "')"
            Command.ExecuteNonQuery()

        Catch ex As Exception

            cerrarConexion()
            Return False

        End Try

        cerrarConexion()
        Return True
    End Function

    '''<summary>
    '''Consulta encargada de obtener los síntomas existentes en la base de datos.
    '''</summary>
    Public Function traerSintomas() As ArrayList

        Dim arraySintomas As New ArrayList
        abrirConexion()
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

        Catch ex As Exception

            cerrarConexion()
            Return False

        End Try

        cerrarConexion()
        Return True
    End Function
    Public Function listarSintomas() As DataTable

        Dim dt As New DataTable
        Command.CommandText = "SELECT nombre AS Nombre, descripcion AS Descripcion FROM sintoma"

        dt.Load(Command.ExecuteReader())

        cerrarConexion()
        Return dt
    End Function
    Public Function eliminarSintomas(ali As ArrayList) As Boolean

        Dim parametros As String
        Dim consulta As String = "
            DELETE patologia_contiene_sintoma , sintoma  
            FROM patologia_contiene_sintoma  
            INNER JOIN sintoma  
                WHERE patologia_contiene_sintoma.idSintoma = sintoma.idSintoma AND               
                AND sintoma.nombre IN ("

        For i = 0 To ali.Count - 1

            parametros = parametros & "'" & ali.Item(i) & "'" & ","
        Next

        consulta = consulta & parametros.TrimEnd(",") & ")"

        Command.CommandText = consulta
        Command.ExecuteNonQuery()

        cerrarConexion()
        Return True
    End Function
End Class
