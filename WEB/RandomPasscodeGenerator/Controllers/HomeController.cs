using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPasscodeGenerator.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscodeGenerator.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    private static Random random = new Random();

    public static string RandomString(int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public IActionResult Index()
    {
        string RandomCode = RandomString (18);

        if (HttpContext.Session.GetInt32("nbr") == null)
        {
            HttpContext.Session.SetInt32("nbr", 1);
        }
        else
        {
            int? counter = HttpContext.Session.GetInt32("nbr") +1;
            HttpContext.Session.SetInt32("nbr", (int)counter);
        }

        ViewBag.Passcode = RandomCode;
        System.Console.WriteLine(ViewBag.Passcode);
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
