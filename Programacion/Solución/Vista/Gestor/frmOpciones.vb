Imports Logica
Public Class frmOpciones
    Public op As Byte
    Private Sub frmOpciones_Load(sender As Object, e As EventArgs) Handles Me.Load

        Select Case op

            Case 0
                lblTitulo1.Text = Principal.Singleton.Idioma("lblTitulo1Pat", "Registrar patología")
                lblTitulo2.Text = Principal.Singleton.Idioma("lblTitulo2Pat", "Registrar patología mediante un archivo CSV")
                lblTitulo3.Text = Principal.Singleton.Idioma("lblTitulo3Pat", "Listado de patologías")
                lblSubtitulo1.Text = Principal.Singleton.Idioma("lblSubtitulo1Pat", "Registre patologías manualmente")
                lblSubtitulo2.Text = Principal.Singleton.Idioma("lblSubtitulo2Pat", "Seleccione un archivo CSV para registrar patologías")
                lblSubtitulo3.Text = Principal.Singleton.Idioma("lblSubtitulo3Pat", "Acceda a todos los patologías registradas y a opciones de eliminar y modificar")

            Case 1
                lblTitulo1.Text = Principal.Singleton.Idioma("lblTitulo1Sin", "Registrar síntoma")
                lblTitulo2.Text = Principal.Singleton.Idioma("lblTitulo2Sin", "Registrar síntoma mediante un archivo CSV")
                lblTitulo3.Text = Principal.Singleton.Idioma("lblTitulo3Sin", "Listado de síntomas")
                lblSubtitulo1.Text = Principal.Singleton.Idioma("lblSubtitulo1Sin", "Registre síntomas manualmente")
                lblSubtitulo2.Text = Principal.Singleton.Idioma("lblSubtitulo2Sin", "Seleccione un archivo CSV para registrar síntomas")
                lblSubtitulo3.Text = Principal.Singleton.Idioma("lblSubtitulo3Sin", "Acceda a todos los síntomas registrados y a opciones de eliminar y modificar")

            Case 2
                lblTitulo1.Text = Principal.Singleton.Idioma("lblTitulo1Med", "Registrar médico")
                lblTitulo2.Text = Principal.Singleton.Idioma("lblTitulo2Med", "Registrar médico mediante un archivo CSV")
                lblTitulo3.Text = Principal.Singleton.Idioma("lblTitulo3Med", "Registrar gestor")
                lblSubtitulo1.Text = Principal.Singleton.Idioma("lblSubtitulo1Med", "Registre médicos manualmente")
                lblSubtitulo2.Text = Principal.Singleton.Idioma("lblSubtitulo2Med", "Seleccione un archivo CSV para registrar médicos")
                lblSubtitulo3.Text = Principal.Singleton.Idioma("lblSubtitulo3Med", "Registre gestores manualmente")

        End Select

    End Sub

    Public Sub New()

        InitializeComponent()

        Datos_Temporales.horizontal = Me.Width
        Datos_Temporales.vertical = Me.Height

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
    End Sub

    Private Sub Opcion1(sender As Object, e As MouseEventArgs) Handles pnlOpcion1.MouseDown, lblTitulo1.MouseDown, lblSubtitulo1.MouseDown

        Select Case op

            Case 0
                Dim frm As New frmRegistrarPatologia
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmRegistrarPatologia)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()

            Case 1
                Dim frm As New frmRegistrarSintoma
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmRegistrarSintoma)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()

            Case 2
                Dim frm As New frmRegistrarMedico
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmRegistrarMedico)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()

        End Select

    End Sub

    Private Sub Opcion2(sender As Object, e As MouseEventArgs) Handles pnlOpcion2.MouseDown, lblTitulo2.MouseDown, lblSubtitulo2.MouseDown

        Dim opf As New OpenFileDialog
        Dim listaColumnas As New List(Of String)
        opf.Title = "Seleccione un archivo"
        opf.InitialDirectory = "C:\\"
        opf.Filter = "Archivo|*.csv"

        Select Case op

            Case 0
                listaColumnas.Add("Nombre")
                listaColumnas.Add("Descrpcion")
                listaColumnas.Add("Recomendación")
                listaColumnas.Add("Prioridad")
            Case 1
                listaColumnas.Add("Nombre")
                listaColumnas.Add("Descripción")

            Case 2
                listaColumnas.Add("Cédula")
                listaColumnas.Add("Contraseña")
                listaColumnas.Add("PNom")
                listaColumnas.Add("Segundo Nombre")
                listaColumnas.Add("Primer Apellido")
                listaColumnas.Add("Segundo Apellido")
                listaColumnas.Add("E-mail")
                listaColumnas.Add("Especialización")

        End Select

        If opf.ShowDialog = DialogResult.OK Then

            If Configuracion.Singleton.LeerCSV(opf.FileName, listaColumnas) IsNot Nothing Then
                If Configuracion.Singleton.LeerCSV(opf.FileName, listaColumnas).Rows.Count <> 0 Then

                    Dim bool As Boolean = False
                    Dim contador As Int32 = 0

                    If op = 0 Then

                        For Each row As DataRow In Configuracion.Singleton.LeerCSV(opf.FileName, listaColumnas).Rows
                            If IsNumeric(row.Item(1).ToString) = False And IsNumeric(row.Item(2).ToString) = False And IsNumeric(row.Item(3).ToString) And (row.Item(3).ToString = "1" Or row.Item(3).ToString = "2" Or row.Item(3).ToString = "3") Then
                                contador += 1
                            End If
                        Next

                    ElseIf op = 1 Then

                        For Each row As DataRow In Configuracion.Singleton.LeerCSV(opf.FileName, listaColumnas).Rows
                            If IsNumeric(row.Item(0)) = False And IsNumeric(row.Item(1)) = False Then
                                contador += 1
                            End If
                        Next

                    Else

                        For Each row As DataRow In Configuracion.Singleton.LeerCSV(opf.FileName, listaColumnas).Rows
                            If Principal.Singleton.VerificarCedula(Verificacion.Singleton, row.Item(0)) Then
                                If Principal.Singleton.VerificarString(Verificacion.Singleton, row.Item(2), row.Item(4), row.Item(3), row.Item(5)) Then
                                    If Verificacion.Singleton.Verificar_String(row.Item(7)) Then
                                        If Verificacion.Singleton.VerificarEmail(row.Item(6)) Then
                                            contador += 1
                                        End If
                                    End If
                                End If
                            End If
                        Next

                    End If

                    If contador = Configuracion.Singleton.LeerCSV(opf.FileName, listaColumnas).Rows.Count Then
                        bool = True
                    End If

                    If bool Then
                        Dim frm As New frmListado(opf.FileName, listaColumnas, op)
                        Me.SuspendLayout()
                        Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                        Principal.Singleton.CambiarTamaño(frm)
                        frm.Show()
                        pnlContenedor.Hide()
                        pnlInstancia.Show()
                        Me.ResumeLayout()
                    Else
                        MsgBox(Principal.Singleton.Idioma("msgArchivoSinFormato", "El archivo seleccionado no posee el formato correcto"))
                    End If

                Else
                    MsgBox(Principal.Singleton.Idioma("msgArchivoNoCorrecto", "El arhivo seleccionado no es correcto"))
                End If
            Else
                MsgBox(Principal.Singleton.Idioma("msgArchivoEnUso", "El archivo se encuentra en uso por otro proceso"))
            End If
        End If
    End Sub

    Private Sub Opcion3(sender As Object, e As MouseEventArgs) Handles pnlOpcion3.MouseDown, lblSubtitulo3.MouseDown, lblTitulo3.MouseDown

        Select Case op

            Case 0
                Dim frm As New frmListado(0)
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmListado)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()

            Case 1
                Dim frm As New frmListado(1)
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmListado)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()

            Case 2
                Dim frm As New frmRegistroGestor
                Me.SuspendLayout()
                Principal.Singleton.CargarVentana(Me.pnlInstancia, frm)
                Principal.Singleton.CambiarTamaño(frmRegistroGestor)
                frm.Show()
                pnlContenedor.Hide()
                pnlInstancia.Show()
                Me.ResumeLayout()

        End Select

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs)
        Principal.Singleton.CambiarTamaño(frmBienvenidaGestor)
        Me.Dispose()
    End Sub

    Private Sub Enter(sender As Object, e As EventArgs) Handles pnlOpcion3.MouseEnter, pnlOpcion2.MouseEnter, pnlOpcion1.MouseEnter, lblTitulo3.MouseEnter, lblTitulo2.MouseEnter, lblTitulo1.MouseEnter, lblSubtitulo3.MouseEnter, lblSubtitulo2.MouseEnter, lblSubtitulo1.MouseEnter

        If TypeOf sender IsNot Panel Then
            sender.parent.backcolor = Colores.hover_DARK
        Else
            sender.backcolor = Colores.hover_DARK
        End If

    End Sub

    Private Sub Leave(sender As Object, e As EventArgs) Handles pnlOpcion3.MouseLeave, pnlOpcion2.MouseLeave, pnlOpcion1.MouseLeave, lblTitulo3.MouseLeave, lblTitulo2.MouseLeave, lblTitulo1.MouseLeave, lblSubtitulo3.MouseLeave, lblSubtitulo2.MouseLeave, lblSubtitulo1.MouseLeave

        If TypeOf sender IsNot Panel Then
            sender.parent.backcolor = Colores.secundario_DARK
        Else
            sender.backcolor = Colores.secundario_DARK
        End If

    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Principal.Singleton.CambiarTamaño(frmBienvenidaGestor)
        Me.Dispose()
    End Sub
    Private Sub Finalizar() Handles pnlInstancia.ControlRemoved
        Principal.Singleton.CambiarTamaño(Me)
        Me.pnlContenedor.Show()
    End Sub

    Private Sub lblSubtitulo3_Click(sender As Object, e As EventArgs) Handles lblSubtitulo3.Click

    End Sub
End Class
