Imports Logica
Public Class frmLogin

    Dim drag As Boolean
    Dim mousex, mousey As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label1.Select()
        Dim p As New Principal
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

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txtPass.Select()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txtUsr.Select()
    End Sub


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click


        Dim ver As New Verificacion
        Dim seg As New Encriptar

        If txtUsr.Text <> "" And txtPass.Text <> "" Then
            If ver.verificar(txtUsr.Text, seg.SHA1(txtPass.Text)) = 1 Then
                frmBienvenidaPaciente.Show()
                Me.Hide()
            Else
                MsgBox("Contraseña o usuario incorrectos")
            End If
        End If

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        frmRegistroPaciente.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub


End Class