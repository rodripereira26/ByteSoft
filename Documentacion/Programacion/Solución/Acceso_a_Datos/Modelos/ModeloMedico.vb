'''<summary>
'''Clase encargada de las consultas pertenecientes a los médicos.
'''</summary>
Public Class ModeloMedico
    Inherits Conexion

    '''<summary>
    '''Consulta encargada de registrar a los usuarios médicos.
    '''</summary>
    Public Function Registrar(cedula As Integer, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Especializacion As String) As Boolean

        Try
            Command.CommandText = "
            INSERT INTO 
                usuario (cedula, contrasena, pNom, sNom, pApe, sApe) 
            VALUES ('" & cedula & "','" & cedula & "','" & PrimerNombre & "','" & SegundoNombre & "','" & PrimerApellido & "','" & SegundoApellido & "')"
            Command.ExecuteNonQuery()

            Command.CommandText = "
            INSERT INTO 
                medico (cedula, especializacion) 
            VALUES ('" & cedula & "','" & Especializacion & "')"
            Command.ExecuteNonQuery()

        Catch ex As Exception

            cerrarConexion()
            Return False

        End Try

        cerrarConexion()
        Return True
    End Function

End Class
