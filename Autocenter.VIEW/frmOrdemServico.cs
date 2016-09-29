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
    public partial class frmOrdemServico : Form
    {
        public frmOrdemServico()
        {
            InitializeComponent();
        }
        int rowindex = 0;
        ClienteController cliController = new ClienteController();
        OrdemServicoController osController = new OrdemServicoController();
        ServicoController servicoController = new ServicoController();
        PecaController pecaController = new PecaController();
        DataTable DT = new DataTable();

        public void frmOrdemServico_Load(object sender, EventArgs e)
        {
            criandoDT();
        }

        protected void criandoDT()
        {
            
            DataColumn IDs = new DataColumn("IDs", typeof(int));
            DT.Columns.Add(IDs);

        }

        private void txtOrdemCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOrdemCliente.Text != "")
                {
                    Cliente obterCliente = cliController.ObterNome(txtOrdemCliente.Text);
                }
            }
        }

        private void txtOrdemOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOrdemCliente.Text != "")
                {
                    OrdemServico obterOS = osController.Obter(Convert.ToInt32(txtOrdemOS.Text));
                    obterOS.Cliente.Nome = txtOrdemCliente.Text;
                    //DT.Rows.Add(obterOS.Servicos.ToList());
                   // DT.Rows.Add(obterOS.Pecas.ToList());
                   // grvOrdem.DataSource = DT;
                }
            }
        }

        private void grvOrdem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                rowindex = e.RowIndex;
            }
        }

        private void grvOrdem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (grvOrdem.Rows[rowindex].Cells[0].Value.ToString() != null)
                {
                    Servico obterServico = servicoController.Obter(Convert.ToInt32(grvOrdem.Rows[rowindex].Cells[0].Value));


                    DataRow novatupla = DT.NewRow();
                    novatupla["IDs"] = obterServico.ServicoId;
                    DT.Rows.Add(novatupla);
                    grvOrdem.DataSource = DT;
                    
                }
            }
        }

      
    }
}
