Imports Logica
Imports Guna.UI.WinForms
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
    Public Overloads Sub CambiarTamaño(form As Form)

        Datos_Temporales.vertical = form.Height
        Datos_Temporales.horizontal = form.Width

        If AppPaciente.main.instancia IsNot Nothing Then
            AppPaciente.main.Singleton.cambiarTamaño()
        ElseIf AppMedico.main.instancia IsNot Nothing Then
            AppMedico.main.Singleton.cambiarTamaño()
        ElseIf AppGestion.main.instancia IsNot Nothing Then
            AppGestion.main.Singleton.cambiarTamaño()
        End If

    End Sub

    Public Overloads Sub CambiarTamaño(ancho As Integer, largo As Integer) ''' esto cambia

        Datos_Temporales.vertical = largo
        Datos_Temporales.horizontal = ancho

        If AppPaciente.main.instancia IsNot Nothing Then
            AppPaciente.main.Singleton.cambiarTamaño()
        ElseIf AppMedico.main.instancia IsNot Nothing Then
            AppMedico.main.Singleton.cambiarTamaño()
        ElseIf AppGestion.main.instancia IsNot Nothing Then
            AppGestion.main.Singleton.cambiarTamaño()
        End If

    End Sub

    ''' <summary>
    ''' Función encargada de asignarle un texto a los componentes gráficos en función del idioma seleccionado.
    ''' </summary>
    ''' <param name="name"></param>
    ''' <returns>Texto traducido al idioma seleccionado.</returns>
    Public Function Idioma(name As String, labeltext As String) As String

        If Datos_Temporales.pathConf IsNot Nothing Then
            If File.Exists(Path.Combine(Datos_Temporales.pathConf, "Idioma.resx")) Then
                Dim archivo As New Resources.ResXResourceSet(Path.Combine(Datos_Temporales.pathConf, "Idioma.resx")) ' cambiar ruta

                labeltext = archivo.GetString(name)
                archivo.Close()
            End If
        End If


        Return labeltext
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
                        MsgBox(Idioma("msgSApeXD","Segundo apellido incorrecto"))
                        Return False
                    End If
                Else
                    MsgBox(Idioma("msgSNomXD","Segundo nombre incorrecto"))
                    Return False
                End If
            Else
                MsgBox(Idioma("msgPaPEXD","Primer apellido incorrecto"))
                Return False
            End If
        Else
            MsgBox(Idioma("msgPNomXD","Primer nombre incorrecto"))
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
            MsgBox(Idioma("msgMailIncorrectounu","E-mail incorrecto"))
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
            MsgBox(Idioma("msgPassesDontMatch","Las contraseñas no coinciden"))
            Return False
        End If

        Return False
    End Function
    Public Function verificarFecha(fecha As MaskedTextBox)
        Dim plano As String
        plano = fecha.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

        If plano <> Nothing Then
            Return True
        Else
            Return False
        End If

    End Function
    ''' <summary>
    ''' Función encargada de verificar si los teléfonos ingresados son correctos.
    ''' </summary>
    ''' <param name="dgv"></param>
    ''' <param name="telefonos"></param>
    ''' <returns>True si los teléfonos son correctos.</returns>
    Public Function VerificarTelefonos(dgv As DataGridView, telefonos As ArrayList)


        For Each var As DataGridViewRow In dgv.Rows
            If var.Cells(0).Value <> "" Then
                If Verificacion.Singleton.Verificar_Int(var.Cells(0).Value.ToString) = True Then
                    telefonos.Add(CType(var.Cells(0).Value, Integer))
                Else
                    Return False
                End If

            End If
        Next

        Return True
    End Function

    Public Function Base64(path As String)

        Dim convert64 As String = ""

        If path <> Nothing Then

            Dim stream As New IO.MemoryStream
            Dim bitmap As New Bitmap(path)
            Dim imgFormat As Imaging.ImageFormat = Imaging.ImageFormat.Jpeg

            bitmap.Save(stream, imgFormat)
            convert64 = Convert.ToBase64String(stream.ToArray)

            Return convert64
        Else
            Return convert64
        End If

    End Function

    Public Function Base64ToImage(base64 As String) As Image
        Dim img As Image
        Dim MS As MemoryStream = New MemoryStream
        Dim b64 As String = base64.Replace(" ", "+")
        Dim b() As Byte

        b = Convert.FromBase64String(b64)
        MS = New MemoryStream(b)

        img = Image.FromStream(MS)

        Return img
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
    Public Overloads Sub limpiar(a As Object, b As Object, c As Object, d As Object, e As Object, f As Object, g As Object, h As Object, j As DataGridView, k As ArrayList)
        a.Text = Nothing
        b.Text = Nothing
        c.Text = Nothing
        d.Text = Nothing
        e.Text = Nothing
        f.Text = Nothing
        g.Text = Nothing
        h.Text = Nothing
        j.Rows.Clear()
        k.Clear()
    End Sub

#Region "Funciones y subrutinas"

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
