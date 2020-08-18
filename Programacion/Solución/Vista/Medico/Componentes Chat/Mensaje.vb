Public Class Mensaje

    Public Sub New(esEmisor As Boolean, Mensaje As String, Fecha As Date, Perfil As Bitmap)

        InitializeComponent()

        If (esEmisor) Then

            lbl_Enviado.Text = Mensaje
            horaRecibido.Visible = False
            horaEnviado.Visible = True
            lbl_Recibido.Visible = False
            lbl_Enviado.Visible = True
            horaEnviado.Text = Fecha.Hour().ToString()
            lbl_Enviado.Size = TextRenderer.MeasureText(lbl_Enviado.Text, lbl_Enviado.Font)
            Me.Height = lbl_Enviado.Height + 15
            Principal.Singleton.SuperRoundedCorners(lbl_Enviado)

        Else
            lbl_Recibido.Text = Mensaje
            horaEnviado.Visible = False
            horaRecibido.Visible = True
            lbl_Recibido.Visible = True
            lbl_Enviado.Visible = False
            horaRecibido.Text = Fecha.Hour().ToString()
            lbl_Recibido.Size = TextRenderer.MeasureText(lbl_Recibido.Text, lbl_Recibido.Font)
            Me.Height = lbl_Recibido.Height + 15
            Principal.Singleton.SuperRoundedCorners(lbl_Recibido)
        End If

    End Sub

End Class