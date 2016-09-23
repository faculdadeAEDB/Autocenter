using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class ServicoRepository : IRepository<Servico>
    {
        public Servico Editar(Servico obj)
        {
            using (DataContext c = new DataContext())
            {
                c.Servicos.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Servico Excluir(Servico obj)
        {
            using (DataContext c = new DataContext())
            {
                Servico servicoExcluido = c.Servicos.Remove(obj);
                c.SaveChanges();
                return servicoExcluido;
            }
        }

        public List<Servico> Obter()
        {
            using (DataContext c = new DataContext())
            {
                return c.Servicos
                    .Include(servico => servico.OrdemServicos)
                    .ToList();
            }
        }

        public Servico Obter(int id)
        {
            using (DataContext c = new DataContext())
            {
                return c.Servicos.Where(item => item.ServicoId == id).First();
            }
        }

        public Servico Salvar(Servico obj)
        {
            using (DataContext c = new DataContext())
            {
                Servico novoCliente = c.Servicos.Add(obj);
                c.SaveChanges();
                return novoCliente;
            }
        }
    }
}
