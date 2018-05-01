' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IService1

    <OperationContract()>
    Function GetDedicacionMedia(ByVal asg As String) As Double

    ' TODO: agregue aquí sus operaciones de servicio

End Interface


