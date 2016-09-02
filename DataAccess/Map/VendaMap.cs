using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class VendaMap : EntityTypeConfiguration<Venda>
    {
        public VendaMap()
        {
            ToTable("Venda");
            HasKey(entity => entity.VendaId);

            HasRequired(x => x.OrdemServico)
                .WithMany(x => x.Vendas)
                .Map(m => m.MapKey("OrdemServicoId"));

            HasMany(x => x.Receitas)
                .WithRequired(x => x.Venda)
                .Map(m => m.MapKey("VendaId"));
        }
    }
}
