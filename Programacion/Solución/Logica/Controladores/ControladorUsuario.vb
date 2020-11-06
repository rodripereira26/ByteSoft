Imports Acceso_a_Datos

'''<summary>
'''Clase principal para los datos de los usuarios.
'''</summary>
Public Class ControladorUsuario

    Private Shared instancia As ControladorUsuario

    Public Shared Function Singleton() As ControladorUsuario
        If instancia Is Nothing Then
            instancia = New ControladorUsuario
        End If
        Return instancia
    End Function

    Public Sub New()

    End Sub

    Property _ci As String
    Property _contraseña As String
    Property _primer_nombre As String
    Property _primer_apellido As String
    Property _segundo_nombre As String
    Property _segundo_apellido As String
    Property _telefono As ArrayList
    Property _email As String
    Property _imagen As String


    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As ArrayList, email As String, imagen As String)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = telefono
        Me._email = email
        Me._imagen = imagen

    End Sub

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, email As String, imagen As String)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._email = email
        Me._imagen = imagen
    End Sub
    Public Sub New(ci As String, pNom As String, Snom As String, PApe As String, SApe As String, email As String, imagen As String)

        Me._ci = ci
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._email = email
        Me._imagen = imagen
    End Sub
    Public Sub New(ci As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As ArrayList, email As String, imagen As String)

        Me._ci = ci
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = telefono
        Me._email = email
        Me._imagen = imagen

    End Sub

    'Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String) CONSTRUCTOR SIN EMAIL PARA MEDICO??

    '    Me._ci = ci
    '    Me._contraseña = contraseña
    '    Me._primer_nombre = pNom
    '    Me._segundo_nombre = Snom
    '    Me._primer_apellido = PApe
    '    Me._segundo_apellido = SApe

    'End Sub

    Public Function RegistarUsuario() As Boolean
        Try
            Return ModeloUsuario.Singleton.Registrar(_ci, _contraseña, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _email, _imagen)
        Catch ex As Odbc.OdbcException
            Return False
        End Try
    End Function

    Public Function RegistrarTelefonos() As Boolean

        Try
            Return ModeloUsuario.Singleton.RegistrarTelefonos(_ci, _telefono)
        Catch ex As Odbc.OdbcException
            Return False
        End Try

    End Function
    Public Function verificarUsuario(usuario As String, pass As String) As Boolean
        Try
            Return ModeloUsuario.Singleton.VerificarUsuario(usuario, pass)
        Catch ex As Exception
            Return False
        End Try


    End Function

    Public Function verificarRol(usuario As String) As Boolean
        Try
            Return ModeloUsuario.Singleton.verificarRol(usuario, Datos_Temporales.rol)

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function VerificarBaja(cedula As String) As Boolean
        Try
            Return ModeloUsuario.Singleton.VerificarBaja(cedula)
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function ReingresarUsuario(cedula As String) As Boolean
        Try
            Return ModeloUsuario.Singleton.ReingresarUsuario(cedula)
        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Function getTelefonosUsuario() As DataTable
        Try
            Return ModeloUsuario.Singleton.getTelefonosPaciente(Datos_Temporales.userLog)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function ListarUsuarios() As DataTable
        Try
            Return ModeloUsuario.Singleton.listarUsuarios
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function getDatosUsuario(cedula As String) As DataTable
        Try
            Return ModeloUsuario.Singleton.getDatosUsuario(cedula)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function updateUsuario() As Boolean
        Try
            Return ModeloUsuario.Singleton.updateUsuario(_ci, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _email, _imagen)
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Function
    Public Function updateTelefonos(alitel As ArrayList) As Boolean
        Try
            Return ModeloUsuario.Singleton.updateTelefonos(_ci, alitel)
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function GetContraseña() As String

        Try
            Return ModeloUsuario.Singleton.GetContraseña(Datos_Temporales.userLog)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function UpdateContrasena(contrasena As String) As Boolean
        Try
            Return ModeloUsuario.Singleton.UpdateContraseña(Datos_Temporales.userLog, contrasena)
        Catch ex As odbc.OdbcException
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

End Class

