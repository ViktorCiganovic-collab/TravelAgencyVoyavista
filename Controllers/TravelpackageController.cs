
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TravelAgencyVoyavista.Data;
using TravelAgencyVoyavista.Models;

public class TravelpackageController : Controller
{
    private readonly ApplicationDbContext _context;

    public TravelpackageController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var travelPackages = _context.Travelpackage.ToList();
        return View(travelPackages);
    }

    public async Task<IActionResult> Details(int id)
    {
        var packageArrangement = await _context.Travelpackage.Include(p => p.Images).FirstOrDefaultAsync(p => p.TravelpackageId == id);

        if (packageArrangement == null)
        {
            return NotFound();
        }

        return View(packageArrangement);
    }

    public async Task<IActionResult> CheckAvailability(int id)
    {
        var queriedTrip = _context.Travelpackage.Where(o => o.TravelpackageId == id).FirstOrDefault();

        return View(queriedTrip);
    }


    [HttpPost] 
    public async Task<IActionResult> CheckAvailability(int TravelpackageId, DateTime startDate, DateTime endDate)
    {
        var overlappingOrders = _context.Orders.Where(o => o.TravelpackageId == TravelpackageId && ((o.StartDate < endDate && o.EndDate > startDate) || o.StartDate == startDate || o.EndDate == endDate)).Count();

        var travelPackage = await _context.Travelpackage.Where(o => o.TravelpackageId == TravelpackageId).FirstOrDefaultAsync();
   
        if (travelPackage == null)
        {
            return NotFound();
        }

        var availableRooms = travelPackage.Availablerooms - overlappingOrders;

        var availabilityData = new 
        { 
            TravelpackageId = TravelpackageId, 
            StartDate = startDate, 
            EndDate = endDate, 
            AvailableRooms = availableRooms 
        }; 
        
        return View("AvailabilityResult", availabilityData);
    }
}


