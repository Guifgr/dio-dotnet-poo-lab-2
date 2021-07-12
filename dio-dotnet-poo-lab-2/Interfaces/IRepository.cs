using System.Collections.Generic;

namespace dio_dotnet_poo_lab_2.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T FindById(long id);
        void Insert(T entity);
        void Delete(long id);
        void Update(long id, T entity);
        long NextId();
    }
}