namespace Autocenter.VIEW
{
    partial class frmInitial
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
            this.grbInitial = new System.Windows.Forms.GroupBox();
            this.btnInitialServ = new System.Windows.Forms.Button();
            this.btnInitialFuncionario = new System.Windows.Forms.Button();
            this.btnInitialPeca = new System.Windows.Forms.Button();
            this.btnInitialCliente = new System.Windows.Forms.Button();
            this.btnInitialModelo = new System.Windows.Forms.Button();
            this.btnInitialOS = new System.Windows.Forms.Button();
            this.btnInitialCarro = new System.Windows.Forms.Button();
            this.grbInitial.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInitial
            // 
            this.grbInitial.Controls.Add(this.btnInitialServ);
            this.grbInitial.Controls.Add(this.btnInitialFuncionario);
            this.grbInitial.Controls.Add(this.btnInitialPeca);
            this.grbInitial.Controls.Add(this.btnInitialCliente);
            this.grbInitial.Controls.Add(this.btnInitialModelo);
            this.grbInitial.Controls.Add(this.btnInitialOS);
            this.grbInitial.Controls.Add(this.btnInitialCarro);
            this.grbInitial.Location = new System.Drawing.Point(13, 13);
            this.grbInitial.Name = "grbInitial";
            this.grbInitial.Size = new System.Drawing.Size(758, 82);
            this.grbInitial.TabIndex = 0;
            this.grbInitial.TabStop = false;
            this.grbInitial.Text = "Cadastro";
            // 
            // btnInitialServ
            // 
            this.btnInitialServ.Location = new System.Drawing.Point(646, 19);
            this.btnInitialServ.Name = "btnInitialServ";
            this.btnInitialServ.Size = new System.Drawing.Size(100, 50);
            this.btnInitialServ.TabIndex = 5;
            this.btnInitialServ.Text = "Serviço";
            this.btnInitialServ.UseVisualStyleBackColor = true;
            this.btnInitialServ.Click += new System.EventHandler(this.btnInitialServ_Click);
            // 
            // btnInitialFuncionario
            // 
            this.btnInitialFuncionario.Location = new System.Drawing.Point(219, 20);
            this.btnInitialFuncionario.Name = "btnInitialFuncionario";
            this.btnInitialFuncionario.Size = new System.Drawing.Size(100, 50);
            this.btnInitialFuncionario.TabIndex = 6;
            this.btnInitialFuncionario.Text = "Funcionário";
            this.btnInitialFuncionario.UseVisualStyleBackColor = true;
            this.btnInitialFuncionario.Click += new System.EventHandler(this.btnInitialFuncionario_Click);
            // 
            // btnInitialPeca
            // 
            this.btnInitialPeca.Location = new System.Drawing.Point(540, 20);
            this.btnInitialPeca.Name = "btnInitialPeca";
            this.btnInitialPeca.Size = new System.Drawing.Size(100, 50);
            this.btnInitialPeca.TabIndex = 4;
            this.btnInitialPeca.Text = "Peca";
            this.btnInitialPeca.UseVisualStyleBackColor = true;
            this.btnInitialPeca.Click += new System.EventHandler(this.btnInitialPeca_Click);
            // 
            // btnInitialCliente
            // 
            this.btnInitialCliente.Location = new System.Drawing.Point(113, 20);
            this.btnInitialCliente.Name = "btnInitialCliente";
            this.btnInitialCliente.Size = new System.Drawing.Size(100, 50);
            this.btnInitialCliente.TabIndex = 1;
            this.btnInitialCliente.Text = "Cliente";
            this.btnInitialCliente.UseVisualStyleBackColor = true;
            this.btnInitialCliente.Click += new System.EventHandler(this.btnInitialCliente_Click);
            // 
            // btnInitialModelo
            // 
            this.btnInitialModelo.Location = new System.Drawing.Point(325, 20);
            this.btnInitialModelo.Name = "btnInitialModelo";
            this.btnInitialModelo.Size = new System.Drawing.Size(100, 50);
            this.btnInitialModelo.TabIndex = 2;
            this.btnInitialModelo.Text = "Modelo";
            this.btnInitialModelo.UseVisualStyleBackColor = true;
            this.btnInitialModelo.Click += new System.EventHandler(this.btnInitialModelo_Click);
            // 
            // btnInitialOS
            // 
            this.btnInitialOS.Location = new System.Drawing.Point(434, 20);
            this.btnInitialOS.Name = "btnInitialOS";
            this.btnInitialOS.Size = new System.Drawing.Size(100, 50);
            this.btnInitialOS.TabIndex = 3;
            this.btnInitialOS.Text = "O.S";
            this.btnInitialOS.UseVisualStyleBackColor = true;
            this.btnInitialOS.Click += new System.EventHandler(this.btnInitialOS_Click);
            // 
            // btnInitialCarro
            // 
            this.btnInitialCarro.Location = new System.Drawing.Point(7, 20);
            this.btnInitialCarro.Name = "btnInitialCarro";
            this.btnInitialCarro.Size = new System.Drawing.Size(100, 50);
            this.btnInitialCarro.TabIndex = 0;
            this.btnInitialCarro.Text = "Carro";
            this.btnInitialCarro.UseVisualStyleBackColor = true;
            this.btnInitialCarro.Click += new System.EventHandler(this.btnInitialCarro_Click);
            // 
            // frmInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 122);
            this.Controls.Add(this.grbInitial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInitial";
            this.Text = "frmInitial";
            this.grbInitial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInitial;
        private System.Windows.Forms.Button btnInitialServ;
        private System.Windows.Forms.Button btnInitialFuncionario;
        private System.Windows.Forms.Button btnInitialPeca;
        private System.Windows.Forms.Button btnInitialCliente;
        private System.Windows.Forms.Button btnInitialModelo;
        private System.Windows.Forms.Button btnInitialOS;
        private System.Windows.Forms.Button btnInitialCarro;
    }
}