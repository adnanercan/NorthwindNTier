using Northwind.DAL.Ef.Abstract;
using Northwind.Entites;
using System.Linq.Expressions;

namespace Northwind.DAL.Ef.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        NorthwindContext db;
        public BaseRepository()
        {
            db = new NorthwindContext();
        }
        public int Add(T entity)
        {
            db.Set<T>().Add(entity);
            return db.SaveChanges();
        }

        public int Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            return db.SaveChanges();
        }

        public T Find(int id)
        {
            return db.Set<T>().Find(id);
        }

        public T Find(string id)
        {
            return db.Set<T>().Find(id);
        }

        public T Find(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression).FirstOrDefault();
        }

        public IList<T> FindAll(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression).ToList();
        }

        public int Update(T entity)
        {
            db.Set<T>().Update(entity);
            return db.SaveChanges();
        }
    }
}
