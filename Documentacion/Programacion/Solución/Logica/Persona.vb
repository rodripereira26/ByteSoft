Public Class Persona
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
    Private _Cedula, _PNom, _SApe, _PApe, _SNom As String

    Public Sub New(Cedula As String, PNom As String, SNom As String, PApe As String, SApe As String)
        Me.Cedula = Cedula
        Me.PNom = PNom
        Me.SNom = SNom
        Me.PApe = PApe
        Me.SApe = SApe
    End Sub
End Class
