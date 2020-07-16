Imports Acceso_a_Datos

Public Class Verificacion

    Public Function verificar_cedula(ced As String) As Boolean

        If ced <> "" Then
            If IsNumeric(ced) = True Then
                If ced.Length = 7 Or ced.Length = 8 Then
                    Return True
                End If
            End If
        End If

        Return False
    End Function

    Public Function verificar_digito(ced As String) As Boolean

        Dim array As New ArrayList
        Dim numeros = New Integer() {2, 9, 8, 7, 6, 3, 4}
        Dim acumulador As Integer = 0
        Dim cuenta As Integer = 0


        If (ced.Length = 8) Then

            Dim digito As String = ced.Substring(7, 1)
            ced = ced.Substring(0, 7)

            For i As Integer = 0 To ced.Length - 1
                array.Add(ced.Substring(i, 1))
            Next
            For i As Integer = 0 To array.Count - 1
                acumulador = acumulador + array.Item(i) * numeros(i)
            Next

            cuenta = 10 - (acumulador Mod 10)

            If (cuenta = digito) Then
                Return True
            Else
                Return False
            End If

        ElseIf (ced.Length = 7) Then

            Dim digito As String = ced.Substring(6, 1)
            ced = ced.Substring(0, 6)
            numeros = {9, 8, 7, 6, 3, 4}

            For i As Integer = 0 To ced.Length - 1
                array.Add(ced.Substring(i, 1))
            Next
            For i As Integer = 0 To array.Count - 1
                acumulador = acumulador + array.Item(i) * numeros(i)
            Next

            cuenta = 10 - (acumulador Mod 10)

            If (cuenta = digito) Then
                Return True
            Else
                Return False
            End If

        End If

        Return False
    End Function

    Public Function verificar_string(texto As String) As Boolean

        If texto <> "" Then
            If IsNumeric(texto) = False Then
                If texto.Length >= 3 Then
                    Return True
                End If
            End If
        End If

        Return False
    End Function

    Public Function verificar_int(numero As String) As Boolean

        If numero <> "" Then
            If IsNumeric(numero) = True Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Function verificar(cedula As String, contraseña As String)

        'Dim datos As New Consultas

        'Return datos.verificarUsuario(cedula, contraseña)
    End Function

End Class
