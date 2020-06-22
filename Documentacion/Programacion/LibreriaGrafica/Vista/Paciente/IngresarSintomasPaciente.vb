Public Class IngresarSintomasPaciente
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim p As New Principal
        ' p.roundedCorners(Me)

        dgvSintomas.Rows.Add("Dolor de cabeza")
        dgvSintomas.Rows.Add("Resfrio")
        dgvSintomas.Rows.Add("Fiebre")
        dgvSintomas.Rows.Add("Dolor de garganta")
        dgvSintomas.Rows.Add("Escalofrios")

        dgvMisSintomas.Rows.Add("Dolor de cabeza")
        dgvMisSintomas.Rows.Add("Resfrio")


    End Sub

    Private Sub dgvSintomas_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvSintomas.MouseDown
        Dim SourceRow As Integer
        SourceRow = dgvSintomas.HitTest(e.X, e.Y).RowIndex
        dgvSintomas.DoDragDrop(SourceRow, DragDropEffects.Move)
    End Sub

    Private Sub dgvMisSintomas_DragOver(sender As Object, e As DragEventArgs) Handles dgvMisSintomas.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvMisSintomas_DragDrop(sender As Object, e As DragEventArgs) Handles dgvMisSintomas.DragDrop

        dgvMisSintomas.Rows.Add("") 'agrega una row vacia para que entre el elemento
        Dim SourceRow = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")))

        Dim clientPoint As Point = dgvMisSintomas.PointToClient(New Point(e.X, e.Y))
        Dim hit As DataGridView.HitTestInfo = dgvMisSintomas.HitTest(clientPoint.X, clientPoint.Y)

        If hit.Type = DataGridViewHitTestType.Cell Then
            Dim rowDestino = hit.RowIndex
            Dim colDestino = hit.ColumnIndex
            dgvMisSintomas.Rows(rowDestino).Cells(colDestino).Value = dgvSintomas.Rows(SourceRow).Cells(0).Value

        End If

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources.obt2
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.obt1
    End Sub

End Class