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
    public partial class frmPecaCadastro : Form
    {
        public frmPecaCadastro()
        {
            InitializeComponent();
        }

        private void btnPecaSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtPecaNome.Text;
            string Modelo = cboPecaModelo.Text;
            string Valor = txtPecaValor.Text;
            string Marca = txtPecaMarca.Text;
            string qtd = txtQtd.Text;

            Peca peca = new Peca();
            peca.Nome = nome;
            peca.Marca = Marca;


            peca.Quantidade = Convert.ToInt32(qtd);
            peca.Modelos = Modelo;
            
            peca.Valor = Valor;

            ModeloController controller = new ModeloController();
            peca.Modelos = controller.Obter(Convert.ToInt32(cboPecaModelo.Text));

            ClienteController controller = new ClienteController();

            controller.Salvar(Peca);
        }
    }
}
