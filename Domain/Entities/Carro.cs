namespace Domain.Entities
{
    public class Carro
    {
        public int CarroId { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }

        // Relationships

        // Um carro pertente a um cliente
        public Cliente Cliente { get; set; }

        // Um carro contém um modelo
        public Modelo Modelo { get; set; }
    }
}
