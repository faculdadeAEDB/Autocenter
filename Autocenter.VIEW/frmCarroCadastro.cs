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
    public partial class frmCarroCadastro : Form
    {
        public frmCarroCadastro()
        {
            InitializeComponent();
        }

        TextBox VarCarroCliente;
        ComboBox varCarroModelo;
         

        private void txtCarroCliente_TextChanged(object sender, EventArgs e)
        {
            VarCarroCliente = txtCarroCliente;
            
        }

        private void cboCarroModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            varCarroModelo = cboCarroModelo;
        }

        private void txtCarroPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //VarTextCarroPlaca = txtCarroPlaca
        }

        private void btnCarroSalvar_Click(object sender, EventArgs e)
        {
            //recebendo campos digitas
            string CadCliente = txtCarroCliente.Text;
            string CadModelo = cboCarroModelo.Text;
            string cadPlaca = txtCarroPlaca.Text;
            string CadCor = txtCarroCor.Text;

            Carro carro = new Carro();
            ClienteController controller= new ClienteController();
            //ModeloController controller = new ModeloController();

            carro.Cliente = controller.Obter(Convert.ToInt32(txtCarroCliente.Text));
            //carro.Modelo = CadModelo.ob;
            carro.Placa = cadPlaca;
            carro.Cor = CadCor;

            //controller.Salvar(Carro);

        }
    }
}
