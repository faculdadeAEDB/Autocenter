using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class PecaRepository : IRepository<Peca>
    {
        public Peca Editar (Peca obj)
        {
            using (DataContext c = new DataContext())
            {
                c.Pecas.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Peca Excluir  (Peca obj)
        {
            using (DataContext c = new DataContext())
            {
                Peca pecaexcluida = c.Pecas.Remove(obj);
                c.SaveChanges();
                return pecaexcluida;
            }
        }

        public List<Peca> Obter()
        {
            using (DataContext c = new DataContext())
            {
                return c.Pecas
                    .Include(peca => peca.Modelos)
                    .Include(peca => peca.OrdemServicos)
                    .ToList();
            }
        }

        public Peca Obter(int id)
        {
            using (DataContext c = new DataContext())
            {
                return c.Pecas.Find(id);
            }
        }

        public Peca Salvar(Peca obj)
        {
            using (DataContext c = new DataContext())
            {
                Peca novaPeca = c.Pecas.Add(obj);
                c.SaveChanges();
                return novaPeca;
            }
        }
    }
}
