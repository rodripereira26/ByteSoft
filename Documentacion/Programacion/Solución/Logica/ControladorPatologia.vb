Imports Acceso_a_Datos
Public Class ControladorPatologia

    Property _nombre As String
    Property _descripcion As String
    Property _recomendacion As String
    Property _prioridad As Byte
    Property _sintomas As ArrayList
    Dim p As New ModeloPatologia

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, sintomas As ArrayList)

        Me._nombre = nombre
        Me._descripcion = descripcion
        Me._recomendacion = recomendacion
        Me._prioridad = prioridad
        Me._sintomas = sintomas
    End Sub

    Public Sub registrar()
        p.Registrar(_nombre, _descripcion, _recomendacion, _prioridad, _sintomas)
        ' VERIFICACIONES
    End Sub

    Public Function listarPatologias() As DataTable
        Return p.listarPatologias
    End Function

    Public Function eliminarPatologias(aliPatologias As ArrayList)

        If p.eliminarPatologias(aliPatologias) Then
            Return True
        End If

        Return False
    End Function

    Public Function obtenerPatologia(sintomas As ArrayList) As DataTable
        Return p.obtenerPatologia(sintomas)
    End Function

End Class
