using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autocenter.VIEW
{
    public partial class frmInitial : Form
    {
        public frmInitial()
        {
            InitializeComponent();
        }

        private void btnInitialCarro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmCarroCadastro()).ShowDialog();
            this.Visible = true;
        }

        private void btnInitialCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmCliCadastro()).ShowDialog();
            this.Visible = true;
        }

        private void btnInitialFuncionario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmFuncCadastro()).ShowDialog();
            this.Visible = true;
        }

        private void btnInitialModelo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmModeloCadastro()).ShowDialog();
            this.Visible = true;
        }

        private void btnInitialOS_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmOrdemServico()).ShowDialog();
            this.Visible = true;
        }

        private void btnInitialPeca_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmPecaCadastro()).ShowDialog();
            this.Visible = true;
        }

        private void btnInitialServ_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmServCadastro()).ShowDialog();
            this.Visible = true;
        }
    }
}
