Imports Logica
Public Class frmLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label1.Select()
        Principal.Singleton.roundedCorners(Me)

    End Sub


    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

        If txtPass.Text <> "" Then
            Label3.Visible = False
        End If

    End Sub

    Private Sub txtUsr_TextChanged(sender As Object, e As EventArgs) Handles txtUsr.TextChanged

        If txtUsr.Text <> "" Then
            Label2.Visible = False
        End If

    End Sub

    Private Sub txtUsr_GotFocus(sender As Object, e As EventArgs) Handles txtUsr.GotFocus
        Label2.Visible = False
    End Sub

    Private Sub txtPass_GotFocus(sender As Object, e As EventArgs) Handles txtPass.GotFocus
        Label3.Visible = False
    End Sub

    Private Sub txtUsr_LostFocus(sender As Object, e As EventArgs) Handles txtUsr.LostFocus

        If txtUsr.Text = "" Then
            Label2.Visible = True
        End If

    End Sub

    Private Sub txtPass_LostFocus(sender As Object, e As EventArgs) Handles txtPass.LostFocus

        If txtPass.Text = "" Then
            Label3.Visible = True
        End If

    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.Red
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtPass.Select()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txtUsr.Select()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ingresarUsuario()

    End Sub

    Private Sub lblCrearCuentaPac_Click(sender As Object, e As EventArgs) Handles lblCrearCuentaPac.Click

        frmRegistroPaciente.Show()
        Me.Hide()

    End Sub

    Private Sub pnlTopBar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseUp
        Principal.Singleton.moverVentanaUp()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        Label3.Visible = False
        txtPass.Focus()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Label2.Visible = False
        txtUsr.Focus()

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

        If txtUsr.Text <> "" And txtPass.Text <> "" Then

            If IsNumeric(txtUsr.Text) Then

                If log.verificarUsuario(txtUsr.Text, seg.HASH256(txtPass.Text)) Then

                    Datos_Temporales.user_temp = txtUsr.Text

                    Select Case log.verificarRol(txtUsr.Text)

                        Case "G"
                            frmBienvenidaGestor.Show()
                            txtPass.Clear()
                            txtUsr.Clear()
                            Me.Hide()

                        Case "P"
                            Dim paciente As New ControladorPaciente

                            If paciente.verificar(txtUsr.Text) Then
                                frmBienvenidaPaciente.Show()
                                txtPass.Clear()
                                txtUsr.Clear()
                                Me.Hide()
                            Else
                                MsgBox("Usted no ha sido habilitado para ingresar al sistema")
                            End If

                        Case "M"
                            frmBienvenidaMedico.Show()
                            txtPass.Clear()
                            txtUsr.Clear()
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

End Class