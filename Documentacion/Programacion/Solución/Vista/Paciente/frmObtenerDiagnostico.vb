﻿Imports Logica
Public Class frmObtenerDiagnostico

    Private Sub frmObtenerDiagnostico_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim nombreDiagnostico As New ArrayList
        Dim pat As New ControladorPatologia

        For i As Integer = 0 To dgv11.RowCount - 1

            nombreDiagnostico.Add(dgv11.Rows(i).Cells(0).Value.ToString)

        Next

        If pat.guardarDiagnostico(Datos_Temporales.user_temp, nombreDiagnostico) = False Then
            MsgBox("Error al almacenar el diagnóstico")
        End If

    End Sub

End Class