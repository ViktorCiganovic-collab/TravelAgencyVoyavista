using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TravelAgencyVoyavista.Models;
using Microsoft.AspNetCore.Authorization;
using TravelAgencyVoyavista.Data;
using Microsoft.EntityFrameworkCore;

namespace TravelAgencyVoyavista.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ExistingOrders()
        {
            var allOrders = _context.Orders.Include(client => client.Travelpackage).ToList();

            return View(allOrders);
        }

        public IActionResult EndingToday()
        {
            var ordersEndingToday = _context.Orders.Where(o => o.EndDate == DateTime.Today).Include(o => o.Travelpackage).ToList();

            return View(ordersEndingToday);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var deletedOrder = _context.Orders.Where(o => o.OrderId == id).FirstOrDefault();

            var returnedPackage = _context.Travelpackage.Where(t => t.TravelpackageId == deletedOrder.TravelpackageId).FirstOrDefault();

            if (deletedOrder == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(deletedOrder);
            returnedPackage.Availablerooms += 1;
            _context.SaveChanges();            

            return RedirectToAction("Index"); //After succesfull deletion and update of the Orders table in db redirect admin to Index views

        }

        public IActionResult IncrementStock()
        {
            var allPackages = _context.Travelpackage.ToList();

            return View(allPackages);
        }

        [HttpPost] 
        public IActionResult Increment(int id)
        {
            var packageToIncrementStock = _context.Travelpackage.FirstOrDefault(o => o.TravelpackageId == id);

            if (packageToIncrementStock == null)
            {
                return NotFound();
            }

            packageToIncrementStock.Availablerooms += 1;
            _context.SaveChanges();

            return RedirectToAction(nameof(IncrementStock));

        }
    }
}
