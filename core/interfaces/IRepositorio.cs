namespace Interface
{
    public interface IRepositorio<T>
    {
        void Add(T objeto);
        void Update(T objeto);
        void Remove(T objeto);
        void List(T objeto);
    }
}