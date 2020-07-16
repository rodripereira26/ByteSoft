Public Class ModeloGestor
    Inherits Conexion
    Public Function Registrar(cedula As Integer, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Telefonos As ArrayList)

        Command.CommandText = "
            INSERT INTO 
                usuario (cedula, contrasena, pNom, sNom, pApe, sApe) 
            VALUES ('" & cedula & "','" & contraseña & "','" & PrimerNombre & "','" & SegundoNombre & "','" & PrimerApellido & "','" & SegundoApellido & "')"
        Command.ExecuteNonQuery()

        Command.CommandText = "
            INSERT INTO 
                gestor (cedula) 
            VALUES ('" & cedula & "')"
        Command.ExecuteNonQuery()

        For i = 0 To Telefonos.Count - 1
            Command.CommandText = "
            INSERT INTO 
                usuario_tel (cedula,telefono) 
            VALUES ('" & cedula & "','" & Telefonos(i) & "')"
            Command.ExecuteNonQuery()

        Next


    End Function

End Class
