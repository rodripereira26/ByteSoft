Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Acceso_a_Datos
Imports Logica

<TestClass()> Public Class PruebasUsuario

    <TestMethod()> Public Sub InsertarUsuarios()

        Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.admin)
        Dim usuario As New ControladorUsuario
        Dim datos As New ModeloGestor
        Dim esperado As Boolean = True
        Dim telefonos As New ArrayList


        usuario._ci = "52645181"
        usuario._contraseña = "1234"
        usuario._primer_apellido = "Rodrigo"
        usuario._primer_apellido = "Pereira"
        usuario._segundo_apellido = "Oseira"
        usuario._email = "asdas@adsa.com"


        Dim actual = datos.Registrar(usuario._ci, usuario._contraseña, usuario._primer_nombre, usuario._primer_nombre, usuario._segundo_apellido, usuario._email, telefonos)

        Assert.AreEqual(actual, esperado)

    End Sub

End Class