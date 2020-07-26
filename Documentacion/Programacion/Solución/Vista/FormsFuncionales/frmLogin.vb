Imports Logica
Public Class frmLogin

    Dim drag As Boolean
    Dim mousex, mousey As Integer
    Dim p As New Principal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label1.Select()
        p.roundedCorners(Me)

    End Sub

    'Private Sub timer1_tick(sender As Object, e As EventArgs) Handles ti.Tick
    '    If Label2.Location <> New Point(60, 169) Then
    '        Label2.Location = New Point(Label2.Location.X + 1, Label2.Location.Y)
    '    End If
    'End Sub

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

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        frmRegistroPaciente.Show()
        Me.Dispose()

    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub

    'Public Sub AsignarRol(rol As Integer)

    '    Select Case rol
    '        Case 1
    '            lbl_rol.Text = "Adminstrador"
    '        Case 2
    '            lbl_rol.Text = "Paciente"
    '        Case 3
    '            lbl_rol.Text = "Médico"
    '    End Select

    '    Me.Show()

    'End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        Label3.Visible = False
        txtPass.Focus()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Label2.Visible = False
        txtUsr.Focus()

    End Sub

    Private Sub ingresarUsuario()

        Dim seg As New Encriptar
        Dim log As New Usuario

        If txtUsr.Text <> "" And txtPass.Text <> "" Then

            If IsNumeric(txtUsr.Text) Then

                If log.verificarUsuario(txtUsr.Text, seg.HASHSHA2566(txtPass.Text)) Then

                    Datos_Temporales.user_temp = txtUsr.Text

                    Select Case log.verificarRol(txtUsr.Text)

                        Case "Gestor"
                            frmBienvenidaGestor.Show()
                            Me.Hide()

                        Case "Paciente"
                            frmBienvenidaPaciente.Show()
                            Me.Hide()

                        Case "Medico"
                            frmBienvenidaMedico.Show()
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

    'Public Sub CargarVentana(ventana As Panel, form As Form, rol As Integer)

    '    form.TopLevel = False
    '    form.Dock = DockStyle.Fill
    '    ventana.Size = Me.Size
    '    ventana.Controls.Add(form)
    '    AsignarRol(rol)
    '    form.Show()

    'End Sub

End Class