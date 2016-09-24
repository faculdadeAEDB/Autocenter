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
        FuncionarioController controller = new FuncionarioController();

        public frmFunCadastro()
        {
            InitializeComponent();
        }

        void atualizandoGrv()
        {
            grvFuncPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<Funcionario> oClientes = new List<Funcionario>();
            oClientes = controller.Obter();
            grvFuncPesquisa.DataSource = oClientes;
            grvFuncPesquisa.Columns["FuncionarioId"].DisplayIndex = 0;
            grvFuncPesquisa.Columns["Nome"].DisplayIndex = 1;
            grvFuncPesquisa.Columns["CPF"].DisplayIndex = 2;
            grvFuncPesquisa.Columns["Funcao"].DisplayIndex = 3;
            grvFuncPesquisa.Columns["OrdemServicos"].DisplayIndex = 4;
        }

        private void frmFunCadastro_Load(object sender, EventArgs e)
        {
            atualizandoGrv();
        }

        private void btnFuncSalvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtFunNome.Text;
            funcionario.CPF = txtFuncCPF.Text;
            funcionario.Funcao = txtFuncFuncao.Text;

            controller.Salvar(funcionario);

            atualizandoGrv();
        }
    }
}
