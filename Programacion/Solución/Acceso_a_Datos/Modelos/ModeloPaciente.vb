Imports System.Data.Odbc
'''<summary>
'''Clase encargada de las consultas pertenecientes a los pacientes.
'''</summary>
Public Class ModeloPaciente

    '''<summary>
    '''Consulta encargada de verificar si el paciente fue ingresado.
    '''</summary>
    Public Function VerificarEstado(cedula As String) As Boolean

        Dim consulta = "SELECT verificacion FROM paciente WHERE cedula = " + cedula

        If ModeloConsultas.Singleton.ConsultaCampo(consulta) = 1 Then
            Return True
        Else
            Return False
        End If

        Return False
    End Function

    '''<summary>
    '''Consulta encargada de registrar a los usuarios pacientes en la tabla usuario.
    '''</summary>
    Public Function Registrar(cedula As String, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Telefonos As ArrayList, Mail As String, sexo As String, FechaNacimiento As String) As Boolean

        Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.aux)
        Dim consulta As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe, correo) VALUES (?,?,?,?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("contrasena", contraseña))
        parametros.Add(New OdbcParameter("pNom", PrimerNombre))
        parametros.Add(New OdbcParameter("sNom", SegundoNombre))
        parametros.Add(New OdbcParameter("pApe", PrimerApellido))
        parametros.Add(New OdbcParameter("sApe", cedula))
        parametros.Add(New OdbcParameter("correo", Mail))


        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then

            If RegistrarPaciente(cedula, sexo, FechaNacimiento) Then

                If RegistrarTelefono(cedula, Telefonos) Then

                    Return True

                End If

            End If

        End If

        Return False
    End Function

    '''<summary>
    '''Consulta encargada de registar a los usuarios pacientes del sistema en la tabla paciente.
    '''</summary>
    Public Function RegistrarPaciente(cedula As String, sexo As String, FechaNacimiento As String) As Boolean

        Dim parametros As New List(Of OdbcParameter)
        Dim consulta As String = "INSERT INTO paciente (cedula, verificacion, fecNac, sexo) VALUES (?,?,?,?)"

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("verificacion", "false"))
        parametros.Add(New OdbcParameter("fecNac", FechaNacimiento))
        parametros.Add(New OdbcParameter("sexo", sexo))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then

            Return True

        End If

        Return False
    End Function

    '''<summary>
    '''Consulta encargada de registar los telefonos de los pacientes.
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
    Public Function traerPacientes() As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT cedula FROM paciente WHERE verificacion= ")
    End Function
End Class
