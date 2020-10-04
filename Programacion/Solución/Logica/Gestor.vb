Public Class Gestor
    Inherits Usuario

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String, telefono As String,
                  email As String)

        MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe, telefono, email)
        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._telefono = telefono
        Me._email = email

    End Sub
End Class
