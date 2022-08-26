using Northwind.BL.Abstract;
using Northwind.Entites;

namespace Northwind.BL.Concrete
{
    public class ShipperManager : BaseManager<Shipper>, IShipperManager
    {
        public int Add(string ShipperName, string Phone)
        {
            var shipper = db.Find(p => p.CompanyName == ShipperName);
            if (shipper != null)
            {
                throw new Exception("Bu Firma isminde başka bir kayit var");
                return -1;
            }

            var shipper2 = db.Find(p => p.Phone == Phone);
            if (shipper2 != null)
            {
                throw new Exception("Bu telefon numarasi baska bir firmaya kaydedilmistir.");
                return -1;
            }


            return db.Add(new Shipper { CompanyName = ShipperName, Phone = Phone });
        }
    }
}
