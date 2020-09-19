Imports Logica
Imports Vista
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim frm As New frmLogin
        Principal.Singleton.CargarVentana(Me.Panel1, frm)
        Datos_Temporales.rol = "M"

    End Sub
End Class
