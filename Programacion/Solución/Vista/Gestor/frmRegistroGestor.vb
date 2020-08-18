Imports Logica
Public Class frmRegistroGestor

    Dim pass As String
    Dim aliTel As New ArrayList
    Dim check As New Verificacion
    Dim seg As New Encriptar

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles btnRegistrarGestor.Click

        If Principal.Singleton.verificarCedula(check, txtCI.Text) Then
            If Principal.Singleton.verificarContraseña(seg, txtPass1.Text, txtPass2.Text) Then
                pass = seg.HASH256(txtPass1.Text)
                If Principal.Singleton.verificarString(check, txtPrimerNombre.Text, txtPrimerApellido.Text, txtSegundoNombre.Text, txtSegundoApellido.Text) Then
                    If Principal.Singleton.verificarEmail(check, txtEmail.Text) Then
                        If Principal.Singleton.verificarTelefonos(dgvTelefonos, aliTel) Then
                            Dim ges As New ControladorGestor(txtCI.Text,
                                                 pass,
                                                 txtPrimerNombre.Text.ToUpper,
                                                 txtSegundoNombre.Text.ToUpper,
                                                 txtPrimerApellido.Text.ToUpper,
                                                 txtSegundoApellido.Text.ToUpper,
                                                 aliTel,
                                                 txtEmail.Text)
                            If ges.registrar() Then
                                MsgBox("Gestor registrado con éxito")
                                Principal.Singleton.limpiar(txtCI, txtPass1, txtPass2, txtPrimerApellido, txtPrimerNombre, txtSegundoApellido, txtSegundoNombre, txtEmail, dgvTelefonos, aliTel)

                            Else
                                MsgBox("El gestor ya fue registrado")
                            End If

                        End If
                    End If
                End If
            End If

        Else
            MsgBox("La cédula ingresada no es correcta")

        End If

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

        If check.verificar_int(dgvTelefonos.Rows(dgvTelefonos.Rows.Count - 2).Cells(0).Value.ToString) = False Then

            MsgBox("Ingresó un teléfono incorrecto")
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.Rows.Count - 2)

        End If

        Panel12.Hide()
        ''add animacion

    End Sub

    Private Sub dgvTelefonos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellClick
        btnEliminar.Enabled = True
    End Sub

    Private Sub dgvTelefonos_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvTelefonos.CellValidating

        'If dgvTelefonos.Rows(e.RowIndex).IsNewRow Then
        '    If e.ColumnIndex = 0 Then
        '        If ver.verificar_int(e.FormattedValue.ToString) Then
        '        Else
        '            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.SelectedRows(0).Index)
        '        End If
        '    End If
        'End If

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        If Not (txtCI.Text = Nothing And txtPrimerNombre.Text = Nothing And txtPrimerApellido.Text = Nothing And
            txtPrimerNombre.Text = Nothing And txtSegundoApellido.Text = Nothing And txtSegundoNombre.Text = Nothing And
            txtPass1.Text = Nothing And txtPass2.Text = Nothing And txtEmail.Text = Nothing And dgvTelefonos.Rows.Count > 0) Then
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