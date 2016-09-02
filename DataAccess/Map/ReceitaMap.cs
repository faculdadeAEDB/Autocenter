using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class ReceitaMap : EntityTypeConfiguration<Receita>
    {
        public ReceitaMap()
        {
            ToTable("Receita");
            HasKey(entity => entity.ReceitaId);

            HasRequired(x => x.Venda)
               .WithMany(x => x.Receitas)
               .Map(m => m.MapKey("VendaId"));
        }
    }
}
