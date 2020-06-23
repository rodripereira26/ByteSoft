Public Class Sintoma
    Private _nombre, _descripcion As String

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
    Public Sub New(nombre As String, descripcion As String)

        Me.nombre = nombre
        Me.descripcion = descripcion

    End Sub
End Class
