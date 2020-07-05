'Imports System.Security.Cryptography
'Public Class Encriptar

'        Function SHA1(ByVal hash As String) As String

'            Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
'            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(hash)

'            bytesToHash = sha1Obj.ComputeHash(bytesToHash)

'            Dim strResult As String = ""

'            For Each b As Byte In bytesToHash
'                strResult += b.ToString("x2")
'            Next

'            Return strResult

'        End Function

'    End Class
