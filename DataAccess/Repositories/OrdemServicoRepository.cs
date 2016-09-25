using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Entities;

namespace DataAccess.Repositories
{
    public class OrdemServicoRepository : IRepository<OrdemServico>
    {
        public OrdemServico Editar(OrdemServico obj)
        {
            using (DataContext c = new DataContext())
            {
                c.OrdemServicos.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public OrdemServico Excluir(OrdemServico obj)
        {
            using (DataContext c = new DataContext())
            {
                OrdemServico OrdemServicoExcluida = c.OrdemServicos.Remove(obj);
                c.SaveChanges();
                return OrdemServicoExcluida;
            }
        }
        public List<OrdemServico> Obter()
        {
            using (DataContext c = new DataContext())
            {
                return c.OrdemServicos
                    .Include(OrdemServico => OrdemServico.Cliente)
                    .Include(OrdemServico => OrdemServico.Servicos)
                    .Include(OrdemServico => OrdemServico.Pecas)
                    .Include(OrdemServico => OrdemServico.Vendas)
                    .ToList();
            }
        }

        public OrdemServico Obter(int id)
        {
            using (DataContext c = new DataContext())
            {
                return c.OrdemServicos.Find(id);
            }
        }

        public OrdemServico Salvar(OrdemServico obj)
        {
            using (DataContext c = new DataContext())
            {
                OrdemServico novoOrdemServico = c.OrdemServicos.Add(obj);
                c.SaveChanges();
                return novoOrdemServico;
            }
        }
    }
}
