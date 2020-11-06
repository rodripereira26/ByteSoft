Imports Logica
Imports System.IO

''' <summary>
''' User Control encargado de los ajustes del sistema
''' </summary>
Public Class UCAjustes

    Private Shared instancia As UCAjustes

    Public Sub New()
        InitializeComponent()
 For Each var As Control In Me.Controls

            If TypeOf var Is Panel Then

                For Each ctrl As Control In var.Controls

                    ctrl.Text = Principal.Singleton.Idioma(ctrl.Name, ctrl.Text)

                    If TypeOf ctrl Is Panel Then

                        For Each ctrl2 As Control In ctrl.Controls
                            ctrl2.Text = Principal.Singleton.Idioma(ctrl2.Name, ctrl2.Text)

                            If TypeOf ctrl2 Is Panel Then

                                For Each ctrl3 As Control In ctrl2.Controls
                                    ctrl3.Text = Principal.Singleton.Idioma(ctrl3.Name, ctrl3.Text)
                                    If TypeOf ctrl3 Is Panel Then
                                        For Each ctrl4 As Control In ctrl3.Controls
                                            ctrl4.Text = Principal.Singleton.Idioma(ctrl4.Name, ctrl4.Text)

                                            If TypeOf ctrl4 Is Panel Then
                                                For Each ctrl5 As Control In ctrl4.Controls
                                                    ctrl5.Text = Principal.Singleton.Idioma(ctrl5.Name, ctrl5.Text)

                                                Next

                                            End If
                                        Next

                                    End If
                                Next
                            End If
                        Next

                    End If
                Next


            End If

            var.Text = Principal.Singleton.Idioma(var.Name, var.Text)
        Next
    End Sub

    Private Sub UCAjustes_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbIdiomas.SelectedIndex = Configuracion.Singleton.lenguaje ''' Setea el índice del combobox en función al idioma cargado.
    End Sub

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As UCAjustes

        If instancia Is Nothing Then
            instancia = New UCAjustes
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Subrutina encargada de verificar si la tabla de recursos existe.
    ''' </summary>
    Public Sub VerificarArchivo()
        If Datos_Temporales.pathConf IsNot Nothing Then
            If File.Exists(Path.Combine(Datos_Temporales.pathConf, "Idioma.resx")) = False Then
                Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES
                Configuracion.Singleton.GuardarConfiguracion()
                CambiarTabla(Path.Combine(Datos_Temporales.pathConf, "es_ES"))
            End If
        End If
    End Sub
    Private Sub BtnAplicarCambios_Click(sender As Object, e As EventArgs) Handles btnAplicarCambiosAjustes.Click

        Dim bool As Boolean = False
        Dim archivo As Boolean = False

        If Datos_Temporales.pathConf IsNot Nothing Then
            If cbIdiomas.SelectedIndex = Configuracion.Idioma.en_US Then

                If Configuracion.Singleton.lenguaje <> Configuracion.Idioma.en_US Then
                    If File.Exists(Path.Combine(Datos_Temporales.pathConf, "en_US.csv")) Then
                        If PreguntaIdioma() Then
                            bool = True
                            Configuracion.Singleton.lenguaje = Configuracion.Idioma.en_US
                            Configuracion.Singleton.GuardarConfiguracion()
                        End If
                    Else
                        archivo = True
                    End If
                End If

            ElseIf cbIdiomas.SelectedIndex = Configuracion.Idioma.es_ES Then

                If Configuracion.Singleton.lenguaje <> Configuracion.Idioma.es_ES Then
                    If File.Exists(Path.Combine(Datos_Temporales.pathConf, "es_ES.csv")) Then
                        If PreguntaIdioma() Then
                            bool = True
                            Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES
                            Configuracion.Singleton.GuardarConfiguracion()
                        End If
                    Else
                        archivo = True
                    End If
                End If


            End If

            If bool Then
                CargarIdioma()
                Application.Restart()
            End If

            If archivo Then
                MsgBox(principal.singleton.idioma("msgSinIdiomaSeleccionado","No se encuentra el archivo del idioma seleccionado"))
                archivo = False
            End If
        Else
            MsgBox(principal.singleton.idioma("msgNoDirectorioConf","No se encuentra el directorio de configuración"))
        End If


    End Sub

    ''' <summary>
    ''' Subrutina encargada de cargar la tabla de recursos en función al idioma seleccionado.
    ''' </summary>
    Private Sub CargarIdioma()
        If Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES Then
            Me.CambiarTabla(Path.Combine(Datos_Temporales.pathConf, "es_ES"))
        ElseIf Configuracion.Singleton.lenguaje = Configuracion.Idioma.en_US Then
            Me.CambiarTabla(Path.Combine(Datos_Temporales.pathConf, "en_US"))
        End If
    End Sub

    ''' <summary>
    ''' Subrutina encargada de cargar la tabla de recursos.
    ''' </summary>
    ''' <param name="archivo"></param>
    Public Sub CambiarTabla(archivo As String)

        Try
            If Datos_Temporales.pathConf IsNot Nothing Then
                Dim componentes As DataTable = Configuracion.Singleton.RecorrerTablaIdioma(archivo)
                Dim obj As New Resources.ResXResourceWriter(Path.Combine(Datos_Temporales.pathConf, "Idioma.resx"))

                For i As Integer = 0 To componentes.Rows.Count - 1
                    obj.AddResource(componentes.Rows.Item(i).Item(0).ToString, componentes.Rows.Item(i).Item(1).ToString)
                Next

                obj.Close()
            End If
        Catch ex As Exception
            MsgBox(principal.singleton.idioma("msgErrorCargaIdioma","Error al cargar el idioma"))
        End Try

    End Sub

    Public Function PreguntaIdioma() As Boolean

        Dim respuesta As Integer

        respuesta = MsgBox(Principal.Singleton.Idioma("msgPreguntaIdioma", "Debe reiniciar para guardar los cambios"), vbQuestion + vbYesNo + vbDefaultButton2, "")

        If respuesta = vbYes Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
