using eLibrary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace eLibrary.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
         private ICRUDBookRepository _repository;

        public HomeController(ILogger<HomeController> logger, ICRUDBookRepository repository)
        {
            _logger = logger;
            _repository = repository;

        }
        


        public IActionResult Index()
        {
            return View();
        }
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult List()
        {
            return View(_repository.FindAll());
        }
    }
}