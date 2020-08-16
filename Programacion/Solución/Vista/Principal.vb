﻿Imports Logica
Imports MaterialSkin

Public Class Principal

    Private drag As Boolean
    Private mousex, mousey As Integer

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

    Public Function verificarCedula(check As Verificacion, cedula As String) As Boolean

        If check.verificar_cedula(cedula) Then

            If check.verificar_digito(cedula) Then

                Return True

            Else
                Return False

            End If
        Else
            Return False

        End If

        Return False
    End Function

    Public Function verificarString(check As Verificacion, pNom As String, pApe As String, sNom As String, sApe As String) As Boolean

        If check.verificar_string(pNom) Then

            If check.verificar_string(pApe) Then

                If IsNumeric(sNom) = False Then

                    If check.verificar_string(sApe) Then

                        Return True

                    Else
                        MsgBox("Segundo apellido incorrecto")
                        Return False

                    End If

                Else
                    MsgBox("Segundo nombre incorrecto")
                    Return False

                End If
            Else
                MsgBox("Primer apellido incorrecto")
                Return False

            End If
        Else
            MsgBox("Primer nombre incorrecto")
            Return False

        End If

        Return False
    End Function

    Public Function verificarEmail(check As Verificacion, mail As String) As Boolean

        If check.verificar_email(mail) = False Then

            MsgBox("Email incorrecto")
            Return False

        End If

        Return True
    End Function

    Public Function verificarContraseña(seg As Encriptar, pass1 As String, pass2 As String) As Boolean

        If seg.HASH256(pass1) = seg.HASH256(pass2) Then

            Return True

        Else
            MsgBox("Las contraseñas no coinciden")
            Return False

        End If

        Return False
    End Function

    Public Function verificarTelefonos(dgv As DataGridView, telefonos As ArrayList) As Boolean

        For i = 0 To dgv.Rows.Count - 2

            If dgv.Rows(i).Cells(0).Value <> "" Then

                telefonos.Add(dgv.Rows(i).Cells(0).Value)

            End If

        Next

        Return True
    End Function

    Public Sub limpiar(a As TextBox, b As TextBox, c As TextBox, d As TextBox, e As TextBox, f As TextBox, g As TextBox, h As TextBox, j As DataGridView, k As ArrayList)

        a.Clear()
        b.Clear()
        c.Clear()
        d.Clear()
        e.Clear()
        f.Clear()
        g.Clear()
        h.Clear()
        j.Rows.Clear()
        k.Clear()

    End Sub

    Public Sub darkMode(obj As Object)

    End Sub

    Public Sub lightMode(obj As Object)

    End Sub

    Public Sub hover(obj As Object)

        obj.BackColor = Color.FromArgb(245, 245, 245)

    End Sub
    Public Sub leave(obj As Object)

        obj.BackColor = Color.White

    End Sub


    Public Sub metroStyle(form As MaterialSkin.Controls.MaterialForm)

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(form)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange100, TextShade.WHITE)

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
