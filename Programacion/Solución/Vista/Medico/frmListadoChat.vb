﻿Imports Logica

Public Class frmListadoChat

    Private Sub frmChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chat As New ControladorChat
        dgvListadoChat.DataSource = chat.listarChat
        Me.dgvListadoChat.Columns("idChat").Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub dgvListadoChat_DoubleClick(sender As Object, e As EventArgs) Handles dgvListadoChat.DoubleClick

        Dim fila As Integer = dgvListadoChat.CurrentCell.RowIndex
        Dim cedula As String = dgvListadoChat.CurrentCell.Value.ToString
        Dim idChat As String = dgvListadoChat.Rows(fila).Cells(columnName:="idChat").Value.ToString
        Dim chat As New ControladorChat


        Dim respuesta As Integer

        respuesta = MsgBox("¿Desea entrar al chat con el usuario " + cedula + "?", vbQuestion + vbYesNo + vbDefaultButton2)

        If respuesta = vbYes Then

            chat.entrarChat(Datos_Temporales.user_temp, idChat)
            Datos_Temporales.idchat = idChat
            frmChat.Show()
            Me.Dispose()

        End If


    End Sub

    Private Sub btnRefrescarListadoPac_Click(sender As Object, e As EventArgs) Handles brnActualizar.Click
        Dim chat As New ControladorChat
        dgvListadoChat.DataSource = chat.listarChat
    End Sub

End Class