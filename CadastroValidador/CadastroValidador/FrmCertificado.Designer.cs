namespace CadastroValidador
{
    partial class FrmCertificado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.validadorDataSet = new CadastroValidador.validadorDataSet();
            this.validadorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panLista = new System.Windows.Forms.Panel();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.listaCertificados = new System.Windows.Forms.DataGridView();
            this.panConsulta = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.cboAtivo = new System.Windows.Forms.ComboBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCertificado = new System.Windows.Forms.Label();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.ofdCertificado = new System.Windows.Forms.OpenFileDialog();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.validadorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validadorDataSetBindingSource)).BeginInit();
            this.panLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCertificados)).BeginInit();
            this.panConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // validadorDataSet
            // 
            this.validadorDataSet.DataSetName = "validadorDataSet";
            this.validadorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // validadorDataSetBindingSource
            // 
            this.validadorDataSetBindingSource.DataSource = this.validadorDataSet;
            this.validadorDataSetBindingSource.Position = 0;
            // 
            // panLista
            // 
            this.panLista.Controls.Add(this.btnIncluir);
            this.panLista.Controls.Add(this.btnPesquisar);
            this.panLista.Controls.Add(this.txtPesquisar);
            this.panLista.Controls.Add(this.listaCertificados);
            this.panLista.Location = new System.Drawing.Point(12, 12);
            this.panLista.Name = "panLista";
            this.panLista.Size = new System.Drawing.Size(455, 317);
            this.panLista.TabIndex = 3;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(3, 291);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(372, 8);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(3, 10);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(363, 20);
            this.txtPesquisar.TabIndex = 3;
            // 
            // listaCertificados
            // 
            this.listaCertificados.AllowUserToAddRows = false;
            this.listaCertificados.AllowUserToDeleteRows = false;
            this.listaCertificados.AllowUserToResizeColumns = false;
            this.listaCertificados.AllowUserToResizeRows = false;
            this.listaCertificados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listaCertificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCertificados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Ativo});
            this.listaCertificados.EnableHeadersVisualStyles = false;
            this.listaCertificados.Location = new System.Drawing.Point(3, 38);
            this.listaCertificados.MultiSelect = false;
            this.listaCertificados.Name = "listaCertificados";
            this.listaCertificados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listaCertificados.RowHeadersVisible = false;
            this.listaCertificados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listaCertificados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaCertificados.Size = new System.Drawing.Size(449, 247);
            this.listaCertificados.TabIndex = 1;
            this.listaCertificados.DoubleClick += new System.EventHandler(this.listaCertificados_DoubleClick);
            // 
            // panConsulta
            // 
            this.panConsulta.Controls.Add(this.btnExibir);
            this.panConsulta.Controls.Add(this.btnCarregar);
            this.panConsulta.Controls.Add(this.btnVoltar);
            this.panConsulta.Controls.Add(this.btnSalvar);
            this.panConsulta.Controls.Add(this.btnExcluir);
            this.panConsulta.Controls.Add(this.cboAtivo);
            this.panConsulta.Controls.Add(this.txtIdentificador);
            this.panConsulta.Controls.Add(this.btnEditar);
            this.panConsulta.Controls.Add(this.lblCertificado);
            this.panConsulta.Controls.Add(this.lblAtivo);
            this.panConsulta.Controls.Add(this.lblIdentificador);
            this.panConsulta.Location = new System.Drawing.Point(12, 335);
            this.panConsulta.Name = "panConsulta";
            this.panConsulta.Size = new System.Drawing.Size(459, 254);
            this.panConsulta.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(251, 114);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(169, 114);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(88, 114);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cboAtivo
            // 
            this.cboAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAtivo.FormattingEnabled = true;
            this.cboAtivo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboAtivo.Location = new System.Drawing.Point(78, 44);
            this.cboAtivo.Name = "cboAtivo";
            this.cboAtivo.Size = new System.Drawing.Size(81, 21);
            this.cboAtivo.TabIndex = 5;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(78, 12);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(149, 20);
            this.txtIdentificador.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(7, 114);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCertificado
            // 
            this.lblCertificado.AutoSize = true;
            this.lblCertificado.Location = new System.Drawing.Point(12, 83);
            this.lblCertificado.Name = "lblCertificado";
            this.lblCertificado.Size = new System.Drawing.Size(60, 13);
            this.lblCertificado.TabIndex = 2;
            this.lblCertificado.Text = "Certificado:";
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(38, 53);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(34, 13);
            this.lblAtivo.TabIndex = 1;
            this.lblAtivo.Text = "Ativo:";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(4, 19);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(68, 13);
            this.lblIdentificador.TabIndex = 0;
            this.lblIdentificador.Text = "Identificador:";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(78, 73);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 9;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(159, 73);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 10;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            // 
            // ofdCertificado
            // 
            this.ofdCertificado.FileName = "openFileDialog1";
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            this.Identificador.Width = 300;
            // 
            // Ativo
            // 
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            // 
            // FrmCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 601);
            this.Controls.Add(this.panConsulta);
            this.Controls.Add(this.panLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCertificado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificado";
            this.Load += new System.EventHandler(this.FrmCertificado_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCertificado_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.validadorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validadorDataSetBindingSource)).EndInit();
            this.panLista.ResumeLayout(false);
            this.panLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCertificados)).EndInit();
            this.panConsulta.ResumeLayout(false);
            this.panConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource validadorDataSetBindingSource;
        private validadorDataSet validadorDataSet;
        private System.Windows.Forms.Panel panLista;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView listaCertificados;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Panel panConsulta;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblCertificado;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox cboAtivo;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.OpenFileDialog ofdCertificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
    }
}