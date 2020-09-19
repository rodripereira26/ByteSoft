Imports Logica
Imports Vista

Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim frm As New frmLogin
        Principal.Singleton.CargarVentana(Me.Panel1, frm)
        Datos_Temporales.rol = "G"
    End Sub
End Class
