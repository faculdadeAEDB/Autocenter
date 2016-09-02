using System;

namespace Domain.Entities
{
    public class Conta
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
