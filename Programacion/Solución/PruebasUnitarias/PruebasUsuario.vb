Imports Acceso_a_Datos
Imports Logica

<TestClass()> Public Class PruebasUsuario

    <TestMethod()> Public Sub selectChat()

        Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.admin)
        Dim chat As New ControladorChat
        Dim datos As New ModeloChat
        Dim esperado As Boolean = True
        Dim telefonos As New ArrayList

        Dim cedula As String = "52645181"

        Dim actual = datos.entrarChat(cedula, Datos_Temporales.idchat)

        Assert.AreEqual(actual, esperado)

    End Sub

End Class