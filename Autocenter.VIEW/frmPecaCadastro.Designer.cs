namespace Autocenter.VIEW
{
    partial class frmPecaCadastro
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
            this.grbPecaPesquisa = new System.Windows.Forms.GroupBox();
            this.cboPecaFiltro = new System.Windows.Forms.ComboBox();
            this.btnPecaBusca = new System.Windows.Forms.Button();
            this.txtPecaBusca = new System.Windows.Forms.TextBox();
            this.btnPecaRelatorio = new System.Windows.Forms.Button();
            this.grvPecaPesquisa = new System.Windows.Forms.DataGridView();
            this.btnPecaExcluir = new System.Windows.Forms.Button();
            this.btnPecaSalvar = new System.Windows.Forms.Button();
            this.txtPecaValor = new System.Windows.Forms.TextBox();
            this.lblPecaValor = new System.Windows.Forms.Label();
            this.cboPecaModelo = new System.Windows.Forms.ComboBox();
            this.lblPecaModelo = new System.Windows.Forms.Label();
            this.txtPecaQtd = new System.Windows.Forms.TextBox();
            this.lblPecaQtd = new System.Windows.Forms.Label();
            this.txtPecaNome = new System.Windows.Forms.TextBox();
            this.lblPecaNome = new System.Windows.Forms.Label();
            this.txtPecaMarca = new System.Windows.Forms.TextBox();
            this.lblPecaMarca = new System.Windows.Forms.Label();
            this.btnPecaLimpar = new System.Windows.Forms.Button();
            this.grbPecaPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPecaPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPecaPesquisa
            // 
            this.grbPecaPesquisa.Controls.Add(this.cboPecaFiltro);
            this.grbPecaPesquisa.Controls.Add(this.btnPecaBusca);
            this.grbPecaPesquisa.Controls.Add(this.txtPecaBusca);
            this.grbPecaPesquisa.Controls.Add(this.btnPecaRelatorio);
            this.grbPecaPesquisa.Controls.Add(this.grvPecaPesquisa);
            this.grbPecaPesquisa.Location = new System.Drawing.Point(5, 110);
            this.grbPecaPesquisa.Name = "grbPecaPesquisa";
            this.grbPecaPesquisa.Size = new System.Drawing.Size(546, 235);
            this.grbPecaPesquisa.TabIndex = 48;
            this.grbPecaPesquisa.TabStop = false;
            this.grbPecaPesquisa.Text = "Pesquisa";
            // 
            // cboPecaFiltro
            // 
            this.cboPecaFiltro.FormattingEnabled = true;
            this.cboPecaFiltro.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Marca"});
            this.cboPecaFiltro.Location = new System.Drawing.Point(7, 19);
            this.cboPecaFiltro.Name = "cboPecaFiltro";
            this.cboPecaFiltro.Size = new System.Drawing.Size(134, 21);
            this.cboPecaFiltro.TabIndex = 13;
            // 
            // btnPecaBusca
            // 
            this.btnPecaBusca.Location = new System.Drawing.Point(317, 17);
            this.btnPecaBusca.Name = "btnPecaBusca";
            this.btnPecaBusca.Size = new System.Drawing.Size(75, 23);
            this.btnPecaBusca.TabIndex = 12;
            this.btnPecaBusca.Text = "Busca";
            this.btnPecaBusca.UseVisualStyleBackColor = true;
            this.btnPecaBusca.Click += new System.EventHandler(this.btnPecaBusca_Click);
            // 
            // txtPecaBusca
            // 
            this.txtPecaBusca.Location = new System.Drawing.Point(147, 19);
            this.txtPecaBusca.Name = "txtPecaBusca";
            this.txtPecaBusca.Size = new System.Drawing.Size(164, 20);
            this.txtPecaBusca.TabIndex = 11;
            // 
            // btnPecaRelatorio
            // 
            this.btnPecaRelatorio.Location = new System.Drawing.Point(434, 16);
            this.btnPecaRelatorio.Name = "btnPecaRelatorio";
            this.btnPecaRelatorio.Size = new System.Drawing.Size(106, 23);
            this.btnPecaRelatorio.TabIndex = 2;
            this.btnPecaRelatorio.Text = "Emitir Relatorio";
            this.btnPecaRelatorio.UseVisualStyleBackColor = true;
            // 
            // grvPecaPesquisa
            // 
            this.grvPecaPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPecaPesquisa.Location = new System.Drawing.Point(7, 49);
            this.grvPecaPesquisa.Name = "grvPecaPesquisa";
            this.grvPecaPesquisa.ReadOnly = true;
            this.grvPecaPesquisa.Size = new System.Drawing.Size(533, 175);
            this.grvPecaPesquisa.TabIndex = 3;
            this.grvPecaPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPecaPesquisa_CellDoubleClick);
            // 
            // btnPecaExcluir
            // 
            this.btnPecaExcluir.Location = new System.Drawing.Point(93, 64);
            this.btnPecaExcluir.Name = "btnPecaExcluir";
            this.btnPecaExcluir.Size = new System.Drawing.Size(79, 40);
            this.btnPecaExcluir.TabIndex = 7;
            this.btnPecaExcluir.Text = "Excluir";
            this.btnPecaExcluir.UseVisualStyleBackColor = true;
            this.btnPecaExcluir.Click += new System.EventHandler(this.btnPecaExcluir_Click);
            // 
            // btnPecaSalvar
            // 
            this.btnPecaSalvar.Location = new System.Drawing.Point(8, 64);
            this.btnPecaSalvar.Name = "btnPecaSalvar";
            this.btnPecaSalvar.Size = new System.Drawing.Size(79, 40);
            this.btnPecaSalvar.TabIndex = 5;
            this.btnPecaSalvar.Text = "Salvar";
            this.btnPecaSalvar.UseVisualStyleBackColor = true;
            this.btnPecaSalvar.Click += new System.EventHandler(this.btnPecaSalvar_Click_1);
            // 
            // txtPecaValor
            // 
            this.txtPecaValor.Location = new System.Drawing.Point(236, 35);
            this.txtPecaValor.Name = "txtPecaValor";
            this.txtPecaValor.Size = new System.Drawing.Size(58, 20);
            this.txtPecaValor.TabIndex = 3;
            // 
            // lblPecaValor
            // 
            this.lblPecaValor.AutoSize = true;
            this.lblPecaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecaValor.Location = new System.Drawing.Point(191, 34);
            this.lblPecaValor.Name = "lblPecaValor";
            this.lblPecaValor.Size = new System.Drawing.Size(46, 18);
            this.lblPecaValor.TabIndex = 43;
            this.lblPecaValor.Text = "Valor:";
            // 
            // cboPecaModelo
            // 
            this.cboPecaModelo.FormattingEnabled = true;
            this.cboPecaModelo.Location = new System.Drawing.Point(64, 35);
            this.cboPecaModelo.Name = "cboPecaModelo";
            this.cboPecaModelo.Size = new System.Drawing.Size(121, 21);
            this.cboPecaModelo.TabIndex = 2;
            // 
            // lblPecaModelo
            // 
            this.lblPecaModelo.AutoSize = true;
            this.lblPecaModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecaModelo.Location = new System.Drawing.Point(5, 36);
            this.lblPecaModelo.Name = "lblPecaModelo";
            this.lblPecaModelo.Size = new System.Drawing.Size(62, 18);
            this.lblPecaModelo.TabIndex = 41;
            this.lblPecaModelo.Text = "Modelo:";
            // 
            // txtPecaQtd
            // 
            this.txtPecaQtd.Location = new System.Drawing.Point(377, 7);
            this.txtPecaQtd.Name = "txtPecaQtd";
            this.txtPecaQtd.Size = new System.Drawing.Size(46, 20);
            this.txtPecaQtd.TabIndex = 1;
            // 
            // lblPecaQtd
            // 
            this.lblPecaQtd.AutoSize = true;
            this.lblPecaQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecaQtd.Location = new System.Drawing.Point(341, 7);
            this.lblPecaQtd.Name = "lblPecaQtd";
            this.lblPecaQtd.Size = new System.Drawing.Size(36, 18);
            this.lblPecaQtd.TabIndex = 39;
            this.lblPecaQtd.Text = "Qtd:";
            // 
            // txtPecaNome
            // 
            this.txtPecaNome.Location = new System.Drawing.Point(64, 7);
            this.txtPecaNome.Name = "txtPecaNome";
            this.txtPecaNome.Size = new System.Drawing.Size(271, 20);
            this.txtPecaNome.TabIndex = 0;
            // 
            // lblPecaNome
            // 
            this.lblPecaNome.AutoSize = true;
            this.lblPecaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecaNome.Location = new System.Drawing.Point(5, 7);
            this.lblPecaNome.Name = "lblPecaNome";
            this.lblPecaNome.Size = new System.Drawing.Size(53, 18);
            this.lblPecaNome.TabIndex = 37;
            this.lblPecaNome.Text = "Nome:";
            // 
            // txtPecaMarca
            // 
            this.txtPecaMarca.Location = new System.Drawing.Point(356, 36);
            this.txtPecaMarca.Name = "txtPecaMarca";
            this.txtPecaMarca.Size = new System.Drawing.Size(195, 20);
            this.txtPecaMarca.TabIndex = 4;
            // 
            // lblPecaMarca
            // 
            this.lblPecaMarca.AutoSize = true;
            this.lblPecaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecaMarca.Location = new System.Drawing.Point(302, 36);
            this.lblPecaMarca.Name = "lblPecaMarca";
            this.lblPecaMarca.Size = new System.Drawing.Size(54, 18);
            this.lblPecaMarca.TabIndex = 49;
            this.lblPecaMarca.Text = "Marca:";
            // 
            // btnPecaLimpar
            // 
            this.btnPecaLimpar.Location = new System.Drawing.Point(178, 64);
            this.btnPecaLimpar.Name = "btnPecaLimpar";
            this.btnPecaLimpar.Size = new System.Drawing.Size(79, 40);
            this.btnPecaLimpar.TabIndex = 50;
            this.btnPecaLimpar.Text = "Limpar";
            this.btnPecaLimpar.UseVisualStyleBackColor = true;
            this.btnPecaLimpar.Click += new System.EventHandler(this.btnPecaLimpar_Click);
            // 
            // frmPecaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 354);
            this.Controls.Add(this.btnPecaLimpar);
            this.Controls.Add(this.txtPecaMarca);
            this.Controls.Add(this.lblPecaMarca);
            this.Controls.Add(this.grbPecaPesquisa);
            this.Controls.Add(this.btnPecaExcluir);
            this.Controls.Add(this.btnPecaSalvar);
            this.Controls.Add(this.txtPecaValor);
            this.Controls.Add(this.lblPecaValor);
            this.Controls.Add(this.cboPecaModelo);
            this.Controls.Add(this.lblPecaModelo);
            this.Controls.Add(this.txtPecaQtd);
            this.Controls.Add(this.lblPecaQtd);
            this.Controls.Add(this.txtPecaNome);
            this.Controls.Add(this.lblPecaNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPecaCadastro";
            this.Text = "Peças";
            this.Load += new System.EventHandler(this.frmPecaCadastro_Load);
            this.grbPecaPesquisa.ResumeLayout(false);
            this.grbPecaPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvPecaPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPecaPesquisa;
        private System.Windows.Forms.Button btnPecaRelatorio;
        private System.Windows.Forms.DataGridView grvPecaPesquisa;
        private System.Windows.Forms.Button btnPecaExcluir;
        private System.Windows.Forms.Button btnPecaSalvar;
        private System.Windows.Forms.TextBox txtPecaValor;
        private System.Windows.Forms.Label lblPecaValor;
        private System.Windows.Forms.ComboBox cboPecaModelo;
        private System.Windows.Forms.Label lblPecaModelo;
        private System.Windows.Forms.TextBox txtPecaQtd;
        private System.Windows.Forms.Label lblPecaQtd;
        private System.Windows.Forms.TextBox txtPecaNome;
        private System.Windows.Forms.Label lblPecaNome;
        private System.Windows.Forms.TextBox txtPecaMarca;
        private System.Windows.Forms.Label lblPecaMarca;
        private System.Windows.Forms.Button btnPecaLimpar;
        private System.Windows.Forms.ComboBox cboPecaFiltro;
        private System.Windows.Forms.Button btnPecaBusca;
        private System.Windows.Forms.TextBox txtPecaBusca;
    }
}