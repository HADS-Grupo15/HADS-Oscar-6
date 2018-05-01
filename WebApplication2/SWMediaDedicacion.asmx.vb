Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient

<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class WebService1

    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function CalcularDedicacionMedia(ByVal asg As String) As Double

        Dim conexion As New SqlConnection

        conexion.ConnectionString = "Server=tcp:hads15iu.database.windows.net,1433;Initial Catalog=HADS-15-Tareas;Persist Security Info=False;User ID=opalomo001;Password=Freetanga69;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

        conexion.Open()

        Dim daQuery As New SqlDataAdapter("SELECT (sum(EstudiantesTareas.HReales)/count(EstudiantesTareas.HReales)) as media FROM EstudiantesTareas 
                                        INNER JOIN TareasGenericas ON TareasGenericas.Codigo = EstudiantesTareas.CodTarea
                                        WHERE TareasGenericas.CodAsig='" & asg & "'", conexion)
        Dim dtsMedia As New DataSet

        daQuery.Fill(dtsMedia, "DedicacionMedia")

        Dim val As String

        Dim tableMedia As DataTable

        tableMedia = dtsMedia.Tables("DedicacionMedia")

        Dim o As Object = tableMedia.Rows.Item(0).Item(0)

        val = o.ToString

        Return val 'SI NO TIRA ASI DEVOLVER EL DATASET Y TRATAR EL VALOR EN EL .ASPX

    End Function

End Class