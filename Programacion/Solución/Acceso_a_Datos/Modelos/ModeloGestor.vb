Imports System.Data.Odbc
'''<summary>
'''Clase encargada de las consultas pertenecientes a los administradores.
'''</summary>
Public Class ModeloGestor

    Private Shared instancia As ModeloGestor

    Public Shared Function Singleton() As ModeloGestor

        If instancia Is Nothing Then
            instancia = New ModeloGestor
        End If

        Return instancia
    End Function

    '''<summary>
    '''Consulta encargada de registar a los usuarios administradores del sistema en la tabla usuarios.
    '''</summary>
    Public Function Registrar(cedula As String, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Telefonos As ArrayList) As Boolean

        Dim consulta As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe) VALUES (?,?,?,?,?,?)"

        Dim parametros As New List(Of OdbcParameter)
        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("contrasena", contraseña))
        parametros.Add(New OdbcParameter("pNom", PrimerNombre))
        parametros.Add(New OdbcParameter("sNom", SegundoNombre))
        parametros.Add(New OdbcParameter("pApe", PrimerApellido))
        parametros.Add(New OdbcParameter("sApe", cedula))


        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then

            If RegistrarGestor(cedula) Then

                If RegistrarTelefono(cedula, Telefonos) Then

                    Return True

                End If

            End If

        End If

        Return False
    End Function

    '''<summary>
    '''Consulta encargada de registar a los usuarios administradores del sistema en la tabla gestor.
    '''</summary>
    Public Function RegistrarGestor(cedula As String) As Boolean

        Dim parametros As New List(Of OdbcParameter)
        Dim consulta As String = "INSERT INTO gestor (cedula) VALUES (?)"
        parametros.Add(New OdbcParameter("cedula", cedula))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then

            Return True

        End If

        Return False
    End Function

    '''<summary>
    '''Consulta encargada de registar los telefonos de los gestores.
    '''</summary>
    Public Function RegistrarTelefono(cedula As String, Telefonos As ArrayList)

        Dim consulta = "INSERT INTO usuario_tel (cedula, telefono) VALUES (?,?)"
        Dim parametros As New List(Of OdbcParameter)
        Dim contador As Int16 = 0

        For i As Int16 = 0 To Telefonos.Count - 1

            parametros.Clear()
            parametros.Add(New OdbcParameter("cedula", cedula))
            parametros.Add(New OdbcParameter("telefono", Telefonos.Item(i)))

            ModeloConsultas.Singleton.InsertParametros(consulta, parametros)
            contador = +1

        Next

        If contador = Telefonos.Count Then

            Return True

        End If

        Return False
    End Function

    Public Function ListarPacientes() As DataTable

        Dim consulta = "SELECT paciente.cedula FROM paciente, usuario WHERE paciente.verificacion = 0 and usuario.bajaLogica = 0 and paciente.cedula=usuario.cedula"
        Return ModeloConsultas.Singleton.ConsultaTabla(consulta)

    End Function

    Public Function habilitarPaciente(cedula As String) As Boolean

        Dim consulta As String = "UPDATE paciente SET verificacion = 1 WHERE cedula=" + cedula

        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then

            Return True
        End If
        Return False
    End Function

    Public Function eliminar(cedula As String) As Boolean
        Dim consulta As String = "UPDATE usuario SET bajaLogica = 1 WHERE cedula=" + cedula
        If ModeloConsultas.Singleton.InsertarSinParametros(consulta) Then

            Return True
        End If
        Return False
    End Function

End Class
