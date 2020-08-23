Imports System.Data.Odbc

'''<summary>
'''Clase encargada de generar la conexión con la base de datos.
'''</summary>
Public Class Conexion

    Private Shared instance As Conexion

    Private Const dsn As String = "driverODBC"
    Private Const Port As String = "3306"
    Private Const DatabaseName As String = "bytesoft_bdd2"
    Private Host As String = "bytesoft.duckdns.org"
    Private dblogin(,) As String = New String(4, 2) {}

    Public Property Connection As New OdbcConnection
    Public Command As New OdbcCommand
    Public Property Reader As OdbcDataReader
    Dim Adapter As OdbcDataAdapter

    Public Shared Function Singleton() As Conexion

        If (instance Is Nothing) Then
            instance = New Conexion
        End If

        Return instance
    End Function

    Public Enum EnumDbLogin
        aux
        paciente
        medico
        admin
    End Enum

    Public Enum TipoDbLogin
        user
        pass
    End Enum

    Public Sub New()

        dblogin(EnumDbLogin.aux, TipoDbLogin.user) = "sysAux"
        dblogin(EnumDbLogin.aux, TipoDbLogin.pass) = "sysAuxPass2"

        dblogin(EnumDbLogin.paciente, TipoDbLogin.user) = "sysPac"
        dblogin(EnumDbLogin.paciente, TipoDbLogin.pass) = "sysPacPass2"

        dblogin(EnumDbLogin.medico, TipoDbLogin.user) = "sysMed"
        dblogin(EnumDbLogin.medico, TipoDbLogin.pass) = "sysMedPass2"

        dblogin(EnumDbLogin.admin, TipoDbLogin.user) = "sysGest"
        dblogin(EnumDbLogin.admin, TipoDbLogin.pass) = "sysGestPass2"

    End Sub

    Public Sub SetRolConexion(RolBD As EnumDbLogin)

        Connection = New OdbcConnection(
            "dsn=" + Me.dsn +
            ";UID=" + dblogin(RolBD, TipoDbLogin.user) +
            ";PWD=" + dblogin(RolBD, TipoDbLogin.pass) +
            ";PORT=" + Me.Port +
            ";DATABASE=" + Me.DatabaseName +
            ";SERVER=" + Me.Host
        )

    End Sub

    Public Sub cerrarConexion()
        Me.Connection.Close()
    End Sub

    Public Sub CheckConexion()

        Try
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
        Catch ex As Exception
            Throw New Exception("Error al conectarse a la base de datos")
        End Try

    End Sub

End Class