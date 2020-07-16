Public Class ModeloPaciente
    Inherits Conexion



    Public Function Registrar(cedula As Integer, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Telefonos As ArrayList, Mail As String, sexo As String, FechaNacimiento As String)
        Command.CommandText = "
            INSERT INTO 
                usuario (cedula, contrasena, pNom, sNom, pApe, sApe, correo) 
            VALUES ('" & cedula & "','" & contraseña & "','" & PrimerNombre & "','" & SegundoNombre & "','" & PrimerApellido & "','" & SegundoApellido & "','" & Mail & "')"
        Command.ExecuteNonQuery()


        Command.CommandText = "
            INSERT INTO 
                paciente (cedula, verificacion, fecNac, sexo) 
            VALUES ('" & cedula & "','0','" & FechaNacimiento & "','" & sexo & "')"
        Command.ExecuteNonQuery()

        For i = 0 To Telefonos.Count - 1

            Command.CommandText = "
            INSERT INTO 
                usuario_tel (cedula,telefono) 
            VALUES ('" & cedula & "','" & Telefonos(i).ToString & "')"
            Command.ExecuteNonQuery()

        Next




    End Function

    Public Function Listar()


        Reader = Command.ExecuteReader()

        Return Reader
    End Function

End Class
