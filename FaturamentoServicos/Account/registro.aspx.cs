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

        //Metodo edição enterface usuario habilitar botões
        public void GUIEdicao()
        {
            txtBuscar.Enabled       = true;
            txtIdEmpregado.Enabled  = true;
            txtNome.Enabled         = true;
            txtUsuario.Enabled      = true;
            txtSenha.Enabled        = true;
            rdbAcesso.Enabled       = true;
            lbnEstado.Text          = "";

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        //Metodo limpeza da edição enterface usuario habilitar botões
        public void GUILimpar()
        {

            txtIdEmpregado.Text = "";
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            rdbAcesso.ClearSelection();

            //txtBuscar.Text = "";
        }

        // BUTTON CRIAR - Metodo adcionar criar registro de novos usuarios no BD pelo botão Criar
        protected void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnNovo.Text == "Novo"){
                GUIEdicao();
                GUILimpar();
                btnNovo.Text = "Salvar";

            }
            else if(btnNovo.Text == "Salvar")
            {

                    
            }


            //Criar novo registro
            Empregados emp = new Empregados(0, 0, "", "", "");
            
            emp.Empregado_idempregado = int.Parse(txtIdEmpregado.Text);
            emp.Acesso_idacesso = int.Parse(rdbAcesso.SelectedValue);
            emp.Nome_nome = txtNome.Text;
            emp.Usuario_usuario = txtUsuario.Text;
            emp.Senha_senha = txtSenha.Text;

            emp.adcionar();
            lbnEstado.Text= "Conta Criada Com Sucesso" ;

        }




        // BUTTON ALTERAR - Altera os dados criados no BD usando o metodo alterar
        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Empregados emp = new Empregados(0, 0, "", "", "");

            emp.Empregado_idempregado = int.Parse(txtIdEmpregado.Text);
            emp.Acesso_idacesso = int.Parse(rdbAcesso.SelectedValue);
            emp.Nome_nome = txtNome.Text;
            emp.Usuario_usuario = txtUsuario.Text;
            emp.Senha_senha = txtSenha.Text;

            emp.alterar();
            lbnEstado.Text = "Registros alterados com sucesso";
        }

        // BUTTON ALTERAR - Excluir dados criados no BD usando o metodo alterar
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Empregados emp = new Empregados(0, 0, "", "", "");
            emp.excluir_dados_existe(int.Parse(txtIdEmpregado.Text));
            lbnEstado.Text = "Registros excluido com sucesso";

        }

        // BUTTON ALTERAR - Excluir dados criados no BD usando o metodo alterar
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Empregados emp = new Empregados(0, 0, "", "", "");

            if (emp.verifica_dados_existe(int.Parse(txtBuscar.Text.Trim())))
            {
                txtIdEmpregado.Text = emp.Empregado_idempregado.ToString();
                txtNome.Text = emp.Nome_nome;
                txtSenha.Text = emp.Senha_senha;
                txtUsuario.Text = emp.Usuario_usuario;
                rdbAcesso.SelectedIndex = rdbAcesso.Items.IndexOf(rdbAcesso.Items.FindByValue(emp.Acesso_idacesso.ToString()));

                lbnEstado.Text = "Registros encontrado com sucesso";

            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Empregados emp = new Empregados(0, 0, "", "", "");

            
        }
    }
}