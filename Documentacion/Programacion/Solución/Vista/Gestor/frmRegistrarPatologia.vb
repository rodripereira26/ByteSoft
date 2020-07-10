Imports Logica
Public Class frmRegistrarPatologia
    Private Sub RegistrarPatologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        dgvTodos.Rows.Add("Fiebre")

        dgvTodos.Rows.Add("Escalofrios")
        dgvTodos.Rows.Add("Dolor de pecho")
        dgvTodos.Rows.Add("Mareos")
    End Sub
    Private Sub dgvSintomas_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvTodos.MouseDown
        Dim SourceRow As Integer
        SourceRow = dgvTodos.HitTest(e.X, e.Y).RowIndex
        dgvTodos.DoDragDrop(SourceRow, DragDropEffects.Move)
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
            dgvMisSintomas.Rows(rowDestino).Cells(colDestino).Value = dgvTodos.Rows(SourceRow).Cells(0).Value

        End If

    End Sub
    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        Dim prioridad As Byte
        If cb1.Checked Then
            prioridad = 1
        ElseIf cb2.Checked Then
            prioridad = 2
        ElseIf cb3.Checked Then
            prioridad = 3
        End If

        Dim ali As New ArrayList

        For i = 0 To dgvMisSintomas.Rows.Count() - 1

            ali.Add(dgvMisSintomas.Rows(i).Cells(0).Value)

        Next

        Dim p As New Patologia(txtNomPat.Text, txtDescPat.Text, txtRecPat.Text, prioridad, ali)
        p.agregar(ali)
    End Sub
End Class