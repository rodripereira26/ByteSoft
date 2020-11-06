Imports Logica
Public Class UCChat

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

    Public Sub New(nombre As String, mensaje As String, fecha As Date, idChat As Int32, cedula As String, foto As Object)

        InitializeComponent()
        If nombre <> "" Then
            lblNombre.Text = nombre
        End If

        If mensaje <> "" Then
            lblMensaje.Text = mensaje
        End If

        lblFecha.Text = fecha

        If idChat <> Nothing Then
            lblidChat.Text = idChat
        End If

        If cedula <> "" Then
            lblCed.Text = cedula
        End If

        SetDate(fecha)

        If TypeOf foto IsNot DBNull Then
            GunaCirclePictureBox1.Image = Principal.Singleton.Base64ToImage(foto.ToString)
        Else
            GunaCirclePictureBox1.Image = My.Resources.nopic
        End If

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
        Next
    End Sub
    Public Sub SetDate(fecha As Date)

        If fecha.Hour < 10 Then
            lblFecha.Text = "0" & fecha.Hour().ToString() & ":"
        Else
            lblFecha.Text = fecha.Hour().ToString() & ":"
        End If
        If fecha.Minute < 10 Then
            lblFecha.Text = lblFecha.Text & "0" & fecha.Minute.ToString
        Else
            lblFecha.Text = lblFecha.Text & fecha.Minute.ToString
        End If

    End Sub
    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave

        Dim instancia As frmChat = Me.ParentForm

        Try
            If instancia.instanciaChat IsNot Nothing Then
                If (sender IsNot instancia.instanciaChat) Then
                    Me.BackColor = Color.FromArgb(31, 39, 49)
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter

        Dim instancia As frmChat = Me.ParentForm

        Try
            If instancia.instanciaChat IsNot Nothing Then
                If (sender IsNot instancia.instanciaChat) Then
                    Me.BackColor = Color.FromArgb(25, 34, 41)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CambioChat() Handles Me.Click, Me.DoubleClick, GunaCirclePictureBox1.Click, lblMensaje.Click, lblFecha.Click, lblCed.Click, lblidChat.Click, lblNombre.Click

        Datos_Temporales.idchat = lblidChat.Text
        Datos_Temporales.pacienteSelecionado = lblCed.Text

        Dim instancia As frmChat = Me.ParentForm

        Me.BackColor = Color.FromArgb(25, 34, 41)
        instancia.instanciaChat.BackColor = Color.FromArgb(31, 39, 49)
        instancia.instanciaChat = Me
        instancia.ReloadChat()
        instancia.lblUsuario.Text = Me.lblNombre.Text
        instancia.lblUsuario.Visible = True
        instancia.pbPerfil.Visible = True
        instancia.btnFinalizar.Visible = True
        instancia.btnVerSintomasDiagPac.Visible = True
        instancia.pbEnviar.Visible = True
        instancia.txtMsg.Visible = True
        instancia.lblEscriba.Visible = True
        instancia.pnlEnviar.Visible = True

        If GunaCirclePictureBox1.Image IsNot Nothing Then
            instancia.pbPerfil.Image = GunaCirclePictureBox1.Image
        Else
            instancia.pbPerfil.Image = My.Resources.nopic
        End If

    End Sub

End Class