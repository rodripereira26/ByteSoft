Imports Logica
Imports MaterialSkin
Public Class frmLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load


        lblIniciarSesion.Select()
        Principal.Singleton.roundedCorners(Me)

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

                    Datos_Temporales.userLog = txtUsuario.Text

                    Select Case log.verificarRol(txtUsuario.Text)

                        Case "G"
                            frmBienvenidaGestor.Show()
                            txtPassword.Clear()
                            txtUsuario.Clear()
                            Datos_Temporales.rol = "G"
                            Me.hide()

                        Case "P"
                            Dim paciente As New ControladorPaciente

                            If paciente.verificar(txtUsuario.Text) Then
                                frmBienvenidaPaciente.Show()
                                txtPassword.Clear()
                                txtUsuario.Clear()
                                Datos_Temporales.rol = "P"
                                Me.Hide()
                            Else
                                MsgBox("Usted no ha sido habilitado para ingresar al sistema")
                            End If

                        Case "M"
                            frmBienvenidaMedico.Show()
                            txtPassword.Clear()
                            txtUsuario.Clear()
                            Datos_Temporales.rol = "M"
                            Me.Hide()

                        Case Else
                            MsgBox("Error al ingresar")

                    End Select

                Else

                    MsgBox("Usuario o contraseña incorrectos")

                End If

            Else
                MsgBox("Debe ingresar una cédula válida")

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
End Class