using System.Collections.Generic;

namespace Domain.Entities
{
    public class Servico
    {
        public Servico()
        {
            OrdemServicos = new List<OrdemServico>();
        }

        public int ServicoId { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

        // Relationships

        // Um serviço cadastrado pode estar em várias ordens de serviço
        public ICollection<OrdemServico> OrdemServicos { get; set; }
    }
}
