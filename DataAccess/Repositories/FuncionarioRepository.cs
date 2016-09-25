using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using System.Data.Entity;

namespace DataAccess.Repositories
{
    public class FuncionarioRepository : IRepository<Funcionario>
    {
        public Funcionario Editar(Funcionario obj)
        {
            using (DataContext c = new DataContext())
            {
                c.Funcionarios.Attach(obj);
                c.Entry(obj).State = EntityState.Modified;
                c.SaveChanges();

                return obj;
            }
        }

        public Funcionario Excluir(Funcionario obj)
        {
            using (DataContext c = new DataContext())
            {
                Funcionario funcionarioExcluido = c.Funcionarios.Remove(obj);
                c.SaveChanges();
                return funcionarioExcluido;
            }
        }

        public List<Funcionario> Obter()
        {
            using (DataContext c = new DataContext())
            {
                return c.Funcionarios
                    .Include(funcionario => funcionario.OrdemServicos)
                    .ToList();
            }
        }

        public Funcionario Obter(int id)
        {
            using (DataContext c = new DataContext())
            {
                Funcionario funcionarioSelecionado = c.Funcionarios.Find(id);
                return funcionarioSelecionado;
            }
        }

        public Funcionario Salvar(Funcionario obj)
        {
            using (DataContext c = new DataContext())
            {
                Funcionario novoFuncionario = c.Funcionarios.Add(obj);
                c.SaveChanges();
                return novoFuncionario;
            }
        }
    }
}
