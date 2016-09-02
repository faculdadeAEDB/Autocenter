namespace Domain.Entities
{
    public class Receita : Conta
    {
        public int ReceitaId { get; set; }

        // Relationships
        public Venda Venda { get; set; }
    }
}
