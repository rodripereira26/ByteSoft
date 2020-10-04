Imports Logica
Public Class frmObtenerDiagnostico

    Dim pat As New ControladorPatologia
    dim solicitud as boolean = True



    Private Sub frmObtenerDiagnostico_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub frmObtenerDiagnostico_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub dgvPosiblesDiagnosticos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPosiblesDiagnosticos.CellDoubleClick

        If pat.informacionPatologia(dgvPosiblesDiagnosticos.CurrentCell.Value.ToString) Is Nothing Then
            MsgBox("Error al obtener la descripción")
        Else
            ucRespuesta.lblNom.Text = dgvPosiblesDiagnosticos.CurrentCell.Value.ToString
            ucRespuesta.lblDesc.Text = pat.informacionPatologia(dgvPosiblesDiagnosticos.CurrentCell.Value.ToString)
            ucRespuesta.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Principal.Singleton.CambiarTamaño(frmIngresarSintomas)
        solicitud = True
        Me.Dispose()
    End Sub

    Private Sub btnSolicitarChat_Click(sender As Object, e As EventArgs) Handles btnSolicitarChat.Click

        Dim chat As New ControladorChat

    if solicitud then
        If chat.crearChat() <> 0 Then
            If chat.entrarChat(Datos_Temporales.userLog, Datos_Temporales.idchat) Then
                
                MsgBox("Se ha enviado una solicitud de chat")
                frmBienvenidaPaciente.Timer1.Enabled = True
                    solicitud = False

                Else
                    MsgBox("Error al enviar solicitud de chat")
            End If
        End If
    else
    msgbox("Ya hay una solicitud en curso")
    end if

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLogin.Visible = True
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub dgvPosiblesDiagnosticos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPosiblesDiagnosticos.CellContentClick

    End Sub
End Class