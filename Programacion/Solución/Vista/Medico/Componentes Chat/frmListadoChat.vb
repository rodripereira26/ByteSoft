Imports Logica
Public Class frmListadoChat
    Dim chat As New ControladorChat

    Private Sub frmListadoChat_Load(sender As Object, e As EventArgs) Handles Me.Load

        dgvListadoChat.DataSource = chat.listarChat
        Me.dgvListadoChat.Columns("idChat").Visible = False

    End Sub

    Private Sub dgvListadoChat_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoChat.CellDoubleClick

        Dim fila As Integer = dgvListadoChat.CurrentCell.RowIndex
        Dim cedula As String = dgvListadoChat.CurrentCell.Value.ToString
        Dim idChat As String = dgvListadoChat.Rows(fila).Cells(columnName:="idChat").Value.ToString
        Dim chat As New ControladorChat

        If chat.verificarCedula(idChat) Then

            Dim respuesta As Integer

            respuesta = MsgBox("¿Desea entrar al chat con el usuario " + cedula + "?", vbQuestion + vbYesNo + vbDefaultButton2)

            If respuesta = vbYes Then

                chat.entrarChat(Datos_Temporales.userLog, idChat)
                Datos_Temporales.idchat = idChat
                Datos_Temporales.pacienteSelecionado = cedula
                frmChat.Update()
                frmChat.Show()
                frmChat.setNombreUsuario(cedula)
                Me.Dispose()

            End If

        Else
            MsgBox("Error al ingresar al chat")
        End If
    End Sub
    Private Sub btnRefrescarListadoPac_Click(sender As Object, e As EventArgs) Handles brnActualizar.Click

        Dim chat As New ControladorChat
        dgvListadoChat.DataSource = chat.listarChat

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmBienvenidaMedico.Show()
        Me.Dispose()

    End Sub

    Private Sub dgvListadoChat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmChat.Update()
        frmChat.Show()
        Me.Dispose()
    End Sub

    Private Sub dgvListadoChat_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoChat.CellEnter

        sender.backcolor = Color.Gainsboro
    End Sub
End Class