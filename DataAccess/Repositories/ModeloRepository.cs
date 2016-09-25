using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class ModeloRepository : IRepository<Modelo>
    {
        public Modelo Editar(Modelo obj)
        {
            using (DataContext c = new DataContext())
            {
                c.Modelos.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Modelo Excluir(Modelo obj)
        {
            using (DataContext c = new DataContext())
            {
                c.Modelos.Attach(obj);
                Modelo modeloExcluida = c.Modelos.Remove(obj);
                c.SaveChanges();
                return modeloExcluida;
            }
        }
        public List<Modelo> Obter()
        {
            using (DataContext c = new DataContext())
            {
                return c.Modelos
                    .Include(modelo => modelo.Carros)
                    .Include(modelo => modelo.Pecas)
                    .ToList();
            }
        }

        public Modelo Obter(int id)
        {
            using (DataContext c = new DataContext())
            {
                return c.Modelos.Where(item => item.ModeloId == id).First();
            }
        }

        public Modelo Salvar(Modelo obj)
        {
            using (DataContext c = new DataContext())
            {
                Modelo novoCliente = c.Modelos.Add(obj);
                c.SaveChanges();
                return novoCliente;
            }
        }
    }
}
