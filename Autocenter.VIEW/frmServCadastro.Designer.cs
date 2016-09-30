namespace Autocenter.VIEW
{
    partial class frmServCadastro
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
            this.txtServDescricao = new System.Windows.Forms.TextBox();
            this.lblServDescricao = new System.Windows.Forms.Label();
            this.grbServPesquisa = new System.Windows.Forms.GroupBox();
            this.btnServRelatorio = new System.Windows.Forms.Button();
            this.btnServBusca = new System.Windows.Forms.Button();
            this.txtServBusca = new System.Windows.Forms.TextBox();
            this.grvServPesquisa = new System.Windows.Forms.DataGridView();
            this.btnServExcluir = new System.Windows.Forms.Button();
            this.btnServSalvar = new System.Windows.Forms.Button();
            this.txtServValor = new System.Windows.Forms.TextBox();
            this.lblServValor = new System.Windows.Forms.Label();
            this.txtServNome = new System.Windows.Forms.TextBox();
            this.lblServNome = new System.Windows.Forms.Label();
            this.btnServLimpar = new System.Windows.Forms.Button();
            this.grbServPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvServPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServDescricao
            // 
            this.txtServDescricao.Location = new System.Drawing.Point(84, 66);
            this.txtServDescricao.Multiline = true;
            this.txtServDescricao.Name = "txtServDescricao";
            this.txtServDescricao.Size = new System.Drawing.Size(469, 50);
            this.txtServDescricao.TabIndex = 2;
            // 
            // lblServDescricao
            // 
            this.lblServDescricao.AutoSize = true;
            this.lblServDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServDescricao.Location = new System.Drawing.Point(7, 66);
            this.lblServDescricao.Name = "lblServDescricao";
            this.lblServDescricao.Size = new System.Drawing.Size(80, 18);
            this.lblServDescricao.TabIndex = 51;
            this.lblServDescricao.Text = "Descrição:";
            // 
            // grbServPesquisa
            // 
            this.grbServPesquisa.Controls.Add(this.btnServRelatorio);
            this.grbServPesquisa.Controls.Add(this.btnServBusca);
            this.grbServPesquisa.Controls.Add(this.txtServBusca);
            this.grbServPesquisa.Controls.Add(this.grvServPesquisa);
            this.grbServPesquisa.Location = new System.Drawing.Point(7, 166);
            this.grbServPesquisa.Name = "grbServPesquisa";
            this.grbServPesquisa.Size = new System.Drawing.Size(546, 235);
            this.grbServPesquisa.TabIndex = 5;
            this.grbServPesquisa.TabStop = false;
            this.grbServPesquisa.Text = "Pesquisa";
            // 
            // btnServRelatorio
            // 
            this.btnServRelatorio.Location = new System.Drawing.Point(434, 16);
            this.btnServRelatorio.Name = "btnServRelatorio";
            this.btnServRelatorio.Size = new System.Drawing.Size(106, 23);
            this.btnServRelatorio.TabIndex = 2;
            this.btnServRelatorio.Text = "Emitir Relatorio";
            this.btnServRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnServBusca
            // 
            this.btnServBusca.Location = new System.Drawing.Point(177, 17);
            this.btnServBusca.Name = "btnServBusca";
            this.btnServBusca.Size = new System.Drawing.Size(75, 23);
            this.btnServBusca.TabIndex = 1;
            this.btnServBusca.Text = "Busca";
            this.btnServBusca.UseVisualStyleBackColor = true;
            // 
            // txtServBusca
            // 
            this.txtServBusca.Location = new System.Drawing.Point(7, 19);
            this.txtServBusca.Name = "txtServBusca";
            this.txtServBusca.Size = new System.Drawing.Size(164, 20);
            this.txtServBusca.TabIndex = 1;
            // 
            // grvServPesquisa
            // 
            this.grvServPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvServPesquisa.Location = new System.Drawing.Point(7, 49);
            this.grvServPesquisa.Name = "grvServPesquisa";
            this.grvServPesquisa.ReadOnly = true;
            this.grvServPesquisa.Size = new System.Drawing.Size(533, 175);
            this.grvServPesquisa.TabIndex = 0;
            this.grvServPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvServPesquisa_CellDoubleClick);
            // 
            // btnServExcluir
            // 
            this.btnServExcluir.Location = new System.Drawing.Point(89, 122);
            this.btnServExcluir.Name = "btnServExcluir";
            this.btnServExcluir.Size = new System.Drawing.Size(76, 38);
            this.btnServExcluir.TabIndex = 3;
            this.btnServExcluir.Text = "Excluir";
            this.btnServExcluir.UseVisualStyleBackColor = true;
            this.btnServExcluir.Click += new System.EventHandler(this.btnServExcluir_Click);
            // 
            // btnServSalvar
            // 
            this.btnServSalvar.Location = new System.Drawing.Point(7, 122);
            this.btnServSalvar.Name = "btnServSalvar";
            this.btnServSalvar.Size = new System.Drawing.Size(76, 38);
            this.btnServSalvar.TabIndex = 4;
            this.btnServSalvar.Text = "Salvar";
            this.btnServSalvar.UseVisualStyleBackColor = true;
            this.btnServSalvar.Click += new System.EventHandler(this.btnServSalvar_Click);
            // 
            // txtServValor
            // 
            this.txtServValor.Location = new System.Drawing.Point(59, 36);
            this.txtServValor.Name = "txtServValor";
            this.txtServValor.Size = new System.Drawing.Size(64, 20);
            this.txtServValor.TabIndex = 1;
            // 
            // lblServValor
            // 
            this.lblServValor.AutoSize = true;
            this.lblServValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServValor.Location = new System.Drawing.Point(7, 35);
            this.lblServValor.Name = "lblServValor";
            this.lblServValor.Size = new System.Drawing.Size(46, 18);
            this.lblServValor.TabIndex = 45;
            this.lblServValor.Text = "Valor:";
            // 
            // txtServNome
            // 
            this.txtServNome.Location = new System.Drawing.Point(66, 6);
            this.txtServNome.Name = "txtServNome";
            this.txtServNome.Size = new System.Drawing.Size(487, 20);
            this.txtServNome.TabIndex = 0;
            // 
            // lblServNome
            // 
            this.lblServNome.AutoSize = true;
            this.lblServNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServNome.Location = new System.Drawing.Point(7, 6);
            this.lblServNome.Name = "lblServNome";
            this.lblServNome.Size = new System.Drawing.Size(53, 18);
            this.lblServNome.TabIndex = 5;
            this.lblServNome.Text = "Nome:";
            // 
            // btnServLimpar
            // 
            this.btnServLimpar.Location = new System.Drawing.Point(171, 122);
            this.btnServLimpar.Name = "btnServLimpar";
            this.btnServLimpar.Size = new System.Drawing.Size(76, 38);
            this.btnServLimpar.TabIndex = 52;
            this.btnServLimpar.Text = "Limpar";
            this.btnServLimpar.UseVisualStyleBackColor = true;
            this.btnServLimpar.Click += new System.EventHandler(this.btnServLimpar_Click);
            // 
            // frmServCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 407);
            this.Controls.Add(this.btnServLimpar);
            this.Controls.Add(this.txtServDescricao);
            this.Controls.Add(this.lblServDescricao);
            this.Controls.Add(this.grbServPesquisa);
            this.Controls.Add(this.btnServExcluir);
            this.Controls.Add(this.btnServSalvar);
            this.Controls.Add(this.txtServValor);
            this.Controls.Add(this.lblServValor);
            this.Controls.Add(this.txtServNome);
            this.Controls.Add(this.lblServNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServCadastro";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmServCadastro_Load);
            this.grbServPesquisa.ResumeLayout(false);
            this.grbServPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvServPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServDescricao;
        private System.Windows.Forms.Label lblServDescricao;
        private System.Windows.Forms.GroupBox grbServPesquisa;
        private System.Windows.Forms.Button btnServRelatorio;
        private System.Windows.Forms.Button btnServBusca;
        private System.Windows.Forms.TextBox txtServBusca;
        private System.Windows.Forms.DataGridView grvServPesquisa;
        private System.Windows.Forms.Button btnServExcluir;
        private System.Windows.Forms.Button btnServSalvar;
        private System.Windows.Forms.TextBox txtServValor;
        private System.Windows.Forms.Label lblServValor;
        private System.Windows.Forms.TextBox txtServNome;
        private System.Windows.Forms.Label lblServNome;
        private System.Windows.Forms.Button btnServLimpar;
    }
}