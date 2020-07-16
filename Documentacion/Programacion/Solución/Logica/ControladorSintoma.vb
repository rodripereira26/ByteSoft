Imports Acceso_a_Datos
Public Class ControladorSintoma
    Property _nombre As String
    Property _descripcion As String
    Public Sub New(nombre As String, descripcion As String)

        Me._nombre = nombre
        Me._descripcion = descripcion

    End Sub

    Public Function registrar()
        Dim c As New ModeloSintoma
        Return c.Registrar(_nombre, _descripcion)
    End Function

End Class
