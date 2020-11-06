Imports Logica

Public Class frmObtenerDiagnostico

    Dim sin As New ControladorSintoma
    Dim pat As New ControladorPatologia
    Dim contador As Integer = 0
    Dim solicitud As Boolean = True
    Dim lista As New List(Of UCDiagnnostico)
    Public Shared listado As Opcion
    Private boton As Short
    Private cedPaciente As String

    Private Sub frmObtenerDiagnostico_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Public Sub New()

        InitializeComponent()
        For Each var As Control In Me.Controls

            If TypeOf var Is Panel Then

                For Each ctrl As Control In var.Controls

                    ctrl.Text = Principal.Singleton.Idioma(ctrl.Name, ctrl.Text)

                    If TypeOf ctrl Is Panel Then

                        For Each ctrl2 As Control In ctrl.Controls
                            ctrl2.Text = Principal.Singleton.Idioma(ctrl2.Name, ctrl2.Text)

                            If TypeOf ctrl2 Is Panel Then

                                For Each ctrl3 As Control In ctrl2.Controls
                                    ctrl3.Text = Principal.Singleton.Idioma(ctrl3.Name, ctrl3.Text)
                                    If TypeOf ctrl3 Is Panel Then
                                        For Each ctrl4 As Control In ctrl3.Controls
                                            ctrl4.Text = Principal.Singleton.Idioma(ctrl4.Name, ctrl4.Text)

                                            If TypeOf ctrl4 Is Panel Then
                                                For Each ctrl5 As Control In ctrl4.Controls
                                                    ctrl5.Text = Principal.Singleton.Idioma(ctrl5.Name, ctrl5.Text)

                                                Next

                                            End If
                                        Next

                                    End If
                                Next
                            End If
                        Next

                    End If
                Next


            End If

            var.Text = Principal.Singleton.Idioma(var.Name, var.Text)
        Next
    End Sub

    Public Sub New(patologias As DataTable, boton As Short)


        InitializeComponent()

        For Each var As Control In Me.Controls

            If TypeOf var Is Panel Then

                For Each ctrl As Control In var.Controls

                    ctrl.Text = Principal.Singleton.Idioma(ctrl.Name, ctrl.Text)

                    If TypeOf ctrl Is Panel Then

                        For Each ctrl2 As Control In ctrl.Controls
                            ctrl2.Text = Principal.Singleton.Idioma(ctrl2.Name, ctrl2.Text)

                            If TypeOf ctrl2 Is Panel Then

                                For Each ctrl3 As Control In ctrl2.Controls
                                    ctrl3.Text = Principal.Singleton.Idioma(ctrl3.Name, ctrl3.Text)
                                    If TypeOf ctrl3 Is Panel Then
                                        For Each ctrl4 As Control In ctrl3.Controls
                                            ctrl4.Text = Principal.Singleton.Idioma(ctrl4.Name, ctrl4.Text)

                                            If TypeOf ctrl4 Is Panel Then
                                                For Each ctrl5 As Control In ctrl4.Controls
                                                    ctrl5.Text = Principal.Singleton.Idioma(ctrl5.Name, ctrl5.Text)

                                                Next

                                            End If
                                        Next

                                    End If
                                Next
                            End If
                        Next

                    End If
                Next


            End If

            var.Text = Principal.Singleton.Idioma(var.Name, var.Text)
        Next

        Me.boton = boton
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        listado = Opcion.paciente

        btnSoliChat.Text = Principal.Singleton.Idioma("lblSex1", "Ver síntomas ingresados")
        btnSoliChat.Width += 40
        btnSoliChat.Location = New Point(btnSoliChat.Location.X - 40, btnSoliChat.Location.Y)
        btnSoliChat.Image = Nothing
        btnSoliChat.TextAlign = HorizontalAlignment.Center
        lblTitulo.Text = Principal.Singleton.Idioma("lblDiagnosticosdeLafecha", "Mis diagnósticos de la fecha ")
        lblTitulo.Location = New Point((Me.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y)
        setPatologias(patologias)
        btnSoliChat.Visible = False

    End Sub

    Public Sub New(patologias As DataTable, boton As Short, cedula As String)

        InitializeComponent()

        For Each var As Control In Me.Controls

            If TypeOf var Is Panel Then

                For Each ctrl As Control In var.Controls

                    ctrl.Text = Principal.Singleton.Idioma(ctrl.Name, ctrl.Text)

                    If TypeOf ctrl Is Panel Then

                        For Each ctrl2 As Control In ctrl.Controls
                            ctrl2.Text = Principal.Singleton.Idioma(ctrl2.Name, ctrl2.Text)

                            If TypeOf ctrl2 Is Panel Then

                                For Each ctrl3 As Control In ctrl2.Controls
                                    ctrl3.Text = Principal.Singleton.Idioma(ctrl3.Name, ctrl3.Text)
                                    If TypeOf ctrl3 Is Panel Then
                                        For Each ctrl4 As Control In ctrl3.Controls
                                            ctrl4.Text = Principal.Singleton.Idioma(ctrl4.Name, ctrl4.Text)

                                            If TypeOf ctrl4 Is Panel Then
                                                For Each ctrl5 As Control In ctrl4.Controls
                                                    ctrl5.Text = Principal.Singleton.Idioma(ctrl5.Name, ctrl5.Text)

                                                Next

                                            End If
                                        Next

                                    End If
                                Next
                            End If
                        Next

                    End If
                Next


            End If

            var.Text = Principal.Singleton.Idioma(var.Name, var.Text)
        Next

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        listado = Opcion.medico
        Me.cedPaciente = cedula

        Me.boton = boton
        setPatologias(patologias)
        btnSoliChat.Text = Principal.Singleton.Idioma("btnverSintomasLugarchat", "Ver síntomas ")
        btnSoliChat.Width += 40
        btnSoliChat.Location = New Point(btnSoliChat.Location.X - 40, btnSoliChat.Location.Y)
        btnSoliChat.Image = Nothing
        btnSoliChat.TextAlign = HorizontalAlignment.Center
        lblTitulo.Text = Principal.Singleton.Idioma("lblTitilDiagnosticosGenerados", "Diagnosticos generados")
        lblTitulo.Location = New Point((Me.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y)

    End Sub

    Public Sub New(patologias As DataTable, sintomas As ArrayList)

        InitializeComponent()
        For Each var As Control In Me.Controls

            If TypeOf var Is Panel Then

                For Each ctrl As Control In var.Controls

                    ctrl.Text = Principal.Singleton.Idioma(ctrl.Name, ctrl.Text)

                    If TypeOf ctrl Is Panel Then

                        For Each ctrl2 As Control In ctrl.Controls
                            ctrl2.Text = Principal.Singleton.Idioma(ctrl2.Name, ctrl2.Text)

                            If TypeOf ctrl2 Is Panel Then

                                For Each ctrl3 As Control In ctrl2.Controls
                                    ctrl3.Text = Principal.Singleton.Idioma(ctrl3.Name, ctrl3.Text)
                                    If TypeOf ctrl3 Is Panel Then
                                        For Each ctrl4 As Control In ctrl3.Controls
                                            ctrl4.Text = Principal.Singleton.Idioma(ctrl4.Name, ctrl4.Text)

                                            If TypeOf ctrl4 Is Panel Then
                                                For Each ctrl5 As Control In ctrl4.Controls
                                                    ctrl5.Text = Principal.Singleton.Idioma(ctrl5.Name, ctrl5.Text)

                                                Next

                                            End If
                                        Next

                                    End If
                                Next
                            End If
                        Next

                    End If
                Next


            End If

            var.Text = Principal.Singleton.Idioma(var.Name, var.Text)
        Next

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        listado = Opcion.paciente

        If sin.guardarSintomas(Datos_Temporales.userLog, sintomas) Then

            If pat.guardarDiagnostico(Datos_Temporales.userLog, patologias) Then
                setPatologias(patologias)
            Else
                MsgBox(Principal.Singleton.Idioma("msgErrorRegistrarSintomasObtenerDiagnostico", "Error al registrar las patologías"))
                Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
                Me.Dispose()
            End If
        Else
            MsgBox(Principal.Singleton.Idioma("msgErrorRegistrarSintomasObtener", "Error al registrar los sintomas"))
            Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
            Me.Dispose()
        End If

    End Sub

    Private Sub setPatologias(patologias As DataTable)

        For Each patologia In patologias.Rows
            lista.Add(New UCDiagnnostico(patologia.item(0), patologia.item(1), patologia.item(2), patologia.item(3)))
        Next

        If lista.Count > 3 Then
            btnSig.Visible = True
        Else
            btnSig.Visible = False
        End If

        If lista.Count = 1 Then

            TableLayoutPanel1.Controls.Add(lista.Item(0), 1, 0)


        ElseIf lista.Count = 2 Then

            For Each fila In lista
                TableLayoutPanel1.Controls.Add(fila)
            Next
        Else

            For i = 0 To 2
                TableLayoutPanel1.Controls.Add(lista.Item(i))
                contador += 1
            Next

        End If

        If lista.Count < 4 Then
            btnSig.Visible = False
        End If

    End Sub

    Public Enum Opcion
        paciente = 0
        medico = 1
    End Enum

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLogin.Visible = True
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click

        If listado = Opcion.paciente Then
            If ControladorChat.Singleton.verificarEstadoChat Then
                Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
                Me.Dispose()
            Else
                Principal.Singleton.CambiarTamaño(frmBienvenidaPaciente)

                If Me.ParentForm Is frmIngresarSintomas Then

                    Dim frm As frmIngresarSintomas = Me.ParentForm
                    frm.Dispose()
                    'ElseIf Me.ParentForm Is  Then

                Else
                    Try
                        Dim frm As frmListado = Me.ParentForm
                        frm.Dispose()
                    Catch ex As Exception
                        Dim frm1 As frmIngresarSintomas = Me.ParentForm
                        frm1.Dispose()
                    End Try

                End If

            End If

        Else
            If boton = 0 Then
                Principal.Singleton.CambiarTamaño(frmBienvenidaMedico)
                Me.Dispose()
            ElseIf boton = 1 Then
                Principal.Singleton.CambiarTamaño(frmChat)
                Me.Dispose()

            End If

        End If

    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click

        TableLayoutPanel1.Controls.Clear()
        Dim contador2 As Integer = contador + 2
        Dim contador1 As Integer = contador

        For i = contador1 To contador2

            If i = lista.Count Then
                btnSig.Visible = False
                Exit For
            Else

                TableLayoutPanel1.Controls.Add(lista.Item(i))
                contador += 1

            End If

        Next
        btnAnt.Visible = True

    End Sub

    Private Sub btnAnt_Click(sender As Object, e As EventArgs) Handles btnAnt.Click

        contador = contador - TableLayoutPanel1.Controls.Count
        Dim tuvieja As Integer = TableLayoutPanel1.Controls.Count
        TableLayoutPanel1.Controls.Clear()

        If (contador - 3) = 0 Then
            For i = 0 To 2
                TableLayoutPanel1.Controls.Add(lista.Item(i))

            Next
            contador = 3
        Else
            For i = (lista.Count - tuvieja) - 1 To contador - 3 Step -1
                TableLayoutPanel1.Controls.Add(lista.Item(i))
            Next

        End If

    End Sub

    Private Sub TableLayoutPanel1_ControlAdded(sender As Object, e As ControlEventArgs) Handles TableLayoutPanel1.ControlAdded, TableLayoutPanel1.ControlRemoved

        If contador < lista.Count Then
            btnSig.Visible = True
        End If
        If contador <= 3 Then
            btnAnt.Visible = False
        Else
            btnAnt.Visible = True
        End If

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btnSoliChat.Click

        If listado = Opcion.paciente Then
            Dim chat As New ControladorChat

            If solicitud Then
                Dim respuesta As Byte = MsgBox(Principal.Singleton.Idioma("msgDeseaInciarChat", "¿Desea iniciar un chat?"), vbYesNo)
                If respuesta = vbYes Then
                    If chat.crearChat() Then
                        MsgBox(Principal.Singleton.Idioma("msgPeticionChatEnviada", "Se ha enviado una solicitud de chat"))
                        solicitud = False
                    Else
                        MsgBox(Principal.Singleton.Idioma("msgErrorCrearSoli", "Error al crear la solicitud de chat"))
                    End If
                End If
            Else
                MsgBox(Principal.Singleton.Idioma("msgYainiciounchat", "Usted ya ha iniciado un chat"))
            End If

        Else

            Dim ucSin As New UCPatologia(ControladorSintoma.Singleton.getSintomasIndicados(Me.cedPaciente))
            Me.Controls.Add(ucSin)
            ucSin.Show()
            ucSin.BringToFront()
            ucSin.Location = New Point((Me.Width - ucSin.Width) / 2, (Me.Height - ucSin.Height) / 2)

        End If

    End Sub

End Class