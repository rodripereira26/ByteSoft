Imports System.Data.Odbc

Public MustInherit Class Conexion

    Public dsn As String = "driverODBC"
    Public Uid As String = "root"
    Public Pwd As String = ""
    Public Port As String = "3306"
    Public DatabaseName As String = "bdd_proyecto"
    Public Host As String = "localhost"
    'Dim Connect As New OdbcConnection("dsn=driverODBC;uid=root;pwd=;")

    Public Connect As New OdbcConnection(
            "dsn=" + Me.dsn +
            ";UID=" + Me.Uid +
            ";PWD=" + Me.Pwd +
            ";PORT=" + Me.Port +
            ";DATABASE=" + Me.DatabaseName +
            ";SERVER=" + Me.Host
        )

    Public Command As New OdbcCommand
    Public Reader As OdbcDataReader
    Dim Adapter As OdbcDataAdapter
    Public Sub New()

        Me.Connect.Open()
        Me.Command.Connection = Me.Connect
    End Sub


End Class

