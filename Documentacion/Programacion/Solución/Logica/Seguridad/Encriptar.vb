Imports System.Text
Imports System.Security.Cryptography
'''<summary>
'''Clase encargada de la seguridad del sistema.
'''</summary>
Public Class Encriptar

    '''<summary>
    '''Función encargada de encriptar las contraseñas mediante el algoritmo SHA25.
    '''</summary>
    Public Function HASHSHA2566(ByVal texto) As String

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
