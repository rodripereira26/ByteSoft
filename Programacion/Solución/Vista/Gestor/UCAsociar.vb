Public Class UCAsociar

    Dim sourcedgv As String

    Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Dim ScrollHelper2 As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper

    Private Shared instancia As UCAsociar
    Public Sub New()

        InitializeComponent()

        For Each var As Control In Me.Controls

            If TypeOf var Is Panel Then

                For Each ctrl As Control In var.Controls

                    ctrl.Text = Principal.Singleton.Idioma(ctrl.Name, ctrl.Text)

                    If TypeOf ctrl Is Panel Then

                        For Each ctrl2 As Control In ctrl.Controls
                            ctrl2.Text = Principal.Singleton.Idioma(ctrl2.Name, ctrl2.Text)

                            If TypeOf ctrl2 Is Panel Then

                                For Each ctrl3 As Control In ctrl2.Controls
                                    ctrl3.Text = Principal.Singleton.Idioma(ctrl3.Name, ctrl3.Text)
                                    If TypeOf ctrl3 Is Panel Then
                                        For Each ctrl4 As Control In ctrl3.Controls
                                            ctrl4.Text = Principal.Singleton.Idioma(ctrl4.Name, ctrl4.Text)

                                            If TypeOf ctrl4 Is Panel Then
                                                For Each ctrl5 As Control In ctrl4.Controls
                                                    ctrl5.Text = Principal.Singleton.Idioma(ctrl5.Name, ctrl5.Text)

                                                Next

                                            End If
                                        Next

                                    End If
                                Next
                            End If
                        Next

                    End If
                Next


            End If
            var.Text = Principal.Singleton.Idioma(var.Name, var.Text)
        Next
    End Sub
    Public Shared Function Singleton() As UCAsociar
        If instancia Is Nothing Then
            instancia = New UCAsociar
        End If
        Return instancia
    End Function
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        dgvTodosLosSintomas.Rows.Clear()
        dgvSintomasSeleccionados.Rows.Clear()
        Me.Visible = False

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
            destino.Sort(destino.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            origen.Sort(origen.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            origen.Rows.RemoveAt(SourceRow)

        Else
            Exit Sub

        End If

    End Sub
    Private Sub dgvTodos_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvTodosLosSintomas.MouseDown
        selectItem(dgvTodosLosSintomas, dgvSintomasSeleccionados, e)
    End Sub

    Private Sub dgvSintomasSeleccionados_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvSintomasSeleccionados.MouseDown
        selectItem(dgvSintomasSeleccionados, dgvTodosLosSintomas, e)
    End Sub

    Private Sub dgvMisSintomas_DragOver(sender As Object, e As DragEventArgs) Handles dgvSintomasSeleccionados.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvMisSintomas_DragDrop(sender As Object, e As DragEventArgs) Handles dgvSintomasSeleccionados.DragDrop
        dropItem(dgvTodosLosSintomas, dgvSintomasSeleccionados, e)
    End Sub

    Private Sub dgvTodos_DragOver(sender As Object, e As DragEventArgs) Handles dgvTodosLosSintomas.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub dgvTodos_DragDrop(sender As Object, e As DragEventArgs) Handles dgvTodosLosSintomas.DragDrop
        dropItem(dgvSintomasSeleccionados, dgvTodosLosSintomas, e)
    End Sub

    Private Sub UCAsociar_Load(sender As Object, e As EventArgs) Handles Me.Load
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomasSeleccionados, scroll, True)

        ScrollHelper2 = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTodosLosSintomas, scroll2, True)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        For i = frmListado.Singleton.dt.Rows.Count - 1 To 0 Step -1

            If frmListado.Singleton.dt.Rows(i).Item(0) = lblPatologia.Text Then
                frmListado.Singleton.dt.Rows.RemoveAt(i)
            End If

        Next

        If dgvSintomasSeleccionados.Rows.Count <> 0 Then

            For i As Integer = 0 To dgvSintomasSeleccionados.Rows.Count - 1
                frmListado.Singleton.dt.Rows.Add(lblPatologia.Text, dgvSintomasSeleccionados.Rows(i).Cells(0).Value)
            Next

        Else
            MsgBox(Principal.Singleton.Idioma("msgSelecSintUCAsociar", "Debe seleccionar síntomas"))
        End If

    End Sub

End Class
