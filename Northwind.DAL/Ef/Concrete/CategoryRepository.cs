using Northwind.DAL.Ef.Abstract;
using Northwind.Entites;

namespace Northwind.DAL.Ef.Concrete
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
    }
}
