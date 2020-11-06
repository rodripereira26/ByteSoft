Public Class UCMensaje

    Public Property idMsj

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

    Public Sub New(esEmisor As Boolean, Mensaje As String, Fecha As Date, idMsj As Int32, Perfil As String)

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
        Me.idMsj = idMsj

        If (esEmisor) Then
            lbl_Enviado.Text = Mensaje
            lbl_Recibido.Visible = False
            lbl_Enviado.Visible = True

            If Fecha.Hour < 10 Then
                horaEnviado.Text = "0" & Fecha.Hour().ToString() & ":"
            Else
                horaEnviado.Text = Fecha.Hour().ToString() & ":"
            End If

            If Fecha.Minute < 10 Then
                horaEnviado.Text = horaEnviado.Text & "0" & Fecha.Minute.ToString & ":"
            Else
                horaEnviado.Text = horaEnviado.Text & Fecha.Minute.ToString & ":"
            End If

            If Fecha.Second < 10 Then
                horaEnviado.Text = horaEnviado.Text & "0" & Fecha.Second.ToString
            Else
                horaEnviado.Text = horaEnviado.Text & Fecha.Second.ToString
            End If

            horaEnviado.Location = New Point((lbl_Enviado.Location.X - horaEnviado.Width) - 33, ((lbl_Enviado.Height - horaEnviado.Height) / 2) + 1)
            lbl_Enviado.Size = TextRenderer.MeasureText(lbl_Enviado.Text, lbl_Enviado.Font)
            Me.Height = lbl_Enviado.Height + 15
        Else
            lbl_Recibido.Text = Mensaje
            lbl_Recibido.Visible = True
            lbl_Enviado.Visible = False

            If Fecha.Hour < 10 Then
                horaRecibido.Text = "0" & Fecha.Hour().ToString() & ":"
            Else
                horaRecibido.Text = Fecha.Hour().ToString() & ":"
            End If

            If Fecha.Minute < 10 Then
                horaRecibido.Text = horaRecibido.Text & "0" & Fecha.Minute.ToString & ":"
            Else
                horaRecibido.Text = horaRecibido.Text & Fecha.Minute.ToString & ":"
            End If

            If Fecha.Second < 10 Then
                horaRecibido.Text = horaRecibido.Text & "0" & Fecha.Second.ToString
            Else
                horaRecibido.Text = horaRecibido.Text & Fecha.Second.ToString
            End If
            horaRecibido.Location = New Point((lbl_Recibido.Width + 23), ((lbl_Recibido.Height - horaRecibido.Height) / 2) + 1)

            lbl_Recibido.Size = TextRenderer.MeasureText(lbl_Recibido.Text, lbl_Recibido.Font)
            Me.Height = lbl_Recibido.Height + 15
        End If

    End Sub
    Private Sub lbl_Recibido_MouseHover(sender As Object, e As EventArgs) Handles lbl_Recibido.MouseHover
        horaRecibido.Visible = True
    End Sub
    Private Sub lbl_Recibido_MouseLeave(sender As Object, e As EventArgs) Handles lbl_Recibido.MouseLeave
        horaRecibido.Visible = False
    End Sub
    Private Sub lbl_Enviado_MouseHover(sender As Object, e As EventArgs) Handles lbl_Enviado.MouseHover
        horaEnviado.Visible = True
    End Sub
    Private Sub lbl_Enviado_MouseLeave(sender As Object, e As EventArgs) Handles lbl_Enviado.MouseLeave
        horaEnviado.Visible = False
    End Sub

End Class
