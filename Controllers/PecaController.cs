using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using Domain.Entities;

namespace Controllers
{
    public class PecaController
    {
        PecaRepository pecaRepository;

        public PecaController()
        {
            pecaRepository = new PecaRepository();
        }

        public Peca Editar(Peca obj)
        {
            return pecaRepository.Editar(obj);
        }

        public Peca Excluir(Peca obj)
        {
            return pecaRepository.Excluir(obj);
        }

        public List<Peca> Obter()
        {
            return pecaRepository.Obter();
        }

        public Peca Obter(int id)
        {
            return pecaRepository.Obter(id);
        }

        public Peca Salvar(Peca obj)
        {
            return pecaRepository.Salvar(obj);
        }
    }
}
