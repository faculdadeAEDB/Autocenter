using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class CarroMap : EntityTypeConfiguration<Carro>
    {
        public CarroMap()
        {
            ToTable("Carro");
            HasKey(entity => entity.CarroId);

            HasRequired(x => x.Cliente)
                .WithMany(x => x.Carros)
                .Map(m => m.MapKey("ClienteId"));
        }
    }
}
