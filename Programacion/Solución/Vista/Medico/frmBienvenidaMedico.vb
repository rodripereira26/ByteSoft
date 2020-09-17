Imports Logica
Public Class frmBienvenidaMedico

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Principal.Singleton.roundedCorners(pnlChat)
        Principal.Singleton.roundedCorners(pnlMiHistorial)
        Principal.Singleton.roundedCorners(pnlAjustes)
        Principal.Singleton.roundedCorners(pnlMiPerfil)
        Principal.Singleton.roundedCorners(pnlAyuda)
        Principal.Singleton.roundedCorners(pnlTitulo)
        Principal.Singleton.roundedCorners(Me)

    End Sub

    Private Sub Panel6_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseDown
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub Panel6_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseMove
        Principal.Singleton.moverVentanaMove(Me)
    End Sub
    Private Sub Panel6_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTitulo.MouseUp
        Principal.Singleton.moverVentanaUp()
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    Me.BackColor = Color.FromArgb(236, 236, 236)
    '    Dim col As Color = Color.FromArgb(52, 73, 94)

    '    Panel1.BackColor = Color.WhiteSmoke
    '    Panel2.BackColor = Color.WhiteSmoke
    '    Panel3.BackColor = Color.WhiteSmoke
    '    Panel4.BackColor = Color.WhiteSmoke
    '    Panel5.BackColor = Color.WhiteSmoke
    '    Label1.ForeColor = col
    '    Label2.ForeColor = col
    '    Label3.ForeColor = col
    '    Label4.ForeColor = col
    '    Label5.ForeColor = col
    '    Label6.ForeColor = col
    '    Label7.ForeColor = col
    '    Label8.ForeColor = col
    '    Label9.ForeColor = col
    '    Label10.ForeColor = col
    '    Label11.ForeColor = col
    '    Label12.ForeColor = col
    '    Label13.ForeColor = col

    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    '    Me.BackColor = Color.FromArgb(19, 19, 19)
    '    Panel1.BackColor = Color.FromArgb(64, 64, 64)
    '    Panel2.BackColor = Color.FromArgb(64, 64, 64)
    '    Panel3.BackColor = Color.FromArgb(64, 64, 64)
    '    Panel4.BackColor = Color.FromArgb(64, 64, 64)
    '    Panel5.BackColor = Color.FromArgb(64, 64, 64)
    '    Label1.ForeColor = Color.White
    '    Label2.ForeColor = Color.White
    '    Label3.ForeColor = Color.White
    '    Label4.ForeColor = Color.White
    '    Label5.ForeColor = Color.White
    '    Label6.ForeColor = Color.White
    '    Label7.ForeColor = Color.White
    '    Label8.ForeColor = Color.White
    '    Label9.ForeColor = Color.White
    '    Label10.ForeColor = Color.White
    '    Label11.ForeColor = Color.White
    '    Label12.ForeColor = Color.White
    '    Label13.ForeColor = Color.White

    'End Sub

    'Private Sub hover(sender As Object)
    '    sender.backcolor = Color.FromArgb(56, 62, 80)
    'End Sub

    'Private Sub Panel1_MouseHover_1(sender As Object, e As EventArgs) Handles Panel1.MouseHover
    '    'hover(Panel1)
    'End Sub
    'Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
    '    hover(Panel2)
    'End Sub

    'Private Sub Panel3_MouseHover(sender As Object, e As EventArgs) Handles Panel3.MouseHover
    '    hover(Panel3)
    'End Sub

    'Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles Panel4.MouseHover
    '    hover(Panel4)
    'End Sub

    'Private Sub Panel5_MouseHover(sender As Object, e As EventArgs) Handles Panel5.MouseHover
    '    hover(Panel5)
    'End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblCerrar.Click
        frmLogin.lblUsuario.Text = "Usuario"
        frmLogin.lblUsuario.Text = "Contraseña"
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlAjustes.MouseClick
        MsgBox("En construcción...")
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlMiHistorial.MouseClick
        MsgBox("En construcción...")
    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlMiPerfil.MouseClick
        MsgBox("En construcción...")
    End Sub

    Private Sub Panel5_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlAyuda.MouseClick
        MsgBox("En construcción...")
    End Sub

    Private Sub Panel12_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlPatologias.MouseClick
        MsgBox("En construcción...")
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles pnlChat.Click
        frmListadoChat.Show()
        Me.Dispose()
    End Sub



End Class