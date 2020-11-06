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

    Public Sub New()

    End Sub
    Private Shared instancia As ControladorPatologia

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ControladorPatologia

        If instancia Is Nothing Then
            instancia = New ControladorPatologia
        End If

        Return instancia
    End Function
    Public Sub New(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, sintomas As ArrayList)

        Me._nombre = nombre
        Me._descripcion = descripcion
        Me._recomendacion = recomendacion
        Me._prioridad = prioridad
        Me._sintomas = sintomas

    End Sub

    Public Overloads Function registrar() As Boolean
        Try
            Return ModeloPatologia.Singleton.Registrar(_nombre, _descripcion, _recomendacion, _prioridad, _sintomas)
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function TraerSintomasPatologia(nombre As String) As ArrayList
        Try
            Return ModeloPatologia.Singleton.traerSintomasPatologia(nombre)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function TraerPatologia(nombre As String) As DataTable
        Try
            Return ModeloPatologia.Singleton.traerPatologia(nombre)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function Modificar(nombreViejo As String) As Boolean
        Try
            Return ModeloPatologia.Singleton.Modificar(nombreViejo, _nombre, _descripcion, _recomendacion, _prioridad, _sintomas)
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Overloads Function Registrar(tabla As DataTable, tablaSintoma As DataTable) As Boolean
        Try
            Return ModeloPatologia.Singleton.Registrar(tabla, tablaSintoma)
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function listarPatologias() As DataTable

        Dim dt As DataTable = ModeloPatologia.Singleton.ListarPatologias

        dt.Columns.Add("Prioridad2", GetType(String))

        For Each row As DataRow In dt.Rows


            row.Item(4) = row.Item(3)

        Next
        dt.Columns.Remove(dt.Columns(3))
        dt.Columns(3).ColumnName = "Prioridad"
        'dt.Columns(3).DataType = GetType(String)

        For Each row As DataRow In dt.Rows

            If row.Item(3) = 1 Then
                row.Item(3) = "Alta"
            ElseIf row.Item(3) = 2 Then
                row.Item(3) = "Media"
            ElseIf row.Item(3) = 3 Then
                row.Item(3) = "Baja"
            End If

        Next
        Return dt
    End Function

    Public Function eliminarPatologias(aliPatologias As ArrayList)

        If ModeloPatologia.Singleton.EliminarPatologias(aliPatologias) Then
            Return True
        End If

        Return False
    End Function

    Public Function informacionPatologia(nombre As String) As String
        Try
            Return ModeloPatologia.Singleton.DescripcionPatologia(nombre)
        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Function obtenerPatologia(sintomas As ArrayList) As DataTable
        Try
            Return ModeloPatologia.Singleton.ObtenerDiagnostico(sintomas)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function guardarDiagnostico(usuario As String, nombreDiagnostico As DataTable) As Boolean

        Try
            Return ModeloPatologia.Singleton.GuardarDiagnostico(usuario, nombreDiagnostico)
        Catch ex As Exception
            Return False
        End Try


    End Function

    Public Function VerificarBaja(nombre As String) As Boolean
        Try
            Return ModeloPatologia.Singleton.VerificarBaja(nombre)
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function ReingresarPatologia(nombre As String) As Boolean
        Try
            Return ModeloPatologia.Singleton.ReingresarPatologia(nombre)
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function ReingresarConDatos(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, sintomas As ArrayList) As Boolean
        Try
            Return ModeloPatologia.Singleton.UpdateBajaLogica(nombre, descripcion, recomendacion, prioridad, sintomas)
        Catch ex As Exception
            Return False
        End Try

    End Function

    'Public Function VerificarExistencia(nombre As String) As Boolean
    '    Return ModeloPatologia.Singleton.VerificarExistencia(nombre)
    'End Function
    Public Function traerUltimoDiagnostico(cedula As String) As DataTable
        Try
            Return ModeloPatologia.Singleton.traerUltimoDiagnostico(cedula)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function getPatologiasPaciente(cedula As String) As DataTable
        Try

        Catch ex As Exception

        End Try
        Return ModeloPatologia.Singleton.getPatologiasPaciente(cedula)
    End Function
    Public Function traerDiagnosticoPorId(idDiagnostico As Byte, cedula As String) As DataTable
        Try
            Return ModeloPatologia.Singleton.traerDiagnosticoPorId(idDiagnostico, cedula)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Public Function getTodasPatologias() As ArrayList
        Try
            Return ModeloPatologia.Singleton.getTodasPatologias()
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Class
