Imports Logica
Imports System.IO

Public Class frmLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Configuracion.Singleton.CargarConfiguracion()
        lblIniciarSesion.Select()
        'Principal.Singleton.roundedCorners(Me)
        CargarUsuario()



    End Sub

    Sub New()

        ObtenerRuta()
        Configuracion.Singleton.CargarConfiguracion()
        VerificarArchivo()
        InitializeComponent()

    End Sub

    Public Sub ObtenerRuta()

        Dim array As New ArrayList
        Dim matriz() As String = Split(Application.StartupPath, "\")
        Dim sec As String

        For i As Int16 = 0 To matriz.Length - 1
            array.Add(matriz.GetValue(i))
        Next

        For i As Int16 = 0 To array.Count - 4
            sec = sec + array.Item(i) + "\"
        Next

        If Directory.Exists(Path.Combine(sec, "Vista\bin\Debug\")) Then
            Datos_Temporales.ruta = Path.Combine(sec, "Vista\bin\Debug\")
        Else
            sec = Nothing
            For i As Int16 = 0 To array.Count - 5
                sec = sec + array.Item(i) + "\"
            Next
            Datos_Temporales.ruta = Path.Combine(sec, "Vista\bin\Debug\")
        End If

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        If txtPassword.Text <> "" Then
            lblContraseña.Visible = False
        End If

    End Sub

    Private Sub txtUsr_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

        If txtUsuario.Text <> "" Then
            lblUsuario.Visible = False
        End If

    End Sub

    Private Sub txtUsr_GotFocus(sender As Object, e As EventArgs) Handles txtUsuario.GotFocus
        lblUsuario.Visible = False
    End Sub

    Private Sub txtPass_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        lblContraseña.Visible = False
    End Sub

    Private Sub txtUsr_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus

        If txtUsuario.Text = "" Then
            lblUsuario.Visible = True
        End If

    End Sub
    Private Sub CargarIdioma()
        If Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES Then
            Me.CambiarTabla(Path.Combine(Datos_Temporales.ruta, "0"))
        ElseIf Configuracion.Singleton.lenguaje = Configuracion.Idioma.en_US Then
            Me.CambiarTabla(Path.Combine(Datos_Temporales.ruta, "1"))

        End If
    End Sub
    Private Sub CargarUsuario()
        If Configuracion.Singleton.usuario <> Nothing Then
            txtUsuario.Text = Configuracion.Singleton.usuario
            mcbRecordarUsuario.Checked = True
        End If
    End Sub
    Private Sub txtPass_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus

        If txtPassword.Text = "" Then
            lblContraseña.Visible = True
        End If

    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles lblCerrar.MouseEnter
        lblCerrar.ForeColor = Color.Red
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles lblCerrar.MouseLeave
        lblCerrar.ForeColor = Color.White
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picContraseña.Click
        txtPassword.Select()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picUsuario.Click
        txtUsuario.Select()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles picIngresar.Click
        ingresarUsuario()
    End Sub

    Private Sub lblCrearCuentaPac_Click(sender As Object, e As EventArgs) Handles lblCrearCuentaPac.Click

        frmRegistroPaciente.Show()
        Me.Hide()

    End Sub

    Private Sub pnlTopBar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseUp
        'Principal.Singleton.moverVentanaUp()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblContraseña.Click

        lblContraseña.Visible = False
        txtPassword.Focus()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblUsuario.Click

        lblUsuario.Visible = False
        txtUsuario.Focus()

    End Sub

    Private Sub pnlTopBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseDown
        'Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub pnlTopBar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseMove
        'Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub ingresarUsuario()

        Dim seg As New Encriptar
        Dim log As New ControladorUsuario
        Dim msgbox1 As New BsMsgbox

        If txtUsuario.Text <> "" And txtPassword.Text <> "" Then

            If IsNumeric(txtUsuario.Text) Then

                If log.verificarUsuario(txtUsuario.Text, seg.HASH256(txtPassword.Text)) Then

                    If mcbRecordarUsuario.Checked Then
                        Configuracion.Singleton.usuario = txtUsuario.Text
                        Configuracion.Singleton.GuardarConfiguracion()
                        'Configuracion.Singleton.CargarConfiguracion()
                    Else
                        Configuracion.Singleton.usuario = Nothing
                        Configuracion.Singleton.GuardarConfiguracion()
                        'Configuracion.Singleton.CargarConfiguracion()
                    End If

                    Datos_Temporales.userLog = txtUsuario.Text

                    Select Case log.verificarRol(txtUsuario.Text)

                        Case "G"
                            frmBienvenidaGestor.Show()
                            txtPassword.Clear()
                            txtUsuario.Clear()
                            Datos_Temporales.rol = "G"
                            Me.Hide()

                        Case "P"
                            Dim paciente As New ControladorPaciente

                            If paciente.verificar(txtUsuario.Text) Then
                                frmBienvenidaPaciente.Show()
                                txtPassword.Clear()
                                txtUsuario.Clear()
                                Datos_Temporales.rol = "P"
                                Me.Hide()
                            Else
                                msgbox1.OnlyText("msgPacienteHabilitado") 'MsgBox(Principal.Singleton.Idioma("msgPacienteHabilitado"))
                                msgbox1.Dispose()
                            End If

                        Case "M"
                            frmBienvenidaMedico.Show()
                            txtPassword.Clear()
                            txtUsuario.Clear()
                            Datos_Temporales.rol = "M"
                            Me.Hide()

                        Case Else
                            msgbox1.OnlyText("msgErrorLogin") 'MsgBox(Principal.Singleton.Idioma("msgErrorLogin"))
                            msgbox1.Dispose()
                    End Select

                Else

                    msgbox1.OnlyText("msgLoginIncorrecto") 'MsgBox(Principal.Singleton.Idioma("msgLoginIncorrecto"))
                    msgbox1.Dispose()
                End If

            Else
                msgbox1.OnlyText("msgCedulaInvalida") 'MsgBox(Principal.Singleton.Idioma("msgCedulaInvalida"),)
                msgbox1.Dispose()
            End If

        Else
            msgbox1.OnlyText(Principal.Singleton.Idioma("msgCamposIncompletos")) 'MsgBox("No completó los campos")
            msgbox1.Dispose()
        End If

    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown, txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            ingresarUsuario()
        End If
    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click


        'Dim respuesta As Integer
        'Dim objeto As New BsMsgbox
        'respuesta = objeto.YesNo()
        'MsgBox(respuesta)
        Dim bool As Boolean = False

        If ing.Checked Then
            If Configuracion.Singleton.lenguaje <> Configuracion.Idioma.en_US Then
                If PreguntaIdioma() Then
                    bool = True
                    Configuracion.Singleton.lenguaje = Configuracion.Idioma.en_US
                    Configuracion.Singleton.GuardarConfiguracion()
                End If
            End If
        ElseIf esp.Checked Then
            If Configuracion.Singleton.lenguaje <> Configuracion.Idioma.es_ES Then
                If PreguntaIdioma() Then
                    bool = True
                    Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES
                    Configuracion.Singleton.GuardarConfiguracion()
                End If
            End If
        End If

        If (ing.Checked Or esp.Checked) And bool = True Then
            CargarIdioma()
            Application.Restart()
        End If

    End Sub

    Public Function PreguntaIdioma() As Boolean
        Dim respuesta As Integer

        respuesta = MsgBox(Principal.Singleton.Idioma("msgPreguntaIdioma"), vbQuestion + vbYesNo + vbDefaultButton2, "")

        If respuesta = vbYes Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub VerificarArchivo()

        If File.Exists(Path.Combine(Datos_Temporales.ruta, "Idioma.resx")) = False Then
            Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES
            Configuracion.Singleton.GuardarConfiguracion()
            CambiarTabla(Path.Combine(Datos_Temporales.ruta, "0"))
        End If
    End Sub

    Public Sub CambiarTabla(archivo As String)

        Dim componentes As DataTable = Configuracion.Singleton.RecorrerTablaIdioma(archivo)
        Dim obj As New Resources.ResXResourceWriter(Path.Combine(Datos_Temporales.ruta, "Idioma.resx")) ' cambiar ruta


        For i As Integer = 0 To componentes.Rows.Count - 1

            obj.AddResource(componentes.Rows.Item(i).Item(0).ToString, componentes.Rows.Item(i).Item(1).ToString)

        Next

        obj.Close()

    End Sub

End Class