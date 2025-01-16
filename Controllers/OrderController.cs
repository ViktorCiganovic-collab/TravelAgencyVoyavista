using TravelAgencyVoyavista.Data;
using TravelAgencyVoyavista.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Hotelbooking.Controllers
{
    [Authorize(Roles = "User")]
    public class OrderController : Controller
    {

        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Rent(int Id)
        {
            Travelpackage travelpackage = _context.Travelpackage.Where(vacationpackage => vacationpackage.TravelpackageId == Id).First();

            if (travelpackage == null || travelpackage.Availablerooms <= 0)
            {
                return RedirectToAction("Index", "Travelpackage");
            }

            return View(travelpackage);
        }

        [HttpPost]
        public IActionResult Rent(int travelpackageId, string FirstName, string LastName, string Address, int NumberOfPersons, DateTime startDate, DateTime endDate)
        {
            var vacationPackage = _context.Travelpackage.Where(p => p.TravelpackageId == travelpackageId).First();

            if (vacationPackage == null || vacationPackage.Availablerooms <= 0)
            {
                return RedirectToAction("Index", "Travelpackage");
            }

            var overlappingOrders = _context.Orders.Where(o => o.TravelpackageId == travelpackageId).Where(o => o.StartDate < endDate && o.EndDate > startDate).Count();

            if (vacationPackage.Availablerooms <= overlappingOrders)
            {
                return View("NoRoomsAvailable");
            }

            var amountOfDays = (endDate - startDate).Days;
            var totalCostofStay = amountOfDays * vacationPackage.Price;
            var totalCostForAllVisitors = totalCostofStay * NumberOfPersons;

            var newOrder = new Order
            {

                TravelpackageId = travelpackageId,
                FirstName = FirstName,
                LastName = LastName,
                Address = Address,
                numberOfPersons = NumberOfPersons,
                StartDate = startDate,
                EndDate = endDate,
                TotalCost = totalCostForAllVisitors
            };

            if (DateTime.Now >= startDate && DateTime.Now <= endDate)
            {
                vacationPackage.Availablerooms -= 1;
            }

            _context.Orders.Add(newOrder);
            _context.SaveChanges();

            return View("Confirmation", newOrder);

        }
    }
}
