using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext") // Nome da conection string
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<OrdemServico> OrdemServicos { get; set; }
        public DbSet<Peca> Pecas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Venda> Vendas  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                   .Where(p => p.Name == p.ReflectedType.Name + "Id")
                   .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                   .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                  .Configure(p => p.HasMaxLength(100));
        }
    }
}
