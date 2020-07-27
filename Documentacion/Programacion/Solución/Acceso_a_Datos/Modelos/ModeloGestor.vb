'''<summary>
'''Clase encargada de las consultas pertenecientes a los administradores.
'''</summary>
Public Class ModeloGestor
    Inherits Conexion

    '''<summary>
    '''Consulta encargada de registar a los usuarios administradores del sistema.
    '''</summary>
    Public Function Registrar(cedula As Integer, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Telefonos As ArrayList) As Boolean

        Try
            Command.CommandText = "
            INSERT INTO 
                usuario (cedula, contrasena, pNom, sNom, pApe, sApe) 
            VALUES ('" & cedula & "','" & contraseña & "','" & PrimerNombre & "','" & SegundoNombre & "','" & PrimerApellido & "','" & SegundoApellido & "')"
            Command.ExecuteNonQuery()

            Command.CommandText = "
            INSERT INTO 
                gestor (cedula) 
            VALUES ('" & cedula & "')"
            Command.ExecuteNonQuery()

            For i = 0 To Telefonos.Count - 1

                Command.CommandText = "
                INSERT INTO 
                    usuario_tel (cedula,telefono) 
                VALUES ('" & cedula & "','" & Telefonos(i) & "')"

                Command.ExecuteNonQuery()

            Next

        Catch ex As Exception

            cerrarConexion()
            Return False

        End Try

        cerrarConexion()
        Return True
    End Function

End Class
