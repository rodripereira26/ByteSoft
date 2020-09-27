''' <summary>
''' Clase encargada de realizar las consultas de los usuarios.
''' </summary>
Public Class ModeloUsuario

    Private Shared instancia As ModeloUsuario

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloUsuario

        If instancia Is Nothing Then
            instancia = New ModeloUsuario
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de verificar si el usuario y la contraseña ingresados por el usuario son correctos.
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="pass"></param>
    ''' <returns>True si coinciden las credenciales.</returns>
    Public Function VerificarUsuario(usuario As String, pass As String) As Boolean

        Conexion.Singleton.cerrarConexion()
        Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.aux)

        If ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM usuario WHERE cedula = " & usuario & " and contrasena = '" & pass & "'") = 1 Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de verificar si el rol al que el usuario quiere acceder es correcto.
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="rol"></param>
    ''' <returns>True si el rol es correcto.</returns>
    Public Function verificarRol(usuario As String, rol As Int16)
        Select Case rol
            Case 0
                If CType(ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM paciente WHERE cedula = " & usuario), Int16) = 1 Then
                    Return True
                End If

            Case 1
                If CType(ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM medico WHERE cedula = " & usuario), Int16) = 1 Then
                    Return True
                End If

            Case 2
                If CType(ModeloConsultas.Singleton.ConsultaCampo("SELECT count(*) FROM gestor WHERE cedula = " & usuario), Int16) = 1 Then
                    Return True
                End If
        End Select

        Return False
    End Function

    ''' <summary>
    ''' Subrutina encargada de setear una conexión en función del usuario logeado.
    ''' </summary>
    ''' <param name="rol"></param>
    Public Sub SetConnection(rol As Int16)
        Select Case rol
            Case 0
                Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.paciente)
                Conexion.Singleton.abrirConexion()

            Case 1
                Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.medico)
                Conexion.Singleton.abrirConexion()

            Case 2
                Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.admin)
                Conexion.Singleton.abrirConexion()
        End Select
    End Sub

End Class
