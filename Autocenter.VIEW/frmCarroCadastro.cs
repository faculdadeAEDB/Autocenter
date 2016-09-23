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
    }
}
