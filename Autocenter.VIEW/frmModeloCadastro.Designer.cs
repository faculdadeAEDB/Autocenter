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
            this.btnModeloAlterar = new System.Windows.Forms.Button();
            this.btnModeloSalvar = new System.Windows.Forms.Button();
            this.grbModeloPesquisa = new System.Windows.Forms.GroupBox();
            this.btnModeloRelatorio = new System.Windows.Forms.Button();
            this.btnModeloBusca = new System.Windows.Forms.Button();
            this.txtModeloBusca = new System.Windows.Forms.TextBox();
            this.grvModeloPesquisa = new System.Windows.Forms.DataGridView();
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
            this.txtModeloAno.TabIndex = 42;
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
            this.txtModeloMarca.TabIndex = 36;
            // 
            // btnModeloExcluir
            // 
            this.btnModeloExcluir.Location = new System.Drawing.Point(170, 34);
            this.btnModeloExcluir.Name = "btnModeloExcluir";
            this.btnModeloExcluir.Size = new System.Drawing.Size(79, 40);
            this.btnModeloExcluir.TabIndex = 40;
            this.btnModeloExcluir.Text = "Excluir";
            this.btnModeloExcluir.UseVisualStyleBackColor = true;
            // 
            // btnModeloAlterar
            // 
            this.btnModeloAlterar.Location = new System.Drawing.Point(89, 34);
            this.btnModeloAlterar.Name = "btnModeloAlterar";
            this.btnModeloAlterar.Size = new System.Drawing.Size(79, 40);
            this.btnModeloAlterar.TabIndex = 39;
            this.btnModeloAlterar.Text = "Alterar";
            this.btnModeloAlterar.UseVisualStyleBackColor = true;
            // 
            // btnModeloSalvar
            // 
            this.btnModeloSalvar.Location = new System.Drawing.Point(8, 34);
            this.btnModeloSalvar.Name = "btnModeloSalvar";
            this.btnModeloSalvar.Size = new System.Drawing.Size(79, 40);
            this.btnModeloSalvar.TabIndex = 38;
            this.btnModeloSalvar.Text = "Salvar";
            this.btnModeloSalvar.UseVisualStyleBackColor = true;
            // 
            // grbModeloPesquisa
            // 
            this.grbModeloPesquisa.Controls.Add(this.btnModeloRelatorio);
            this.grbModeloPesquisa.Controls.Add(this.btnModeloBusca);
            this.grbModeloPesquisa.Controls.Add(this.txtModeloBusca);
            this.grbModeloPesquisa.Controls.Add(this.grvModeloPesquisa);
            this.grbModeloPesquisa.Location = new System.Drawing.Point(5, 80);
            this.grbModeloPesquisa.Name = "grbModeloPesquisa";
            this.grbModeloPesquisa.Size = new System.Drawing.Size(546, 236);
            this.grbModeloPesquisa.TabIndex = 37;
            this.grbModeloPesquisa.TabStop = false;
            this.grbModeloPesquisa.Text = "Pesquisa";
            // 
            // btnModeloRelatorio
            // 
            this.btnModeloRelatorio.Location = new System.Drawing.Point(434, 16);
            this.btnModeloRelatorio.Name = "btnModeloRelatorio";
            this.btnModeloRelatorio.Size = new System.Drawing.Size(106, 23);
            this.btnModeloRelatorio.TabIndex = 22;
            this.btnModeloRelatorio.Text = "Emitir Relatorio";
            this.btnModeloRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnModeloBusca
            // 
            this.btnModeloBusca.Location = new System.Drawing.Point(177, 17);
            this.btnModeloBusca.Name = "btnModeloBusca";
            this.btnModeloBusca.Size = new System.Drawing.Size(75, 23);
            this.btnModeloBusca.TabIndex = 21;
            this.btnModeloBusca.Text = "Busca";
            this.btnModeloBusca.UseVisualStyleBackColor = true;
            // 
            // txtModeloBusca
            // 
            this.txtModeloBusca.Location = new System.Drawing.Point(7, 19);
            this.txtModeloBusca.Name = "txtModeloBusca";
            this.txtModeloBusca.Size = new System.Drawing.Size(164, 20);
            this.txtModeloBusca.TabIndex = 6;
            // 
            // grvModeloPesquisa
            // 
            this.grvModeloPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvModeloPesquisa.Location = new System.Drawing.Point(7, 49);
            this.grvModeloPesquisa.Name = "grvModeloPesquisa";
            this.grvModeloPesquisa.Size = new System.Drawing.Size(533, 175);
            this.grvModeloPesquisa.TabIndex = 0;
            // 
            // frmModeloCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 325);
            this.Controls.Add(this.lblModeloAno);
            this.Controls.Add(this.txtModeloAno);
            this.Controls.Add(this.lblModeloMarca);
            this.Controls.Add(this.txtModeloMarca);
            this.Controls.Add(this.btnModeloExcluir);
            this.Controls.Add(this.btnModeloAlterar);
            this.Controls.Add(this.btnModeloSalvar);
            this.Controls.Add(this.grbModeloPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModeloCadastro";
            this.Text = "Modelos";
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
        private System.Windows.Forms.Button btnModeloAlterar;
        private System.Windows.Forms.Button btnModeloSalvar;
        private System.Windows.Forms.GroupBox grbModeloPesquisa;
        private System.Windows.Forms.Button btnModeloRelatorio;
        private System.Windows.Forms.Button btnModeloBusca;
        private System.Windows.Forms.TextBox txtModeloBusca;
        private System.Windows.Forms.DataGridView grvModeloPesquisa;
    }
}