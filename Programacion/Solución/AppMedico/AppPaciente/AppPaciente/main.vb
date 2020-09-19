Imports Logica
Imports Vista
Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim frm As New frmLogin
        frm.mcbRecordarUsuario.Visible = False
        Principal.Singleton.CargarVentana(Me.Panel1, frm)

    End Sub
End Class
