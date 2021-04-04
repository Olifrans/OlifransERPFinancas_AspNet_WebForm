using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FaturamentoServicos.Code;

namespace FaturamentoServicos.Pages
{
    public partial class clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verificar se a seção se encotra aberta ou fechada
            
            //try
            //{
            //    if ((bool)(Session["login"]) == false)
            //    {
            //        Response.Redirect("/Account/login.aspx");
            //       // Response.Redirect("");
            //    }
            //}
            //catch
            //{
            //    Response.Redirect("/Account/login.aspx");
            //    //Response.Redirect("");
            //}
        }


        /*
        //Metodo edição enterface usuario habilitar botões
        public void GUIEdicaoCliente()
        {
            btnBuscarCliente.Enabled = true;
            txtIdCliente.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtSobrenome1Cliente.Enabled = true;
            txtSobrenome1Cliente.Enabled = true;
            txtEnderecoCliente.Enabled = true;
            txtEmailCliente.Enabled = true;
            txtTelefoneCliente.Enabled = true;
            lbnEstado.Text = "";

            btnAlterarCliente.Enabled = false;
            btnExcluirCliente.Enabled = false;
        }

        //Metodo limpeza da edição enterface usuario habilitar botões
        public void GUILimparCliente()
        {

            txtIdCliente.Text = "";
            txtNomeCliente.Text = "";
            txtSobrenome1Cliente.Text = "";
            txtSobrenome1Cliente.Text = "";
            txtEnderecoCliente.Text = "";
            txtEmailCliente.Text = "";
            txtTelefoneCliente.Text = "";
            //btnBuscarCliente.Text = "";
        }

        //Metodo habilita da edição enterface usuario do botão buscar
        public void GUIEdicaoTerminadaCliente()
        {
            txtBuscarCliente.Enabled = true;        
            txtIdCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtSobrenome1Cliente.Enabled = false;
            txtSobrenome1Cliente.Enabled = false;
            txtEnderecoCliente.Enabled = false;
            txtEmailCliente.Enabled = false;
            txtTelefoneCliente.Enabled = false;

            lbnEstado.Text = "";
            btnNovoCliente.Text = "Novo";

            btnAlterarCliente.Enabled = true;
            btnExcluirCliente.Enabled = true;
        }

        */

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente emp = new Cliente(0, 0, "", "", "", "", "", "");
                txtBuscarCliente.Enabled = true;

                txtIdCliente.Enabled = false;
                drpEmpresa.Enabled = false;
                txtNomeCliente.Enabled = false;
                txtSobrenome1Cliente.Enabled = false;
                txtSobrenome2Cliente.Enabled = false;
                txtEnderecoCliente.Enabled = false;
                txtEmailCliente.Enabled = false;
                txtTelefoneCliente.Enabled = false;
                //RadioButtonListCategoria.Enabled = false;

                btnNovoCliente.Enabled = true;
                btnNovoCliente.Text = "";
                btnAlterarCliente.Enabled = true;
                btnExcluirCliente.Enabled = true;
                btnCancelarCliente.Enabled = true;


                if (emp.verifica_dados_existecliente(int.Parse(txtBuscarCliente.Text.Trim())))
                {
                    txtIdCliente.Text = emp.Cliente_idcliente.ToString();
                    drpEmpresa.SelectedIndex = drpEmpresa.Items.IndexOf(drpEmpresa.Items.FindByValue(emp.EmpresaCliente_idempresa.ToString()));

                    txtNomeCliente.Text = emp.NomeCliente_nome;
                    txtSobrenome1Cliente.Text = emp.SobrenomeCliente_sobrenome1;
                    txtSobrenome2Cliente.Text = emp.SobrenomeCliente_sobrenome2;
                    txtEnderecoCliente.Text = emp.EnderecoCliente_endereco;
                    txtEmailCliente.Text = emp.EmailCliente_email;
                    txtTelefoneCliente.Text = emp.TelefoneCliente_telefone;

                    lbnEstado.Text = "Registros encontrado com sucesso";
                }
                else 
                {
                    txtIdCliente.Text = "";
                    txtNomeCliente.Text = "";
                    txtSobrenome1Cliente.Text = "";
                    txtSobrenome2Cliente.Text = "";
                    txtEnderecoCliente.Text = "";
                    txtEmailCliente.Text = "";
                    txtTelefoneCliente.Text = "";
                    lbnEstado.Text = "Registros não encontrado, favor verificar se existe cadastro"; 
                }
            }
            catch 
            {
                lbnEstado.Text = "Registros não encontrado, favor verificar se existe cadastro";

                txtIdCliente.Enabled = false;
                txtNomeCliente.Enabled = false;
                txtSobrenome1Cliente.Enabled = false;
                txtSobrenome2Cliente.Enabled = false;
                txtEnderecoCliente.Enabled = false;
                txtEmailCliente.Enabled = false;
                txtTelefoneCliente.Enabled = false;
                //RadioButtonListCategoria.Enabled = false;

                txtIdCliente.Text = "";
                txtNomeCliente.Text = "";
                txtSobrenome1Cliente.Text = "";
                txtSobrenome2Cliente.Text = "";
                txtEnderecoCliente.Text = "";
                txtEmailCliente.Text = "";
                txtTelefoneCliente.Text = "";
               // RadioButtonListCategoria.SelectedIndex = 0;

                btnNovoCliente.Enabled = true;
                btnNovoCliente.Text = "";
                btnAlterarCliente.Enabled = true;
                btnExcluirCliente.Enabled = true;
                btnCancelarCliente.Enabled = true;

                lbnEstado.Text = "Registros não encontrado, favor verificar se existe cadastro";

            }
        }


        protected void btnNovo_Click(object sender, EventArgs e)
        {
            if (btnNovoCliente.Text == "Novo")
            {
                //Alterar estados de controles
                btnNovoCliente.Text = "Salvar";

                txtIdCliente.Enabled = true;
                txtNomeCliente.Enabled = true;
                txtSobrenome1Cliente.Enabled = true;
                txtSobrenome2Cliente.Enabled = true;
                txtEnderecoCliente.Enabled = true;
                txtEmailCliente.Enabled = true;
                txtTelefoneCliente.Enabled = true;
                drpEmpresa.Enabled = true;

                //RadioButtonListCategoria.Enabled = false;
                //RadioButtonListCategoria.Enabled = false;

                btnAlterarCliente.Enabled = false;
                btnExcluirCliente.Enabled = false;

                //Limpar formulario
                txtIdCliente.Text = "";
                txtNomeCliente.Text = "";
                txtSobrenome1Cliente.Text = "";
                txtSobrenome2Cliente.Text = "";
                txtEnderecoCliente.Text = "";
                txtEmailCliente.Text = "";
                txtTelefoneCliente.Text = "";
                lbnEstado.Text = "";
            }
            else if (btnNovoCliente.Text == "Salvar")
            {
                try
                {
                    Cliente emp = new Cliente(0, 0, "", "", "", "", "", ""); //instancia da classe cliente
                    
                    //Alterar estados de controles
                    btnNovoCliente.Text = "Novo";

                    btnAlterarCliente.Enabled = true;
                    btnNovoCliente.Enabled = true;
                    btnExcluirCliente.Enabled = true;
                    btnCancelarCliente.Enabled = true;

                    txtIdCliente.Enabled = false;
                    drpEmpresa.Enabled = false;
                    txtNomeCliente.Enabled = false;
                    txtSobrenome1Cliente.Enabled = false;
                    txtSobrenome2Cliente.Enabled = false;
                    txtEnderecoCliente.Enabled = false;
                    txtEmailCliente.Enabled = false;
                    txtTelefoneCliente.Enabled = false;
                    //RadioButtonListCategoria.Enabled = false;


                    if (emp.verifica_dados_existecliente(int.Parse(txtIdCliente.Text)))
                    {
                        //Capturar dados do formulario
                        emp.Cliente_idcliente = int.Parse(txtIdCliente.Text.Trim());
                        //emp.EmpresaCliente_idempresa = int.Parse(drpEmpresa.Text.Trim());
                        emp.NomeCliente_nome = txtNomeCliente.Text;
                        emp.SobrenomeCliente_sobrenome1 = txtSobrenome1Cliente.Text;
                        emp.SobrenomeCliente_sobrenome2 = txtSobrenome2Cliente.Text;
                        emp.EnderecoCliente_endereco = txtEnderecoCliente.Text;
                        emp.TelefoneCliente_telefone = txtTelefoneCliente.Text;
                        emp.EmailCliente_email = txtEmailCliente.Text;

                        //Categoria

                        emp.alterarcliente(); //Alterar um dados de  cliente
                        lbnEstado.Text = "Dadso do cliente alterado com sucesso ";    
                    }
                    else
                    {
                        //Capturar dados do formulario
                        emp.Cliente_idcliente = int.Parse(txtIdCliente.Text.Trim());
                        emp.EmpresaCliente_idempresa = int.Parse(drpEmpresa.SelectedValue);


                        emp.NomeCliente_nome = txtNomeCliente.Text;
                        emp.SobrenomeCliente_sobrenome1 = txtSobrenome1Cliente.Text;
                        emp.SobrenomeCliente_sobrenome2 = txtSobrenome2Cliente.Text;
                        emp.EnderecoCliente_endereco = txtEnderecoCliente.Text;
                        emp.TelefoneCliente_telefone = txtTelefoneCliente.Text;
                        emp.EmailCliente_email = txtEmailCliente.Text;

                        //Categoria

                        emp.adcionarcliente(); //Adcionar dados de um novo cliente
                        lbnEstado.Text = "Cliente cadastrado com sucesso";
                    }
                }
                catch
                {

                    lbnEstado.Text = "Favor verificar os campos não preenchidos";
                }
            }                      
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            if (btnNovoCliente.Text == "Novo" && txtIdCliente.Text !="")
            {
                //Alterar estados de controles
                btnNovoCliente.Text = "Salvar";

                txtIdCliente.Enabled = true;
                drpEmpresa.Enabled = true;       
                txtNomeCliente.Enabled = true;
                txtSobrenome1Cliente.Enabled = true;
                txtSobrenome2Cliente.Enabled = true;
                txtEnderecoCliente.Enabled = true;
                txtEmailCliente.Enabled = true;
                txtTelefoneCliente.Enabled = true;
                //RadioButtonListCategoria.Enabled = false;

                btnAlterarCliente.Enabled = false;
                btnExcluirCliente.Enabled = false;
            }
            else
            {
                lbnEstado.Text = "Registros não encontrado, favor verificar se existe cadastro";
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente emp = new Cliente(0, 0, "", "", "", "", "", "");
                emp.excluir_dados_existecliente(int.Parse(txtIdCliente.Text));
                lbnEstado.Text = "Registros excluido com sucesso";

                txtBuscarCliente.Enabled = true;
                txtIdCliente.Enabled = false;
                txtNomeCliente.Enabled = false;
                txtSobrenome1Cliente.Enabled = false;
                txtSobrenome2Cliente.Enabled = false;
                txtEnderecoCliente.Enabled = false;
                txtEmailCliente.Enabled = false;
                txtTelefoneCliente.Enabled = false;
                //RadioButtonListCategoria.Enabled = false;
                btnNovoCliente.Enabled = true;
                btnNovoCliente.Text = "";
                btnAlterarCliente.Enabled = true;
                btnExcluirCliente.Enabled = true;
                btnCancelarCliente.Enabled = true;

                txtIdCliente.Text = "";
                txtNomeCliente.Text = "";
                txtSobrenome1Cliente.Text = "";
                txtSobrenome2Cliente.Text = "";
                txtEnderecoCliente.Text = "";
                txtEmailCliente.Text = "";
                txtTelefoneCliente.Text = "";
                //RadioButtonListCategoria.Enabled = false;

            }
            catch
            {
                lbnEstado.Text = "Falha ao excluir o registros, ou na conexão com a basae de dados";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Enabled = true;
            txtIdCliente.Enabled = false;
            drpEmpresa.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtSobrenome1Cliente.Enabled = false;
            txtSobrenome2Cliente.Enabled = false;
            txtEnderecoCliente.Enabled = false;
            txtEmailCliente.Enabled = false;
            txtTelefoneCliente.Enabled = false;
            //RadioButtonListCategoria.Enabled = false;

            btnNovoCliente.Enabled = true;
            btnNovoCliente.Text = "Novo";
            btnAlterarCliente.Enabled = true;
            btnExcluirCliente.Enabled = true;
            btnCancelarCliente.Enabled = true;
        }


        protected void txtIdCliente_TextChanged (object sender, EventArgs e)
        {
            try
            {
                Cliente emp = new Cliente(0, 0, "", "", "", "", "", "");
                if (emp.verifica_dados_existecliente(int.Parse(txtIdCliente.Text.Trim())))
                {
                    //Captura atributos e devolve a busca
                    txtIdCliente.Text = emp.Cliente_idcliente.ToString();
                    txtNomeCliente.Text = emp.NomeCliente_nome;
                    txtSobrenome1Cliente.Text = emp.SobrenomeCliente_sobrenome1;
                    txtSobrenome2Cliente.Text = emp.SobrenomeCliente_sobrenome2;
                    txtEnderecoCliente.Text = emp.EnderecoCliente_endereco;
                    txtEmailCliente.Text = emp.EmailCliente_email;
                    txtTelefoneCliente.Text = emp.TelefoneCliente_telefone;
                    //RadioButtonListCategoria.Enabled = false;

                    lbnEstado.Text = "Registros encontrado com sucesso";
                    txtNomeCliente.Focus();
                }
                else { txtNomeCliente.Focus(); }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}