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

        private void frmClienteCadastro_Load(object sender, EventArgs e)
        {

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

            ClienteController controller = new ClienteController();

            controller.Salvar(cliente);
        }
    }
}
