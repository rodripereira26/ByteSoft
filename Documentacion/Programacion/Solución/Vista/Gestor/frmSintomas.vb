Public Class frmSintomas

    Dim p As New Principal


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Console.WriteLine(Panel1.Location.Y)
        '   p.roundedCorners(Panel1)
        '  p.roundedCorners(Panel2)
        '  p.roundedCorners(Panel4)
        ' p.roundedCorners(Me)

    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel4.Click, Panel1.Click


        'p.enterAnimation(sender)
        'Panel1.Height += 10
        'p.tEnter_Tick()
        'Console.WriteLine("hover")
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs)

    End Sub



    'Private Sub Panel1_MouseEnter_1(sender As Object, e As EventArgs) Handles Panel4.MouseEnter, Panel2.MouseEnter, Panel1.MouseEnter

    '    p.enterAnimation(sender)
    '    p.tEnter_Tick()
    '    Console.WriteLine("hover")
    'End Sub

    'Private Sub Panel1_MouseLeave_1(sender As Object, e As EventArgs) Handles Panel4.MouseLeave, Panel2.MouseLeave, Panel1.MouseLeave

    '    p.leaveAnimation(sender)
    '    p.tleave_Tick()

    'End Sub
End Class
