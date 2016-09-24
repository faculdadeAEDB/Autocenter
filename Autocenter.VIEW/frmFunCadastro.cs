using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities;
using Controllers;


namespace Autocenter.VIEW
{
    public partial class frmFunCadastro : Form
    {
        FuncionarioController controller;

        public frmFunCadastro()
        {
            InitializeComponent();
            controller = new FuncionarioController();
        }

        private void frmFunCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnFuncSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtFunNome.Text;
            funcionario.CPF = txtFuncCPF.Text;
            funcionario.Funcao = txtFuncFuncao.Text;

            controller.Salvar(funcionario);
        }
    }
}
