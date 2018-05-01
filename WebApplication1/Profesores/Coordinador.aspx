<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Coordinador.aspx.vb" Inherits="WebApplication1.Coordinador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <div id="cabecera" style="text-align:center;background-color:Highlight;">
            <h1 style="color:lightcyan">PANEL DE DEDICACIONES <asp:Label ID="Label2" runat="server" Text=" "></asp:Label></h1>
        </div>
        <div id="cabecera2" style="float:right;text-align:left;width:10%">
            <asp:ImageButton ID="ImageButton2" runat="server" Height="53px" ImageUrl="https://cdn2.iconfinder.com/data/icons/snipicons/500/logout-256.png" Width="57px" />
              Logout
            </div>    
        <br /><br /><br /><br><br />
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HADS-15-TareasConnectionString %>" SelectCommand="SELECT Asignaturas.codigo FROM Asignaturas"></asp:SqlDataSource>
        </div>
        <div id="asignaturas" style="text-align:center">
            <asp:Label ID="Label1" runat="server" Text="Escoja una asignatura:" Font-Size="Large" ForeColor="#666666"></asp:Label>
            <br /><br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo"></asp:DropDownList>
        </div>
        <br />
        <div id="dedicacion" style="text-align:center">
            <asp:Label ID="txtMedia" runat="server" Text=" Dedicación media de la asignatura:" Font-Size="Large" ForeColor="#666666" Visible="False"/>
            <br /><br />
            <asp:Label ID="ansMedia" runat="server" Text=" " />
            <asp:Label ID="lblError" runat="server" Text=" " Font-Size="Large" ForeColor="Red" />
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Obtener Dedicación" style="border-radius:3px" BackColor="#0099FF" BorderColor="#0033CC" BorderStyle="Double" ForeColor="White" Height="35px" Width="154px" />
        </div>
    </form>
</body>
</html>
