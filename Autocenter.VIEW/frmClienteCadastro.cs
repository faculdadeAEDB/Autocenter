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
    public partial class frmCliCadastro : Form
    {
        public frmCliCadastro()
        {
            InitializeComponent();
        }

        Cliente selectedCliente = null;
       

        void limpandoCampos()
        {
            selectedCliente = null;
            txtCliBusca.Clear();
            txtCliCPF.Clear();
            txtCliEndereco.Clear();
            txtCliNome.Clear();
            txtCliTelefone.Clear();
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
            grvCliPesquisa.Columns["Carros"].Visible = false;
            grvCliPesquisa.Columns["OrdemServicos"].Visible = false;
            cboCliFiltro.DisplayMember = "ID";
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

            if (selectedCliente == null){
                Cliente novoCliente = controller.Salvar(cliente);
            }
            else
            {
                if (MessageBox.Show("Deseja realmente Alterar?", "Cadastro de Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    selectedCliente.Nome = nome;
                    selectedCliente.Telefone = telefone;
                    selectedCliente.CPF = cpf;
                    selectedCliente.Endereco = endereco;
                    Cliente alteraCliente = controller.Editar(selectedCliente);
                }
            }

            atualizandoGrv();
            limpandoCampos();
        }

        private void grvCliPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedCliente = controller.Obter(Convert.ToInt32(grvCliPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString()));

            txtCliNome.Text = selectedCliente.Nome;
            txtCliCPF.Text = selectedCliente.CPF;
            txtCliEndereco.Text = selectedCliente.Endereco;
            txtCliTelefone.Text = selectedCliente.Telefone;
        }

        private void btnClienteLimpar_Click(object sender, EventArgs e)
        {
            limpandoCampos();
        }

        private void btnCliBusca_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("ID", typeof(int));
            DT.Columns.Add("Nome", typeof(string));
            DT.Columns.Add("Telefone", typeof(string));
            DT.Columns.Add("CPF", typeof(string));
            DT.Columns.Add("Endereço", typeof(string));
            Cliente clienteBuscado = controller.Obter(Convert.ToInt32(txtCliBusca.Text));
            DataRow novatupla = DT.NewRow();
            novatupla["ID"] = clienteBuscado.ClienteId;
            novatupla["Nome"] = clienteBuscado.Nome;
            novatupla["Telefone"] = clienteBuscado.Telefone;
            novatupla["CPF"] = clienteBuscado.CPF;
            novatupla["Endereço"] = clienteBuscado.Endereco;
            DT.Rows.Add(novatupla);
            grvCliPesquisa.DataSource = DT;
        }
    }
}
