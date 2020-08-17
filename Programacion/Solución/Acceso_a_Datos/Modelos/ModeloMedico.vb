Imports System.Data.Odbc

'''<summary>
'''Clase encargada de las consultas pertenecientes a los médicos.
'''</summary>
Public Class ModeloMedico

    Private Shared instancia As ModeloMedico

    Public Shared Function Singleton() As ModeloMedico

        If instancia Is Nothing Then
            instancia = New ModeloMedico
        End If

        Return instancia
    End Function

    '''<summary>
    '''Consulta encargada de registar a los usuarios médicos del sistema en la tabla usuarios.
    '''</summary>
    Public Function Registrar(cedula As String, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Especializacion As String) As Boolean

        Dim consulta As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe) VALUES (?,?,?,?,?,?)"

        Dim parametros As New List(Of OdbcParameter)
        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("contrasena", contraseña))
        parametros.Add(New OdbcParameter("pNom", PrimerNombre))
        parametros.Add(New OdbcParameter("sNom", SegundoNombre))
        parametros.Add(New OdbcParameter("pApe", PrimerApellido))
        parametros.Add(New OdbcParameter("sApe", cedula))


        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then

            If RegistrarMedico(cedula, Especializacion) Then

                Return True

            End If

        End If

        Return False
    End Function

    '''<summary>
    '''Consulta encargada de registar a los usuarios médicos del sistema en la tabla medico.
    '''</summary>
    Public Function RegistrarMedico(cedula As String, esp As String) As Boolean

        Dim parametros As New List(Of OdbcParameter)
        Dim consulta As String = "INSERT INTO medico (cedula, especializacion) VALUES (?,?)"
        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("especializacion", esp))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then

            Return True

        End If

        Return False
    End Function

End Class


