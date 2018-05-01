' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.vb en el Explorador de soluciones e inicie la depuración.

Imports AccesoDatosSQL.accesodatosSQL

Public Class Service1
    Implements IService1

    Public Sub New()
    End Sub

    Public Function GetDedicacionMedia(ByVal asg As String) As Double Implements IService1.GetDedicacionMedia

        'escribir aqui el codigo de acceso a la BD llamando a la capa de acceso a datos



        Return 0.0

    End Function

End Class
