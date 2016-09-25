using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class VendaRepository : IRepository<Venda>
    {
        public Venda Editar(Venda obj)
        {
            using (DataContext c = new DataContext())
            {
                c.Vendas.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Venda Excluir(Venda obj)
        {
            using (DataContext c = new DataContext())
            {
                Venda vendaExcluido = c.Vendas.Remove(obj);
                c.SaveChanges();
                return vendaExcluido;
            }
        }

        public List<Venda> Obter()
        {
            using (DataContext c = new DataContext())
            {
                return c.Vendas
                    .Include(Venda => Venda.Receitas)
                    .Include(Venda => Venda.OrdemServico)
                    .ToList();
            }
        }

        public Venda Obter(int id)
        {
            using (DataContext c = new DataContext())
            {
                return c.Vendas.Find(id);
            }
        }

        public Venda Salvar(Venda obj)
        {
            using (DataContext c = new DataContext())
            {
                Venda novaVenda = c.Vendas.Add(obj);
                c.SaveChanges();
                return novaVenda;
            }
        }
    }
}
