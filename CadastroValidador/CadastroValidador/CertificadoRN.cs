using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CadastroValidador
{
    class CertificadoRN
    {
        private String identificador;
        private Boolean ativo;
        private String certificado;

        public String Identificador
        {
            set { this.identificador = value; }
            get { return this.identificador; }
        }

        public Boolean Ativo
        {
            set { this.ativo = value; }
            get { return this.ativo; }
        }

        public String Certificado
        {
            set { this.certificado = value; }
            get { return this.certificado; }
        }

        public Int32 Incluir()
        {
            try
            {
                CertificadoBD certificadoBD = new CertificadoBD();

                if (this.identificador.Trim() == String.Empty)
                {
                    return 1;
                }

                if (this.certificado.Trim() == String.Empty)
                {
                    return 2;
                }

                return certificadoBD.Incluir(this);
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
                CertificadoBD certificadoBD = new CertificadoBD();

                return certificadoBD.Contar(this.identificador, out qtdRegistros);
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
                CertificadoBD certificadoBD = new CertificadoBD();

                return certificadoBD.Listar(this.identificador, dataSet);
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
                CertificadoBD certificacoBD = new CertificadoBD();

                return certificacoBD.Obter(this);
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
                CertificadoBD certificadoBD = new CertificadoBD();

                return certificadoBD.Excluir(this);
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
                CertificadoBD CertificadoBD = new CertificadoBD();

                return CertificadoBD.Alterar(this);
            }
            catch
            {
                return 99;
            }
        }
    }
}
