using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
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

    [HttpPost("process")]
    public IActionResult process(User newUser)
    {

        if (ModelState.IsValid)
        {
            Console.WriteLine($"Name:  {newUser.Name}");
            Console.WriteLine($"Lacation:  {newUser.Location}");
            Console.WriteLine($"FavLanguage:  {newUser.Language}");
            // this means we passed our validation
            // then would you redirect to success
            return RedirectToAction("result");
        }
        else
        {
            //ViewBag.User = newUser;
            return View("Index");
        }
    }

    [HttpGet("result")]
    public IActionResult Result(User newUser)
    {
        Console.WriteLine($"Name:  {newUser.Name}");
        Console.WriteLine($"Lacation:  {newUser.Location}");
        Console.WriteLine($"FavLanguage:  {newUser.Language}");
        return View(newUser);
    }
    
}
