Imports Logica
Public Class frmRegistrarMedico
    Private Sub RegistrarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Select()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim med As New Medico(
        txtCed.Text,
        txtCed.Text,
        txtPrimerNombre.Text,
        txtSegundoNombre.Text,
        txtPrimerApellido.Text,
        txtSegundoApellido.Text,
        0,
        "PENDIENTE",
        txtEspe.Text)
        med.agregar()

    End Sub
End Class