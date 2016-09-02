using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class ModeloMap : EntityTypeConfiguration<Modelo>
    {
        public ModeloMap()
        {
            string modeloForeignName = "ModeloId";

            ToTable("Funcionario");
            HasKey(entity => entity.ModeloId);

            HasMany(x => x.Carros)
                .WithRequired(x => x.Modelo)
                .Map(m => m.MapKey(modeloForeignName));

            HasMany(x => x.Pecas)
                .WithMany(x => x.Modelos)
                .Map(m =>
                {
                    m.MapLeftKey(modeloForeignName);
                    m.MapRightKey("PecaId");
                    m.ToTable("ModeloPeca");
                });

        }
    }
}
