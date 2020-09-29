Imports Logica
Imports System.IO

Public Class frmLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Configuracion.Singleton.CargarConfiguracion()
        lblIniciarSesion.Select()
        CargarUsuario()
    End Sub
    Sub New()
        ObtenerRuta()
        Configuracion.Singleton.CargarConfiguracion()
        VerificarArchivo()
        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        Principal.Singleton.CambiarTamaño(Me)
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
            Datos_Temporales.pathConf = Path.Combine(sec, "Vista\bin\Debug\")
        Else
            sec = Nothing
            For i As Int16 = 0 To array.Count - 5
                sec = sec + array.Item(i) + "\"
            Next
        End If

        If Directory.Exists(Path.Combine(sec, "Vista\bin\Debug\")) Then
            Datos_Temporales.pathConf = Path.Combine(sec, "Vista\bin\Debug\")
        Else
            sec = Nothing
            For i As Int16 = 0 To array.Count - 6
                sec = sec + array.Item(i) + "\"
            Next
            Datos_Temporales.pathConf = Path.Combine(sec, "Vista\bin\Debug\")
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
            Me.CambiarTabla(Path.Combine(Datos_Temporales.pathConf, "0"))
        ElseIf Configuracion.Singleton.lenguaje = Configuracion.Idioma.en_US Then
            Me.CambiarTabla(Path.Combine(Datos_Temporales.pathConf, "1"))
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
        Dim frm As New frmRegistroPaciente
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmRegistroPaciente)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub
    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblContraseña.Click
        lblContraseña.Visible = False
        txtPassword.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblUsuario.Click
        lblUsuario.Visible = False
        txtUsuario.Focus()
    End Sub

    Private Sub pnlTopBar_MouseDown(sender As Object, e As MouseEventArgs)
        'Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub pnlTopBar_MouseMove(sender As Object, e As MouseEventArgs)
        'Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub ingresarUsuario()

        Dim seg As New Encriptar
        Dim log As New ControladorUsuario
        Dim msgbox1 As New BsMsgbox

        If txtUsuario.Text <> "" And txtPassword.Text <> "" Then
            If IsNumeric(txtUsuario.Text) Then
                If log.verificarUsuario(txtUsuario.Text, seg.HASH256(txtPassword.Text)) And log.verificarRol(txtUsuario.Text) Then

                    If mcbRecordarUsuario.Checked Then
                        Configuracion.Singleton.usuario = txtUsuario.Text
                        Configuracion.Singleton.GuardarConfiguracion()
                    Else
                        Configuracion.Singleton.usuario = Nothing
                        Configuracion.Singleton.GuardarConfiguracion()
                    End If

                    Datos_Temporales.userLog = txtUsuario.Text


                    Select Case Datos_Temporales.rol

                        Case Datos_Temporales.enumRol.Paciente
                            Dim paciente As New ControladorPaciente

                            If paciente.verificar(txtUsuario.Text) Then
                                Dim frm As New frmBienvenidaPaciente
                                Configuracion.Singleton.SetConnection()
                                Me.SuspendLayout()
                                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                                Principal.Singleton.CambiarTamaño(frmBienvenidaPaciente)
                                frm.Show()
                                pnlContenedor.Hide()
                                pnlInstancia.Show()
                                Me.ResumeLayout()
                            Else
                                MsgBox(Principal.Singleton.Idioma("msgPacienteHabilitado"))
                            End If

                        Case Datos_Temporales.enumRol.Gestor
                            Dim frm As New frmBienvenidaGestor
                            Configuracion.Singleton.SetConnection()
                            Me.SuspendLayout()
                            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                            Principal.Singleton.CambiarTamaño(frmBienvenidaGestor)
                            frm.Show()
                            pnlContenedor.Hide()
                            pnlInstancia.Show()
                            Me.ResumeLayout()

                        Case Datos_Temporales.enumRol.Medico
                            Dim frm As New frmBienvenidaMedico
                            Configuracion.Singleton.SetConnection()
                            Me.SuspendLayout()
                            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                            Principal.Singleton.CambiarTamaño(frmBienvenidaMedico)
                            frm.Show()
                            pnlContenedor.Hide()
                            pnlInstancia.Show()
                            Me.ResumeLayout()

                    End Select

                Else

                    MsgBox(Principal.Singleton.Idioma("msgLoginIncorrecto"))

                End If

            Else
                MsgBox(Principal.Singleton.Idioma("msgCedulaInvalida"))
            End If

        Else
            MsgBox(Principal.Singleton.Idioma("msgCamposIncompletos"))

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
    Public Sub mostrarhola()
        MsgBox("asdjasikdnjasokjdnasodnaskd")
    End Sub
    Public Sub VerificarArchivo()

        If File.Exists(Path.Combine(Datos_Temporales.pathConf, "Idioma.resx")) = False Then
            Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES
            Configuracion.Singleton.GuardarConfiguracion()
            CambiarTabla(Path.Combine(Datos_Temporales.pathConf, "0"))
        End If
    End Sub

    Public Sub CambiarTabla(archivo As String)

        Dim componentes As DataTable = Configuracion.Singleton.RecorrerTablaIdioma(archivo)
        Dim obj As New Resources.ResXResourceWriter(Path.Combine(Datos_Temporales.pathConf, "Idioma.resx")) ' cambiar ruta


        For i As Integer = 0 To componentes.Rows.Count - 1

            obj.AddResource(componentes.Rows.Item(i).Item(0).ToString, componentes.Rows.Item(i).Item(1).ToString)

        Next

        obj.Close()

    End Sub

End Class