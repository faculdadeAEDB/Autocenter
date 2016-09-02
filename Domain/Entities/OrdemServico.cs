using System.Collections.Generic;

namespace Domain.Entities
{
    public class OrdemServico
    {
        public OrdemServico()
        {
            Pecas = new List<Peca>();
            Servicos = new List<Servico>();
            Vendas = new List<Venda>();
        }

        public int OrdemServicoId { get; set; }

        // Relationships

        // Uma ordem de serviço tem um cliente
        public Cliente Cliente { get; set; }

        // Uma ordem de serviço tem um Funcionário
        public Funcionario Funcionario { get; set; }

        // Uma ordem de serviço pode listar várias peças
        public ICollection<Peca> Pecas { get; set; }

        // Uma ordem de serviço pode listar vários serviços
        public ICollection<Servico> Servicos { get; set; }

        // Uma ordem de serviço pode ser efetuada em uma venda
        public ICollection<Venda> Vendas { get; set; }
    }
}
