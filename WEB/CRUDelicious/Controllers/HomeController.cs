using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

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

        // Get all Users
        //ViewBag.AllDishes = _context.Dishes.ToList();
    
         // Get Users with the LastName "Jefferson"
        //ViewBag.Jeffersons = _context.Users.Where(u => u.LastName == "Jefferson");

    	// Get the 5 most recently added Users
        List<Dish> lastDishes = _context.Dishes.OrderByDescending(u => u.CreatedAt).Take(5).ToList();
        //Dish oneDish = _context.Dishes.FirstOrDefault(dish => dish.DishID == DishID);
        List<Dish> AllDishes = _context.Dishes.ToList();
        ViewBag.AllDishes = _context.Dishes.OrderByDescending(u => u.CreatedAt).ToList();
        return View();
    }

    [HttpPost("/CreateDish")]
    public IActionResult CreateDish( Dish newdish)
    {   
        if(ModelState.IsValid)
        {
            _context.Add(newdish);
            _context.SaveChanges();
            System.Console.WriteLine("Valid");
            return RedirectToAction("Index");
        }
        else 
        {
            System.Console.WriteLine("NOT Valid");
            return View("NewDish");
        }

        
    }

    [HttpGet("/dish/edit/{DishID}")]
    public IActionResult DishToEdit(int DishID)
    {
        Dish DishToEdit = _context.Dishes.SingleOrDefault(dish => dish.DishID == DishID);
        return View(DishToEdit);
    }

    [HttpPost("/dish/update/{DishID}")]
    public IActionResult UpdateItem(int DishID, Dish newVersionOfDish)
    {
        Dish oldDish = _context.Dishes.FirstOrDefault(b => b.DishID == DishID);

        oldDish.Name = newVersionOfDish.Name;
        oldDish.Chef = newVersionOfDish.Chef;
        oldDish.Tastiness = newVersionOfDish.Tastiness;
        oldDish.Calories = newVersionOfDish.Calories;
        oldDish.Description = newVersionOfDish.Description;
        oldDish.UpdatedAt = newVersionOfDish.UpdatedAt;
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    [HttpGet("/dish/delete/{DishID}")]
    public IActionResult DeleteDish(int DishID)
    {
        System.Console.WriteLine("Dish not yet selected  ");
        Dish DishToDelete = _context.Dishes.SingleOrDefault(a => a.DishID == DishID);
        System.Console.WriteLine("Dish selected ");
        _context.Dishes.Remove(DishToDelete);
        _context.SaveChanges();
        System.Console.WriteLine("Dish deleted ");
        return RedirectToAction("Index");
    }

    [HttpGet("/dishform")]
    public IActionResult NewDish()
    {
        return View();
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
