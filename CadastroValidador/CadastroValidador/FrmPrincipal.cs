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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void itmCertificado_Click(object sender, EventArgs e)
        {
            FrmCertificado frmCertificado = FrmCertificado.ObterInstancia();

            frmCertificado.Width = 485;
            frmCertificado.Height = 375;
            frmCertificado.MudarEstado(TipoTela.Listar);
            frmCertificado.MdiParent = this;
            frmCertificado.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void itmRegra_Click(object sender, EventArgs e)
        {
            FrmRegra frmRegra = FrmRegra.ObterInstancia();

            frmRegra.Width = 485;
            frmRegra.Height = 375;
            frmRegra.MudarEstado(TipoTela.Listar);
            frmRegra.MdiParent = this;
            frmRegra.Show();
        }
    }
}
