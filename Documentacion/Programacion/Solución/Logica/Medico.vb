Public Class Medico
    Inherits Usuario
    Private _especialidad As String
    Public Property especialidad() As String
        Get
            Return _especialidad
        End Get
        Set(ByVal value As String)
            _especialidad = value
        End Set
    End Property


    Public Sub New(Cedula As String, PNom As String, SNom As String, PApe As String, SApe As String,
                   email As String, contraseña As String, telefonos As ArrayList, especialidad As String)
        MyBase.New(Cedula, PNom, SNom, PApe, SApe, email, contraseña, telefonos)

        Me.especialidad = especialidad

    End Sub


End Class
