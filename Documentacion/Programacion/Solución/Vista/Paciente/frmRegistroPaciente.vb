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

        'VERIFICACIONES
        Dim sexo As String

        If cbM.Checked Then
            sexo = "M"
        Else
            sexo = "F"
        End If

        Dim aliTel As New ArrayList

        For i = 0 To dgvTelefonos.Rows.Count - 2

            If dgvTelefonos.Rows(i).Cells(0).Value <> "" Then

                aliTel.Add(dgvTelefonos.Rows(i).Cells(0).Value)

            End If

        Next

        Dim pac As New ControladorPaciente(txtCed.Text,
                                    txtPass1.Text,
                                    txtPrimerNombre.Text,
                                    txtSegundoNombre.Text,
                                    txtPrimerApellido.Text,
                                    txtSegundoApellido.Text,
                                    aliTel, txtMail.Text,
                                    sexo, txtFecNac.Text)
        pac.registrar()

    End Sub

    Private Sub MaterialRaisedButton2_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click

        Panel12.Hide()
        ''add animacion

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

        If Panel12.Visible = False Then

            Panel12.Visible = True

        End If

    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        dgvTelefonos.Rows.RemoveAt(dgvTelefonos.SelectedRows(0).Index)
    End Sub

    Private Sub dgvTelefonos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellClick

        btnEliminar.Enabled = True
        ' no permite elimianr si no hay ninguna cell seleccionada

    End Sub

End Class