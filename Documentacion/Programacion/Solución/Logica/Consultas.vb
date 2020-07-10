Imports AccesoBD
Imports System.Data.Odbc

Public Class Consultas

    Private query As New OdbcCommand
    Private Shared instancia

    Public Shared Function GetSingleton() As Consultas
        If (Instancia Is Nothing) Then
            instancia = New Consultas
        End If
        Return Instancia
    End Function

    Public Function verificarUsuario(usuario As String, pass As String) As Integer
        Return LeerDatos("select count(*) from usuario where cedula = " & usuario & "and contraseña = " & pass)
    End Function
    Public Function buscarEnfermedadesConSintomas() As Integer
        Return LeerDatos("select ")
    End Function
    Public Function ActivarConexion()
        Try
            ConexionBD.GetSingleton.CrearConexion()
            query.Connection = ConexionBD.GetSingleton.InstanciarConexion
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function

    Public Function LeerDatos(consulta As String)
        Try
            ActivarConexion()
            query.Connection = ConexionBD.GetSingleton.InstanciarConexion
            query.CommandText = consulta
            Return query.ExecuteScalar

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
