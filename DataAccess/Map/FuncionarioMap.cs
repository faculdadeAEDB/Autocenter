using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Map
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            string funcionarioForeignName = "FuncionarioId";

            ToTable("Funcionario");
            HasKey(entity => entity.FuncionarioId);

            HasMany(x => x.OrdemServicos)
                .WithRequired(x => x.Funcionario)
                .Map(m => m.MapKey(funcionarioForeignName));

        }
    }
}
