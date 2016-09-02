using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            string clienteForeignName = "ClienteId";

            ToTable("Cliente");
            HasKey(entity => entity.ClienteId);

            HasMany(x => x.Carros)
                .WithRequired(x => x.Cliente)
                .Map(m => m.MapKey(clienteForeignName));

            HasMany(x => x.OrdemServicos)
                .WithRequired(x => x.Cliente)
                .Map(m => m.MapKey(clienteForeignName));

        }
    }
}
