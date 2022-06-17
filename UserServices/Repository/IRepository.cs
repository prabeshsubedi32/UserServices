using System.Linq;

namespace UserServices.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        T Find(int key);

        void Remove(int key);

        void Add(T item);
    }
}
