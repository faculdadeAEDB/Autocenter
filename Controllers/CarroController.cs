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

        List<Carro> Obter()
        {
            return carroRepository.Obter();
        }
    }
}
