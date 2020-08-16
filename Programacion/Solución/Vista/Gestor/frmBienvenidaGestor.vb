Imports Logica

Public Class frmBienvenidaGestor


    Private p As New Principal
    Dim gestor As New ControladorGestor

    Private Sub BienvenidaGestor_Load(sender As Object, e As EventArgs) Handles Me.Load



        p.roundedCorners(Me)
        p.roundedCorners(pnlAjustes)
        p.roundedCorners(pnlMiPerfil)
        p.roundedCorners(pnlPatologias)
        p.roundedCorners(pnlUsuarios)
        p.roundedCorners(pnlSintomas)
        p.roundedCorners(Panel14)
        p.roundedCorners(pnlRegistrodeUsuarios)
        p.roundedCorners(pnlUsuarios)
        p.roundedCorners(pnlAyuda)
        p.roundedCorners(Panel14)



        'Me.BackColor = Color.FromArgb(236, 236, 236)
        'Dim col As Color = Color.FromArgb(52, 73, 94)

        'Panel1.BackColor = Color.WhiteSmoke

        'Panel3.BackColor = Color.WhiteSmoke
        'Panel4.BackColor = Color.WhiteSmoke
        'Panel5.BackColor = Color.WhiteSmoke
        'Panel6.BackColor = Color.FromArgb(236, 236, 236)
        'Panel12.BackColor = Color.WhiteSmoke
        'Panel15.BackColor = Color.WhiteSmoke
        'Panel16.BackColor = Color.WhiteSmoke

        'Label1.ForeColor = col
        'Label2.ForeColor = col
        'Label3.ForeColor = col

        'Label5.ForeColor = col
        'Label6.ForeColor = col
        'Label7.ForeColor = col
        'Label8.ForeColor = col
        'Label9.ForeColor = col
        'Label10.ForeColor = col
        'Label11.ForeColor = col
        'Label12.ForeColor = col
        'Label13.ForeColor = col
        'Label14.ForeColor = col

        'Label16.ForeColor = col
        'Label17.ForeColor = col
        'Label18.ForeColor = col
        'Label19.ForeColor = col

    End Sub

    Private Sub Panel6_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseDown
        p.moverVentanaDown(Me)
    End Sub

    Private Sub Panel6_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseMove
        p.moverVentanaMove(Me)
    End Sub

    Private Sub Panel6_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseUp
        p.moverVentanaUp()
    End Sub

    Private Sub pnlPatologias_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlPatologias.MouseDown
        frmModular.op = 0
        frmModular.Visible = True
        Me.Hide()
    End Sub

    Private Sub pnlSintomas_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlSintomas.MouseDown
        frmModular.op = 1
        frmModular.Visible = True
        Me.Hide()
    End Sub
    Private Sub pnlRegistrodeUsuarios_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlRegistrodeUsuarios.MouseDown
        frmModular.op = 2
        frmModular.Visible = True
        Me.Hide()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmRegistroGestor.Show()
    End Sub

    Private Sub btnNotificacion_Click(sender As Object, e As EventArgs) Handles btnNotificacion.Click
        If pnlListadoPacientes.Visible = True Then
            pnlListadoPacientes.Visible = False
        Else
            pnlListadoPacientes.Visible = True

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        dgvListadoPacientes.DataSource = gestor.listarPacientes

    End Sub

    Private Sub dgvListadoPacientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPacientes.CellDoubleClick

    End Sub

    Private Sub dgvListadoPacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) _
                                           Handles dgvListadoPacientes.CellContentClick
        If e.RowIndex >= 0 Then

            If dgvListadoPacientes.Columns(e.ColumnIndex).Index = 0 Then
                Dim respuesta As Integer = MsgBox("¿Desea habilitar a este paciente?", vbQuestion + vbYesNo + vbDefaultButton2)

                If respuesta = vbYes Then

                    gestor.habilitar(dgvListadoPacientes.Rows(e.RowIndex).Cells(2).Value)

                End If

            Else
                Dim respuesta As Integer = MsgBox("¿Desea eliminar a este paciente?", vbQuestion + vbYesNo + vbDefaultButton2)

                If respuesta = vbYes Then

                    gestor.eliminar(dgvListadoPacientes.Rows(e.RowIndex).Cells(2).Value)

                End If

            End If
        End If

    End Sub

    Private Sub btnRefrescarListadoPac_Click(sender As Object, e As EventArgs) Handles btnRefrescarListadoPac.Click
        dgvListadoPacientes.DataSource = gestor.listarPacientes
    End Sub
End Class