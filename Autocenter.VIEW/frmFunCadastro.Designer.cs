namespace Autocenter.VIEW
{
    partial class frmFunCadastro
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
            this.txtFuncFuncao = new System.Windows.Forms.TextBox();
            this.lblFuncFuncao = new System.Windows.Forms.Label();
            this.lblFuncCPF = new System.Windows.Forms.Label();
            this.btnFuncExcluir = new System.Windows.Forms.Button();
            this.btnFuncAlterar = new System.Windows.Forms.Button();
            this.btnFuncSalvar = new System.Windows.Forms.Button();
            this.grbFuncPesquisa = new System.Windows.Forms.GroupBox();
            this.btnFuncRelatorio = new System.Windows.Forms.Button();
            this.btnFuncBusca = new System.Windows.Forms.Button();
            this.txtFuncBusca = new System.Windows.Forms.TextBox();
            this.grvFuncPesquisa = new System.Windows.Forms.DataGridView();
            this.txtFunNome = new System.Windows.Forms.TextBox();
            this.lblFuncNome = new System.Windows.Forms.Label();
            this.txtFuncCPF = new System.Windows.Forms.MaskedTextBox();
            this.grbFuncPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvFuncPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFuncFuncao
            // 
            this.txtFuncFuncao.Location = new System.Drawing.Point(69, 36);
            this.txtFuncFuncao.Name = "txtFuncFuncao";
            this.txtFuncFuncao.Size = new System.Drawing.Size(106, 20);
            this.txtFuncFuncao.TabIndex = 42;
            // 
            // lblFuncFuncao
            // 
            this.lblFuncFuncao.AutoSize = true;
            this.lblFuncFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncFuncao.Location = new System.Drawing.Point(6, 35);
            this.lblFuncFuncao.Name = "lblFuncFuncao";
            this.lblFuncFuncao.Size = new System.Drawing.Size(62, 18);
            this.lblFuncFuncao.TabIndex = 41;
            this.lblFuncFuncao.Text = "Função:";
            // 
            // lblFuncCPF
            // 
            this.lblFuncCPF.AutoSize = true;
            this.lblFuncCPF.Enabled = false;
            this.lblFuncCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncCPF.Location = new System.Drawing.Point(183, 36);
            this.lblFuncCPF.Name = "lblFuncCPF";
            this.lblFuncCPF.Size = new System.Drawing.Size(42, 18);
            this.lblFuncCPF.TabIndex = 39;
            this.lblFuncCPF.Text = "CPF:";
            this.lblFuncCPF.Visible = false;
            // 
            // btnFuncExcluir
            // 
            this.btnFuncExcluir.Location = new System.Drawing.Point(474, 32);
            this.btnFuncExcluir.Name = "btnFuncExcluir";
            this.btnFuncExcluir.Size = new System.Drawing.Size(79, 40);
            this.btnFuncExcluir.TabIndex = 38;
            this.btnFuncExcluir.Text = "Excluir";
            this.btnFuncExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFuncAlterar
            // 
            this.btnFuncAlterar.Location = new System.Drawing.Point(399, 32);
            this.btnFuncAlterar.Name = "btnFuncAlterar";
            this.btnFuncAlterar.Size = new System.Drawing.Size(79, 40);
            this.btnFuncAlterar.TabIndex = 37;
            this.btnFuncAlterar.Text = "Alterar";
            this.btnFuncAlterar.UseVisualStyleBackColor = true;
            // 
            // btnFuncSalvar
            // 
            this.btnFuncSalvar.Location = new System.Drawing.Point(318, 32);
            this.btnFuncSalvar.Name = "btnFuncSalvar";
            this.btnFuncSalvar.Size = new System.Drawing.Size(79, 40);
            this.btnFuncSalvar.TabIndex = 36;
            this.btnFuncSalvar.Text = "Salvar";
            this.btnFuncSalvar.UseVisualStyleBackColor = true;
            this.btnFuncSalvar.Click += new System.EventHandler(this.btnFuncSalvar_Click);
            // 
            // grbFuncPesquisa
            // 
            this.grbFuncPesquisa.Controls.Add(this.btnFuncRelatorio);
            this.grbFuncPesquisa.Controls.Add(this.btnFuncBusca);
            this.grbFuncPesquisa.Controls.Add(this.txtFuncBusca);
            this.grbFuncPesquisa.Controls.Add(this.grvFuncPesquisa);
            this.grbFuncPesquisa.Location = new System.Drawing.Point(9, 78);
            this.grbFuncPesquisa.Name = "grbFuncPesquisa";
            this.grbFuncPesquisa.Size = new System.Drawing.Size(546, 233);
            this.grbFuncPesquisa.TabIndex = 35;
            this.grbFuncPesquisa.TabStop = false;
            this.grbFuncPesquisa.Text = "Pesquisa";
            // 
            // btnFuncRelatorio
            // 
            this.btnFuncRelatorio.Location = new System.Drawing.Point(434, 16);
            this.btnFuncRelatorio.Name = "btnFuncRelatorio";
            this.btnFuncRelatorio.Size = new System.Drawing.Size(106, 23);
            this.btnFuncRelatorio.TabIndex = 22;
            this.btnFuncRelatorio.Text = "Emitir Relatorio";
            this.btnFuncRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnFuncBusca
            // 
            this.btnFuncBusca.Location = new System.Drawing.Point(177, 17);
            this.btnFuncBusca.Name = "btnFuncBusca";
            this.btnFuncBusca.Size = new System.Drawing.Size(75, 23);
            this.btnFuncBusca.TabIndex = 21;
            this.btnFuncBusca.Text = "Busca";
            this.btnFuncBusca.UseVisualStyleBackColor = true;
            // 
            // txtFuncBusca
            // 
            this.txtFuncBusca.Location = new System.Drawing.Point(7, 19);
            this.txtFuncBusca.Name = "txtFuncBusca";
            this.txtFuncBusca.Size = new System.Drawing.Size(164, 20);
            this.txtFuncBusca.TabIndex = 6;
            // 
            // grvFuncPesquisa
            // 
            this.grvFuncPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvFuncPesquisa.Location = new System.Drawing.Point(7, 49);
            this.grvFuncPesquisa.Name = "grvFuncPesquisa";
            this.grvFuncPesquisa.Size = new System.Drawing.Size(533, 175);
            this.grvFuncPesquisa.TabIndex = 0;
            // 
            // txtFunNome
            // 
            this.txtFunNome.Location = new System.Drawing.Point(56, 6);
            this.txtFunNome.Name = "txtFunNome";
            this.txtFunNome.Size = new System.Drawing.Size(497, 20);
            this.txtFunNome.TabIndex = 34;
            // 
            // lblFuncNome
            // 
            this.lblFuncNome.AutoSize = true;
            this.lblFuncNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncNome.Location = new System.Drawing.Point(6, 6);
            this.lblFuncNome.Name = "lblFuncNome";
            this.lblFuncNome.Size = new System.Drawing.Size(53, 18);
            this.lblFuncNome.TabIndex = 33;
            this.lblFuncNome.Text = "Nome:";
            // 
            // txtFuncCPF
            // 
            this.txtFuncCPF.Enabled = false;
            this.txtFuncCPF.Location = new System.Drawing.Point(224, 36);
            this.txtFuncCPF.Mask = "999.999.999-99";
            this.txtFuncCPF.Name = "txtFuncCPF";
            this.txtFuncCPF.Size = new System.Drawing.Size(85, 20);
            this.txtFuncCPF.TabIndex = 43;
            this.txtFuncCPF.Visible = false;
            // 
            // frmFunCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 318);
            this.Controls.Add(this.txtFuncCPF);
            this.Controls.Add(this.txtFuncFuncao);
            this.Controls.Add(this.lblFuncFuncao);
            this.Controls.Add(this.lblFuncCPF);
            this.Controls.Add(this.btnFuncExcluir);
            this.Controls.Add(this.btnFuncAlterar);
            this.Controls.Add(this.btnFuncSalvar);
            this.Controls.Add(this.grbFuncPesquisa);
            this.Controls.Add(this.txtFunNome);
            this.Controls.Add(this.lblFuncNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFunCadastro";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frmFunCadastro_Load);
            this.grbFuncPesquisa.ResumeLayout(false);
            this.grbFuncPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvFuncPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFuncFuncao;
        private System.Windows.Forms.Label lblFuncFuncao;
        private System.Windows.Forms.Label lblFuncCPF;
        private System.Windows.Forms.Button btnFuncExcluir;
        private System.Windows.Forms.Button btnFuncAlterar;
        private System.Windows.Forms.Button btnFuncSalvar;
        private System.Windows.Forms.GroupBox grbFuncPesquisa;
        private System.Windows.Forms.Button btnFuncRelatorio;
        private System.Windows.Forms.Button btnFuncBusca;
        private System.Windows.Forms.TextBox txtFuncBusca;
        private System.Windows.Forms.DataGridView grvFuncPesquisa;
        private System.Windows.Forms.TextBox txtFunNome;
        private System.Windows.Forms.Label lblFuncNome;
        private System.Windows.Forms.MaskedTextBox txtFuncCPF;
    }
}