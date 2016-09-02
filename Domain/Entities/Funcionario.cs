using System.Collections.Generic;

namespace Domain.Entities
{
    public class Funcionario : Pessoa
    {
        public Funcionario()
        {
            OrdemServicos = new List<OrdemServico>();
        }

        public int FuncionarioId { get; set; }
        public string Funcao { get; set; }

        // Relationships

        // Um funcionário participa de várias ordens de serviço
        public ICollection<OrdemServico> OrdemServicos { get; set; }
    }
}
