Imports Logica
Public Class frmBienvenidaGestor
    Dim drag As Boolean
    Dim mousex, mousey As Integer
    Private Sub BienvenidaGestor_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim p As New Principal
        p.roundedCorners(Me)
        p.roundedCorners(Panel3)
        p.roundedCorners(Panel4)
        p.roundedCorners(Panel1)
        p.roundedCorners(Panel16)
        p.roundedCorners(Panel15)
        p.roundedCorners(Panel14)
        p.roundedCorners(Panel12)
        p.roundedCorners(Panel16)
        p.roundedCorners(Panel5)
        p.roundedCorners(Panel14)

        'Me.BackColor = Color.FromArgb(236, 236, 236)
        'Dim col As Color = Color.FromArgb(52, 73, 94)

        'Panel1.BackColor = Color.WhiteSmoke

        'Panel3.BackColor = Color.WhiteSmoke
        'Panel4.BackColor = Color.WhiteSmoke
        'Panel5.BackColor = Color.WhiteSmoke
        'Panel6.BackColor = Color.FromArgb(236, 236, 236)
        'Panel12.BackColor = Color.WhiteSmoke
        'Panel15.BackColor = Color.WhiteSmoke
        'Panel16.BackColor = Color.WhiteSmoke

        'Label1.ForeColor = col
        'Label2.ForeColor = col
        'Label3.ForeColor = col

        'Label5.ForeColor = col
        'Label6.ForeColor = col
        'Label7.ForeColor = col
        'Label8.ForeColor = col
        'Label9.ForeColor = col
        'Label10.ForeColor = col
        'Label11.ForeColor = col
        'Label12.ForeColor = col
        'Label13.ForeColor = col
        'Label14.ForeColor = col

        'Label16.ForeColor = col
        'Label17.ForeColor = col
        'Label18.ForeColor = col
        'Label19.ForeColor = col
    End Sub
    Private Sub Panel6_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel6.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top


    End Sub

    Private Sub Panel6_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel6.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel6_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel6.MouseUp
        drag = False

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Close()
    End Sub


End Class