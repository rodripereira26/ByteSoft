Imports Logica
Public Class frmRegistroPaciente

    Dim aliTel As New ArrayList
    Dim check As New Verificacion
    Dim seg As New Encriptar
    Dim pass As String
    Dim sexo As String
    Dim p As New Principal

    Private Sub frmRegistroPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p.roundedCorners(Me)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Dispose()
        frmLogin.Show()

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        If p.verificarCedula(check, txtCed.Text) Then
            If p.verificarContraseña(seg, txtPass1.Text, txtPass2.Text) Then
                pass = seg.HASH256(txtPass1.Text)
                If p.verificarString(check, txtPrimerNombre.Text, txtPrimerApellido.Text, txtSegundoNombre.Text, txtSegundoApellido.Text) Then
                    If p.verificarEmail(check, txtMail.Text) Then
                        If p.verificarTelefonos(dgvTelefonos, aliTel) Then
                            If txtFecNac.Text <> "" Then

                                If cbM.Checked Then
                                    sexo = "M"
                                Else
                                    sexo = "F"
                                End If

                                Dim pac As New ControladorPaciente(txtCed.Text,
                                           pass,
                                           txtPrimerNombre.Text.ToUpper,
                                           txtSegundoNombre.Text.ToUpper,
                                           txtPrimerApellido.Text.ToUpper,
                                           txtSegundoApellido.Text.ToUpper,
                                           aliTel,
                                           txtMail.Text,
                                           sexo,
                                           txtFecNac.Text)

                                If pac.registrar() Then

                                    MsgBox("Paciente registrado con éxito")
                                    p.limpiar(txtCed, txtPass1, txtPass2, txtPrimerNombre,
                                            txtPrimerApellido,
                                            txtSegundoApellido, txtSegundoNombre,
                                            txtMail, dgvTelefonos, aliTel)
                                    txtFecNac.Clear()
                                    cbM.Checked = True

                                Else
                                    MsgBox("El paciente ya fue registrado")

                                End If

                            Else
                                MsgBox("Debe ingresar su fecha de nacimiento")
                            End If

                        End If
                    End If
                End If
            End If
        Else
            MsgBox("La cédula ingresada no es correcta")
        End If

    End Sub

    Private Sub MaterialRaisedButton2_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click

        If check.verificar_int(dgvTelefonos.Rows(dgvTelefonos.Rows.Count - 2).Cells(0).Value.ToString) = False Then

            MsgBox("Ingresó un teléfono incorrecto")
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.Rows.Count - 2)

        End If
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

    Private Sub txtFecNac_Click(sender As Object, e As EventArgs) Handles txtFecNac.Click
        txtFecNac.Select(0, 0)
    End Sub

End Class