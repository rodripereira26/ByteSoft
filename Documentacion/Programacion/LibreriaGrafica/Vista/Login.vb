Public Class Login




    Dim drag As Boolean
        Dim mousex, mousey As Integer


        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

            Label1.Select()
            Dim radio As Integer = 20



            Dim p As New Drawing2D.GraphicsPath()

            p.StartFigure()

            p.AddArc(New Rectangle(0, 0, radio, radio), 180, 90)
            p.AddLine(radio, 0, Me.Width - radio, 0)
            p.AddArc(New Rectangle(Me.Width - radio, 0, radio, radio), -90, 90)
            p.AddLine(Me.Width, radio, Me.Width, Me.Height - radio)
            p.AddArc(New Rectangle(Me.Width - radio, Me.Height - radio, radio, radio), 0, 90)
            p.AddLine(Me.Width - radio, Me.Height, radio, Me.Height)
            p.AddArc(New Rectangle(0, Me.Height - radio, radio, radio), 90, 90)

            p.CloseFigure()

            Me.Region = New Region(p)
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
            Me.Close()
        End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown

    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
            txtPass.Select()
        End Sub

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
            txtUsr.Select()
        End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        End Sub

        Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        End Sub

        Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        End Sub

        Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        End Sub

        Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

        End Sub

        Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
            drag = False
        End Sub


    End Class