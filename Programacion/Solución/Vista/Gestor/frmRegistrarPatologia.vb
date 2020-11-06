Imports Logica

Public Class frmRegistrarPatologia

    Dim sourcedgv As String
    Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Dim ScrollHelper2 As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Dim op As Byte
    Dim pat As New ControladorPatologia
    Private _nomActual, _descActual, _recActual, _prioActual
    Private cambiados As Boolean = False
    Public Sub New()

        ' This call is required by the designer.
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

        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomasSeleccionados, scroll, True)

        ScrollHelper2 = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTodosLosSintomas, scroll2, True)

        ScrollHelper.UpdateScrollBar()
        ScrollHelper2.UpdateScrollBar()
        traerSintomas()
    End Sub
    Public Sub New(op As Byte) '0 es default
        Me.op = op
        ' Esta llamada es exigida por el diseñador.
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

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomasSeleccionados, scroll, True)

        ScrollHelper2 = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTodosLosSintomas, scroll2, True)

        ScrollHelper.UpdateScrollBar()
        ScrollHelper2.UpdateScrollBar()

        Select Case op
            Case 0

            Case 1
                btnRegPatologia.Text = Principal.Singleton.Idioma("btnRegPat", "Modificar patologia")

        End Select

    End Sub

    Public Sub llenarCampos(nombre As String)

        Dim row As DataRow = pat.TraerPatologia(nombre).Rows(0)

        _nomActual = txtNomPat.Text = row.Item(0).ToString
        MsgBox(_nomActual)
        _descActual = txtDescPat.Text = row.Item(1).ToString
        _recActual = txtRecPat.Text = row.Item(2).ToString
        If row.Item(3) = 1 Then
            mrbPAlta.Checked = True
        ElseIf row.Item(3) = 2 Then
            mrbPMedia.Checked = True
        ElseIf row.Item(3) = 3 Then
            mrbPBaja.Checked = True
        End If
        _prioActual = row.Item(3)

        For Each sintoma In pat.TraerSintomasPatologia(row.Item(0))
            dgvSintomasSeleccionados.Rows.Add(sintoma)
        Next
        traerSintomas()
        cambiados = True
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

    Private Sub traerSintomas()
        If op = 0 Then
            Dim array As ArrayList = ControladorSintoma.Singleton.traerSintomas()

            For Each sintoma In array
                dgvTodosLosSintomas.Rows.Add(sintoma)
            Next

        ElseIf op = 1 Then
            Dim ali As New ArrayList

            For Each row As DataGridViewRow In dgvSintomasSeleccionados.Rows
                ali.Add(row.Cells(0).Value.ToString)
            Next

            Dim array As ArrayList = ControladorSintoma.Singleton.traerSintomas(ali)

            For Each sintoma In array
                dgvTodosLosSintomas.Rows.Add(sintoma)
            Next

            dgvTodosLosSintomas.Sort(dgvTodosLosSintomas.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        End If

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnRegPatologia.Click

        Select Case op
            Case 0
                Dim prioridad As Byte
                Dim ali As New ArrayList
                Dim check As New Verificacion

                If dgvSintomasSeleccionados.Rows.Count() <> 0 Then
                    If txtNomPat.Text <> Nothing Then
                        If txtDescPat.Text.Length > 10 Then
                            If txtRecPat.Text.Length > 10 Then
                                If mrbPAlta.Checked = True Or mrbPBaja.Checked = True Or mrbPMedia.Checked = True Then

                                    If mrbPAlta.Checked Then
                                        prioridad = 1
                                    ElseIf mrbPMedia.Checked Then
                                        prioridad = 2
                                    ElseIf mrbPBaja.Checked Then
                                        prioridad = 3
                                    End If

                                    For i = 0 To dgvSintomasSeleccionados.Rows.Count() - 1
                                        ali.Add(dgvSintomasSeleccionados.Rows(i).Cells(0).Value)
                                    Next

                                    Dim p As New ControladorPatologia(txtNomPat.Text.ToUpper, txtDescPat.Text.ToUpper, txtRecPat.Text.ToUpper, prioridad, ali)

                                    If p.VerificarBaja(txtNomPat.Text.ToUpper) Then

                                        If p.registrar() Then
                                            MsgBox(Principal.Singleton.Idioma("msgSuccessRegPat", "Patología registrada con éxito"))
                                            txtNomPat.Text = Nothing
                                            txtDescPat.Text = Nothing
                                            txtRecPat.Text = Nothing
                                            dgvTodosLosSintomas.Rows.Clear()
                                            dgvSintomasSeleccionados.Rows.Clear()
                                            mrbPAlta.Checked = False
                                            mrbPBaja.Checked = False
                                            mrbPMedia.Checked = False
                                            traerSintomas()
                                            ali.Clear()
                                        Else
                                            MsgBox(Principal.Singleton.Idioma("msgYaRegPat", "La patología ya fue ingresada"))
                                        End If

                                    Else
                                        Dim respuesta As Integer = MsgBox(Principal.Singleton.Idioma("msgReingPatYaReg", "La patología se encuentra dada de baja. ¿Desea reingresarla al sistema?"), vbQuestion + vbYesNo + vbDefaultButton2)

                                        If respuesta = vbYes Then

                                            Dim respuesta2 As Integer = MsgBox(Principal.Singleton.Idioma("msgActualizarPatDatos", "¿Desea actualizar la patología con los datos ingresados?"), vbQuestion + vbYesNo + vbDefaultButton2)

                                            If respuesta2 = vbYes Then
                                                If p.ReingresarConDatos(txtNomPat.Text.ToUpper, txtDescPat.Text.ToUpper, txtRecPat.Text.ToUpper, prioridad, ali) Then

                                                    MsgBox(Principal.Singleton.Idioma("msgActualizarPatDatosSuccess", "Patología reingresada con éxito"))
                                                    txtNomPat.Text = Nothing
                                                    txtDescPat.Text = Nothing
                                                    txtRecPat.Text = Nothing
                                                    dgvTodosLosSintomas.Rows.Clear()
                                                    dgvSintomasSeleccionados.Rows.Clear()
                                                    mrbPAlta.Checked = False
                                                    mrbPBaja.Checked = False
                                                    mrbPMedia.Checked = False
                                                    traerSintomas()
                                                    ali.Clear()
                                                Else
                                                    MsgBox(Principal.Singleton.Idioma("msgActualizarPatDatosError", "Error al reingresar la patología"))
                                                    ali.Clear()
                                                End If

                                            Else

                                                If p.ReingresarPatologia(txtNomPat.Text.ToUpper) Then
                                                    MsgBox(Principal.Singleton.Idioma("msgActualizarPatDatosSuccess", "Patología reingresada con éxito"))
                                                    txtNomPat.Text = Nothing
                                                    txtDescPat.Text = Nothing
                                                    txtRecPat.Text = Nothing
                                                    dgvTodosLosSintomas.Rows.Clear()
                                                    dgvSintomasSeleccionados.Rows.Clear()
                                                    mrbPAlta.Checked = False
                                                    mrbPBaja.Checked = False
                                                    mrbPMedia.Checked = False
                                                    traerSintomas()
                                                    ali.Clear()
                                                Else
                                                    MsgBox(Principal.Singleton.Idioma("msgActualizarPatDatosError", "Error al reingresar la patología"))
                                                    ali.Clear()
                                                End If

                                            End If

                                        End If

                                    End If

                                Else
                                    MsgBox(Principal.Singleton.Idioma("msgPrioridadPat", "Debe ingresar una prioridad"))
                                End If
                            Else
                                MsgBox(Principal.Singleton.Idioma("msgRecomendacionPat", "Debe ingresar una recomendación completa"))
                            End If
                        Else
                            MsgBox(Principal.Singleton.Idioma("msgDescripcionCompletaPat", "Debe ingresar una descripción completa"))
                        End If
                    Else
                        MsgBox(Principal.Singleton.Idioma("msgNombrePat", "Debe ingresar un nombre"))
                    End If
                Else
                    MsgBox(Principal.Singleton.Idioma("msgSintomasSeleccPat", "Debe seleccionar síntomas para la patología"))
                End If



            Case 1
                Dim prioridad As Byte
                Dim ali As New ArrayList
                Dim check As New Verificacion

                If dgvSintomasSeleccionados.Rows.Count() <> 0 Then
                    If txtNomPat.Text <> Nothing Then
                        If txtDescPat.Text.Length > 10 Then
                            If txtRecPat.Text.Length > 10 Then
                                If mrbPAlta.Checked = True Or mrbPBaja.Checked = True Or mrbPMedia.Checked = True Then

                                    If mrbPAlta.Checked Then
                                        prioridad = 1
                                    ElseIf mrbPMedia.Checked Then
                                        prioridad = 2
                                    ElseIf mrbPBaja.Checked Then
                                        prioridad = 3
                                    End If

                                    For i = 0 To dgvSintomasSeleccionados.Rows.Count() - 1
                                        ali.Add(dgvSintomasSeleccionados.Rows(i).Cells(0).Value)
                                    Next

                                    Dim p As New ControladorPatologia(txtNomPat.Text.ToUpper, txtDescPat.Text.ToUpper, txtRecPat.Text.ToUpper, prioridad, ali)

                                    If p.Modificar(Label1.Text) Then
                                        MsgBox(Principal.Singleton.Idioma("msgPatModificadaSuccess", "Patología modificada con éxito"))
                                        Label1.Text = txtNomPat.Text
                                        ali.Clear()
                                    Else
                                        MsgBox(Principal.Singleton.Idioma("msgModificarPatErr", "Error al modificar la patología"))
                                    End If
                                Else
                                    MsgBox(Principal.Singleton.Idioma("msgPrioridadIngresarPat", "Debe ingresar una prioridad"))
                                End If
                            Else
                                MsgBox(Principal.Singleton.Idioma("msgRecomendacionPat", "Debe ingresar una recomendación completa"))
                            End If
                        Else
                            MsgBox(Principal.Singleton.Idioma("msgDescripcionPat", "Debe ingresar una descripción completa"))
                        End If
                    Else
                        MsgBox(Principal.Singleton.Idioma("msgIngresarNombreErr", "Debe ingresar un nombre"))
                    End If
                Else
                    MsgBox(Principal.Singleton.Idioma("msgSeleccSintomasPat", "Debe seleccionar síntomas para la patología"))
                End If


        End Select



    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub pnlTituloPatologia_MouseDown(sender As Object, e As MouseEventArgs)
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub pnlTituloPatologia_MouseMove(sender As Object, e As MouseEventArgs)
        Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub pnlTituloPatologia_MouseUp(sender As Object, e As MouseEventArgs)
        Principal.Singleton.moverVentanaUp()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        If Not (txtDescPat.Text = Nothing And txtNomPat.Text = Nothing And txtRecPat.Text = Nothing And dgvSintomasSeleccionados.Rows.Count = 0) Then
            Dim res = MsgBox(Principal.Singleton.Idioma("msgInfoSinGuardarPat", "Hay información sin guardar, ¿seguro desea salir?"), vbYesNo)
            If res = vbYes Then
                Principal.Singleton.CambiarTamaño(frmOpciones)
                Me.Dispose()
            End If
        Else
            Principal.Singleton.CambiarTamaño(frmOpciones)
            Me.Dispose()
        End If

    End Sub

    Private Sub pnlTituloPatologia_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnSintomas_Click(sender As Object, e As EventArgs) Handles btnSintomasPatologia.Click

        pnlPatologia.BringToFront()
        transicion.Hide(pnlPatologia)
        transicion.Show(pnlSintomas)
    End Sub

    Private Sub txtDescPat_TextChanged(sender As Object, e As EventArgs) Handles txtDescPat.TextChanged
        lblCantDesc.Text = txtDescPat.Text.Length & "/300"
    End Sub

    Private Sub txtRecPat_TextChanged(sender As Object, e As EventArgs) Handles txtRecPat.TextChanged
        lblCantRec.Text = txtRecPat.Text.Length & "/300"
    End Sub

    Private Sub dgvTodosLosSintomas_Resize(sender As Object, e As EventArgs) Handles dgvTodosLosSintomas.Resize
        If ScrollHelper2 IsNot Nothing Then
            ScrollHelper2.UpdateScrollBar()
        End If

    End Sub
    Private Sub dgvSintomasSeleccionados_Resize(sender As Object, e As EventArgs) Handles dgvSintomasSeleccionados.Resize
        If ScrollHelper IsNot Nothing Then
            ScrollHelper.UpdateScrollBar()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        pnlSintomas.BringToFront()
        transicion.Hide(pnlSintomas)
        transicion.Show(pnlPatologia)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If op = 0 Then
            If Not (txtDescPat.Text = Nothing And txtNomPat.Text = Nothing And txtRecPat.Text = Nothing And dgvSintomasSeleccionados.Rows.Count = 0) Then
                Dim res = MsgBox(Principal.Singleton.Idioma("msgInfoSinGuardarPat", "Hay información sin guardar, ¿Seguro desea salir?"), vbYesNo)
                If res = vbYes Then
                    Principal.Singleton.CambiarTamaño(frmOpciones)
                    Me.Dispose()
                End If
            Else
                Principal.Singleton.CambiarTamaño(frmOpciones)
                Me.Dispose()
            End If

        ElseIf op = 1 Then

            Principal.Singleton.CambiarTamaño(frmListado)
            Me.Dispose()

        End If

    End Sub

    Private Sub txtDescPat_GotFocus(sender As Object, e As EventArgs) Handles txtDescPat.GotFocus
        sepDesc.LineColor = Colores.violeta_DARK
    End Sub

    Private Sub txtRecPat_GotFocus(sender As Object, e As EventArgs) Handles txtRecPat.GotFocus
        sepRec.LineColor = Colores.violeta_DARK
    End Sub

End Class