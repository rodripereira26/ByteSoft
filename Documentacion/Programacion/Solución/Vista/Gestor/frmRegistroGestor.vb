Imports Logica
Public Class frmRegistroGestor

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim aliTel As New ArrayList

        For i = 0 To dgvTelefonos.Rows.Count - 2
            If dgvTelefonos.Rows(i).Cells(0).Value <> "" Then
                aliTel.Add(dgvTelefonos.Rows(i).Cells(0).Value)
            End If

        Next

        'VERIFICACIONES
        Dim ges As New ControladorGestor(txtCI.Text,
                                         txtPass1.Text,
                                         txtPrimerNombre.Text,
                                         txtSegundoNombre.Text,
                                         txtPrimerApellido.Text,
                                         txtSegundoApellido.Text,
                                         aliTel,
                                         txtEmail.Text)
        ges.registrar()
    End Sub


    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        If Panel12.Visible = False Then
            Panel12.Visible = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        dgvTelefonos.Rows.RemoveAt(dgvTelefonos.SelectedRows(0).Index)

    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Panel12.Hide()
        ''add animacion
    End Sub

    Private Sub dgvTelefonos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellClick
        btnEliminar.Enabled = True
    End Sub
End Class