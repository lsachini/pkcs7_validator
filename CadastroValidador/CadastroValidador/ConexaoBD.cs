using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;

namespace CadastroValidador
{
    class ConexaoBD
    {
        private OdbcConnection conexao;

        protected OdbcConnection Conexao
        {
            get { return conexao; }
        }

        //TODO:
        public void AbrirConexao()
        {
            this.conexao = new OdbcConnection();

            this.conexao.ConnectionString = "Driver=MySQL ODBC 5.1 Driver;Server=localhost;Database=validador;uid=validador;pwd=teste";

            this.conexao.Open();
        }

        //TODO:
        public void FecharConexao()
        {
            this.conexao.Close();
        }
    }
}
