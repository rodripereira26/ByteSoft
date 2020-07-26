Public Class ModeloUsuario
    Inherits Conexion

    '''<summary>
    '''Consulta encargada de verificar si el usuario y contraseña ingresados coinciden en la base de datos.
    '''</summary>
    Public Function verificarUsuario(usuario As String, pass As String) As Boolean

        Command.CommandText = "SELECT count(*) FROM usuario WHERE cedula = " & usuario & " and contrasena = '" & pass & "'"
        Reader = Command.ExecuteReader

        If Reader.HasRows Then

            If Reader.GetInt16(0) = 1 Then

                cerrarConexion()
                Return True

            End If

            cerrarConexion()
        End If

        cerrarConexion()
        Return False
    End Function

    '''<summary>
    '''Consulta encargada de verificar a qué tabla pertenece el usuario.
    '''</summary>
    Public Function verificarRol(usuario) As String

        Dim tabla As String

        Command.CommandText = "SELECT count(*) FROM gestor WHERE cedula = " & usuario
        Reader = Command.ExecuteReader

        If Reader.HasRows Then

            If Reader.GetInt16(0) = 1 Then

                cerrarConexion()
                tabla = "Gestor"
                Return tabla

            End If

            cerrarConexion()
        End If

        Command.CommandText = "SELECT count(*) FROM paciente WHERE cedula = " & usuario
        abrirConexion()
        Reader = Command.ExecuteReader

        If Reader.HasRows Then

            If Reader.GetInt16(0) = 1 Then

                cerrarConexion()
                tabla = "Paciente"
                Return tabla

            End If

            cerrarConexion()
        End If

        Command.CommandText = "SELECT count(*) FROM medico WHERE cedula = " & usuario
        abrirConexion()
        Reader = Command.ExecuteReader

        If Reader.HasRows Then

            If Reader.GetInt16(0) = 1 Then

                cerrarConexion()
                tabla = "Medico"
                Return tabla

            End If

            cerrarConexion()
        End If

        Return tabla
    End Function


End Class
