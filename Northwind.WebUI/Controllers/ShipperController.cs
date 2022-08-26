using Microsoft.AspNetCore.Mvc;
using Northwind.BL.Abstract;

namespace Northwind.WebUI.Controllers
{
    public class ShipperController : Controller
    {
        private readonly IShipperManager manager;

        public ShipperController(IShipperManager manager)
        {
            this.manager = manager;
        }
        public IActionResult Index()
        {
            var shippers = manager.FindAll(p => p.ShipperId > 0);
            return View(shippers);
        }
    }
}
