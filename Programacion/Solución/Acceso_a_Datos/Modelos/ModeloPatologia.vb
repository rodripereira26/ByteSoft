Imports System.Data.Odbc
'''<summary>
'''Clase encargada de las consultas pertenecientes a las patologías.
'''</summary>
Public Class ModeloPatologia

    '''<summary>
    '''Consulta encargada de registrar las patologías.
    '''</summary>
    Public Function Registrar(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, nomSintomas As ArrayList) As Boolean

        Dim consulta As String = "INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES (?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("nombre", nombre))
        parametros.Add(New OdbcParameter("descripcion", descripcion))
        parametros.Add(New OdbcParameter("recomendacion", recomendacion))
        parametros.Add(New OdbcParameter("prioridad", prioridad))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then

            If RegistrarPatSintomas(nombre, nomSintomas) Then

                Return True

            End If

        End If

        Return False
    End Function

    '''<summary>
    '''Consulta encargada de registrar la asociación de los síntomas y las patologías.
    '''</summary>
    Public Function RegistrarPatSintomas(nombre As String, nomSintomas As ArrayList) As Boolean

        Dim parametros As New List(Of OdbcParameter)
        Dim contador As Int16 = 0
        Dim consulta As String = " 
                    INSERT INTO patologia_contiene_sintoma (idSintoma, idPatologia) VALUES ((SELECT idSintoma FROM sintoma WHERE nombre = ?), (SELECT idPatologia FROM patologia WHERE nombre = ?))"

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

    '''<summary>
    '''Consulta encargada de listar las patologías.
    '''</summary>
    Public Function listarPatologias() As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT nombre AS Nombre, descripcion AS Descripcion, recomendacion AS Recomendacion, prioridad AS Prioridad FROM patologia")
    End Function

    '''<summary>
    '''Consulta encargada de eliminar patologías.
    '''</summary>
    Public Function eliminarPatologias(ali As ArrayList) As Boolean

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

    '''<summary>
    '''Consulta encargada de obtener las patologías asociadas a los síntomas ingresador por el paciente.
    '''</summary>
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

    '''<summary>
    '''Consulta encargada de traer la descripción de las patologías
    '''</summary>
    Public Function informacionPatologia(nombre As String) As String

        Dim consulta As String = "SELECT descripcion FROM patologia WHERE nombre = '" & nombre & "'"

        Return CType(ModeloConsultas.Singleton.ConsultaCampo(consulta), String)
    End Function

    Public Function guardarDiagnosticos(usuario As String, diagnosticos As ArrayList) As Boolean

        Dim consulta As String

        For Each nom In diagnosticos

            consulta = "
                    INSERT INTO paciente_obtiene_diagnostico (cedulaPaciente, idPatologia, fecha) 
                    SELECT " & usuario & ", p.idPatologia, '" & DateTime.Now.ToString("yyyy-MM-dd hh:MM") & "' 
                    FROM patologia p WHERE p.nombre = '" & nom & "'"

            ModeloConsultas.Singleton.InsertarSinParametros(consulta)

        Next

        Return True
    End Function

End Class
