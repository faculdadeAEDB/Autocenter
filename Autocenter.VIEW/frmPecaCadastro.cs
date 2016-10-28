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
        Peca selectedPeca = null;
        PecaController controller = new PecaController();
        ModeloController controllerModelo = new ModeloController();

        void limpandoCampos()
        {
            txtPecaBusca.Clear();
            txtPecaMarca.Clear();
            txtPecaNome.Clear();
            txtPecaQtd.Clear();
            txtPecaValor.Clear();
            cboPecaModelo.Text = "";
        }
        void atualizandoGrv()
        {
            grvPecaPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<Peca> oPeca = new List<Peca>();
            oPeca = controller.Obter();
            grvPecaPesquisa.DataSource = oPeca;
            grvPecaPesquisa.Columns["PecaId"].DisplayIndex = 0;
            grvPecaPesquisa.Columns["Nome"].DisplayIndex = 1;
            grvPecaPesquisa.Columns["Marca"].DisplayIndex = 2;
            grvPecaPesquisa.Columns["Quantidade"].DisplayIndex = 3;
            grvPecaPesquisa.Columns["Modelos"].Visible = false;
            grvPecaPesquisa.Columns["OrdemServicos"].Visible = false;
            List<Modelo> oModelo = controllerModelo.Obter().ToList();
            cboPecaModelo.DataSource = oModelo;
            cboPecaModelo.DisplayMember = "Nome";
            cboPecaModelo.Text = "";
            cboPecaFiltro.DisplayMember = "ID";
        }

        private void frmPecaCadastro_Load(object sender, EventArgs e)
        {
            atualizandoGrv();
        }

        private void btnPecaSalvar_Click_1(object sender, EventArgs e)
        {
            string nome = txtPecaNome.Text;
            Modelo cboModelo = (Modelo)cboPecaModelo.SelectedItem;
            Modelo modeloAssociado = controllerModelo.Obter(cboModelo.ModeloId);
            //string Valor = txtPecaValor.Text; não tem no banco
            string Marca = txtPecaMarca.Text;
            int qtd = Convert.ToInt32(txtPecaQtd.Text);
            Peca peca = new Peca();
            peca.Nome = nome;
            peca.Marca = Marca;
            peca.Quantidade = qtd;
            if (selectedPeca == null)
            {
                Peca novoPeca = controller.Salvar(peca);
                peca.Modelos.Add(modeloAssociado);
            }
            else
            {
                if (MessageBox.Show("Deseja realmente Alterar?", "Cadastro de Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    selectedPeca.Marca = Marca;
                    selectedPeca.Nome = nome;
                    selectedPeca.Quantidade = qtd;
                    
                    Peca alteraPeca = controller.Editar(selectedPeca);
                    
                }
            }
            atualizandoGrv();
            limpandoCampos();
        }

        private void grvPecaPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPeca = controller.Obter(Convert.ToInt32(grvPecaPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString()));

            txtPecaNome.Text = selectedPeca.Nome;
            txtPecaQtd.Text = Convert.ToString(selectedPeca.Quantidade);
            //txtPecaValor.Text = selectedPeca.Valor; não tem no banco
            txtPecaMarca.Text = selectedPeca.Marca;
        }

        private void btnPecaExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Excluir?", "Cadastro de Peca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    controller.Excluir(selectedPeca);
                    atualizandoGrv();
                    limpandoCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não possível excluir sem selecionar uma peça");
                }

            }
        }

        private void btnPecaLimpar_Click(object sender, EventArgs e)
        {
            limpandoCampos();
        }

        private void btnPecaBusca_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("ID", typeof(int));
            DT.Columns.Add("Nome", typeof(string));
            DT.Columns.Add("Quantidade", typeof(string));
           // DT.Columns.Add("Valor", typeof(string));
            DT.Columns.Add("Marca", typeof(string));
            Peca pecaBuscado = controller.Obter(Convert.ToInt32(txtPecaBusca.Text));
            DataRow novatupla = DT.NewRow();
            novatupla["ID"] = pecaBuscado.PecaId;
            novatupla["Nome"] = pecaBuscado.Nome;
            novatupla["Quantidade"] = pecaBuscado.Quantidade;
           // novatupla["Valor"] = pecaBuscado.Valor;
            novatupla["Marca"] = pecaBuscado.Marca;
            DT.Rows.Add(novatupla);
            grvPecaPesquisa.DataSource = DT;
        }
    }
}
