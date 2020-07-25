Imports Logica
Imports MaterialSkin

Public Class Principal

    'Private WithEvents tEnter As New Timer
    'Private WithEvents tLeave As New Timer
    'Dim obj As New Panel
    Dim drag As Boolean
    Dim mousex, mousey As Integer

    Public Sub roundedCorners(rect As Object)

        Dim gp As New Drawing2D.GraphicsPath()
        Dim radio As Integer = 10

        gp.StartFigure()
        gp.AddArc(New Rectangle(0, 0, radio, radio), 180, 90)
        gp.AddLine(radio, 0, rect.Width - radio, 0)
        gp.AddArc(New Rectangle(rect.Width - radio, 0, radio, radio), -90, 90)
        gp.AddLine(rect.Width, radio, rect.Width, rect.Height - radio)
        gp.AddArc(New Rectangle(rect.Width - radio, rect.Height - radio, radio, radio), 0, 90)
        gp.AddLine(rect.Width - radio, rect.Height, radio, rect.Height)
        gp.AddArc(New Rectangle(0, rect.Height - radio, radio, radio), 90, 90)
        gp.CloseFigure()

        rect.Region = New Region(gp)
    End Sub

    Public Sub darkMode(obj As Object)

    End Sub

    Public Sub lightMode(obj As Object)

    End Sub

    Public Sub hover(obj As Object)

    End Sub

    Public Sub metroStyle(form As MaterialSkin.Controls.MaterialForm)

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(form)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)

    End Sub

    Public Sub moverVentanaDown(form As Form)

        Me.drag = True
        Me.mousex = Cursor.Position.X - form.Left
        Me.mousey = Cursor.Position.Y - form.Top

    End Sub

    Public Sub moverVentanaUp()
        Me.drag = False
    End Sub

    Public Sub moverVentanaMove(form As Form)

        If Me.drag Then

            form.Top = Cursor.Position.Y - mousey
            form.Left = Cursor.Position.X - mousex

        End If

    End Sub

    'Public Sub enterAnimation(obj As Panel)

    '    tEnter.Interval = 100
    '    tEnter.Enabled = True
    '    tEnter.Start()
    '    Me.obj = obj
    'End Sub

    'Public Sub tEnter_Tick() Handles tEnter.Tick
    '    tEnter.Start()
    '    Threading.Thread.Sleep(1)
    '    Console.WriteLine(obj.Location.Y)

    '    tEnter.Stop()

    '    While obj.Location <> New Point(obj.Location.X, 100)
    '        obj.Location = New Point(obj.Location.X, obj.Location.Y - 1)
    '        Threading.Thread.Sleep(1)
    '        Console.WriteLine(obj.Location.Y)
    '    End While
    '    tEnter.Stop()
    'End Sub



    'Public Sub tleave_Tick() Handles tLeave.Tick
    '    tLeave.Start()

    '    While obj.Location <> New Point(obj.Location.X, 209)
    '        obj.Location = New Point(obj.Location.X, obj.Location.Y + 1)
    '        Threading.Thread.Sleep(1)

    '    End While
    '    tLeave.Stop()

    'End Sub

    'Public Sub leaveAnimation(obj As Panel)

    '    tLeave.Interval = 100
    '    tLeave.Enabled = True
    '    tLeave.Start()
    '    Me.obj = obj
    'End Sub

End Class
