Public Class Coordinador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ans As New SWAMedia.WebService1

        txtMedia.Visible = True

        lblError.Text = " "

        Try
            ansMedia.Text = " "

            ansMedia.Text = ans.CalcularDedicacionMedia(DropDownList1.SelectedValue)

        Catch ex As Exception

            lblError.Text = "Esta asignatura no tiene tareas instanciadas aún"

        End Try


    End Sub


    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click

        FormsAuthentication.SignOut()

        Session.Abandon()

        Response.Redirect("~Inicio.aspx")

    End Sub

End Class