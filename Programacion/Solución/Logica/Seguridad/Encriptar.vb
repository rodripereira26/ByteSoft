Imports System.Text
Imports System.Security.Cryptography

''' <summary>
''' Clase encargada de realizar las encriptaciones.
''' </summary>
Public Class Encriptar

    ''' <summary>
    ''' Función encargada de hashear una contraseña utilizando SHA256.
    ''' </summary>
    ''' <param name="texto"></param>
    ''' <returns>Contraseña hasheada del usuario.</returns>
    Public Function HASH256(ByVal texto) As String

        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function

End Class
