using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class PecaMap : EntityTypeConfiguration<Peca>
    {
        public PecaMap()
        {
            string pecaForeignName = "PecaId";

            ToTable("Peca");
            HasKey(entity => entity.PecaId);

            HasMany(x => x.Modelos)
                .WithMany(x => x.Pecas)
                .Map(m =>
                {
                    m.MapLeftKey(pecaForeignName);
                    m.MapRightKey("ModeloId");
                    m.ToTable("ModeloPeca");
                });

            HasMany(x => x.OrdemServicos)
                .WithMany(x => x.Pecas)
                .Map(m =>
                {
                    m.MapLeftKey(pecaForeignName);
                    m.MapRightKey("OrdemServicoId");
                    m.ToTable("OrdemServicoPeca");
                });
        }
    }
}
