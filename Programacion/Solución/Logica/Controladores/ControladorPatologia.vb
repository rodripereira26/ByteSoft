Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de las patologías.
'''</summary>
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

    Public Function registrar() As Boolean
        Return p.Registrar(_nombre, _descripcion, _recomendacion, _prioridad, _sintomas)
    End Function

    Public Function listarPatologias() As DataTable
        Return p.listarPatologias
    End Function

    Public Function eliminarPatologias(aliPatologias As ArrayList)

        If p.eliminarPatologias(aliPatologias) Then
            Return True
        End If

        Return False
    End Function

    Public Function informacionPatologia(nombre As String) As String
        Return p.informacionPatologia(nombre)
    End Function

    Public Function obtenerPatologia(sintomas As ArrayList) As DataTable

        Return p.obtenerDiagnostico(sintomas)

    End Function

    Public Function guardarDiagnostico(usuario As String, nombreDiagnostico As ArrayList) As Boolean
        Return p.guardarDiagnosticos(usuario, nombreDiagnostico)
    End Function

End Class
