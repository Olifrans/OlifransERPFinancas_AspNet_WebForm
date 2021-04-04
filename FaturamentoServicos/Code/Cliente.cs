using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

/// <summary>
/// Classe cliente
/// </summary>
namespace FaturamentoServicos.Code
{
    public class Cliente : Conexao
    {
        //Variaveis globais
        string tabela = "tbl_cliente";
        protected string Nome, Sobrenome1, Sobrenome2, Endereco, Email, Telefone;
        protected int IdCliente, IdEmpresa;

        //Construtor da classe cliente
        public Cliente(int Id_Cliente, int Id_Empresa, string Use_NomeCliente, string Use_Sobrenome1Cliente, string Use_Sobrenome2Cliente, string Use_EnderecoCliente, string Use_EmailCliente, string Use_TelefoneCliente)
        {
            this.IdCliente = Id_Cliente;
            this.IdEmpresa = Id_Empresa;
            this.Nome = Use_NomeCliente;
            this.Sobrenome1 = Use_Sobrenome1Cliente;
            this.Sobrenome2 = Use_Sobrenome2Cliente;
            this.Endereco = Use_EnderecoCliente;
            this.Email = Use_EmailCliente;
            this.Telefone = Use_TelefoneCliente;
        }

        //Metodos da classe cliente
        public int Cliente_idcliente
        {
            set { IdCliente = value; }
            get { return IdCliente; }
        }

        public int EmpresaCliente_idempresa
        {
            set { IdEmpresa = value; }
            get { return IdEmpresa; }
        }

        public string NomeCliente_nome
        {
            set { Nome = value; }
            get { return Nome; }
        }

        public string SobrenomeCliente_sobrenome1
        {
            set { Sobrenome1 = value; }
            get { return Sobrenome1; }
        }

        public string SobrenomeCliente_sobrenome2
        {
            set { Sobrenome2 = value; }
            get { return Sobrenome2; }
        }

        public string EnderecoCliente_endereco
        {
            set { Endereco = value; }
            get { return Endereco; }
        }

        public string EmailCliente_email
        {
            set { Email = value; }
            get { return Email; }
        }

        public string TelefoneCliente_telefone
        {
            set { Telefone = value; }
            get { return Telefone; }
        }



        //Metodos de manipulação e adção de dos dados no BD da classe empregado
        public void adcionarcliente()
        {
            conectar(tabela);
            DataRow fila;
            fila = Data.Tables[tabela].NewRow();

            fila["IdCliente"] = Cliente_idcliente;
            fila["IdEmpresa"] = EmpresaCliente_idempresa;
            fila["Nome"] = NomeCliente_nome;
            fila["Sobrenome1"] = SobrenomeCliente_sobrenome1;
            fila["Sobrenome2"] = SobrenomeCliente_sobrenome2;
            fila["Endereco"] = EnderecoCliente_endereco;
            fila["Email"] = EmailCliente_email;
            fila["Telefone"] = TelefoneCliente_telefone;

            Data.Tables[tabela].Rows.Add(fila);
            da_adapter.Update(Data, tabela);

        }



        //Metodos de manipulação e alteração de dos dados no BD da classe empregado
        public void alterarcliente()
        {
            conectar(tabela);
            DataRow fila;
            int dados = Data.Tables[tabela].Rows.Count - 1;

            for (int i = 0; i <= dados; i++)
            {
                fila = Data.Tables[tabela].Rows[i];
                if (int.Parse(fila["IdEmpregado"].ToString().Trim()) == IdCliente)
                {
                    fila["IdCliente"] = Cliente_idcliente;
                    fila["IdEmpresa"] = EmpresaCliente_idempresa;
                    fila["Nome"] = NomeCliente_nome;
                    fila["Sobrenome1"] = SobrenomeCliente_sobrenome1;
                    fila["Sobrenome2"] = SobrenomeCliente_sobrenome2;
                    fila["Endereco"] = EnderecoCliente_endereco;
                    fila["Email"] = EmailCliente_email;
                    fila["Telefone"] = TelefoneCliente_telefone;

                    da_adapter.Update(Data, tabela);
                }
            }
        }



        //Metodos retorna o booleano (true ou false) e verificar se já existe o registro no BD
        public bool verifica_dados_existecliente(int valor)
        {
            conectar(tabela);
            DataRow fila;

            int dados = Data.Tables[tabela].Rows.Count - 1; //Percorre os registros existente na tabela
            for (int i = 0; i <= dados; i++)
            {
                fila = Data.Tables[tabela].Rows[i];

                if (int.Parse(fila["IdCliente"].ToString().Trim()) == valor) //Buscar e compara os dados existente no BD
                {
                    Cliente_idcliente = int.Parse(fila["IdCliente"].ToString());
                    EmpresaCliente_idempresa = int.Parse(fila["IdEmpresa"].ToString());
                    NomeCliente_nome = fila["Nome"].ToString();
                    SobrenomeCliente_sobrenome1 = fila["Sobrenome1"].ToString();
                    SobrenomeCliente_sobrenome2 = fila["Sobrenome2"].ToString();
                    EnderecoCliente_endereco = fila["Endereco"].ToString();
                    EmailCliente_email = fila["Email"].ToString();
                    TelefoneCliente_telefone = fila["Telefone"].ToString();
                    return true;
                }
            }
            //Caso o objeto não exista no BD.
            return false;
        }



        //Metodos que excluir dados do BD
        public bool excluir_dados_existecliente(int valor)
        {
            conectar(tabela);
            DataRow fila;

            int dados = Data.Tables[tabela].Rows.Count - 1; //Obtem o números de reistros da tabela

            for (int i = 0; i <= dados; i++)
            {
                fila = Data.Tables[tabela].Rows[i]; //Captura os registros

                if (int.Parse(fila["IdCliente"].ToString().Trim()) == valor) //Compara registros com o digitado
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