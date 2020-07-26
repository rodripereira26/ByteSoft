Imports Logica
Public Class frmObtenerDiagnostico

    Private Sub frmObtenerDiagnostico_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim nombreDiagnostico As New ArrayList
        Dim pat As New ControladorPatologia

        For i As Integer = 0 To dgv11.RowCount - 1

            nombreDiagnostico.Add(dgv11.Rows(i).Cells(0).Value.ToString)

        Next

        pat.guardarDiagnostico(Datos_Temporales.user_temp, nombreDiagnostico)

    End Sub

End Class