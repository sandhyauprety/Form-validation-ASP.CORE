using Form_validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Form_validation.Controllers
{
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
        [HttpPost]
        public string Index(student std)
        {
            if(ModelState.IsValid)
            {
                return "Name is:" + std.Name+ "Surname is:" + std.Surname+ " Email is:" + std.Name+ "Age is:" + std.Age;


            }
            else
            {
                return "Validation Failed..";
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
}