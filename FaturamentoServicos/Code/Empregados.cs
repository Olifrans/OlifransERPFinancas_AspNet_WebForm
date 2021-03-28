using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace FaturamentoServicos.Code
{
    public class Empregados : Conexao
    {
        //Variaveis globais
        //string tabela = "tbl_empregado";
        string tabela = "tbl_empregado";
        protected string Nome, Usuario, Senha;
        protected int IdEmpregado, IdAcesso;

        //Construtor da classe empregado
        public Empregados(int Id_Empregado, int Id_Acesso, string Use_Nome, string Use_Usuario, string Use_Senha)
        {         
            this.IdEmpregado = Id_Empregado;
            this.IdAcesso = Id_Acesso;
            this.Nome = Use_Nome;
            this.Usuario = Use_Usuario;
            this.Senha = Use_Senha;
        }

        //Metodos da classe empregado
        public int Empregado_idempregado
        {
            set { IdEmpregado = value; }
            get { return IdEmpregado; }
        }

        public int Acesso_idacesso
        {
            set { IdAcesso = value; }
            get { return IdAcesso; }
        }

        public string Nome_nome
        {
            set { Nome = value; }
            get { return Nome; }
        }

        public string Usuario_usuario
        {
            set { Usuario = value; }
            get { return Usuario; }
        }

        public string Senha_senha
        {
            set { Senha = value; }
            get { return Senha; }
        }

        //Metodos de manipulação dos dados da classe empregado
        public void adcionar()
        {
            conectar(tabela);
            DataRow fila;
            fila = Data.Tables[tabela].NewRow();

            fila["IdEmpregado"] = Empregado_idempregado;
            fila["IdAcesso"] = Acesso_idacesso; ;
            fila["Nome"] = Nome_nome;
            fila["Usuario"] = Usuario_usuario;
            fila["Senha"] = Senha_senha;

            Data.Tables[tabela].Rows.Add(fila);
            da_adapter.Update(Data, tabela);
        }
    }
}