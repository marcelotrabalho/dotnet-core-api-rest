using System.Collections.Generic;

namespace Interface
{
    public interface IRepositorio<T>
    {
        void Add(T objeto);
        void Update(T objeto);
        void Remove(T objeto);
        List<T> Listar(int id);
        List<T> Listar();
    }
}