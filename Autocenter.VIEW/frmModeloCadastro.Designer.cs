namespace Autocenter.VIEW
{
    partial class frmModeloCadastro
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
            this.lblModeloAno = new System.Windows.Forms.Label();
            this.txtModeloAno = new System.Windows.Forms.TextBox();
            this.lblModeloMarca = new System.Windows.Forms.Label();
            this.txtModeloMarca = new System.Windows.Forms.TextBox();
            this.btnModeloExcluir = new System.Windows.Forms.Button();
            this.btnModeloSalvar = new System.Windows.Forms.Button();
            this.grbModeloPesquisa = new System.Windows.Forms.GroupBox();
            this.cboModeloFiltro = new System.Windows.Forms.ComboBox();
            this.btnModeloBusca = new System.Windows.Forms.Button();
            this.txtModeloBusca = new System.Windows.Forms.TextBox();
            this.btnModeloRelatorio = new System.Windows.Forms.Button();
            this.grvModeloPesquisa = new System.Windows.Forms.DataGridView();
            this.btnModeloLimpar = new System.Windows.Forms.Button();
            this.grbModeloPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvModeloPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModeloAno
            // 
            this.lblModeloAno.AutoSize = true;
            this.lblModeloAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloAno.Location = new System.Drawing.Point(235, 7);
            this.lblModeloAno.Name = "lblModeloAno";
            this.lblModeloAno.Size = new System.Drawing.Size(38, 18);
            this.lblModeloAno.TabIndex = 43;
            this.lblModeloAno.Text = "Ano:";
            // 
            // txtModeloAno
            // 
            this.txtModeloAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloAno.Location = new System.Drawing.Point(274, 7);
            this.txtModeloAno.Name = "txtModeloAno";
            this.txtModeloAno.Size = new System.Drawing.Size(164, 21);
            this.txtModeloAno.TabIndex = 1;
            // 
            // lblModeloMarca
            // 
            this.lblModeloMarca.AutoSize = true;
            this.lblModeloMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloMarca.Location = new System.Drawing.Point(5, 8);
            this.lblModeloMarca.Name = "lblModeloMarca";
            this.lblModeloMarca.Size = new System.Drawing.Size(54, 18);
            this.lblModeloMarca.TabIndex = 41;
            this.lblModeloMarca.Text = "Marca:";
            // 
            // txtModeloMarca
            // 
            this.txtModeloMarca.Location = new System.Drawing.Point(65, 8);
            this.txtModeloMarca.Name = "txtModeloMarca";
            this.txtModeloMarca.Size = new System.Drawing.Size(164, 20);
            this.txtModeloMarca.TabIndex = 0;
            // 
            // btnModeloExcluir
            // 
            this.btnModeloExcluir.Location = new System.Drawing.Point(97, 34);
            this.btnModeloExcluir.Name = "btnModeloExcluir";
            this.btnModeloExcluir.Size = new System.Drawing.Size(79, 40);
            this.btnModeloExcluir.TabIndex = 3;
            this.btnModeloExcluir.Text = "Excluir";
            this.btnModeloExcluir.UseVisualStyleBackColor = true;
            this.btnModeloExcluir.Click += new System.EventHandler(this.btnModeloExcluir_Click);
            // 
            // btnModeloSalvar
            // 
            this.btnModeloSalvar.Location = new System.Drawing.Point(8, 34);
            this.btnModeloSalvar.Name = "btnModeloSalvar";
            this.btnModeloSalvar.Size = new System.Drawing.Size(79, 40);
            this.btnModeloSalvar.TabIndex = 2;
            this.btnModeloSalvar.Text = "Salvar";
            this.btnModeloSalvar.UseVisualStyleBackColor = true;
            this.btnModeloSalvar.Click += new System.EventHandler(this.btnModeloSalvar_Click);
            // 
            // grbModeloPesquisa
            // 
            this.grbModeloPesquisa.Controls.Add(this.cboModeloFiltro);
            this.grbModeloPesquisa.Controls.Add(this.btnModeloBusca);
            this.grbModeloPesquisa.Controls.Add(this.txtModeloBusca);
            this.grbModeloPesquisa.Controls.Add(this.btnModeloRelatorio);
            this.grbModeloPesquisa.Controls.Add(this.grvModeloPesquisa);
            this.grbModeloPesquisa.Location = new System.Drawing.Point(5, 80);
            this.grbModeloPesquisa.Name = "grbModeloPesquisa";
            this.grbModeloPesquisa.Size = new System.Drawing.Size(546, 236);
            this.grbModeloPesquisa.TabIndex = 37;
            this.grbModeloPesquisa.TabStop = false;
            this.grbModeloPesquisa.Text = "Pesquisa";
            // 
            // cboModeloFiltro
            // 
            this.cboModeloFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModeloFiltro.FormattingEnabled = true;
            this.cboModeloFiltro.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "Ano"});
            this.cboModeloFiltro.Location = new System.Drawing.Point(6, 19);
            this.cboModeloFiltro.Name = "cboModeloFiltro";
            this.cboModeloFiltro.Size = new System.Drawing.Size(134, 21);
            this.cboModeloFiltro.TabIndex = 10;
            // 
            // btnModeloBusca
            // 
            this.btnModeloBusca.Location = new System.Drawing.Point(316, 17);
            this.btnModeloBusca.Name = "btnModeloBusca";
            this.btnModeloBusca.Size = new System.Drawing.Size(75, 23);
            this.btnModeloBusca.TabIndex = 9;
            this.btnModeloBusca.Text = "Busca";
            this.btnModeloBusca.UseVisualStyleBackColor = true;
            this.btnModeloBusca.Click += new System.EventHandler(this.btnModeloBusca_Click);
            // 
            // txtModeloBusca
            // 
            this.txtModeloBusca.Location = new System.Drawing.Point(146, 19);
            this.txtModeloBusca.Name = "txtModeloBusca";
            this.txtModeloBusca.Size = new System.Drawing.Size(164, 20);
            this.txtModeloBusca.TabIndex = 8;
            // 
            // btnModeloRelatorio
            // 
            this.btnModeloRelatorio.Location = new System.Drawing.Point(434, 16);
            this.btnModeloRelatorio.Name = "btnModeloRelatorio";
            this.btnModeloRelatorio.Size = new System.Drawing.Size(106, 23);
            this.btnModeloRelatorio.TabIndex = 2;
            this.btnModeloRelatorio.Text = "Emitir Relatorio";
            this.btnModeloRelatorio.UseVisualStyleBackColor = true;
            this.btnModeloRelatorio.Click += new System.EventHandler(this.btnModeloRelatorio_Click);
            // 
            // grvModeloPesquisa
            // 
            this.grvModeloPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvModeloPesquisa.Location = new System.Drawing.Point(7, 49);
            this.grvModeloPesquisa.Name = "grvModeloPesquisa";
            this.grvModeloPesquisa.ReadOnly = true;
            this.grvModeloPesquisa.Size = new System.Drawing.Size(533, 175);
            this.grvModeloPesquisa.TabIndex = 3;
            this.grvModeloPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvModeloPesquisa_CellDoubleClick);
            // 
            // btnModeloLimpar
            // 
            this.btnModeloLimpar.Location = new System.Drawing.Point(194, 34);
            this.btnModeloLimpar.Name = "btnModeloLimpar";
            this.btnModeloLimpar.Size = new System.Drawing.Size(79, 40);
            this.btnModeloLimpar.TabIndex = 44;
            this.btnModeloLimpar.Text = "Limpar";
            this.btnModeloLimpar.UseVisualStyleBackColor = true;
            this.btnModeloLimpar.Click += new System.EventHandler(this.btnModeloLimpar_Click);
            // 
            // frmModeloCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 325);
            this.Controls.Add(this.btnModeloLimpar);
            this.Controls.Add(this.lblModeloAno);
            this.Controls.Add(this.txtModeloAno);
            this.Controls.Add(this.lblModeloMarca);
            this.Controls.Add(this.txtModeloMarca);
            this.Controls.Add(this.btnModeloExcluir);
            this.Controls.Add(this.btnModeloSalvar);
            this.Controls.Add(this.grbModeloPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModeloCadastro";
            this.Text = "Modelos";
            this.Load += new System.EventHandler(this.frmModeloCadastro_Load);
            this.grbModeloPesquisa.ResumeLayout(false);
            this.grbModeloPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvModeloPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModeloAno;
        private System.Windows.Forms.TextBox txtModeloAno;
        private System.Windows.Forms.Label lblModeloMarca;
        private System.Windows.Forms.TextBox txtModeloMarca;
        private System.Windows.Forms.Button btnModeloExcluir;
        private System.Windows.Forms.Button btnModeloSalvar;
        private System.Windows.Forms.GroupBox grbModeloPesquisa;
        private System.Windows.Forms.Button btnModeloRelatorio;
        private System.Windows.Forms.DataGridView grvModeloPesquisa;
        private System.Windows.Forms.Button btnModeloLimpar;
        private System.Windows.Forms.ComboBox cboModeloFiltro;
        private System.Windows.Forms.Button btnModeloBusca;
        private System.Windows.Forms.TextBox txtModeloBusca;
    }
}