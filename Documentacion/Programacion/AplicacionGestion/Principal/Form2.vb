Imports Vista
Public Class Form2
    Public Sub New()

        InitializeComponent()
        Dim login As New frmLogin()
        login.Show()
        Me.Hide()
    End Sub
End Class