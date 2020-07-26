Imports Logica
Public Class frmRegistroPaciente

    Dim aliTel As New ArrayList
    Dim check As New Verificacion
    Dim sexo As String

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        If verificarDatos() Then
            Dim pac As New ControladorPaciente(txtCed.Text,
                                       txtPass1.Text,
                                       txtPrimerNombre.Text,
                                       txtSegundoNombre.Text,
                                       txtPrimerApellido.Text,
                                       txtSegundoApellido.Text,
                                       aliTel, txtMail.Text,
                                       sexo, txtFecNac.Text)
            If pac.registrar() Then

                MsgBox("Paciente registrado")
                limpiar()

            Else
                MsgBox("El paciente ya fue ingresado")

            End If

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

    Private Sub limpiar()

        txtCed.Clear()
        txtPass1.Clear()
        txtPass2.Clear()
        txtPrimerApellido.Clear()
        txtPrimerNombre.Clear()
        txtSegundoApellido.Clear()
        txtSegundoNombre.Clear()
        txtMail.Clear()
        aliTel.Clear()
        txtFecNac.Clear()
        dgvTelefonos.Rows.Clear()


    End Sub

    Private Function verificarDatos() As Boolean

        Dim seg As New Encriptar
        Dim pass As String

        If check.verificar_cedula(txtCed.Text) And check.verificar_digito(txtCed.Text) Then

            If check.verificar_string(txtPrimerNombre.Text) = False Then

                MsgBox("Primer nombre incorrecto")
                Return False

            End If

            If check.verificar_string(txtPrimerApellido.Text) = False Then

                MsgBox("Primer apellido incorrecto")
                Return False

            End If

            If IsNumeric(txtSegundoNombre.Text) Then

                MsgBox("Segundo nombre incorrecto")
                Return False

            End If

            If check.verificar_string(txtSegundoApellido.Text) = False Then

                MsgBox("Segundo apellido incorrecto")
                Return False

            End If

            If check.verificar_email(txtMail.Text) = False Then

                MsgBox("Email incorrecto")
                Return False

            End If

            If seg.HASHSHA2566(txtPass1.Text) = seg.HASHSHA2566(txtPass2.Text) Then

                pass = seg.HASHSHA2566(txtPass1.Text)

            Else
                MsgBox("Las contraseñas no coinciden")
                Return False

            End If

            For i = 0 To dgvTelefonos.Rows.Count - 2

                If dgvTelefonos.Rows(i).Cells(0).Value <> "" Then

                    aliTel.Add(dgvTelefonos.Rows(i).Cells(0).Value)

                End If

            Next

            If cbM.Checked Then
                sexo = "M"
            Else
                sexo = "F"
            End If

        Else
            MsgBox("Cédula incorrecta")
            Return False

        End If

        Return True
    End Function

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