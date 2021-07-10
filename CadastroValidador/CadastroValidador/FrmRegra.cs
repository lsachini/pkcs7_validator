using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroValidador
{
    public partial class FrmRegra : Form
    {
        private static FrmRegra janela = null;
        private TipoTela operacao;
        private String pesquisa;

        public FrmRegra()
        {
            InitializeComponent();
        }

        public static FrmRegra ObterInstancia()
        {
            if(janela == null)
            {
                janela = new FrmRegra();
            }

            return janela;
        }

        public void MudarEstado(TipoTela tipoTela)
        {
            switch (tipoTela)
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
                    txtParametros.Enabled = true;
                    txtRegra.Enabled = true;

                    btnEditar.Visible = false;
                    btnExcluir.Visible = false;
                    btnSalvar.Visible = true;
                    btnVoltar.Visible = true;

                    this.Width = 485;
                    this.Height = 325;

                    break;
                case TipoTela.Consultar:
                    panConsulta.Visible = true;
                    panConsulta.Top = 0;
                    panConsulta.Left = 0;
                    panLista.Visible = false;
                    
                    txtIdentificador.Enabled = false;
                    cboAtivo.Enabled = false;
                    txtParametros.Enabled = false;
                    txtRegra.Enabled = false;

                    btnEditar.Visible = true;
                    btnExcluir.Visible = true;
                    btnSalvar.Visible = false;
                    btnVoltar.Visible = true;

                    this.Width = 485;
                    this.Height = 325;

                    break;
                case TipoTela.Incluir:
                    panConsulta.Visible = true;
                    panConsulta.Top = 0;
                    panConsulta.Left = 0;
                    panLista.Visible = false;
                    
                    txtIdentificador.Enabled = true;
                    cboAtivo.Enabled = true;
                    txtParametros.Enabled = true;
                    txtRegra.Enabled = true;

                    txtIdentificador.Text = String.Empty;
                    cboAtivo.Text = String.Empty;
                    txtParametros.Text = String.Empty;
                    txtRegra.Text = String.Empty;

                    cboAtivo.SelectedIndex = 0;

                    btnEditar.Visible = false;
                    btnExcluir.Visible = false;
                    btnSalvar.Visible = true;
                    btnVoltar.Visible = true;

                    this.Width = 485;
                    this.Height = 325;

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            listaRegras.Rows.Clear();

            RegraRN regraRN = new RegraRN();

            Int64 qtdRegistros;

            pesquisa = txtPesquisar.Text;
            regraRN.Identificador = pesquisa;

            Int32 retorno = regraRN.Contar(out qtdRegistros);

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

            retorno = regraRN.Listar(dataSet);

            if (retorno != 0)
            {
                MessageBox.Show("Erro ao consultar BD");

                return;
            }

            foreach (DataRow linha in dataSet.Tables[0].Rows)
            {
                string ativo = (Int16)linha[1] == 1 ? "Sim" : "Não";

                listaRegras.Rows.Add(new Object[] { linha[0], ativo });
            }
        }

        private void FrmRegra_FormClosed(object sender, FormClosedEventArgs e)
        {
            janela = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                RegraRN regraRN = new RegraRN();

                Int32 retorno = 0;


                regraRN.Identificador = txtIdentificador.Text;

                if (cboAtivo.Text == String.Empty)
                {
                    MessageBox.Show("Preencha o campo Ativo");

                    return;
                }
                else
                {
                    regraRN.Ativo = cboAtivo.Text == "Sim" ? true : false;
                }

                regraRN.Parametros = txtParametros.Text;
                regraRN.Regra = txtRegra.Text;
            
                if (operacao == TipoTela.Incluir)
                {
                    retorno = regraRN.Incluir();
                }
                else
                {
                    retorno = regraRN.Alterar();
                }

                switch (retorno)
                {
                    case 0:
                        MessageBox.Show("Operação concluída com sucesso");

                        if (listaRegras.Rows.Count > 0)
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

        private void FrmRegra_Load(object sender, EventArgs e)
        {
        }
        
        private void cboAtivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listaRegras_DoubleClick(object sender, EventArgs e)
        {
            RegraRN regraRN = new RegraRN();

            regraRN.Identificador = listaRegras.CurrentRow.Cells[0].Value.ToString();

            Int32 retorno = regraRN.Obter();

            if (retorno != 0)
            {
                MessageBox.Show("Erro ao consultar banco");

                return;
            }

            MudarEstado(TipoTela.Consultar);

            txtIdentificador.Text = regraRN.Identificador;
            cboAtivo.SelectedIndex = regraRN.Ativo ? 0 : 1;
            txtParametros.Text = regraRN.Parametros;
            txtRegra.Text = regraRN.Regra;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirmar exclusão do registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

                RegraRN regraRN = new RegraRN();

                regraRN.Identificador = txtIdentificador.Text;

                Int32 retorno = regraRN.Excluir();

                if (retorno != 0)
                {
                    MessageBox.Show("Erro ao consultar banco");
                }
                else
                {
                    MessageBox.Show("Operação concluída com sucesso");
                }

                listaRegras.Rows.Clear();

                txtPesquisar.Text = pesquisa;

                MudarEstado(TipoTela.Listar);

                btnPesquisar_Click(null, null);
            }
            catch { }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = TipoTela.Alterar;

            MudarEstado(TipoTela.Alterar);
        }

        private void listaRegras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
