
Public Class Paciente
    Inherits Usuario
    Private _edad As Integer
    Private _sexo As Char
    Private _fotoPerfil As Byte()

    Public Property edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property
    Public Property sexo() As Char
        Get
            Return _sexo
        End Get
        Set(ByVal value As Char)
            _sexo = value
        End Set
    End Property
    Public Property fotoPerfil() As Byte()
        Get
            Return _fotoPerfil
        End Get
        Set(ByVal value As Byte())
            _fotoPerfil = value
        End Set
    End Property

    Public Sub New(Cedula As String, PNom As String, SNom As String, PApe As String, SApe As String,
                   edad As Integer, email As String, contraseña As String, sexo As Char, fotoPerfil As Byte(), telefonos As ArrayList)
        MyBase.New(Cedula, PNom, SNom, PApe, SApe, email, contraseña, telefonos)
        Me.sexo = sexo
        Me.edad = edad
        Me.fotoPerfil = fotoPerfil
    End Sub

End Class
