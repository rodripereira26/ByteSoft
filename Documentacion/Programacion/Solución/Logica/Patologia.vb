Public Class Patologia
    Private _nombre, _descripcion, _recomendacion, _prioridad As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
    Public Property recomendacion() As String
        Get
            Return _recomendacion
        End Get
        Set(ByVal value As String)
            _recomendacion = value
        End Set
    End Property
    Public Property prioridad() As String
        Get
            Return _prioridad
        End Get
        Set(ByVal value As String)
            _prioridad = value
        End Set
    End Property

    Public Sub New(nombre As String, descripcion As String, recomendacion As String, prioridad As String)
        Me.nombre = nombre
        Me.descripcion = descripcion
        Me.recomendacion = recomendacion
        Me.prioridad = prioridad
    End Sub
End Class
