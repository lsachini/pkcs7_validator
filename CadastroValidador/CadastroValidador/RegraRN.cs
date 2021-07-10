using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CadastroValidador
{
    class RegraRN
    {
        private String identificador;
        private Boolean ativo;
        private String parametros;
        private String regra;

        public String Identificador
        {
            set { this.identificador = value; }
            get { return this.identificador; }
        }

        public Boolean Ativo
        {
            set { this.ativo = value; }
            get { return this.ativo;  }
        }

        public String Parametros
        {
            set { this.parametros = value; }
            get { return this.parametros; }
        }

        public String Regra
        {
            set { this.regra = value; }
            get { return this.regra;  }
        }

        public Int32 Incluir()
        {
            try
            {
                RegraBD regraBD = new RegraBD();

                if (this.identificador.Trim() == String.Empty)
                {
                    return 1;
                }

                if (this.regra.Trim() == String.Empty)
                {
                    return 3;
                }

                return regraBD.Incluir(this);
            }
            catch
            {
                return 99;
            }
        }

        public Int32 Alterar()
        {
            try
            {
                if (this.regra.Trim() == String.Empty)
                {
                    return 3;
                }

                RegraBD regraBD = new RegraBD();

                return regraBD.Alterar(this);
            }
            catch
            {
                return 99;
            }
        }

        public Int32 Contar(out Int64 qtdRegistros)
        {
            qtdRegistros = 0;

            try
            {
                RegraBD regraBD = new RegraBD();

                return regraBD.Contar(this.identificador, out qtdRegistros);
            }
            catch
            {
                return 99;
            }
        }

        public Int32 Listar(DataSet dataSet)
        {
            try
            {
                RegraBD regraBD = new RegraBD();

                return regraBD.Listar(this.identificador, dataSet);
            }
            catch
            {
                return 99;
            }
        }

        public Int32 Obter()
        {
            try
            {
                RegraBD regraBD = new RegraBD();

                return regraBD.Obter(this);
            }
            catch
            {
                return 99;
            }
        }

        public Int32 Excluir()
        {
            try
            {
                RegraBD regraBD = new RegraBD();

                return regraBD.Excluir(this);
            }
            catch
            {
                return 99;
            }
        }
    }
}
