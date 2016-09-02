using System.Collections.Generic;

namespace Domain.Entities
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {
            Carros = new List<Carro>();
            OrdemServicos = new List<OrdemServico>();
        }

        public int ClienteId { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        // Relationships

        // Um cliente pode ter vários carros
        public ICollection<Carro> Carros { get; set; }
        // Um cliente pode solicitar várias ordens de serviço
        public ICollection<OrdemServico> OrdemServicos { get; set; }
    }
}
