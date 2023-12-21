using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefsDishes.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
namespace ChefsDishes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        List<Dish> AllDishes = _context.Dishes.ToList();
        List<Chef> AllChefs = _context.Chefs.ToList();
        //ViewBag.AllOwners = _context.Chefs.Include(a => a.DishesOwned).Count;
        //int numMessages = _context.Chefs.Include(Chef => Chef.CreatedMessages).FirstOrDefault(Chef => Chef.ChefId == ChefId).CreatedMessages.Count;
        return View(AllChefs);
    }

    [HttpGet("/dishes")]
    public IActionResult Dishes()
    {
        List<Dish> DishesbyChef = _context.Dishes.Include(a => a.Creator).ToList();
        // populates each Message with its related User object (Creator)
        
        return View(DishesbyChef);
    }

    [HttpGet("/dishes/new")]
    public IActionResult AddDish()
    {
        ViewBag.AllChefs = _context.Chefs.ToList();
        // populates each Message with its related User object (Creator)
        
        return View();
    }

    [HttpGet("/chefs/new")]
    public IActionResult AddChef()
    {
        return View();
    }

    [HttpPost("/AddnewChef")]
    public IActionResult AddnewChef(Chef newChef)
    {
        if(ModelState.IsValid)
        {
            if ( DateTime.Now.Year - newChef.DateBirth.Year > 18 )
            {
                _context.Add(newChef);
                _context.SaveChanges();
                System.Console.WriteLine("New chef added successfully");
                return RedirectToAction("Index");
            }
            else 
            {
                return View("AddChef");
            }
            
        }
        else 
        {
            System.Console.WriteLine("NOT Valid new chef not added !");
            return View("AddChef");
        }
    }

    [HttpPost("/AddnewDish")]
    public IActionResult AddnewDish(Dish newDish)
    {
        if(ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            System.Console.WriteLine("New Dish added successfully");
            System.Console.WriteLine(newDish.Name);
            System.Console.WriteLine(newDish.Tastiness);
            System.Console.WriteLine(newDish.Calories);
            System.Console.WriteLine(newDish.ChefId);
            //Chef? DishCreator = _context.Chefs.FirstOrDefault(c => c.ChefId == newDish.ChefId);
            return RedirectToAction("dishes");
        }
        else 
        {
            System.Console.WriteLine("NOT Valid new Dish not added !");
            return View("AddDish");
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
