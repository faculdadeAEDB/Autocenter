using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class ServicoMap : EntityTypeConfiguration<Servico>
    {
        public ServicoMap()
        {
            ToTable("Servico");
            HasKey(entity => entity.ServicoId);

            HasMany(x => x.OrdemServicos)
               .WithMany(x => x.Servicos)
               .Map(m =>
               {
                   m.MapLeftKey("OrdemServicoId");
                   m.MapRightKey("ServicoId");
                   m.ToTable("OrdemServicoServico");
               });
        }
    }
}
