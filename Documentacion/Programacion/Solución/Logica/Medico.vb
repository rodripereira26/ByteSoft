Public Class Medico
    Inherits Usuario
    Property _especialidad As String

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String,
                  email As String, telefonos As ArrayList, especialidad As String)

        MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe, email, telefonos)
        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._email = email
        Me._telefonos = telefonos
        Me._especialidad = especialidad
    End Sub
End Class
