'''<summary>
'''Clase encargada de las consultas pertenecientes a los médicos.
'''</summary>
Public Class ModeloMedico
    Inherits Conexion

    '''<summary>
    '''Consulta encargada de registrar a los usuarios médicos.
    '''</summary>
    Public Function Registrar(cedula As Integer, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Telefonos As ArrayList, Especializacion As String) As Boolean

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

        For i = 0 To Telefonos.Count - 1

            Command.CommandText = "
            INSERT INTO 
                usuario_tel (cedula,telefono) 
            VALUES ('" & cedula & "','" & Telefonos.Item(0) & "')"
            Command.ExecuteNonQuery()

        Next

        Return True
    End Function

End Class
