Public Class UCAdvertencia
    
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

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnCambiarPass.Click

        Dim instancia As frmBienvenidaMedico = Me.ParentForm

        Me.Dispose()
        instancia.SuspendLayout()
        Dim perfil As New UCVerPerfil()
        instancia.Controls.Add(perfil)
        perfil.pnlCredenciales.BringToFront()
        perfil.pnlCredenciales.Visible = True

        perfil.BringToFront()
        Me.ResumeLayout()

    End Sub
End Class
