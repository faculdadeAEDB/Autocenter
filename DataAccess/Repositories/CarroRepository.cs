using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class CarroRepository : IRepository<Carro>
    {
        public Carro Editar(Carro obj)
        {
            using (DataContext c = new DataContext())
            {
                c.Carros.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Carro Excluir(Carro obj)
        {
            using (DataContext c = new DataContext())
            {
                Carro carroExcluido = c.Carros.Remove(obj);
                c.SaveChanges();
                return carroExcluido;
            }
        }

        public List<Carro> Obter()
        {
            using (DataContext c = new DataContext())
            {
                return c.Carros
                    .Include(carro => carro.Cliente)
                    .Include(carro => carro.Modelo)
                    .ToList();
            }
        }

        public Carro Obter(int id)
        {
            using (DataContext c = new DataContext())
            {
                return c.Carros.Where(item => item.CarroId == id).First();
            }
        }

        public Carro Salvar(Carro obj)
        {
            using (DataContext c = new DataContext())
            {
                Carro novoCliente = c.Carros.Add(obj);
                c.SaveChanges();
                return novoCliente;
            }
        }
    }
}
