using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using Domain.Entities;

namespace Controllers
{
    public class ServicoController
    {
        ServicoRepository servicoRepository;

        public ServicoController()
        {
            servicoRepository = new ServicoRepository();
        }

        public Servico Editar(Servico obj)
        {
            return servicoRepository.Editar(obj);
        }

        public Servico Excluir(Servico obj)
        {
            return servicoRepository.Excluir(obj);
        }

        public List<Servico> Obter()
        {
            return servicoRepository.Obter();
        }

        public Servico Obter(int id)
        {
            return servicoRepository.Obter(id);
        }

        public Servico Salvar(Servico obj)
        {
            return servicoRepository.Salvar(obj);
        }
    }
}
