using Northwind.DAL.Ef.Abstract;
using Northwind.Entites;

namespace Northwind.DAL.Ef.Concrete
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {


    }
}
