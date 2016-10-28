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
    public partial class frmServCadastro : Form
    {
        public frmServCadastro()
        {
            InitializeComponent();
        }
        ServicoController controller = new ServicoController();
        Servico selectedServico = null; 
        void limpandoCampos()
        {
            selectedServico = null;
            txtServBusca.Clear();
            txtServDescricao.Clear();
            txtServNome.Clear();
            txtServValor.Clear();
        }
        void atualizandoGrv()
        {
            grvServPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<Servico> oServicos = new List<Servico>();
            oServicos = controller.Obter();
            grvServPesquisa.DataSource = oServicos;
            grvServPesquisa.Columns["ServicoId"].DisplayIndex = 0;
            grvServPesquisa.Columns["Descricao"].DisplayIndex = 1;
            grvServPesquisa.Columns["Valor"].DisplayIndex = 2;
            grvServPesquisa.Columns["OrdemServicos"].Visible = false;
            cboServFiltro.DisplayMember = "ID";
        }


        private void frmServCadastro_Load(object sender, EventArgs e)
        {
            atualizandoGrv();
        }

        private void btnServSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtServNome.Text;
            string descricao = txtServDescricao.Text;
            string valor = txtServValor.Text;
            Servico servico = new Servico();
            //servico.Nome = nome;
            servico.Descricao = descricao;
            servico.Valor = Convert.ToDecimal(valor);
            
            if (selectedServico == null)
            {
                Servico novoServico = controller.Salvar(servico);
            }
            else
            {
                if (MessageBox.Show("Deseja realmente Alterar?", "Cadastro de Servico", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //selectedServico.Nome = nome;
                    selectedServico.Descricao = descricao;
                    selectedServico.Valor = Convert.ToDecimal(valor);
                    Servico alteraServico = controller.Editar(selectedServico);
                }
            }
            atualizandoGrv();
            limpandoCampos();
        }

        private void grvServPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedServico = controller.Obter(Convert.ToInt32(grvServPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString()));

            txtServDescricao.Text = selectedServico.Descricao;
            //txtServNome.Text = selectedServico.Nome;
            txtServValor.Text = Convert.ToString(selectedServico.Valor);
        }

        private void btnServExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Excluir?", "Cadastro de Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    controller.Excluir(selectedServico);
                    atualizandoGrv();
                    limpandoCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não possível excluir sem selecionar um modelo");
                }

            }
        }

        private void btnServLimpar_Click(object sender, EventArgs e)
        {
            limpandoCampos();
        }

        private void btnServBusca_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboServFiltro.Text == "ID")
                {
                    DataTable DT = new DataTable();
                    DT.Columns.Add("ID", typeof(int));
                    //   DT.Columns.Add("Nome", typeof(string));
                    DT.Columns.Add("Valor", typeof(string));
                    DT.Columns.Add("Descrição", typeof(string));
                    Servico servicoBuscado = controller.Obter(Convert.ToInt32(txtServBusca.Text));
                    DataRow novatupla = DT.NewRow();
                    novatupla["ID"] = servicoBuscado.ServicoId;
                    // novatupla["Nome"] = servicoBuscado.Nome;
                    novatupla["Valor"] = servicoBuscado.Valor;
                    novatupla["Descrição"] = servicoBuscado.Descricao;
                    DT.Rows.Add(novatupla);
                    grvServPesquisa.DataSource = DT;
                }
                else
                {
                    atualizandoGrv();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ID não encontrada", "Erro");
            }
        }
    }
}
