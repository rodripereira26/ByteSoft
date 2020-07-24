Imports Acceso_a_Datos
Public Class ControladorSintoma
    Property _nombre As String
    Property _descripcion As String
    Public Sub New()

    End Sub
    Public Sub New(nombre As String, descripcion As String)

        Me._nombre = nombre
        Me._descripcion = descripcion

    End Sub

    '''<summary>
    '''Función encargada de registrar los síntomas en la base de datos.
    '''</summary>
    Public Function registrar()
        Dim s As New ModeloSintoma
        Return s.Registrar(_nombre, _descripcion)
    End Function

    '''<summary>
    '''Función encargada de traer los síntomas ingresados en la base de datos.
    '''</summary>
    Public Function traerSintomas() As ArrayList
        Dim s As New ModeloSintoma
        Return s.traerSintomas
    End Function


End Class
