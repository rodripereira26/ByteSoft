Imports Logica
Public Class frmRegistrarPatologia
    Private Sub RegistrarPatologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As New ControladorSintoma
        Dim arraySintomas = s.traerSintomas

        For i = 0 To arraySintomas.Count - 1
            dgvTodos.Rows.Add(arraySintomas(i))
        Next

    End Sub
    Private Sub dgvTodos_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvTodos.MouseDown
        Dim SourceRow = dgvTodos.HitTest(e.X, e.Y).RowIndex 'obtiene el indice de la fila que contiene las coordenadas
        If SourceRow >= 0 Then ' el usuario solo puede seleccionar una fila, no el fondo de la tabla           
            dgvTodos.Rows(SourceRow).Selected = True
            dgvTodos.DoDragDrop(SourceRow, DragDropEffects.Move)
        End If

    End Sub

    Private Sub dgvMisSintomas_DragOver(sender As Object, e As DragEventArgs) Handles dgvSintomasSeleccionados.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvMisSintomas_DragDrop(sender As Object, e As DragEventArgs) Handles dgvSintomasSeleccionados.DragDrop

        dgvSintomasSeleccionados.Rows.Add() 'agrega una row vacia para que entre el elemento
        Dim SourceRow = (e.Data.GetData(Type.GetType("System.Int32")))

        Dim rowDestino = dgvSintomasSeleccionados.Rows.Count - 1
        Try
            dgvSintomasSeleccionados.Rows(rowDestino).Cells(0).Value = dgvTodos.Rows(SourceRow).Cells(0).Value
        Catch ex As Exception

        End Try


        dgvTodos.Rows.RemoveAt(SourceRow)

    End Sub

    Private Sub dgvSintomasSeleccionados_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvSintomasSeleccionados.MouseDown
        Dim SourceRow = dgvSintomasSeleccionados.HitTest(e.X, e.Y).RowIndex 'obtiene el indice de la fila que contiene las coordenadas
        If SourceRow >= 0 Then
            dgvSintomasSeleccionados.Rows(SourceRow).Selected = True
            dgvSintomasSeleccionados.DoDragDrop(SourceRow, DragDropEffects.Move)
        End If

    End Sub

    Private Sub dgvTodos_DragOver(sender As Object, e As DragEventArgs) Handles dgvTodos.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvTodos_DragDrop(sender As Object, e As DragEventArgs) Handles dgvTodos.DragDrop

        dgvTodos.Rows.Add() 'agrega una row vacia para que entre el elemento
        Dim SourceRow = (e.Data.GetData(Type.GetType("System.Int32")))

        Dim rowDestino = dgvTodos.Rows.Count - 1
        dgvTodos.Rows(rowDestino).Cells(0).Value = dgvSintomasSeleccionados.Rows(SourceRow).Cells(0).Value

        dgvSintomasSeleccionados.Rows.RemoveAt(SourceRow)

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

        For i = 0 To dgvSintomasSeleccionados.Rows.Count() - 1
            ali.Add(dgvSintomasSeleccionados.Rows(i).Cells(0).Value)

        Next

        Try
            Dim p As New ControladorPatologia(txtNomPat.Text, txtDescPat.Text, txtRecPat.Text, prioridad, ali)
            p.registrar()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Close()
    End Sub

End Class