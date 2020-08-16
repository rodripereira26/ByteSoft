Imports Acceso_a_Datos

Public Class Paciente
    Inherits Usuario

    Property _sexo As String
    Property _fecNac As String
    Public Sub New()

    End Sub

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As String,
                   email As String, sexo As String, fecNac As String)

        MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe, telefono, email)
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
    End Sub

    Public Overloads Function agregar()

        Dim datos As New Consultas

        Return datos.registrar_Paciente(_ci, _contraseña, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _telefono, _email, _sexo, _fecNac)
    End Function

End Class
