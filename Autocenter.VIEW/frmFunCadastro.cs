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
        private FuncionarioController controller = new FuncionarioController();
        public frmFunCadastro()
        {
            InitializeComponent();
        }

        private void frmFunCadastro_Load(object sender, EventArgs e)
        {
            List<Funcionario> oFuncionarios = new List<Funcionario>();
            oFuncionarios = controller.Obter();

            grvFuncPesquisa.DataSource = oFuncionarios;
        }
    }
}
