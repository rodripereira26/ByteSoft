''' <summary>
''' Clase encargada de almacenar los datos utilizados en la sesión actual.
''' </summary>
Public Class Datos_Temporales

    ''' <summary>
    ''' Cédula del usuario logeado.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property userLog

    ''' <summary>
    ''' Identificación del chat seleccionado.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property idchat

    ''' <summary>
    ''' Rol del usuario logeado en el sistema.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property rol As enumRol

    ''' <summary>
    ''' Cédula del paciente seleccionado por el médico.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property pacienteSelecionado

    ''' <summary>
    ''' Ruta en la que se encuentran los archivos de configuración del sistema.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property pathConf

    ''' <summary>
    ''' Medida en vertical del tamaño del form actual.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property vertical As Int32

    ''' <summary>
    ''' Medida en horizontal del tamaño del form actual.
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property horizontal As Int32
    Public Enum enumRol
        Paciente = 0
        Medico = 1
        Gestor = 2
    End Enum

End Class
