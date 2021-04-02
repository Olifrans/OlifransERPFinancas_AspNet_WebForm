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
            this.IdAcesso    = Id_Acesso;
            this.Nome        = Use_Nome;
            this.Usuario     = Use_Usuario;
            this.Senha       = Use_Senha;
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

        //Metodos de manipulação e adção de dos dados no BD da classe empregado
        public void adcionar()
        {
            conectar(tabela);
            DataRow fila;
            fila = Data.Tables[tabela].NewRow();

            fila["IdEmpregado"] = Empregado_idempregado;
            fila["IdAcesso"]    = Acesso_idacesso; ;
            fila["Nome"]        = Nome_nome;
            fila["Usuario"]     = Usuario_usuario;
            fila["Senha"]       = Senha_senha;

            Data.Tables[tabela].Rows.Add(fila);
            da_adapter.Update(Data, tabela);
        }


        //Metodos de manipulação e alteração de dos dados no BD da classe empregado
        public void alterar()
        {
            conectar(tabela);
            DataRow fila;
            int dados = Data.Tables[tabela].Rows.Count - 1;

            for (int i = 0; i <= dados; i++)
            {
                fila = Data.Tables[tabela].Rows[i];
                if(int.Parse(fila["IdEmpregado"].ToString().Trim()) == IdEmpregado)
                {
                    fila["IdEmpregado"] = Empregado_idempregado;
                    fila["IdAcesso"]    = Acesso_idacesso; ;
                    fila["Nome"]        = Nome_nome;
                    fila["Usuario"]     = Usuario_usuario;
                    fila["Senha"]       = Senha_senha;

                    da_adapter.Update(Data, tabela);
                }
            }
        }


        //Metodos retorna o booleano (true ou false) e verificar se já existe o registro no BD
        public bool verifica_dados_existe(int valor)
        {
            conectar(tabela);
            DataRow fila;

            int dados = Data.Tables[tabela].Rows.Count - 1; //Percorre os registros existente na tabela
            for (int i=0; i <= dados; i++)
            {
                fila = Data.Tables[tabela].Rows[i];

                if (int.Parse(fila["IdEmpregado"].ToString().Trim()) == valor) //Buscar e compara os dados existente no BD
                {
                    Empregado_idempregado   = int.Parse(fila["IdEmpregado"].ToString());
                    Acesso_idacesso         = int.Parse(fila["IdAcesso"].ToString());
                    Nome_nome               = fila["Nome"].ToString();
                    Usuario_usuario         = fila["Usuario"].ToString();
                    Senha_senha             = fila["Senha"].ToString();
                    return true;
                }
            }
            //Caso o objeto não exista no BD.
            return false;
        }


        //Metodos que excluir dados do BD
        public bool excluir_dados_existe(int valor)
        {
            conectar(tabela);
            DataRow fila;

            int dados = Data.Tables[tabela].Rows.Count - 1; //Obtem o números de reistros da tabela

            for (int i = 0; i <= dados; i++)
            {
                fila = Data.Tables[tabela].Rows[i]; //Captura os registros

                if (int.Parse(fila["IdEmpregado"].ToString().Trim()) == valor) //Compara registros com o digitado
                {
                    fila = Data.Tables[tabela].Rows[i];
                    fila.Delete();
                    DataTable dadosapagado;

                    dadosapagado = Data.Tables[tabela].GetChanges(DataRowState.Deleted);
                    da_adapter.Update(dadosapagado);
                    Data.Tables[tabela].AcceptChanges();
                    return true;
                }
            }
            //Caso o objeto não exista no BD.
            return false;
        }


    }
}