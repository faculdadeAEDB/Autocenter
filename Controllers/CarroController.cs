using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;

namespace Controllers
{
    public class CarroController
    {

        public CarroController()
        {
            db = new DataContext();
        }

        List<Carro> buscar()
        {
            return db.Carros.AsParallel();
        }
    }
}
