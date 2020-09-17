Public Class BsMsgbox


    Private Sub BsMsgbox_Load(sender As Object, e As EventArgs) Handles Me.Load

        btnNo.Visible = False
        Me.btnNo.Width = pnlWrap.Width
    End Sub

    Sub New()

        InitializeComponent()


    End Sub


    Public Shared instancia As BsMsgbox
    Property estado As Opcion

    Public Enum Opcion

        no = 0
        yes = 1
    End Enum
    'Private estado As Int16 = Nothing


    'Public Sub instanciar(instancia1 As BsMsgbox)

    '    instancia = instancia1

    'End Sub

    Public Function YesNo() As Integer

        Me.ShowDialog()
        Return estado

    End Function


    Public Shared Function Singleton() As BsMsgbox

        If instancia Is Nothing Then
            instancia = New BsMsgbox
        End If

        Return instancia

    End Function

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click

        estado = Opcion.yes
        Me.Dispose()

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        estado = Opcion.no
        Me.Dispose()
    End Sub

    Private Sub BsMsgbox_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, lblTitulo.MouseDown
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub BsMsgbox_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, lblTitulo.MouseMove
        Principal.Singleton.moverVentanaDown(Me)
    End Sub

    Private Sub BsMsgbox_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp, lblTitulo.MouseUp
        Principal.Singleton.moverVentanaUp()
    End Sub

    Private Sub BsMsgbox_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub


End Class