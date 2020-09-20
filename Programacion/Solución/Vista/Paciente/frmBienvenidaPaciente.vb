
Imports Logica
Public Class frmBienvenidaPaciente

    Dim drag As Boolean
    Dim mousex, mousey As Integer
    Dim contChat As New ControladorChat
    Private chatComenzo As Boolean = False
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Principal.Singleton.roundedCorners(pnlIngresarSintomas)
        Principal.Singleton.roundedCorners(pnlHistorial)
        Principal.Singleton.roundedCorners(pnlReanudar)
        Principal.Singleton.roundedCorners(pnlPerfil)
        Principal.Singleton.roundedCorners(pnlAyuda)
        'Principal.Singleton.roundedCorners(Me)

        'Me.BackColor = Color.FromArgb(236, 236, 236)
        'Dim col As Color = Color.FromArgb(52, 73, 94)

        'Panel1.BackColor = Color.WhiteSmoke
        'Panel2.BackColor = Color.WhiteSmoke
        'Panel3.BackColor = Color.WhiteSmoke
        'Panel4.BackColor = Color.WhiteSmoke
        'Panel5.BackColor = Color.WhiteSmoke
        'Label1.ForeColor = col
        'Label2.ForeColor = col
        'Label3.ForeColor = col
        'Label4.ForeColor = col
        'Label5.ForeColor = col
        'Label6.ForeColor = col
        'Label7.ForeColor = col
        'Label8.ForeColor = col
        'Label9.ForeColor = col
        'Label10.ForeColor = col
        'Label11.ForeColor = col
        'Label12.ForeColor = col
        'Label13.ForeColor = col

    End Sub

    Public Sub New()
        InitializeComponent()
        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height
        Timer1.Enabled = True
    End Sub

    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Me.pnlContenedor.Show()
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
    '    hover(Panel1)
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

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles pnlIngresarSintomas.Click
        Dim frm As New frmIngresarSintomas
        Configuracion.Singleton.setConnection()
        Me.SuspendLayout()
        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
        Principal.Singleton.cambiarTamaño(frmIngresarSintomas)
        frm.Show()
        pnlContenedor.Hide()
        pnlInstancia.Show()
        Me.ResumeLayout()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If obtenerRespuesta() Then

            Me.Timer1.Enabled = False
            Dim respuesta As Integer
            respuesta = MsgBox("Ha recibido una respuesta, ¿Desea chatear?", vbQuestion + vbYesNo + vbDefaultButton2)

            If respuesta = vbYes Then
                chatComenzo = True
                Dim frm As New frmChat
                Configuracion.Singleton.setConnection()
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.cambiarTamaño(frmChat)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()
                respuesta = True
            Else
                Me.Timer1.Enabled = True
            End If

        End If

    End Sub

    Public Function obtenerRespuesta() As Boolean

        If contChat.obtenerRespuesta >= 1 Then
            Return True
        End If

        Return False
    End Function
    Private Sub pnlReanudar_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlReanudar.MouseClick
        If chatComenzo Then
            Dim frm As New frmChat
            Configuracion.Singleton.setConnection()
            Me.SuspendLayout()
            Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
            Principal.Singleton.cambiarTamaño(frmChat)
            frm.Show()
            pnlContenedor.Hide()
            pnlInstancia.Show()
            Me.ResumeLayout()
        Else
            MsgBox("Usted aún no ha iniciado ningún chat")
        End If
    End Sub

End Class