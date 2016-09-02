using System.Collections.Generic;

namespace Domain.Entities
{
    public class Modelo
    {
        public Modelo()
        {
            Carros = new List<Carro>();
            Pecas = new List<Peca>();
        }

        public int ModeloId { get; set; }
        public string Nome { get; set; }
        public string Ano { get; set; }

        // Relationships

        // Um modelo pode ser atribuído a vários carros
        public ICollection<Carro> Carros { get; set; }

        // Um modelo pode ter várias peças em catálogo
        public ICollection<Peca> Pecas { get; set; }
    }
}
