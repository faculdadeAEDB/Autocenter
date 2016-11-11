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
using System.Data.SqlClient;
using ReportGenerator;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Diagnostics;

namespace Autocenter.VIEW
{
    public partial class frmCarroCadastro : Form
    {
        CarroController controller;
        ModeloController controllerModelo;
        ClienteController controllerCliente;

        public frmCarroCadastro()
        {
            controller = new CarroController();
            controllerModelo = new ModeloController();
            controllerCliente = new ClienteController();
            InitializeComponent();
        }

        void atualizandoGrv()
        {
            grvCarroPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<Carro> oClientes = new List<Carro>();
            oClientes = controller.Obter();
            grvCarroPesquisa.DataSource = oClientes;

            List<Modelo> oModelo = controllerModelo.Obter().ToList();
            cboCarroModelo.DataSource = oModelo;
            cboCarroModelo.DisplayMember = "Nome";

            List<Cliente> oCliente = controllerCliente.Obter().ToList();
            cboCarroCliente.DataSource = oCliente;
            cboCarroCliente.DisplayMember = "Nome";

            cboCarroFiltro.DisplayMember = "ID";
        }

        private void btnCarroSalvar_Click(object sender, EventArgs e)
        {
            //recebendo campos digitas
            Cliente cliente = (Cliente)cboCarroCliente.SelectedItem;
            Cliente clienteReferenciado = controllerCliente.Obter(cliente.ClienteId);

            Modelo cboModelo = (Modelo)cboCarroModelo.SelectedItem;
            Modelo modeloAssociado = controllerModelo.Obter(cboModelo.ModeloId);

            string CadModelo = cboCarroModelo.Text;
            string cadPlaca = txtCarroPlaca.Text;
            string CadCor = txtCarroCor.Text;

            Carro carro = new Carro();
            ClienteController controller= new ClienteController();
            //ModeloController controller = new ModeloController();

            //carro.Modelo = CadModelo.ob;
            carro.Placa = cadPlaca;
            carro.Cor = CadCor;

            //controller.Salvar(Carro);

        }

        private void frmCarroCadastro_Load(object sender, EventArgs e)
        {
            atualizandoGrv();
        }

        private void btnCarroLimpar_Click(object sender, EventArgs e)
        {
        }

        private void btnCarroRelatorio_Click(object sender, EventArgs e)
        {
            ReportDocument oReport = new ReportDocument();
            oReport.Load(Application.StartupPath + "\\CrystalReportCarro.rpt");
            oReport.VerifyDatabase();
            oReport.SetDataSource(grvCarroPesquisa.DataSource as DataTable);
            oReport.Refresh();
            oReport.ExportToDisk(ExportFormatType.PortableDocFormat, @"c:\\users\\gusta\\desktop\\Relatório Carro.pdf");
            MessageBox.Show("Relatório Emitido com sucesso", "OK");
            {
                Process.Start(@"c:\\users\\gusta\\desktop\\Relatório Carro.pdf");
            }
        }
    }
}
