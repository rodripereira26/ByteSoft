Imports logica
Public Class frmRegistrarSintoma

    Private Sub RegistrarSintomas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label13.Select()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim sintoma As New ControladorSintoma(txtNomSintoma.Text, txtDescripcion.Text)
        sintoma.registrar()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        frmSintomas.Show()

    End Sub
End Class