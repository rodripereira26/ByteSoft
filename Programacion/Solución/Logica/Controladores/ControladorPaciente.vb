Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de los pacientes.
'''</summary>
Public Class ControladorPaciente
    Inherits ControladorUsuario

    Property _sexo As String
    Property _fecNac As String

    Private Shared instancia As ControladorPaciente

    Public Shared Function Singleton() As ControladorPaciente
        If instancia Is Nothing Then
            instancia = New ControladorPaciente
        End If
        Return instancia
    End Function
    Public Sub New()

    End Sub

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As ArrayList,
                   email As String, sexo As String, fecNac As String, imagen As String)

        MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe, telefono, email, imagen)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = telefono
        Me._email = email
        Me._fecNac = fecNac
        Me._sexo = sexo

        If imagen <> Nothing Then
            Me._imagen = imagen
        Else
            Me._imagen = ""
        End If

    End Sub
    Public Sub New(ci As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As ArrayList,
                   email As String, sexo As String, fecNac As String, imagen As String)

        MyBase.New(ci, pNom, Snom, PApe, SApe, telefono, email, imagen)

        Me._ci = ci
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = telefono
        Me._email = email
        Me._fecNac = fecNac
        Me._sexo = sexo

        If imagen <> Nothing Then
            Me._imagen = imagen
        Else
            Me._imagen = ""
        End If

    End Sub

    Public Function RegistrarPaciente() As Boolean

        Try
            Return ModeloPaciente.Singleton.RegistrarPaciente(_ci, _sexo, _fecNac)
        Catch ex As Odbc.OdbcException
            Return False
        End Try

    End Function



    Public Function verificar(ci As String) As Boolean
        Try
            Return ModeloPaciente.Singleton.VerificarEstado(ci)
        Catch ex As Exception
            Return False
        End Try


    End Function
    Public Function getDatosPacientePerfil(cedula As String) As DataTable

        Try
            Return ModeloPaciente.Singleton.GetDatosPacientePerfil(cedula)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function getDatosPacienteFicha(cedula As String) As DataTable
        Try
            Return ModeloPaciente.Singleton.GetDatosPacienteFicha(cedula)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function getPatologiasCronicas(ci As String) As DataTable
        Try
            Return ModeloPaciente.Singleton.GetPatologiasCronicas(ci)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function getHistorialConsultas(ci As String) As DataTable
        Try
            Return ModeloPaciente.Singleton.GetHistorialConsultas(ci)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function updatePaciente(cedula As String) As Boolean
        Try
            Return ModeloPaciente.Singleton.updatePaciente(_ci, _sexo, _fecNac)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function updatePatologiasPaciente(cedula As String, patologias As ArrayList) As Boolean
        Try
            Return ModeloPaciente.Singleton.updatePatologiasPaciente(cedula, patologias)
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function IngresarPatologias(patologias As ArrayList) As Boolean
        Try
            Return ModeloPaciente.Singleton.RegistrarPatologias(_ci, patologias)
        Catch ex As Odbc.OdbcException
            Return False
        End Try
    End Function
End Class
