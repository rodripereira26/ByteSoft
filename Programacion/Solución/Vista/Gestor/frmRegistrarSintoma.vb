Imports Logica
Public Class frmRegistrarSintoma
    Private op As Byte
    Private sin As New ControladorSintoma
    Private _nomActual As String
    Private _descActual As String
    Private cambiados As Boolean = False
    Public Sub New()

        InitializeComponent()
For Each var As Control In Me.Controls

            If TypeOf var Is Panel Then

                For Each ctrl As Control In var.Controls

                    ctrl.Text = Principal.Singleton.Idioma(ctrl.Name, ctrl.Text)

                    If TypeOf ctrl Is Panel Then

                        For Each ctrl2 As Control In ctrl.Controls
                            ctrl2.Text = Principal.Singleton.Idioma(ctrl2.Name, ctrl2.Text)

                            If TypeOf ctrl2 Is Panel Then

                                For Each ctrl3 As Control In ctrl2.Controls
                                    ctrl3.Text = Principal.Singleton.Idioma(ctrl3.Name, ctrl3.Text)
                                    If TypeOf ctrl3 Is Panel Then
                                        For Each ctrl4 As Control In ctrl3.Controls
                                            ctrl4.Text = Principal.Singleton.Idioma(ctrl4.Name, ctrl4.Text)

                                            If TypeOf ctrl4 Is Panel Then
                                                For Each ctrl5 As Control In ctrl4.Controls
                                                    ctrl5.Text = Principal.Singleton.Idioma(ctrl5.Name, ctrl5.Text)

                                                Next

                                            End If
                                        Next

                                    End If
                                Next
                            End If
                        Next

                    End If
                Next


            End If
            var.Text = Principal.Singleton.Idioma(var.Name, var.Text)
        Next

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

    End Sub
    Public Sub New(op As Byte)

        InitializeComponent()
For Each var As Control In Me.Controls

            If TypeOf var Is Panel Then

                For Each ctrl As Control In var.Controls

                    ctrl.Text = Principal.Singleton.Idioma(ctrl.Name, ctrl.Text)

                    If TypeOf ctrl Is Panel Then

                        For Each ctrl2 As Control In ctrl.Controls
                            ctrl2.Text = Principal.Singleton.Idioma(ctrl2.Name, ctrl2.Text)

                            If TypeOf ctrl2 Is Panel Then

                                For Each ctrl3 As Control In ctrl2.Controls
                                    ctrl3.Text = Principal.Singleton.Idioma(ctrl3.Name, ctrl3.Text)
                                    If TypeOf ctrl3 Is Panel Then
                                        For Each ctrl4 As Control In ctrl3.Controls
                                            ctrl4.Text = Principal.Singleton.Idioma(ctrl4.Name, ctrl4.Text)

                                            If TypeOf ctrl4 Is Panel Then
                                                For Each ctrl5 As Control In ctrl4.Controls
                                                    ctrl5.Text = Principal.Singleton.Idioma(ctrl5.Name, ctrl5.Text)

                                                Next

                                            End If
                                        Next

                                    End If
                                Next
                            End If
                        Next

                    End If
                Next


            End If
            var.Text = Principal.Singleton.Idioma(var.Name, var.Text)
        Next
        Me.op = op
        Select Case op
            Case 0

            Case 1
                btnRegistrar.Text = Principal.Singleton.Idioma("txtModSintRegistrar", "Modificar Síntoma")
                btnRegistrar.Enabled = False
        End Select

    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub llenarCampos(nombre As String)

        _nomActual = nombre
        _descActual = sin.traerInfoSintomas(nombre)

        txtNom.Text = _nomActual
        txtDescripcion.Text = _descActual
        lblCantText.Text = txtDescripcion.Text.Length & "/300"
        cambiados = True
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If op = 0 Then
            If txtDescripcion.Text.Length > 10 Then
                If txtNom.Text <> Nothing Then
                    Dim sintoma As New ControladorSintoma(txtNom.Text, txtDescripcion.Text)

                    If sintoma.Registrar() Then
                        MsgBox(Principal.Singleton.Idioma("msgRegistrarSintSuccess","Síntoma registrado con éxito"))
                        txtDescripcion.Text = Nothing
                        txtNom.Text = Nothing
                    Else
                        MsgBox(Principal.Singleton.Idioma("msgErrorRegistrarSint","Error al registrar el síntoma"))
                    End If
                Else
                    MsgBox(Principal.Singleton.Idioma("msgIngresarNombreSint","Debe Ingresar un nombre"))
                End If

            Else
                MsgBox(Principal.Singleton.Idioma("msgDescripcionRegSint","Debe completar la descripción"))
            End If

        ElseIf op = 1 Then

            If txtDescripcion.Text.Length > 10 Then
                If txtNom.Text <> Nothing Then
                    Dim sintoma As New ControladorSintoma(txtNom.Text, txtDescripcion.Text)

                    If sintoma.Modificar(Label1.Text) Then
                        MsgBox(Principal.Singleton.Idioma("msgSuccessModRegSint","Síntoma modificado con éxito"))
                        Label1.Text = txtNom.Text
                    Else
                        MsgBox(Principal.Singleton.Idioma("msgErrModRegSint","Error al modificar el síntoma"))
                    End If
                Else
                    MsgBox(Principal.Singleton.Idioma("msgRegNomSint","Debe Ingresar un nombre"))
                End If

            Else
                MsgBox(Principal.Singleton.Idioma("msgCompDescSint","Debe completar la descripción"))
            End If

        End If


    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        lblCantText.Text = txtDescripcion.Text.Length & "/300"
    End Sub

    Private Sub btnAtras_Click_1(sender As Object, e As EventArgs) Handles btnAtras.Click
        If op = 0 Then
            If Not (txtNom.Text = Nothing And txtDescripcion.Text = Nothing) Then
                Dim res = MsgBox(Principal.Singleton.Idioma("msgConfSalirReg","Hay información sin guardar, ¿Seguro desea salir?"), vbYesNo)
                If res = vbYes Then
                    Principal.Singleton.CambiarTamaño(frmOpciones)
                    Me.Dispose()
                End If
            Else
                Principal.Singleton.CambiarTamaño(frmOpciones)
                Me.Dispose()
            End If

        ElseIf op = 1 Then

            Principal.Singleton.CambiarTamaño(frmListado)
            Me.Dispose()

        End If
    End Sub
    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        lblCantNom.Text = txtDescripcion.Text.Length & "/25"
    End Sub
    Private Sub txtChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged, txtDescripcion.TextChanged

        If cambiados Then
            If _nomActual <> txtNom.Text Or _descActual <> txtDescripcion.Text Then
                btnRegistrar.Enabled = True
            Else
                btnRegistrar.Enabled = False
            End If
        End If

    End Sub

    Private Sub txtDescripcion_GotFocus(sender As Object, e As EventArgs) Handles txtDescripcion.GotFocus
        sepDesc.LineColor = Colores.violeta_DARK
    End Sub
    Private Sub txtDescripcion_LostFocus(sender As Object, e As EventArgs) Handles txtDescripcion.LostFocus
        sepDesc.LineColor = Color.Gainsboro
    End Sub
End Class