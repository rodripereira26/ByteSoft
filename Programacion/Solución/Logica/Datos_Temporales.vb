
Public Class Datos_Temporales

    ''' <summary>
    ''' Cédula del usuario logeado
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property userLog
    Public Shared Property idchat
    Public Shared Property rol As enumRol
    Public Shared Property pacienteSelecionado
    Public Shared Property ruta
    Public Shared Property vertical As Int32
    Public Shared Property horizontal As Int32

    Public Enum enumRol
        Paciente = 0
        Medico = 1
        Gestor = 2
    End Enum


End Class
