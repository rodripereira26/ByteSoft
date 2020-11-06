Imports Logica
Public Class UCPatologia

    Private dtDescripcion As DataTable
    Public Sub New(sintomas As DataTable)

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
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomas, scroll, True)

        lblTitulo.Visible = False

        If sintomas.Rows.Count > 0 Then
            dtDescripcion = sintomas

            For Each sintoma As DataRow In sintomas.Rows
                dgvSintomas.Rows.Add(sintoma.Item(0))
            Next

            dgvSintomas.Rows(0).Selected = True
            setTextos(dgvSintomas.Rows(0).Cells(0).Value, 0)
        End If

    End Sub
    Public Sub New(nombre As String, sintomas As DataTable)

        InitializeComponent()
        Dim ScrollHelper As Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper
        ScrollHelper = New Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(dgvSintomas, scroll, True)

        lblTitulo.Text += " " & nombre
        lblTitulo.Location = New Point((Me.Width - lblTitulo.Width) / 2, lblTitulo.Location.Y)
        dtDescripcion = sintomas

        For Each sintoma As DataRow In sintomas.Rows
            dgvSintomas.Rows.Add(sintoma.Item(0))
        Next

        dgvSintomas.Rows(0).Selected = True
        setTextos(dgvSintomas.Rows(0).Cells(0).Value, 0)

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Dispose()
    End Sub

    Private Sub setTextos(sintoma As String, indice As Integer)
        Label1.Text = dtDescripcion.Rows.Item(indice).Item(1).ToString
        lblNomSin.Text = Principal.Singleton.Idioma("txtnomsimpxd", "¿Qué es ")
        lblNomSin.Text = lblNomSin.Text & sintoma.ToLower & "?"
    End Sub

    Private Sub dgvSintomas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSintomas.CellClick
        setTextos(dgvSintomas.CurrentCell.Value, dgvSintomas.CurrentCell.RowIndex)
    End Sub

End Class
