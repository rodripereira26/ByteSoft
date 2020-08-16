Imports System.Data.Odbc

'''<summary>
'''Clase encargada de generar la conexión con la base de datos.
'''</summary>
Public Class Conexion

    Private Shared instance As Conexion

    Private Const dsn As String = "driverODBC"
    Private Const Port As String = "3308"
    Private Const DatabaseName As String = "bytesoft_bdd"
    Private Host As String = "localhost"
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

        dblogin(EnumDbLogin.aux, TipoDbLogin.user) = "root"
        dblogin(EnumDbLogin.aux, TipoDbLogin.pass) = "" '1DWbt9hj8xdk3C72

        dblogin(EnumDbLogin.paciente, TipoDbLogin.user) = "sysPac"
        dblogin(EnumDbLogin.paciente, TipoDbLogin.pass) = "dV23UTXFZRbinBz3"

        dblogin(EnumDbLogin.medico, TipoDbLogin.user) = "sysMed"
        dblogin(EnumDbLogin.medico, TipoDbLogin.pass) = "hF69t12lQal6hyiD"

        dblogin(EnumDbLogin.admin, TipoDbLogin.user) = "root"
        dblogin(EnumDbLogin.admin, TipoDbLogin.pass) = "" 'yX4H84ZpgNp07kDy

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

        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If

    End Sub

End Class