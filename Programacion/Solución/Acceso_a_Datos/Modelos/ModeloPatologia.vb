Imports System.Data.Odbc

''' <summary>
''' Clase encargada de realizar las consultas de las patologías.
''' </summary>
Public Class ModeloPatologia

    Private Shared instancia As ModeloPatologia

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloPatologia

        If instancia Is Nothing Then
            instancia = New ModeloPatologia
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de registrar las patologías.
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="descripcion"></param>
    ''' <param name="recomendacion"></param>
    ''' <param name="prioridad"></param>
    ''' <param name="nomSintomas"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function Registrar(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, nomSintomas As ArrayList) As Boolean

        Dim consulta As String = "INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES (?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("nombre", nombre))
        parametros.Add(New OdbcParameter("descripcion", descripcion))
        parametros.Add(New OdbcParameter("recomendacion", recomendacion))
        parametros.Add(New OdbcParameter("prioridad", prioridad))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            If RegistrarAsociacion(nombre, nomSintomas) Then
                Return True
            End If
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de registrar la asociación de los síntomas y las patologías.
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <param name="nomSintomas"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function RegistrarAsociacion(nombre As String, nomSintomas As ArrayList) As Boolean

        Dim parametros As New List(Of OdbcParameter)
        Dim contador As Int16 = 0
        Dim consulta As String = "INSERT INTO patologia_contiene_sintoma (idSintoma, idPatologia) 
                                  VALUES ((SELECT idSintoma FROM sintoma WHERE nombre = ?), 
                                  (SELECT idPatologia FROM patologia WHERE nombre = ?))"

        For i As Int16 = 0 To nomSintomas.Count - 1
            parametros.Clear()
            parametros.Add(New OdbcParameter("nombre", nomSintomas.Item(i)))
            parametros.Add(New OdbcParameter("nombre", nombre))

            ModeloConsultas.Singleton.InsertParametros(consulta, parametros)
            contador = +1
        Next

        If contador = nomSintomas.Count Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de listar las patologías.
    ''' </summary>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function ListarPatologias() As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT nombre AS Nombre, descripcion AS Descripcion, recomendacion AS Recomendacion, prioridad AS Prioridad FROM patologia")
    End Function

    ''' <summary>
    ''' Función encargada de eliminar las patologías
    ''' </summary>
    ''' <param name="ali"></param>
    ''' <returns>True si el delete fue realizado.</returns>
    Public Function EliminarPatologias(ali As ArrayList) As Boolean

        Dim valores As String
        Dim consulta As String = "
                                DELETE patologia_contiene_sintoma , patologia  
                                FROM patologia_contiene_sintoma  
                                INNER JOIN patologia  
                                    WHERE patologia_contiene_sintoma.idPatologia = patologia.idPatologia AND
                                    patologia_contiene_sintoma.idPatologia = patologia.idPatologia
                                    AND patologia.nombre IN ("

        For i = 0 To ali.Count - 1
            valores = valores & "'" & ali.Item(i) & "'" & ","
        Next

        consulta = consulta & valores.TrimEnd(",") & ")"

        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de obtener un diagnóstico basado en los síntomas del paciente.
    ''' </summary>
    ''' <param name="sintomas"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function obtenerDiagnostico(sintomas As ArrayList) As DataTable

        Dim parametros As String
        Dim consulta As String = "
                                SELECT p.nombre
                                FROM patologia p, sintoma s, patologia_contiene_sintoma ps
                                WHERE p.idPatologia = ps.idPatologia and s.idSintoma = ps.idSintoma 
                                and s.nombre IN ("

        For i As Integer = 0 To sintomas.Count - 1
            parametros = parametros & "'" & sintomas.Item(i) & "'" & ","
        Next

        consulta = consulta & parametros.TrimEnd(",") & ")"
        consulta = consulta & " GROUP BY ps.idPatologia HAVING count(*) >= " & sintomas.Count & " ORDER BY count(*) desc"

        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)
    End Function

    ''' <summary>
    ''' Función encargada de obtener la descripción de una patología
    ''' </summary>
    ''' <param name="nombre"></param>
    ''' <returns>Descripción de la patología seleccionada</returns>
    Public Function DescripcionPatologia(nombre As String) As String

        Dim consulta As String = "SELECT descripcion FROM patologia WHERE nombre = '" & nombre & "'"

        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), String)
    End Function

    ''' <summary>
    ''' Función encargada de registrar las patologías asociadas a los síntomas del paciente.
    ''' </summary>
    ''' <param name="usuario"></param>
    ''' <param name="diagnosticos"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function GuardarDiagnostico(usuario As String, diagnosticos As ArrayList) As Boolean

        Dim consulta As String

        Try
            For Each nom In diagnosticos
                consulta = "
                    INSERT INTO paciente_obtiene_diagnostico (cedulaPaciente, idPatologia, fecha) 
                    SELECT " & usuario & ", p.idPatologia, '" & DateTime.Now.ToString("yyyy-MM-dd hh:mm") & "' 
                    FROM patologia p WHERE p.nombre = '" & nom & "'"

                ModeloConsultas.Singleton.InsertarSinParametros(consulta)
            Next

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
