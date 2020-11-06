Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de los administradores.
'''</summary>
Public Class ControladorGestor
    Inherits ControladorUsuario
    Public Sub New()

    End Sub
    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As ArrayList,
                  email As String, imagen As String)

        MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe, telefono, email, imagen)

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
    Public Sub New(ci As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As ArrayList, email As String, imagen As String)
        MyBase.New(ci, pNom, Snom, PApe, SApe, telefono, email, imagen)
        Me._ci = ci
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = telefono
        Me._email = email
        Me._imagen = imagen

    End Sub
    Public Function getInformacionGestor(cedula As String) As DataTable
        Try
            Return ModeloGestor.Singleton.getInformacionGestor(cedula)
        Catch ex As Exception

        End Try

    End Function

    Public Function Registrar() As Boolean

        Try
            Return ModeloGestor.Singleton.Registrar(_ci, _contraseña, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _email, _imagen, _telefono)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function RegistrarGestor() As Boolean

        Try
            Return ModeloGestor.Singleton.RegistrarGestor(_ci)
        Catch ex As Odbc.OdbcException
            Return False
        End Try

    End Function

    Public Function ListadoHabilitarPac() As DataTable
        Try
            Return ModeloGestor.Singleton.ListadoHabilitarPacientes
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function ListadoHabilitarGest() As DataTable
        Try
            Return ModeloGestor.Singleton.ListadoHabilitarGestores
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function NotificacionListadoPaciente() As Int16

        Try
            Return ModeloGestor.Singleton.NotificacionListadoPaciente
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function NotificacionListadoGestor() As Int16
        Try
            Return ModeloGestor.Singleton.NotificacionListadoGestor
        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Function eliminar(cedula As String) As Boolean
        Try
            Return ModeloGestor.Singleton.Eliminar(cedula)
        Catch ex As Exception
            Return False
        End Try


    End Function

    Public Function HabilitarPacientes(cedula As String) As Boolean
        Try
            Return ModeloGestor.Singleton.HabilitarPaciente(cedula)
        Catch ex As Exception
            Return False
        End Try


    End Function

    Public Function HabilitarGestores(cedula As String) As Boolean
        Try
            Return ModeloGestor.Singleton.HabilitarGestor(cedula)
        Catch ex As Exception
            Return False
        End Try


    End Function

    Public Function verificar(ci As String) As Boolean
        Try
            Return ModeloGestor.Singleton.VerificarEstado(ci)
        Catch ex As Exception
            Return False
        End Try


    End Function

End Class
