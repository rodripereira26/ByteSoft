Imports Logica
Imports Vista
Public Class main

    Public Shared instancia As main
    Private drag As Boolean
    Private mousex, mousey As Integer

    Public Shared Function Singleton() As main
        If instancia Is Nothing Then
            instancia = New main
        End If

        Return instancia
    End Function
    Public Function GetInstancia() As main
        Return instancia
    End Function

    Public Sub New()
        InitializeComponent()
        instancia = Me
        Datos_Temporales.rol = Datos_Temporales.enumRol.Gestor
        Dim frm As New frmLogin
        frm.lblCrearCuenta.Visible = True
        CargarVentana(ventana, frm)
        cambiarTamaño()
    End Sub
    Public Sub CargarVentana(ventana As Panel, formInterno As Form)
        ventana.Controls.Clear()
        formInterno.TopLevel = False
        formInterno.Dock = DockStyle.Fill
        formInterno.Size = ventana.Size
        ventana.Controls.Add(formInterno)
        formInterno.Show()
    End Sub
    Public Sub cambiarTamaño()
        Me.SuspendLayout()
        Me.Size = New Size(Datos_Temporales.horizontal, Datos_Temporales.vertical + 38)
        Me.MinimumSize = New Size(Datos_Temporales.horizontal, Datos_Temporales.vertical + 38)
        Me.MaximumSize = New Size(Datos_Temporales.horizontal, Datos_Temporales.vertical + 38)
        Me.CenterToScreen()
        Me.ResumeLayout()
    End Sub
    Public Sub moverVentanaMove(form As Form)
        If Me.drag Then
            form.Top = Cursor.Position.Y - mousey
            form.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Public Sub moverVentanaDown(form As Form)
        Me.drag = True
        Me.mousex = Cursor.Position.X - form.Left
        Me.mousey = Cursor.Position.Y - form.Top
    End Sub
    Public Sub moverVentanaUp()
        Me.drag = False
    End Sub
    Private Sub pnlCerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlCerrar.MouseMove
        moverVentanaMove(Me)
    End Sub
    Private Sub pnlCerrar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlCerrar.MouseDown
        moverVentanaDown(Me)
    End Sub
    Private Sub pnlCerrar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlCerrar.MouseUp
        moverVentanaUp()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
    Private Sub btnSalir_MouseLeave(sender As Object, e As EventArgs) Handles btnSalir.MouseLeave
        btnSalir.BackColor = Color.Transparent
    End Sub
    Private Sub btnSalir_MouseEnter(sender As Object, e As EventArgs) Handles btnSalir.MouseEnter
        btnSalir.BackColor = Color.Red
    End Sub
    Private Sub btnMinimizar_MouseEnter(sender As Object, e As EventArgs) Handles btnMinimizar.MouseEnter
        btnMinimizar.BackColor = Color.Gray
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnMinimizar_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimizar.MouseLeave
        btnMinimizar.BackColor = Color.Transparent
    End Sub

End Class