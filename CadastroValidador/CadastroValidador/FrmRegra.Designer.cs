namespace CadastroValidador
{
    partial class FrmRegra
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
            this.panLista = new System.Windows.Forms.Panel();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.listaRegras = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panConsulta = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtRegra = new System.Windows.Forms.TextBox();
            this.txtParametros = new System.Windows.Forms.TextBox();
            this.cboAtivo = new System.Windows.Forms.ComboBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.lblRegra = new System.Windows.Forms.Label();
            this.lblParametros = new System.Windows.Forms.Label();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.panLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegras)).BeginInit();
            this.panConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panLista
            // 
            this.panLista.Controls.Add(this.btnIncluir);
            this.panLista.Controls.Add(this.btnPesquisar);
            this.panLista.Controls.Add(this.txtPesquisar);
            this.panLista.Controls.Add(this.listaRegras);
            this.panLista.Location = new System.Drawing.Point(12, 12);
            this.panLista.Name = "panLista";
            this.panLista.Size = new System.Drawing.Size(453, 319);
            this.panLista.TabIndex = 0;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(4, 290);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(374, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(3, 10);
            this.txtPesquisar.MaxLength = 50;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(365, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // listaRegras
            // 
            this.listaRegras.AllowUserToAddRows = false;
            this.listaRegras.AllowUserToDeleteRows = false;
            this.listaRegras.AllowUserToResizeColumns = false;
            this.listaRegras.AllowUserToResizeRows = false;
            this.listaRegras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listaRegras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaRegras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Ativo});
            this.listaRegras.Location = new System.Drawing.Point(3, 36);
            this.listaRegras.MultiSelect = false;
            this.listaRegras.Name = "listaRegras";
            this.listaRegras.RowHeadersVisible = false;
            this.listaRegras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaRegras.Size = new System.Drawing.Size(447, 247);
            this.listaRegras.TabIndex = 0;
            this.listaRegras.DoubleClick += new System.EventHandler(this.listaRegras_DoubleClick);
            this.listaRegras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaRegras_CellContentClick);
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
            // panConsulta
            // 
            this.panConsulta.Controls.Add(this.btnVoltar);
            this.panConsulta.Controls.Add(this.btnSalvar);
            this.panConsulta.Controls.Add(this.btnExcluir);
            this.panConsulta.Controls.Add(this.btnEditar);
            this.panConsulta.Controls.Add(this.txtRegra);
            this.panConsulta.Controls.Add(this.txtParametros);
            this.panConsulta.Controls.Add(this.cboAtivo);
            this.panConsulta.Controls.Add(this.txtIdentificador);
            this.panConsulta.Controls.Add(this.lblRegra);
            this.panConsulta.Controls.Add(this.lblParametros);
            this.panConsulta.Controls.Add(this.lblAtivo);
            this.panConsulta.Controls.Add(this.lblIdentificador);
            this.panConsulta.Location = new System.Drawing.Point(12, 337);
            this.panConsulta.Name = "panConsulta";
            this.panConsulta.Size = new System.Drawing.Size(453, 285);
            this.panConsulta.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(250, 254);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(169, 254);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(88, 254);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(7, 254);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtRegra
            // 
            this.txtRegra.Location = new System.Drawing.Point(79, 104);
            this.txtRegra.MaxLength = 2000;
            this.txtRegra.Multiline = true;
            this.txtRegra.Name = "txtRegra";
            this.txtRegra.Size = new System.Drawing.Size(369, 133);
            this.txtRegra.TabIndex = 7;
            // 
            // txtParametros
            // 
            this.txtParametros.Location = new System.Drawing.Point(78, 74);
            this.txtParametros.MaxLength = 255;
            this.txtParametros.Name = "txtParametros";
            this.txtParametros.Size = new System.Drawing.Size(370, 20);
            this.txtParametros.TabIndex = 6;
            // 
            // cboAtivo
            // 
            this.cboAtivo.DisplayMember = " ";
            this.cboAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAtivo.FormattingEnabled = true;
            this.cboAtivo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cboAtivo.Location = new System.Drawing.Point(79, 43);
            this.cboAtivo.Name = "cboAtivo";
            this.cboAtivo.Size = new System.Drawing.Size(121, 21);
            this.cboAtivo.TabIndex = 5;
            this.cboAtivo.ValueMember = " ";
            this.cboAtivo.SelectedIndexChanged += new System.EventHandler(this.cboAtivo_SelectedIndexChanged);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(78, 15);
            this.txtIdentificador.MaxLength = 50;
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(216, 20);
            this.txtIdentificador.TabIndex = 4;
            // 
            // lblRegra
            // 
            this.lblRegra.AutoSize = true;
            this.lblRegra.Location = new System.Drawing.Point(33, 112);
            this.lblRegra.Name = "lblRegra";
            this.lblRegra.Size = new System.Drawing.Size(39, 13);
            this.lblRegra.TabIndex = 3;
            this.lblRegra.Text = "Regra:";
            // 
            // lblParametros
            // 
            this.lblParametros.AutoSize = true;
            this.lblParametros.Location = new System.Drawing.Point(9, 81);
            this.lblParametros.Name = "lblParametros";
            this.lblParametros.Size = new System.Drawing.Size(63, 13);
            this.lblParametros.TabIndex = 2;
            this.lblParametros.Text = "Parametros:";
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Location = new System.Drawing.Point(38, 52);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(34, 13);
            this.lblAtivo.TabIndex = 1;
            this.lblAtivo.Text = "Ativo:";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(4, 22);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(68, 13);
            this.lblIdentificador.TabIndex = 0;
            this.lblIdentificador.Text = "Identificador:";
            // 
            // FrmRegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 634);
            this.Controls.Add(this.panConsulta);
            this.Controls.Add(this.panLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmRegra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regra";
            this.Load += new System.EventHandler(this.FrmRegra_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegra_FormClosed);
            this.panLista.ResumeLayout(false);
            this.panLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegras)).EndInit();
            this.panConsulta.ResumeLayout(false);
            this.panConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panLista;
        private System.Windows.Forms.DataGridView listaRegras;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Panel panConsulta;
        private System.Windows.Forms.Label lblRegra;
        private System.Windows.Forms.Label lblParametros;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.TextBox txtRegra;
        private System.Windows.Forms.TextBox txtParametros;
        private System.Windows.Forms.ComboBox cboAtivo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
    }
}