Imports Logica
Public Class frmRegistrarSintoma

    Private Sub RegistrarSintomas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label13.Select()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        If txtDescripcion.Text.Length > 10 Then
            Dim sintoma As New ControladorSintoma(txtNomSintoma.Text, txtDescripcion.Text)

            If sintoma.registrar() Then
                MsgBox("Síntoma registrado con éxito")
                txtDescripcion.Clear()
                txtNomSintoma.Clear()
            Else
                MsgBox("Error al registrar el síntoma")
            End If
        End If

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub panelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseDown
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub panelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseMove
        Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub panelTitulo_MouseUp(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseUp
        Principal.Singleton.moverVentanaUp()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Not (txtNomSintoma.Text = Nothing And txtDescripcion.Text = Nothing) Then
            Dim res = MsgBox("Hay información sin guardar, ¿seguro desea salir?", vbYesNo)
            If res = vbYes Then
                frmModular.Show()
                Me.Close()
            End If
        Else
            frmModular.Show()
            Me.Close()
        End If
        frmModular.Show()
        Me.Hide()
    End Sub
End Class