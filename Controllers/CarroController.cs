using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using Domain.Entities;

namespace Controllers
{
    public class CarroController
    {
        CarroRepository carroRepository;

        public CarroController()
        {
            carroRepository = new CarroRepository();
        }

        public Carro Editar(Carro obj)
        {
            return carroRepository.Editar(obj);
        }

        public Carro Excluir(Carro obj)
        {
            return carroRepository.Excluir(obj);
        }

        public List<Carro> Obter()
        {
            return carroRepository.Obter();
        }

        public Carro Obter(int id)
        {
            return carroRepository.Obter(id);
        }

        public Carro Salvar(Carro obj)
        {
            return carroRepository.Salvar(obj);
        }
    }
}
