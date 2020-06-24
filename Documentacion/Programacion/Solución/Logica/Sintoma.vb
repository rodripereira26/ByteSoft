Imports Acceso_a_Datos
Public Class Sintoma
    Property _nombre As String
    Property _descripcion As String
    Public Sub New(nombre As String, descripcion As String)

        Me._nombre = nombre
        Me._descripcion = descripcion

    End Sub

    Public Function agregar()
        Dim c As New Consultas
        Return c.agregarSintoma(_nombre, _descripcion)

    End Function

End Class
