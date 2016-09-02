using System.Collections.Generic;

namespace Domain.Entities
{
    public class Peca
    {
        public Peca()
        {
            Modelos = new List<Modelo>();
            OrdemServicos = new List<OrdemServico>();
        }

        public int PecaId { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }

        // Relationships

        // Uma peça cadastrada pode servir para vários modelos
        public ICollection<Modelo> Modelos { get; set; }

        // Uma peça cadastrada pode estar em várias ordens de serviço
        public ICollection<OrdemServico> OrdemServicos { get; set; }
    }
}
