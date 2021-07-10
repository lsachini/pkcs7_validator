using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CadastroValidador
{
    public partial class FrmCertificado : Form
    {
        private static FrmCertificado janela = null;
        private String certificado;
        private TipoTela operacao;
        private String pesquisa;

        public FrmCertificado()
        {
            InitializeComponent();
        }

        private void FrmCertificado_Load(object sender, EventArgs e)
        {

        }

        public static FrmCertificado ObterInstancia()
        {
            if (janela == null)
            {
                janela = new FrmCertificado();
            }

            return janela;
        }

        public void MudarEstado(TipoTela tipoTela)
        {
            switch(tipoTela)
            {
                case TipoTela.Listar:
                    panLista.Visible = true;
                    panLista.Top = 0;
                    panLista.Left = 0;
                    panConsulta.Visible = false;

                    this.Width = 485;
                    this.Height = 375;

                    break;
                case TipoTela.Alterar:
                    panConsulta.Visible = true;
                    panConsulta.Top = 0;
                    panConsulta.Left = 0;
                    panLista.Visible = false;

                    txtIdentificador.Enabled = false;
                    cboAtivo.Enabled = true;

                    btnEditar.Visible = false;
                    btnExcluir.Visible = false;
                    btnSalvar.Visible = true;
                    btnVoltar.Visible = true;
                    btnCarregar.Visible = true;
                    btnExibir.Visible = true;

                    this.Width = 485;
                    this.Height = 200;

                    break;
                case TipoTela.Consultar:
                    panConsulta.Visible = true;
                    panConsulta.Top = 0;
                    panConsulta.Left = 0;
                    panLista.Visible = false;
                    
                    txtIdentificador.Enabled = false;
                    cboAtivo.Enabled = false;

                    btnEditar.Visible = true;
                    btnExcluir.Visible = true;
                    btnSalvar.Visible = false;
                    btnVoltar.Visible = true;
                    btnCarregar.Visible = false;
                    btnExibir.Visible = true;

                    this.Width = 485;
                    this.Height = 200;

                    break;
                case TipoTela.Incluir:
                    panConsulta.Visible = true;
                    panConsulta.Top = 0;
                    panConsulta.Left = 0;
                    panLista.Visible = false;
                    
                    txtIdentificador.Enabled = true;
                    cboAtivo.Enabled = true;

                    txtIdentificador.Text = String.Empty;
                    cboAtivo.Text = String.Empty;
                    certificado = String.Empty;
                    
                    btnEditar.Visible = false;
                    btnExcluir.Visible = false;
                    btnSalvar.Visible = true;
                    btnVoltar.Visible = true;
                    btnCarregar.Visible = true;
                    btnExibir.Visible = true;

                    this.Width = 485;
                    this.Height = 200;

                    break;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            operacao = TipoTela.Incluir;

            MudarEstado(TipoTela.Incluir);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MudarEstado(TipoTela.Listar);
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (ofdCertificado.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(ofdCertificado.FileName))
                {
                    MessageBox.Show("Arquivo não existe");

                    return;
                }

                Byte[] baConteudo = File.ReadAllBytes(ofdCertificado.FileName);
                String conteudo = String.Empty;

                conteudo = Encoding.GetEncoding( "iso-8859-1" ).GetString(baConteudo);

                try
                {
                    Convert.FromBase64String(conteudo);
                }
                catch 
                {
                    conteudo = Convert.ToBase64String(baConteudo);
                }

                try
                {
                    X509Certificate2 cert = new X509Certificate2(Convert.FromBase64String(conteudo));
                }
                catch
                {
                    MessageBox.Show("Arquivo não é um certificado");

                    return;
                }

                if (conteudo.Length > 10000)
                {
                    MessageBox.Show("Conteúdo do certificado maior do que o permitido");

                    return;
                }

                certificado = conteudo;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listaCertificados.Rows.Clear();

            CertificadoRN certificadoRN = new CertificadoRN();

            Int64 qtdRegistros;

            pesquisa = txtPesquisar.Text;
            certificadoRN.Identificador = pesquisa;

            Int32 retorno = certificadoRN.Contar(out qtdRegistros);

            if (retorno != 0)
            {
                MessageBox.Show("Erro ao consultar BD");

                return;
            }

            if (qtdRegistros == 0)
            {
                MessageBox.Show("Nenhum registro encontrado");

                return;
            }

            DataSet dataSet = new DataSet();

            retorno = certificadoRN.Listar(dataSet);

            if (retorno != 0)
            {
                MessageBox.Show("Erro ao consultar BD");

                return;
            }

            foreach (DataRow linha in dataSet.Tables[0].Rows)
            {
                string ativo = (Int16)linha[1] == 1 ? "Sim" : "Não";

                listaCertificados.Rows.Add(new Object[] { linha[0], ativo });
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                CertificadoRN certificadoRN = new CertificadoRN();

                Int32 retorno = 0;

                certificadoRN.Identificador = txtIdentificador.Text;

                if (cboAtivo.Text == String.Empty)
                {
                    MessageBox.Show("Preencha o campo Ativo");

                    return;
                }
                else
                {
                    certificadoRN.Ativo = cboAtivo.Text == "Sim" ? true : false;
                }

                certificadoRN.Certificado = certificado;
            
                if (operacao == TipoTela.Incluir)
                {
                    retorno = certificadoRN.Incluir();
                }
                else
                {
                    retorno = certificadoRN.Alterar();
                }

                switch (retorno)
                {
                    case 0:
                        MessageBox.Show("Operação concluída com sucesso");

                        if (listaCertificados.Rows.Count > 0)
                        {
                            txtPesquisar.Text = pesquisa;

                            btnPesquisar_Click(null, null);
                        }

                        MudarEstado(TipoTela.Listar);

                        break;
                    case 1:
                        MessageBox.Show("Campo Identificador deve ser informado");

                        break;
                    case 2:
                        MessageBox.Show("Campo Parametros deve ser informado");

                        break;
                    case 3:
                        MessageBox.Show("Campo Regra deve ser informado");

                        break;
                    case 98:
                        MessageBox.Show("Instrução não executada");

                        break;
                    case 99:
                        MessageBox.Show("Exceção");

                        break;
                }
            }
            catch { }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = TipoTela.Alterar;

            MudarEstado(TipoTela.Alterar);
        }

        private void listaCertificados_DoubleClick(object sender, EventArgs e)
        {
            CertificadoRN certificadoRN = new CertificadoRN();

            certificadoRN.Identificador = listaCertificados.CurrentRow.Cells[0].Value.ToString();

            Int32 retorno = certificadoRN.Obter();

            if (retorno != 0)
            {
                MessageBox.Show("Erro ao consultar banco");

                return;
            }

            MudarEstado(TipoTela.Consultar);

            txtIdentificador.Text = certificadoRN.Identificador;
            cboAtivo.SelectedIndex = certificadoRN.Ativo ? 0 : 1;
            certificado = certificadoRN.Certificado;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirmar exclusão do registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                CertificadoRN certificadoRN = new CertificadoRN();

                certificadoRN.Identificador = txtIdentificador.Text;

                Int32 retorno = certificadoRN.Excluir();

                if (retorno != 0)
                {
                    MessageBox.Show("Erro ao consultar banco");
                }
                else
                {
                    MessageBox.Show("Operação concluída com sucesso");
                }

                listaCertificados.Rows.Clear();

                txtPesquisar.Text = pesquisa;

                MudarEstado(TipoTela.Listar);

                btnPesquisar_Click(null, null);
            }
            catch { }
        }

        private void FrmCertificado_FormClosed(object sender, FormClosedEventArgs e)
        {
            janela = null;
        }
    }
}
