Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de los síntomas.
'''</summary>
Public Class ControladorSintoma
    Dim s As New ModeloSintoma
    Property _nombre As String
    Property _descripcion As String

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, descripcion As String)

        Me._nombre = nombre
        Me._descripcion = descripcion

    End Sub

    Public Function registrar() As Boolean
        Return s.Registrar(_nombre, _descripcion)
    End Function

    Public Function traerSintomas() As ArrayList
        Return s.traerSintomas
    End Function

    Public Function guardarSintomas(usuario As String, nombreSintoma As ArrayList) As Boolean
        Return s.guardarSintomas(usuario, nombreSintoma)
    End Function

    Public Function listarSintomas() As DataTable
        Return s.listarSintomas
    End Function

    Public Function eliminarSintomas(aliSintomas As ArrayList)

        If s.eliminarSintomas(aliSintomas) Then
            Return True
        End If

        Return False
    End Function
End Class
