Imports Logica
Public Class frmRegistroPaciente
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim paciente As New Paciente(txtCed.Text,
                                     txtPass1.Text,
                                     txtPrimerNombre.Text,
                                     txtSegundoNombre.Text,
                                     txtPrimerApellido.Text,
                                     txtSegundoApellido.Text,
                                     txtTel.Text, txtMail.Text,
                                     "M", txtFecNac.Text)
        paciente.agregar()
    End Sub

    Private Sub frmRegistroPaciente_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtCed.Text = 1234554
        txtPass1.Text = "asd"
        txtPrimerNombre.Text = "asd"
        txtSegundoNombre.Text = "asd"
        txtPrimerApellido.Text = "asd"
        txtSegundoApellido.Text = "asd"
        txtTel.Text = 123
        txtMail.Text = "asddhfgfgh"
        txtFecNac.Text = "2000/02/01"

        'Dim fecha As String
        'txtFecNac.Text = Format$(fecha, "DD-mm-yyyy")
    End Sub
End Class