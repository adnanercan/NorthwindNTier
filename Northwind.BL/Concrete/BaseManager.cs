using Northwind.BL.Abstract;
using Northwind.DAL.Ef.Abstract;
using Northwind.DAL.Ef.Concrete;
using System.Linq.Expressions;

namespace Northwind.BL.Concrete
{
    public class BaseManager<T> : IBaseManager<T> where T : class
    {

        protected IBaseRepository<T> db;
        public BaseManager()
        {
            db = new BaseRepository<T>();
        }

        public int Add(T entity)
        {
            return db.Add(entity);
        }

        public int Delete(T entity)
        {
            return db.Delete(entity);
        }

        public T Find(int id)
        {
            return db.Find(id);
        }

        public T Find(string id)
        {
            return db.Find(id);
        }

        public IList<T> FindAll(Expression<Func<T, bool>> expression)
        {
            return db.FindAll(expression);
        }

        public int Update(T entity)
        {
            return db.Update(entity);
        }
    }
}
