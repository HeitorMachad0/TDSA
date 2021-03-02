<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="WebApplication2.Pages.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Página Secundária</title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <tr>
                <td>
                    Nome do Cliente: <asp:TextBox ID="TBNome" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnDel" runat="server" Text="Excluir" OnClick="BtnDel_Click"/>
                    <asp:Button ID="BtnList" runat="server" Text="Listar" OnClick="BtnList_Click" />
                </td>
            </tr>
        </div>
        <div aria-disabled="true" id="GridView2">
            <tr>
                <td>
                    <asp:GridView ID="ViewRows" runat="server"></asp:GridView>
                </td>
            </tr>
        </div>
    </form>
</body>
</html>
