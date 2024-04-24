<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrarEmpleado.aspx.cs" Inherits="EjercicioBilog.BorrarEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" Text="Borrar empleado" ID="label" style="text-align:center;display:inline-block; padding: 10px;vertical-align:central;width:100%" Font-Bold="True" Font-Size="XX-Large"></asp:Label>

        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BackColor="#B5C7DE" Width="100%" RenderingMode="List">
    <Items>
        <asp:MenuItem Text="Agregar" Value="Agregar" NavigateUrl="AgregarEmpleado.aspx"></asp:MenuItem>
        <asp:MenuItem Text="Borrar" Value="Borrar" NavigateUrl="BorrarEmpleado.aspx"></asp:MenuItem>
        <asp:MenuItem Text="Modificar" Value="Modificar" NavigateUrl="ModificarEmpleado.aspx"></asp:MenuItem>
        <asp:MenuItem Text="Listar" Value="Listar" NavigateUrl="ListarEmpleado.aspx">
            </asp:MenuItem>
    </Items>
</asp:Menu>



        <asp:Label ID="Label1" runat="server" Text="Ingrese el email del empleado:"></asp:Label>
        <asp:TextBox ID="emailEmpleado" runat="server" placeholder="Ingrese email"></asp:TextBox>

        <br/>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Borrar" OnClick="Button1_Click" />
    </form>
</body>
</html>
