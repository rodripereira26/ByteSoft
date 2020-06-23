Public Class Usuario
    Private _Cedula, _PNom, _SApe, _PApe, _SNom As String
    Private _telefonos As ArrayList
    Private _email, _contraseña As String

    Public Property Cedula() As String
        Get
            Return _Cedula
        End Get
        Set(ByVal value As String)
            _Cedula = value
        End Set
    End Property
    Public Property PNom() As String
        Get
            Return _PNom
        End Get
        Set(ByVal value As String)
            _PNom = value
        End Set
    End Property
    Public Property SNom() As String
        Get
            Return _SNom
        End Get
        Set(ByVal value As String)
            _SNom = value
        End Set
    End Property
    Public Property PApe() As String
        Get
            Return _PApe
        End Get
        Set(ByVal value As String)
            _PApe = value
        End Set
    End Property
    Public Property SApe() As String
        Get
            Return _SApe
        End Get
        Set(ByVal value As String)
            _SApe = value
        End Set
    End Property
    Public Property telefonos() As ArrayList
        Get
            Return _telefonos
        End Get
        Set(ByVal value As ArrayList)
            _telefonos = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Public Property contraseña() As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            _contraseña = value
        End Set
    End Property
    Public Sub New(Cedula As String, PNom As String, SNom As String, PApe As String,
                   SApe As String, email As String, contraseña As String, telefonos As ArrayList)
        Me.Cedula = Cedula
        Me.PNom = PNom
        Me.SNom = SNom
        Me.PApe = PApe
        Me.SApe = SApe
        Me.email = email
        Me.contraseña = contraseña
        Me.telefonos = telefonos
    End Sub
End Class
