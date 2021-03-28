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
    public class Conexao
    {
        //Atibutos
        protected SqlDataAdapter da_adapter;
        protected SqlDataReader dr_reader;
        protected DataSet ds_set;
        protected SqlConnection conex = new SqlConnection();
        //protected SqlCommand Cmd;

        public void conectar(string tabela)
        {
            string strConexao = ConfigurationManager.ConnectionStrings["FaturamentoServicoConnectionString"].ConnectionString;

            conex.ConnectionString = strConexao;
            conex.Open();
            da_adapter = new SqlDataAdapter("select * from "+ tabela, conex);
            SqlCommandBuilder executarcomandos = new SqlCommandBuilder(da_adapter);

            Data = new DataSet();
            da_adapter.Fill(Data, tabela);
            conex.Close();
        }

        public DataSet Data
        {
            set { ds_set = value; }
            get { return ds_set; }
        }

        public SqlDataReader DataReader
        {
            set { dr_reader = value; }
            get { return dr_reader; }
        }
    }
}