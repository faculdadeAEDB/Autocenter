using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class ClienteRepository : IRepository<Cliente>
    {
        public Cliente Editar(Cliente obj)
        {
            using (DataContext c = new DataContext())
            {
                c.Clientes.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Cliente Excluir (Cliente obj)
        {
            using (DataContext c = new DataContext())
            {
                Cliente clienteExcluido = c.Clientes.Remove(obj);
                c.SaveChanges();
                return clienteExcluido;
            }
        }

        public List<Cliente> Obter()
        {
            using (DataContext c = new DataContext())
            {
                return c.Clientes
                    .Include(cliente => cliente.Carros)
                    .Include(cliente => cliente.OrdemServicos)
                    .ToList();
            }
        }

        public Cliente Obter(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente Salvar (Cliente obj)
        {
            using (DataContext c = new DataContext())
            {
                Cliente novoCliente = c.Clientes.Add(obj);
                c.SaveChanges();
                return novoCliente;
            }
        }
    }
}
