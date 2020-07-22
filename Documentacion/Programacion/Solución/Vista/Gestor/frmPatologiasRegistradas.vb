Imports Logica
Public Class frmPatologiasRegistradas

    Private Sub frmPatologiasRegistradas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim p As New ControladorPatologia
        dgvListadoPatologias.DataSource = p.listarPatologias
    End Sub

    Private Sub btnSeleccionMultiple_Click(sender As Object, e As EventArgs) Handles btnSeleccionMultiple.Click
        If dgvListadoPatologias.Columns(0).Visible = False Then
            'dgvListadoPatologias.Columns(0).Visible = True
            dgvListadoPatologias.MultiSelect = True
        Else
            dgvListadoPatologias.Columns(0).Visible = False
        End If
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvListadoPatologias.MouseDown
        'Dim SourceRow = dgvListadoPatologias.HitTest(e.X, e.Y).RowIndex

    End Sub

    Private Sub dgvListadoPatologias_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvListadoPatologias.MouseClick
        If dgvListadoPatologias.MultiSelect = True Then
            lblCantSelecc.Text = dgvListadoPatologias.SelectedRows.Count.ToString
        End If
    End Sub

    Private Sub dgvListadoPatologias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPatologias.CellDoubleClick
        If dgvListadoPatologias.MultiSelect = False Then
        End If
    End Sub


End Class