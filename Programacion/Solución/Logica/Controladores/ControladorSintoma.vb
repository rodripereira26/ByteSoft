Imports Acceso_a_Datos

'''<summary>
'''Clase encargada de los datos de los síntomas.
'''</summary>
Public Class ControladorSintoma

    Property _nombre As String
    Property _descripcion As String

    Private Shared instancia As ControladorSintoma
    Public Shared Function Singleton() As ControladorSintoma
        If instancia Is Nothing Then
            instancia = New ControladorSintoma
        End If
        Return instancia
    End Function

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, descripcion As String)

        Me._nombre = nombre
        Me._descripcion = descripcion

    End Sub

    Public Overloads Function Registrar(tabla As DataTable) As Boolean

        Try
            Return ModeloSintoma.Singleton.Registrar(tabla)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Modificar(nombreViejo As String) As Boolean
        Try
            Return ModeloSintoma.Singleton.Modificar(nombreViejo, _nombre, _descripcion)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function traerInfoSintomas(nombre As String) As String
        Try
            Return ModeloSintoma.Singleton.traerInfoSintoma(nombre)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Overloads Function Registrar() As Boolean
        Try
            Return ModeloSintoma.Singleton.Registrar(_nombre, _descripcion)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Overloads Function traerSintomas(sintomas As ArrayList) As ArrayList
        Try
            Return ModeloSintoma.Singleton.TraerSintomas(sintomas)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function TraerSintomasDePatologia(nombre As String) As DataTable
        Try
            Return ModeloSintoma.Singleton.TraerSintomasDePatologia(nombre)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Overloads Function traerSintomas() As ArrayList
        Try
            Return ModeloSintoma.Singleton.TraerSintomas

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function guardarSintomas(usuario As String, nombreSintoma As ArrayList) As Boolean
        Try
            Return ModeloSintoma.Singleton.GuardarSintomas(usuario, nombreSintoma)
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function listarSintomas() As DataTable

        Try
            Return ModeloSintoma.Singleton.ListarSintomas
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function eliminarSintomas(aliSintomas As ArrayList)

        If ModeloSintoma.Singleton.EliminarSintomas(aliSintomas) Then
            Return True
        End If

        Return False
    End Function
    Public Function getSintomasIndicados(cedula As String) As DataTable
        Try
            Return ModeloSintoma.Singleton.getSintomasIndicados(cedula)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Class
