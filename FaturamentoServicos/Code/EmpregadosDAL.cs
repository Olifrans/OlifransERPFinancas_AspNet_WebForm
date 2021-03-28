//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace FaturamentoServicos.Code
//{
//    public class EmpregadosDAL
//    {
//    }
//}



using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient; //ADO NET --> SQL SERVER



//namespace FaturamentoServicos.Code
//{
    //public class EmpregadosDAL : Conexao //Herança e C#
    //{
    //    //Metodos para gravar dados: Insert:
    //    public void Gravar(Pessoa p)
    //    {
    //        try
    //        {
    //            //Abrir Conexão
    //            AbrirConexao();
    //            Cmd = new SqlCommand("insert into Pessoa(Nome, Endereco, Email) values(@v1, @v2, @v3)", Con);

    //            Cmd.Parameters.AddWithValue("@v1", p.Nome);
    //            Cmd.Parameters.AddWithValue("@v2", p.Endereco);
    //            Cmd.Parameters.AddWithValue("@v3", p.Email);

    //            Cmd.ExecuteNonQuery(); //Executa esse metodto Query
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Erro ao gravar os dados: " + ex.Message);
    //        }
    //        finally
    //        {
    //            //Fechar Conexão
    //            FecharConexao();
    //        }
    //    }


    //    //Metodos para atualizar dados: Update:
    //    public void Atualizar(Pessoa p)
    //    {
    //        try
    //        {
    //            //Abrir Conexão
    //            AbrirConexao();
    //            Cmd = new SqlCommand("update Pessoa set Nome=@v1, Endereco=@v2, Email=@v3 where Id=@v4", Con);

    //            Cmd.Parameters.AddWithValue("@v1", p.Nome);
    //            Cmd.Parameters.AddWithValue("@v2", p.Endereco);
    //            Cmd.Parameters.AddWithValue("@v3", p.Email);
    //            Cmd.Parameters.AddWithValue("@v4", p.Id);

    //            Cmd.ExecuteNonQuery(); //Executa esse metoto update
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Erro ao atualizar os dados: " + ex.Message);
    //        }
    //        finally
    //        {
    //            //Fechar Conexão
    //            FecharConexao();
    //        }
    //    }


    //    //Metodos para excluir dados: delet:
    //    public void Excluir(int Id)
    //    {
    //        try
    //        {
    //            //Abrir Conexão
    //            AbrirConexao();
    //            Cmd = new SqlCommand("delete from Pessoa where Id=@v1", Con);
    //            Cmd.Parameters.AddWithValue("@v1", Id);

    //            Cmd.ExecuteNonQuery(); //Executa o metodo excluir
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Erro ao excluir dados: " + ex.Message);
    //        }
    //        finally
    //        {
    //            //Fechar Conexão
    //            FecharConexao();
    //        }
    //    }


    //    //Metodos para pesquisar e obter pessoa pelo Id - Chave Primaria: Verredura no BD:
    //    public Pessoa ObterPessoaID(int Id)
    //    {
    //        try
    //        {
    //            //Abrir Conexão
    //            AbrirConexao();
    //            Cmd = new SqlCommand("select * from Pessoa where Id=@v1", Con);
    //            Cmd.Parameters.AddWithValue("@v1", Id);
    //            Dr = Cmd.ExecuteReader(); // Execução de leitura das informações no BD


    //            Pessoa p = null;  //Criando um espaço de memória: Ponteiro:

    //            if (Dr.Read())
    //            {
    //                p = new Pessoa();

    //                p.Id = Convert.ToInt32(Dr["Id"]);
    //                p.Nome = Convert.ToString(Dr["Nome"]);
    //                p.Endereco = Convert.ToString(Dr["Endereco"]);
    //                p.Email = Convert.ToString(Dr["Email"]);
    //            }
    //            return p;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Erro ao pesquisar e obter os dados: " + ex.Message);
    //        }
    //        finally
    //        {
    //            //Fechar Conexão
    //            FecharConexao();
    //        }
    //    }


    //    //Metodos para Lista  e obter todos os dados cadastrados
    //    public List<Pessoa> Listar()
    //    {
    //        try
    //        {
    //            //Abrir Conexão
    //            AbrirConexao();
    //            Cmd = new SqlCommand("select * from Pessoa", Con);

    //            Dr = Cmd.ExecuteReader(); //Executa o metodo listar

    //            List<Pessoa> lista = new List<Pessoa>(); // Criando uma Lista Vazia

    //            while (Dr.Read())
    //            {
    //                Pessoa p = new Pessoa();

    //                p.Id = Convert.ToInt32(Dr["Id"]);
    //                p.Nome = Convert.ToString(Dr["Nome"]);
    //                p.Endereco = Convert.ToString(Dr["Endereco"]);
    //                p.Email = Convert.ToString(Dr["Email"]);

    //                lista.Add(p);
    //            }
    //            return lista;

    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("Erro ao Lista os dados: " + ex.Message);
    //        }
    //        finally
    //        {
    //            //Fechar Conexão
    //            FecharConexao();
    //        }
    //    }

    //}
//}

//Regras de negócio da aplicação - consultas (select, update, insert e delete - om metodo obter por ID)
