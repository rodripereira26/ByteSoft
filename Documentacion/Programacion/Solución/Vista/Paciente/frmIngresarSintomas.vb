Imports Logica

Public Class frmIngresarSintomas

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim p As New Principal
        p.roundedCorners(Me)

        Dim sintomas As New ControladorSintoma

        For i As Integer = 0 To sintomas.traerSintomas.Count - 1

            dgvSintomas.Rows.Add(sintomas.traerSintomas.Item(i))

        Next

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

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        Dim misSintomas As New ArrayList
        Dim pat As New ControladorPatologia
        Dim sin As New ControladorSintoma

        For i As Integer = 0 To dgvMisSintomas.RowCount - 1

            If dgvMisSintomas.Rows.Item(i).Cells(0).Value <> Nothing Then

                misSintomas.Add(dgvMisSintomas.Rows.Item(i).Cells(0).Value.ToString)

            End If

        Next

        If misSintomas.Count > 0 Then

            If sin.guardarSintomas(Datos_Temporales.user_temp, misSintomas) Then

                If pat.obtenerPatologia(misSintomas).Rows.Count > 0 Then

                    frmObtenerDiagnostico.dgv11.DataSource = pat.obtenerPatologia(misSintomas)
                    frmObtenerDiagnostico.Show()
                    Me.Hide()
                Else
                    MsgBox("No se encontraron patologías que contenga los síntomas seleccionados")

                End If

            End If

        Else
            MsgBox("No seleccionó ningún síntoma")
        End If

    End Sub

End Class