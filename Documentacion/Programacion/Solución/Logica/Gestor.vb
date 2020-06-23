Public Class Gestor
    Inherits Usuario
    Public Sub New(Cedula As String, PNom As String, SNom As String, PApe As String, SApe As String,
                   email As String, contraseña As String, telefonos As ArrayList)
        MyBase.New(Cedula, contraseña, PNom, SNom, PApe, SApe, email, telefonos)
    End Sub

End Class
