Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de los síntomas.
'''</summary>
Public Class ControladorSintoma

    Property _nombre As String
    Property _descripcion As String

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, descripcion As String)

        Me._nombre = nombre
        Me._descripcion = descripcion

    End Sub

    Public Function registrar()

        Dim s As New ModeloSintoma

        Return s.Registrar(_nombre, _descripcion)
    End Function

    Public Function traerSintomas() As ArrayList

        Dim s As New ModeloSintoma

        Return s.traerSintomas
    End Function

    Public Function guardarSintomas(usuario As String, nombreSintoma As ArrayList) As Boolean

        Dim dato As New ModeloSintoma

        Return dato.guardarSintomas(usuario, nombreSintoma)
    End Function

End Class
