Imports System.Data.Odbc

Public Class ConexionBD

    Private Shared conexion As New OdbcConnection("dsn=driverODBC;uid=root;pwd=")
    Private Shared instancia As ConexionBD

    Public Shared Function GetSingleton() As ConexionBD
        If (instancia Is Nothing) Then
            instancia = New ConexionBD
        End If
        Return instancia
    End Function

    Public Sub CrearConexion()
        Conectar()
    End Sub

    Public Function Conectar() As Boolean
        Try
            conexion.Open()
            Return True
        Catch ex As Exception
            conexion.Close()
        End Try
        Return False
    End Function

    Public ReadOnly Property InstanciarConexion() As OdbcConnection
        Get
            Return conexion
        End Get
    End Property

End Class