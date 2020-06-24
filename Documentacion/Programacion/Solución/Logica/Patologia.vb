Imports Acceso_a_Datos
Public Class Patologia

    Property _nombre As String
    Property _descripcion As String
    Property _recomendacion As String
    Property _prioridad As String
    Property _sintomas As ArrayList

    Public Sub New(nombre As String, descripcion As String, recomendacion As String, prioridad As String, sintomas As ArrayList)

        Me._nombre = nombre
        Me._descripcion = descripcion
        Me._recomendacion = recomendacion
        Me._prioridad = prioridad
        Me._sintomas = sintomas
    End Sub


    'Public Function agregar()
    '    Dim c As New Consultas
    '    Return c.agregarPatologia(_nombre, _descripcion, _recomendacion, _prioridad, _sintomas)

    'End Function
    'Public Function buscarSintoma(ali As ArrayList)
    '    Dim c As New Consultas
    '    Return c.traerId(ali)
    'End Function

End Class
