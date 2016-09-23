namespace Autocenter.VIEW
{
    partial class frmOrdemServico
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
            this.txtOrdemCliente = new System.Windows.Forms.TextBox();
            this.lblOrdemCliente = new System.Windows.Forms.Label();
            this.txtOrdemOS = new System.Windows.Forms.TextBox();
            this.lblOrdemOS = new System.Windows.Forms.Label();
            this.grvOrdem = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdemSalvar = new System.Windows.Forms.Button();
            this.btnOrdemVenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblOrdemOrcamento = new System.Windows.Forms.Label();
            this.chkOrdemOrcamento = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrdem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrdemCliente
            // 
            this.txtOrdemCliente.Location = new System.Drawing.Point(75, 12);
            this.txtOrdemCliente.Name = "txtOrdemCliente";
            this.txtOrdemCliente.Size = new System.Drawing.Size(380, 20);
            this.txtOrdemCliente.TabIndex = 31;
            // 
            // lblOrdemCliente
            // 
            this.lblOrdemCliente.AutoSize = true;
            this.lblOrdemCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdemCliente.Location = new System.Drawing.Point(7, 12);
            this.lblOrdemCliente.Name = "lblOrdemCliente";
            this.lblOrdemCliente.Size = new System.Drawing.Size(62, 20);
            this.lblOrdemCliente.TabIndex = 30;
            this.lblOrdemCliente.Text = "Cliente:";
            // 
            // txtOrdemOS
            // 
            this.txtOrdemOS.Location = new System.Drawing.Point(496, 12);
            this.txtOrdemOS.Name = "txtOrdemOS";
            this.txtOrdemOS.Size = new System.Drawing.Size(88, 20);
            this.txtOrdemOS.TabIndex = 33;
            // 
            // lblOrdemOS
            // 
            this.lblOrdemOS.AutoSize = true;
            this.lblOrdemOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdemOS.Location = new System.Drawing.Point(463, 11);
            this.lblOrdemOS.Name = "lblOrdemOS";
            this.lblOrdemOS.Size = new System.Drawing.Size(36, 20);
            this.lblOrdemOS.TabIndex = 32;
            this.lblOrdemOS.Text = "OS:";
            // 
            // grvOrdem
            // 
            this.grvOrdem.AllowUserToOrderColumns = true;
            this.grvOrdem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrdem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Quantidade,
            this.Nome,
            this.Valor});
            this.grvOrdem.Location = new System.Drawing.Point(11, 48);
            this.grvOrdem.Name = "grvOrdem";
            this.grvOrdem.Size = new System.Drawing.Size(698, 211);
            this.grvOrdem.TabIndex = 34;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // btnOrdemSalvar
            // 
            this.btnOrdemSalvar.Location = new System.Drawing.Point(11, 265);
            this.btnOrdemSalvar.Name = "btnOrdemSalvar";
            this.btnOrdemSalvar.Size = new System.Drawing.Size(115, 37);
            this.btnOrdemSalvar.TabIndex = 35;
            this.btnOrdemSalvar.Text = "Salvar";
            this.btnOrdemSalvar.UseVisualStyleBackColor = true;
            // 
            // btnOrdemVenda
            // 
            this.btnOrdemVenda.Location = new System.Drawing.Point(590, 265);
            this.btnOrdemVenda.Name = "btnOrdemVenda";
            this.btnOrdemVenda.Size = new System.Drawing.Size(115, 37);
            this.btnOrdemVenda.TabIndex = 36;
            this.btnOrdemVenda.Text = "Finalizar Venda";
            this.btnOrdemVenda.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Valor Total:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1.Location = new System.Drawing.Point(484, 265);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 37);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "R$ 00,00";
            // 
            // lblOrdemOrcamento
            // 
            this.lblOrdemOrcamento.AutoSize = true;
            this.lblOrdemOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdemOrcamento.Location = new System.Drawing.Point(600, 11);
            this.lblOrdemOrcamento.Name = "lblOrdemOrcamento";
            this.lblOrdemOrcamento.Size = new System.Drawing.Size(92, 20);
            this.lblOrdemOrcamento.TabIndex = 39;
            this.lblOrdemOrcamento.Text = "Orçamento:";
            // 
            // chkOrdemOrcamento
            // 
            this.chkOrdemOrcamento.AutoSize = true;
            this.chkOrdemOrcamento.Location = new System.Drawing.Point(694, 15);
            this.chkOrdemOrcamento.Name = "chkOrdemOrcamento";
            this.chkOrdemOrcamento.Size = new System.Drawing.Size(15, 14);
            this.chkOrdemOrcamento.TabIndex = 40;
            this.chkOrdemOrcamento.UseVisualStyleBackColor = true;
            // 
            // frmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 314);
            this.Controls.Add(this.chkOrdemOrcamento);
            this.Controls.Add(this.lblOrdemOrcamento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrdemVenda);
            this.Controls.Add(this.btnOrdemSalvar);
            this.Controls.Add(this.grvOrdem);
            this.Controls.Add(this.txtOrdemOS);
            this.Controls.Add(this.lblOrdemOS);
            this.Controls.Add(this.txtOrdemCliente);
            this.Controls.Add(this.lblOrdemCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdemServico";
            this.Text = "frmOrdemServico";
            ((System.ComponentModel.ISupportInitialize)(this.grvOrdem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrdemCliente;
        private System.Windows.Forms.Label lblOrdemCliente;
        private System.Windows.Forms.TextBox txtOrdemOS;
        private System.Windows.Forms.Label lblOrdemOS;
        private System.Windows.Forms.DataGridView grvOrdem;
        private System.Windows.Forms.Button btnOrdemSalvar;
        private System.Windows.Forms.Button btnOrdemVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label lblOrdemOrcamento;
        private System.Windows.Forms.CheckBox chkOrdemOrcamento;
    }
}