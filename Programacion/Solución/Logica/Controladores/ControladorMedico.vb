Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de los médicos.
'''</summary>
Public Class ControladorMedico
    Inherits ControladorUsuario

    Private Shared instancia As ControladorMedico

    Public Shared Function Singleton() As ControladorMedico
        If instancia Is Nothing Then
            instancia = New ControladorMedico
        End If
        Return instancia
    End Function
    Property _especializacion As String

    Public Sub New()

    End Sub

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String,
                  especializacion As String, email As String, imagen As String)

        MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe, email, imagen)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._especializacion = especializacion
        Me._email = email
        Me._imagen = imagen
    End Sub
    Public Sub New(ci As String, pNom As String, Snom As String, PApe As String, SApe As String, especializacion As String, email As String, imagen As String)
        MyBase.New(ci, pNom, Snom, PApe, SApe, email, imagen)
        Me._ci = ci
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._email = email
        Me._imagen = imagen
        Me._especializacion = especializacion
    End Sub
    'Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String)

    '    MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe)

    '    Me._ci = ci
    '    Me._contraseña = contraseña
    '    Me._primer_nombre = pNom
    '    Me._segundo_nombre = Snom
    '    Me._primer_apellido = PApe
    '    Me._segundo_apellido = SApe


    'End Sub

    Public Function RegistrarMedico() As Boolean
        Try
            Return ModeloMedico.Singleton.RegistrarMedico(_ci, _especializacion)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Overloads Function registrar(tabla As DataTable) As Boolean
        Try
            Return ModeloMedico.Singleton.Registrar(tabla)
        Catch ex As Odbc.OdbcException
            Return False
        End Try
    End Function
    Public Function getInformacionMedico(cedula As String) As String
        Try
            Return ModeloMedico.Singleton.getInformacionMedico(cedula)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function updateMedico(cedula As String) As Boolean
        Try
            Return ModeloMedico.Singleton.updateMedico(cedula, _especializacion)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function verificarPassMedico() As String
        Try
            Return ModeloMedico.Singleton.verificarPassMedico(Datos_Temporales.userLog)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Class
