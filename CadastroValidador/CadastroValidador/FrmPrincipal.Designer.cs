namespace CadastroValidador
{
    partial class FrmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.opcManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.itmCertificado = new System.Windows.Forms.ToolStripMenuItem();
            this.itmRegra = new System.Windows.Forms.ToolStripMenuItem();
            this.opcSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.itmPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcManutencao,
            this.opcSobre});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(593, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // opcManutencao
            // 
            this.opcManutencao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmCertificado,
            this.itmRegra});
            this.opcManutencao.Name = "opcManutencao";
            this.opcManutencao.Size = new System.Drawing.Size(78, 20);
            this.opcManutencao.Text = "Manutenção";
            // 
            // itmCertificado
            // 
            this.itmCertificado.Name = "itmCertificado";
            this.itmCertificado.Size = new System.Drawing.Size(152, 22);
            this.itmCertificado.Text = "Certificado";
            this.itmCertificado.Click += new System.EventHandler(this.itmCertificado_Click);
            // 
            // itmRegra
            // 
            this.itmRegra.Name = "itmRegra";
            this.itmRegra.Size = new System.Drawing.Size(152, 22);
            this.itmRegra.Text = "Regra";
            this.itmRegra.Click += new System.EventHandler(this.itmRegra_Click);
            // 
            // opcSobre
            // 
            this.opcSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmPrograma});
            this.opcSobre.Name = "opcSobre";
            this.opcSobre.Size = new System.Drawing.Size(47, 20);
            this.opcSobre.Text = "Sobre";
            // 
            // itmPrograma
            // 
            this.itmPrograma.Name = "itmPrograma";
            this.itmPrograma.Size = new System.Drawing.Size(142, 22);
            this.itmPrograma.Text = "O Programa";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 375);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Cadastro Validador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem opcManutencao;
        private System.Windows.Forms.ToolStripMenuItem itmCertificado;
        private System.Windows.Forms.ToolStripMenuItem itmRegra;
        private System.Windows.Forms.ToolStripMenuItem opcSobre;
        private System.Windows.Forms.ToolStripMenuItem itmPrograma;
    }
}

