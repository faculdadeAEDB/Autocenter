using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using Domain.Entities;

namespace Controllers
{
    public class OrdemServicoController
    {
        OrdemServicoRepository ordemServicoRepository;

        public OrdemServicoController()
        {
            ordemServicoRepository = new OrdemServicoRepository();
        }

        public OrdemServico Editar(OrdemServico obj)
        {
            return ordemServicoRepository.Editar(obj);
        }

        public OrdemServico Excluir(OrdemServico obj)
        {
            return ordemServicoRepository.Excluir(obj);
        }
        public List<OrdemServico> Obter()
        {
            return ordemServicoRepository.Obter();
        }

        public OrdemServico Obter(int id)
        {
            return ordemServicoRepository.Obter(id);
        }

        public OrdemServico Salvar(OrdemServico obj)
        {
            return ordemServicoRepository.Salvar(obj);
        }
    }
}
