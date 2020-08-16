Imports System.Data.Odbc
'''<summary>
'''Clase encargada de las consultas pertenecientes a los síntomas.
'''</summary>
Public Class ModeloSintoma

    '''<summary>
    '''Consulta encargada de registrar los síntomas.
    '''</summary>
    Public Function Registrar(nombre As String, descripcion As String) As Boolean

        Dim consulta As String = "INSERT INTO sintoma(nombre, descripcion) VALUES(?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("nombre", nombre))
        parametros.Add(New OdbcParameter("descripcion", descripcion))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then

            Return True

        End If

        Return False
    End Function

    '''<summary>
    '''Consulta encargada de obtener los síntomas existentes en la base de datos.
    '''</summary>
    Public Function traerSintomas() As ArrayList
        Return ModeloConsultas.Singleton.ConsultaArray("SELECT nombre FROM sintoma")
    End Function

    '''<summary>
    '''Consulta encargada de guardar en la base de datos los síntomas seleccionados por el usuario.
    '''</summary>
    Public Function guardarSintomas(usuario As String, nombreSintoma As ArrayList) As Boolean

        Dim consulta As String

        For Each nom In nombreSintoma

            consulta = "
                    INSERT INTO paciente_indica_sintoma (cedula, idSintoma, fechaIngreso) 
                    SELECT " & usuario & ", s.idSintoma, '" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "' 
                    FROM sintoma s WHERE s.nombre = '" & nom & "'"
            ModeloConsultas.Singleton.InsertarSinParametros(consulta)

        Next

        Return True
    End Function

    Public Function listarSintomas() As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT nombre AS Nombre, descripcion AS Descripcion FROM sintoma")
    End Function

    Public Function eliminarSintomas(ali As ArrayList) As Boolean

        Dim valores As String
        Dim consulta As String = "
            DELETE patologia_contiene_sintoma , sintoma  
            FROM patologia_contiene_sintoma  
            INNER JOIN sintoma  
                WHERE patologia_contiene_sintoma.idSintoma = sintoma.idSintoma AND sintoma.nombre IN ("

        For i = 0 To ali.Count - 1

            valores = valores & "'" & ali.Item(i) & "'" & ","
        Next

        consulta = consulta & valores.TrimEnd(",") & ")"

        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then

            Return True

        End If

        Return False
    End Function

End Class
