﻿namespace Autocenter.VIEW
{
    partial class frmCliCadastro
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
            this.btnCliAlterar = new System.Windows.Forms.Button();
            this.btnCliSalvar = new System.Windows.Forms.Button();
            this.txtCliTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCliTelefone = new System.Windows.Forms.Label();
            this.txtCliEndereco = new System.Windows.Forms.TextBox();
            this.txtCliNome = new System.Windows.Forms.TextBox();
            this.lblCliEndereco = new System.Windows.Forms.Label();
            this.lblCliCPF = new System.Windows.Forms.Label();
            this.lblCliNome = new System.Windows.Forms.Label();
            this.txtCliCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCliLimpar = new System.Windows.Forms.Button();
            this.grvCliPesquisa = new System.Windows.Forms.DataGridView();
            this.grbCliPesquisa = new System.Windows.Forms.GroupBox();
            this.cboCliFiltro = new System.Windows.Forms.ComboBox();
            this.btnCliRelatorio = new System.Windows.Forms.Button();
            this.btnCliBusca = new System.Windows.Forms.Button();
            this.txtCliBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvCliPesquisa)).BeginInit();
            this.grbCliPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCliAlterar
            // 
            this.btnCliAlterar.Location = new System.Drawing.Point(88, 86);
            this.btnCliAlterar.Name = "btnCliAlterar";
            this.btnCliAlterar.Size = new System.Drawing.Size(79, 40);
            this.btnCliAlterar.TabIndex = 5;
            this.btnCliAlterar.Text = "Alterar";
            this.btnCliAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCliSalvar
            // 
            this.btnCliSalvar.Location = new System.Drawing.Point(7, 86);
            this.btnCliSalvar.Name = "btnCliSalvar";
            this.btnCliSalvar.Size = new System.Drawing.Size(79, 40);
            this.btnCliSalvar.TabIndex = 4;
            this.btnCliSalvar.Text = "Salvar";
            this.btnCliSalvar.UseVisualStyleBackColor = true;
            this.btnCliSalvar.Click += new System.EventHandler(this.btnCliSalvar_Click);
            // 
            // txtCliTelefone
            // 
            this.txtCliTelefone.Location = new System.Drawing.Point(70, 34);
            this.txtCliTelefone.Name = "txtCliTelefone";
            this.txtCliTelefone.Size = new System.Drawing.Size(82, 20);
            this.txtCliTelefone.TabIndex = 1;
            // 
            // lblCliTelefone
            // 
            this.lblCliTelefone.AutoSize = true;
            this.lblCliTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliTelefone.Location = new System.Drawing.Point(4, 34);
            this.lblCliTelefone.Name = "lblCliTelefone";
            this.lblCliTelefone.Size = new System.Drawing.Size(69, 18);
            this.lblCliTelefone.TabIndex = 2;
            this.lblCliTelefone.Text = "Telefone:";
            // 
            // txtCliEndereco
            // 
            this.txtCliEndereco.Location = new System.Drawing.Point(80, 60);
            this.txtCliEndereco.Name = "txtCliEndereco";
            this.txtCliEndereco.Size = new System.Drawing.Size(471, 20);
            this.txtCliEndereco.TabIndex = 3;
            // 
            // txtCliNome
            // 
            this.txtCliNome.Location = new System.Drawing.Point(57, 7);
            this.txtCliNome.Name = "txtCliNome";
            this.txtCliNome.Size = new System.Drawing.Size(494, 20);
            this.txtCliNome.TabIndex = 0;
            // 
            // lblCliEndereco
            // 
            this.lblCliEndereco.AutoSize = true;
            this.lblCliEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEndereco.Location = new System.Drawing.Point(4, 59);
            this.lblCliEndereco.Name = "lblCliEndereco";
            this.lblCliEndereco.Size = new System.Drawing.Size(76, 18);
            this.lblCliEndereco.TabIndex = 6;
            this.lblCliEndereco.Text = "Endereço:";
            // 
            // lblCliCPF
            // 
            this.lblCliCPF.AutoSize = true;
            this.lblCliCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCPF.Location = new System.Drawing.Point(158, 34);
            this.lblCliCPF.Name = "lblCliCPF";
            this.lblCliCPF.Size = new System.Drawing.Size(42, 18);
            this.lblCliCPF.TabIndex = 4;
            this.lblCliCPF.Text = "CPF:";
            // 
            // lblCliNome
            // 
            this.lblCliNome.AutoSize = true;
            this.lblCliNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliNome.Location = new System.Drawing.Point(4, 4);
            this.lblCliNome.Name = "lblCliNome";
            this.lblCliNome.Size = new System.Drawing.Size(53, 18);
            this.lblCliNome.TabIndex = 0;
            this.lblCliNome.Text = "Nome:";
            // 
            // txtCliCPF
            // 
            this.txtCliCPF.Location = new System.Drawing.Point(197, 33);
            this.txtCliCPF.Mask = "999.999.999-99";
            this.txtCliCPF.Name = "txtCliCPF";
            this.txtCliCPF.Size = new System.Drawing.Size(85, 20);
            this.txtCliCPF.TabIndex = 2;
            // 
            // btnCliLimpar
            // 
            this.btnCliLimpar.Location = new System.Drawing.Point(173, 86);
            this.btnCliLimpar.Name = "btnCliLimpar";
            this.btnCliLimpar.Size = new System.Drawing.Size(79, 40);
            this.btnCliLimpar.TabIndex = 7;
            this.btnCliLimpar.Text = "Limpar";
            this.btnCliLimpar.UseVisualStyleBackColor = true;
            this.btnCliLimpar.Click += new System.EventHandler(this.btnClienteLimpar_Click);
            // 
            // grvCliPesquisa
            // 
            this.grvCliPesquisa.AllowUserToAddRows = false;
            this.grvCliPesquisa.AllowUserToDeleteRows = false;
            this.grvCliPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCliPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grvCliPesquisa.Location = new System.Drawing.Point(7, 49);
            this.grvCliPesquisa.Name = "grvCliPesquisa";
            this.grvCliPesquisa.ReadOnly = true;
            this.grvCliPesquisa.Size = new System.Drawing.Size(533, 178);
            this.grvCliPesquisa.TabIndex = 3;
            this.grvCliPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCliPesquisa_CellDoubleClick);
            // 
            // grbCliPesquisa
            // 
            this.grbCliPesquisa.Controls.Add(this.cboCliFiltro);
            this.grbCliPesquisa.Controls.Add(this.btnCliRelatorio);
            this.grbCliPesquisa.Controls.Add(this.btnCliBusca);
            this.grbCliPesquisa.Controls.Add(this.txtCliBusca);
            this.grbCliPesquisa.Controls.Add(this.grvCliPesquisa);
            this.grbCliPesquisa.Location = new System.Drawing.Point(5, 132);
            this.grbCliPesquisa.Name = "grbCliPesquisa";
            this.grbCliPesquisa.Size = new System.Drawing.Size(546, 233);
            this.grbCliPesquisa.TabIndex = 6;
            this.grbCliPesquisa.TabStop = false;
            this.grbCliPesquisa.Text = "Pesquisa";
            // 
            // cboCliFiltro
            // 
            this.cboCliFiltro.AutoCompleteCustomSource.AddRange(new string[] {
            "ID",
            "Nome",
            "CPF"});
            this.cboCliFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliFiltro.FormattingEnabled = true;
            this.cboCliFiltro.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "CPF"});
            this.cboCliFiltro.Location = new System.Drawing.Point(7, 19);
            this.cboCliFiltro.Name = "cboCliFiltro";
            this.cboCliFiltro.Size = new System.Drawing.Size(134, 21);
            this.cboCliFiltro.TabIndex = 4;
            // 
            // btnCliRelatorio
            // 
            this.btnCliRelatorio.Location = new System.Drawing.Point(434, 17);
            this.btnCliRelatorio.Name = "btnCliRelatorio";
            this.btnCliRelatorio.Size = new System.Drawing.Size(106, 23);
            this.btnCliRelatorio.TabIndex = 2;
            this.btnCliRelatorio.Text = "Emitir Relatorio";
            this.btnCliRelatorio.UseVisualStyleBackColor = true;
            this.btnCliRelatorio.Click += new System.EventHandler(this.btnCliRelatorio_Click);
            // 
            // btnCliBusca
            // 
            this.btnCliBusca.Location = new System.Drawing.Point(317, 17);
            this.btnCliBusca.Name = "btnCliBusca";
            this.btnCliBusca.Size = new System.Drawing.Size(75, 23);
            this.btnCliBusca.TabIndex = 1;
            this.btnCliBusca.Text = "Busca";
            this.btnCliBusca.UseVisualStyleBackColor = true;
            this.btnCliBusca.Click += new System.EventHandler(this.btnCliBusca_Click);
            // 
            // txtCliBusca
            // 
            this.txtCliBusca.Location = new System.Drawing.Point(147, 19);
            this.txtCliBusca.Name = "txtCliBusca";
            this.txtCliBusca.Size = new System.Drawing.Size(164, 20);
            this.txtCliBusca.TabIndex = 0;
            // 
            // frmCliCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 374);
            this.Controls.Add(this.btnCliLimpar);
            this.Controls.Add(this.txtCliCPF);
            this.Controls.Add(this.grbCliPesquisa);
            this.Controls.Add(this.btnCliAlterar);
            this.Controls.Add(this.btnCliSalvar);
            this.Controls.Add(this.txtCliTelefone);
            this.Controls.Add(this.lblCliTelefone);
            this.Controls.Add(this.txtCliEndereco);
            this.Controls.Add(this.txtCliNome);
            this.Controls.Add(this.lblCliEndereco);
            this.Controls.Add(this.lblCliCPF);
            this.Controls.Add(this.lblCliNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliCadastro";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClienteCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCliPesquisa)).EndInit();
            this.grbCliPesquisa.ResumeLayout(false);
            this.grbCliPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCliAlterar;
        private System.Windows.Forms.Button btnCliSalvar;
        private System.Windows.Forms.MaskedTextBox txtCliTelefone;
        private System.Windows.Forms.Label lblCliTelefone;
        private System.Windows.Forms.TextBox txtCliEndereco;
        private System.Windows.Forms.TextBox txtCliNome;
        private System.Windows.Forms.Label lblCliEndereco;
        private System.Windows.Forms.Label lblCliCPF;
        private System.Windows.Forms.Label lblCliNome;
        private System.Windows.Forms.MaskedTextBox txtCliCPF;
        private System.Windows.Forms.Button btnCliLimpar;
        private System.Windows.Forms.DataGridView grvCliPesquisa;
        private System.Windows.Forms.GroupBox grbCliPesquisa;
        private System.Windows.Forms.ComboBox cboCliFiltro;
        private System.Windows.Forms.Button btnCliRelatorio;
        private System.Windows.Forms.Button btnCliBusca;
        private System.Windows.Forms.TextBox txtCliBusca;
    }
}