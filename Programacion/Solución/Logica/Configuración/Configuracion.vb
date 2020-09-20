Imports Acceso_a_Datos
Imports System.IO

<Serializable>
Public Class Configuracion

    Private Shared instancia As Configuracion
    Property lenguaje As Idioma
    Property usuario As String
    Public Shared Function Singleton() As Configuracion

        If instancia Is Nothing Then
            instancia = New Configuracion
        End If

        Return instancia
    End Function

    Public Sub Instanciar(instancia1 As Configuracion)
        instancia = instancia1
    End Sub

    Public Sub GuardarConfiguracion()
        Serializacion.Singleton.Serializar(Configuracion.Singleton, Path.Combine(Datos_Temporales.ruta, "config.cfg"))
    End Sub

    Public Sub CargarConfiguracion()
        Configuracion.Singleton.Instanciar(Serializacion.Singleton.Deserializar(Path.Combine(Datos_Temporales.ruta, "config.cfg")))
    End Sub
    Public Sub setConnection()
        ModeloUsuario.Singleton.setConnection(Datos_Temporales.rol)
    End Sub


    Public Enum Idioma
        es_ES = 0
        en_US = 1
    End Enum

    Public Function RecorrerTablaIdioma(archivo As String) As DataTable
        Return Serializacion.Singleton.LeerCSV(archivo)
    End Function

End Class
