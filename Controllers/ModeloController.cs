using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using Domain.Entities;

namespace Controllers
{
    public class ModeloController
    {
        ModeloRepository  modeloRepository;

        public ModeloController()
        {
             modeloRepository = new ModeloRepository();
        }

        public Modelo Editar(Modelo obj)
        {
            return  modeloRepository.Editar(obj);
        }

        public Modelo Excluir(Modelo obj)
        {
            return  modeloRepository.Excluir(obj);
        }

        public List<Modelo> Obter()
        {
            return  modeloRepository.Obter();
        }

        public Modelo Obter(int id)
        {
            return  modeloRepository.Obter(id);
        }

        public Modelo Salvar(Modelo obj)
        {
            return  modeloRepository.Salvar(obj);
        }
    }
