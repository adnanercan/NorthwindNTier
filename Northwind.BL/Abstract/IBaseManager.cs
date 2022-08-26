using System.Linq.Expressions;

namespace Northwind.BL.Abstract
{
    public interface IBaseManager<T> where T : class
    {
        int Add(T entity);

        int Update(T entity);
        int Delete(T entity);
        T Find(int id);

        T Find(string id);

        IList<T> FindAll(Expression<Func<T, bool>> expression);

    }
}
