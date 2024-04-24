<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarEmpleado.aspx.cs" Inherits="EjercicioBilog.ModificarEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" Text="Modificar empleado" ID="label" style="text-align:center;display:inline-block; padding: 10px;vertical-align:central;width:100%" Font-Bold="True" Font-Size="XX-Large"></asp:Label>

        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BackColor="#B5C7DE" Width="100%" RenderingMode="List">
    <Items>
        <asp:MenuItem Text="Agregar" Value="Agregar" NavigateUrl="AgregarEmpleado.aspx"></asp:MenuItem>
        <asp:MenuItem Text="Borrar" Value="Borrar" NavigateUrl="BorrarEmpleado.aspx"></asp:MenuItem>
        <asp:MenuItem Text="Modificar" Value="Modificar" NavigateUrl="ModificarEmpleado.aspx"></asp:MenuItem>
        <asp:MenuItem Text="Listar" Value="Listar" NavigateUrl="ListarEmpleado.aspx">
            </asp:MenuItem>
    </Items>
</asp:Menu>


        <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
        <asp:TextBox ID="emailtxt" runat="server" placeholder="Ingrese email del empleado a modificar" type="email"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
        <br/>
        <br/>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
        <asp:TextBox ID="nombretxt" runat="server" placeholder="Nombre" type="text"></asp:TextBox>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Apllido:"></asp:Label>
        <asp:TextBox ID="apellidotxt" runat="server" placeholder="Apellido" type="text"></asp:TextBox>

        <br/>
        <br/>
        <asp:Button ID="modificarbtn" runat="server" Text="Modificar" OnClick="Modificarbtn_Click" />
    </form>
</body>
</html>
