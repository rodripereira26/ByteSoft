Imports Logica
Imports Vista
Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim frm As New frmLogin
        frm.mcbRecordarUsuario.Visible = False
        Principal.Singleton.CargarVentana(Me.Panel1, frm)
        Principal.Singleton.roundedCorners(Me)

    End Sub

    Private Sub pnlTopBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseDown
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub pnlTopBar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseMove
        Principal.Singleton.moverVentanaMove(Me)
    End Sub

    Private Sub pnlTopBar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTopBar.MouseUp
        Principal.Singleton.moverVentanaUp()
    End Sub
End Class
