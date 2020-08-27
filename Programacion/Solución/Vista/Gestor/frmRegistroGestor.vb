Imports Logica
Public Class frmRegistroGestor

    Dim pass As String
    Dim aliTel As New ArrayList
    Dim check As New Verificacion
    Dim seg As New Encriptar

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles btnRegistrarGestor.Click

        If Principal.Singleton.verificarCedula(check, txtCI.Text) Then
            If Principal.Singleton.verificarContraseña(seg, txtCon.Text, txtRepCon.Text) Then
                pass = seg.HASH256(txtCon.Text)
                If Principal.Singleton.verificarString(check, txtPNom.Text, txtPApe.Text, txtSNom.Text, txtSApe.Text) Then
                    If Principal.Singleton.verificarEmail(check, txtMail.Text) Then
                        If Principal.Singleton.verificarTelefonos(dgvTelefonos, aliTel) Then
                            Dim ges As New ControladorGestor(txtCI.Text,
                                                 pass,
                                                 txtPNom.Text.ToUpper,
                                                 txtSNom.Text.ToUpper,
                                                 txtPApe.Text.ToUpper,
                                                 txtSApe.Text.ToUpper,
                                                 aliTel,
                                                 txtMail.Text)
                            If ges.registrar() Then
                                MsgBox("Gestor registrado con éxito")
                                Principal.Singleton.limpiar(txtCI, txtCon, txtRepCon, txtPApe, txtPNom, txtSApe, txtSNom, txtMail, dgvTelefonos, aliTel)

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


    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lblTxtAgregarTelefonos.Click

        If pnlTelefonos.Visible = False Then
            pnlTelefonos.Visible = True
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        dgvTelefonos.Rows.RemoveAt(dgvTelefonos.SelectedRows(0).Index)
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If check.verificar_int(dgvTelefonos.Rows(dgvTelefonos.Rows.Count - 2).Cells(0).Value.ToString) = False Then

            MsgBox("Ingresó un teléfono incorrecto")
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.Rows.Count - 2)

        End If

        pnlTelefonos.Hide()
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
        If Not (txtCI.Text = Nothing And txtPNom.Text = Nothing And txtPApe.Text = Nothing And
            txtPNom.Text = Nothing And txtSApe.Text = Nothing And txtSNom.Text = Nothing And
            txtCon.Text = Nothing And txtRepCon.Text = Nothing And txtMail.Text = Nothing And dgvTelefonos.Rows.Count > 0) Then
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