using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers;

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
        if (HttpContext.Session.GetString("UserName") == null)
        {
            return View();
        }
        else
        {
            return RedirectToAction("Weddings");
        }
    }


    public IActionResult Weddings()
    {
        if (HttpContext.Session.GetString("UserName") == null)
        {
            return View("Index");
        }
        else
        {
            String? username = HttpContext.Session.GetString("UserName");
            ViewBag.AllWeddings = _context.Weddings.ToList();
            System.Console.WriteLine(username);
            return View();
        }        
    }

    [HttpPost("/Register")]
    public IActionResult Register(User newUser)
    {
        if (ModelState.IsValid)
        {
            // We pass the validation
            // need to check if the email is unique
            if (_context.Users.Any(a => a.Email == newUser.Email))
            {
                // we have a problem . this user already has this email in database 
                ModelState.AddModelError("Email", "Email is already in use !");
                return View("Index");
            }

            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            _context.Add(newUser);
            _context.SaveChanges();
            HttpContext.Session.SetString("UserName", newUser.FirstName);
            return RedirectToAction("Weddings");
        }
        else
        {
            return View("Index");
        }
    }


    [HttpPost("/Login")]
    public IActionResult Login(LoginUser loginUser)
    {
        if (ModelState.IsValid)
        {
            // step 1 : find their email and if we can't find it throw an error
            User userInDB = _context.Users.FirstOrDefault(a => a.Email == loginUser.LogEmail);
            if (userInDB == null)
            {
                // there was no Email in the database
                ModelState.AddModelError("LogEmail", "Invalid Login attempt");
                return View("Index");
            }
            PasswordHasher<LoginUser> Hasher = new PasswordHasher<LoginUser>();
            var result = Hasher.VerifyHashedPassword(loginUser, userInDB.Password, loginUser.LogPassword);
            
            if (result == 0)
            {
                // this is a problem , we did not put in the database
                ModelState.AddModelError("LogEmail", "Invalid Login attempt");
                return View("Index");
            }
            else
            {
                HttpContext.Session.SetString("UserName", userInDB.FirstName);
                return RedirectToAction("Weddings");
            }
        }
        else
        {
            return View("Index");
        }
    }


    [HttpGet("logout")]
    public IActionResult DeleteSession()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
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
