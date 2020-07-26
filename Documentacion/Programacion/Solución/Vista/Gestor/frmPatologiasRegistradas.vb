﻿Imports Logica
Imports MaterialSkin
''https://github.com/IgnaceMaes/MaterialSkin

Public Class frmPatologiasRegistradas

    Dim p As New Principal
    Dim criterio As String
    Dim textoBusqueda As String = "Buscar por " & Me.criterio

    Private Sub frmPatologiasRegistradas_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim p As New ControladorPatologia
        Dim principal As New Principal
        principal.metroStyle(Me)

        dgvListadoPatologias.DataSource = p.listarPatologias
        Panel1.Height = btnBuscarPor.Height

        For i As Integer = 0 To dgvListadoPatologias.Rows.Count - 1

            If dgvListadoPatologias.Rows(i).Cells(3).Value = 1 Then

                dgvListadoPatologias.Rows(i).Cells(3).Value = "Alta"

            ElseIf dgvListadoPatologias.Rows(i).Cells(3).Value = 2 Then

                dgvListadoPatologias.Rows(i).Cells(3).Value = "Media"

            Else
                dgvListadoPatologias.Rows(i).Cells(3).Value = "Baja"

            End If

        Next

    End Sub

    Private Sub btnSeleccionMultiple_Click(sender As Object, e As EventArgs)

        If dgvListadoPatologias.MultiSelect = True Then

            dgvListadoPatologias.MultiSelect = False
            btnSeleccionMultiple.Text = "activar selección múltiple"

        Else
            dgvListadoPatologias.MultiSelect = True
            btnSeleccionMultiple.Text = "desactivar selección múltiple"

        End If

    End Sub

    Private Sub dgvListadoPatologias_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvListadoPatologias.MouseClick
        'btnEliminarElementos.Visible = True
        'btnModificarElemento.Visible = True
    End Sub

    Private Sub dgvListadoPatologias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoPatologias.CellDoubleClick

        If dgvListadoPatologias.MultiSelect = False Then

        End If

    End Sub

    Private Sub MaterialSingleLineTextField2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialSingleLineTextField1_LostFocus(sender As Object, e As EventArgs) Handles txtBuscar.LostFocus

        If txtBuscar.Text = "" Then

            txtBuscar.Text = textoBusqueda

        End If

    End Sub

    Private Sub dgvListadoPatologias_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListadoPatologias.SelectionChanged

        If dgvListadoPatologias.MultiSelect = True And dgvListadoPatologias.SelectedRows.Count > 1 Then

            btnEliminarElementos.Enabled = True
            lblCantSelecc.Text = dgvListadoPatologias.SelectedRows.Count.ToString
            btnEliminarElementos.Text = "eliminar " & dgvListadoPatologias.SelectedRows.Count.ToString & " patologías"
            btnModificarElemento.Enabled = False

        ElseIf dgvListadoPatologias.SelectedRows.Count = 1 Then

            btnEliminarElementos.Enabled = True
            btnModificarElemento.Enabled = True
            btnEliminarElementos.Text = "eliminar patología seleccionada"

            If dgvListadoPatologias.MultiSelect = True Then

                lblCantSelecc.Text = "1"

            End If

        Else

            lblCantSelecc.Text = Nothing 'al cambiar a modo de seleccion unica, el count de rows seleccionadas no cambiaba a 0
            btnEliminarElementos.Enabled = False
            btnModificarElemento.Enabled = False

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        If btnPrio.Visible = False Then
            btnDesc.Visible = True
            btnNom.Visible = True
            btnPrio.Visible = True

        Else
            btnDesc.Visible = False
            btnNom.Visible = False
            btnPrio.Visible = False

        End If

    End Sub

    Private Sub btnBuscarPor_Click(sender As Object, e As EventArgs) Handles btnBuscarPor.Click

        If btnPrio.Visible = False Then

            Panel1.Height = 191
            btnPrio.Visible = True
            btnRec.Visible = True
            btnNom.Visible = True
            btnDesc.Visible = True

        Else
            Panel1.Height = btnBuscarPor.Height
            btnPrio.Visible = False
            btnRec.Visible = False
            btnNom.Visible = False
            btnDesc.Visible = False

        End If

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles btnSeleccionMultiple.Click

        If dgvListadoPatologias.MultiSelect = True Then

            dgvListadoPatologias.MultiSelect = False
            btnSeleccionMultiple.Text = "activar selección múltiple"

        Else
            dgvListadoPatologias.MultiSelect = True
            btnSeleccionMultiple.Text = "desactivar selección múltiple"

        End If

    End Sub

    Private Sub btnModificarElemento_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEliminarElementos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles txtBuscar.Click

        If txtBuscar.Text = "Buscar" Then

            txtBuscar.Text = ""

        End If

    End Sub

    Private Sub btnPrio_Click(sender As Object, e As EventArgs) Handles btnPrio.Click, btnDesc.Click, btnRec.Click, btnNom.Click

        btnBuscarPor.Text = "buscar por " & sender.text
        Me.criterio = sender.text
        Panel1.Height = btnBuscarPor.Height
        btnPrio.Visible = False
        btnRec.Visible = False
        btnNom.Visible = False
        btnDesc.Visible = False

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Dim dt As New DataTable
        Dim bs As New BindingSource

        bs.DataSource = dgvListadoPatologias.DataSource
        dt.DefaultView.RowFilter = String.Format("'{0}'", txtBuscar.Text)
        bs.Filter = "Nombre like '%" & txtBuscar.Text & "%'"
        dgvListadoPatologias.DataSource = bs

    End Sub

    Private Sub btnBuscarPor_TextChanged(sender As Object, e As EventArgs) Handles btnBuscarPor.TextChanged

    End Sub

    Private Sub btnBuscarPor_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBuscarPor.MouseClick

        If txtBuscar.Text = "" Then

            txtBuscar.Text = "Buscar por " & Me.criterio

        End If

    End Sub

    '''<summary>
    '''Movimiento de ventanas sin bordes
    '''</summary>
    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        p.moverVentanaDown(Me)
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        p.moverVentanaMove(Me)
    End Sub

    Public Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        p.moverVentanaUp()
    End Sub

    Private Sub btnEliminarElementos_Click_1(sender As Object, e As EventArgs) Handles btnEliminarElementos.Click

        Dim YN As Integer

        If dgvListadoPatologias.SelectedRows.Count = 1 Then

            YN = MsgBox("¿Seguro desea eliminar esta patología?", vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar patología")

        Else
            YN = MsgBox("¿Seguro desea eliminar " & dgvListadoPatologias.SelectedRows.Count & " patologías?", vbQuestion + vbYesNo + vbDefaultButton2, "Eliminar patologías")

        End If

        If YN = vbYes Then

            Dim pat As New ControladorPatologia
            Dim arrayNombrePatologias As New ArrayList

            For Each selectedRow As DataGridViewRow In dgvListadoPatologias.SelectedRows
                arrayNombrePatologias.Add(dgvListadoPatologias.Rows(selectedRow.Index).Cells(0).Value.ToString)
            Next

            If pat.eliminarPatologias(arrayNombrePatologias) Then

                For Each selectedRow2 As DataGridViewRow In dgvListadoPatologias.SelectedRows
                    dgvListadoPatologias.Rows.Remove(selectedRow2)
                Next

            End If

        End If

    End Sub

End Class
