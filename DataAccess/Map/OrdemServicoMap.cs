using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class OrdemServicoMap : EntityTypeConfiguration<OrdemServico>
    {
        public OrdemServicoMap()
        {
            string ordemServicoName = "OrdemServicoId";

            ToTable("OrdemServico");
            HasKey(entity => entity.OrdemServicoId);

            HasRequired(x => x.Cliente)
                .WithMany(x => x.OrdemServicos)
                .Map(m => m.MapKey(ordemServicoName));

            HasRequired(x => x.Funcionario)
                .WithMany(x => x.OrdemServicos)
                .Map(m => m.MapKey(ordemServicoName));

            HasMany(x => x.Pecas)
                .WithMany(x => x.OrdemServicos)
                .Map(m =>
                {
                    m.MapLeftKey(ordemServicoName);
                    m.MapRightKey("PecaId");
                    m.ToTable("OrdemServicoPeca");
                });

            HasMany(x => x.Servicos)
                .WithMany(x => x.OrdemServicos)
                .Map(m =>
                {
                    m.MapLeftKey(ordemServicoName);
                    m.MapRightKey("PecaId");
                    m.ToTable("OrdemServicoServico");
                });

            HasMany(x => x.Vendas)
                .WithRequired(x => x.OrdemServico)
                .Map(m => m.MapKey("OrdemServicoId"));;
        }
    }
}
