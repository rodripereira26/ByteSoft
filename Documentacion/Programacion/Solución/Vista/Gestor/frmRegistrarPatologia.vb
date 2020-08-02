Imports Logica
Public Class frmRegistrarPatologia
    Dim sourcedgv As String
    Dim p As New Principal
    Private Sub RegistrarPatologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p.roundedCorners(Me)
        traerSintomas()

    End Sub

    Private Sub selectItem(origen As DataGridView, destino As DataGridView, e As MouseEventArgs)
        sourcedgv = origen.Name ' obtiene el nombre del datagridview de origen
        Dim SourceRow = origen.HitTest(e.X, e.Y).RowIndex 'obtiene el indice de la fila que contiene las coordenadas

        If SourceRow >= 0 Then ' el usuario solo puede seleccionar una fila, no el fondo de la tabla         
            destino.BorderStyle = BorderStyle.FixedSingle
            origen.Rows(SourceRow).Selected = True
            origen.DoDragDrop(SourceRow, DragDropEffects.Move)
        End If
    End Sub

    Private Sub dropItem(origen As DataGridView, destino As DataGridView, e As DragEventArgs)
        If sourcedgv <> destino.Name Then ' evita que el usuario arrastre una row a la misma datagridview de origen

            destino.BorderStyle = BorderStyle.None
            destino.Rows.Add() 'agrega una row vacia para que entre el elemento

            Dim SourceRow = (e.Data.GetData(Type.GetType("System.Int32")))

            Dim rowDestino = destino.Rows.Count - 1

            destino.Rows(rowDestino).Cells(0).Value = origen.Rows(SourceRow).Cells(0).Value
            origen.Rows.RemoveAt(SourceRow)

        Else
            Exit Sub

        End If
    End Sub
    Private Sub dgvTodos_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvTodos.MouseDown
        selectItem(dgvTodos, dgvSintomasSeleccionados, e)
    End Sub
    Private Sub dgvSintomasSeleccionados_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvSintomasSeleccionados.MouseDown
        selectItem(dgvSintomasSeleccionados, dgvTodos, e)
    End Sub
    Private Sub dgvMisSintomas_DragOver(sender As Object, e As DragEventArgs) Handles dgvSintomasSeleccionados.DragOver
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub dgvMisSintomas_DragDrop(sender As Object, e As DragEventArgs) Handles dgvSintomasSeleccionados.DragDrop
        dropItem(dgvTodos, dgvSintomasSeleccionados, e)
    End Sub
    Private Sub dgvTodos_DragOver(sender As Object, e As DragEventArgs) Handles dgvTodos.DragOver
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub dgvTodos_DragDrop(sender As Object, e As DragEventArgs) Handles dgvTodos.DragDrop
        dropItem(dgvSintomasSeleccionados, dgvTodos, e)
    End Sub

    Private Sub traerSintomas()

        Dim s As New ControladorSintoma
        Dim arraySintomas = s.traerSintomas

        For i = 0 To arraySintomas.Count - 1
            dgvTodos.Rows.Add(arraySintomas(i))
        Next

    End Sub


    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        Dim prioridad As Byte
        Dim ali As New ArrayList
        Dim check As New Verificacion

        If dgvSintomasSeleccionados.Rows.Count() <> 0 Then
            If txtDescPat.Text.Length > 10 Then
                If txtRecPat.Text.Length > 10 Then

                    If cb1.Checked Then
                        prioridad = 1
                    ElseIf cb2.Checked Then
                        prioridad = 2
                    ElseIf cb3.Checked Then
                        prioridad = 3
                    End If

                    For i = 0 To dgvSintomasSeleccionados.Rows.Count() - 1
                        ali.Add(dgvSintomasSeleccionados.Rows(i).Cells(0).Value)
                    Next

                    Dim p As New ControladorPatologia(txtNomPat.Text, txtDescPat.Text, txtRecPat.Text, prioridad, ali)

                    If p.registrar() Then

                        MsgBox("Patología registrada con éxito")
                        Dim s As New ControladorSintoma
                        txtNomPat.Clear()
                        txtDescPat.Clear()
                        txtRecPat.Clear()
                        dgvTodos.Rows.Clear()
                        dgvSintomasSeleccionados.Rows.Clear()
                        traerSintomas()

                    Else
                        MsgBox("Error al registrar la patología")
                    End If

                Else
                    MsgBox("Debe ingresar una recomendación completa")
                End If
            Else
                MsgBox("Debe ingresar una descripción completa")
            End If
        Else
            MsgBox("Debe seleccionar síntomas para la patología")
        End If

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Close()
    End Sub

    Private Sub pnlTituloPatologia_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTituloPatologia.MouseDown
        p.moverVentanaDown(Me)
    End Sub

    Private Sub pnlTituloPatologia_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTituloPatologia.MouseMove
        p.moverVentanaMove(Me)
    End Sub

    Private Sub pnlTituloPatologia_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTituloPatologia.MouseUp
        p.moverVentanaUp()
    End Sub
End Class