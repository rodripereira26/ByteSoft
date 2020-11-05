Imports Acceso_a_Datos
Imports System.IO

''' <summary>
''' Clase serializable encargada de almacenar la configuración del usuario.
''' </summary>
<Serializable>
Public Class Configuracion

    Private Shared instancia As Configuracion

#Region "Variables"
    Property lenguaje As Idioma
    Property usuario As String
#End Region

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As Configuracion

        If instancia Is Nothing Then
            instancia = New Configuracion
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Subrutina encargada de guardar en disco la configuración del usuario.
    ''' </summary>
    Public Sub GuardarConfiguracion()
        EntradaSalida.Singleton.Serializar(Configuracion.Singleton, Path.Combine(Datos_Temporales.pathConf, "config.cfg"))
    End Sub

    ''' <summary>
    ''' Subrutina encargada de cargar del disco la configuración del usuario.
    ''' </summary>
    Public Sub CargarConfiguracion()
        Configuracion.Singleton.Instanciar(EntradaSalida.Singleton.Deserializar(Path.Combine(Datos_Temporales.pathConf, "config.cfg")))
    End Sub

    ''' <summary>
    ''' Subrutina encargada de instanciar la configuración almacenada en disco.
    ''' </summary>
    ''' <param name="instanciaDisco"></param>
    Public Sub Instanciar(instanciaDisco As Configuracion)
        instancia = instanciaDisco
    End Sub

    ''' <summary>
    ''' Subrutina encargada de setear la conexión a la base de datos.
    ''' </summary>
    Public Sub SetConnection()
        ModeloUsuario.Singleton.SetConnection(Datos_Temporales.rol)
    End Sub

    ''' <summary>
    ''' Función encargada de iterar el archivo CSV que contiene el idioma.
    ''' </summary>
    ''' <param name="archivo"></param>
    ''' <returns>DataTable con la información del idioma.</returns>
    Public Function RecorrerTablaIdioma(archivo As String) As DataTable
        Return EntradaSalida.Singleton.LeerCSV(archivo)
    End Function

    Public Enum Idioma
        es_ES = 0
        en_US = 1
    End Enum

End Class
