Imports AccesoDatosSQL.accesodatosSQL

Public Class Registro

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click

        Dim m As matriculas.Matriculas

        Dim numConf = myrandomize()

        Dim ans As String

        m = New matriculas.Matriculas

        ans = m.comprobar(txtmail.Text)

        If (ans = "SI") Then

            Dim res = insertar(txtmail.Text, txtNom.Text, txtApe.Text, txtApe2.Text, numConf, rol.Text, txtPass.Text)

            txtConfirmar.Text = res

            enviarEmail(txtmail.Text, numConf, "Enlace para registro", "Confirmar")

            If res = "1" Then

                Response.Redirect("Confirmar.aspx")

            End If

        Else

            txtConfirmar.Text = "Estudiante no matriculado"

        End If

    End Sub

End Class