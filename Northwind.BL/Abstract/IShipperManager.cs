using Northwind.Entites;

namespace Northwind.BL.Abstract
{
    public interface IShipperManager : IBaseManager<Shipper>
    {

        public int Add(string ShipperName, string Phone);
    }
}
