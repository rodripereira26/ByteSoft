Imports Logica
Public Class UCHabilitarGestor
    Private gestor As New ControladorGestor
    Public Sub New(nombre As String, cedula As String)


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

        lblCedula.Text = cedula
        lblNombre.Text = nombre
        Label1.Text = cedula

        lblNombre.Location = New Point((Me.Width - lblNombre.Width) \ 2, lblNombre.Location.Y)
        lblCedula.Location = New Point((Me.Width - lblCedula.Width) \ 2, lblCedula.Location.Y)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim respuesta As Integer = MsgBox(Principal.Singleton.Idioma("xdxdUCHabilitarGestor","¿Desea habilitar a este gestor?"), vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            If gestor.HabilitarGestores(Label1.Text) Then

                frmBienvenidaGestor.Singleton.setTamaños()
                Me.Dispose()

            End If

        End If

    End Sub

    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click

        Dim respuesta As Integer = MsgBox(Principal.Singleton.Idioma("msgDarbajaGestorUC", "¿Desea dar de baja a este gestor?"), vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            If gestor.eliminar(Label1.Text) Then

                frmBienvenidaGestor.Singleton.setTamaños()
                Me.Dispose()

            End If

        End If

    End Sub


End Class
