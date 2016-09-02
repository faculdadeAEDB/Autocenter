using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Venda
    {
        public Venda()
        {

        }

        public int VendaId { get; set; }
        public DateTime Data { get; set; }

        // Relationships

        // Uma venda deve pertencer a uma ordem de serviço
        public OrdemServico OrdemServico { get; set; }

        // Uma venda gera uma receita
        public ICollection<Receita> Receitas { get; set; }
    }
}
