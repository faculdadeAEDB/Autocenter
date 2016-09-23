using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public interface IRepository<T>
    {
        List<T> Obter();
        T Obter(int id);
        T Salvar(T obj);
        T Editar(T obj);
        T Excluir(T obj);

    }
}