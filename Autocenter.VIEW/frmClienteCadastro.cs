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
    public partial class frmClienteCadastro : Form
    {
        public frmClienteCadastro()
        {
            InitializeComponent();
        }

        void atualizandoGrv()
        {
            grvCliPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<Cliente> oClientes = new List<Cliente>();
            oClientes = controller.Obter();
            grvCliPesquisa.DataSource = oClientes;
            grvCliPesquisa.Columns["ClienteId"].DisplayIndex = 0;
            grvCliPesquisa.Columns["Nome"].DisplayIndex = 1;
            grvCliPesquisa.Columns["CPF"].DisplayIndex = 2;
            grvCliPesquisa.Columns["Endereco"].DisplayIndex = 3;
            grvCliPesquisa.Columns["Telefone"].DisplayIndex = 4;
            grvCliPesquisa.Columns["Carros"].DisplayIndex = 5;
            grvCliPesquisa.Columns["OrdemServicos"].DisplayIndex = 6;
        }
        ClienteController controller = new ClienteController();

        private void frmClienteCadastro_Load(object sender, EventArgs e)
        {
            atualizandoGrv();
        }

        private void btnCliSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtCliNome.Text;
            string telefone = txtCliTelefone.Text;
            string cpf = txtCliCPF.Text;
            string endereco = txtCliEndereco.Text;

            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Telefone = telefone;
            cliente.CPF = cpf;
            cliente.Endereco = endereco;

            Cliente novoCliente = controller.Salvar(cliente);

            atualizandoGrv();


        }
    }
}
