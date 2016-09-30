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
        FuncionarioController funcController = new FuncionarioController();
        PecaController pecaController = new PecaController();
        List<Servico> listaServico = new List<Servico>();
        List<Peca> listaPeca = new List<Peca>();
        Cliente obterCliente = new Cliente();
        Funcionario obterFunc = new Funcionario();
        DataTable DT = new DataTable();

        public void frmOrdemServico_Load(object sender, EventArgs e)
        {
            criandoDT();
            grvOrdem.DataSource = DT;
            atualizarValor();
            List<Cliente> oCliente = cliController.Obter().ToList();
            cboOrdemCliente.DataSource = oCliente;
            cboOrdemCliente.DisplayMember = "Nome";
            cboOrdemCliente.Text = "";
            List<Funcionario> oFuncionario = funcController.Obter().ToList();
            cboOrdemFunc.DataSource = oFuncionario;
            cboOrdemFunc.DisplayMember = "Nome";
            cboOrdemFunc.Text = "";
        }

        protected void criandoDT()
        {
            DataColumn Tipo = new DataColumn("Tipo", typeof(string));
            DT.Columns.Add(Tipo);
            DataColumn ID = new DataColumn("ID", typeof(int));
            DT.Columns.Add(ID);
            DataColumn Quantidade = new DataColumn("Quantidade", typeof(int));
            DT.Columns.Add(Quantidade);
            DataColumn Valor = new DataColumn("Valor", typeof(int));
            DT.Columns.Add(Valor);
            DataColumn Nome = new DataColumn("Nome", typeof(string));
            DT.Columns.Add(Nome);
            DT.Rows.Add("S",0,0,0,"");
        }

        private void txtOrdemCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboOrdemCliente.Text != "")
                {
                    try
                    { 
                        
                        MessageBox.Show("Cliente Selecionado com sucesso");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Cliente não Cadastrado");
                    }
                    
                }
            }
        }

        private void txtOrdemFunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    
                    MessageBox.Show("Funcionario Selecionado com sucesso");
                }
                catch (Exception)
                {

                    MessageBox.Show("Funcionario não Cadastrado");
                }

            }
        }

        private void txtOrdemOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboOrdemCliente.Text == ""  || cboOrdemFunc.Text == "")
                {
                    try
                    {
                        OrdemServico obterOS = osController.Obter(Convert.ToInt32(txtOrdemOS.Text));
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("O.S não existente");
                    }
                }          
            }
        }

        private void grvOrdem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string pecaouserv = "";


            if (grvOrdem.Rows[e.RowIndex].Cells[0].Value.ToString() == "S" || grvOrdem.Rows[e.RowIndex].Cells[0].Value.ToString() == "s")
                pecaouserv = "serv";
            else
               if (grvOrdem.Rows[e.RowIndex].Cells[0].Value.ToString() == "P" || grvOrdem.Rows[e.RowIndex].Cells[0].Value.ToString() == "p")
            { 
                pecaouserv = "peca";
            }

                if (grvOrdem.Rows[e.RowIndex].Cells[1].Value.ToString() != "0" && e.ColumnIndex == 1)
            { 
                if (pecaouserv == "serv")
                {
                    try
                    {
                        Servico obterServico = servicoController.Obter(Convert.ToInt32(grvOrdem.Rows[rowindex].Cells[1].Value));
                        listaServico.Add(obterServico);
                        DataRow novatupla = DT.NewRow();
                        novatupla["ID"] = obterServico.ServicoId;
                        novatupla["Quantidade"] = 1;
                        novatupla["Valor"] = obterServico.Valor;
                        //novatupla["Nome"] = obterServico.Nome; não tem no banco
                        DT.Rows.Add(novatupla);
                        grvOrdem.ClearSelection();
                        grvOrdem.DataSource = DT;
                        grvOrdem.Rows[0].Cells[1].Value = 0;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Serviço não cadastrado");
                    }
                    
                }
                if (pecaouserv == "peca")
                {
                    try
                    {
                        Peca obterPeca = pecaController.Obter(Convert.ToInt32(grvOrdem.Rows[rowindex].Cells[1].Value));
                        listaPeca.Add(obterPeca);
                        DataRow novatupla = DT.NewRow();
                        novatupla["ID"] = obterPeca.PecaId;
                        novatupla["Quantidade"] = 1;
                        novatupla["Valor"] = 0; //obterPeca.Valor; não tem valor no banco
                        novatupla["Nome"] = obterPeca.Nome;
                        DT.Rows.Add(novatupla);
                        grvOrdem.ClearSelection();
                        grvOrdem.DataSource = DT;
                        grvOrdem.Rows[0].Cells[1].Value = 0;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Peça não cadastrada");
                    }
                }
                else
                {
                }
            }
            atualizarValor();
        }

        private void atualizarValor()
        {
            decimal soma = 0;
            
            foreach (DataRow row in DT.Rows)
            {
                soma += Convert.ToDecimal(row["Valor"]);
            }
            txtOrdemValor.Text = soma.ToString();
        }

        private void btnOrdemSalvar_Click(object sender, EventArgs e)
        {
            if (txtOrdemOS.Text == "")
            {
                obterFunc = (Funcionario)cboOrdemFunc.SelectedItem;
                Funcionario funcAssociado = funcController.Obter(obterFunc.FuncionarioId);
                obterCliente = (Cliente)(cboOrdemCliente.SelectedItem);
                Cliente clienteAssociado = cliController.Obter(obterCliente.ClienteId);
                OrdemServico OS = new OrdemServico();
                OS.Cliente = clienteAssociado;
                OS.Funcionario = funcAssociado;
                OS.Pecas = listaPeca;
                OS.Servicos = listaServico;
                OrdemServico novaOS = osController.Salvar(OS);

                limpartudo();
            }
             else
            {
                MessageBox.Show("O.S já selecionada, limpe antes de selecionar outra O.S");
            }
        }

        private void limpartudo()
        {
            cboOrdemCliente.Text = "";
            cboOrdemFunc.Text = "";
            DT.Clear();
            DT.Rows.Add("S", 0, 0, 0, "");
            txtOrdemOS.Text = "";
            txtOrdemValor.Text = "";
        }
    }
}
