<%@ Page Title="" Language="C#" MasterPageFile="~/PageLogin.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="FaturamentoServicos.Account.registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         
    <form id="form1" runat="server">
        <table style="width: 922px; height: 237px">
            <tr>
                <td rowspan="8" style="height: 281px; width: 336px">
                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
                    <img alt="" src="../images/login/LoginEmpregado.jpg" style="width: 255px; height: 262px" /></td>
                <td colspan="2" style="height: 34px">
                    <asp:Button ID="btnNovo" runat="server" OnClick="btnNovo_Click" Text="Novo" />
                    <asp:Button ID="btnAlterar" runat="server" Text="Alterar" />
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 34px">
                    <asp:Label ID="lbnEstado" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 368px; height: 34px">Código do Empregado</td>
                <td style="width: 1337px; height: 34px">
                    <asp:TextBox ID="txtIdEmpregado" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 368px; height: 34px">Nome</td>
                <td style="width: 1337px; height: 34px">
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 34px; width: 368px">Usuario</td>
                <td style="height: 34px; width: 1337px">
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 35px; width: 368px">Senha</td>
                <td style="height: 35px; width: 1337px">
                    <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 35px; width: 368px">Nivél de acesso</td>
                <td style="height: 35px; width: 1337px">
                    <asp:RadioButtonList ID="rdbAcesso" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1">Nivel 1</asp:ListItem>
                        <asp:ListItem Value="2">Nivel 2</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td style="height: 35px; width: 368px">&nbsp;</td>
                <td style="height: 35px; width: 1337px">&nbsp;</td>
            </tr>
        </table>
    </form>


</asp:Content>
