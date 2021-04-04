<%@ Page Title="" Language="C#" MasterPageFile="~/PageAdmin.Master" AutoEventWireup="true" CodeBehind="clientes.aspx.cs" Inherits="FaturamentoServicos.Pages.clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form id="form1" runat="server">
        <h1> Gestão de Cliente</h1>

        <table style="width: 922px; height: 237px">
            <tr>
                <td rowspan="9" style="height: 281px; width: 336px">
                    <asp:TextBox ID="txtBuscarCliente" runat="server"></asp:TextBox>
                    <asp:Button ID="btnBuscarCliente" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                    <img alt="" src="../images/login/LoginEmpregado.jpg" style="width: 255px; height: 262px" /></td>
                <td colspan="2" style="height: 34px">
                    <h1>
                         <asp:Label ID="lbnEstado" runat="server"></asp:Label>
                    </h1>                 
                </td>
            </tr>

            
            <tr>
                <td style="width: 295px; height: 34px">Código do Cliente</td>
                <td style="width: 397px; height: 34px">
                    <asp:TextBox ID="txtIdCliente" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td style="width: 295px; height: 34px">Nome</td>
                <td style="width: 397px; height: 34px">
                    <asp:TextBox ID="txtNomeCliente" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td style="width: 295px; height: 34px">Primeiro Sobrenome</td>
                <td style="width: 397px; height: 34px">
                    <asp:TextBox ID="txtSobrenome1Cliente" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td style="width: 295px; height: 34px">Segundo Sobrenome</td>
                <td style="width: 397px; height: 34px">
                    <asp:TextBox ID="txtSobrenome2Cliente" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>



            <tr>
                <td style="height: 34px; width: 295px">Endereço</td>
                <td style="height: 34px; width: 397px">
                    <asp:TextBox ID="txtEnderecoCliente" runat="server" Enabled="False" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>

             <tr>
                <td style="height: 34px; width: 295px">E-mail</td>
                <td style="height: 34px; width: 397px">
                    <asp:TextBox ID="txtEmailCliente" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td style="height: 34px; width: 295px">Telefone</td>
                <td style="height: 34px; width: 397px">
                    <asp:TextBox ID="txtTelefoneCliente" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>


            <tr>
                <td style="height: 34px; width: 295px">Empressa</td>
                <td style="height: 34px; width: 397px">
                    <asp:DropDownList ID="drpEmpresa" runat="server" DataSourceID="SqlDataSourceEmpresa" DataTextField="Nome" DataValueField="IdEmpresa" Enabled="False">
                        <asp:ListItem Value="0">Nenhuma</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSourceEmpresa" runat="server" ConnectionString="<%$ ConnectionStrings:FaturamentoServicoConnectionString %>" SelectCommand="SELECT [IdEmpresa], [Nome] FROM [tbl_empresa]"></asp:SqlDataSource>
                </td>
            </tr>


            <tr>
                <td style="height: 35px; width: 368px">
                    <asp:HyperLink ID="linkVoltarHome" runat="server" NavigateUrl="~/Account/login.aspx">Volta a Pagina Login</asp:HyperLink>
                </td>
                <td style="height: 35px; width: 295px">
                    <asp:Button ID="btnNovoCliente" runat="server" Text="Novo" OnClick="btnNovo_Click" />
                    <asp:Button ID="btnAlterarCliente" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
                    <asp:Button ID="btnExcluirCliente" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
                    <asp:Button ID="btnCancelarCliente" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </td>
            </tr>
        </table>
    </form>



    

</asp:Content>
