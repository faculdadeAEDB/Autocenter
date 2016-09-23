using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using Domain.Entities;

namespace Controllers
{
    public class VendaController
    {
        VendaRepository vendaRepository;

        public VendaController()
        {
            vendaRepository = new VendaRepository();
        }

        public Venda Editar(Venda obj)
        {
            return vendaRepository.Editar(obj);
        }

        public Venda Excluir(Venda obj)
        {
            return vendaRepository.Excluir(obj);
        }

        public List<Venda> Obter()
        {
            return vendaRepository.Obter();
        }

        public Venda Obter(int id)
        {
            return vendaRepository.Obter(id);
        }

        public Venda Salvar(Venda obj)
        {
            return vendaRepository.Salvar(obj);
        }
    }
}
