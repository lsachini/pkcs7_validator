using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Data;

namespace CadastroValidador
{
    class CertificadoBD : ConexaoBD
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
                                             "CERTIFICADO " +
                                      "FROM CERTIFICADO ";

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

        public Int32 Obter(CertificadoRN certificado)
        {
            try
            {
                this.AbrirConexao();

                OdbcCommand comando = new OdbcCommand();

                comando.Connection = this.Conexao;
                comando.CommandText = "SELECT IDENTIFICADOR, " +
                                             "ATIVO, " +
                                             "CERTIFICADO " +
                                      "FROM CERTIFICADO ";

                if (certificado.Identificador.Trim() != String.Empty)
                {
                    comando.CommandText += "WHERE IDENTIFICADOR = ?";
                    comando.Parameters.Add(new OdbcParameter("IDENTIFICADOR", certificado.Identificador));
                }

                OdbcDataAdapter adaptador = new OdbcDataAdapter();

                adaptador.SelectCommand = comando;

                DataSet dataSet = new DataSet();

                adaptador.Fill(dataSet);

                certificado.Identificador = dataSet.Tables[0].Rows[0]["identificador"].ToString();
                certificado.Ativo = (Int16)dataSet.Tables[0].Rows[0]["ativo"] == 1 ? true : false;
                certificado.Certificado = dataSet.Tables[0].Rows[0]["certificado"].ToString();

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
                                      "FROM CERTIFICADO ";

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

        public Int32 Incluir(CertificadoRN certificado)
        {
            try
            {
                this.AbrirConexao();

                OdbcCommand comando = new OdbcCommand();

                comando.Connection = this.Conexao;
                comando.CommandText = "INSERT INTO CERTIFICADO (IDENTIFICADOR, ATIVO, CERTIFICADO) VALUES (?, ?, ?)";

                OdbcParameter parametro1 = new OdbcParameter("IDENTIFICADOR", certificado.Identificador);
                OdbcParameter parametro2 = new OdbcParameter("ATIVO", certificado.Ativo);
                OdbcParameter parametro3 = new OdbcParameter("CERTIFICADO", certificado.Certificado);

                comando.Parameters.Add(parametro1);
                comando.Parameters.Add(parametro2);
                comando.Parameters.Add(parametro3);

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

        public Int32 Excluir(CertificadoRN certificado)
        {
            try
            {
                this.AbrirConexao();

                OdbcCommand comando = new OdbcCommand();

                comando.Connection = this.Conexao;
                comando.CommandText = "DELETE FROM CERTIFICADO ";

                if (certificado.Identificador.Trim() != String.Empty)
                {
                    comando.CommandText += "WHERE IDENTIFICADOR = ?";

                    comando.Parameters.Add(new OdbcParameter("IDENTIFICADOR", certificado.Identificador));
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

        public Int32 Alterar(CertificadoRN certificado)
        {
            try
            {
                this.AbrirConexao();

                OdbcCommand comando = new OdbcCommand();

                String temporario = String.Empty;

                comando.Connection = this.Conexao;
                comando.CommandText = "UPDATE CERTIFICADO SET ";

                comando.CommandText += "ATIVO = ?, ";
                OdbcParameter parametro2 = new OdbcParameter("ATIVO", certificado.Ativo);
                comando.Parameters.Add(parametro2);

                if (certificado.Certificado.Trim() != String.Empty)
                {
                    comando.CommandText += "CERTIFICADO = ?, ";
                    OdbcParameter parametro3 = new OdbcParameter("CERTIFICADO", certificado.Certificado);
                    comando.Parameters.Add(parametro3);
                }

                if (comando.CommandText.EndsWith(", "))
                {
                    comando.CommandText = comando.CommandText.Substring(0, comando.CommandText.Length - 2);
                }

                if (certificado.Identificador.Trim() != String.Empty)
                {
                    comando.CommandText += " WHERE IDENTIFICADOR = ?";

                    comando.Parameters.Add(new OdbcParameter("IDENTIFICADOR", certificado.Identificador));
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
