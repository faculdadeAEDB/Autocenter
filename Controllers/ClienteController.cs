using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using Domain.Entities;

namespace Controllers
{
    public class ClienteController
    {
        ClienteRepository clienteRepository;

        public ClienteController()
        {
            clienteRepository = new ClienteRepository();
        }

        public Cliente Editar(Cliente obj)
        {
            return clienteRepository.Editar(obj);
        }

        public List<Cliente> Obter ()
        {
            return clienteRepository.Obter();  
        }
        public Cliente Obter(int id)
        {
            return clienteRepository.Obter(id);
        }

        public Cliente ObterNome(string nome)
        {
            return clienteRepository.ObterNome(nome);
        }

        public Cliente Salvar(Cliente obj)
        {
            return clienteRepository.Salvar(obj);
        }


    }
}
