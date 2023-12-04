using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;     //be sure to use your own project's namespace!
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View("Index"); 
        }

        
        // Post request example
        // This will go to "localhost:5XXX/submission"
        [HttpPost("result")]
        // Don't worry about what the form is doing for now. We'll get to those soon!
        public IActionResult FormSubmission(string Name, String Location, string Language, String Comment)
        {
            // Logic for post request here
            System.Console.WriteLine($"{Name} | {Location} | {Language} | {Comment}");
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("submission");
        } 

        [HttpGet("submission")]
        public ViewResult Submission()
        {
            return View();
        }
    }