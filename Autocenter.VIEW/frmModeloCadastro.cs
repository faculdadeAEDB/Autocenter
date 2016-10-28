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
    public partial class frmModeloCadastro : Form
    {
        public frmModeloCadastro()
        {
            InitializeComponent();
        }
        Modelo selectedModelo = null;
        ModeloController controller = new ModeloController();
        private void frmModeloCadastro_Load(object sender, EventArgs e)
        {
            atualizandoGrv();
        }

        void limpandoCampos()
        {
            selectedModelo = null;
            txtModeloBusca.Clear();
            txtModeloMarca.Clear();
            txtModeloAno.Clear();
        }
        private void atualizandoGrv()
        {
            grvModeloPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<Modelo> oModelo = new List<Modelo>();
            oModelo = controller.Obter();
            grvModeloPesquisa.DataSource = oModelo;
            grvModeloPesquisa.Columns["ModeloId"].DisplayIndex = 0;
            grvModeloPesquisa.Columns["Nome"].DisplayIndex = 1;
            grvModeloPesquisa.Columns["Ano"].DisplayIndex = 2;
            grvModeloPesquisa.Columns["Carros"].Visible = false;
            grvModeloPesquisa.Columns["Pecas"].Visible = false;
            cboModeloFiltro.DisplayMember = "ID";
        }

        private void btnModeloSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtModeloMarca.Text;
            string ano = txtModeloAno.Text;
            Modelo modelo = new Modelo();
            modelo.Nome = nome;
            modelo.Ano = ano;

            if (selectedModelo == null)
            {
                Modelo novoModelo = controller.Salvar(modelo);
            }
            else
            {
                if (MessageBox.Show("Deseja realmente Alterar?", "Cadastro de Modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    selectedModelo.Nome = nome;
                    selectedModelo.Ano = ano;
                    Modelo alteraModelo = controller.Editar(selectedModelo);
                }
            }

            atualizandoGrv();
            limpandoCampos();
        }

        private void grvModeloPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedModelo = controller.Obter(Convert.ToInt32(grvModeloPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString()));

            txtModeloMarca.Text = selectedModelo.Nome;
            txtModeloAno.Text = selectedModelo.Ano;
        }

        private void btnModeloExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Excluir?", "Cadastro de Modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
              try
                {
                    controller.Excluir(selectedModelo);
                    atualizandoGrv();
                    limpandoCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não possível excluir sem selecionar um modelo");
                }
                
            }
        }

        private void btnModeloLimpar_Click(object sender, EventArgs e)
        {
            limpandoCampos();
        }

        private void btnModeloBusca_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("ID", typeof(int));
            DT.Columns.Add("Marca", typeof(string));
            DT.Columns.Add("Ano", typeof(string));
            Modelo modeloBuscado = controller.Obter(Convert.ToInt32(txtModeloBusca.Text));
            DataRow novatupla = DT.NewRow();
            novatupla["ID"] = modeloBuscado.ModeloId;
            novatupla["Marca"] = modeloBuscado.Nome;
            novatupla["Ano"] = modeloBuscado.Ano;
            DT.Rows.Add(novatupla);
            grvModeloPesquisa.DataSource = DT;
        }
    }
}
