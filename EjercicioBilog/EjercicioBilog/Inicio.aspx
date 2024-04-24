<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="EjercicioBilog.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="width:100%; height:100%">

    <asp:Label runat="server" Text="Gestión de empleados" ID="label" style="text-align:center;display:inline-block; padding: 10px;vertical-align:central;width:100%" Font-Bold="True" Font-Size="XX-Large"></asp:Label>

        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" BackColor="#B5C7DE" Width="100%" RenderingMode="List">
            <Items>
                <asp:MenuItem Text="Agregar" Value="Agregar" NavigateUrl="AgregarEmpleado.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Borrar" Value="Borrar" NavigateUrl="BorrarEmpleado.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Modificar" Value="Modificar" NavigateUrl="ModificarEmpleado.aspx"></asp:MenuItem>
                <asp:MenuItem Text="Listar" Value="Listar" NavigateUrl="ListarEmpleado.aspx">
                    </asp:MenuItem>
            </Items>
        </asp:Menu>

    </form>
</body>
</html>
