Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de los médicos.
'''</summary>
Public Class ControladorMedico
    Inherits ControladorUsuario

    Property _especializacion As String

    Public Sub New(ci As String, contraseña As String, pNom As String, Snom As String, PApe As String, SApe As String,
                  especializacion As String)

        MyBase.New(ci, contraseña, pNom, Snom, PApe, SApe)

        Me._ci = ci
        Me._contraseña = contraseña
        Me._primer_nombre = pNom
        Me._segundo_nombre = Snom
        Me._primer_apellido = PApe
        Me._segundo_apellido = SApe
        Me._especializacion = especializacion

    End Sub

    Public Function registrar() As Boolean

        Dim datos As New ModeloMedico

        Return datos.Registrar(_ci, _contraseña, _primer_nombre, _segundo_nombre, _primer_apellido, _segundo_apellido, _especializacion)
    End Function

End Class
