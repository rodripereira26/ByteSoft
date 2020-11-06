Imports Logica
Public Class UCHabilitarPaciente

    Private gestor As New ControladorGestor


    Private Sub UCHabilitar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(nombre As String, cedula As String)

        ' Esta llamada es exigida por el diseñador.
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
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub hover(sender As Object, e As EventArgs) Handles lblCedula.MouseEnter, lblNombre.MouseEnter, Me.MouseEnter

        Me.BackColor = Color.FromArgb(21, 30, 43)

    End Sub
    Private Sub leave(sender As Object, e As EventArgs) Handles lblCedula.MouseLeave, lblNombre.MouseLeave, Me.MouseLeave

        Me.BackColor = Color.FromArgb(18, 25, 36)

    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarPaciente.Click

        Dim respuesta As Integer = MsgBox(Principal.Singleton.Idioma("msgHabilitarPacienteUC","¿Desea habilitar a este paciente?"), vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            If gestor.HabilitarPacientes(Label1.Text) Then

                frmBienvenidaGestor.Singleton.setTamaños()
                Me.Dispose()

            End If

        End If

    End Sub

    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazarPaciente.Click

        Dim respuesta As Integer = MsgBox(Principal.Singleton.Idioma("xdxdlol","¿Desea dar de baja a este paciente?"), vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            If gestor.eliminar(Label1.Text) Then

                frmBienvenidaGestor.Singleton.setTamaños()
                Me.Dispose()

            End If

        End If

    End Sub

End Class
