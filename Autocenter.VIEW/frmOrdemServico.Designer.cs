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
            this.lblOrdemCliente = new System.Windows.Forms.Label();
            this.txtOrdemOS = new System.Windows.Forms.TextBox();
            this.lblOrdemOS = new System.Windows.Forms.Label();
            this.grvOrdem = new System.Windows.Forms.DataGridView();
            this.btnOrdemSalvar = new System.Windows.Forms.Button();
            this.btnOrdemVenda = new System.Windows.Forms.Button();
            this.lblOrdemValor = new System.Windows.Forms.Label();
            this.txtOrdemValor = new System.Windows.Forms.TextBox();
            this.lblOrdemOrcamento = new System.Windows.Forms.Label();
            this.chkOrdemOrcamento = new System.Windows.Forms.CheckBox();
            this.lblOrdemFunc = new System.Windows.Forms.Label();
            this.cboOrdemCliente = new System.Windows.Forms.ComboBox();
            this.cboOrdemFunc = new System.Windows.Forms.ComboBox();
            this.btnOrdemLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrdem)).BeginInit();
            this.SuspendLayout();
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
            this.txtOrdemOS.TabIndex = 1;
            this.txtOrdemOS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrdemOS_KeyDown);
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
            this.grvOrdem.AllowDrop = true;
            this.grvOrdem.AllowUserToAddRows = false;
            this.grvOrdem.AllowUserToOrderColumns = true;
            this.grvOrdem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrdem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grvOrdem.Location = new System.Drawing.Point(11, 74);
            this.grvOrdem.MultiSelect = false;
            this.grvOrdem.Name = "grvOrdem";
            this.grvOrdem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grvOrdem.Size = new System.Drawing.Size(698, 185);
            this.grvOrdem.TabIndex = 3;
            this.grvOrdem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvOrdem_CellValueChanged);
            // 
            // btnOrdemSalvar
            // 
            this.btnOrdemSalvar.Location = new System.Drawing.Point(11, 265);
            this.btnOrdemSalvar.Name = "btnOrdemSalvar";
            this.btnOrdemSalvar.Size = new System.Drawing.Size(115, 37);
            this.btnOrdemSalvar.TabIndex = 4;
            this.btnOrdemSalvar.Text = "Salvar";
            this.btnOrdemSalvar.UseVisualStyleBackColor = true;
            this.btnOrdemSalvar.Click += new System.EventHandler(this.btnOrdemSalvar_Click);
            // 
            // btnOrdemVenda
            // 
            this.btnOrdemVenda.Location = new System.Drawing.Point(590, 265);
            this.btnOrdemVenda.Name = "btnOrdemVenda";
            this.btnOrdemVenda.Size = new System.Drawing.Size(115, 37);
            this.btnOrdemVenda.TabIndex = 6;
            this.btnOrdemVenda.Text = "Finalizar Venda";
            this.btnOrdemVenda.UseVisualStyleBackColor = true;
            // 
            // lblOrdemValor
            // 
            this.lblOrdemValor.AutoSize = true;
            this.lblOrdemValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdemValor.Location = new System.Drawing.Point(389, 275);
            this.lblOrdemValor.Name = "lblOrdemValor";
            this.lblOrdemValor.Size = new System.Drawing.Size(89, 20);
            this.lblOrdemValor.TabIndex = 37;
            this.lblOrdemValor.Text = "Valor Total:";
            // 
            // txtOrdemValor
            // 
            this.txtOrdemValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtOrdemValor.Location = new System.Drawing.Point(484, 265);
            this.txtOrdemValor.Multiline = true;
            this.txtOrdemValor.Name = "txtOrdemValor";
            this.txtOrdemValor.ReadOnly = true;
            this.txtOrdemValor.Size = new System.Drawing.Size(100, 37);
            this.txtOrdemValor.TabIndex = 5;
            // 
            // lblOrdemOrcamento
            // 
            this.lblOrdemOrcamento.AutoSize = true;
            this.lblOrdemOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdemOrcamento.Location = new System.Drawing.Point(600, 11);
            this.lblOrdemOrcamento.Name = "lblOrdemOrcamento";
            this.lblOrdemOrcamento.Size = new System.Drawing.Size(92, 20);
            this.lblOrdemOrcamento.TabIndex = 4;
            this.lblOrdemOrcamento.Text = "Orçamento:";
            // 
            // chkOrdemOrcamento
            // 
            this.chkOrdemOrcamento.AutoSize = true;
            this.chkOrdemOrcamento.Location = new System.Drawing.Point(694, 15);
            this.chkOrdemOrcamento.Name = "chkOrdemOrcamento";
            this.chkOrdemOrcamento.Size = new System.Drawing.Size(15, 14);
            this.chkOrdemOrcamento.TabIndex = 2;
            this.chkOrdemOrcamento.UseVisualStyleBackColor = true;
            // 
            // lblOrdemFunc
            // 
            this.lblOrdemFunc.AutoSize = true;
            this.lblOrdemFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdemFunc.Location = new System.Drawing.Point(7, 41);
            this.lblOrdemFunc.Name = "lblOrdemFunc";
            this.lblOrdemFunc.Size = new System.Drawing.Size(96, 20);
            this.lblOrdemFunc.TabIndex = 39;
            this.lblOrdemFunc.Text = "Funcionario:";
            // 
            // cboOrdemCliente
            // 
            this.cboOrdemCliente.FormattingEnabled = true;
            this.cboOrdemCliente.Location = new System.Drawing.Point(75, 11);
            this.cboOrdemCliente.Name = "cboOrdemCliente";
            this.cboOrdemCliente.Size = new System.Drawing.Size(381, 21);
            this.cboOrdemCliente.TabIndex = 40;
            // 
            // cboOrdemFunc
            // 
            this.cboOrdemFunc.FormattingEnabled = true;
            this.cboOrdemFunc.Location = new System.Drawing.Point(109, 41);
            this.cboOrdemFunc.Name = "cboOrdemFunc";
            this.cboOrdemFunc.Size = new System.Drawing.Size(381, 21);
            this.cboOrdemFunc.TabIndex = 41;
            // 
            // btnOrdemLimpar
            // 
            this.btnOrdemLimpar.Location = new System.Drawing.Point(132, 265);
            this.btnOrdemLimpar.Name = "btnOrdemLimpar";
            this.btnOrdemLimpar.Size = new System.Drawing.Size(115, 37);
            this.btnOrdemLimpar.TabIndex = 42;
            this.btnOrdemLimpar.Text = "Limpar";
            this.btnOrdemLimpar.UseVisualStyleBackColor = true;
            this.btnOrdemLimpar.Click += new System.EventHandler(this.btnOrdemLimpar_Click);
            // 
            // frmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 314);
            this.Controls.Add(this.btnOrdemLimpar);
            this.Controls.Add(this.cboOrdemFunc);
            this.Controls.Add(this.cboOrdemCliente);
            this.Controls.Add(this.lblOrdemFunc);
            this.Controls.Add(this.chkOrdemOrcamento);
            this.Controls.Add(this.lblOrdemOrcamento);
            this.Controls.Add(this.txtOrdemValor);
            this.Controls.Add(this.lblOrdemValor);
            this.Controls.Add(this.btnOrdemVenda);
            this.Controls.Add(this.btnOrdemSalvar);
            this.Controls.Add(this.grvOrdem);
            this.Controls.Add(this.txtOrdemOS);
            this.Controls.Add(this.lblOrdemOS);
            this.Controls.Add(this.lblOrdemCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdemServico";
            this.Text = "frmOrdemServico";
            this.Load += new System.EventHandler(this.frmOrdemServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvOrdem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrdemCliente;
        private System.Windows.Forms.TextBox txtOrdemOS;
        private System.Windows.Forms.Label lblOrdemOS;
        private System.Windows.Forms.DataGridView grvOrdem;
        private System.Windows.Forms.Button btnOrdemSalvar;
        private System.Windows.Forms.Button btnOrdemVenda;
        private System.Windows.Forms.Label lblOrdemValor;
        private System.Windows.Forms.TextBox txtOrdemValor;
        private System.Windows.Forms.Label lblOrdemOrcamento;
        private System.Windows.Forms.CheckBox chkOrdemOrcamento;
        private System.Windows.Forms.Label lblOrdemFunc;
        private System.Windows.Forms.ComboBox cboOrdemCliente;
        private System.Windows.Forms.ComboBox cboOrdemFunc;
        private System.Windows.Forms.Button btnOrdemLimpar;
    }
}