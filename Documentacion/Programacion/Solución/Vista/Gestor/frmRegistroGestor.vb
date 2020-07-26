Imports Logica
Public Class frmRegistroGestor

    Dim check As New Verificacion

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        Dim aliTel As New ArrayList
        Dim seg As New Encriptar
        Dim pass As String

        Try
            If check.verificar_cedula(txtCI.Text) And check.verificar_digito(txtCI.Text) Then

                If check.verificar_string(txtPrimerNombre.Text) = False Then

                    MsgBox("Primer nombre incorrecto")
                    Exit Try

                End If

                If check.verificar_string(txtPrimerApellido.Text) = False Then

                    MsgBox("Primer apellido incorrecto")
                    Exit Try

                End If

                If IsNumeric(txtSegundoNombre.Text) Then

                    MsgBox("Segundo nombre incorrecto")
                    Exit Try

                End If

                If check.verificar_string(txtSegundoApellido.Text) = False Then

                    MsgBox("Segundo apellido incorrecto")
                    Exit Try

                End If

                If check.verificar_email(txtEmail.Text) = False Then

                    MsgBox("Email incorrecto")
                    Exit Try

                End If

                If seg.HASHSHA2566(txtPass1.Text) = seg.HASHSHA2566(txtPass2.Text) Then

                    pass = seg.HASHSHA2566(txtPass1.Text)

                Else
                    MsgBox("Las contraseñas no coinciden")
                    Exit Try

                End If

                For i = 0 To dgvTelefonos.Rows.Count - 2

                    If dgvTelefonos.Rows(i).Cells(0).Value <> "" Then

                        aliTel.Add(dgvTelefonos.Rows(i).Cells(0).Value)

                    End If

                Next

                Dim ges As New ControladorGestor(txtCI.Text,
                                                 pass,
                                                 txtPrimerNombre.Text,
                                                 txtSegundoNombre.Text,
                                                 txtPrimerApellido.Text,
                                                 txtSegundoApellido.Text,
                                                 aliTel,
                                                 txtEmail.Text)
                ges.registrar()

            Else
                MsgBox("Cédula incorrecta")
                Exit Try

            End If

        Catch ex As Exception

        End Try

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

End Class