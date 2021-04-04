using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FaturamentoServicos.Code;

namespace FaturamentoServicos.Account
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFazerLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Empregados emp = new Empregados(0, 0, "", "", "");

                if (emp.FazerLogin(txtUsuario.Text, txtSenha.Text))
                {
                    lblEstado.Text = "Login realizado com sucesso";
                     
                    if (emp.Acesso_idacesso == 1)
                    {
                        //Login admin
                        Response.Redirect("~/HomeAdmin.aspx");
                    }
                    else if (emp.Acesso_idacesso == 2)
                    {
                        //Login usuario
                        Response.Redirect("");
                    }
                    else
                    {                  
                    }

                }
                else
                {
                    lblEstado.Text = "Usuário ou senha invalido";       
                }
            }
            catch
            {
            }
        }
    }
}