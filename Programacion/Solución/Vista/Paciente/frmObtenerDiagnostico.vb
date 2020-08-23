Imports Logica
Public Class frmObtenerDiagnostico

    Dim pat As New ControladorPatologia
    dim solicitud as boolean = true

    Private Sub frmObtenerDiagnostico_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub frmObtenerDiagnostico_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub dgvPosiblesDiagnosticos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPosiblesDiagnosticos.CellDoubleClick

        If pat.informacionPatologia(dgvPosiblesDiagnosticos.CurrentCell.Value.ToString) Is Nothing Then
            MsgBox("Error al obtener la descripción")
        Else
            UserControl11.lblNom.Text = dgvPosiblesDiagnosticos.CurrentCell.Value.ToString
            UserControl11.lblDesc.Text = pat.informacionPatologia(dgvPosiblesDiagnosticos.CurrentCell.Value.ToString)
            UserControl11.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmIngresarSintomas.Visible = True
        solicitud = true
        Me.Dispose()
    End Sub

    Private Sub btnSolicitarChat_Click(sender As Object, e As EventArgs) Handles btnSolicitarChat.Click

        Dim chat As New ControladorChat

    if solicitud then
        If chat.crearChat() <> 0 Then
            If chat.entrarChat(Datos_Temporales.user_temp, Datos_Temporales.idchat) Then
                
                MsgBox("Se ha enviado una solicitud de chat")
                frmBienvenidaPaciente.Timer1.Enabled = True
                solicitud = false
            Else
                MsgBox("Error al enviar solicitud de chat")
            End If
        End If
    else
    msgbox("Ya hay una solicitud en curso")
    end if

    End Sub

End Class