Public Class Mensaje
    Private Property esEnviado As Boolean

    Public Sub New(isReceiver As Boolean, Mensaje As String, Fecha As Date, Perfil As Bitmap)
        InitializeComponent()
        Me.esEnviado = isReceiver
        lbl_Mensaje.Text = Mensaje

        If (esEnviado) Then
            lbl_Mensaje.TextAlign = ContentAlignment.TopRight
            imgRecibido.Image = Perfil
            imgRecibido.Visible = False
            horaRecibido.Visible = False
            horaEnviado.Visible = True
            horaEnviado.Text = Fecha.Hour().ToString()
        End If
    End Sub

End Class