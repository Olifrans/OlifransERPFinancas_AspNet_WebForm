using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FaturamentoServicos.Code;

namespace FaturamentoServicos.Account
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Metodo adcionar criar registro de novos usuarios no BD
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            Empregados emp = new Empregados(0, 0, "", "", "");

            emp.Empregado_idempregado = int.Parse(txtIdEmpregado.Text);
            emp.Acesso_idacesso = int.Parse(rdbAcesso.SelectedValue);
            emp.Nome_nome = txtNome.Text;
            emp.Usuario_usuario = txtUsuario.Text;
            emp.Senha_senha = txtSenha.Text;

            emp.adcionar();
            lbnEstado.Text = "Conta Criada Com Sucesso";

        }
    }
}