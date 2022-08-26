using System.Linq.Expressions;

namespace Northwind.DAL.Ef.Abstract
{
    public interface IBaseRepository<T> where T : class
    {
        int Add(T entity);

        int Update(T entity);
        int Delete(T entity);
        T Find(int id);

        T Find(string id);
        T Find(Expression<Func<T, bool>> expression);
        IList<T> FindAll(Expression<Func<T, bool>> expression);

    }
}
