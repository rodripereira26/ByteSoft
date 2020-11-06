Imports System.Data.Odbc

'''<summary>
'''Clase encargada de generar la conexión con la base de datos.
'''</summary>
Public Class Conexion

    Private Shared instance As Conexion
    Private dblogin(,) As String = New String(4, 2) {}

#Region "String de Conexión"
    Private Const dsn As String = "driverODBC"
    Private Const Port As String = "3306"
    Private Const DatabaseName As String = "bytesoft_bdd"
    Private Host As String = "bytesoft.duckdns.org"
#End Region

    ''' <summary>
    ''' Objeto encargado de realizar la conexión a la base de datos.
    ''' </summary>
    ''' <returns>La conexión de tipo OdbcConnection.</returns>
    Public Property Connection As New OdbcConnection

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As Conexion

        If (instance Is Nothing) Then
            instance = New Conexion
        End If

        Return instance
    End Function

    ''' <summary>
    ''' Constructor por defecto de la clase.
    ''' </summary>
    Public Sub New()
        ''Auxiliar
        dblogin(EnumDbLogin.aux, TipoDbLogin.user) = "admin"
        dblogin(EnumDbLogin.aux, TipoDbLogin.pass) = "26280259rodrigo"
        ''Paciente
        dblogin(EnumDbLogin.paciente, TipoDbLogin.user) = "admin"
        dblogin(EnumDbLogin.paciente, TipoDbLogin.pass) = "26280259rodrigo"
        ''Médico
        dblogin(EnumDbLogin.medico, TipoDbLogin.user) = "admin"
        dblogin(EnumDbLogin.medico, TipoDbLogin.pass) = "26280259rodrigo"
        ''Gestor
        dblogin(EnumDbLogin.admin, TipoDbLogin.user) = "admin"
        dblogin(EnumDbLogin.admin, TipoDbLogin.pass) = "26280259rodrigo"
    End Sub

    ''' <summary>
    ''' Subrutina encargada de setear una conexión a la base de datos dependiendo del usuario logeado.
    ''' </summary>
    ''' <param name="RolBD"></param>
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

    ''' <summary>
    ''' Subrutina encargada de cerrar la conexión con la base de datos.
    ''' </summary>
    Public Sub cerrarConexion()
        Try
            If Connection.State = ConnectionState.Open Then
                Me.Connection.Close()
            End If
        Catch ex As Exception
            Throw New Exception("Error al conectarse a la base de datos")
        End Try
    End Sub

    ''' <summary>
    ''' Subrutina encargada de abrir la conexión con la base de datos.
    ''' </summary>
    Public Sub abrirConexion()
        Try
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos")
        End Try
    End Sub

#Region "Enum de acceso"
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
#End Region

End Class