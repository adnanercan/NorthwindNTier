using Northwind.BL.Concrete;
using Northwind.Entites;
namespace Northwind.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu sekilde kullanim tercih edilmiyor
            //NorthwindContext context = new NorthwindContext();  

            ShipperManager shipperManager = new ShipperManager();

            Shipper mng = new Shipper { CompanyName = "Mng Kargo", Phone = "1234" };

            try
            {
                shipperManager.Add("Mng Kargo", "123");
            }
            catch (Exception ex)
            {

                System.Console.WriteLine(ex.Message);
            }


        }
    }
}