Imports Acceso_a_Datos
Imports System.Text.RegularExpressions

''' <summary>
''' Clase encargada de realizar las verificaciones.
''' </summary>
Public Class Verificacion

    Private Shared instancia As Verificacion

    Public Shared Function Singleton() As Verificacion
        If instancia Is Nothing Then
            instancia = New Verificacion
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de verificar si la cédula ingresada contiene caracteres.
    ''' </summary>
    ''' <param name="ced"></param>
    ''' <returns>True si la cédula ingresada tiene el formato correcto</returns>
    Public Function Verificar_Cedula(ced As String) As Boolean

        If ced <> "" Then
            If IsNumeric(ced) = True Then
                If ced.Length = 7 Or ced.Length = 8 Then
                    Return True
                End If
            End If
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de verificar si el dígito verificador de la cédula es correcto.
    ''' </summary>
    ''' <param name="ced"></param>
    ''' <returns>True si el dígito es correcto.</returns>
    Public Function Verificar_Digito(ced As String) As Boolean

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

    ''' <summary>
    ''' Función encargada de verificar si el string ingresado contiene dígitos numéricos.
    ''' </summary>
    ''' <param name="texto"></param>
    ''' <returns>True si el string ingresado es correcto.</returns>
    Public Function Verificar_String(texto As String) As Boolean

        If texto <> "" Then

            Dim bool As Boolean = Regex.IsMatch(texto, "^[a-zA-ZñÑ]+$")

            If bool Then
                If texto.Length >= 3 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de verificar si los dígitos ingresados contienen caracteres.
    ''' </summary>
    ''' <param name="numero"></param>
    ''' <returns>True si los dígitos ingresados son correctos.</returns>
    Public Function Verificar_Int(numero As String) As Boolean

        If numero <> "" Then
            If IsNumeric(numero) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de verificar si e-mail ingresado contiene el formato correcto.
    ''' </summary>
    ''' <param name="email"></param>
    ''' <returns>True si el e-mail es correcto.</returns>
    Public Function VerificarEmail(ByVal email As String) As Boolean

        Dim patron As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim match As Match = Regex.Match(email, patron)

        If match.Success Then
            Return True
        End If

        Return False
    End Function

End Class
