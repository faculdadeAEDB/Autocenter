﻿using System;
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
    public partial class frmFuncCadastro : Form
    {
        FuncionarioController controller = new FuncionarioController();

        public frmFuncCadastro()
        {
            InitializeComponent();
        } 
        Funcionario selectedFuncionario = null;

        private void frmClienteCadastro_Load(object sender, EventArgs e)
        {
            atualizandoGrv();
        }

        void limpandoCampos()
        {
            selectedFuncionario = null;
            txtFuncBusca.Clear();
            txtFuncCPF.Clear();
            txtFuncNome.Clear();
            txtFuncFuncao.Clear();
        }

        void atualizandoGrv()
        {
            grvFuncPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<Funcionario> oFuncionarios = new List<Funcionario>();
            oFuncionarios = controller.Obter();
            grvFuncPesquisa.DataSource = oFuncionarios;
            grvFuncPesquisa.Columns["FuncionarioId"].DisplayIndex = 0;
            grvFuncPesquisa.Columns["Nome"].DisplayIndex = 1;
            grvFuncPesquisa.Columns["CPF"].DisplayIndex = 2;
            grvFuncPesquisa.Columns["Funcao"].DisplayIndex = 3;
            grvFuncPesquisa.Columns["OrdemServicos"].Visible = false;
        }

        private void frmFunCadastro_Load(object sender, EventArgs e)
        {
            atualizandoGrv();
        }

        private void btnFuncSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtFuncNome.Text;
            string cpf = txtFuncCPF.Text;
            string funcao = txtFuncFuncao.Text;
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = nome;
            funcionario.CPF = cpf;
            funcionario.Funcao = funcao;

            if (selectedFuncionario == null)
            {
                Funcionario novoFuncionario = controller.Salvar(funcionario);
            }
            else
            {
                if (MessageBox.Show("Deseja realmente Alterar?", "Cadastro de Funcionario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    selectedFuncionario.Nome = nome;
                    selectedFuncionario.CPF = cpf;
                    selectedFuncionario.Funcao = funcao;
                    Funcionario alteraFuncionario = controller.Editar(selectedFuncionario);
                }
            }

            atualizandoGrv();
            limpandoCampos();
        }

        private void grvFuncPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedFuncionario = controller.Obter(Convert.ToInt32(grvFuncPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString()));

            txtFuncNome.Text = selectedFuncionario.Nome;
            txtFuncCPF.Text = selectedFuncionario.CPF;
            txtFuncFuncao.Text = selectedFuncionario.Funcao;
        }

        private void btnFuncLimpar_Click(object sender, EventArgs e)
        {
            limpandoCampos();
        }

        private void btnFuncBusca_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("ID", typeof(int));
            DT.Columns.Add("Nome", typeof(string));
            DT.Columns.Add("Função", typeof(string));
            DT.Columns.Add("CPF", typeof(string));
            Funcionario funcionarioBuscado = controller.Obter(Convert.ToInt32(txtFuncBusca.Text));
            DataRow novatupla = DT.NewRow();
            novatupla["ID"] = funcionarioBuscado.FuncionarioId;
            novatupla["Nome"] = funcionarioBuscado.Nome;
            novatupla["Função"] = funcionarioBuscado.Funcao;
            novatupla["CPF"] = funcionarioBuscado.CPF;
            DT.Rows.Add(novatupla);
            grvFuncPesquisa.DataSource = DT;
        }
    }
}
