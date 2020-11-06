Imports Logica

Public Class UCDiagnnostico

    Private pat As New ControladorPatologia
    Private sin As New ControladorSintoma
    Public Sub New(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte)

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

        lblNom.Text = nombre
        txtDescripcion.Text = descripcion
        txtRecomendacion.Text = recomendacion

        If prioridad = 1 Then
            pbAdvertencia.Visible = True
        Else
            pbAdvertencia.Visible = False
        End If

    End Sub

    Private Sub btnSintomas_Click_1(sender As Object, e As EventArgs) Handles btnSintomas.Click

        Dim uc = New UCPatologia(lblNom.Text, sin.TraerSintomasDePatologia(lblNom.Text))
        Me.ParentForm.Controls.Add(uc)
        uc.BringToFront()
        uc.Show()
        uc.Top = (frmObtenerDiagnostico.Height / 2) - (uc.Height / 2)
        uc.Left = (frmObtenerDiagnostico.Width / 2) - (uc.Width / 2)

    End Sub

    Private Sub IconPictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles pbAdvertencia.MouseHover
        MetroToolTip1.Show(Principal.Singleton.Idioma("toolRecomendarXD","Advertencia: Recomendamos que solicite un chat debido a la gravedad de la enfermedad."), pbAdvertencia)
    End Sub

    Private Sub IconPictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles pbAdvertencia.MouseLeave
        MetroToolTip1.Hide(pbAdvertencia)
    End Sub

    Private Sub btnMasDesc_Click(sender As Object, e As EventArgs) Handles btnMasDesc.Click

        If txtDescripcion.Height < 220 Then
            txtDescripcion.Height = 220
            txtDescripcion.BringToFront()
            btnMasDesc.Text = Principal.Singleton.Idioma("txtMostrarMenosXD","Mostrar menos")
        Else
            txtDescripcion.Height = 81
            txtDescripcion.BringToFront()
            btnMasDesc.Text = Principal.Singleton.Idioma("txtMostrarMasXD","Mostrar más")
        End If

    End Sub

    Private Sub btnMasRec_Click(sender As Object, e As EventArgs) Handles btnMasRec.Click

        If txtRecomendacion.Height < 220 Then
            txtRecomendacion.Height = 220
            txtRecomendacion.BringToFront()
            btnMasRec.Text = Principal.Singleton.Idioma("txtMostrarMenosXD","Mostrar menos")
        Else
            txtRecomendacion.Height = 137
            txtRecomendacion.BringToFront()
            btnMasRec.Text = Principal.Singleton.Idioma("txtMostrarMasXD","Mostrar más")
        End If

    End Sub


End Class
