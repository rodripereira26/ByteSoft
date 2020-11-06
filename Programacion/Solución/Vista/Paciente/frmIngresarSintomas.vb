Imports Logica

Public Class frmIngresarSintomas

    Dim sourcedgv As String
    Dim dv As New DataView
    Public opcion As op
    Dim ScrollHelperSeleccionados As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Dim ScrollHelperTodos As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
    Private Shared instancia As frmIngresarSintomas
    Dim aliPatologias As ArrayList

    Public Enum op
        sintomas = 0
        modificarPaciente = 1
        regsitrarPatologia = 2
    End Enum

    Public Shared Function ObtenerInstancia() As frmIngresarSintomas
        Return instancia
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ScrollHelperSeleccionados = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomasSeleccionados, scrollSeleccionados, True)
        ScrollHelperTodos = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvTodos, scrollTodos, True)

    End Sub

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

    Public Sub New(aliPatologias As ArrayList, op As op)

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

        Me.opcion = op
        Me.aliPatologias = aliPatologias

        Select Case op
            Case op.modificarPaciente

                lblMisSintomas.Text = Principal.Singleton.Idioma("lblMisPatologiasIngresar", "Mis patologías")
                lblIngreseSIntomas.Text = Principal.Singleton.Idioma("lblModificarCronicas", "Modificar patologías crónicas")
                lblArrastreSintomas.Text = Principal.Singleton.Idioma("lblArrastrarDerIzq", "Arrastre patologías hacia la derecha o izquierda")
                btnObtenerDiag.Enabled = False
                btnObtenerDiag.Text = Principal.Singleton.Idioma("btnModPatCronicas", "Modificar patologías crónicas")
                Dim pat As New ControladorPatologia
                Dim pac As New ControladorPaciente

                For Each patologia As DataRow In pat.getPatologiasPaciente(Datos_Temporales.userLog).Rows
                    dgvTodos.Rows.Add(patologia.Item(0))
                Next

                For Each patologia As DataRow In pac.getPatologiasCronicas(Datos_Temporales.userLog).Rows
                    dgvSintomasSeleccionados.Rows.Add(patologia.Item(0))
                Next

                dgvTodos.Sort(dgvTodos.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

            Case op.regsitrarPatologia

                lblMisSintomas.Text = Principal.Singleton.Idioma("lblMispatReg", "Mis patologías crónicas")
                lblIngreseSIntomas.Text = Principal.Singleton.Idioma("lblRegistrarCronicass", "Registrar patologías crónicas")
                lblArrastreSintomas.Text = Principal.Singleton.Idioma("lblArrastrarRegCrinicas", "Arrastre patologías hacia la derecha")
                btnObtenerDiag.Enabled = True
                btnObtenerDiag.Text = Principal.Singleton.Idioma("btnGuardarPatologiasCronicas", "Guardar Patologías")

                For Each patologia In aliPatologias
                    dgvTodos.Rows.Add(patologia)
                Next

                dgvTodos.Sort(dgvTodos.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        End Select

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

    Private Sub dgvSintomasSeleccionados_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvSintomasSeleccionados.RowsAdded

        If Me.opcion = op.modificarPaciente Then
            Dim i = 0
            Dim contador As Short = 0

            If (aliPatologias.Count <> dgvSintomasSeleccionados.Rows.Count) And (dgvSintomasSeleccionados.Rows.Count <> 0) Then
                btnObtenerDiag.Enabled = True
            Else
                For Each patologia In aliPatologias
                    For Each patSeleccionada As DataGridViewRow In dgvSintomasSeleccionados.Rows
                        If patologia = patSeleccionada.Cells(0).Value Then
                            contador += 1

                        End If
                    Next

                Next
                If contador <> aliPatologias.Count Then
                    btnObtenerDiag.Enabled = True
                Else
                    btnObtenerDiag.Enabled = False
                End If
            End If
        End If


    End Sub

    Private Sub dgvSintomasSeleccionados_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvSintomasSeleccionados.RowsRemoved
        If opcion = op.modificarPaciente Then
            Dim i = 0
            Dim contador As Short = 0

            If (aliPatologias.Count <> dgvSintomasSeleccionados.Rows.Count) And (dgvSintomasSeleccionados.Rows.Count <> 0) Then
                btnObtenerDiag.Enabled = True
            Else
                For Each patologia In aliPatologias
                    For Each patSeleccionada As DataGridViewRow In dgvSintomasSeleccionados.Rows
                        If patologia = patSeleccionada.Cells(0).Value Then
                            contador += 1

                        End If
                    Next

                Next
                If contador <> aliPatologias.Count Then
                    btnObtenerDiag.Enabled = True
                Else
                    btnObtenerDiag.Enabled = False
                End If
            End If
        End If

    End Sub

    Public Sub New(op As op)

        InitializeComponent()

        Dim lista As New List(Of Panel)

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








        Me.opcion = op
        instancia = Me
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

        Select Case op
            Case op.sintomas
                For Each sintoma In ControladorSintoma.Singleton.traerSintomas
                    dgvTodos.Rows.Add(sintoma)
                Next

        End Select

        dgvTodos.Sort(dgvTodos.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub selectItem(origen As DataGridView, destino As DataGridView, e As MouseEventArgs)

        sourcedgv = origen.Name
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
            Exit Sub 'OPCIONAL COLOCAR 
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

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
    End Sub

    Private Sub btnObtenerDiag_Click(sender As Object, e As EventArgs) Handles btnObtenerDiag.Click

        Select Case Me.opcion
            Case op.modificarPaciente

                Dim pat As New ControladorPatologia
                Dim pac As New ControladorPaciente
                Dim aliPatologiasNuevas As New ArrayList

                For Each patologia In dgvSintomasSeleccionados.Rows

                    If patologia.Cells(0).Value <> Nothing Then

                        aliPatologiasNuevas.Add(patologia.Cells(0).Value.ToString)

                    End If

                Next

                If pac.updatePatologiasPaciente(Datos_Temporales.userLog, aliPatologiasNuevas) Then
                    MsgBox(Principal.Singleton.Idioma("msgBoxPatCronicaModificada", "Patologias crónicas modificadas con éxito"))

                Else
                    MsgBox(Principal.Singleton.Idioma("msgBoxErrorPatCronica", "Error al modificar las patologías crónicas"))
                End If

            Case op.sintomas
                Dim misSintomas As New ArrayList
                Dim pat As New ControladorPatologia
                Dim sin As New ControladorSintoma

                For i As Integer = 0 To dgvSintomasSeleccionados.RowCount - 1

                    If dgvSintomasSeleccionados.Rows.Item(i).Cells(0).Value <> Nothing Then

                        misSintomas.Add(dgvSintomasSeleccionados.Rows.Item(i).Cells(0).Value.ToString)

                    End If

                Next

                If misSintomas.Count > 0 Then

                    Dim dt = pat.obtenerPatologia(misSintomas)

                    If dt.Rows.Count > 0 Then

                        Dim frm As New frmObtenerDiagnostico(dt, misSintomas)
                        Me.SuspendLayout()
                        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                        Principal.Singleton.CambiarTamaño(frmObtenerDiagnostico)
                        frm.Show()
                        pnlContenedor.Hide()
                        pnlInstancia.Show()
                        Me.ResumeLayout()

                        dt.Clear()
                        misSintomas.Clear()
                    Else

                        MsgBox(Principal.Singleton.Idioma("msgBoxErrorEncontrarPatologias", "No se encontraron patologías que contenga los síntomas seleccionados"))

                    End If

                Else
                    MsgBox(Principal.Singleton.Idioma("msgBoxErrorSeleccionarSintoma", "No seleccionó ningún síntoma"))
                End If
            Case op.regsitrarPatologia
                If dgvSintomasSeleccionados.Rows.Count > 0 Then

                    Dim instancia As frmRegistroPaciente = Me.ParentForm
                    instancia.aliPatologias.Clear()

                    For Each patologia As DataGridViewRow In dgvSintomasSeleccionados.Rows

                        instancia.aliPatologias.Add(patologia.Cells(0).Value)

                    Next
                    MsgBox(Principal.Singleton.Idioma("msgBoxPatologiasGuardadas", "Patologías guardadas"))
                Else
                    MsgBox(Principal.Singleton.Idioma("msgBoxDebeIngresarpatologia", "Debe ingresar patologías"))


                End If
        End Select

    End Sub

    Private Sub dgvTodos_Paint(sender As Object, e As PaintEventArgs) Handles dgvTodos.Paint, dgvSintomasSeleccionados.Paint
        ScrollHelperSeleccionados.UpdateScrollBar()
        ScrollHelperTodos.UpdateScrollBar()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click

        Select Case opcion
            Case op.modificarPaciente
                Principal.Singleton.CambiarTamaño(frmBienvenidaPaciente)
                Me.Dispose()
            Case op.regsitrarPatologia
                Principal.Singleton.CambiarTamaño(frmRegistroPaciente)
                Me.Dispose()
            Case op.sintomas
                Principal.Singleton.CambiarTamaño(frmBienvenidaPaciente)
                Me.Dispose()
        End Select

    End Sub

End Class