<%@ Page Title="" Language="C#" MasterPageFile="~/PageLogin.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FaturamentoServicos.Account.login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form id="form1" runat="server">
    <table style="width: 100%">
    <tr>
        <td rowspan="6" style="width: 51px">
            <img alt="" src="../images/login/login1.jpg" style="width: 225px; height: 225px" /></td>
        <td>&nbsp;</td>
        <td>Iniciar Sessão</td>
    </tr>
    <tr>
        <td>Usuário</td>
        <td>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Senha</td>
        <td>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="height: 37px"></td>
        <td style="height: 37px">
            <asp:CheckBox ID="chkLembrarSessao" runat="server" Text="Lembrar da sessão" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="lblEstado" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="btnFazerLogin" runat="server" Text="Fazer Login" Width="128px" />
            <asp:HyperLink ID="linkCriarConta" runat="server" NavigateUrl="~/Account/registro.aspx">Criar Conta</asp:HyperLink>
        </td>
    </tr>
</table>

        <a href="/Default.aspx" class="btn btn-default btn-lg"> Voltara Home</a>

</form>

</asp:Content>
