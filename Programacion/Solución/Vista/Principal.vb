Imports Logica
Imports MaterialSkin
Imports System.IO

''' <summary>
''' Clase principal de la libreria gráfica.
''' </summary>
Public Class Principal

#Region "Variables"
    Private Shared instancia As Principal
    Private drag As Boolean
    Private mousex, mousey As Integer
#End Region

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As Principal

        If instancia Is Nothing Then
            instancia = New Principal
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Subrutina encargada de instanciar un formulario dentro de un panel.
    ''' </summary>
    ''' <param name="ventana"></param>
    ''' <param name="formInterno"></param>
    Public Sub CargarVentana(ventana As Panel, formInterno As Form)
        ventana.Controls.Clear()
        formInterno.TopLevel = False
        formInterno.Dock = DockStyle.Fill
        formInterno.Size = ventana.Size
        ventana.Controls.Add(formInterno)
        formInterno.Show()
    End Sub

    ''' <summary>
    ''' Subrutina encargada de adaptar el tamaño de la aplicación en función del formulario instanciado.
    ''' </summary>
    ''' <param name="form"></param>
    Public Sub CambiarTamaño(form As Form)

        Datos_Temporales.vertical = form.Height
        Datos_Temporales.horizontal = form.Width

        If AppPaciente.main.instancia IsNot Nothing Then
            AppPaciente.main.Singleton.cambiarTamaño()
        ElseIf AppMedico.main.instancia IsNot Nothing Then
            AppMedico.main.Singleton.cambiarTamaño()
        ElseIf AppGestion.main.Singleton.GetInstancia IsNot Nothing Then
            AppGestion.main.Singleton.cambiarTamaño()
        End If

    End Sub

    ''' <summary>
    ''' Función encargada de asignarle un texto a los componentes gráficos en función del idioma seleccionado.
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns>Texto traducido al idioma seleccionado.</returns>
    Public Function Idioma(name As String) As String

        Dim valor As String = "NULL"

        If File.Exists(Path.Combine(Datos_Temporales.pathConf, "Idioma.resx")) Then
            Dim archivo As New Resources.ResXResourceSet(Path.Combine(Datos_Temporales.pathConf, "Idioma.resx")) ' cambiar ruta

            valor = archivo.GetString(name)
            archivo.Close()
        End If

        Return valor
    End Function

    ''' <summary>
    ''' Subrutina encargada de redondear los bordes del formulario.
    ''' </summary>
    ''' <param name="rect"></param>
    Public Sub RoundedCorners(rect As Object)

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

    ''' <summary>
    ''' Función encargada de verificar la cédula ingresada.
    ''' </summary>
    ''' <param name="check"></param>
    ''' <param name="cedula"></param>
    ''' <returns>True si la cédula es correcta.</returns>
    Public Function VerificarCedula(check As Verificacion, cedula As String) As Boolean

        If check.Verificar_Cedula(cedula) Then
            If check.Verificar_Digito(cedula) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de verificar si los string ingresados son correctos.
    ''' </summary>
    ''' <param name="check"></param>
    ''' <param name="pNom"></param>
    ''' <param name="pApe"></param>
    ''' <param name="sNom"></param>
    ''' <param name="sApe"></param>
    ''' <returns>True si los string son correctos.</returns>
    Public Function VerificarString(check As Verificacion, pNom As String, pApe As String, sNom As String, sApe As String) As Boolean

        If check.Verificar_String(pNom) Then
            If check.Verificar_String(pApe) Then
                If IsNumeric(sNom) = False Then
                    If check.Verificar_String(sApe) Then
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

    ''' <summary>
    ''' Función encargada de verificar si el e-mail ingresado es correcto.
    ''' </summary>
    ''' <param name="check"></param>
    ''' <param name="mail"></param>
    ''' <returns>True si el e-mail es correcto.</returns>
    Public Function VerificarEmail(check As Verificacion, mail As String) As Boolean

        If check.VerificarEmail(mail) = False Then
            MsgBox("E-mail incorrecto")
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Función encargada de verificar si las contraseñas ingresadas coinciden.
    ''' </summary>
    ''' <param name="seg"></param>
    ''' <param name="pass1"></param>
    ''' <param name="pass2"></param>
    ''' <returns>True si las contraseñas coinciden</returns>
    Public Function VerificarContraseña(seg As Encriptar, pass1 As String, pass2 As String) As Boolean

        If seg.HASH256(pass1) = seg.HASH256(pass2) Then
            Return True
        Else
            MsgBox("Las contraseñas no coinciden")
            Return False
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de verificar si los teléfonos ingresados son correctos.
    ''' </summary>
    ''' <param name="dgv"></param>
    ''' <param name="telefonos"></param>
    ''' <returns>True si los teléfonos son correctos.</returns>
    Public Function VerificarTelefonos(dgv As DataGridView, telefonos As ArrayList) As Boolean

        For i = 0 To dgv.Rows.Count - 2
            If dgv.Rows(i).Cells(0).Value <> "" Then
                telefonos.Add(dgv.Rows(i).Cells(0).Value)
            End If
        Next

        Return True
    End Function

    ''' <summary>
    ''' Subrutina encargada de limpiar los componentes de la pantalla.
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <param name="c"></param>
    ''' <param name="d"></param>
    ''' <param name="e"></param>
    ''' <param name="f"></param>
    ''' <param name="g"></param>
    ''' <param name="h"></param>
    ''' <param name="j"></param>
    ''' <param name="k"></param>
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


#Region "Funciones y subrutinas"
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
    Public Sub hover(obj As Object)
        obj.BackColor = Color.FromArgb(245, 245, 245)
    End Sub
    Public Sub leave(obj As Object)
        obj.BackColor = Color.White
    End Sub

    'Public Sub SuperRoundedCorners(rect As Object)

    '    Dim gp As New Drawing2D.GraphicsPath()
    '    Dim radio As Integer = 40

    '    gp.StartFigure()
    '    gp.AddArc(New Rectangle(0, 0, radio, radio), 180, 90)
    '    gp.AddLine(radio, 0, rect.Width - radio, 0)
    '    gp.AddArc(New Rectangle(rect.Width - radio, 0, radio, radio), -90, 90)
    '    gp.AddLine(rect.Width, radio, rect.Width, rect.Height - radio)
    '    gp.AddArc(New Rectangle(rect.Width - radio, rect.Height - radio, radio, radio), 0, 90)
    '    gp.AddLine(rect.Width - radio, rect.Height, radio, rect.Height)
    '    gp.AddArc(New Rectangle(0, rect.Height - radio, radio, radio), 90, 90)
    '    gp.CloseFigure()

    '    rect.Region = New Region(gp)

    'End Sub

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
#End Region

End Class
