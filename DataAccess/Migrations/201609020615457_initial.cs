namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carro",
                c => new
                    {
                        CarroId = c.Int(nullable: false, identity: true),
                        Cor = c.String(maxLength: 100, unicode: false),
                        Placa = c.String(maxLength: 100, unicode: false),
                        Cliente_ClienteId = c.Int(),
                        Modelo_ModeloId = c.Int(),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.Cliente", t => t.Cliente_ClienteId)
                .ForeignKey("dbo.Modelo", t => t.Modelo_ModeloId)
                .Index(t => t.Cliente_ClienteId)
                .Index(t => t.Modelo_ModeloId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Endereco = c.String(maxLength: 100, unicode: false),
                        Telefone = c.String(maxLength: 100, unicode: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        CPF = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.OrdemServico",
                c => new
                    {
                        OrdemServicoId = c.Int(nullable: false, identity: true),
                        Cliente_ClienteId = c.Int(),
                        Funcionario_FuncionarioId = c.Int(),
                    })
                .PrimaryKey(t => t.OrdemServicoId)
                .ForeignKey("dbo.Cliente", t => t.Cliente_ClienteId)
                .ForeignKey("dbo.Funcionario", t => t.Funcionario_FuncionarioId)
                .Index(t => t.Cliente_ClienteId)
                .Index(t => t.Funcionario_FuncionarioId);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        Funcao = c.String(maxLength: 100, unicode: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        CPF = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.FuncionarioId);
            
            CreateTable(
                "dbo.Peca",
                c => new
                    {
                        PecaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Marca = c.String(maxLength: 100, unicode: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PecaId);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        ModeloId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Ano = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ModeloId);
            
            CreateTable(
                "dbo.Servico",
                c => new
                    {
                        ServicoId = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descricao = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ServicoId);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        VendaId = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        OrdemServico_OrdemServicoId = c.Int(),
                    })
                .PrimaryKey(t => t.VendaId)
                .ForeignKey("dbo.OrdemServico", t => t.OrdemServico_OrdemServicoId)
                .Index(t => t.OrdemServico_OrdemServicoId);
            
            CreateTable(
                "dbo.Receita",
                c => new
                    {
                        ReceitaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataVencimento = c.DateTime(nullable: false),
                        Venda_VendaId = c.Int(),
                    })
                .PrimaryKey(t => t.ReceitaId)
                .ForeignKey("dbo.Venda", t => t.Venda_VendaId)
                .Index(t => t.Venda_VendaId);
            
            CreateTable(
                "dbo.ModeloPeca",
                c => new
                    {
                        Modelo_ModeloId = c.Int(nullable: false),
                        Peca_PecaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Modelo_ModeloId, t.Peca_PecaId })
                .ForeignKey("dbo.Modelo", t => t.Modelo_ModeloId)
                .ForeignKey("dbo.Peca", t => t.Peca_PecaId)
                .Index(t => t.Modelo_ModeloId)
                .Index(t => t.Peca_PecaId);
            
            CreateTable(
                "dbo.PecaOrdemServico",
                c => new
                    {
                        Peca_PecaId = c.Int(nullable: false),
                        OrdemServico_OrdemServicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Peca_PecaId, t.OrdemServico_OrdemServicoId })
                .ForeignKey("dbo.Peca", t => t.Peca_PecaId)
                .ForeignKey("dbo.OrdemServico", t => t.OrdemServico_OrdemServicoId)
                .Index(t => t.Peca_PecaId)
                .Index(t => t.OrdemServico_OrdemServicoId);
            
            CreateTable(
                "dbo.ServicoOrdemServico",
                c => new
                    {
                        Servico_ServicoId = c.Int(nullable: false),
                        OrdemServico_OrdemServicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Servico_ServicoId, t.OrdemServico_OrdemServicoId })
                .ForeignKey("dbo.Servico", t => t.Servico_ServicoId)
                .ForeignKey("dbo.OrdemServico", t => t.OrdemServico_OrdemServicoId)
                .Index(t => t.Servico_ServicoId)
                .Index(t => t.OrdemServico_OrdemServicoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receita", "Venda_VendaId", "dbo.Venda");
            DropForeignKey("dbo.Venda", "OrdemServico_OrdemServicoId", "dbo.OrdemServico");
            DropForeignKey("dbo.ServicoOrdemServico", "OrdemServico_OrdemServicoId", "dbo.OrdemServico");
            DropForeignKey("dbo.ServicoOrdemServico", "Servico_ServicoId", "dbo.Servico");
            DropForeignKey("dbo.PecaOrdemServico", "OrdemServico_OrdemServicoId", "dbo.OrdemServico");
            DropForeignKey("dbo.PecaOrdemServico", "Peca_PecaId", "dbo.Peca");
            DropForeignKey("dbo.ModeloPeca", "Peca_PecaId", "dbo.Peca");
            DropForeignKey("dbo.ModeloPeca", "Modelo_ModeloId", "dbo.Modelo");
            DropForeignKey("dbo.Carro", "Modelo_ModeloId", "dbo.Modelo");
            DropForeignKey("dbo.OrdemServico", "Funcionario_FuncionarioId", "dbo.Funcionario");
            DropForeignKey("dbo.OrdemServico", "Cliente_ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Carro", "Cliente_ClienteId", "dbo.Cliente");
            DropIndex("dbo.ServicoOrdemServico", new[] { "OrdemServico_OrdemServicoId" });
            DropIndex("dbo.ServicoOrdemServico", new[] { "Servico_ServicoId" });
            DropIndex("dbo.PecaOrdemServico", new[] { "OrdemServico_OrdemServicoId" });
            DropIndex("dbo.PecaOrdemServico", new[] { "Peca_PecaId" });
            DropIndex("dbo.ModeloPeca", new[] { "Peca_PecaId" });
            DropIndex("dbo.ModeloPeca", new[] { "Modelo_ModeloId" });
            DropIndex("dbo.Receita", new[] { "Venda_VendaId" });
            DropIndex("dbo.Venda", new[] { "OrdemServico_OrdemServicoId" });
            DropIndex("dbo.OrdemServico", new[] { "Funcionario_FuncionarioId" });
            DropIndex("dbo.OrdemServico", new[] { "Cliente_ClienteId" });
            DropIndex("dbo.Carro", new[] { "Modelo_ModeloId" });
            DropIndex("dbo.Carro", new[] { "Cliente_ClienteId" });
            DropTable("dbo.ServicoOrdemServico");
            DropTable("dbo.PecaOrdemServico");
            DropTable("dbo.ModeloPeca");
            DropTable("dbo.Receita");
            DropTable("dbo.Venda");
            DropTable("dbo.Servico");
            DropTable("dbo.Modelo");
            DropTable("dbo.Peca");
            DropTable("dbo.Funcionario");
            DropTable("dbo.OrdemServico");
            DropTable("dbo.Cliente");
            DropTable("dbo.Carro");
        }
    }
}
