using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;

namespace CadastroValidador
{
    class RegraBD: ConexaoBD
    {
        public Int32 Listar(String identificador,
                            DataSet dataSet)
        {
            try
            {
                this.AbrirConexao();

                OdbcCommand comando = new OdbcCommand();

                comando.Connection = this.Conexao;
                comando.CommandText = "SELECT IDENTIFICADOR, " +
                                             "ATIVO, " +
                                             "PARAMETROS, " +
                                             "REGRA " +
                                      "FROM REGRA ";

                if (identificador != String.Empty)
                {
                    comando.CommandText += "WHERE IDENTIFICADOR LIKE ?";
                    comando.Parameters.Add(new OdbcParameter("IDENTIFICADOR", identificador + "%"));
                }

                comando.CommandText += "ORDER BY IDENTIFICADOR ASC";

                OdbcDataAdapter adaptador = new OdbcDataAdapter();

                adaptador.SelectCommand = comando;

                adaptador.Fill(dataSet);

                return 0;
            }
            catch 
            {
                return 99;
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public Int32 Obter(RegraRN regra)
        {
            try
            {
                this.AbrirConexao();

                OdbcCommand comando = new OdbcCommand();

                comando.Connection = this.Conexao;
                comando.CommandText = "SELECT IDENTIFICADOR, " +
                                             "ATIVO, " +
                                             "PARAMETROS, " +
                                             "REGRA " +
                                      "FROM REGRA ";

                if (regra.Identificador.Trim() != String.Empty)
                {
                    comando.CommandText += "WHERE IDENTIFICADOR = ?";
                    comando.Parameters.Add(new OdbcParameter("IDENTIFICADOR", regra.Identificador));
                }

                OdbcDataAdapter adaptador = new OdbcDataAdapter();

                adaptador.SelectCommand = comando;

                DataSet dataSet = new DataSet();

                adaptador.Fill(dataSet);

                regra.Identificador = dataSet.Tables[0].Rows[0]["identificador"].ToString();
                regra.Ativo = (Int16)dataSet.Tables[0].Rows[0]["ativo"] == 1 ? true : false;
                regra.Parametros = dataSet.Tables[0].Rows[0]["parametros"] != null ? dataSet.Tables[0].Rows[0]["parametros"].ToString() : String.Empty;
                regra.Regra = dataSet.Tables[0].Rows[0]["regra"].ToString();

                return 0;
            }
            catch
            {
                return 99;
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public Int32 Contar(String identificador,
                            out Int64 qtdRegistros)
        {
            qtdRegistros = 0;

            try
            {
                this.AbrirConexao();

                OdbcCommand comando = new OdbcCommand();

                comando.Connection = this.Conexao;
                comando.CommandText = "SELECT COUNT(*) " +
                                      "FROM REGRA ";

                if (identificador.Trim() != String.Empty)
                {
                    comando.CommandText += "WHERE IDENTIFICADOR LIKE ?";

                    comando.Parameters.Add(new OdbcParameter("IDENTIFICADOR", identificador + "%"));
                }

                qtdRegistros = (Int64)comando.ExecuteScalar();

                return 0;
            }
            catch
            {
                return 99;
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public Int32 Incluir(RegraRN regra)
        {
            try
            {
                this.AbrirConexao();

                OdbcCommand comando = new OdbcCommand();

                comando.Connection = this.Conexao;
                comando.CommandText = "INSERT INTO REGRA (IDENTIFICADOR, ATIVO, PARAMETROS, REGRA) VALUES (?, ?, ?, ?)";

                OdbcParameter parametro1 = new OdbcParameter("IDENTIFICADOR", regra.Identificador);
                OdbcParameter parametro2 = new OdbcParameter("ATIVO", regra.Ativo);
                OdbcParameter parametro3 = new OdbcParameter("PARAMETROS", regra.Parametros);
                OdbcParameter parametro4 = new OdbcParameter("REGRA", regra.Regra);

                comando.Parameters.Add(parametro1);
                comando.Parameters.Add(parametro2);
                comando.Parameters.Add(parametro3);
                comando.Parameters.Add(parametro4);

                Int32 retorno = comando.ExecuteNonQuery();

                if (retorno == 0)
                {
                    return 98;
                }

                return 0;
            }
            catch
            {
                return 99;
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public Int32 Alterar(RegraRN regra)
        {
            try
            {
                this.AbrirConexao();

                OdbcCommand comando = new OdbcCommand();

                String temporario = String.Empty;

                comando.Connection = this.Conexao;
                comando.CommandText = "UPDATE REGRA SET ";

                comando.CommandText += "ATIVO = ?, ";
                OdbcParameter parametro2 = new OdbcParameter("ATIVO", regra.Ativo);
                comando.Parameters.Add(parametro2);
  
                if (regra.Parametros.Trim() != String.Empty)
                {
                    comando.CommandText += "PARAMETROS = ?, ";
                    OdbcParameter parametro3 = new OdbcParameter("PARAMETROS", regra.Parametros);
                    comando.Parameters.Add(parametro3);
                }

                if (regra.Regra.Trim() != String.Empty)
                {
                    comando.CommandText += "REGRA = ?, ";
                    OdbcParameter parametro4 = new OdbcParameter("REGRA", regra.Regra);
                    comando.Parameters.Add(parametro4);
                }

                if (comando.CommandText.EndsWith(", "))
                {
                    comando.CommandText = comando.CommandText.Substring(0, comando.CommandText.Length - 2);
                }

                if (regra.Identificador.Trim() != String.Empty)
                {
                    comando.CommandText += " WHERE IDENTIFICADOR = ?";

                    comando.Parameters.Add(new OdbcParameter("IDENTIFICADOR", regra.Identificador));
                }

                Int32 retorno = comando.ExecuteNonQuery();

                if (retorno == 0)
                {
                    return 98;
                }

                return 0;
            }
            catch
            {
                return 99;
            }
            finally
            {
                this.FecharConexao();
            }
        }

        public Int32 Excluir(RegraRN regra)
        {
            try
            {
                this.AbrirConexao();

                OdbcCommand comando = new OdbcCommand();

                comando.Connection = this.Conexao;
                comando.CommandText = "DELETE FROM REGRA ";

                if (regra.Identificador.Trim() != String.Empty)
                {
                    comando.CommandText += "WHERE IDENTIFICADOR = ?";

                    comando.Parameters.Add(new OdbcParameter("IDENTIFICADOR", regra.Identificador));
                }

                Int32 retorno = comando.ExecuteNonQuery();

                if (retorno == 0)
                {
                    return 98;
                }

                return 0;
            }
            catch
            {
                return 99;
            }
            finally
            {
                this.FecharConexao();
            }
        }
    }
}
