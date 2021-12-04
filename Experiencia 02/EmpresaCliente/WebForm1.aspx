<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EmpresaCliente.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" DataSourceID = "ObjectDataSource1">
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCategorias" TypeName="EmpresaCliente.ServiceReference1.WSCategoriasSoapClient"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource" runat="server" SelectMethod
="GetCategorias" TypeName = "Cliente2.ServiceReference1. WSCategoriasSoapClient"/>
    </form>
</body>
</html>
