﻿namespace Autocenter.VIEW
{
    partial class frmCarroCadastro
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
            this.txtCarroPlaca = new System.Windows.Forms.MaskedTextBox();
            this.grbCarroPesquisa = new System.Windows.Forms.GroupBox();
            this.btnCarroRelatorio = new System.Windows.Forms.Button();
            this.btnCarroBusca = new System.Windows.Forms.Button();
            this.txtCarroBusca = new System.Windows.Forms.TextBox();
            this.grvCarroPesquisa = new System.Windows.Forms.DataGridView();
            this.cboCarroModelo = new System.Windows.Forms.ComboBox();
            this.btnCarroExcluir = new System.Windows.Forms.Button();
            this.btnCarroAlterar = new System.Windows.Forms.Button();
            this.btnCarroSalvar = new System.Windows.Forms.Button();
            this.lblCarroPlaca = new System.Windows.Forms.Label();
            this.txtCarroCor = new System.Windows.Forms.TextBox();
            this.txtCarroCliente = new System.Windows.Forms.TextBox();
            this.lblCarroCor = new System.Windows.Forms.Label();
            this.lblCarroModelo = new System.Windows.Forms.Label();
            this.lblCarroCliente = new System.Windows.Forms.Label();
            this.grbCarroPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCarroPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarroPlaca
            // 
            this.txtCarroPlaca.Location = new System.Drawing.Point(261, 41);
            this.txtCarroPlaca.Mask = "9999-9999";
            this.txtCarroPlaca.Name = "txtCarroPlaca";
            this.txtCarroPlaca.Size = new System.Drawing.Size(60, 20);
            this.txtCarroPlaca.TabIndex = 37;
            // 
            // grbCarroPesquisa
            // 
            this.grbCarroPesquisa.Controls.Add(this.btnCarroRelatorio);
            this.grbCarroPesquisa.Controls.Add(this.btnCarroBusca);
            this.grbCarroPesquisa.Controls.Add(this.txtCarroBusca);
            this.grbCarroPesquisa.Controls.Add(this.grvCarroPesquisa);
            this.grbCarroPesquisa.Location = new System.Drawing.Point(5, 110);
            this.grbCarroPesquisa.Name = "grbCarroPesquisa";
            this.grbCarroPesquisa.Size = new System.Drawing.Size(550, 236);
            this.grbCarroPesquisa.TabIndex = 36;
            this.grbCarroPesquisa.TabStop = false;
            this.grbCarroPesquisa.Text = "Pesquisa";
            // 
            // btnCarroRelatorio
            // 
            this.btnCarroRelatorio.Location = new System.Drawing.Point(434, 16);
            this.btnCarroRelatorio.Name = "btnCarroRelatorio";
            this.btnCarroRelatorio.Size = new System.Drawing.Size(106, 23);
            this.btnCarroRelatorio.TabIndex = 22;
            this.btnCarroRelatorio.Text = "Emitir Relatorio";
            this.btnCarroRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnCarroBusca
            // 
            this.btnCarroBusca.Location = new System.Drawing.Point(177, 17);
            this.btnCarroBusca.Name = "btnCarroBusca";
            this.btnCarroBusca.Size = new System.Drawing.Size(75, 23);
            this.btnCarroBusca.TabIndex = 21;
            this.btnCarroBusca.Text = "Busca";
            this.btnCarroBusca.UseVisualStyleBackColor = true;
            // 
            // txtCarroBusca
            // 
            this.txtCarroBusca.Location = new System.Drawing.Point(7, 19);
            this.txtCarroBusca.Name = "txtCarroBusca";
            this.txtCarroBusca.Size = new System.Drawing.Size(164, 20);
            this.txtCarroBusca.TabIndex = 6;
            // 
            // grvCarroPesquisa
            // 
            this.grvCarroPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCarroPesquisa.Location = new System.Drawing.Point(7, 49);
            this.grvCarroPesquisa.Name = "grvCarroPesquisa";
            this.grvCarroPesquisa.Size = new System.Drawing.Size(533, 175);
            this.grvCarroPesquisa.TabIndex = 0;
            // 
            // cboCarroModelo
            // 
            this.cboCarroModelo.FormattingEnabled = true;
            this.cboCarroModelo.Location = new System.Drawing.Point(76, 42);
            this.cboCarroModelo.Name = "cboCarroModelo";
            this.cboCarroModelo.Size = new System.Drawing.Size(121, 21);
            this.cboCarroModelo.TabIndex = 35;
            // 
            // btnCarroExcluir
            // 
            this.btnCarroExcluir.Location = new System.Drawing.Point(174, 69);
            this.btnCarroExcluir.Name = "btnCarroExcluir";
            this.btnCarroExcluir.Size = new System.Drawing.Size(81, 35);
            this.btnCarroExcluir.TabIndex = 34;
            this.btnCarroExcluir.Text = "Excluir";
            this.btnCarroExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCarroAlterar
            // 
            this.btnCarroAlterar.Location = new System.Drawing.Point(93, 69);
            this.btnCarroAlterar.Name = "btnCarroAlterar";
            this.btnCarroAlterar.Size = new System.Drawing.Size(81, 35);
            this.btnCarroAlterar.TabIndex = 33;
            this.btnCarroAlterar.Text = "Alterar";
            this.btnCarroAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCarroSalvar
            // 
            this.btnCarroSalvar.Location = new System.Drawing.Point(12, 69);
            this.btnCarroSalvar.Name = "btnCarroSalvar";
            this.btnCarroSalvar.Size = new System.Drawing.Size(81, 35);
            this.btnCarroSalvar.TabIndex = 32;
            this.btnCarroSalvar.Text = "Salvar";
            this.btnCarroSalvar.UseVisualStyleBackColor = true;
            // 
            // lblCarroPlaca
            // 
            this.lblCarroPlaca.AutoSize = true;
            this.lblCarroPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarroPlaca.Location = new System.Drawing.Point(203, 41);
            this.lblCarroPlaca.Name = "lblCarroPlaca";
            this.lblCarroPlaca.Size = new System.Drawing.Size(52, 20);
            this.lblCarroPlaca.TabIndex = 31;
            this.lblCarroPlaca.Text = "Placa:";
            // 
            // txtCarroCor
            // 
            this.txtCarroCor.Location = new System.Drawing.Point(371, 42);
            this.txtCarroCor.Name = "txtCarroCor";
            this.txtCarroCor.Size = new System.Drawing.Size(88, 20);
            this.txtCarroCor.TabIndex = 30;
            // 
            // txtCarroCliente
            // 
            this.txtCarroCliente.Location = new System.Drawing.Point(76, 12);
            this.txtCarroCliente.Name = "txtCarroCliente";
            this.txtCarroCliente.Size = new System.Drawing.Size(456, 20);
            this.txtCarroCliente.TabIndex = 29;
            // 
            // lblCarroCor
            // 
            this.lblCarroCor.AutoSize = true;
            this.lblCarroCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarroCor.Location = new System.Drawing.Point(327, 41);
            this.lblCarroCor.Name = "lblCarroCor";
            this.lblCarroCor.Size = new System.Drawing.Size(38, 20);
            this.lblCarroCor.TabIndex = 28;
            this.lblCarroCor.Text = "Cor:";
            // 
            // lblCarroModelo
            // 
            this.lblCarroModelo.AutoSize = true;
            this.lblCarroModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarroModelo.Location = new System.Drawing.Point(8, 42);
            this.lblCarroModelo.Name = "lblCarroModelo";
            this.lblCarroModelo.Size = new System.Drawing.Size(65, 20);
            this.lblCarroModelo.TabIndex = 27;
            this.lblCarroModelo.Text = "Modelo:";
            // 
            // lblCarroCliente
            // 
            this.lblCarroCliente.AutoSize = true;
            this.lblCarroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarroCliente.Location = new System.Drawing.Point(8, 12);
            this.lblCarroCliente.Name = "lblCarroCliente";
            this.lblCarroCliente.Size = new System.Drawing.Size(62, 20);
            this.lblCarroCliente.TabIndex = 26;
            this.lblCarroCliente.Text = "Cliente:";
            // 
            // frmCarroCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 352);
            this.Controls.Add(this.txtCarroPlaca);
            this.Controls.Add(this.grbCarroPesquisa);
            this.Controls.Add(this.cboCarroModelo);
            this.Controls.Add(this.btnCarroExcluir);
            this.Controls.Add(this.btnCarroAlterar);
            this.Controls.Add(this.btnCarroSalvar);
            this.Controls.Add(this.lblCarroPlaca);
            this.Controls.Add(this.txtCarroCor);
            this.Controls.Add(this.txtCarroCliente);
            this.Controls.Add(this.lblCarroCor);
            this.Controls.Add(this.lblCarroModelo);
            this.Controls.Add(this.lblCarroCliente);
            this.Name = "frmCarroCadastro";
            this.Text = "Carros";
            this.grbCarroPesquisa.ResumeLayout(false);
            this.grbCarroPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCarroPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCarroPlaca;
        private System.Windows.Forms.GroupBox grbCarroPesquisa;
        private System.Windows.Forms.Button btnCarroRelatorio;
        private System.Windows.Forms.Button btnCarroBusca;
        private System.Windows.Forms.TextBox txtCarroBusca;
        private System.Windows.Forms.DataGridView grvCarroPesquisa;
        private System.Windows.Forms.ComboBox cboCarroModelo;
        private System.Windows.Forms.Button btnCarroExcluir;
        private System.Windows.Forms.Button btnCarroAlterar;
        private System.Windows.Forms.Button btnCarroSalvar;
        private System.Windows.Forms.Label lblCarroPlaca;
        private System.Windows.Forms.TextBox txtCarroCor;
        private System.Windows.Forms.TextBox txtCarroCliente;
        private System.Windows.Forms.Label lblCarroCor;
        private System.Windows.Forms.Label lblCarroModelo;
        private System.Windows.Forms.Label lblCarroCliente;
    }
}