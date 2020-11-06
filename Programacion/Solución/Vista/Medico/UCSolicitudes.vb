Imports Logica

Public Class UCSolicitudes

    Dim idChat As Int32
    Dim cedula As String
    Private pat As New ControladorPatologia

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

    Public Sub New(cedula As String, idChat As Integer, nombre As String, edad As Integer)


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

        Me.idChat = idChat
        Me.cedula = cedula
        lblNombre.Text = nombre
        lblEdad.Text = edad.ToString & principal.singleton.idioma("msgEdadSolicitud"," años")

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarChat.Click

        Dim instancia As frmBienvenidaMedico = Me.ParentForm
        If ControladorChat.Singleton.verificarCedula(idChat) Then

            Dim respuesta As Integer

            respuesta = MsgBox(principal.singleton.idioma("msgEntrarAChat","¿Desea entrar al chat con el usuario ") + cedula + "?", vbQuestion + vbYesNo + vbDefaultButton2)

            If respuesta = vbYes Then

                ControladorChat.Singleton.entrarChat(Datos_Temporales.userLog, idChat)
                Datos_Temporales.idchat = idChat
                Datos_Temporales.pacienteSelecionado = cedula
                Dim frm As New frmChat()
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(instancia.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frm)
                frm.Show()
                instancia.pnlContenedor.Hide()
                instancia.pnlInstancia.Show()
                frm.ReloadChat()
                Me.ResumeLayout()
                Me.Dispose()

            End If

        Else
            MsgBox(principal.singleton.idioma("msgErrorIngresoChat","Error al ingresar al chat"))
        End If
    End Sub

    Private Sub btnDiagnostico_Click(sender As Object, e As EventArgs) Handles btnDiagnostico.Click

        Dim instancia As frmBienvenidaMedico = Me.ParentForm
        Dim frm As New frmObtenerDiagnostico(pat.traerUltimoDiagnostico(Me.cedula), 0, cedula)
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(instancia.pnlInstancia, frm)
        Principal.Singleton.CambiarTamaño(frmObtenerDiagnostico)
        frm.Show()
        instancia.pnlContenedor.Hide()
        instancia.pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub
End Class
