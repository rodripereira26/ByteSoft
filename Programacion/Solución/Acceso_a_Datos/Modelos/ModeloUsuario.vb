Public Class ModeloUsuario

    Private Shared instancia As ModeloUsuario

    Public Shared Function Singleton() As ModeloUsuario

        If instancia Is Nothing Then
            instancia = New ModeloUsuario
        End If

        Return instancia
    End Function

    '''<summary>
    '''Consulta encargada de verificar si el usuario y contraseña ingresados coinciden en la base de datos.
    '''</summary>
    Public Function verificarUsuario(usuario As String, pass As String) As Boolean

        Conexion.Singleton.cerrarConexion()
        Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.aux)

        If ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM usuario WHERE cedula = " & usuario & " and contrasena = '" & pass & "'") = 1 Then

            Return True

        End If

        Return False
    End Function

    '''<summary>
    '''Consulta encargada de verificar a qué tabla pertenece el usuario.
    '''</summary>
    Public Function verificarRol(usuario) As Char

        Dim tabla As Char

        If ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM gestor WHERE cedula = " & usuario) = 1 Then

            tabla = "G"

        End If

        If ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM paciente WHERE cedula = " & usuario) = 1 Then

            tabla = "P"

        End If

        If ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM medico WHERE cedula = " & usuario) = 1 Then

            tabla = "M"

        End If

        Conexion.Singleton.cerrarConexion()
        Select Case tabla

            Case "M"
                Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.medico)
                Conexion.Singleton.CheckConexion()

            Case "P"
                Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.paciente)
                Conexion.Singleton.CheckConexion()

            Case "G"
                Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.admin)
                Conexion.Singleton.CheckConexion()

        End Select

        Return tabla
    End Function


End Class
