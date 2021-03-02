<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Pages.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Página Inicial</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <tr>
                <td>
                    Nome do Cliente: <asp:TextBox ID="TBNome" runat="server"></asp:TextBox>
                    Data de Nascimento: <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
                    Ativo: <asp:TextBox ID="TBAtivo" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnAdd" runat="server" Text="Adicionar" OnClick="BtnAdd_Click" />
                    <asp:Button ID="BtnList" runat="server" Text="Listar" OnClick="BtnList_Click" />
                    <asp:Button ID="BtnNext" runat="server" Text="Próximo" OnClick="BtnNext_Click"/>
                </td>
            </tr>
        </div>
        <div aria-disabled="true" id="GridView">
            <tr>
                <td>
                    <asp:GridView ID="ViewRows" runat="server"></asp:GridView>
                </td>
            </tr>
        </div>
    </form>
</body>
</html>
