Imports Acceso_a_Datos

'''<summary>
'''Clase principal para los datos de los usuarios.
'''</summary>
Public Class ControladorUsuario

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


    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As ArrayList, email As String)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = telefono
        Me._email = email

    End Sub

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe

    End Sub

    Public Function verificarUsuario(usuario As String, pass As String) As Boolean

        Return ModeloUsuario.Singleton.verificarUsuario(usuario, pass)

    End Function

    Public Function verificarRol(usuario As String)

        Return ModeloUsuario.Singleton.verificarRol(usuario, Datos_Temporales.rol)

    End Function

End Class

