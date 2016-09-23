using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using Domain.Entities;

namespace Controllers
{
    public class FuncionarioController
    {
        FuncionarioRepository funcionarioRepository;

        public FuncionarioController()
        {
            funcionarioRepository = new FuncionarioRepository();
        }

        public Funcionario Editar(Funcionario obj)
        {
            return funcionarioRepository.Editar(obj);
        }

        public Funcionario Excluir(Funcionario obj)
        {
            return funcionarioRepository.Excluir(obj);
        }

        public List<Funcionario> Obter()
        {
            return funcionarioRepository.Obter();
        }

        public Funcionario Obter(int id)
        {
            return funcionarioRepository.Obter(id);
        }

        public Funcionario Salvar(Funcionario obj)
        {
            return funcionarioRepository.Salvar(obj);
        }
    }
}
