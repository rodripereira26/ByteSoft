Imports Logica

Public Class frmLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblIniciarSesion.Select()
        Principal.Singleton.roundedCorners(Me)
        Configuracion.Singleton.CargarConfiguracion()
        CargarUsuario()

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
            Me.CambiarTabla("0")
        ElseIf Configuracion.Singleton.lenguaje = Configuracion.Idioma.en_US Then
            Me.CambiarTabla("1")

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
        Principal.Singleton.moverVentanaUp()
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
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub pnlTopBar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseMove
        Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub ingresarUsuario()

        Dim seg As New Encriptar
        Dim log As New ControladorUsuario

        If txtUsuario.Text <> "" And txtPassword.Text <> "" Then

            If IsNumeric(txtUsuario.Text) Then

                If log.verificarUsuario(txtUsuario.Text, seg.HASH256(txtPassword.Text)) Then

                    If mcbRecordarUsuario.Checked Then
                        Configuracion.Singleton.usuario = txtUsuario.Text
                        Configuracion.Singleton.GuardarConfiguracion()
                        Configuracion.Singleton.CargarConfiguracion()
                    Else
                        Configuracion.Singleton.usuario = Nothing
                        Configuracion.Singleton.GuardarConfiguracion()
                        Configuracion.Singleton.CargarConfiguracion()
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
                                MsgBox(Principal.Singleton.Idioma("msgPacienteHabilitado"))
                            End If

                        Case "M"
                            frmBienvenidaMedico.Show()
                            txtPassword.Clear()
                            txtUsuario.Clear()
                            Datos_Temporales.rol = "M"
                            Me.Hide()

                        Case Else
                            MsgBox(Principal.Singleton.Idioma("msgErrorLogin"))

                    End Select

                Else

                    MsgBox(Principal.Singleton.Idioma("msgLoginIncorrecto"))

                End If

            Else
                MsgBox(Principal.Singleton.Idioma("msgCedulaInvalida"),)

            End If

        Else
            MsgBox("No completó los campos")

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

        If ing.Checked Then
            If PreguntaIdioma() Then
                Configuracion.Singleton.lenguaje = Configuracion.Idioma.en_US
                Configuracion.Singleton.GuardarConfiguracion()
            End If
        ElseIf esp.Checked Then
            If PreguntaIdioma() Then
                Configuracion.Singleton.lenguaje = Configuracion.Idioma.es_ES
                Configuracion.Singleton.GuardarConfiguracion()
            End If
        End If

        If ing.Checked Or esp.Checked Then
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

    Public Sub CambiarTabla(archivo As String)

        Dim componentes As DataTable = Configuracion.Singleton.RecorrerTablaIdioma(archivo)
        Dim obj As New Resources.ResXResourceWriter(".\Idioma.resx") ' cambiar ruta


        For i As Integer = 0 To componentes.Rows.Count - 1

            obj.AddResource(componentes.Rows.Item(i).Item(0).ToString, componentes.Rows.Item(i).Item(1).ToString)

        Next

        obj.Close()

        'Dim obtener As New Resources.ResXResourceReader(".\Idioma.resx")
        'Dim autos As New ArrayList
        'For Each dc As DictionaryEntry In obtener
        '    autos.Add(dc.Value)
        'Next
        'For i As Integer = 0 To autos.Count - 1

        '    Me.lblIniciarSesion.Text = autos.Item(i)
        '    MsgBox(autos.Item(i))
        'Next
        'Dim hola As New Resources.ResXResourceSet(".\Idioma.resx")
        'Me.lblIniciarSesion.Text = hola.GetString("lblIniciarSesion")
        '' MsgBox(hola.GetString("Hola5"))
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles esp.CheckedChanged

    End Sub
End Class